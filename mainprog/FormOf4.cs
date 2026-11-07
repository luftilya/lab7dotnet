using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_tools;

namespace lab7;

public partial class FormOf4 : Form
{
    public FormOf4() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(a_textBox.Text)
            && double.TryParse(a_textBox.Text, out double a)
            && !string.IsNullOrWhiteSpace(b_textBox.Text)
            && double.TryParse(b_textBox.Text, out double b))
        {
            WonderfulTools.CalcU(a, b, out double u);
            setu_label.Text = u.ToString();

            WonderfulTools.CalcV(a, b, out double v);
            setv_label.Text = v.ToString();

            double k = 0;
            WonderfulTools.CalcK(u, v, ref k);
            setk_label.Text = k.ToString();
        }
    }
}
