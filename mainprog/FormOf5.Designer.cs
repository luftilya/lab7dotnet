namespace lab7
{
    partial class FormOf5
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
            a_label = new Label();
            b_label = new Label();
            x1_label = new Label();
            x1_textBox = new TextBox();
            y1_textBox = new TextBox();
            y1_label = new Label();
            x2_textBox = new TextBox();
            x2_label = new Label();
            y2_textBox = new TextBox();
            y2_label = new Label();
            button = new Button();
            answer_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(69, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(667, 120);
            history_label.TabIndex = 0;
            history_label.Text = "Проверить, лежат ли точки \r\nв одной четверти плоскости";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // a_label
            // 
            a_label.AutoSize = true;
            a_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            a_label.Location = new Point(171, 166);
            a_label.Name = "a_label";
            a_label.Size = new Size(166, 50);
            a_label.TabIndex = 1;
            a_label.Text = "Точка A";
            // 
            // b_label
            // 
            b_label.AutoSize = true;
            b_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            b_label.Location = new Point(456, 166);
            b_label.Name = "b_label";
            b_label.Size = new Size(164, 50);
            b_label.TabIndex = 2;
            b_label.Text = "Точка B";
            // 
            // x1_label
            // 
            x1_label.AutoSize = true;
            x1_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            x1_label.Location = new Point(121, 228);
            x1_label.Name = "x1_label";
            x1_label.Size = new Size(49, 41);
            x1_label.TabIndex = 3;
            x1_label.Text = "X:";
            // 
            // x1_textBox
            // 
            x1_textBox.Font = new Font("Segoe UI", 18F);
            x1_textBox.Location = new Point(171, 228);
            x1_textBox.Name = "x1_textBox";
            x1_textBox.Size = new Size(166, 47);
            x1_textBox.TabIndex = 4;
            // 
            // y1_textBox
            // 
            y1_textBox.Font = new Font("Segoe UI", 18F);
            y1_textBox.Location = new Point(171, 281);
            y1_textBox.Name = "y1_textBox";
            y1_textBox.Size = new Size(166, 47);
            y1_textBox.TabIndex = 6;
            // 
            // y1_label
            // 
            y1_label.AutoSize = true;
            y1_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            y1_label.Location = new Point(121, 281);
            y1_label.Name = "y1_label";
            y1_label.Size = new Size(47, 41);
            y1_label.TabIndex = 5;
            y1_label.Text = "Y:";
            // 
            // x2_textBox
            // 
            x2_textBox.Font = new Font("Segoe UI", 18F);
            x2_textBox.Location = new Point(456, 225);
            x2_textBox.Name = "x2_textBox";
            x2_textBox.Size = new Size(166, 47);
            x2_textBox.TabIndex = 8;
            // 
            // x2_label
            // 
            x2_label.AutoSize = true;
            x2_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            x2_label.Location = new Point(406, 225);
            x2_label.Name = "x2_label";
            x2_label.Size = new Size(49, 41);
            x2_label.TabIndex = 7;
            x2_label.Text = "X:";
            // 
            // y2_textBox
            // 
            y2_textBox.Font = new Font("Segoe UI", 18F);
            y2_textBox.Location = new Point(456, 281);
            y2_textBox.Name = "y2_textBox";
            y2_textBox.Size = new Size(166, 47);
            y2_textBox.TabIndex = 10;
            // 
            // y2_label
            // 
            y2_label.AutoSize = true;
            y2_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            y2_label.Location = new Point(406, 281);
            y2_label.Name = "y2_label";
            y2_label.Size = new Size(47, 41);
            y2_label.TabIndex = 9;
            y2_label.Text = "Y:";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(292, 334);
            button.Name = "button";
            button.Size = new Size(210, 61);
            button.TabIndex = 11;
            button.Text = "проверить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // answer_label
            // 
            answer_label.AutoSize = true;
            answer_label.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            answer_label.Location = new Point(18, 408);
            answer_label.MinimumSize = new Size(765, 0);
            answer_label.Name = "answer_label";
            answer_label.Size = new Size(765, 81);
            answer_label.TabIndex = 12;
            answer_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOf5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(answer_label);
            Controls.Add(button);
            Controls.Add(y2_textBox);
            Controls.Add(y2_label);
            Controls.Add(x2_textBox);
            Controls.Add(x2_label);
            Controls.Add(y1_textBox);
            Controls.Add(y1_label);
            Controls.Add(x1_textBox);
            Controls.Add(x1_label);
            Controls.Add(b_label);
            Controls.Add(a_label);
            Controls.Add(history_label);
            Name = "FormOf5";
            Text = "Проверить, лежат ли точки в одной четверти плоскости";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label a_label;
        private Label b_label;
        private Label x1_label;
        private TextBox x1_textBox;
        private TextBox y1_textBox;
        private Label y1_label;
        private TextBox x2_textBox;
        private Label x2_label;
        private TextBox y2_textBox;
        private Label y2_label;
        private Button button;
        private Label answer_label;
    }
}