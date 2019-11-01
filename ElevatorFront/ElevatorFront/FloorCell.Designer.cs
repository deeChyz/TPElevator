namespace ElevatorFront
{
    partial class FloorCell
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
            this.elevetorCellCheckbox = new System.Windows.Forms.CheckBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addUserButton.Location = new System.Drawing.Point(711, -1);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(49, 42);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // FloorCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.elevetorCellCheckbox);
            this.Name = "FloorCell";
            this.Size = new System.Drawing.Size(759, 42);
            this.Load += new System.EventHandler(this.FloorCell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox elevetorCellCheckbox;
        private System.Windows.Forms.Button addUserButton;
    }
}
