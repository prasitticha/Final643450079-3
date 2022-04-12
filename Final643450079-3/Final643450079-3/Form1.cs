using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final643450079_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPress_to_View_Information_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 1; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2]);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string List = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string List_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Price = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.textBoxProduct_Code.Text = List;
            this.textBoxDescription.Text = List_Name;
            this.textBoxPrice.Text = Price;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int Price = 0;
            int Amount = 0;
            int Discount = 0;

            Price = Convert.ToInt32(textBoxPrice.Text);
            Amount = Convert.ToInt32(textBoxAmount.Text);

            sum = Price * Amount;

            int n = dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = textBoxProduct_Code.Text;
            dataGridView2.Rows[n].Cells[1].Value = textBoxDescription.Text;
            dataGridView2.Rows[n].Cells[2].Value = sum;
        }
    }
}
