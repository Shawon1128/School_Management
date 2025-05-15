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
    public partial class FeesDetails : Form
    {
        private DataAccess Da { get; set; }
        public FeesDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            //this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from FeesDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvFeesDetails.DataSource = ds.Tables[0];
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
                        InsertFeesDetails i = new InsertFeesDetails();
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
                        UpdateFeesDetails u = new UpdateFeesDetails();
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
            try {

                if (txtInsert.Text!="")
                {
                    int x = int.Parse(txtInsert.Text);
                    if (x == 111)
                    {
                        DeleteFeesDetails d = new DeleteFeesDetails();
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            AdminAccess a = new AdminAccess();
            a.Show();
            this.Hide();
        }

        private void FeesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_School_Management_SystemDataSet.FeesDetails' table. You can move, or remove it, as needed.
            this.feesDetailsTableAdapter.Fill(this._School_Management_SystemDataSet.FeesDetails);

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
