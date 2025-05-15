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
    public partial class DeleteSalary : Form
    {
        private DataAccess Da { get; set; }
        public DeleteSalary()
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
            this.dgvDeleteSalary.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtBasic.Clear();
            this.txtOthers.Clear();
            this.txtTotal.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteSalary.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteSalary.SelectedRows.Count < 1)

            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    //MessageBox.Show("No delete");
                    return;
                }

                var query = "delete from Salary where ID = '" + txtID.Text + "';";

                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)

                    MessageBox.Show("Data removed properly");

                else

                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();

                //this.ClearContent();
            }

            catch (Exception exc)

            {
                MessageBox.Show("An error has occured: " + exc.Message);
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

        private void dgvDeleteSalary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteSalary.SelectedRows != null && dgvDeleteSalary.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteSalary.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteSalary.CurrentRow.Cells[1].Value.ToString();

                string Basic = dgvDeleteSalary.CurrentRow.Cells[2].Value.ToString();

                string Others = dgvDeleteSalary.CurrentRow.Cells[3].Value.ToString();

                string Total = dgvDeleteSalary.CurrentRow.Cells[4].Value.ToString();



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
