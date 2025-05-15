using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class StudentAccess : Form
    {
        public StudentAccess()
        {
            InitializeComponent();
        }

        private void txtNotice_Click(object sender, EventArgs e)
        {
            Notice n = new Notice();
            n.Show();
            this.Hide();
        }
    }
}
