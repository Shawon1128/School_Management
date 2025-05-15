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
    public partial class DeleteNotice : Form
    {
        private DataAccess Da { get; set; }
        public DeleteNotice()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Notice;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteNotice.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtCategory.Clear();
            this.txtDate.Value = DateTime.Now;
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteNotice.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteNotice.SelectedRows.Count < 1)

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

                var query = "delete from Notice where ID = '" + txtID.Text + "';";

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

        private void dgvDeleteNotice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteNotice.SelectedRows != null && dgvDeleteNotice.SelectedRows.Count > 0)

            {
                string ID = dgvDeleteNotice.CurrentRow.Cells[0].Value.ToString();

                string Category = dgvDeleteNotice.CurrentRow.Cells[1].Value.ToString();

                string Date = dgvDeleteNotice.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvDeleteNotice.CurrentRow.Cells[3].Value.ToString();



                txtID.Text = ID;

                txtCategory.Text = Category;

                txtDate.Text = Date;

                txtDescription.Text = Description;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Notice n = new Notice();
            n.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteNotice_Load(object sender, EventArgs e)
        {

        }
    }
}
