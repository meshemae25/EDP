namespace Shoe_Collection
{
    partial class frmownerlist
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
            this.dgvownerlist = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvownerlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvownerlist
            // 
            this.dgvownerlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvownerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvownerlist.Location = new System.Drawing.Point(12, 61);
            this.dgvownerlist.Name = "dgvownerlist";
            this.dgvownerlist.Size = new System.Drawing.Size(776, 340);
            this.dgvownerlist.TabIndex = 0;
            this.dgvownerlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvownerlist_CellClick);
            // txtsearch
            // 
            this.txtsearch.AutoSize = true;
            this.txtsearch.Location = new System.Drawing.Point(16, 29);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(44, 13);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Text = "Search:";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(63, 24);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(245, 20);
            this.txtbox.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(713, 24);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // frmownerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvownerlist);
            this.Name = "frmownerlist";
            this.Text = "frmownerlist";
            this.Load += new System.EventHandler(this.frmownerlist_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvownerlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvownerlist;
        private System.Windows.Forms.Label txtsearch;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btncancel;
    }
}