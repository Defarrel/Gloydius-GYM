namespace Gym_desktop
{
    partial class hapusPaket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.hapus_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.gYMDataSet1 = new Gym_desktop.GYMDataSet1();
            this.paketMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paketMemberTableAdapter = new Gym_desktop.GYMDataSet1TableAdapters.PaketMemberTableAdapter();
            this.paketMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasipaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Hapus Paket Member";
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHapus.Location = new System.Drawing.Point(778, 485);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(126, 62);
            this.btnHapus.TabIndex = 20;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // hapus_text
            // 
            this.hapus_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_text.Location = new System.Drawing.Point(352, 505);
            this.hapus_text.Multiline = true;
            this.hapus_text.Name = "hapus_text";
            this.hapus_text.Size = new System.Drawing.Size(305, 35);
            this.hapus_text.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Masukan ID yang Ingin dihapus";
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
            this.backBtn.TabIndex = 21;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // gYMDataSet1
            // 
            this.gYMDataSet1.DataSetName = "GYMDataSet1";
            this.gYMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paketMemberBindingSource
            // 
            this.paketMemberBindingSource.DataMember = "PaketMember";
            this.paketMemberBindingSource.DataSource = this.gYMDataSet1;
            // 
            // paketMemberTableAdapter
            // 
            this.paketMemberTableAdapter.ClearBeforeFill = true;
            // 
            // paketMemberBindingSource1
            // 
            this.paketMemberBindingSource1.DataMember = "PaketMember";
            this.paketMemberBindingSource1.DataSource = this.gYMDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpaketDataGridViewTextBoxColumn,
            this.namapaketDataGridViewTextBoxColumn,
            this.hargapaketDataGridViewTextBoxColumn,
            this.durasipaketDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paketMemberBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(326, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Size = new System.Drawing.Size(402, 296);
            this.dataGridView1.TabIndex = 22;
            // 
            // idpaketDataGridViewTextBoxColumn
            // 
            this.idpaketDataGridViewTextBoxColumn.DataPropertyName = "Id_paket";
            this.idpaketDataGridViewTextBoxColumn.HeaderText = "Id Paket";
            this.idpaketDataGridViewTextBoxColumn.Name = "idpaketDataGridViewTextBoxColumn";
            this.idpaketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namapaketDataGridViewTextBoxColumn
            // 
            this.namapaketDataGridViewTextBoxColumn.DataPropertyName = "Nama_paket";
            this.namapaketDataGridViewTextBoxColumn.HeaderText = "Nama Paket";
            this.namapaketDataGridViewTextBoxColumn.Name = "namapaketDataGridViewTextBoxColumn";
            this.namapaketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargapaketDataGridViewTextBoxColumn
            // 
            this.hargapaketDataGridViewTextBoxColumn.DataPropertyName = "Harga_paket";
            this.hargapaketDataGridViewTextBoxColumn.HeaderText = "Harga Paket";
            this.hargapaketDataGridViewTextBoxColumn.Name = "hargapaketDataGridViewTextBoxColumn";
            this.hargapaketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durasipaketDataGridViewTextBoxColumn
            // 
            this.durasipaketDataGridViewTextBoxColumn.DataPropertyName = "Durasi_paket";
            this.durasipaketDataGridViewTextBoxColumn.HeaderText = "Durasi Paket";
            this.durasipaketDataGridViewTextBoxColumn.Name = "durasipaketDataGridViewTextBoxColumn";
            this.durasipaketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hapusPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.hapus_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paketMemberBindingSource, "Id_paket", true));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hapusPaket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hapusPaket";
            this.Load += new System.EventHandler(this.hapusPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox hapus_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private GYMDataSet1 gYMDataSet1;
        private System.Windows.Forms.BindingSource paketMemberBindingSource;
        private GYMDataSet1TableAdapters.PaketMemberTableAdapter paketMemberTableAdapter;
        private System.Windows.Forms.BindingSource paketMemberBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasipaketDataGridViewTextBoxColumn;
    }
}