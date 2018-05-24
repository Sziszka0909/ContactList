using DesktopCLient.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCLient
{
    public partial class Form1 : Form
    {
        public static string Username;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            PopUpForm popUpForm = new PopUpForm();
            Username = UsernameField.Text;
            string Password = PasswordField.Text;
            bool Login = client.Login(Username, Password);
            if (Login == false)
            {
                popUpForm.Show();
                UsernameField.Text = "";
                PasswordField.Text = "";
            } else
            {
                this.Hide();
                Kisokos kisokos = new Kisokos();
                kisokos.Show();
            }
        }
    }
}
