namespace lab7.SubForms.SubFormsOf1.SubFormsOfString
{
    partial class FormOfChange
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
            button = new Button();
            textBox = new TextBox();
            elems_listBox = new ListBox();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 61);
            history_label.Name = "history_label";
            history_label.Size = new Size(526, 54);
            history_label.TabIndex = 0;
            history_label.Text = "Изменить элемент в строке";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(143, 207);
            button.Name = "button";
            button.Size = new Size(227, 65);
            button.TabIndex = 1;
            button.Text = "Изменить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(12, 129);
            textBox.Name = "textBox";
            textBox.Size = new Size(526, 57);
            textBox.TabIndex = 2;
            textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // elems_listBox
            // 
            elems_listBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            elems_listBox.FormattingEnabled = true;
            elems_listBox.Location = new Point(594, 63);
            elems_listBox.Name = "elems_listBox";
            elems_listBox.Size = new Size(299, 209);
            elems_listBox.TabIndex = 3;
            // 
            // FormOfChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 339);
            Controls.Add(elems_listBox);
            Controls.Add(textBox);
            Controls.Add(button);
            Controls.Add(history_label);
            Name = "FormOfChange";
            Text = "Изменить элемент в строке";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Button button;
        private TextBox textBox;
        private ListBox elems_listBox;
    }
}