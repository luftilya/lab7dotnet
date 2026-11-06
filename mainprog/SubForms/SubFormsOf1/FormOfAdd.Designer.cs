namespace lab7.SubForms.SubFormsOf1.SubFormsOfString
{
    partial class FormOfAdd
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
            history_label = new Label();
            textBox = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(619, 60);
            history_label.TabIndex = 0;
            history_label.Text = "Добавить элемент в строку";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(12, 86);
            textBox.Name = "textBox";
            textBox.Size = new Size(619, 65);
            textBox.TabIndex = 1;
            textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(194, 167);
            button.Name = "button";
            button.Size = new Size(255, 73);
            button.TabIndex = 2;
            button.Text = "Добавить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // FormOfAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 263);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(history_label);
            Name = "FormOfAdd";
            Text = "Добавить элемент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private TextBox textBox;
        private Button button;
    }
}