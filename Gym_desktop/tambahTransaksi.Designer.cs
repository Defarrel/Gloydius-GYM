namespace Gym_desktop
{
    partial class tambahTransaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemberbaru = new System.Windows.Forms.Button();
            this.btnTransaksibaru = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu Tambah Transaksi";
            // 
            // btnMemberbaru
            // 
            this.btnMemberbaru.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMemberbaru.Location = new System.Drawing.Point(672, 275);
            this.btnMemberbaru.Name = "btnMemberbaru";
            this.btnMemberbaru.Size = new System.Drawing.Size(176, 88);
            this.btnMemberbaru.TabIndex = 14;
            this.btnMemberbaru.Text = "Tambah Transaksi Member Baru";
            this.btnMemberbaru.UseVisualStyleBackColor = true;
            this.btnMemberbaru.Click += new System.EventHandler(this.btnMemberbaru_Click);
            // 
            // btnTransaksibaru
            // 
            this.btnTransaksibaru.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksibaru.Location = new System.Drawing.Point(293, 275);
            this.btnTransaksibaru.Name = "btnTransaksibaru";
            this.btnTransaksibaru.Size = new System.Drawing.Size(176, 88);
            this.btnTransaksibaru.TabIndex = 13;
            this.btnTransaksibaru.Text = "Tambah Transaksi Baru";
            this.btnTransaksibaru.UseVisualStyleBackColor = true;
            this.btnTransaksibaru.Click += new System.EventHandler(this.btnTransaksibaru_Click);
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
            this.backBtn.TabIndex = 16;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tambahTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnMemberbaru);
            this.Controls.Add(this.btnTransaksibaru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tambahTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambahTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMemberbaru;
        private System.Windows.Forms.Button btnTransaksibaru;
        private System.Windows.Forms.Button backBtn;
    }
}