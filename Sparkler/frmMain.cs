using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiResTimer;

namespace Sparkler
{
  public partial class FrmMain : Form
  {
    //private static volatile bool _isFinished;  TBD Note the way that this boolean is declared.
    Stopwatch _Stopwatch = new Stopwatch();
    HighResolutionTimer _Timer;
    Random _Rng;
    ClsSparkler _Sparkler;
    Graphics _G;  // TBD May not be necessary; may be able to use CreateGraphics() as needed, below.

    public FrmMain()
    {
      InitializeComponent();
      InitializeTimer();
      _G = PicSparkler.CreateGraphics();
    }

    private void InitializeTimer()
    {
      //Console.WriteLine($"IsHighResolution = {HighResolutionTimer.IsHighResolution}");
      //Console.WriteLine($"Tick time length = {HighResolutionTimer.TickLength} [ms]");
      // UseHighPriorityThread = true, sets the execution thread to ThreadPriority.Highest.  
      // It doesn't provide any precision gain in most of the cases and may do things worse for other threads. 
      // It is suggested to do some studies before setting it true
      _Timer = new HighResolutionTimer(30.0f) // in msec
      {
        UseHighPriorityThread = false
      };
      _Timer.Elapsed += Timer_Elapsed;

    }

    private void InitializeRandomNumberGenerator()
    {
      // Initialize the random number generator.  If seed = 0 (or is defined incorrectly) 
      //   then let the system determine the initial seed.
      bool seedokay = int.TryParse(TxtSeed.Text, out int seed);
      if (seedokay)
      {
        if (seed != 0)
        {
          _Rng = new Random(seed);
        }
        else
        {
          _Rng = new Random();
        }
      }
      else
      {
        _Rng = new Random();
      }
    }

    private ClsSparkler CreateSparkler(int originx, int originy)
    {
      bool diameterokay = int.TryParse(TxtMaxDiameterInPixels.Text, out int diameter);
      if (!diameterokay)
      {
        MessageBox.Show("Diameter (in pixels) must be an integer > 0");
        return (null);
      }
      bool numsparksokay = int.TryParse(TxtNumberOfSparks.Text, out int numsparks);
      if (!numsparksokay)
      {
        MessageBox.Show("Number of sparks must be an integer > 0");
        return (null);
      }
      bool sparkdeltaokay = int.TryParse(TxtDeltaNumberOfSparks.Text, out int sparkdelta);
      if (!sparkdeltaokay)
      {
        MessageBox.Show("Delta # of sparks must be an integer > 0");
        return (null);
      }
      bool sparkvelocityokay = int.TryParse(TxtSparkVelocityPxPerIteration.Text, out int sparkvelocity);
      if (!sparkvelocityokay)
      {
        MessageBox.Show("Spark velocity (in pixels/sec) must be an integer > 0");
        return (null);
      }
      bool sparklengthokay = int.TryParse(TxtAvgSparkLengthInPixels.Text, out int sparklength);
      if (!sparklengthokay)
      {
        MessageBox.Show("Spark length (in pixels) must be an integer > 0");
        return (null);
      }
      bool sparklengthvarianceokay = double.TryParse(TxtSparkLengthVariance.Text, out double sparklengthvariance);
      if (!sparklengthvarianceokay)
      {
        MessageBox.Show("Spark length variance (% of total length) must be a real number between 0 and 100");
        return (null);
      }
      bool iterationrateokay = int.TryParse(TxtIterationRate.Text, out int iterationrate);
      if (!iterationrateokay)
      {
        MessageBox.Show("Iteration rate (refreshes/sec) must be an integer > 0");
        return (null);
      }

      int pdftype = Math.Max(0, CmbPDFType.SelectedIndex);     
      ClsSparkler sparkler = new ClsSparkler(_Rng, new Point(originx, originy), diameter, numsparks, sparkdelta, sparkvelocity, sparklength, sparklengthvariance, iterationrate, pdftype);

      return (sparkler);
    }

    private void Timer_Elapsed(object sender, HighResolutionTimerElapsedEventArgs e)
    {
      CmdNext_Click(sender, e);
    }

    private void CmdGo_Click(object sender, EventArgs e)
    {

      InitializeRandomNumberGenerator();

      int originx = 10; // PicSparkler.Width / 2;
      int originy = PicSparkler.Height / 2;
      Graphics g = PicSparkler.CreateGraphics();
      g.DrawLine(Pens.White, new Point(originx, originy), new Point(originx + 5000, originy + 1000));


      // TBD Create and draw ONE sparkler
      _Sparkler = CreateSparkler(originx, originy);
      for (int i = 0; i < _Sparkler._SparkList.Count; i++)
      {
        _Sparkler.DrawSpark(_G, i);
      }
      _Sparkler.AddLine(new Point(originx, originy), new Point(originx + 5000, originy + 1000));

      CmdGo.Enabled = false;

      // Initialize, then start the timer.
      //InitializeTimer();
      _Timer.Start();
    }

