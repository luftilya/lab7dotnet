using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab7.SubForms.SubFormsOf1.SubFormsOfString;

public partial class FormOfAdd : Form
{
    List<List<double>> numbers_strings;

    ListBox listBox;

    public FormOfAdd(List<List<double>> numbers_strings, ListBox listBox)
    {
        InitializeComponent();
        this.numbers_strings = numbers_strings;
        this.listBox = listBox;
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text)
            && double.TryParse(textBox.Text, out double elem))
        {
            numbers_strings[listBox.SelectedIndex].Add(elem);

            if (numbers_strings[listBox.SelectedIndex].Count > 1)
            {
                var list_string = "";

                for (int i = 0; i < numbers_strings[listBox.SelectedIndex].Count - 1; i++)
                    list_string += numbers_strings[listBox.SelectedIndex][i] + ", ";

                listBox.Items[listBox.SelectedIndex] = list_string + elem;
            } else
                listBox.Items[listBox.SelectedIndex] = elem;
        }
    }
}
