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
    public partial class AdminAccess : Form
    {
        public AdminAccess()
        {
            InitializeComponent();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            StudentDetails cls = new StudentDetails();
            cls.Show();
            this.Hide();
        }

        private void btnClass_Click_1(object sender, EventArgs e)
        {
            Class_Details cls = new Class_Details();
            cls.Show();
            this.Hide();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            Parent_Details pd = new Parent_Details();
            pd.Show();
            this.Hide();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Subject_Details sd = new Subject_Details();
            sd.Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher_Details td = new Teacher_Details();
            td.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_Details ed = new Employee_Details();
            ed.Show();
            this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Expense_Details ed = new Expense_Details();
            ed.Show();
            this.Hide();
        }

        private void txtFees_Click(object sender, EventArgs e)
        {
            FeesDetails fd = new FeesDetails();
            fd.Show();
            this.Hide();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            Notice n = new Notice();
            n.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }
    }
}
