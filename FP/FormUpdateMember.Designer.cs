namespace FP
{
    partial class FormUpdateMember
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
            this._BacktoMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pELANGGANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMember = new FP.DataMember();
            this.label5 = new System.Windows.Forms.Label();
            this.comboMemberGanti = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gantiDengan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataMobil = new FP.DataMobil();
            this.mOBILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOBILTableAdapter = new FP.DataMobilTableAdapters.MOBILTableAdapter();
            this.pELANGGANTableAdapter = new FP.DataMemberTableAdapters.PELANGGANTableAdapter();
            this.udpateButton = new System.Windows.Forms.Button();
            this.tanggalBaru = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pELANGGANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pELANGGANBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pELANGGANBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // _BacktoMenu
            // 
            this._BacktoMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this._BacktoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._BacktoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BacktoMenu.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BacktoMenu.ForeColor = System.Drawing.Color.White;
            this._BacktoMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._BacktoMenu.Location = new System.Drawing.Point(710, 12);
            this._BacktoMenu.Name = "_BacktoMenu";
            this._BacktoMenu.Size = new System.Drawing.Size(78, 31);
            this._BacktoMenu.TabIndex = 104;
            this._BacktoMenu.Text = "Back";
            this._BacktoMenu.UseVisualStyleBackColor = false;
            this._BacktoMenu.Click += new System.EventHandler(this._BacktoMenu_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 102;
            this.label1.Text = "AutoExpress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "the best partner for your mobility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 37);
            this.label4.TabIndex = 105;
            this.label4.Text = "MemberUpdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(448, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 106;
            this.label3.Text = "MemberDelete";
            // 
            // pELANGGANBindingSource
            // 
            this.pELANGGANBindingSource.DataMember = "PELANGGAN";
            this.pELANGGANBindingSource.DataSource = this.dataMember;
            // 
            // dataMember
            // 
            this.dataMember.DataSetName = "DataMember";
            this.dataMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 108;
            this.label5.Text = "ID Member";
            // 
            // comboMemberGanti
            // 
            this.comboMemberGanti.FormattingEnabled = true;
            this.comboMemberGanti.Items.AddRange(new object[] {
            "NAMA_LENGKAP",
            "TEMPAT_LAHIR",
            "TANGGAL_LAHIR",
            "WARGA_NEGARA",
            "JENIS_IDENTITAS",
            "NO_IDENTITAS",
            "J_KEL",
            "ALAMAT",
            "NO_HP",
            "NO_TELP",
            "TANGGAL_BERGABUNG",
            "FOTO_PELANGGAN"});
            this.comboMemberGanti.Location = new System.Drawing.Point(148, 178);
            this.comboMemberGanti.Name = "comboMemberGanti";
            this.comboMemberGanti.Size = new System.Drawing.Size(181, 25);
            this.comboMemberGanti.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Change Data";
            // 
            // gantiDengan
            // 
            this.gantiDengan.Location = new System.Drawing.Point(148, 209);
            this.gantiDengan.Name = "gantiDengan";
            this.gantiDengan.Size = new System.Drawing.Size(181, 25);
            this.gantiDengan.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 114;
            this.label8.Text = "Ganti Dengan";
            // 
            // dataMobil
            // 
            this.dataMobil.DataSetName = "DataMobil";
            this.dataMobil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOBILBindingSource
            // 
            this.mOBILBindingSource.DataMember = "MOBIL";
            this.mOBILBindingSource.DataSource = this.dataMobil;
            // 
            // mOBILTableAdapter
            // 
            this.mOBILTableAdapter.ClearBeforeFill = true;
            // 
            // pELANGGANTableAdapter
            // 
            this.pELANGGANTableAdapter.ClearBeforeFill = true;
            // 
            // udpateButton
            // 
            this.udpateButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.udpateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.udpateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.udpateButton.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateButton.ForeColor = System.Drawing.Color.White;
            this.udpateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.udpateButton.Location = new System.Drawing.Point(251, 305);
            this.udpateButton.Name = "udpateButton";
            this.udpateButton.Size = new System.Drawing.Size(78, 31);
            this.udpateButton.TabIndex = 115;
            this.udpateButton.Text = "Update";
            this.udpateButton.UseVisualStyleBackColor = false;
            this.udpateButton.Click += new System.EventHandler(this.udpateButton_Click);
            // 
            // tanggalBaru
            // 
            this.tanggalBaru.Location = new System.Drawing.Point(149, 240);
            this.tanggalBaru.Name = "tanggalBaru";
            this.tanggalBaru.Size = new System.Drawing.Size(180, 25);
            this.tanggalBaru.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 118;
            this.label7.Text = "ID Member";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(690, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 134;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pELANGGANBindingSource1
            // 
            this.pELANGGANBindingSource1.DataMember = "PELANGGAN";
            this.pELANGGANBindingSource1.DataSource = this.dataMember;
            // 
            // pELANGGANBindingSource2
            // 
            this.pELANGGANBindingSource2.DataMember = "PELANGGAN";
            this.pELANGGANBindingSource2.DataSource = this.dataMember;
            // 
            // pELANGGANBindingSource3
            // 
            this.pELANGGANBindingSource3.DataMember = "PELANGGAN";
            this.pELANGGANBindingSource3.DataSource = this.dataMember;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 25);
            this.textBox1.TabIndex = 135;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(587, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 25);
            this.textBox2.TabIndex = 136;
            // 
            // FormUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tanggalBaru);
            this.Controls.Add(this.udpateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gantiDengan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboMemberGanti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._BacktoMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateMember";
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELANGGANBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _BacktoMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMemberGanti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gantiDengan;
        private System.Windows.Forms.Label label8;
        private DataMobil dataMobil;
        private System.Windows.Forms.BindingSource mOBILBindingSource;
        private DataMobilTableAdapters.MOBILTableAdapter mOBILTableAdapter;
        private DataMember dataMember;
        private System.Windows.Forms.BindingSource pELANGGANBindingSource;
        private DataMemberTableAdapters.PELANGGANTableAdapter pELANGGANTableAdapter;
        private System.Windows.Forms.Button udpateButton;
        private System.Windows.Forms.DateTimePicker tanggalBaru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pELANGGANBindingSource2;
        private System.Windows.Forms.BindingSource pELANGGANBindingSource1;
        private System.Windows.Forms.BindingSource pELANGGANBindingSource3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}