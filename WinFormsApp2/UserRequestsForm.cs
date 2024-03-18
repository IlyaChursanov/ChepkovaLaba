using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserRequestsForm : Form
    {
        private readonly DatabaseManager dbManager;
        private readonly string username; // Объявляем переменную username

        public UserRequestsForm(string username) // Добавляем username как параметр конструктора
        {
            InitializeComponent();
            this.username = username; // Сохраняем переданное значение в переменной username
            dbManager = new DatabaseManager();
            LoadUserRequests();
        }

        private void LoadUserRequests()
        {
            DataTable userRequests = dbManager.GetAllRepairsForUser(username);

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Time", "Дата");
            dataGridView1.Columns.Add("Device", "Устройство");
            dataGridView1.Columns.Add("Faulttype", "Тип неисправности");
            dataGridView1.Columns.Add("Problem", "Проблема");
            dataGridView1.Columns.Add("Status", "Статус");

            foreach (DataRow row in userRequests.Rows)
            {
                dataGridView1.Rows.Add(
                    row["DateAdded"],
                    row["Equipment"],
                    row["Faulttype"],
                    row["ProblemDescription"],
                    row["Status"]
                );
            }
        }
    }
}
