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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Login where UserName = '" + this.txtUserName.Text + "' and Password = '" + this.txtPassword.Text + "' ;";
                DataAccess d = new DataAccess();
                d.ExecuteQueryTable(sql);




                if (d.Ds.Tables[0].Rows.Count == 1)
                {
                    //string sqlLogin = "select * from Login where Role"
                    //MessageBox.Show("Valid User");
                    if (d.Ds.Tables[0].Rows[0][2].ToString().Equals("Admin"))
                    {
                        AdminAccess a = new AdminAccess();
                        a.Visible = true;
                    }
                    else if (d.Ds.Tables[0].Rows[0][2].ToString().Equals("Teacher"))
                    {
                        TeacherAccess ta = new TeacherAccess();
                        ta.Visible = true;
                    }
                    else if (d.Ds.Tables[0].Rows[0][2].ToString().Equals("Student"))
                    {
                        StudentAccess sa = new StudentAccess();
                        sa.Visible = true;
                    }
                    else
                    {
                        ParentAccess pa = new ParentAccess();
                        pa.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
                /*AdminAccess a = new AdminAccess();
                a.Show();
                this.Hide();*/
            }
            catch(Exception exc)
            {
                MessageBox.Show("An exception has occured" + exc.Message);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
