namespace lab7
{
    partial class FormOf2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOf2));
            history_label = new Label();
            apictureBox = new PictureBox();
            bpictureBox = new PictureBox();
            x_textlabel = new Label();
            y_textlabel = new Label();
            x_textBox = new TextBox();
            y_textBox = new TextBox();
            button = new Button();
            a_label = new Label();
            b_label = new Label();
            ((System.ComponentModel.ISupportInitialize)apictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpictureBox).BeginInit();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(183, 25);
            history_label.Name = "history_label";
            history_label.Size = new Size(972, 54);
            history_label.TabIndex = 0;
            history_label.Text = "Вычислить значения по заданным формулам";
            // 
            // apictureBox
            // 
            apictureBox.Image = (Image)resources.GetObject("apictureBox.Image");
            apictureBox.Location = new Point(373, 115);
            apictureBox.Name = "apictureBox";
            apictureBox.Size = new Size(299, 159);
            apictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            apictureBox.TabIndex = 1;
            apictureBox.TabStop = false;
            // 
            // bpictureBox
            // 
            bpictureBox.Image = (Image)resources.GetObject("bpictureBox.Image");
            bpictureBox.Location = new Point(718, 148);
            bpictureBox.Name = "bpictureBox";
            bpictureBox.Size = new Size(313, 62);
            bpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bpictureBox.TabIndex = 2;
            bpictureBox.TabStop = false;
            // 
            // x_textlabel
            // 
            x_textlabel.AutoSize = true;
            x_textlabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            x_textlabel.Location = new Point(67, 324);
            x_textlabel.Name = "x_textlabel";
            x_textlabel.Size = new Size(171, 41);
            x_textlabel.TabIndex = 3;
            x_textlabel.Text = "Введите x:";
            // 
            // y_textlabel
            // 
            y_textlabel.AutoSize = true;
            y_textlabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            y_textlabel.Location = new Point(67, 419);
            y_textlabel.Name = "y_textlabel";
            y_textlabel.Size = new Size(170, 41);
            y_textlabel.TabIndex = 4;
            y_textlabel.Text = "Введите y:";
            // 
            // x_textBox
            // 
            x_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            x_textBox.Location = new Point(244, 321);
            x_textBox.Name = "x_textBox";
            x_textBox.Size = new Size(404, 47);
            x_textBox.TabIndex = 5;
            // 
            // y_textBox
            // 
            y_textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            y_textBox.Location = new Point(244, 419);
            y_textBox.Name = "y_textBox";
            y_textBox.Size = new Size(404, 47);
            y_textBox.TabIndex = 6;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(521, 495);
            button.Name = "button";
            button.Size = new Size(298, 63);
            button.TabIndex = 7;
            button.Text = "ВЫЧИСЛИТЬ";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // a_label
            // 
            a_label.AutoSize = true;
            a_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            a_label.Location = new Point(746, 324);
            a_label.MinimumSize = new Size(500, 41);
            a_label.Name = "a_label";
            a_label.Size = new Size(500, 41);
            a_label.TabIndex = 8;
            a_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_label
            // 
            b_label.AutoSize = true;
            b_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            b_label.Location = new Point(746, 422);
            b_label.MinimumSize = new Size(500, 41);
            b_label.Name = "b_label";
            b_label.Size = new Size(500, 41);
            b_label.TabIndex = 9;
            b_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOf2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1330, 585);
            Controls.Add(b_label);
            Controls.Add(a_label);
            Controls.Add(button);
            Controls.Add(y_textBox);
            Controls.Add(x_textBox);
            Controls.Add(y_textlabel);
            Controls.Add(x_textlabel);
            Controls.Add(bpictureBox);
            Controls.Add(apictureBox);
            Controls.Add(history_label);
            Name = "FormOf2";
            Text = "Вычисление значений по заданным формулам";
            ((System.ComponentModel.ISupportInitialize)apictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private PictureBox apictureBox;
        private PictureBox bpictureBox;
        private Label x_textlabel;
        private Label y_textlabel;
        private TextBox x_textBox;
        private TextBox y_textBox;
        private Button button;
        private Label a_label;
        private Label b_label;
    }
}