namespace AppBanVeRapChieuPhim_Group7
{
    partial class frmSetting
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
            this.btnFix = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvControl = new System.Windows.Forms.ListView();
            this.ttlvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlvTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // plControl
            // 
            this.plControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plControl.Controls.Add(this.comboBox1);
            this.plControl.Controls.Add(this.btnFix);
            this.plControl.Controls.Add(this.btnRemove);
            this.plControl.Controls.Add(this.btnAdd);
            this.plControl.Controls.Add(this.btnCancel);
            this.plControl.Controls.Add(this.txtTime);
            this.plControl.Controls.Add(this.label3);
            this.plControl.Controls.Add(this.txtPrice);
            this.plControl.Controls.Add(this.label2);
            this.plControl.Controls.Add(this.txtID);
            this.plControl.Controls.Add(this.label4);
            this.plControl.Controls.Add(this.txtMovie);
            this.plControl.Controls.Add(this.label1);
            this.plControl.Location = new System.Drawing.Point(12, 12);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(508, 751);
            this.plControl.TabIndex = 0;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.Cyan;
            this.btnFix.Location = new System.Drawing.Point(375, 267);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(117, 48);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Yellow;
            this.btnRemove.Location = new System.Drawing.Point(252, 267);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 48);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(6, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(129, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(195, 167);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(296, 30);
            this.txtTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(195, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(296, 30);
            this.txtPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(195, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(296, 30);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // txtMovie
            // 
            this.txtMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.Location = new System.Drawing.Point(195, 95);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(296, 30);
            this.txtMovie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Movie:";
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ttlvID,
            this.ttlvMovie,
            this.ttlvPrice,
            this.ttlvTime});
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(540, 12);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(590, 751);
            this.lvControl.TabIndex = 1;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            this.lvControl.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvControl_ItemSelectionChanged);
            // 
            // ttlvID
            // 
            this.ttlvID.Text = "ID";
            this.ttlvID.Width = 80;
            // 
            // ttlvMovie
            // 
            this.ttlvMovie.Text = "Movie";
            this.ttlvMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvMovie.Width = 130;
            // 
            // ttlvPrice
            // 
            this.ttlvPrice.Text = "Price";
            this.ttlvPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvPrice.Width = 120;
            // 
            // ttlvTime
            // 
            this.ttlvTime.Text = "Time";
            this.ttlvTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlvTime.Width = 120;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 775);
            this.Controls.Add(this.lvControl);
            this.Controls.Add(this.plControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.plControl.ResumeLayout(false);
            this.plControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader ttlvID;
        private System.Windows.Forms.ColumnHeader ttlvMovie;
        private System.Windows.Forms.ColumnHeader ttlvPrice;
        private System.Windows.Forms.ColumnHeader ttlvTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}