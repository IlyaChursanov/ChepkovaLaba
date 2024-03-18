using Npgsql;
using System.Windows.Forms;
using System;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Host=localhost;Username=postgres;Password=1111;Database=Fakel";

        public Form1()
        {
            InitializeComponent();
        }
        private void OpenDashboard(string role)
        {
            switch (role)
            {
                case "user":
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    break;
                case "manager":
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                    break;
                case "admin":
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                default:
                    MessageBox.Show("Неизвестная роль пользователя");
                    break;
            }

            Hide();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string role = result.ToString();
                        OpenDashboard(role);
                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

