namespace Sparkler
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TxtMaxDiameterInPixels = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtNumberOfSparks = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TxtDeltaNumberOfSparks = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.TxtSparkVelocityPxPerIteration = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.TxtIterationRate = new System.Windows.Forms.TextBox();
      this.PicSparkler = new System.Windows.Forms.PictureBox();
      this.CmdGo = new System.Windows.Forms.Button();
      this.CmdExit = new System.Windows.Forms.Button();
      this.CmdStop = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.TxtSeed = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.TxtAvgSparkLengthInPixels = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.TxtSparkLengthVariance = new System.Windows.Forms.TextBox();
      this.CmdNext = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.CmbPDFType = new System.Windows.Forms.ComboBox();
      this.CmdReset = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PicSparkler)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtMaxDiameterInPixels
      // 
      this.TxtMaxDiameterInPixels.Location = new System.Drawing.Point(145, 12);
      this.TxtMaxDiameterInPixels.Name = "TxtMaxDiameterInPixels";
      this.TxtMaxDiameterInPixels.Size = new System.Drawing.Size(49, 20);
      this.TxtMaxDiameterInPixels.TabIndex = 0;
      this.TxtMaxDiameterInPixels.Text = "120";
      this.TxtMaxDiameterInPixels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Max Diameter (px)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "# of Sparks";
      // 
      // TxtNumberOfSparks
      // 
      this.TxtNumberOfSparks.Location = new System.Drawing.Point(145, 38);
      this.TxtNumberOfSparks.Name = "TxtNumberOfSparks";
      this.TxtNumberOfSparks.Size = new System.Drawing.Size(49, 20);
      this.TxtNumberOfSparks.TabIndex = 2;
      this.TxtNumberOfSparks.Text = "150";
      this.TxtNumberOfSparks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(90, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Delta # of Sparks";
      // 
      // TxtDeltaNumberOfSparks
      // 
      this.TxtDeltaNumberOfSparks.Location = new System.Drawing.Point(145, 64);
      this.TxtDeltaNumberOfSparks.Name = "TxtDeltaNumberOfSparks";
      this.TxtDeltaNumberOfSparks.Size = new System.Drawing.Size(49, 20);
      this.TxtDeltaNumberOfSparks.TabIndex = 4;
      this.TxtDeltaNumberOfSparks.Text = "0";
      this.TxtDeltaNumberOfSparks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(137, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Spark Velocity (px/iteration)";
      // 
      // TxtSparkVelocityPxPerIteration
      // 
      this.TxtSparkVelocityPxPerIteration.Location = new System.Drawing.Point(145, 90);
      this.TxtSparkVelocityPxPerIteration.Name = "TxtSparkVelocityPxPerIteration";
      this.TxtSparkVelocityPxPerIteration.Size = new System.Drawing.Size(49, 20);
      this.TxtSparkVelocityPxPerIteration.TabIndex = 6;
      this.TxtSparkVelocityPxPerIteration.Text = "70";
      this.TxtSparkVelocityPxPerIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 171);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(93, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Iteration Rate (Hz)";
      // 
      // TxtIterationRate
      // 
      this.TxtIterationRate.Location = new System.Drawing.Point(145, 168);
      this.TxtIterationRate.Name = "TxtIterationRate";
      this.TxtIterationRate.Size = new System.Drawing.Size(49, 20);
      this.TxtIterationRate.TabIndex = 8;
      this.TxtIterationRate.Text = "30";
      this.TxtIterationRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // PicSparkler
      // 
      this.PicSparkler.BackColor = System.Drawing.Color.Black;
      this.PicSparkler.Location = new System.Drawing.Point(200, 12);
      this.PicSparkler.Name = "PicSparkler";
      this.PicSparkler.Size = new System.Drawing.Size(1401, 934);
      this.PicSparkler.TabIndex = 10;
      this.PicSparkler.TabStop = false;
      // 
      // CmdGo
      // 
      this.CmdGo.Location = new System.Drawing.Point(6, 380);
      this.CmdGo.Name = "CmdGo";
      this.CmdGo.Size = new System.Drawing.Size(62, 26);
      this.CmdGo.TabIndex = 11;
      this.CmdGo.Text = "Go!";
      this.CmdGo.UseVisualStyleBackColor = true;
      this.CmdGo.Click += new System.EventHandler(this.CmdGo_Click);
      // 
      // CmdExit
      // 
      this.CmdExit.Location = new System.Drawing.Point(6, 444);
      this.CmdExit.Name = "CmdExit";
      this.CmdExit.Size = new System.Drawing.Size(62, 26);
      this.CmdExit.TabIndex = 12;
      this.CmdExit.Text = "Exit";
      this.CmdExit.UseVisualStyleBackColor = true;
      this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
      // 
      // CmdStop
      // 
      this.CmdStop.Location = new System.Drawing.Point(6, 412);
      this.CmdStop.Name = "CmdStop";
      this.CmdStop.Size = new System.Drawing.Size(62, 26);
      this.CmdStop.TabIndex = 13;
      this.CmdStop.Text = "Stop!";
      this.CmdStop.UseVisualStyleBackColor = true;
      this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 197);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(111, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "Integer Random Seed";
      // 
      // TxtSeed
      // 
      this.TxtSeed.Location = new System.Drawing.Point(145, 194);
      this.TxtSeed.Name = "TxtSeed";
      this.TxtSeed.Size = new System.Drawing.Size(49, 20);
      this.TxtSeed.TabIndex = 14;
      this.TxtSeed.Text = "0";
      this.TxtSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 119);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(135, 13);
      this.label7.TabIndex = 17;
      this.label7.Text = "Minimum Spark Length (px)";
      // 
      // TxtAvgSparkLengthInPixels
      // 
      this.TxtAvgSparkLengthInPixels.Location = new System.Drawing.Point(145, 116);
      this.TxtAvgSparkLengthInPixels.Name = "TxtAvgSparkLengthInPixels";
      this.TxtAvgSparkLengthInPixels.Size = new System.Drawing.Size(49, 20);
      this.TxtAvgSparkLengthInPixels.TabIndex = 16;
      this.TxtAvgSparkLengthInPixels.Text = "2";
      this.TxtAvgSparkLengthInPixels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 145);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(133, 13);
      this.label8.TabIndex = 19;
      this.label8.Text = "Spark Length Variance (%)";
      // 
      // TxtSparkLengthVariance
      // 
      this.TxtSparkLengthVariance.Location = new System.Drawing.Point(145, 142);
      this.TxtSparkLengthVariance.Name = "TxtSparkLengthVariance";
      this.TxtSparkLengthVariance.Size = new System.Drawing.Size(49, 20);
      this.TxtSparkLengthVariance.TabIndex = 18;
      this.TxtSparkLengthVariance.Text = "200";
      this.TxtSparkLengthVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // CmdNext
      // 
      this.CmdNext.Location = new System.Drawing.Point(103, 380);
      this.CmdNext.Name = "CmdNext";
      this.CmdNext.Size = new System.Drawing.Size(62, 26);
      this.CmdNext.TabIndex = 20;
      this.CmdNext.Text = "Next";
      this.CmdNext.UseVisualStyleBackColor = true;
      this.CmdNext.Click += new System.EventHandler(this.CmdNext_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 223);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(55, 13);
      this.label9.TabIndex = 21;
      this.label9.Text = "PDF Type";
      // 
      // CmbPDFType
      // 
      this.CmbPDFType.FormattingEnabled = true;
      this.CmbPDFType.Items.AddRange(new object[] {
            "1/r",
            "1/r-squared",
            "1/r-cubed",
            "1/sqrt(r)",
            "Uniform"});
      this.CmbPDFType.Location = new System.Drawing.Point(67, 220);
      this.CmbPDFType.Name = "CmbPDFType";
      this.CmbPDFType.Size = new System.Drawing.Size(127, 21);
      this.CmbPDFType.TabIndex = 22;
      this.CmbPDFType.Text = "1/r";
      // 
      // CmdReset
      // 
      this.CmdReset.Location = new System.Drawing.Point(103, 412);
      this.CmdReset.Name = "CmdReset";
      this.CmdReset.Size = new System.Drawing.Size(62, 26);
      this.CmdReset.TabIndex = 23;
      this.CmdReset.Text = "Reset";
      this.CmdReset.UseVisualStyleBackColor = true;
      this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1608, 953);
      this.Controls.Add(this.CmdReset);
      this.Controls.Add(this.CmbPDFType);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.CmdNext);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.TxtSparkLengthVariance);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.TxtAvgSparkLengthInPixels);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.TxtSeed);
      this.Controls.Add(this.CmdStop);
      this.Controls.Add(this.CmdExit);
      this.Controls.Add(this.CmdGo);
      this.Controls.Add(this.PicSparkler);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.TxtIterationRate);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.TxtSparkVelocityPxPerIteration);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TxtDeltaNumberOfSparks);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtNumberOfSparks);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtMaxDiameterInPixels);
      this.Name = "FrmMain";
      this.Text = "Sparkler!";
      ((System.ComponentModel.ISupportInitialize)(this.PicSparkler)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TxtMaxDiameterInPixels;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtNumberOfSparks;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TxtDeltaNumberOfSparks;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TxtSparkVelocityPxPerIteration;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox TxtIterationRate;
    private System.Windows.Forms.PictureBox PicSparkler;
    private System.Windows.Forms.Button CmdGo;
    private System.Windows.Forms.Button CmdExit;
    private System.Windows.Forms.Button CmdStop;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox TxtSeed;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox TxtAvgSparkLengthInPixels;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox TxtSparkLengthVariance;
    private System.Windows.Forms.Button CmdNext;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox CmbPDFType;
    private System.Windows.Forms.Button CmdReset;
  }
}

