using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_tools;

namespace lab7;

public partial class FormOf3 : Form
{
    public FormOf3() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox1.Text)
            && int.TryParse(textBox1.Text, out int n))
        {
            var A = new double[n];

            Random r = new Random();
            array_label.Text = "";

            for (int i = 0; i < n; i++)
            {
                A[i] = r.Next(100);

                array_label.Text += A[i] + "; ";
            }

            sum_label.Text = WonderfulTools.SumElems(A).ToString();
        }
    }
}
