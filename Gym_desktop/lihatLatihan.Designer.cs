namespace Gym_desktop
{
    partial class lihatLatihan
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.riwayat_latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.Riwayat_latihanTableAdapter();
            this.gYMDataSet2 = new Gym_desktop.GYMDataSet2();
            this.riwayatlatihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.latihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latihanTableAdapter = new Gym_desktop.GYMDataSet2TableAdapters.LatihanTableAdapter();
            this.idlatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenislatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerakangerakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasilatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riwayatlatihanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Menu Lihat Latihan";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlatihanDataGridViewTextBoxColumn,
            this.Id_member,
            this.Id_trainer,
            this.jenislatihanDataGridViewTextBoxColumn,
            this.gerakangerakanDataGridViewTextBoxColumn,
            this.tgllatihanDataGridViewTextBoxColumn,
            this.durasilatihanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.latihanBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(225, 159);
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
            this.dataGridView1.Size = new System.Drawing.Size(704, 296);
            this.dataGridView1.TabIndex = 22;
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
            // Id_member
            // 
            this.Id_member.DataPropertyName = "Id_member";
            this.Id_member.HeaderText = "Id_member";
            this.Id_member.Name = "Id_member";
            this.Id_member.ReadOnly = true;
            // 
            // Id_trainer
            // 
            this.Id_trainer.DataPropertyName = "Id_trainer";
            this.Id_trainer.HeaderText = "Id_trainer";
            this.Id_trainer.Name = "Id_trainer";
            this.Id_trainer.ReadOnly = true;
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
            // lihatLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lihatLatihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lihatLatihan";
            this.Load += new System.EventHandler(this.lihatLatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riwayatlatihanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latihanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private GYMDataSet2TableAdapters.Riwayat_latihanTableAdapter riwayat_latihanTableAdapter;
        private GYMDataSet2 gYMDataSet2;
        private System.Windows.Forms.BindingSource riwayatlatihanBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource latihanBindingSource;
        private GYMDataSet2TableAdapters.LatihanTableAdapter latihanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenislatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerakangerakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllatihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasilatihanDataGridViewTextBoxColumn;
    }
}