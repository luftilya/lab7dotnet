using lab7.SubForms.SubFormsOf1.SubFormsOfString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab7;

public partial class FormOf1 : Form
{
    List<List<double>> numbers_strings = new List<List<double>>();

    public FormOf1()
    {
        InitializeComponent();
        listBox.ContextMenuStrip = contextMenuStrip;
    }

    private void add_button_Click(object sender, EventArgs e)
    {
        numbers_strings.Add(new List<double>());
        listBox.Items.Add("Пустая строка");
    }

    private void del_button_Click(object sender, EventArgs e)
    {
        int index = listBox.SelectedIndex;

        if (index != -1)
        {
            numbers_strings.RemoveAt(index);
            listBox.Items.RemoveAt(index);
        }
    }

    private void listBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            int i = listBox.IndexFromPoint(e.Location);

            if (i != -1)
                listBox.SelectedIndex = i;
        }
    }

    private void add_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex != -1)
            new FormOfAdd(numbers_strings, listBox).ShowDialog();
    }

    private void change_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex != -1
            && numbers_strings[listBox.SelectedIndex].Count > 0)
            new FormOfChange(numbers_strings, listBox).ShowDialog();
    }

    private void del_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex != -1
            && numbers_strings[listBox.SelectedIndex].Count > 0)
            new FormOfDel(numbers_strings, listBox).ShowDialog();
    }

    private void find_button_Click(object sender, EventArgs e)
    {
        var count = 0;

        if (numbers_strings.Count > 0)
            for (int i = 0; i < numbers_strings.Count; i++)
                if (numbers_strings[i].Count > 0
                    && numbers_strings[i].Average() < 0)
                    ++count;

        find_label.Text = count.ToString();
    }
}
