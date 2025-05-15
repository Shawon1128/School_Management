
namespace School_Management_System
{
    partial class InsertFeesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertFeesDetails));
            this.button4 = new System.Windows.Forms.Button();
            this.dgvInsertFeesDetails = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeForMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastMonthChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._School_Management_SystemDataSet1 = new School_Management_System._School_Management_SystemDataSet1();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.feesDetailsTableAdapter = new School_Management_System._School_Management_SystemDataSet1TableAdapters.FeesDetailsTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertFeesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._School_Management_SystemDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 43);
            this.button4.TabIndex = 72;
            this.button4.Text = "Total:";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvInsertFeesDetails
            // 
            this.dgvInsertFeesDetails.AllowUserToAddRows = false;
            this.dgvInsertFeesDetails.AllowUserToDeleteRows = false;
            this.dgvInsertFeesDetails.AutoGenerateColumns = false;
            this.dgvInsertFeesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsertFeesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.feeForMonthDataGridViewTextBoxColumn,
            this.lastMonthChargesDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvInsertFeesDetails.DataSource = this.feesDetailsBindingSource;
            this.dgvInsertFeesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsertFeesDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInsertFeesDetails.Name = "dgvInsertFeesDetails";
            this.dgvInsertFeesDetails.ReadOnly = true;
            this.dgvInsertFeesDetails.RowHeadersWidth = 62;
            this.dgvInsertFeesDetails.RowTemplate.Height = 28;
            this.dgvInsertFeesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsertFeesDetails.Size = new System.Drawing.Size(1284, 174);
            this.dgvInsertFeesDetails.TabIndex = 0;
            this.dgvInsertFeesDetails.SelectionChanged += new System.EventHandler(this.dgvInsertFeesDetails_SelectionChanged);
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
            // feesDetailsBindingSource
            // 
            this.feesDetailsBindingSource.DataMember = "FeesDetails";
            this.feesDetailsBindingSource.DataSource = this._School_Management_SystemDataSet1;
            // 
            // _School_Management_SystemDataSet1
            // 
            this._School_Management_SystemDataSet1.DataSetName = "_School_Management_SystemDataSet1";
            this._School_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnShowDetails.Location = new System.Drawing.Point(1129, 1);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(155, 31);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(253, 207);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(269, 35);
            this.txtTotal.TabIndex = 73;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Cyan;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1008, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 50);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(253, 7);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(269, 35);
            this.txtStudentID.TabIndex = 70;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(253, 330);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(269, 26);
            this.txtDate.TabIndex = 69;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Lime;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(816, 302);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 54);
            this.btnInsert.TabIndex = 68;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(253, 166);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(269, 35);
            this.txtDiscount.TabIndex = 67;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.Location = new System.Drawing.Point(253, 289);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(269, 35);
            this.txtRemaining.TabIndex = 66;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(253, 248);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(269, 35);
            this.txtPaid.TabIndex = 65;
            // 
            // txtLastMonthCharges
            // 
            this.txtLastMonthCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMonthCharges.Location = new System.Drawing.Point(253, 125);
            this.txtLastMonthCharges.Name = "txtLastMonthCharges";
            this.txtLastMonthCharges.Size = new System.Drawing.Size(269, 35);
            this.txtLastMonthCharges.TabIndex = 64;
            // 
            // txtFeesForMonth
            // 
            this.txtFeesForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeesForMonth.Location = new System.Drawing.Point(253, 89);
            this.txtFeesForMonth.Name = "txtFeesForMonth";
            this.txtFeesForMonth.Size = new System.Drawing.Size(269, 35);
            this.txtFeesForMonth.TabIndex = 63;
            // 
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(253, 48);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(269, 35);
            this.txtClassID.TabIndex = 62;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 43);
            this.button7.TabIndex = 61;
            this.button7.Text = "Discount:";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 43);
            this.button8.TabIndex = 60;
            this.button8.Text = "Remaining:";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 244);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 43);
            this.button9.TabIndex = 59;
            this.button9.Text = "Paid:";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 43);
            this.button5.TabIndex = 58;
            this.button5.Text = "Date:";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 43);
            this.button3.TabIndex = 56;
            this.button3.Text = "Fees For Month:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 43);
            this.button2.TabIndex = 55;
            this.button2.Text = "Class ID:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 43);
            this.button1.TabIndex = 54;
            this.button1.Text = "Student ID:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnShowDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 37);
            this.panel2.TabIndex = 53;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 43);
            this.button6.TabIndex = 57;
            this.button6.Text = "LastMonthCharges:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInsertFeesDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 174);
            this.panel1.TabIndex = 52;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(605, 360);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(145, 50);
            this.btnPrevious.TabIndex = 74;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1151, 360);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 50);
            this.button10.TabIndex = 75;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.add_fees;
            this.pictureBox1.Location = new System.Drawing.Point(741, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1160, 233);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 50);
            this.btnPrint.TabIndex = 77;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // feesDetailsTableAdapter
            // 
            this.feesDetailsTableAdapter.ClearBeforeFill = true;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // InsertFeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1284, 627);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnInsert);
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
            this.Name = "InsertFeesDetails";
            this.Text = "InsertFeesDetails";
            this.Load += new System.EventHandler(this.InsertFeesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertFeesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._School_Management_SystemDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvInsertFeesDetails;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnInsert;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private _School_Management_SystemDataSet1 _School_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource feesDetailsBindingSource;
        private _School_Management_SystemDataSet1TableAdapters.FeesDetailsTableAdapter feesDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeForMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastMonthChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}