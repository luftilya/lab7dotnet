namespace lab7
{
    partial class FormOf3
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
            n_textlabel = new Label();
            textBox1 = new TextBox();
            button = new Button();
            array_label = new Label();
            sum_textlabel = new Label();
            sum_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(39, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(736, 108);
            history_label.TabIndex = 0;
            history_label.Text = "Нахождение суммы одномерного \r\nмассива A длины N";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n_textlabel
            // 
            n_textlabel.AutoSize = true;
            n_textlabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            n_textlabel.Location = new Point(158, 155);
            n_textlabel.Name = "n_textlabel";
            n_textlabel.Size = new Size(226, 50);
            n_textlabel.TabIndex = 1;
            n_textlabel.Text = "Введите N:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(390, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 61);
            textBox1.TabIndex = 2;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(238, 238);
            button.Name = "button";
            button.Size = new Size(323, 98);
            button.TabIndex = 3;
            button.Text = "сгенерировать\r\nмассив";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // array_label
            // 
            array_label.AutoSize = true;
            array_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            array_label.Location = new Point(39, 363);
            array_label.MaximumSize = new Size(720, 190);
            array_label.MinimumSize = new Size(720, 190);
            array_label.Name = "array_label";
            array_label.Size = new Size(720, 190);
            array_label.TabIndex = 4;
            // 
            // sum_textlabel
            // 
            sum_textlabel.AutoSize = true;
            sum_textlabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            sum_textlabel.Location = new Point(97, 579);
            sum_textlabel.Name = "sum_textlabel";
            sum_textlabel.Size = new Size(358, 50);
            sum_textlabel.TabIndex = 5;
            sum_textlabel.Text = "Сумма элементов:";
            // 
            // sum_label
            // 
            sum_label.AutoSize = true;
            sum_label.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            sum_label.Location = new Point(461, 579);
            sum_label.MinimumSize = new Size(280, 50);
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(280, 50);
            sum_label.TabIndex = 6;
            // 
            // FormOf3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 658);
            Controls.Add(sum_label);
            Controls.Add(sum_textlabel);
            Controls.Add(array_label);
            Controls.Add(button);
            Controls.Add(textBox1);
            Controls.Add(n_textlabel);
            Controls.Add(history_label);
            Name = "FormOf3";
            Text = "Нахождение суммы одномерного массива A длины N";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label n_textlabel;
        private TextBox textBox1;
        private Button button;
        private Label array_label;
        private Label sum_textlabel;
        private Label sum_label;
    }
}