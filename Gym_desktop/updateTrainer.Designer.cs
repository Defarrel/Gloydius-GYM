namespace Gym_desktop
{
    partial class updateTrainer
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
            this.personalTrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet = new Gym_desktop.GYMDataSet();
            this.personalTrainerTableAdapter = new Gym_desktop.GYMDataSetTableAdapters.PersonalTrainerTableAdapter();
            this.update = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namatrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohptrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTrainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.no_hp = new System.Windows.Forms.TextBox();
            this.nama_trainer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_trainer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // personalTrainerBindingSource
            // 
            this.personalTrainerBindingSource.DataMember = "PersonalTrainer";
            this.personalTrainerBindingSource.DataSource = this.gYMDataSet;
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTrainerTableAdapter
            // 
            this.personalTrainerTableAdapter.ClearBeforeFill = true;
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
            this.idtrainerDataGridViewTextBoxColumn,
            this.namatrainerDataGridViewTextBoxColumn,
            this.nohptrainerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalTrainerBindingSource1;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(718, 153);
            this.dataGridView1.Name = "dataGridView1";
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
            this.dataGridView1.Size = new System.Drawing.Size(303, 273);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idtrainerDataGridViewTextBoxColumn
            // 
            this.idtrainerDataGridViewTextBoxColumn.DataPropertyName = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.HeaderText = "Id_trainer";
            this.idtrainerDataGridViewTextBoxColumn.Name = "idtrainerDataGridViewTextBoxColumn";
            // 
            // namatrainerDataGridViewTextBoxColumn
            // 
            this.namatrainerDataGridViewTextBoxColumn.DataPropertyName = "Nama_trainer";
            this.namatrainerDataGridViewTextBoxColumn.HeaderText = "Nama_trainer";
            this.namatrainerDataGridViewTextBoxColumn.Name = "namatrainerDataGridViewTextBoxColumn";
            // 
            // nohptrainerDataGridViewTextBoxColumn
            // 
            this.nohptrainerDataGridViewTextBoxColumn.DataPropertyName = "No_hp_trainer";
            this.nohptrainerDataGridViewTextBoxColumn.HeaderText = "No_hp_trainer";
            this.nohptrainerDataGridViewTextBoxColumn.Name = "nohptrainerDataGridViewTextBoxColumn";
            // 
            // personalTrainerBindingSource1
            // 
            this.personalTrainerBindingSource1.DataMember = "PersonalTrainer";
            this.personalTrainerBindingSource1.DataSource = this.gYMDataSet;
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
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cari Nama Trainer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Menu Update Trainer";
            // 
            // no_hp
            // 
            this.no_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.no_hp.Location = new System.Drawing.Point(284, 274);
            this.no_hp.Multiline = true;
            this.no_hp.Name = "no_hp";
            this.no_hp.Size = new System.Drawing.Size(305, 35);
            this.no_hp.TabIndex = 68;
            // 
            // nama_trainer
            // 
            this.nama_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nama_trainer.Location = new System.Drawing.Point(284, 213);
            this.nama_trainer.Multiline = true;
            this.nama_trainer.Name = "nama_trainer";
            this.nama_trainer.Size = new System.Drawing.Size(305, 35);
            this.nama_trainer.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Masukan Harga Nomor HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Masukan Nama Trainer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Masukan ID trainer";
            // 
            // id_trainer
            // 
            this.id_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_trainer.Location = new System.Drawing.Point(284, 153);
            this.id_trainer.Multiline = true;
            this.id_trainer.Name = "id_trainer";
            this.id_trainer.Size = new System.Drawing.Size(305, 35);
            this.id_trainer.TabIndex = 63;
            // 
            // updateTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1132, 672);
            this.Controls.Add(this.no_hp);
            this.Controls.Add(this.nama_trainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_trainer);
            this.Controls.Add(this.update);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateTrainer";
            this.Load += new System.EventHandler(this.updateTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalTrainerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.BindingSource personalTrainerBindingSource;
        private GYMDataSetTableAdapters.PersonalTrainerTableAdapter personalTrainerTableAdapter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox no_hp;
        private System.Windows.Forms.TextBox nama_trainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namatrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohptrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personalTrainerBindingSource1;
    }
}