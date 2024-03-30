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
            this.ttlvMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvNumberOfChair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvManager
            // 
            this.lvManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ttlvMovie,
            this.ttlvPrice,
            this.ttlvNumberOfChair});
            this.lvManager.GridLines = true;
            this.lvManager.HideSelection = false;
            this.lvManager.Location = new System.Drawing.Point(0, -1);
            this.lvManager.Name = "lvManager";
            this.lvManager.Size = new System.Drawing.Size(973, 728);
            this.lvManager.TabIndex = 0;
            this.lvManager.UseCompatibleStateImageBehavior = false;
            this.lvManager.View = System.Windows.Forms.View.Details;
            // 
            // ttlvMovie
            // 
            this.ttlvMovie.Text = "Movie";
            this.ttlvMovie.Width = 267;
            // 
            // ttlvPrice
            // 
            this.ttlvPrice.Text = "Price";
            this.ttlvPrice.Width = 146;
            // 
            // ttlvNumberOfChair
            // 
            this.ttlvNumberOfChair.Text = "Number Of Chair";
            this.ttlvNumberOfChair.Width = 174;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 729);
            this.Controls.Add(this.lvManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvManager;
        private System.Windows.Forms.ColumnHeader ttlvMovie;
        private System.Windows.Forms.ColumnHeader ttlvPrice;
        private System.Windows.Forms.ColumnHeader ttlvNumberOfChair;
    }
}