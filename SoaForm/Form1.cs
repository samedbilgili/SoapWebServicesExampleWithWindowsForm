using SoaForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServisimSoapClient client = new ServiceReference1.ServisimSoapClient();

            dataGridView1.DataSource = client.GetProduct
                 (
               new UserDetails()
               {
                   userName = "Samed",
                   password = "Bilgili"
               }
                );
        }
    }
}
