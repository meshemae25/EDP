namespace Shoe_Collection
{
    partial class frmshoeslist
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
            this.dgvshoeslist = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoeslist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvshoeslist
            // 
            this.dgvshoeslist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvshoeslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshoeslist.Location = new System.Drawing.Point(12, 78);
            this.dgvshoeslist.Name = "dgvshoeslist";
            this.dgvshoeslist.Size = new System.Drawing.Size(776, 348);
            this.dgvshoeslist.TabIndex = 0;
            this.dgvshoeslist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshoeslist_CellClick);
            this.dgvshoeslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshoeslist_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(72, 52);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(273, 20);
            this.txtsearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(713, 50);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // frmshoeslist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvshoeslist);
            this.Name = "frmshoeslist";
            this.Text = "Shoes List";
            this.Load += new System.EventHandler(this.frmshoeslist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoeslist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvshoeslist;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
    }
}