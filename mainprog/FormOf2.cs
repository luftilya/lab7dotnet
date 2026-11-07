using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_tools;

namespace lab7;

public partial class FormOf2 : Form
{
    public FormOf2() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(x_textBox.Text)
            && double.TryParse(x_textBox.Text, out double x)
            && !string.IsNullOrWhiteSpace(y_textBox.Text)
            && double.TryParse(y_textBox.Text, out double y))
        {
            a_label.Text = WonderfulTools.CalcFuncA(x, y).ToString();
            b_label.Text = WonderfulTools.CalcFuncB(x, y).ToString();
        }
    }
}
