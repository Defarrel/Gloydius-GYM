namespace Gym_desktop
{
    partial class transaksiManagement
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
            this.btnLihatTransaksi = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TambahPaketMember = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLihatTransaksi
            // 
            this.btnLihatTransaksi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLihatTransaksi.Location = new System.Drawing.Point(631, 354);
            this.btnLihatTransaksi.Name = "btnLihatTransaksi";
            this.btnLihatTransaksi.Size = new System.Drawing.Size(150, 77);
            this.btnLihatTransaksi.TabIndex = 14;
            this.btnLihatTransaksi.Text = "Lihat Transaksi";
            this.btnLihatTransaksi.UseVisualStyleBackColor = true;
            this.btnLihatTransaksi.Click += new System.EventHandler(this.btnLihatTransaksi_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(392, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 77);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Transaksi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu Transaksi Management";
            // 
            // TambahPaketMember
            // 
            this.TambahPaketMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahPaketMember.Location = new System.Drawing.Point(512, 205);
            this.TambahPaketMember.Name = "TambahPaketMember";
            this.TambahPaketMember.Size = new System.Drawing.Size(150, 77);
            this.TambahPaketMember.TabIndex = 11;
            this.TambahPaketMember.Text = "Tambah Transaksi";
            this.TambahPaketMember.UseVisualStyleBackColor = true;
            this.TambahPaketMember.Click += new System.EventHandler(this.TambahPaketMember_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::Gym_desktop.Properties.Resources.arrow_back_regular_240;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(1049, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 59);
            this.backBtn.TabIndex = 22;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // transaksiManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnLihatTransaksi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TambahPaketMember);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transaksiManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transaksiManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLihatTransaksi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TambahPaketMember;
        private System.Windows.Forms.Button backBtn;
    }
}