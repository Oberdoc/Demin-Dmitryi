using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шефDataSet.продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.шефDataSet.продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шефDataSet.книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.шефDataSet.книга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шефDataSet.виды_блюд". При необходимости она может быть перемещена или удалена.
            this.виды_блюдTableAdapter.Fill(this.шефDataSet.виды_блюд);

        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            string selectString =
       "Name Like '%" + textBox1.Text.Trim() + "%'";

            DataRowCollection allRows =
                ((DataTable)dataGridView2.DataSource).Rows;

            DataRow[] searchedRows =
                ((DataTable)dataGridView2.DataSource).
                    Select(selectString);

            int rowIndex = allRows.IndexOf(searchedRows[0]);

            dataGridView2.CurrentCell =
                dataGridView2[0, rowIndex];  

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // сохранения данных 
            this.книгаTableAdapter.Update(this.шефDataSet.книга);
            this.виды_блюдTableAdapter.Update(this.шефDataSet.виды_блюд);
            this.продуктыTableAdapter.Update(this.шефDataSet.продукты);
        }




        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //переменная для получения результата работы информ окна 
            DialogResult DR = MessageBox.Show("Запись будет удалена!\nПродолжить?",
                "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            //Если пользователь выбрал Отмена (Cancel)
            if (DR == DialogResult.Cancel)
                e.Cancel = true;
            //пользователь нажал (OK) запись удаляется
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //переменная для получения результата работы информ окна 
            DialogResult DR = MessageBox.Show("Запись будет удалена!\nПродолжить?",
                "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            //Если пользователь выбрал Отмена (Cancel)
            if (DR == DialogResult.Cancel)
                e.Cancel = true;
            //пользователь нажал (OK) запись удаляется
        }


        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //переменная для получения результата работы информ окна 
            DialogResult DR = MessageBox.Show("Запись будет удалена!\nПродолжить?",
                "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            //Если пользователь выбрал Отмена (Cancel)
            if (DR == DialogResult.Cancel)
                e.Cancel = true;
            //пользователь нажал (OK) запись удаляется
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}

        
    
