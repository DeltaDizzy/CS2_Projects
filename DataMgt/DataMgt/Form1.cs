using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataMgt
{
    public partial class Form1 : Form
    {
        static int size = 15;
        string[] dataArray = new string[size];
        List<string> dataList = new List<string>();
        string text;
        bool ascendingSortActive = true;
        public Form1()
        {
            InitializeComponent();
            txtContent.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = txtContent.Text;
            dataArray.Append(text);
            dataList.Add(text);
            lstList.Items.Add(dataList.FindLast(s => s is string));
            txtContent.Text = String.Empty;
            txtContent.Focus();
            if (lstList.Items.Count == size)
            {
                btnSubmit.Enabled = false;
                txtContent.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstList.Items.RemoveAt(lstList.SelectedIndex);
            btnSubmit.Enabled = true;
            txtContent.Enabled = true;
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem != null)
            {
                MessageBox.Show($"You chose {lstList.SelectedItem}");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lstList.Items.RemoveAt(lstList.SelectedIndex);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            IEnumerable<string> query = from item in lstList.Items.Cast<string>().ToList()
                                        orderby item.Substring(0, 1) ascending 
                                        select item;
            lstList.Items.Clear();
            foreach (string word in query)
            {
                lstList.Items.Add(word);
            }
        }

        private void btnReverseSort_Click(object sender, EventArgs e)
        {
            IEnumerable<string> query = from item in lstList.Items.Cast<string>().ToList()
                                        orderby item.Substring(0, 1) descending
                                        select item;
            lstList.Items.Clear();
            foreach (string word in query)
            {
                lstList.Items.Add(word);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            dataList.Clear();
        }
    }
}
