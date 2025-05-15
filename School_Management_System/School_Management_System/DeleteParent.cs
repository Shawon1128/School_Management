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
    public partial class DeleteParent : Form
    {
        private DataAccess Da { get; set; }
        public DeleteParent()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from ParentDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteParent.DataSource = ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtEmail.Clear();
            this.txtCellNo.Clear();
            this.txtOccupation.Clear();
            this.txtMonthlyIncome.Clear();
            this.txtStatus.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteParent.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteParent.SelectedRows.Count < 1)

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

                var query = "delete from ParentDetails where ID = '" + txtID.Text + "';";

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
            string sql = "select * from ParentDetails where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ParentDetails where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvDeleteParent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteParent.SelectedRows != null && dgvDeleteParent.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteParent.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteParent.CurrentRow.Cells[1].Value.ToString();

                string Email = dgvDeleteParent.CurrentRow.Cells[2].Value.ToString();

                string CellNo = dgvDeleteParent.CurrentRow.Cells[3].Value.ToString();

                string Occupation = dgvDeleteParent.CurrentRow.Cells[4].Value.ToString();

                string MonthlyIncome = dgvDeleteParent.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvDeleteParent.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtEmail.Text = Email;

                txtCellNo.Text = CellNo;

                txtOccupation.Text = Occupation;

                txtMonthlyIncome.Text = MonthlyIncome;

                txtStatus.Text = Status;



            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Parent_Details p = new Parent_Details();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
