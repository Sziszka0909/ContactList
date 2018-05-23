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
    public partial class AllContact : Form
    {
        public AllContact()
        {
            InitializeComponent();
        }

        private void AllContact_Load(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            Dictionary<string, string> contacts = client.showContact();
            for(int i = 0; i < contacts.Count; i++)
            {
                ContactNames.Text += contacts.Keys.ElementAt(i) + "\n";
                ContactNumbers.Text += contacts.Values.ElementAt(i) + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kisokos kisokos = new Kisokos();
            kisokos.Show();
        }
    }
}
