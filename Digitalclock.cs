namespace Digitalclock
{
    partial class DigitalClock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clocklabel = new Label();
            Clocktimer = new System.Windows.Forms.Timer(components);
            redButton = new Button();
            orangeButton = new Button();
            yellowButton = new Button();
            greenButton = new Button();
            blueButton = new Button();
            styleButton = new Button();
            styleButton2 = new Button();
            styleButton3 = new Button();
            SuspendLayout();
            // 
            // clocklabel
            // 
            clocklabel.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Point);
            clocklabel.ForeColor = Color.Red;
            clocklabel.Location = new Point(12, 9);
            clocklabel.Name = "clocklabel";
            clocklabel.Size = new Size(1010, 609);
            clocklabel.TabIndex = 0;
            clocklabel.Text = "Loading...";
            clocklabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Clocktimer
            // 
            Clocktimer.Interval = 1000;
            Clocktimer.Tick += this.Clocktimer_Tick;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Location = new Point(12, 621);
            redButton.Name = "redButton";
            redButton.Size = new Size(42, 36);
            redButton.TabIndex = 1;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += this.redButton_Click;
            // 
            // orangeButton
            // 
            orangeButton.BackColor = Color.FromArgb(255, 128, 0);
            orangeButton.Location = new Point(75, 621);
            orangeButton.Name = "orangeButton";
            orangeButton.Size = new Size(42, 36);
            orangeButton.TabIndex = 2;
            orangeButton.UseVisualStyleBackColor = false;
            orangeButton.Click += this.orangeButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Yellow;
            yellowButton.Location = new Point(139, 621);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(42, 36);
            yellowButton.TabIndex = 3;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += this.yellowButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.Green;
            greenButton.Location = new Point(205, 621);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(42, 36);
            greenButton.TabIndex = 4;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += this.greenButton_Click;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.Blue;
            blueButton.Location = new Point(270, 621);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(42, 36);
            blueButton.TabIndex = 5;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += this.blueButton_Click;
            // 
            // styleButton
            // 
            styleButton.BackColor = Color.White;
            styleButton.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton.Location = new Point(330, 634);
            styleButton.Name = "styleButton";
            styleButton.Size = new Size(75, 23);
            styleButton.TabIndex = 6;
            styleButton.Text = "Style 1";
            styleButton.UseVisualStyleBackColor = false;
            styleButton.Click += this.styleButton_Click;
            // 
            // styleButton2
            // 
            styleButton2.BackColor = Color.White;
            styleButton2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton2.Location = new Point(411, 634);
            styleButton2.Name = "styleButton2";
            styleButton2.Size = new Size(75, 23);
            styleButton2.TabIndex = 7;
            styleButton2.Text = "Style 1";
            styleButton2.UseVisualStyleBackColor = false;
            styleButton2.Click += this.styleButton2_Click;
            // 
            // styleButton3
            // 
            styleButton3.BackColor = Color.White;
            styleButton3.Font = new Font("Poor Richard", 9F, FontStyle.Bold, GraphicsUnit.Point);
            styleButton3.Location = new Point(492, 634);
            styleButton3.Name = "styleButton3";
            styleButton3.Size = new Size(75, 23);
            styleButton3.TabIndex = 8;
            styleButton3.Text = "Style 1";
            styleButton3.UseVisualStyleBackColor = false;
            styleButton3.Click += this.styleButton3_Click;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1034, 671);
            Controls.Add(styleButton3);
            Controls.Add(styleButton2);
            Controls.Add(styleButton);
            Controls.Add(blueButton);
            Controls.Add(greenButton);
            Controls.Add(yellowButton);
            Controls.Add(orangeButton);
            Controls.Add(redButton);
            Controls.Add(clocklabel);
            Name = "DigitalClock";
            Text = "Digital clock";
            Load += this.DigitalClock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label clocklabel;
        private System.Windows.Forms.Timer Clocktimer;
        private Button redButton;
        private Button orangeButton;
        private Button yellowButton;
        private Button greenButton;
        private Button blueButton;
        private Button styleButton;
        private Button styleButton2;
        private Button styleButton3;
    }
}