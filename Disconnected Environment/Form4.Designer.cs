namespace Disconnected_Environment
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbNama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.cbTahunMasuk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpen.Location = new System.Drawing.Point(705, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(74, 33);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Location = new System.Drawing.Point(507, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.Location = new System.Drawing.Point(507, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 33);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.Location = new System.Drawing.Point(507, 286);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 33);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(359, 293);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 21);
            this.cbxNama.TabIndex = 19;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(359, 407);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 21);
            this.cbxTahunMasuk.TabIndex = 20;
            this.cbxTahunMasuk.SelectedIndexChanged += new System.EventHandler(this.cbxTahunMasuk_SelectedIndexChanged);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(359, 363);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 21);
            this.cbxStatusMahasiswa.TabIndex = 21;
            this.cbxStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMahasiswa_SelectedIndexChanged);
            // 
            // cbNama
            // 
            this.cbNama.AutoSize = true;
            this.cbNama.Location = new System.Drawing.Point(207, 296);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(91, 13);
            this.cbNama.TabIndex = 22;
            this.cbNama.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nomor Induk Mahasiswa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(356, 332);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(38, 13);
            this.txtNIM.TabIndex = 24;
            this.txtNIM.Text = "txtNIM";
            // 
            // cbTahunMasuk
            // 
            this.cbTahunMasuk.AutoSize = true;
            this.cbTahunMasuk.Location = new System.Drawing.Point(207, 410);
            this.cbTahunMasuk.Name = "cbTahunMasuk";
            this.cbTahunMasuk.Size = new System.Drawing.Size(73, 13);
            this.cbTahunMasuk.TabIndex = 25;
            this.cbTahunMasuk.Text = "Tahun Masuk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Status Mahasiwa";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTahunMasuk);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNama);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.Label cbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Label cbTahunMasuk;
        private System.Windows.Forms.Label label5;
    }
}