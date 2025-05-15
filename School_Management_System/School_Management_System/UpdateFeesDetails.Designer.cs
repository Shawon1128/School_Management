
namespace School_Management_System
{
    partial class UpdateFeesDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFeesDetails));
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtLastMonthCharges = new System.Windows.Forms.TextBox();
            this.txtFeesForMonth = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUpdateFeesDetails = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this._School_Management_SystemDataSet2 = new School_Management_System._School_Management_SystemDataSet2();
            this.feesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feesDetailsTableAdapter = new School_Management_System._School_Management_SystemDataSet2TableAdapters.FeesDetailsTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeForMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastMonthChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateFeesDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._School_Management_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Cyan;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1008, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 48);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(253, 10);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(267, 35);
            this.txtStudentID.TabIndex = 48;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(253, 333);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(267, 26);
            this.txtDate.TabIndex = 46;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(854, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 48);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(253, 169);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(267, 35);
            this.txtDiscount.TabIndex = 42;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.Location = new System.Drawing.Point(253, 292);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(267, 35);
            this.txtRemaining.TabIndex = 41;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(253, 251);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(267, 35);
            this.txtPaid.TabIndex = 40;
            // 
            // txtLastMonthCharges
            // 
            this.txtLastMonthCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMonthCharges.Location = new System.Drawing.Point(253, 128);
            this.txtLastMonthCharges.Name = "txtLastMonthCharges";
            this.txtLastMonthCharges.Size = new System.Drawing.Size(267, 35);
            this.txtLastMonthCharges.TabIndex = 39;
            // 
            // txtFeesForMonth
            // 
            this.txtFeesForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeesForMonth.Location = new System.Drawing.Point(253, 92);
            this.txtFeesForMonth.Name = "txtFeesForMonth";
            this.txtFeesForMonth.Size = new System.Drawing.Size(267, 35);
            this.txtFeesForMonth.TabIndex = 38;
            // 
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(253, 51);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(267, 35);
            this.txtClassID.TabIndex = 37;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 43);
            this.button7.TabIndex = 36;
            this.button7.Text = "Discount:";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 43);
            this.button8.TabIndex = 35;
            this.button8.Text = "Remaining:";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 43);
            this.button9.TabIndex = 34;
            this.button9.Text = "Paid:";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 43);
            this.button5.TabIndex = 32;
            this.button5.Text = "Date:";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 43);
            this.button3.TabIndex = 30;
            this.button3.Text = "Fees For Month:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 43);
            this.button2.TabIndex = 29;
            this.button2.Text = "Class ID:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Student ID:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(503, 1);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(247, 35);
            this.txtAutoSearch.TabIndex = 26;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 35);
            this.txtSearch.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(1146, 0);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(155, 31);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnShowDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 37);
            this.panel2.TabIndex = 27;
            // 
            // dgvUpdateFeesDetails
            // 
            this.dgvUpdateFeesDetails.AllowUserToAddRows = false;
            this.dgvUpdateFeesDetails.AllowUserToDeleteRows = false;
            this.dgvUpdateFeesDetails.AutoGenerateColumns = false;
            this.dgvUpdateFeesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateFeesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.feeForMonthDataGridViewTextBoxColumn,
            this.lastMonthChargesDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvUpdateFeesDetails.DataSource = this.feesDetailsBindingSource;
            this.dgvUpdateFeesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpdateFeesDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvUpdateFeesDetails.Name = "dgvUpdateFeesDetails";
            this.dgvUpdateFeesDetails.ReadOnly = true;
            this.dgvUpdateFeesDetails.RowHeadersWidth = 62;
            this.dgvUpdateFeesDetails.RowTemplate.Height = 28;
            this.dgvUpdateFeesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdateFeesDetails.Size = new System.Drawing.Size(1306, 174);
            this.dgvUpdateFeesDetails.TabIndex = 0;
            this.dgvUpdateFeesDetails.SelectionChanged += new System.EventHandler(this.dgvUpdateFeesDetails_SelectionChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 43);
            this.button6.TabIndex = 31;
            this.button6.Text = "LastMonthCharges:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUpdateFeesDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 174);
            this.panel1.TabIndex = 26;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(253, 210);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(267, 35);
            this.txtTotal.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 43);
            this.button4.TabIndex = 50;
            this.button4.Text = "Total:";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(632, 352);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(145, 45);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1179, 352);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 45);
            this.button10.TabIndex = 54;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.update_fees;
            this.pictureBox1.Location = new System.Drawing.Point(770, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1179, 301);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 45);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // _School_Management_SystemDataSet2
            // 
            this._School_Management_SystemDataSet2.DataSetName = "_School_Management_SystemDataSet2";
            this._School_Management_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feesDetailsBindingSource
            // 
            this.feesDetailsBindingSource.DataMember = "FeesDetails";
            this.feesDetailsBindingSource.DataSource = this._School_Management_SystemDataSet2;
            // 
            // feesDetailsTableAdapter
            // 
            this.feesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.classIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // feeForMonthDataGridViewTextBoxColumn
            // 
            this.feeForMonthDataGridViewTextBoxColumn.DataPropertyName = "FeeForMonth";
            this.feeForMonthDataGridViewTextBoxColumn.HeaderText = "FeeForMonth";
            this.feeForMonthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.feeForMonthDataGridViewTextBoxColumn.Name = "feeForMonthDataGridViewTextBoxColumn";
            this.feeForMonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.feeForMonthDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastMonthChargesDataGridViewTextBoxColumn
            // 
            this.lastMonthChargesDataGridViewTextBoxColumn.DataPropertyName = "LastMonthCharges";
            this.lastMonthChargesDataGridViewTextBoxColumn.HeaderText = "LastMonthCharges";
            this.lastMonthChargesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastMonthChargesDataGridViewTextBoxColumn.Name = "lastMonthChargesDataGridViewTextBoxColumn";
            this.lastMonthChargesDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastMonthChargesDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDataGridViewTextBoxColumn.Width = 150;
            // 
            // remainingDataGridViewTextBoxColumn
            // 
            this.remainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining";
            this.remainingDataGridViewTextBoxColumn.HeaderText = "Remaining";
            this.remainingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.remainingDataGridViewTextBoxColumn.Name = "remainingDataGridViewTextBoxColumn";
            this.remainingDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UpdateFeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 614);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtLastMonthCharges);
            this.Controls.Add(this.txtFeesForMonth);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateFeesDetails";
            this.Text = "UpdateFeesDetails";
            this.Load += new System.EventHandler(this.UpdateFeesDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateFeesDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._School_Management_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtLastMonthCharges;
        private System.Windows.Forms.TextBox txtFeesForMonth;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUpdateFeesDetails;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private _School_Management_SystemDataSet2 _School_Management_SystemDataSet2;
        private System.Windows.Forms.BindingSource feesDetailsBindingSource;
        private _School_Management_SystemDataSet2TableAdapters.FeesDetailsTableAdapter feesDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeForMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastMonthChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}