    private void CmdStop_Click(object sender, EventArgs e)
    {
      _Timer.Stop();
    }

    private void CmdExit_Click(object sender, EventArgs e)
    {
      // Stop the timer (if it was ever instantiated)
      if (_Timer != null)
      {
        _Timer.Stop();
      }
      Application.Exit();
    }

    private void CmdNext_Click(object sender, EventArgs e)
    {
      // TBD - This is to check that we can wipe out the current sparks and replace them 
      //  with the next sparks
      // Separating the erasing from the iterating ONLY works for low spark counts (150 seems to be okay).
      //  A large number of sparks displays an oscillating core area.
      // However, the separation makes it easy to move the origin.

      const int XINCREMENT = 4;

      for (int i = 0; i < _Sparkler._SparkList.Count; i++)
      {
        _Sparkler.EraseSpark(_G, i);
      }

      // Here is where we move the sparkler's origin

      Point origin = _Sparkler.Origin;
      if (origin.X < PicSparkler.Width - XINCREMENT)
      {
        _Sparkler.IncrementOrigin(XINCREMENT, 0);
      } else
      {
        origin.X = 0;
        _Sparkler.Origin = origin;
      }


      for (int i = 0; i < _Sparkler._SparkList.Count; i++)
      {
        _Sparkler.IterateSpark(_G, i);
      }
    }

