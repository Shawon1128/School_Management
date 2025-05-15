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
    public partial class UpdateSalary : Form
    {
        private DataAccess Da { get; set; }
        public UpdateSalary()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Salary;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvUpdateSalary.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtBasic.Clear();
            this.txtOthers.Clear();
            this.txtTotal.Clear();

            this.txtSearch.Clear();
            this.dgvUpdateSalary.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtBasic.Text)
                || String.IsNullOrEmpty(this.txtOthers.Text)
                || String.IsNullOrEmpty(this.txtTotal.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateSalary.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Plaese select a Row first to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to change?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    var query = "UPDATE Salary SET Name = '" + txtName.Text + "',Basic = '" + txtBasic.Text + "',Others = '" + txtOthers.Text + "',Total = '" + txtTotal.Text + "'WHERE ID = '" + txtID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    MessageBox.Show("Data updated Properly");

                    this.PopulateGridView();

                    //this.ClearContent();

                }

                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Salary where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Salary where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvUpdateSalary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateSalary.SelectedRows != null && dgvUpdateSalary.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateSalary.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateSalary.CurrentRow.Cells[1].Value.ToString();

                string Basic = dgvUpdateSalary.CurrentRow.Cells[2].Value.ToString();

                string Others = dgvUpdateSalary.CurrentRow.Cells[3].Value.ToString();

                string Total = dgvUpdateSalary.CurrentRow.Cells[4].Value.ToString();



                txtName.Text = Name;

                txtID.Text = ID;

                txtBasic.Text = Basic;

                txtOthers.Text = Others;

                txtTotal.Text = Total;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
