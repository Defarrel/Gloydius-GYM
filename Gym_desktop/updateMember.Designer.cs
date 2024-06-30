namespace Gym_desktop
{
    partial class updateMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gYMDataSet = new Gym_desktop.GYMDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.memberTableAdapter = new Gym_desktop.GYMDataSetTableAdapters.MemberTableAdapter();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.gambar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.tenggat = new System.Windows.Forms.DateTimePicker();
            this.daftar = new System.Windows.Forms.DateTimePicker();
            this.no_hp = new System.Windows.Forms.TextBox();
            this.umur = new System.Windows.Forms.TextBox();
            this.berat_badan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beratbdnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgldaftarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgltenggatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambarDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Update Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(610, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari Nama Member";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxID.Location = new System.Drawing.Point(799, 481);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(305, 35);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(896, 551);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 46);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Cari";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.namamemberDataGridViewTextBoxColumn,
            this.beratbdnDataGridViewTextBoxColumn,
            this.umurDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.tgldaftarDataGridViewTextBoxColumn,
            this.tgltenggatDataGridViewTextBoxColumn,
            this.gambarDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(613, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Size = new System.Drawing.Size(507, 273);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.gYMDataSet;
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
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.RefreshButton.Location = new System.Drawing.Point(1008, 551);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(96, 46);
            this.RefreshButton.TabIndex = 21;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click_1);
            // 
            // gambar
            // 
            this.gambar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gambar.Location = new System.Drawing.Point(403, 514);
            this.gambar.Multiline = true;
            this.gambar.Name = "gambar";
            this.gambar.Size = new System.Drawing.Size(182, 24);
            this.gambar.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Masukan Foto";
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(280, 511);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(105, 31);
            this.upload.TabIndex = 34;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // tenggat
            // 
            this.tenggat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenggat.Location = new System.Drawing.Point(280, 462);
            this.tenggat.Name = "tenggat";
            this.tenggat.Size = new System.Drawing.Size(305, 20);
            this.tenggat.TabIndex = 33;
            // 
            // daftar
            // 
            this.daftar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftar.Location = new System.Drawing.Point(280, 406);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(305, 20);
            this.daftar.TabIndex = 32;
            // 
            // no_hp
            // 
            this.no_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.no_hp.Location = new System.Drawing.Point(280, 332);
            this.no_hp.Multiline = true;
            this.no_hp.Name = "no_hp";
            this.no_hp.Size = new System.Drawing.Size(305, 35);
            this.no_hp.TabIndex = 31;
            // 
            // umur
            // 
            this.umur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.umur.Location = new System.Drawing.Point(280, 274);
            this.umur.Multiline = true;
            this.umur.Name = "umur";
            this.umur.Size = new System.Drawing.Size(305, 35);
            this.umur.TabIndex = 30;
            // 
            // berat_badan
            // 
            this.berat_badan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.berat_badan.Location = new System.Drawing.Point(280, 213);
            this.berat_badan.Multiline = true;
            this.berat_badan.Name = "berat_badan";
            this.berat_badan.Size = new System.Drawing.Size(305, 35);
            this.berat_badan.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Masukan Tanggal Tenggat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Masukan Tanggal Daftar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Masukan Nomor Hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Masukan Umur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Masukan Berat Badan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Masukan Nama";
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(280, 153);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(305, 35);
            this.nama.TabIndex = 22;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(781, 551);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 46);
            this.update.TabIndex = 37;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(80, 87);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(305, 35);
            this.ID.TabIndex = 39;
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_member";
            this.Column1.HeaderText = "id_member";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // namamemberDataGridViewTextBoxColumn
            // 
            this.namamemberDataGridViewTextBoxColumn.DataPropertyName = "Nama_member";
            this.namamemberDataGridViewTextBoxColumn.HeaderText = "Nama_member";
            this.namamemberDataGridViewTextBoxColumn.Name = "namamemberDataGridViewTextBoxColumn";
            this.namamemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beratbdnDataGridViewTextBoxColumn
            // 
            this.beratbdnDataGridViewTextBoxColumn.DataPropertyName = "Berat_bdn";
            this.beratbdnDataGridViewTextBoxColumn.HeaderText = "Berat_bdn";
            this.beratbdnDataGridViewTextBoxColumn.Name = "beratbdnDataGridViewTextBoxColumn";
            this.beratbdnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // umurDataGridViewTextBoxColumn
            // 
            this.umurDataGridViewTextBoxColumn.DataPropertyName = "Umur";
            this.umurDataGridViewTextBoxColumn.HeaderText = "Umur";
            this.umurDataGridViewTextBoxColumn.Name = "umurDataGridViewTextBoxColumn";
            this.umurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "No_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "No_hp";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            this.nohpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgldaftarDataGridViewTextBoxColumn
            // 
            this.tgldaftarDataGridViewTextBoxColumn.DataPropertyName = "Tgl_daftar";
            this.tgldaftarDataGridViewTextBoxColumn.HeaderText = "Tgl_daftar";
            this.tgldaftarDataGridViewTextBoxColumn.Name = "tgldaftarDataGridViewTextBoxColumn";
            this.tgldaftarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgltenggatDataGridViewTextBoxColumn
            // 
            this.tgltenggatDataGridViewTextBoxColumn.DataPropertyName = "Tgl_tenggat";
            this.tgltenggatDataGridViewTextBoxColumn.HeaderText = "Tgl_tenggat";
            this.tgltenggatDataGridViewTextBoxColumn.Name = "tgltenggatDataGridViewTextBoxColumn";
            this.tgltenggatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gambarDataGridViewImageColumn
            // 
            this.gambarDataGridViewImageColumn.DataPropertyName = "Gambar";
            this.gambarDataGridViewImageColumn.HeaderText = "Gambar";
            this.gambarDataGridViewImageColumn.Name = "gambarDataGridViewImageColumn";
            this.gambarDataGridViewImageColumn.ReadOnly = true;
            // 
            // updateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.gambar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.tenggat);
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.no_hp);
            this.Controls.Add(this.umur);
            this.Controls.Add(this.berat_badan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateMember";
            this.Load += new System.EventHandler(this.updateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button backBtn;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GYMDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox gambar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.DateTimePicker tenggat;
        private System.Windows.Forms.DateTimePicker daftar;
        private System.Windows.Forms.TextBox no_hp;
        private System.Windows.Forms.TextBox umur;
        private System.Windows.Forms.TextBox berat_badan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beratbdnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgldaftarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgltenggatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gambarDataGridViewImageColumn;
        private System.Windows.Forms.TextBox ID;
    }
}