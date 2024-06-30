namespace Gym_desktop
{
    partial class tambahLatihan
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
            this.components = new System.ComponentModel.Container();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.durasi = new System.Windows.Forms.TextBox();
            this.gerakan = new System.Windows.Forms.TextBox();
            this.latihan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_member = new System.Windows.Forms.TextBox();
            this.id_trainer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.gYMDataSet2 = new Gym_desktop.GYMDataSet2();
            this.latihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.LatihanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tanggal
            // 
            this.tanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(439, 379);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(305, 20);
            this.tanggal.TabIndex = 31;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTambah.Location = new System.Drawing.Point(882, 302);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(126, 62);
            this.btnTambah.TabIndex = 29;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // durasi
            // 
            this.durasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durasi.Location = new System.Drawing.Point(437, 436);
            this.durasi.Multiline = true;
            this.durasi.Name = "durasi";
            this.durasi.Size = new System.Drawing.Size(305, 35);
            this.durasi.TabIndex = 28;
            // 
            // gerakan
            // 
            this.gerakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gerakan.Location = new System.Drawing.Point(437, 306);
            this.gerakan.Multiline = true;
            this.gerakan.Name = "gerakan";
            this.gerakan.Size = new System.Drawing.Size(305, 35);
            this.gerakan.TabIndex = 27;
            // 
            // latihan
            // 
            this.latihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.latihan.Location = new System.Drawing.Point(437, 245);
            this.latihan.Multiline = true;
            this.latihan.Name = "latihan";
            this.latihan.Size = new System.Drawing.Size(305, 35);
            this.latihan.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(203, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Masukan Id Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(203, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Masukan Durasi Latihan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(203, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Masukan Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(203, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Masukan Gerakan Latihan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Masukan Jenis Latihan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Masukan ID";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(437, 185);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(305, 35);
            this.ID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Menu Tambah Latihan";
            // 
            // id_member
            // 
            this.id_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_member.Location = new System.Drawing.Point(437, 492);
            this.id_member.Multiline = true;
            this.id_member.Name = "id_member";
            this.id_member.Size = new System.Drawing.Size(305, 35);
            this.id_member.TabIndex = 32;
            // 
            // id_trainer
            // 
            this.id_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_trainer.Location = new System.Drawing.Point(437, 549);
            this.id_trainer.Multiline = true;
            this.id_trainer.Name = "id_trainer";
            this.id_trainer.Size = new System.Drawing.Size(305, 35);
            this.id_trainer.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(203, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Masukan Id Trainer";
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
            this.backBtn.TabIndex = 30;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // gYMDataSet2
            // 
            this.gYMDataSet2.DataSetName = "GYMDataSet2";
            this.gYMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // latihanBindingSource
            // 
            this.latihanBindingSource.DataMember = "Latihan";
            this.latihanBindingSource.DataSource = this.gYMDataSet2;
            // 
            // latihanTableAdapter
            // 
            this.latihanTableAdapter.ClearBeforeFill = true;
            // 
            // tambahLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.id_trainer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_member);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.durasi);
            this.Controls.Add(this.gerakan);
            this.Controls.Add(this.latihan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tambahLatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambahLatihan";
            this.Load += new System.EventHandler(this.tambahLatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox durasi;
        private System.Windows.Forms.TextBox gerakan;
        private System.Windows.Forms.TextBox latihan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_member;
        private System.Windows.Forms.TextBox id_trainer;
        private System.Windows.Forms.Label label8;
        private GYMDataSet2 gYMDataSet2;
        private System.Windows.Forms.BindingSource latihanBindingSource;
        private GYMDataSet2TableAdapters.LatihanTableAdapter latihanTableAdapter;
    }
}