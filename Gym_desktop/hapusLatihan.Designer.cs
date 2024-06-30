namespace Gym_desktop
{
    partial class hapusLatihan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.hapus_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gYMDataSet2 = new Gym_desktop.GYMDataSet2();
            this.latihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.LatihanTableAdapter();
            this.idlatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenislatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerakangerakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasilatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(208, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.dataGridView1.Size = new System.Drawing.Size(705, 273);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHapus.Location = new System.Drawing.Point(841, 473);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(126, 62);
            this.btnHapus.TabIndex = 26;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            this.backBtn.TabIndex = 25;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // hapus_text
            // 
            this.hapus_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_text.Location = new System.Drawing.Point(399, 493);
            this.hapus_text.Multiline = true;
            this.hapus_text.Name = "hapus_text";
            this.hapus_text.Size = new System.Drawing.Size(305, 35);
            this.hapus_text.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Masukan ID yang Ingin dihapus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Menu Hapus Latihan";
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
            // idlatihanDataGridViewTextBoxColumn
            // 
            this.idlatihanDataGridViewTextBoxColumn.DataPropertyName = "Id_latihan";
            this.idlatihanDataGridViewTextBoxColumn.HeaderText = "Id_latihan";
            this.idlatihanDataGridViewTextBoxColumn.Name = "idlatihanDataGridViewTextBoxColumn";
            this.idlatihanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenislatihanDataGridViewTextBoxColumn
            // 
            this.jenislatihanDataGridViewTextBoxColumn.DataPropertyName = "Jenis_latihan";
            this.jenislatihanDataGridViewTextBoxColumn.HeaderText = "Jenis_latihan";
            this.jenislatihanDataGridViewTextBoxColumn.Name = "jenislatihanDataGridViewTextBoxColumn";
            this.jenislatihanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gerakangerakanDataGridViewTextBoxColumn
            // 
            this.gerakangerakanDataGridViewTextBoxColumn.DataPropertyName = "Gerakan_gerakan";
            this.gerakangerakanDataGridViewTextBoxColumn.HeaderText = "Gerakan_gerakan";
            this.gerakangerakanDataGridViewTextBoxColumn.Name = "gerakangerakanDataGridViewTextBoxColumn";
            this.gerakangerakanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgllatihanDataGridViewTextBoxColumn
            // 
            this.tgllatihanDataGridViewTextBoxColumn.DataPropertyName = "Tgl_latihan";
            this.tgllatihanDataGridViewTextBoxColumn.HeaderText = "Tgl_latihan";
            this.tgllatihanDataGridViewTextBoxColumn.Name = "tgllatihanDataGridViewTextBoxColumn";
            this.tgllatihanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durasilatihanDataGridViewTextBoxColumn
            // 
            this.durasilatihanDataGridViewTextBoxColumn.DataPropertyName = "Durasi_latihan";
            this.durasilatihanDataGridViewTextBoxColumn.HeaderText = "Durasi_latihan";
            this.durasilatihanDataGridViewTextBoxColumn.Name = "durasilatihanDataGridViewTextBoxColumn";
            this.durasilatihanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmemberDataGridViewTextBoxColumn
            // 
            this.idmemberDataGridViewTextBoxColumn.DataPropertyName = "Id_member";
            this.idmemberDataGridViewTextBoxColumn.HeaderText = "Id_member";
            this.idmemberDataGridViewTextBoxColumn.Name = "idmemberDataGridViewTextBoxColumn";
            this.idmemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtrainerDataGridViewTextBoxColumn
            // 
            this.idtrainerDataGridViewTextBoxColumn.DataPropertyName = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.HeaderText = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.Name = "idtrainerDataGridViewTextBoxColumn";
            this.idtrainerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hapusLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hapus_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hapusLatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hapusLatihan";
            this.Load += new System.EventHandler(this.hapusLatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox hapus_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GYMDataSet2 gYMDataSet2;
        private System.Windows.Forms.BindingSource latihanBindingSource;
        private GYMDataSet2TableAdapters.LatihanTableAdapter latihanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenislatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerakangerakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasilatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainerDataGridViewTextBoxColumn;
    }
}