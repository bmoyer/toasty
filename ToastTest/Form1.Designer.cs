namespace ToastTest
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tempControlGroupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setTempLabel = new System.Windows.Forms.Label();
            this.actualTempDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setTempDisplay = new System.Windows.Forms.TextBox();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.tempNumBox = new System.Windows.Forms.NumericUpDown();
            this.setTempButton = new System.Windows.Forms.Button();
            this.pidControlGroupbox = new System.Windows.Forms.GroupBox();
            this.kdLabel = new System.Windows.Forms.Label();
            this.kiLabel = new System.Windows.Forms.Label();
            this.kpLabel = new System.Windows.Forms.Label();
            this.kdNumBox = new System.Windows.Forms.NumericUpDown();
            this.kiNumBox = new System.Windows.Forms.NumericUpDown();
            this.kpNumBox = new System.Windows.Forms.NumericUpDown();
            this.setPidButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.comPortList = new System.Windows.Forms.ListBox();
            this.plotGroupbox = new System.Windows.Forms.GroupBox();
            this.samplingRateNumBox = new System.Windows.Forms.NumericUpDown();
            this.setSamplingRateButton = new System.Windows.Forms.Button();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.clearPlotButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timerButton = new System.Windows.Forms.ToolStripButton();
            this.profilesButton = new System.Windows.Forms.ToolStripButton();
            this.tempControlGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumBox)).BeginInit();
            this.pidControlGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.plotGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempControlGroupbox
            // 
            this.tempControlGroupbox.Controls.Add(this.label3);
            this.tempControlGroupbox.Controls.Add(this.setTempLabel);
            this.tempControlGroupbox.Controls.Add(this.actualTempDisplay);
            this.tempControlGroupbox.Controls.Add(this.label2);
            this.tempControlGroupbox.Controls.Add(this.label1);
            this.tempControlGroupbox.Controls.Add(this.setTempDisplay);
            this.tempControlGroupbox.Controls.Add(this.degreesLabel);
            this.tempControlGroupbox.Controls.Add(this.tempNumBox);
            this.tempControlGroupbox.Controls.Add(this.setTempButton);
            this.tempControlGroupbox.Location = new System.Drawing.Point(12, 45);
            this.tempControlGroupbox.Name = "tempControlGroupbox";
            this.tempControlGroupbox.Size = new System.Drawing.Size(104, 91);
            this.tempControlGroupbox.TabIndex = 0;
            this.tempControlGroupbox.TabStop = false;
            this.tempControlGroupbox.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actual:";
            // 
            // setTempLabel
            // 
            this.setTempLabel.AutoSize = true;
            this.setTempLabel.Location = new System.Drawing.Point(14, 49);
            this.setTempLabel.Name = "setTempLabel";
            this.setTempLabel.Size = new System.Drawing.Size(26, 13);
            this.setTempLabel.TabIndex = 7;
            this.setTempLabel.Text = "Set:";
            // 
            // actualTempDisplay
            // 
            this.actualTempDisplay.Enabled = false;
            this.actualTempDisplay.Location = new System.Drawing.Point(47, 68);
            this.actualTempDisplay.Name = "actualTempDisplay";
            this.actualTempDisplay.Size = new System.Drawing.Size(24, 20);
            this.actualTempDisplay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "°C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // setTempDisplay
            // 
            this.setTempDisplay.Enabled = false;
            this.setTempDisplay.Location = new System.Drawing.Point(47, 46);
            this.setTempDisplay.Name = "setTempDisplay";
            this.setTempDisplay.Size = new System.Drawing.Size(24, 20);
            this.setTempDisplay.TabIndex = 3;
            // 
            // degreesLabel
            // 
            this.degreesLabel.AutoSize = true;
            this.degreesLabel.Location = new System.Drawing.Point(50, 22);
            this.degreesLabel.Name = "degreesLabel";
            this.degreesLabel.Size = new System.Drawing.Size(18, 13);
            this.degreesLabel.TabIndex = 2;
            this.degreesLabel.Text = "°C";
            // 
            // tempNumBox
            // 
            this.tempNumBox.DecimalPlaces = 1;
            this.tempNumBox.Location = new System.Drawing.Point(9, 20);
            this.tempNumBox.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.tempNumBox.Name = "tempNumBox";
            this.tempNumBox.Size = new System.Drawing.Size(43, 20);
            this.tempNumBox.TabIndex = 1;
            // 
            // setTempButton
            // 
            this.setTempButton.Location = new System.Drawing.Point(69, 17);
            this.setTempButton.Name = "setTempButton";
            this.setTempButton.Size = new System.Drawing.Size(31, 23);
            this.setTempButton.TabIndex = 0;
            this.setTempButton.Text = "Set";
            this.setTempButton.UseVisualStyleBackColor = true;
            this.setTempButton.Click += new System.EventHandler(this.setTempButton_Click);
            // 
            // pidControlGroupbox
            // 
            this.pidControlGroupbox.Controls.Add(this.kdLabel);
            this.pidControlGroupbox.Controls.Add(this.kiLabel);
            this.pidControlGroupbox.Controls.Add(this.kpLabel);
            this.pidControlGroupbox.Controls.Add(this.kdNumBox);
            this.pidControlGroupbox.Controls.Add(this.kiNumBox);
            this.pidControlGroupbox.Controls.Add(this.kpNumBox);
            this.pidControlGroupbox.Controls.Add(this.setPidButton);
            this.pidControlGroupbox.Location = new System.Drawing.Point(12, 139);
            this.pidControlGroupbox.Name = "pidControlGroupbox";
            this.pidControlGroupbox.Size = new System.Drawing.Size(104, 121);
            this.pidControlGroupbox.TabIndex = 1;
            this.pidControlGroupbox.TabStop = false;
            this.pidControlGroupbox.Text = "PID Control";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Location = new System.Drawing.Point(6, 70);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(23, 13);
            this.kdLabel.TabIndex = 7;
            this.kdLabel.Text = "Kd:";
            // 
            // kiLabel
            // 
            this.kiLabel.AutoSize = true;
            this.kiLabel.Location = new System.Drawing.Point(6, 44);
            this.kiLabel.Name = "kiLabel";
            this.kiLabel.Size = new System.Drawing.Size(19, 13);
            this.kiLabel.TabIndex = 6;
            this.kiLabel.Text = "Ki:";
            // 
            // kpLabel
            // 
            this.kpLabel.AutoSize = true;
            this.kpLabel.Location = new System.Drawing.Point(6, 22);
            this.kpLabel.Name = "kpLabel";
            this.kpLabel.Size = new System.Drawing.Size(23, 13);
            this.kpLabel.TabIndex = 5;
            this.kpLabel.Text = "Kp:";
            // 
            // kdNumBox
            // 
            this.kdNumBox.Location = new System.Drawing.Point(32, 68);
            this.kdNumBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.kdNumBox.Name = "kdNumBox";
            this.kdNumBox.Size = new System.Drawing.Size(44, 20);
            this.kdNumBox.TabIndex = 4;
            // 
            // kiNumBox
            // 
            this.kiNumBox.Location = new System.Drawing.Point(31, 42);
            this.kiNumBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.kiNumBox.Name = "kiNumBox";
            this.kiNumBox.Size = new System.Drawing.Size(45, 20);
            this.kiNumBox.TabIndex = 3;
            // 
            // kpNumBox
            // 
            this.kpNumBox.Location = new System.Drawing.Point(31, 19);
            this.kpNumBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.kpNumBox.Name = "kpNumBox";
            this.kpNumBox.Size = new System.Drawing.Size(45, 20);
            this.kpNumBox.TabIndex = 2;
            // 
            // setPidButton
            // 
            this.setPidButton.Location = new System.Drawing.Point(9, 94);
            this.setPidButton.Name = "setPidButton";
            this.setPidButton.Size = new System.Drawing.Size(43, 23);
            this.setPidButton.TabIndex = 1;
            this.setPidButton.Text = "Set";
            this.setPidButton.UseVisualStyleBackColor = true;
            this.setPidButton.Click += new System.EventHandler(this.setPidButton_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(122, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(698, 354);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.comPortList);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::ToastTest.Properties.Resources.refresh_button1;
            this.refreshButton.InitialImage = null;
            this.refreshButton.Location = new System.Drawing.Point(76, 95);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(22, 22);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 94);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(70, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comPortList
            // 
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(6, 19);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(77, 69);
            this.comPortList.TabIndex = 0;
            // 
            // plotGroupbox
            // 
            this.plotGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plotGroupbox.Controls.Add(this.samplingRateNumBox);
            this.plotGroupbox.Controls.Add(this.setSamplingRateButton);
            this.plotGroupbox.Controls.Add(this.samplingRateLabel);
            this.plotGroupbox.Controls.Add(this.clearPlotButton);
            this.plotGroupbox.Location = new System.Drawing.Point(826, 45);
            this.plotGroupbox.Name = "plotGroupbox";
            this.plotGroupbox.Size = new System.Drawing.Size(104, 121);
            this.plotGroupbox.TabIndex = 4;
            this.plotGroupbox.TabStop = false;
            this.plotGroupbox.Text = "Plot";
            // 
            // samplingRateNumBox
            // 
            this.samplingRateNumBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.samplingRateNumBox.Location = new System.Drawing.Point(6, 42);
            this.samplingRateNumBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.samplingRateNumBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.samplingRateNumBox.Name = "samplingRateNumBox";
            this.samplingRateNumBox.Size = new System.Drawing.Size(43, 20);
            this.samplingRateNumBox.TabIndex = 11;
            this.samplingRateNumBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // setSamplingRateButton
            // 
            this.setSamplingRateButton.Location = new System.Drawing.Point(55, 38);
            this.setSamplingRateButton.Name = "setSamplingRateButton";
            this.setSamplingRateButton.Size = new System.Drawing.Size(32, 23);
            this.setSamplingRateButton.TabIndex = 10;
            this.setSamplingRateButton.Text = "Set";
            this.setSamplingRateButton.UseVisualStyleBackColor = true;
            this.setSamplingRateButton.Click += new System.EventHandler(this.setSamplingRateButton_Click);
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.AutoSize = true;
            this.samplingRateLabel.Location = new System.Drawing.Point(2, 22);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(96, 13);
            this.samplingRateLabel.TabIndex = 8;
            this.samplingRateLabel.Text = "Sampling rate (ms):";
            // 
            // clearPlotButton
            // 
            this.clearPlotButton.Location = new System.Drawing.Point(0, 71);
            this.clearPlotButton.Name = "clearPlotButton";
            this.clearPlotButton.Size = new System.Drawing.Size(62, 23);
            this.clearPlotButton.TabIndex = 0;
            this.clearPlotButton.Text = "Clear Plot";
            this.clearPlotButton.UseVisualStyleBackColor = true;
            this.clearPlotButton.Click += new System.EventHandler(this.clearPlotButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilesButton,
            this.timerButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 28);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timerButton
            // 
            this.timerButton.AutoSize = false;
            this.timerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerButton.Image = global::ToastTest.Properties.Resources.Time_Timer_icon;
            this.timerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(70, 25);
            this.timerButton.Text = "00:00";
            this.timerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timerButton.ToolTipText = "Countdown Timer";
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // profilesButton
            // 
            this.profilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.profilesButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilesButton.Image = ((System.Drawing.Image)(resources.GetObject("profilesButton.Image")));
            this.profilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profilesButton.Name = "profilesButton";
            this.profilesButton.Size = new System.Drawing.Size(71, 25);
            this.profilesButton.Text = "Profiles...";
            this.profilesButton.Click += new System.EventHandler(this.profilesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.plotGroupbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pidControlGroupbox);
            this.Controls.Add(this.tempControlGroupbox);
            this.MinimumSize = new System.Drawing.Size(16, 416);
            this.Name = "Form1";
            this.Text = "ToastGhost";
            this.tempControlGroupbox.ResumeLayout(false);
            this.tempControlGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumBox)).EndInit();
            this.pidControlGroupbox.ResumeLayout(false);
            this.pidControlGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.plotGroupbox.ResumeLayout(false);
            this.plotGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tempControlGroupbox;
        private System.Windows.Forms.NumericUpDown tempNumBox;
        private System.Windows.Forms.Button setTempButton;
        private System.Windows.Forms.GroupBox pidControlGroupbox;
        private System.Windows.Forms.Button setPidButton;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.Label kiLabel;
        private System.Windows.Forms.Label kpLabel;
        private System.Windows.Forms.NumericUpDown kdNumBox;
        private System.Windows.Forms.NumericUpDown kiNumBox;
        private System.Windows.Forms.NumericUpDown kpNumBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox comPortList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.TextBox setTempDisplay;
        private System.Windows.Forms.TextBox actualTempDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label setTempLabel;
        private System.Windows.Forms.GroupBox plotGroupbox;
        private System.Windows.Forms.Button clearPlotButton;
        private System.Windows.Forms.Button setSamplingRateButton;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.NumericUpDown samplingRateNumBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton timerButton;
        private System.Windows.Forms.ToolStripButton profilesButton;
    }
}

