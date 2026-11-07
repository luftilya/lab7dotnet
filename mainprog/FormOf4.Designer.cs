namespace lab7
{
    partial class FormOf4
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
            a_textBox = new TextBox();
            b_textBox = new TextBox();
            u_textlabel = new Label();
            v_textlabel = new Label();
            k_label = new Label();
            button = new Button();
            setu_label = new Label();
            setv_label = new Label();
            setk_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(18, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(770, 60);
            history_label.TabIndex = 0;
            history_label.Text = "Вычислить u, v, а только затем k";
            // 
            // a_label
            // 
            a_label.AutoSize = true;
            a_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            a_label.Location = new Point(204, 86);
            a_label.Name = "a_label";
            a_label.Size = new Size(175, 41);
            a_label.TabIndex = 1;
            a_label.Text = "Введите a:";
            // 
            // b_label
            // 
            b_label.AutoSize = true;
            b_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            b_label.Location = new Point(204, 150);
            b_label.Name = "b_label";
            b_label.Size = new Size(175, 41);
            b_label.TabIndex = 2;
            b_label.Text = "Введите b:";
            // 
            // a_textBox
            // 
            a_textBox.Font = new Font("Segoe UI", 18F);
            a_textBox.Location = new Point(385, 83);
            a_textBox.Name = "a_textBox";
            a_textBox.Size = new Size(211, 47);
            a_textBox.TabIndex = 3;
            // 
            // b_textBox
            // 
            b_textBox.Font = new Font("Segoe UI", 18F);
            b_textBox.Location = new Point(385, 150);
            b_textBox.Name = "b_textBox";
            b_textBox.Size = new Size(211, 47);
            b_textBox.TabIndex = 4;
            // 
            // u_textlabel
            // 
            u_textlabel.AutoSize = true;
            u_textlabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            u_textlabel.Location = new Point(248, 294);
            u_textlabel.Name = "u_textlabel";
            u_textlabel.Size = new Size(85, 81);
            u_textlabel.TabIndex = 5;
            u_textlabel.Text = "u:";
            // 
            // v_textlabel
            // 
            v_textlabel.AutoSize = true;
            v_textlabel.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            v_textlabel.Location = new Point(248, 401);
            v_textlabel.Name = "v_textlabel";
            v_textlabel.Size = new Size(80, 81);
            v_textlabel.TabIndex = 6;
            v_textlabel.Text = "v:";
            // 
            // k_label
            // 
            k_label.AutoSize = true;
            k_label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            k_label.Location = new Point(248, 513);
            k_label.Name = "k_label";
            k_label.Size = new Size(82, 81);
            k_label.TabIndex = 7;
            k_label.Text = "k:";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(285, 213);
            button.Name = "button";
            button.Size = new Size(250, 60);
            button.TabIndex = 8;
            button.Text = "вычислить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // setu_label
            // 
            setu_label.AutoSize = true;
            setu_label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            setu_label.Location = new Point(339, 294);
            setu_label.MaximumSize = new Size(300, 81);
            setu_label.MinimumSize = new Size(300, 0);
            setu_label.Name = "setu_label";
            setu_label.Size = new Size(300, 81);
            setu_label.TabIndex = 9;
            // 
            // setv_label
            // 
            setv_label.AutoSize = true;
            setv_label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            setv_label.Location = new Point(339, 401);
            setv_label.MaximumSize = new Size(300, 81);
            setv_label.MinimumSize = new Size(300, 0);
            setv_label.Name = "setv_label";
            setv_label.Size = new Size(300, 81);
            setv_label.TabIndex = 10;
            // 
            // setk_label
            // 
            setk_label.AutoSize = true;
            setk_label.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic);
            setk_label.Location = new Point(339, 513);
            setk_label.MaximumSize = new Size(300, 81);
            setk_label.MinimumSize = new Size(300, 0);
            setk_label.Name = "setk_label";
            setk_label.Size = new Size(300, 81);
            setk_label.TabIndex = 11;
            // 
            // FormOf4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(setk_label);
            Controls.Add(setv_label);
            Controls.Add(setu_label);
            Controls.Add(button);
            Controls.Add(k_label);
            Controls.Add(v_textlabel);
            Controls.Add(u_textlabel);
            Controls.Add(b_textBox);
            Controls.Add(a_textBox);
            Controls.Add(b_label);
            Controls.Add(a_label);
            Controls.Add(history_label);
            Name = "FormOf4";
            Text = "Вычислить u, v, а только затем k";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label a_label;
        private Label b_label;
        private TextBox a_textBox;
        private TextBox b_textBox;
        private Label u_textlabel;
        private Label v_textlabel;
        private Label k_label;
        private Button button;
        private Label setu_label;
        private Label setv_label;
        private Label setk_label;
    }
}