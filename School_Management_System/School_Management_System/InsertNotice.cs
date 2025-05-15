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
    public partial class InsertNotice : Form
    {
        private DataAccess Da { get; set; }
        public InsertNotice()
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
            this.dgvInsertNotice.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtCategory.Clear();
            this.txtDate.Value = DateTime.Now;
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvInsertNotice.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtCategory.Text) ||
                String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Notice where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Notice (ID, Category, Date, Description)VALUES('" + txtID.Text + "','"+txtCategory+"', '" + txtDate.Value + "', '" + txtDescription.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Notice?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            string sql = "select * from Notice where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Notice where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvInsertNotice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertNotice.SelectedRows != null && dgvInsertNotice.SelectedRows.Count > 0)

            {
                string ID = dgvInsertNotice.CurrentRow.Cells[0].Value.ToString();

                string Category = dgvInsertNotice.CurrentRow.Cells[1].Value.ToString();

                string Date = dgvInsertNotice.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvInsertNotice.CurrentRow.Cells[3].Value.ToString();


               
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
