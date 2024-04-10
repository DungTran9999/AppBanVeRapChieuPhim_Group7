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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.lbRank = new System.Windows.Forms.ListBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.ptbRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lvManager
            // 
            this.lvManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.ttlv,
            this.columnHeader4});
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Theater";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Movie";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // ttlv
            // 
            this.ttlv.Text = "Number of Chairs";
            this.ttlv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlv.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1023, 596);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 41);
            this.txtDoanhThu.TabIndex = 1;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(1017, 518);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(254, 36);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThu.Location = new System.Drawing.Point(1035, 671);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(211, 73);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Refresh";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // lbRank
            // 
            this.lbRank.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.FormattingEnabled = true;
            this.lbRank.ItemHeight = 20;
            this.lbRank.Location = new System.Drawing.Point(1006, 114);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(281, 204);
            this.lbRank.TabIndex = 4;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(979, 38);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(328, 36);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "Bảng Xếp Hạng Phim ";
            // 
            // ptbRefresh
            // 
            this.ptbRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ptbRefresh.Image = global::AppBanVeRapChieuPhim_Group7.Properties.Resources.refresh;
            this.ptbRefresh.Location = new System.Drawing.Point(1044, 677);
            this.ptbRefresh.Name = "ptbRefresh";
            this.ptbRefresh.Size = new System.Drawing.Size(60, 60);
            this.ptbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbRefresh.TabIndex = 5;
            this.ptbRefresh.TabStop = false;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::AppBanVeRapChieuPhim_Group7.Properties.Resources.nenhong;
            this.ClientSize = new System.Drawing.Size(1299, 790);
            this.Controls.Add(this.ptbRefresh);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.lvManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManager";
            this.Text = "frmManager";
            ((System.ComponentModel.ISupportInitialize)(this.ptbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvManager;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader ttlv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.ListBox lbRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.PictureBox ptbRefresh;
    }
}