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
    public partial class UpdateNotice : Form
    {
        private DataAccess Da { get; set; }
        public UpdateNotice()
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
            this.dgvUpdateNotice.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtCategory.Clear();
            this.txtDate.Value = DateTime.Now;
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvUpdateNotice.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtCategory.Text) ||
                String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateNotice.SelectedRows.Count < 1)
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
                    var query = "UPDATE Notice SET Category = '" + txtCategory.Text + "',Date = '" + txtDate.Value + "',Description = '" + txtDescription.Text + "'WHERE ID = '" + txtID.Text + "'; ";
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

        private void dgvUpdateNotice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateNotice.SelectedRows != null && dgvUpdateNotice.SelectedRows.Count > 0)

            {
                string ID = dgvUpdateNotice.CurrentRow.Cells[0].Value.ToString();

                string Category = dgvUpdateNotice.CurrentRow.Cells[1].Value.ToString();

                string Date = dgvUpdateNotice.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvUpdateNotice.CurrentRow.Cells[3].Value.ToString();



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
    }
}
