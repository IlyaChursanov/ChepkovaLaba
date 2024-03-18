using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace WinFormsApp2
{
    public partial class AdminForm : Form
    {
        private readonly DatabaseManager dbManager;

        public AdminForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadRepairs();
        }

        private void LoadRepairs()
        {
            DataTable repairs = dbManager.GetAllRepairs();
            dataGridViewRepairs.DataSource = repairs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewRepairs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRepairs.SelectedRows[0];
                txtEquipment.Text = selectedRow.Cells["Equipment"].Value.ToString();
                txtFaultType.Text = selectedRow.Cells["FaultType"].Value.ToString();
                txtProblemDescription.Text = selectedRow.Cells["ProblemDescription"].Value.ToString();
                txtClient.Text = selectedRow.Cells["Client"].Value.ToString();
                txtStatus.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewRepairs.CurrentRow;
            if (selectedRow != null)
            {
                // Получаем данные из TextBox
                string equipment = txtEquipment.Text;
                string faultType = txtFaultType.Text;
                string problemDescription = txtProblemDescription.Text;
                string client = txtClient.Text;
                string status = txtStatus.Text;

                // Получаем requestId из выбранной строки DataGridView
                int requestId = (int)selectedRow.Cells["RequestNumber"].Value;

                // Вызываем метод обновления данных в базе данных
                dbManager.UpdateRepair(requestId, equipment, faultType, problemDescription, client, status);

                // Обновляем DataGridView после сохранения изменений в базе данных
                LoadRepairs();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
