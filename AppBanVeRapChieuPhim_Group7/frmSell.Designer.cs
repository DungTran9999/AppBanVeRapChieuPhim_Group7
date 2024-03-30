namespace AppBanVeRapChieuPhim_Group7
{
    partial class frmSell
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
            this.plLoadForm = new System.Windows.Forms.Panel();
            this.btnTheater1 = new System.Windows.Forms.Button();
            this.btnTheater2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plLoadForm
            // 
            this.plLoadForm.BackColor = System.Drawing.Color.Gray;
            this.plLoadForm.Location = new System.Drawing.Point(0, 0);
            this.plLoadForm.Name = "plLoadForm";
            this.plLoadForm.Size = new System.Drawing.Size(1317, 550);
            this.plLoadForm.TabIndex = 0;
            // 
            // btnTheater1
            // 
            this.btnTheater1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheater1.Location = new System.Drawing.Point(0, 550);
            this.btnTheater1.Name = "btnTheater1";
            this.btnTheater1.Size = new System.Drawing.Size(129, 46);
            this.btnTheater1.TabIndex = 0;
            this.btnTheater1.Text = "Theater 1";
            this.btnTheater1.UseVisualStyleBackColor = true;
            this.btnTheater1.Click += new System.EventHandler(this.btnTheater1_Click);
            // 
            // btnTheater2
            // 
            this.btnTheater2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheater2.Location = new System.Drawing.Point(174, 550);
            this.btnTheater2.Name = "btnTheater2";
            this.btnTheater2.Size = new System.Drawing.Size(129, 46);
            this.btnTheater2.TabIndex = 0;
            this.btnTheater2.Text = "Theater 2";
            this.btnTheater2.UseVisualStyleBackColor = true;
            this.btnTheater2.Click += new System.EventHandler(this.btnTheater2_Click);
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1317, 776);
            this.Controls.Add(this.btnTheater2);
            this.Controls.Add(this.btnTheater1);
            this.Controls.Add(this.plLoadForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLoadForm;
        private System.Windows.Forms.Button btnTheater1;
        private System.Windows.Forms.Button btnTheater2;
    }
}