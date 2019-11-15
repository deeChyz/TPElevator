namespace ElevatorFront
{
    partial class FloorIndicator
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
            this.floorIndicatorCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // floorIndicatorCheckbox
            // 
            this.floorIndicatorCheckbox.AutoSize = true;
            this.floorIndicatorCheckbox.Location = new System.Drawing.Point(12, 12);
            this.floorIndicatorCheckbox.Name = "floorIndicatorCheckbox";
            this.floorIndicatorCheckbox.Size = new System.Drawing.Size(18, 17);
            this.floorIndicatorCheckbox.TabIndex = 0;
            this.floorIndicatorCheckbox.UseVisualStyleBackColor = true;
            // 
            // FloorIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.floorIndicatorCheckbox);
            this.Name = "FloorIndicator";
            this.Size = new System.Drawing.Size(44, 42);
            this.Load += new System.EventHandler(this.FloorIndicator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox floorIndicatorCheckbox;
    }
}
