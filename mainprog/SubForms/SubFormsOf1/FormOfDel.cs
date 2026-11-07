using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab7.SubForms.SubFormsOf1.SubFormsOfString
{
    public partial class FormOfDel : Form
    {
        List<List<double>> numbers_strings;

        ListBox main_listBox;

        public FormOfDel(List<List<double>> numbers_strings, ListBox main_listBox)
        {
            InitializeComponent();
            this.numbers_strings = numbers_strings;
            this.main_listBox = main_listBox;

            for (int i = 0; i < numbers_strings[main_listBox.SelectedIndex].Count; i++)
                elems_listBox.Items.Add(numbers_strings[main_listBox.SelectedIndex][i]);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (elems_listBox.SelectedIndex != -1)
            {
                numbers_strings[main_listBox.SelectedIndex].RemoveAt(elems_listBox.SelectedIndex);

                elems_listBox.Items.RemoveAt(elems_listBox.SelectedIndex);

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
                this.Close();
            }
        }
    }
}
