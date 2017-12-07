namespace FunktionenTheorie
{
    partial class Main
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
            this.screenWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.screenHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.JuliaButton = new System.Windows.Forms.Button();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.minPlusLabel = new System.Windows.Forms.Label();
            this.maxPlusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minRealNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minImaginaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxRealNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxImaginaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.juliaBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.functionLabel = new System.Windows.Forms.Label();
            this.realConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.functionPlusLabel = new System.Windows.Forms.Label();
            this.imaginaryConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.maxIterLabel = new System.Windows.Forms.Label();
            this.maxIterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.screenWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRealNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImaginaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRealNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImaginaryNumericUpDown)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // screenWidthNumericUpDown
            // 
            this.screenWidthNumericUpDown.Location = new System.Drawing.Point(139, 62);
            this.screenWidthNumericUpDown.Maximum = new decimal(new int[] {
            1366,
            0,
            0,
            0});
            this.screenWidthNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.screenWidthNumericUpDown.Name = "screenWidthNumericUpDown";
            this.screenWidthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.screenWidthNumericUpDown.TabIndex = 2;
            this.screenWidthNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // screenHeightNumericUpDown
            // 
            this.screenHeightNumericUpDown.Location = new System.Drawing.Point(139, 91);
            this.screenHeightNumericUpDown.Maximum = new decimal(new int[] {
            736,
            0,
            0,
            0});
            this.screenHeightNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.screenHeightNumericUpDown.Name = "screenHeightNumericUpDown";
            this.screenHeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.screenHeightNumericUpDown.TabIndex = 3;
            this.screenHeightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(24, 62);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(24, 91);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // JuliaButton
            // 
            this.JuliaButton.Location = new System.Drawing.Point(184, 193);
            this.JuliaButton.Name = "JuliaButton";
            this.JuliaButton.Size = new System.Drawing.Size(75, 23);
            this.JuliaButton.TabIndex = 9;
            this.JuliaButton.Text = "Julia";
            this.JuliaButton.UseVisualStyleBackColor = true;
            this.JuliaButton.Click += new System.EventHandler(this.JuliaButton_Click);
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.AutoSize = true;
            this.imaginaryLabel.Location = new System.Drawing.Point(255, 132);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(9, 13);
            this.imaginaryLabel.TabIndex = 6;
            this.imaginaryLabel.Text = "i";
            // 
            // minPlusLabel
            // 
            this.minPlusLabel.AutoSize = true;
            this.minPlusLabel.Location = new System.Drawing.Point(151, 129);
            this.minPlusLabel.Name = "minPlusLabel";
            this.minPlusLabel.Size = new System.Drawing.Size(13, 13);
            this.minPlusLabel.TabIndex = 7;
            this.minPlusLabel.Text = "+";
            // 
            // maxPlusLabel
            // 
            this.maxPlusLabel.AutoSize = true;
            this.maxPlusLabel.Location = new System.Drawing.Point(151, 164);
            this.maxPlusLabel.Name = "maxPlusLabel";
            this.maxPlusLabel.Size = new System.Drawing.Size(13, 13);
            this.maxPlusLabel.TabIndex = 11;
            this.maxPlusLabel.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "i";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(22, 129);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(27, 13);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(22, 167);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 13);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max:";
            // 
            // minRealNumericUpDown
            // 
            this.minRealNumericUpDown.DecimalPlaces = 3;
            this.minRealNumericUpDown.Location = new System.Drawing.Point(65, 127);
            this.minRealNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minRealNumericUpDown.Name = "minRealNumericUpDown";
            this.minRealNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.minRealNumericUpDown.TabIndex = 4;
            this.minRealNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // minImaginaryNumericUpDown
            // 
            this.minImaginaryNumericUpDown.DecimalPlaces = 3;
            this.minImaginaryNumericUpDown.Location = new System.Drawing.Point(169, 127);
            this.minImaginaryNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minImaginaryNumericUpDown.Name = "minImaginaryNumericUpDown";
            this.minImaginaryNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.minImaginaryNumericUpDown.TabIndex = 5;
            this.minImaginaryNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // maxRealNumericUpDown
            // 
            this.maxRealNumericUpDown.DecimalPlaces = 3;
            this.maxRealNumericUpDown.Location = new System.Drawing.Point(65, 162);
            this.maxRealNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.maxRealNumericUpDown.Name = "maxRealNumericUpDown";
            this.maxRealNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.maxRealNumericUpDown.TabIndex = 6;
            this.maxRealNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // maxImaginaryNumericUpDown
            // 
            this.maxImaginaryNumericUpDown.DecimalPlaces = 3;
            this.maxImaginaryNumericUpDown.Location = new System.Drawing.Point(169, 162);
            this.maxImaginaryNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.maxImaginaryNumericUpDown.Name = "maxImaginaryNumericUpDown";
            this.maxImaginaryNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.maxImaginaryNumericUpDown.TabIndex = 7;
            this.maxImaginaryNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 231);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // juliaBackgroundWorker
            // 
            this.juliaBackgroundWorker.WorkerReportsProgress = true;
            this.juliaBackgroundWorker.WorkerSupportsCancellation = true;
            this.juliaBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.juliaBackgroundWorker_DoWork);
            this.juliaBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.juliaBackgroundWorker_ProgressChanged);
            this.juliaBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.juliaBackgroundWorker_RunWorkerCompleted);
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(27, 24);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(59, 13);
            this.functionLabel.TabIndex = 20;
            this.functionLabel.Text = "f(z) = z^2 +";
            // 
            // realConstantNumericUpDown
            // 
            this.realConstantNumericUpDown.DecimalPlaces = 3;
            this.realConstantNumericUpDown.Location = new System.Drawing.Point(92, 22);
            this.realConstantNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.realConstantNumericUpDown.Name = "realConstantNumericUpDown";
            this.realConstantNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.realConstantNumericUpDown.TabIndex = 0;
            // 
            // functionPlusLabel
            // 
            this.functionPlusLabel.AutoSize = true;
            this.functionPlusLabel.Location = new System.Drawing.Point(160, 24);
            this.functionPlusLabel.Name = "functionPlusLabel";
            this.functionPlusLabel.Size = new System.Drawing.Size(13, 13);
            this.functionPlusLabel.TabIndex = 1;
            this.functionPlusLabel.Text = "+";
            // 
            // imaginaryConstantNumericUpDown
            // 
            this.imaginaryConstantNumericUpDown.DecimalPlaces = 3;
            this.imaginaryConstantNumericUpDown.Location = new System.Drawing.Point(179, 22);
            this.imaginaryConstantNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.imaginaryConstantNumericUpDown.Name = "imaginaryConstantNumericUpDown";
            this.imaginaryConstantNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.imaginaryConstantNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "i";
            // 
            // maxIterLabel
            // 
            this.maxIterLabel.AutoSize = true;
            this.maxIterLabel.Location = new System.Drawing.Point(21, 198);
            this.maxIterLabel.Name = "maxIterLabel";
            this.maxIterLabel.Size = new System.Drawing.Size(75, 13);
            this.maxIterLabel.TabIndex = 23;
            this.maxIterLabel.Text = "Max iterations:";
            // 
            // maxIterNumericUpDown
            // 
            this.maxIterNumericUpDown.Location = new System.Drawing.Point(102, 195);
            this.maxIterNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.maxIterNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterNumericUpDown.Name = "maxIterNumericUpDown";
            this.maxIterNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.maxIterNumericUpDown.TabIndex = 8;
            this.maxIterNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.maxIterNumericUpDown);
            this.Controls.Add(this.maxIterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imaginaryConstantNumericUpDown);
            this.Controls.Add(this.functionPlusLabel);
            this.Controls.Add(this.realConstantNumericUpDown);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.maxImaginaryNumericUpDown);
            this.Controls.Add(this.maxRealNumericUpDown);
            this.Controls.Add(this.minImaginaryNumericUpDown);
            this.Controls.Add(this.minRealNumericUpDown);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxPlusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minPlusLabel);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.JuliaButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.screenHeightNumericUpDown);
            this.Controls.Add(this.screenWidthNumericUpDown);
            this.Name = "Main";
            this.Text = "FunktionenTheorie";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRealNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImaginaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRealNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImaginaryNumericUpDown)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown screenWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown screenHeightNumericUpDown;
        private System.Windows.Forms.Button JuliaButton;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.Label minPlusLabel;
        private System.Windows.Forms.Label maxPlusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.NumericUpDown minRealNumericUpDown;
        private System.Windows.Forms.NumericUpDown minImaginaryNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxRealNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxImaginaryNumericUpDown;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.ComponentModel.BackgroundWorker juliaBackgroundWorker;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.NumericUpDown realConstantNumericUpDown;
        private System.Windows.Forms.Label functionPlusLabel;
        private System.Windows.Forms.NumericUpDown imaginaryConstantNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxIterLabel;
        private System.Windows.Forms.NumericUpDown maxIterNumericUpDown;
    }
}

