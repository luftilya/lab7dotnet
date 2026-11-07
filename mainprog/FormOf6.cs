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

public partial class FormOf6 : Form
{
    public FormOf6()
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        double? x1 = null, y1 = null,
                x2 = null, y2 = null,
                x3 = null, y3 = null;

        if (!string.IsNullOrWhiteSpace(x1_textBox.Text)
            && double.TryParse(x1_textBox.Text, out double t))
            x1 = t;

        if (!string.IsNullOrWhiteSpace(y1_textBox.Text)
            && double.TryParse(y1_textBox.Text, out t))
            y1 = t;

        if (!string.IsNullOrWhiteSpace(x2_textBox.Text)
            && double.TryParse(x2_textBox.Text, out t))
            x2 = t;

        if (!string.IsNullOrWhiteSpace(y2_textBox.Text)
            && double.TryParse(y2_textBox.Text, out t))
            y2 = t;

        if (!string.IsNullOrWhiteSpace(x3_textBox.Text)
            && double.TryParse(x3_textBox.Text, out t))
            x3 = t;

        if (!string.IsNullOrWhiteSpace(y3_textBox.Text)
            && double.TryParse(y3_textBox.Text, out t))
            y3 = t;

        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);
        Point p3 = new Point(x3, y3);

        Point.SquareOfTriangle(p1, p2, p3, out double S);
        Point.PerimetrOfTriangle(p1, p2, p3, out double P);

        s_label.Text = "S = " + S;
        p_label.Text = "P = " + P;
    }
}
