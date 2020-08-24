using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ackountermann
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void newVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newVendorForm = new vendorInputForm();
            newVendorForm.Show();
        }
    }
}
