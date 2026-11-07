using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab7.SubForms.SubFormsOf1.SubFormsOfString;

public partial class FormOfChange : Form
{
    List<List<double>> numbers_strings;

    ListBox main_listBox;

    public FormOfChange(List<List<double>> numbers_strings, ListBox main_listBox)
    {
        InitializeComponent();
        this.numbers_strings = numbers_strings;
        this.main_listBox = main_listBox;

        for (int i = 0; i < numbers_strings[main_listBox.SelectedIndex].Count; i++)
            elems_listBox.Items.Add(numbers_strings[main_listBox.SelectedIndex][i]);
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (elems_listBox.SelectedIndex != -1
            && !string.IsNullOrWhiteSpace(textBox.Text)
            && double.TryParse(textBox.Text, out double elem))
        {
            numbers_strings[main_listBox.SelectedIndex]
                [elems_listBox.SelectedIndex] = elem;

            elems_listBox.Items[elems_listBox.SelectedIndex] = elem.ToString();

            if (numbers_strings[main_listBox.SelectedIndex].Count > 1)
            {
                var list_string = "";

                for (int i = 0; i < numbers_strings[main_listBox.SelectedIndex].Count - 1; i++)
                    list_string += numbers_strings[main_listBox.SelectedIndex][i] + ", ";

                main_listBox.Items[main_listBox.SelectedIndex] = list_string +
                    numbers_strings[main_listBox.SelectedIndex]
                    [numbers_strings[main_listBox.SelectedIndex].Count - 1];
            }
            else
                main_listBox.Items[main_listBox.SelectedIndex] =
                    numbers_strings[main_listBox.SelectedIndex][0];
        }
    }
}
