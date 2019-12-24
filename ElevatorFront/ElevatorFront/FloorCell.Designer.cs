namespace ElevatorFront
{
    public partial class FloorCell
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addUserButton = new System.Windows.Forms.Button();
            this.elevetorCellCheckbox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelForPassengers = new System.Windows.Forms.FlowLayoutPanel();
            this.ElevatorBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addUserButton.Location = new System.Drawing.Point(667, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(46, 42);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // elevetorCellCheckbox
            // 
            this.elevetorCellCheckbox.AutoSize = true;
            this.elevetorCellCheckbox.Location = new System.Drawing.Point(3, 3);
            this.elevetorCellCheckbox.Name = "elevetorCellCheckbox";
            this.elevetorCellCheckbox.Size = new System.Drawing.Size(18, 17);
            this.elevetorCellCheckbox.TabIndex = 0;
            this.elevetorCellCheckbox.UseVisualStyleBackColor = true;
            this.elevetorCellCheckbox.CheckedChanged += new System.EventHandler(this.elevetorCellCheckbox_CheckedChanged);
            // 
            // flowLayoutPanelForPassengers
            // 
            this.flowLayoutPanelForPassengers.Location = new System.Drawing.Point(27, 0);
            this.flowLayoutPanelForPassengers.Name = "flowLayoutPanelForPassengers";
            this.flowLayoutPanelForPassengers.Size = new System.Drawing.Size(634, 41);
            this.flowLayoutPanelForPassengers.TabIndex = 2;
            this.flowLayoutPanelForPassengers.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelForPassengers_Paint);
            // 
            // ElevatorBox
            // 
            this.ElevatorBox.BackColor = System.Drawing.Color.Green;
            this.ElevatorBox.Location = new System.Drawing.Point(719, -1);
            this.ElevatorBox.Name = "ElevatorBox";
            this.ElevatorBox.Size = new System.Drawing.Size(49, 44);
            this.ElevatorBox.TabIndex = 3;
            this.ElevatorBox.UseVisualStyleBackColor = false;
            this.ElevatorBox.Visible = false;
            this.ElevatorBox.Click += new System.EventHandler(this.ElevatorBox_Click);
            // 
            // FloorCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ElevatorBox);
            this.Controls.Add(this.flowLayoutPanelForPassengers);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.elevetorCellCheckbox);
            this.Name = "FloorCell";
            this.Size = new System.Drawing.Size(767, 42);
            this.Load += new System.EventHandler(this.FloorCell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.CheckBox elevetorCellCheckbox;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelForPassengers;
        public System.Windows.Forms.Button ElevatorBox;
    }
}
