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
    public partial class Notice : Form
    {
        private DataAccess Da { get; set; }
        public Notice()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            //this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Notice;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvNotice.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtInsert.Text != "")
                {
                    int x = int.Parse(txtInsert.Text);
                    if (x == 111)
                    {
                        InsertNotice i = new InsertNotice();
                        i.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please provide proper code.");
                    }
                }
                else
                {
                    MessageBox.Show("You can't go for next operation");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An exception has occured: " + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtInsert.Text != "")
                {
                    int x = int.Parse(txtInsert.Text);
                    if (x == 111)
                    {
                        UpdateNotice u = new UpdateNotice();
                        u.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please provide proper code.");
                    }
                }
                else
                {
                    MessageBox.Show("You can't go for next operation");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An exception has occured: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtInsert.Text != "")
                {
                    int x = int.Parse(txtInsert.Text);
                    if (x == 111)
                    {
                        DeleteNotice d = new DeleteNotice();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please provide proper code.");
                    }
                }
                else
                {
                    MessageBox.Show("You can't go for next operation");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An exception has occured: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Notice where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Notice where Category like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvClassDetails_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            AdminAccess a = new AdminAccess();
            a.Show();
            this.Hide();
        }
    }
}
