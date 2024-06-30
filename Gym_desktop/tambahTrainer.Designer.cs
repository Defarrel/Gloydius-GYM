namespace Gym_desktop
{
    partial class tambahTrainer
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gYMDataSet = new Gym_desktop.GYMDataSet();
            this.personalTrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTrainerTableAdapter = new Gym_desktop.GYMDataSetTableAdapters.PersonalTrainerTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            this.id_trainer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nama_trainer = new System.Windows.Forms.TextBox();
            this.no_hp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTambah.Location = new System.Drawing.Point(896, 317);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(126, 62);
            this.btnTambah.TabIndex = 38;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Menu Tambah Trainer";
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTrainerBindingSource
            // 
            this.personalTrainerBindingSource.DataMember = "PersonalTrainer";
            this.personalTrainerBindingSource.DataSource = this.gYMDataSet;
            // 
            // personalTrainerTableAdapter
            // 
            this.personalTrainerTableAdapter.ClearBeforeFill = true;
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
            this.backBtn.TabIndex = 39;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // id_trainer
            // 
            this.id_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_trainer.Location = new System.Drawing.Point(451, 200);
            this.id_trainer.Multiline = true;
            this.id_trainer.Name = "id_trainer";
            this.id_trainer.Size = new System.Drawing.Size(305, 35);
            this.id_trainer.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Masukan ID trainer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Masukan Nama Trainer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Masukan Harga Nomor HP";
            // 
            // nama_trainer
            // 
            this.nama_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nama_trainer.Location = new System.Drawing.Point(451, 260);
            this.nama_trainer.Multiline = true;
            this.nama_trainer.Name = "nama_trainer";
            this.nama_trainer.Size = new System.Drawing.Size(305, 35);
            this.nama_trainer.TabIndex = 35;
            // 
            // no_hp
            // 
            this.no_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.no_hp.Location = new System.Drawing.Point(451, 321);
            this.no_hp.Multiline = true;
            this.no_hp.Name = "no_hp";
            this.no_hp.Size = new System.Drawing.Size(305, 35);
            this.no_hp.TabIndex = 36;
            // 
            // tambahTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.no_hp);
            this.Controls.Add(this.nama_trainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_trainer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tambahTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tambahTrainer";
            this.Load += new System.EventHandler(this.tambahTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.BindingSource personalTrainerBindingSource;
        private GYMDataSetTableAdapters.PersonalTrainerTableAdapter personalTrainerTableAdapter;
        private System.Windows.Forms.TextBox id_trainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nama_trainer;
        private System.Windows.Forms.TextBox no_hp;
    }
}