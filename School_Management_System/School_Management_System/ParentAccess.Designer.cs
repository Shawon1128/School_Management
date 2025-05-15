
namespace School_Management_System
{
    partial class ParentAccess
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
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotice
            // 
            this.btnNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotice.Location = new System.Drawing.Point(212, 277);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(133, 58);
            this.btnNotice.TabIndex = 0;
            this.btnNotice.Text = "Notice";
            this.btnNotice.UseVisualStyleBackColor = false;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.Location = new System.Drawing.Point(393, 277);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(133, 58);
            this.btnFee.TabIndex = 1;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.parents;
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ParentAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnNotice);
            this.Name = "ParentAccess";
            this.Text = "ParentAccess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}