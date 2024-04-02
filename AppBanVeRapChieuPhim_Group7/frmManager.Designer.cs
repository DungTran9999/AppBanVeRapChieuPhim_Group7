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
            this.lb = new System.Windows.Forms.Label();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.txtThinhHanh = new System.Windows.Forms.TextBox();
            this.lbThinhHanh = new System.Windows.Forms.Label();
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
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1028, 239);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 41);
            this.txtDoanhThu.TabIndex = 1;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(1058, 192);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(172, 36);
            this.lb.TabIndex = 2;
            this.lb.Text = "Doanh Thu";
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThu.Location = new System.Drawing.Point(1076, 649);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(124, 48);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Tính";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // txtThinhHanh
            // 
            this.txtThinhHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThinhHanh.Location = new System.Drawing.Point(1028, 427);
            this.txtThinhHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThinhHanh.Name = "txtThinhHanh";
            this.txtThinhHanh.Size = new System.Drawing.Size(235, 41);
            this.txtThinhHanh.TabIndex = 1;
            this.txtThinhHanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbThinhHanh
            // 
            this.lbThinhHanh.AutoSize = true;
            this.lbThinhHanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbThinhHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThinhHanh.Location = new System.Drawing.Point(1013, 380);
            this.lbThinhHanh.Name = "lbThinhHanh";
            this.lbThinhHanh.Size = new System.Drawing.Size(260, 36);
            this.lbThinhHanh.TabIndex = 2;
            this.lbThinhHanh.Text = "Phim Thịnh Hành";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 790);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.lbThinhHanh);
            this.Controls.Add(this.txtThinhHanh);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader ttlv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.TextBox txtThinhHanh;
        private System.Windows.Forms.Label lbThinhHanh;
    }
}