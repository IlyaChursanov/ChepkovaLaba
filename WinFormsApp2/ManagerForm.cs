using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace WinFormsApp2
{
    public partial class ManagerForm : Form
    {
        private readonly DatabaseManager dbManager;
        public ManagerForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LoadRepairs();
        }

        private void LoadRepairs()
        {
            DataTable repairs = dbManager.GetAllRepairs();

            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("Tag", "Номер");
            dataGridView2.Columns.Add("Time", "Дата");
            dataGridView2.Columns.Add("Device", "Устройство");
            dataGridView2.Columns.Add("FaultType", "Тип неисправности");
            dataGridView2.Columns.Add("Problem", "Проблема");
            dataGridView2.Columns.Add("Client", "Клиент");
            dataGridView2.Columns.Add("Status", "Статус");

            foreach (DataRow row in repairs.Rows)
            {
                dataGridView2.Rows.Add(
                    row["RequestNumber"],
                    row["DateAdded"],
                    row["Equipment"],
                    row["FaultType"],
                    row["ProblemDescription"],
                    row["Client"],
                    row["Status"]
                );
            }

            dataGridView2.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value != null && cell.Value.ToString().Length > 15)
                    {
                        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = cell.Value.ToString();
                    }
                }
            };
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    txtFaultType.Text = selectedRow.Cells["FaultType"].Value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int requestId = Convert.ToInt32(selectedRow.Cells["Tag"].Value);
                string faultType = txtFaultType.Text;
                dbManager.UpdateRepairStatus(requestId, "в работе", faultType);
                LoadRepairs();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int requestId = Convert.ToInt32(selectedRow.Cells["Tag"].Value);
                string faultType = txtFaultType.Text;
                dbManager.UpdateRepairStatus(requestId, "выполнено", faultType);
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