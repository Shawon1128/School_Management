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
    public partial class UpdateFeesDetails : Form
    {
        private DataAccess Da { get; set; }
        public UpdateFeesDetails()
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
            this.dgvUpdateFeesDetails.DataSource = ds.Tables[0];
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
            this.dgvUpdateFeesDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtStudentID.Text) || String.IsNullOrEmpty(this.txtClassID.Text) ||
                String.IsNullOrEmpty(this.txtFeesForMonth.Text)
                || String.IsNullOrEmpty(this.txtLastMonthCharges.Text) || String.IsNullOrEmpty(this.txtDiscount.Text)
                || String.IsNullOrEmpty(this.txtTotal.Text) || String.IsNullOrEmpty(this.txtPaid.Text)
                || String.IsNullOrEmpty(this.txtRemaining.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateFeesDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE FeesDetails SET ClassID = '" + txtClassID.Text + "',FeeForMonth = '" + txtFeesForMonth.Text + "',LastMonthCharges = '" + txtLastMonthCharges.Text + "',Discount = '" + txtDiscount.Text + "',Total = '" + txtTotal.Text + "',Paid = '" + txtPaid.Text + "',Remaining = '" + txtRemaining.Text + "',Date = '" + txtDate.Value + "'WHERE StudentID = '" + txtStudentID.Text + "'; ";

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

        private void dgvUpdateFeesDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateFeesDetails.SelectedRows != null && dgvUpdateFeesDetails.SelectedRows.Count > 0)

            {
                string StudentID = dgvUpdateFeesDetails.CurrentRow.Cells[0].Value.ToString();

                string ClassID = dgvUpdateFeesDetails.CurrentRow.Cells[1].Value.ToString();

                string FeeForMonth = dgvUpdateFeesDetails.CurrentRow.Cells[2].Value.ToString();

                string LastMonthCharges = dgvUpdateFeesDetails.CurrentRow.Cells[3].Value.ToString();

                string Discount = dgvUpdateFeesDetails.CurrentRow.Cells[4].Value.ToString();

                string Total = dgvUpdateFeesDetails.CurrentRow.Cells[5].Value.ToString();

                string Paid = dgvUpdateFeesDetails.CurrentRow.Cells[6].Value.ToString();

                string Remaining = dgvUpdateFeesDetails.CurrentRow.Cells[7].Value.ToString();

                string Date = dgvUpdateFeesDetails.CurrentRow.Cells[8].Value.ToString();


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

        private void UpdateFeesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_School_Management_SystemDataSet2.FeesDetails' table. You can move, or remove it, as needed.
            this.feesDetailsTableAdapter.Fill(this._School_Management_SystemDataSet2.FeesDetails);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
