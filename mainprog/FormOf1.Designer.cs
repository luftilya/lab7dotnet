namespace lab7
{
    partial class FormOf1
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
            components = new System.ComponentModel.Container();
            hystory_label = new Label();
            find_button = new Button();
            listBox = new ListBox();
            find_label = new Label();
            add_button = new Button();
            del_button = new Button();
            contextMenuStrip = new ContextMenuStrip(components);
            перейтиВОкноСтрокиToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // hystory_label
            // 
            hystory_label.AutoSize = true;
            hystory_label.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            hystory_label.Location = new Point(214, 9);
            hystory_label.Name = "hystory_label";
            hystory_label.Size = new Size(816, 100);
            hystory_label.TabIndex = 0;
            hystory_label.Text = "Найти кол-во строк, у которых среднее \r\nарифметическое элементов меньше нуля";
            hystory_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // find_button
            // 
            find_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            find_button.Location = new Point(73, 188);
            find_button.Name = "find_button";
            find_button.Size = new Size(286, 63);
            find_button.TabIndex = 1;
            find_button.Text = "Найти!";
            find_button.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(805, 129);
            listBox.Name = "listBox";
            listBox.Size = new Size(413, 250);
            listBox.TabIndex = 3;
            // 
            // find_label
            // 
            find_label.AutoSize = true;
            find_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            find_label.Location = new Point(66, 288);
            find_label.MinimumSize = new Size(300, 54);
            find_label.Name = "find_label";
            find_label.Size = new Size(300, 54);
            find_label.TabIndex = 2;
            find_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add_button
            // 
            add_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            add_button.Location = new Point(590, 154);
            add_button.Name = "add_button";
            add_button.Size = new Size(183, 90);
            add_button.TabIndex = 4;
            add_button.Text = "добавить\r\nстроку";
            add_button.UseVisualStyleBackColor = true;
            // 
            // del_button
            // 
            del_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            del_button.Location = new Point(590, 263);
            del_button.Name = "del_button";
            del_button.Size = new Size(183, 90);
            del_button.TabIndex = 5;
            del_button.Text = "удалить\r\nстроку";
            del_button.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { перейтиВОкноСтрокиToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(240, 28);
            // 
            // перейтиВОкноСтрокиToolStripMenuItem
            // 
            перейтиВОкноСтрокиToolStripMenuItem.Name = "перейтиВОкноСтрокиToolStripMenuItem";
            перейтиВОкноСтрокиToolStripMenuItem.Size = new Size(239, 24);
            перейтиВОкноСтрокиToolStripMenuItem.Text = "Перейти в окно строки";
            // 
            // FormOf1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 402);
            Controls.Add(del_button);
            Controls.Add(add_button);
            Controls.Add(listBox);
            Controls.Add(find_label);
            Controls.Add(find_button);
            Controls.Add(hystory_label);
            Name = "FormOf1";
            Text = "Количество строк, у которых среднее арифметическое элементов меньше нуля";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hystory_label;
        private Button find_button;
        private Label help_label;
        private ListBox listBox;
        private Label find_label;
        private Button add_button;
        private Button del_button;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem перейтиВОкноСтрокиToolStripMenuItem;
    }
}