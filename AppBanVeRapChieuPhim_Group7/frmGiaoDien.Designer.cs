namespace AppBanVeRapChieuPhim_Group7
{
    partial class frmGiaoDien
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
            this.plControl = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.plScroll = new System.Windows.Forms.Panel();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.plLoadForm = new System.Windows.Forms.Panel();
            this.lbChangeName = new System.Windows.Forms.Label();
            this.plControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // plControl
            // 
            this.plControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.plControl.Controls.Add(this.btnExit);
            this.plControl.Controls.Add(this.plScroll);
            this.plControl.Controls.Add(this.btnManager);
            this.plControl.Controls.Add(this.btnSell);
            this.plControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.plControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plControl.Location = new System.Drawing.Point(0, 0);
            this.plControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(173, 706);
            this.plControl.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(2, 622);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 82);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // plScroll
            // 
            this.plScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plScroll.Location = new System.Drawing.Point(2, 170);
            this.plScroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plScroll.Name = "plScroll";
            this.plScroll.Size = new System.Drawing.Size(8, 103);
            this.plScroll.TabIndex = 0;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.FlatAppearance.BorderSize = 0;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnManager.Location = new System.Drawing.Point(2, 223);
            this.btnManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(169, 72);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            this.btnManager.Leave += new System.EventHandler(this.btnManager_Leave);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSell.Location = new System.Drawing.Point(2, 146);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(169, 72);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            this.btnSell.Leave += new System.EventHandler(this.btnSell_Leave);
            // 
            // plLoadForm
            // 
            this.plLoadForm.BackColor = System.Drawing.Color.Gray;
            this.plLoadForm.Location = new System.Drawing.Point(177, 73);
            this.plLoadForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plLoadForm.Name = "plLoadForm";
            this.plLoadForm.Size = new System.Drawing.Size(988, 630);
            this.plLoadForm.TabIndex = 1;
            // 
            // lbChangeName
            // 
            this.lbChangeName.AutoSize = true;
            this.lbChangeName.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold);
            this.lbChangeName.Location = new System.Drawing.Point(221, 26);
            this.lbChangeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChangeName.Name = "lbChangeName";
            this.lbChangeName.Size = new System.Drawing.Size(108, 41);
            this.lbChangeName.TabIndex = 2;
            this.lbChangeName.Text = "label1";
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 706);
            this.Controls.Add(this.lbChangeName);
            this.Controls.Add(this.plLoadForm);
            this.Controls.Add(this.plControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoDien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDien_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            this.plControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Panel plLoadForm;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lbChangeName;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel plScroll;
        private System.Windows.Forms.Button btnExit;
    }
}