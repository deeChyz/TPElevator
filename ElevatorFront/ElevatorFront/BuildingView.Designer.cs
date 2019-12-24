namespace ElevatorFront
{
    partial class BuildingView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.floorMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stopButton = new System.Windows.Forms.Button();
            this.floorButtonIndicatorsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peopleCounterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.peopleOnlineStats = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weightIndicator = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.peopleOnlineStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Location = new System.Drawing.Point(1214, 28);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 50);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "СТАРТ";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // floorMainPanel
            // 
            this.floorMainPanel.AutoSize = true;
            this.floorMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.floorMainPanel.Location = new System.Drawing.Point(63, 131);
            this.floorMainPanel.Name = "floorMainPanel";
            this.floorMainPanel.Size = new System.Drawing.Size(811, 76);
            this.floorMainPanel.TabIndex = 2;
            this.floorMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.floorMainPanel_Paint);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DarkRed;
            this.stopButton.Location = new System.Drawing.Point(1295, 28);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 50);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "СТОП";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // floorButtonIndicatorsBox
            // 
            this.floorButtonIndicatorsBox.AutoSize = true;
            this.floorButtonIndicatorsBox.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.floorButtonIndicatorsBox.Location = new System.Drawing.Point(880, 131);
            this.floorButtonIndicatorsBox.Name = "floorButtonIndicatorsBox";
            this.floorButtonIndicatorsBox.Size = new System.Drawing.Size(44, 76);
            this.floorButtonIndicatorsBox.TabIndex = 3;
            this.floorButtonIndicatorsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.floorButtonIndicatorsBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peopleCounterLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 38);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // peopleCounterLabel
            // 
            this.peopleCounterLabel.AutoSize = true;
            this.peopleCounterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.peopleCounterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peopleCounterLabel.Location = new System.Drawing.Point(189, 21);
            this.peopleCounterLabel.Name = "peopleCounterLabel";
            this.peopleCounterLabel.Size = new System.Drawing.Size(120, 17);
            this.peopleCounterLabel.TabIndex = 1;
            this.peopleCounterLabel.Text = "People counter: 9";
            this.peopleCounterLabel.Click += new System.EventHandler(this.peopleCounterLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // peopleOnlineStats
            // 
            this.peopleOnlineStats.Controls.Add(this.label3);
            this.peopleOnlineStats.Controls.Add(this.label4);
            this.peopleOnlineStats.Controls.Add(this.label5);
            this.peopleOnlineStats.Controls.Add(this.label6);
            this.peopleOnlineStats.Controls.Add(this.label8);
            this.peopleOnlineStats.Controls.Add(this.label9);
            this.peopleOnlineStats.Controls.Add(this.label10);
            this.peopleOnlineStats.Controls.Add(this.label11);
            this.peopleOnlineStats.Location = new System.Drawing.Point(982, 131);
            this.peopleOnlineStats.Name = "peopleOnlineStats";
            this.peopleOnlineStats.Size = new System.Drawing.Size(351, 589);
            this.peopleOnlineStats.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дмитрий ждет лифта на 6 этаже";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Валера едет на 5 этаж";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Антон был доставлен на целевой 8 этаж";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Настя едет на 1 этаж";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Зина едет на целевой 3 этаж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(3, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Дмитрий ждет лифта на 1 этаже";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Настя была доставлена на целевой 3 этаж";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(3, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Катя ждет лифта на 9 этаже";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нажатые клавиши на этажах    Количество людей на каэжом этаже";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(880, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Лифт";
            // 
            // weightIndicator
            // 
            this.weightIndicator.BackColor = System.Drawing.Color.DarkGray;
            this.weightIndicator.Location = new System.Drawing.Point(493, 33);
            this.weightIndicator.Name = "weightIndicator";
            this.weightIndicator.Size = new System.Drawing.Size(88, 29);
            this.weightIndicator.TabIndex = 8;
            this.weightIndicator.Text = "ПЕРЕВЕС";
            this.weightIndicator.UseVisualStyleBackColor = false;
            // 
            // BuildingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1372, 733);
            this.Controls.Add(this.weightIndicator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.peopleOnlineStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.floorButtonIndicatorsBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.floorMainPanel);
            this.Controls.Add(this.startButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "BuildingView";
            this.Text = "My Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.peopleOnlineStats.ResumeLayout(false);
            this.peopleOnlineStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel floorMainPanel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.FlowLayoutPanel floorButtonIndicatorsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label peopleCounterLabel;
        private System.Windows.Forms.FlowLayoutPanel peopleOnlineStats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button weightIndicator;
    }
}

