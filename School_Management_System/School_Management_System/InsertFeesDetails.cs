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
    public partial class InsertFeesDetails : Form
    {
        private DataAccess Da { get; set; }
        public InsertFeesDetails()
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
            this.dgvInsertFeesDetails.DataSource = ds.Tables[0];
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
            this.dgvInsertFeesDetails.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtStudentID.Text) || String.IsNullOrEmpty(this.txtClassID.Text) ||
                String.IsNullOrEmpty(this.txtFeesForMonth.Text)
                || String.IsNullOrEmpty(this.txtLastMonthCharges.Text) || String.IsNullOrEmpty(this.txtDiscount.Text)
                || String.IsNullOrEmpty(this.txtTotal.Text) || String.IsNullOrEmpty(this.txtPaid.Text)
                || String.IsNullOrEmpty(this.txtRemaining.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from FeesDetails where StudentID = '" + txtStudentID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO FeesDetails (StudentID, ClassID, FeeForMonth, LastMonthCharges,Discount, Total, Paid, Remaining, Date)VALUES('" + txtStudentID.Text + "', '" + txtClassID.Text + "', '" + txtFeesForMonth.Text + "', '" + txtLastMonthCharges.Text + "', '" + txtDiscount.Text + "', '" + txtTotal.Text + "', '" + txtPaid.Text + "', '" + txtRemaining.Text + "', '" + txtDate.Value + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Fees?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (d == DialogResult.No)

                            return;

                        int a = Da.ExecuteDMLQuery(sql);

                        if (a > 0)
                        {
                            MessageBox.Show("Successfully added!");

                            this.PopulateGridView();

                            //this.ClearContent();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add");
                        }
                    }
                    this.PopulateGridView();
                    this.ClearContent();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured!", ex.Message);
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

        private void dgvInsertFeesDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertFeesDetails.SelectedRows != null && dgvInsertFeesDetails.SelectedRows.Count > 0)

            {
                string StudentID = dgvInsertFeesDetails.CurrentRow.Cells[0].Value.ToString();

                string ClassID = dgvInsertFeesDetails.CurrentRow.Cells[1].Value.ToString();

                string FeeForMonth = dgvInsertFeesDetails.CurrentRow.Cells[2].Value.ToString();

                string LastMonthCharges = dgvInsertFeesDetails.CurrentRow.Cells[3].Value.ToString();

                string Discount = dgvInsertFeesDetails.CurrentRow.Cells[4].Value.ToString();

                string Total = dgvInsertFeesDetails.CurrentRow.Cells[5].Value.ToString();

                string Paid = dgvInsertFeesDetails.CurrentRow.Cells[6].Value.ToString();

                string Remaining = dgvInsertFeesDetails.CurrentRow.Cells[7].Value.ToString();

                string Date = dgvInsertFeesDetails.CurrentRow.Cells[8].Value.ToString();


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

        private void InsertFeesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_School_Management_SystemDataSet1.FeesDetails' table. You can move, or remove it, as needed.
            this.feesDetailsTableAdapter.Fill(this._School_Management_SystemDataSet1.FeesDetails);

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
    }
}