    private void CmdReset_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < _Sparkler._SparkList.Count; i++)
      {
        _Sparkler.EraseSpark(_G, i);
      }
      _Sparkler._SparkList.Clear();
      CmdStop_Click(sender, e);
      CmdGo_Click(sender, e);
    }
  }

  public class ClsSparkler
  {
    public List<ClsSpark> _SparkList;
    Point _Origin;
    private readonly int _SparklerDiameter;
    private readonly int _NumSparks;
    private readonly int _SparkDelta;
    private readonly int _SparkVelocity;
    private readonly int _SparkLength;
    private readonly double _SparkLengthVariance;
    private readonly double _IterationRate;
    private readonly int _PDFType;
    private readonly Random _Rng;
    private readonly List<ClsLineClass> _LineList;

    public ClsSparkler (Random rng, Point origin, int diameter, int numsparks, int sparkdelta, int sparkvelocity, int sparklength, double sparklengthvariance, double iterationrate, int pdftype)
    {
      _Origin = origin;
      _SparklerDiameter = diameter;
      _NumSparks = numsparks;
      _SparkDelta = sparkdelta;
      _SparkVelocity = sparkvelocity;
      _SparkLength = sparklength;
      _SparkLengthVariance = sparklengthvariance;
      _IterationRate = iterationrate;
      _PDFType = pdftype;
      _Rng = rng;
      _LineList = new List<ClsLineClass>();

      // Create sparks based on the data passed into this sparkler.
      _SparkList = new List<ClsSpark>();
      for (int i = 0; i < _NumSparks; i++)
      {
        ClsSpark spark = CreateSpark(_SparklerDiameter, _SparkLength, _SparkLengthVariance, Color.White, _PDFType);
        _SparkList.Add(spark);
      }
    }

    public Point Origin
    {
      get => _Origin;
      set { _Origin = value; }
    }

    private ClsSpark CreateSpark(int sparklerDiameter, int sparkLength, double sparkLengthVariance, Color color, int pdftype)
    {
      int radius = SparklerPSD(sparklerDiameter, pdftype);
      double theta = 2.0 * Math.PI * _Rng.NextDouble();
      int length = (int)((double)sparkLength * (1.0 + (_Rng.NextDouble() * sparkLengthVariance / 100.0)));
      ClsSpark spark = new ClsSpark(radius, theta, length, color);
      return (spark);
    }

    public void DrawSpark(Graphics g, int sparknumber)
    {
      _SparkList[sparknumber].DrawSpark(g, _Origin);
    }

    public void EraseSpark(Graphics g, int sparknumber)
    {
      _SparkList[sparknumber].EraseSpark(g, _Origin);
    }

    public void IterateSpark(Graphics g, int sparknumber)
    {
      int newradius = _SparkList[sparknumber].IterateSpark(_SparkVelocity);
      if (newradius > _SparklerDiameter / 2)
      {
        Color color = CreateRandomWhite(_Rng);
        _SparkList[sparknumber] = CreateSpark(_SparklerDiameter, _SparkLength, _SparkLengthVariance, color, _PDFType);
      }
      _SparkList[sparknumber].DrawSpark(g, _Origin);
    }

    private Color CreateRandomWhite(Random rng)
    {
      // "Random White" is essentially RGB(223,223,223) +/- a random 32 additional color values, just to give the white a little color

      const int COLOR_VARIANCE = 64;
      int basevalue = 255 - COLOR_VARIANCE / 2;
      Color color = new Color();
      color = Color.FromArgb(
        basevalue + (int)(COLOR_VARIANCE * (_Rng.NextDouble() - 0.5)),
        basevalue + (int)(COLOR_VARIANCE * (_Rng.NextDouble() - 0.5)),
        basevalue + (int)(COLOR_VARIANCE * (_Rng.NextDouble() - 0.5)));
      return (color);
    }

    private int SparklerPSD(int diameter, int pdftype)
    {
      // Returns a random integer value - the spark's starting radius - based on the computed probability distribution function.
      //   PDF is based on wanting to concentrate the sparks nearer the center of the sparkler.
      //   PDF = 1/Ran() will do this.
      // Because this is a reciprocal function the resulting pdf could range greatly.  
      //   Limit the value to the range [0,100], then normalize.
      double pdf = 0;
      switch (pdftype)
      {
        case 0: // 1/r distribution
          pdf = 10;
          while (pdf > 1.0)
          {
            pdf = 0.01 * (1.0 / _Rng.NextDouble() - 1.0);
          }
          break;
        case 1: // 1/r*r distribution
          pdf = 10;
          while (pdf > 1.0)
          {
            double r = _Rng.NextDouble();
            pdf = 0.01 * (1.0 / (r*r) - 1.0);
          }
          break;
        case 2: // 1/r*r*r distribution
          pdf = 10;
          while (pdf > 1.0)
          {
            double r = _Rng.NextDouble();
            pdf = 0.01 * (1.0 / (r * r * r) - 1.0);
          }
          break;
        case 3: // 1/sqrt(r) distribution
          pdf = 0.01 * (1.0 / Math.Sqrt(_Rng.NextDouble()) - 1.0);
          break;
        case 4: // uniform distribution
          pdf = _Rng.NextDouble();
          break;
        default:
          pdf = _Rng.NextDouble();
          break;
      }
      // Return a value normalized to the diameter of the sparkler.
      int startingradius = (int)(((double)diameter / 2.0) * pdf);
      return (startingradius);
    }

    internal void IncrementOrigin(int NumPixelsX, int NumPixelsY)
    {
      // Moves the origin by the specified number of pixels
      _Origin.X += NumPixelsX;
      _Origin.Y += NumPixelsY;
    }

    public void AddLine(Point startpoint, Point endpoint)
    {
      // Add a line that the sparkler will follow.  Multiple entries in this list 
      //   will be followed sequentially, up to the end of the list.
      // TBD - We need an indicator (or an event) indicating that the end of the line has been hit.
      _LineList.Add(new ClsLineClass(startpoint, endpoint));
    }

    // This (internal only) class defines lines on which the sparkler will move.
    private class ClsLineClass
    {
      private readonly Point _StartPoint;
      private readonly Point _EndPoint;

      public ClsLineClass (Point startpoint, Point endpoint)
      {
        _StartPoint = new Point(startpoint.X, startpoint.Y);
        _EndPoint = new Point(endpoint.X, endpoint.Y);
      }
    }
  }

  public class ClsSpark
  {
    int _R;
    private readonly double _Theta;
    private readonly int _Length;
    private readonly Color _Color;

    public ClsSpark (int startingradius, double theta, int length, Color color)
    {
      _R = startingradius;
      _Theta = theta;
      _Length = length;
      _Color = color;
    }

    public void DrawSpark(Graphics g, Point origin)
    {
      DrawSpark(g, origin, _Color);
    }

    public void DrawSpark(Graphics g, Point origin, Color color)
    {
      // determine beginning and end points for this spark (in pixels)
      double startx = (double)origin.X + _R * Math.Cos(_Theta);
      double endx = (double)origin.X + (_R + _Length) * Math.Cos(_Theta);

      double starty = (double)origin.Y + _R * Math.Sin(_Theta);
      double endy = (double)origin.Y + (_R + _Length) * Math.Sin(_Theta);

      g.DrawLine(new Pen(color), new Point((int)startx, (int)starty), new Point((int)endx, (int)endy));
    }

    public void EraseSpark(Graphics g, Point origin)
    {
      DrawSpark(g, origin, Color.Black);
    }

    public int IterateSpark(int velocity)
    {
      _R = _R + velocity;
      return (_R);
    }
  }
}
