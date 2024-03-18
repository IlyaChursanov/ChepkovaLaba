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
    public partial class UserForm : Form
    {
        private DatabaseManager dbManager;

        public UserForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }







        

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserRequestsForm userRequestsForm = new UserRequestsForm("Current User"); // Предполагается, что имя текущего пользователя передается
            userRequestsForm.ShowDialog();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            string deviceName = textbox1.Text;
            string problemDescription = textbox2.Text;
            if (!string.IsNullOrEmpty(deviceName) && !string.IsNullOrEmpty(problemDescription))
            {
                dbManager.AddRepair(deviceName, "", problemDescription, "Current User", "в ожидании");

                MessageBox.Show("Заявка успешно добавлена");
                textbox1.Text = "";
                textbox2.Text = "";
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                Form1 Form1 = new Form1();
                Form1.Show();

                this.Hide();
            }


        }
    }
}
