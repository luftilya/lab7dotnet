using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_tools;
using Point = wonderful_tools.Point;

namespace lab7;

public partial class FormOf5 : Form
{
    public FormOf5()
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(x1_textBox.Text)
            && double.TryParse(x1_textBox.Text, out double x1)
            && !string.IsNullOrWhiteSpace(y1_textBox.Text)
            && double.TryParse(y1_textBox.Text, out double y1)
            && !string.IsNullOrWhiteSpace(x2_textBox.Text)
            && double.TryParse(x2_textBox.Text, out double x2)
            && !string.IsNullOrWhiteSpace(y2_textBox.Text)
            && double.TryParse(y2_textBox.Text, out double y2))
        {
            if (Point.IsOneQuater(new Point(x1, y1), new Point(x2, y2)))
                answer_label.Text = "Да, в одной";
            else
                answer_label.Text = "Нет, в разных";
        }
    }
}
