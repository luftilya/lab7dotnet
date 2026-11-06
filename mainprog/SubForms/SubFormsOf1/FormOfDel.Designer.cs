namespace lab7.SubForms.SubFormsOf1.SubFormsOfString
{
    partial class FormOfDel
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
            elems_listBox = new ListBox();
            help_label = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(550, 54);
            history_label.TabIndex = 0;
            history_label.Text = "Удалить элемент из строки";
            // 
            // elems_listBox
            // 
            elems_listBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            elems_listBox.FormattingEnabled = true;
            elems_listBox.Location = new Point(12, 111);
            elems_listBox.Name = "elems_listBox";
            elems_listBox.Size = new Size(550, 291);
            elems_listBox.TabIndex = 1;
            // 
            // help_label
            // 
            help_label.AutoSize = true;
            help_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            help_label.Location = new Point(73, 77);
            help_label.Name = "help_label";
            help_label.Size = new Size(427, 31);
            help_label.TabIndex = 2;
            help_label.Text = "Выберите элемент строки из списка";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(164, 408);
            button.Name = "button";
            button.Size = new Size(238, 49);
            button.TabIndex = 3;
            button.Text = "Удалить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // FormOfDel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 464);
            Controls.Add(button);
            Controls.Add(help_label);
            Controls.Add(elems_listBox);
            Controls.Add(history_label);
            Name = "FormOfDel";
            Text = "Удалить элемент из строки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private ListBox elems_listBox;
        private Label help_label;
        private Button button;
    }
}