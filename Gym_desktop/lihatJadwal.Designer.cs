﻿namespace Gym_desktop
{
    partial class lihatJadwal
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
            this.gYMDataSet = new Gym_desktop.GYMDataSet();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paketMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paketMemberTableAdapter = new Gym_desktop.GYMDataSetTableAdapters.PaketMemberTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jadwalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalTableAdapter = new Gym_desktop.GYMDataSetTableAdapters.JadwalTableAdapter();
            this.idjadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namajadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harilatihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.backBtn.TabIndex = 24;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Menu Lihat Jadwal";
            // 
            // paketMemberBindingSource
            // 
            this.paketMemberBindingSource.DataMember = "PaketMember";
            this.paketMemberBindingSource.DataSource = this.gYMDataSet;
            // 
            // paketMemberTableAdapter
            // 
            this.paketMemberTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjadwalDataGridViewTextBoxColumn,
            this.namajadwalDataGridViewTextBoxColumn,
            this.harilatihanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jadwalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(374, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(307, 296);
            this.dataGridView1.TabIndex = 25;
            // 
            // jadwalBindingSource
            // 
            this.jadwalBindingSource.DataMember = "Jadwal";
            this.jadwalBindingSource.DataSource = this.gYMDataSet;
            // 
            // jadwalTableAdapter
            // 
            this.jadwalTableAdapter.ClearBeforeFill = true;
            // 
            // idjadwalDataGridViewTextBoxColumn
            // 
            this.idjadwalDataGridViewTextBoxColumn.DataPropertyName = "Id_jadwal";
            this.idjadwalDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idjadwalDataGridViewTextBoxColumn.Name = "idjadwalDataGridViewTextBoxColumn";
            this.idjadwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namajadwalDataGridViewTextBoxColumn
            // 
            this.namajadwalDataGridViewTextBoxColumn.DataPropertyName = "Nama_jadwal";
            this.namajadwalDataGridViewTextBoxColumn.HeaderText = "Nama Jadwal";
            this.namajadwalDataGridViewTextBoxColumn.Name = "namajadwalDataGridViewTextBoxColumn";
            this.namajadwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // harilatihanDataGridViewTextBoxColumn
            // 
            this.harilatihanDataGridViewTextBoxColumn.DataPropertyName = "Hari_latihan";
            this.harilatihanDataGridViewTextBoxColumn.HeaderText = "Hari Latihan";
            this.harilatihanDataGridViewTextBoxColumn.Name = "harilatihanDataGridViewTextBoxColumn";
            this.harilatihanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lihatJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lihatJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lihat_jadwal";
            this.Load += new System.EventHandler(this.lihatJadwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.BindingSource paketMemberBindingSource;
        private GYMDataSetTableAdapters.PaketMemberTableAdapter paketMemberTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jadwalBindingSource;
        private GYMDataSetTableAdapters.JadwalTableAdapter jadwalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namajadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harilatihanDataGridViewTextBoxColumn;
    }
}