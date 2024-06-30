namespace Gym_desktop
{
    partial class updatelatihan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.riwayat_latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.Riwayat_latihanTableAdapter();
            this.gYMDataSet2 = new Gym_desktop.GYMDataSet2();
            this.riwayatlatihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.LatihanTableAdapter();
            this.update = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenislatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerakangerakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasilatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_trainer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.id_member = new System.Windows.Forms.TextBox();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.durasi = new System.Windows.Forms.TextBox();
            this.gerakan = new System.Windows.Forms.TextBox();
            this.latihan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riwayatlatihanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // riwayat_latihanTableAdapter
            // 
            this.riwayat_latihanTableAdapter.ClearBeforeFill = true;
            // 
            // gYMDataSet2
            // 
            this.gYMDataSet2.DataSetName = "GYMDataSet2";
            this.gYMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // riwayatlatihanBindingSource
            // 
            this.riwayatlatihanBindingSource.DataMember = "Riwayat_latihan";
            this.riwayatlatihanBindingSource.DataSource = this.gYMDataSet2;
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
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(781, 551);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 46);
            this.update.TabIndex = 61;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.RefreshButton.Location = new System.Drawing.Point(1008, 551);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(96, 46);
            this.RefreshButton.TabIndex = 45;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlatihanDataGridViewTextBoxColumn,
            this.jenislatihanDataGridViewTextBoxColumn,
            this.gerakangerakanDataGridViewTextBoxColumn,
            this.tgllatihanDataGridViewTextBoxColumn,
            this.durasilatihanDataGridViewTextBoxColumn,
            this.idmemberDataGridViewTextBoxColumn,
            this.idtrainerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.latihanBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(613, 153);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Size = new System.Drawing.Size(507, 273);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idlatihanDataGridViewTextBoxColumn
            // 
            this.idlatihanDataGridViewTextBoxColumn.DataPropertyName = "Id_latihan";
            this.idlatihanDataGridViewTextBoxColumn.HeaderText = "Id_latihan";
            this.idlatihanDataGridViewTextBoxColumn.Name = "idlatihanDataGridViewTextBoxColumn";
            // 
            // jenislatihanDataGridViewTextBoxColumn
            // 
            this.jenislatihanDataGridViewTextBoxColumn.DataPropertyName = "Jenis_latihan";
            this.jenislatihanDataGridViewTextBoxColumn.HeaderText = "Jenis_latihan";
            this.jenislatihanDataGridViewTextBoxColumn.Name = "jenislatihanDataGridViewTextBoxColumn";
            // 
            // gerakangerakanDataGridViewTextBoxColumn
            // 
            this.gerakangerakanDataGridViewTextBoxColumn.DataPropertyName = "Gerakan_gerakan";
            this.gerakangerakanDataGridViewTextBoxColumn.HeaderText = "Gerakan_gerakan";
            this.gerakangerakanDataGridViewTextBoxColumn.Name = "gerakangerakanDataGridViewTextBoxColumn";
            // 
            // tgllatihanDataGridViewTextBoxColumn
            // 
            this.tgllatihanDataGridViewTextBoxColumn.DataPropertyName = "Tgl_latihan";
            this.tgllatihanDataGridViewTextBoxColumn.HeaderText = "Tgl_latihan";
            this.tgllatihanDataGridViewTextBoxColumn.Name = "tgllatihanDataGridViewTextBoxColumn";
            // 
            // durasilatihanDataGridViewTextBoxColumn
            // 
            this.durasilatihanDataGridViewTextBoxColumn.DataPropertyName = "Durasi_latihan";
            this.durasilatihanDataGridViewTextBoxColumn.HeaderText = "Durasi_latihan";
            this.durasilatihanDataGridViewTextBoxColumn.Name = "durasilatihanDataGridViewTextBoxColumn";
            // 
            // idmemberDataGridViewTextBoxColumn
            // 
            this.idmemberDataGridViewTextBoxColumn.DataPropertyName = "Id_member";
            this.idmemberDataGridViewTextBoxColumn.HeaderText = "Id_member";
            this.idmemberDataGridViewTextBoxColumn.Name = "idmemberDataGridViewTextBoxColumn";
            // 
            // idtrainerDataGridViewTextBoxColumn
            // 
            this.idtrainerDataGridViewTextBoxColumn.DataPropertyName = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.HeaderText = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.Name = "idtrainerDataGridViewTextBoxColumn";
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
            this.backBtn.TabIndex = 43;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cari
            // 
            this.cari.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cari.Location = new System.Drawing.Point(896, 551);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(96, 46);
            this.cari.TabIndex = 42;
            this.cari.Text = "Cari";
            this.cari.UseVisualStyleBackColor = true;
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxID.Location = new System.Drawing.Point(799, 481);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(305, 35);
            this.textBoxID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(610, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cari ID Latihan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Menu Update Latihan";
            // 
            // id_trainer
            // 
            this.id_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_trainer.Location = new System.Drawing.Point(275, 517);
            this.id_trainer.Multiline = true;
            this.id_trainer.Name = "id_trainer";
            this.id_trainer.Size = new System.Drawing.Size(305, 35);
            this.id_trainer.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = "Masukan Id Trainer";
            // 
            // id_member
            // 
            this.id_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_member.Location = new System.Drawing.Point(275, 460);
            this.id_member.Multiline = true;
            this.id_member.Name = "id_member";
            this.id_member.Size = new System.Drawing.Size(305, 35);
            this.id_member.TabIndex = 74;
            // 
            // tanggal
            // 
            this.tanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(277, 347);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(305, 20);
            this.tanggal.TabIndex = 73;
            // 
            // durasi
            // 
            this.durasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durasi.Location = new System.Drawing.Point(275, 404);
            this.durasi.Multiline = true;
            this.durasi.Name = "durasi";
            this.durasi.Size = new System.Drawing.Size(305, 35);
            this.durasi.TabIndex = 72;
            // 
            // gerakan
            // 
            this.gerakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gerakan.Location = new System.Drawing.Point(275, 274);
            this.gerakan.Multiline = true;
            this.gerakan.Name = "gerakan";
            this.gerakan.Size = new System.Drawing.Size(305, 35);
            this.gerakan.TabIndex = 71;
            // 
            // latihan
            // 
            this.latihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.latihan.Location = new System.Drawing.Point(275, 213);
            this.latihan.Multiline = true;
            this.latihan.Name = "latihan";
            this.latihan.Size = new System.Drawing.Size(305, 35);
            this.latihan.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Masukan Id Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Masukan Durasi Latihan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Masukan Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Masukan Gerakan Latihan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Masukan Jenis Latihan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Masukan ID";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(275, 153);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(305, 35);
            this.ID.TabIndex = 63;
            // 
            // updatelatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.id_trainer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_member);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.durasi);
            this.Controls.Add(this.gerakan);
            this.Controls.Add(this.latihan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatelatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatelatihan";
            this.Load += new System.EventHandler(this.updatelatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riwayatlatihanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GYMDataSet2TableAdapters.Riwayat_latihanTableAdapter riwayat_latihanTableAdapter;
        private GYMDataSet2 gYMDataSet2;
        private System.Windows.Forms.BindingSource riwayatlatihanBindingSource;
        private System.Windows.Forms.BindingSource latihanBindingSource;
        private GYMDataSet2TableAdapters.LatihanTableAdapter latihanTableAdapter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_trainer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_member;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.TextBox durasi;
        private System.Windows.Forms.TextBox gerakan;
        private System.Windows.Forms.TextBox latihan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenislatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerakangerakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasilatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainerDataGridViewTextBoxColumn;
    }
}