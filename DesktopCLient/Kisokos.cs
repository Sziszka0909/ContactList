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
    public partial class Kisokos : Form
    {
        public Kisokos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.Text = "";
            MyServiceClient client = new MyServiceClient();
            string contactName = addContactName.Text;
            string contactNumber = addContactNumber.Text;
            message.Text = client.addContact(contactName, contactNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            message.Text = "";
            MyServiceClient client = new MyServiceClient();
            string deleteName = deleteContact.Text;
            message.Text = client.deleteContact(deleteName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            client.Logout(Form1.Username);
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllContact allContact = new AllContact();
            this.Hide();
            allContact.Show();
        }
    }
}
