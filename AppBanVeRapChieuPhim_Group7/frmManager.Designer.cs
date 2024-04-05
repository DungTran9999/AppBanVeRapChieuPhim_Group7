namespace AppBanVeRapChieuPhim_Group7
{
    partial class frmManager
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
            this.lvManager = new System.Windows.Forms.ListView();
            this.ttlvTheater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvNumberofChairs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvManager
            // 
            this.lvManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ttlvTheater,
            this.ttlvMovie,
            this.ttlvPrice,
            this.ttlvNumberofChairs,
            this.ttlvTotal});
            this.lvManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvManager.GridLines = true;
            this.lvManager.HideSelection = false;
            this.lvManager.Location = new System.Drawing.Point(0, -2);
            this.lvManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvManager.Name = "lvManager";
            this.lvManager.Size = new System.Drawing.Size(973, 790);
            this.lvManager.TabIndex = 0;
            this.lvManager.UseCompatibleStateImageBehavior = false;
            this.lvManager.View = System.Windows.Forms.View.Details;
            // 
            // ttlvTheater
            // 
            this.ttlvTheater.Text = "Theater";
            this.ttlvTheater.Width = 120;
            // 
            // ttlvMovie
            // 
            this.ttlvMovie.Text = "Movie";
            this.ttlvMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvMovie.Width = 200;
            // 
            // ttlvPrice
            // 
            this.ttlvPrice.Text = "Price";
            this.ttlvPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvPrice.Width = 120;
            // 
            // ttlvNumberofChairs
            // 
            this.ttlvNumberofChairs.Text = "Number of Chairs";
            this.ttlvNumberofChairs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvNumberofChairs.Width = 170;
            // 
            // ttlvTotal
            // 
            this.ttlvTotal.Text = "Total";
            this.ttlvTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvTotal.Width = 120;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1025, 591);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 41);
            this.txtDoanhThu.TabIndex = 1;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(1051, 521);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(172, 36);
            this.lb.TabIndex = 2;
            this.lb.Text = "Doanh Thu";
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThu.Location = new System.Drawing.Point(1079, 687);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(124, 48);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Tính";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(988, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xếp Hạng Bộ Phim Hay Nhất";
            // 
            // lbRank
            // 
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.FormattingEnabled = true;
            this.lbRank.ItemHeight = 22;
            this.lbRank.Location = new System.Drawing.Point(979, 59);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(327, 334);
            this.lbRank.TabIndex = 4;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 790);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.lvManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvManager;
        private System.Windows.Forms.ColumnHeader ttlvTheater;
        private System.Windows.Forms.ColumnHeader ttlvMovie;
        private System.Windows.Forms.ColumnHeader ttlvPrice;
        private System.Windows.Forms.ColumnHeader ttlvNumberofChairs;
        private System.Windows.Forms.ColumnHeader ttlvTotal;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRank;
    }
}