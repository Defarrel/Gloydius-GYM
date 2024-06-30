namespace Gym_desktop
{
    partial class tambahKehadiran
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
            this.id_jadwal = new System.Windows.Forms.TextBox();
            this.id_trainer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.kehadiran = new System.Windows.Forms.ComboBox();
            this.gYMDataSet2 = new Gym_desktop.GYMDataSet2();
            this.kehadiranTrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kehadiranTrainerTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.KehadiranTrainerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kehadiranTrainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tanggal
            // 
            this.tanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(437, 313);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(305, 20);
            this.tanggal.TabIndex = 29;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTambah.Location = new System.Drawing.Point(882, 302);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(126, 62);
            this.btnTambah.TabIndex = 27;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // id_jadwal
            // 
            this.id_jadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_jadwal.Location = new System.Drawing.Point(437, 419);
            this.id_jadwal.Multiline = true;
            this.id_jadwal.Name = "id_jadwal";
            this.id_jadwal.Size = new System.Drawing.Size(305, 35);
            this.id_jadwal.TabIndex = 26;
            // 
            // id_trainer
            // 
            this.id_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_trainer.Location = new System.Drawing.Point(437, 361);
            this.id_trainer.Multiline = true;
            this.id_trainer.Name = "id_trainer";
            this.id_trainer.Size = new System.Drawing.Size(305, 35);
            this.id_trainer.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(203, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Masukan Tanggal Kehadiran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(203, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Masukan Id Jadwal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(203, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Masukan Id Trainer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kehadiran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Masukan Id ";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(437, 185);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(305, 35);
            this.ID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Tambah Kehadiran";
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
            this.backBtn.TabIndex = 28;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // kehadiran
            // 
            this.kehadiran.FormattingEnabled = true;
            this.kehadiran.Location = new System.Drawing.Point(437, 259);
            this.kehadiran.Name = "kehadiran";
            this.kehadiran.Size = new System.Drawing.Size(305, 21);
            this.kehadiran.TabIndex = 30;
            // 
            // gYMDataSet2
            // 
            this.gYMDataSet2.DataSetName = "GYMDataSet2";
            this.gYMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kehadiranTrainerBindingSource
            // 
            this.kehadiranTrainerBindingSource.DataMember = "KehadiranTrainer";
            this.kehadiranTrainerBindingSource.DataSource = this.gYMDataSet2;
            // 
            // kehadiranTrainerTableAdapter
            // 
            this.kehadiranTrainerTableAdapter.ClearBeforeFill = true;
            // 
            // tambahKehadiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.kehadiran);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.id_jadwal);
            this.Controls.Add(this.id_trainer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tambahKehadiran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambahKehadiran";
            this.Load += new System.EventHandler(this.tambahKehadiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kehadiranTrainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox id_jadwal;
        private System.Windows.Forms.TextBox id_trainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kehadiran;
        private GYMDataSet2 gYMDataSet2;
        private System.Windows.Forms.BindingSource kehadiranTrainerBindingSource;
        private GYMDataSet2TableAdapters.KehadiranTrainerTableAdapter kehadiranTrainerTableAdapter;
    }
}