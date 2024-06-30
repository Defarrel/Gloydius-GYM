namespace Gym_desktop
{
    partial class paketManagement
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
            this.btnLihatPaket = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapusPaket = new System.Windows.Forms.Button();
            this.TambahPaketMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLihatPaket
            // 
            this.btnLihatPaket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLihatPaket.Location = new System.Drawing.Point(606, 339);
            this.btnLihatPaket.Name = "btnLihatPaket";
            this.btnLihatPaket.Size = new System.Drawing.Size(150, 77);
            this.btnLihatPaket.TabIndex = 9;
            this.btnLihatPaket.Text = "Lihat Paket Member";
            this.btnLihatPaket.UseVisualStyleBackColor = true;
            this.btnLihatPaket.Click += new System.EventHandler(this.btnLihatPaket_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(393, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 77);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Paket Member";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapusPaket
            // 
            this.btnHapusPaket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHapusPaket.Location = new System.Drawing.Point(606, 189);
            this.btnHapusPaket.Name = "btnHapusPaket";
            this.btnHapusPaket.Size = new System.Drawing.Size(150, 77);
            this.btnHapusPaket.TabIndex = 7;
            this.btnHapusPaket.Text = "Hapus Paket Member";
            this.btnHapusPaket.UseVisualStyleBackColor = true;
            this.btnHapusPaket.Click += new System.EventHandler(this.btnHapusPaket_Click);
            // 
            // TambahPaketMember
            // 
            this.TambahPaketMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahPaketMember.Location = new System.Drawing.Point(393, 189);
            this.TambahPaketMember.Name = "TambahPaketMember";
            this.TambahPaketMember.Size = new System.Drawing.Size(150, 77);
            this.TambahPaketMember.TabIndex = 6;
            this.TambahPaketMember.Text = "Tambah Paket Member";
            this.TambahPaketMember.UseVisualStyleBackColor = true;
            this.TambahPaketMember.Click += new System.EventHandler(this.TambahPaketMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Paket Member Management";
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
            // paketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnLihatPaket);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapusPaket);
            this.Controls.Add(this.TambahPaketMember);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paketManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paketManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLihatPaket;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapusPaket;
        private System.Windows.Forms.Button TambahPaketMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
    }
}