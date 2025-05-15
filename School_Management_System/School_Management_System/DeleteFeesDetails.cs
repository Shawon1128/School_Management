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
    public partial class DeleteFeesDetails : Form
    {
        private DataAccess Da { get; set; }
        public DeleteFeesDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from FeesDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteFeesDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtStudentID.Clear();
            this.txtClassID.Clear();
            this.txtFeesForMonth.Clear();
            this.txtLastMonthCharges.Clear();
            this.txtDiscount.Clear();
            this.txtTotal.Clear();
            this.txtPaid.Clear();
            this.txtRemaining.Clear();
            this.txtDate.Value = DateTime.Now;


            this.txtSearch.Clear();
            this.dgvDeleteFeesDetails.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteFeesDetails.SelectedRows.Count < 1)

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

                var query = "delete from FeesDetails where StudentID = '" + txtStudentID.Text + "';";

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
            string sql = "select * from FeesDetails where StudentID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from FeesDetails where StudentID like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvDeleteFeesDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteFeesDetails.SelectedRows != null && dgvDeleteFeesDetails.SelectedRows.Count > 0)

            {
                string StudentID = dgvDeleteFeesDetails.CurrentRow.Cells[0].Value.ToString();

                string ClassID = dgvDeleteFeesDetails.CurrentRow.Cells[1].Value.ToString();

                string FeeForMonth = dgvDeleteFeesDetails.CurrentRow.Cells[2].Value.ToString();

                string LastMonthCharges = dgvDeleteFeesDetails.CurrentRow.Cells[3].Value.ToString();

                string Discount = dgvDeleteFeesDetails.CurrentRow.Cells[4].Value.ToString();

                string Total = dgvDeleteFeesDetails.CurrentRow.Cells[5].Value.ToString();

                string Paid = dgvDeleteFeesDetails.CurrentRow.Cells[6].Value.ToString();

                string Remaining = dgvDeleteFeesDetails.CurrentRow.Cells[7].Value.ToString();

                string Date = dgvDeleteFeesDetails.CurrentRow.Cells[8].Value.ToString();


                txtStudentID.Text = StudentID;

                txtClassID.Text = ClassID;

                txtFeesForMonth.Text = FeeForMonth;

                txtLastMonthCharges.Text = LastMonthCharges;

                txtDiscount.Text = Discount;

                txtTotal.Text = Total;

                txtPaid.Text = Paid;

                txtRemaining.Text = Remaining;

                txtDate.Text = Date;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FeesDetails f = new FeesDetails();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
