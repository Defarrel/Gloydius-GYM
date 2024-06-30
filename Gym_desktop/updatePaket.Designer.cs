namespace Gym_desktop
{
    partial class updatePaket
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
            this.paketMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet1 = new Gym_desktop.GYMDataSet1();
            this.paketMemberTableAdapter = new Gym_desktop.GYMDataSet1TableAdapters.PaketMemberTableAdapter();
            this.update = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasipaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.durasi = new System.Windows.Forms.TextBox();
            this.harga_paket = new System.Windows.Forms.TextBox();
            this.nama_paket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_paket = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // paketMemberBindingSource
            // 
            this.paketMemberBindingSource.DataMember = "PaketMember";
            this.paketMemberBindingSource.DataSource = this.gYMDataSet1;
            // 
            // gYMDataSet1
            // 
            this.gYMDataSet1.DataSetName = "GYMDataSet1";
            this.gYMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paketMemberTableAdapter
            // 
            this.paketMemberTableAdapter.ClearBeforeFill = true;
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
            this.idpaketDataGridViewTextBoxColumn,
            this.namapaketDataGridViewTextBoxColumn,
            this.hargapaketDataGridViewTextBoxColumn,
            this.durasipaketDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paketMemberBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(668, 153);
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
            this.dataGridView1.Size = new System.Drawing.Size(405, 273);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idpaketDataGridViewTextBoxColumn
            // 
            this.idpaketDataGridViewTextBoxColumn.DataPropertyName = "Id_paket";
            this.idpaketDataGridViewTextBoxColumn.HeaderText = "Id_paket";
            this.idpaketDataGridViewTextBoxColumn.Name = "idpaketDataGridViewTextBoxColumn";
            // 
            // namapaketDataGridViewTextBoxColumn
            // 
            this.namapaketDataGridViewTextBoxColumn.DataPropertyName = "Nama_paket";
            this.namapaketDataGridViewTextBoxColumn.HeaderText = "Nama_paket";
            this.namapaketDataGridViewTextBoxColumn.Name = "namapaketDataGridViewTextBoxColumn";
            // 
            // hargapaketDataGridViewTextBoxColumn
            // 
            this.hargapaketDataGridViewTextBoxColumn.DataPropertyName = "Harga_paket";
            this.hargapaketDataGridViewTextBoxColumn.HeaderText = "Harga_paket";
            this.hargapaketDataGridViewTextBoxColumn.Name = "hargapaketDataGridViewTextBoxColumn";
            // 
            // durasipaketDataGridViewTextBoxColumn
            // 
            this.durasipaketDataGridViewTextBoxColumn.DataPropertyName = "Durasi_paket";
            this.durasipaketDataGridViewTextBoxColumn.HeaderText = "Durasi_paket";
            this.durasipaketDataGridViewTextBoxColumn.Name = "durasipaketDataGridViewTextBoxColumn";
            // 
            // paketMemberBindingSource1
            // 
            this.paketMemberBindingSource1.DataMember = "PaketMember";
            this.paketMemberBindingSource1.DataSource = this.gYMDataSet1;
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
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cari Nama Paket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Menu Update Paket Member";
            // 
            // durasi
            // 
            this.durasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.durasi.Location = new System.Drawing.Point(292, 332);
            this.durasi.Multiline = true;
            this.durasi.Name = "durasi";
            this.durasi.Size = new System.Drawing.Size(305, 35);
            this.durasi.TabIndex = 70;
            // 
            // harga_paket
            // 
            this.harga_paket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.harga_paket.Location = new System.Drawing.Point(292, 274);
            this.harga_paket.Multiline = true;
            this.harga_paket.Name = "harga_paket";
            this.harga_paket.Size = new System.Drawing.Size(305, 35);
            this.harga_paket.TabIndex = 69;
            // 
            // nama_paket
            // 
            this.nama_paket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nama_paket.Location = new System.Drawing.Point(292, 213);
            this.nama_paket.Multiline = true;
            this.nama_paket.Name = "nama_paket";
            this.nama_paket.Size = new System.Drawing.Size(305, 35);
            this.nama_paket.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Masukan Durasi Paket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Masukan Harga Paket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Masukan Nama Paket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Masukan ID paket";
            // 
            // id_paket
            // 
            this.id_paket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_paket.Location = new System.Drawing.Point(292, 153);
            this.id_paket.Multiline = true;
            this.id_paket.Name = "id_paket";
            this.id_paket.Size = new System.Drawing.Size(305, 35);
            this.id_paket.TabIndex = 63;
            // 
            // updatePaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.durasi);
            this.Controls.Add(this.harga_paket);
            this.Controls.Add(this.nama_paket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_paket);
            this.Controls.Add(this.update);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatePaket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatePaket";
            this.Load += new System.EventHandler(this.updatePaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GYMDataSet1 gYMDataSet1;
        private System.Windows.Forms.BindingSource paketMemberBindingSource;
        private GYMDataSet1TableAdapters.PaketMemberTableAdapter paketMemberTableAdapter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasipaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paketMemberBindingSource1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox durasi;
        private System.Windows.Forms.TextBox harga_paket;
        private System.Windows.Forms.TextBox nama_paket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_paket;
    }
}