namespace FP
{
    partial class formUpdateMobil
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tanggalBaru2 = new System.Windows.Forms.DateTimePicker();
            this.udpateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gantiWith = new System.Windows.Forms.TextBox();
            this.comboCarGanti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mOBILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataMobil = new FP.DataMobil();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._BacktoMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mOBILTableAdapter = new FP.DataMobilTableAdapters.MOBILTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(691, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 149;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(455, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 148;
            this.label6.Text = "ID Mobil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 146;
            this.label7.Text = "Change Data";
            // 
            // tanggalBaru2
            // 
            this.tanggalBaru2.Location = new System.Drawing.Point(149, 240);
            this.tanggalBaru2.Name = "tanggalBaru2";
            this.tanggalBaru2.Size = new System.Drawing.Size(180, 20);
            this.tanggalBaru2.TabIndex = 145;
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
            this.udpateButton.TabIndex = 144;
            this.udpateButton.Text = "Update";
            this.udpateButton.UseVisualStyleBackColor = false;
            this.udpateButton.Click += new System.EventHandler(this.udpateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 143;
            this.label8.Text = "Ganti Dengan";
            // 
            // gantiWith
            // 
            this.gantiWith.Location = new System.Drawing.Point(148, 209);
            this.gantiWith.Name = "gantiWith";
            this.gantiWith.Size = new System.Drawing.Size(181, 20);
            this.gantiWith.TabIndex = 142;
            // 
            // comboCarGanti
            // 
            this.comboCarGanti.FormattingEnabled = true;
            this.comboCarGanti.Items.AddRange(new object[] {
            "MERK_MOBIL",
            "JENIS_MOBIL",
            "TAHUN_PEMBUATAN",
            "ISI_SILINDER",
            "NO_RANGKA_MOBIL",
            "NO_MESIN_MOBIL",
            "WARNA",
            "BAHAN_BAKAR",
            "GOLONGAN_MOBIL",
            "HARGA_SEWA",
            "STATUS_SEWA",
            "FOTO_MOBIL"});
            this.comboCarGanti.Location = new System.Drawing.Point(148, 178);
            this.comboCarGanti.Name = "comboCarGanti";
            this.comboCarGanti.Size = new System.Drawing.Size(181, 21);
            this.comboCarGanti.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 140;
            this.label5.Text = "ID Mobil";
            // 
            // mOBILBindingSource
            // 
            this.mOBILBindingSource.DataMember = "MOBIL";
            this.mOBILBindingSource.DataSource = this.dataMobil;
            // 
            // dataMobil
            // 
            this.dataMobil.DataSetName = "DataMobil";
            this.dataMobil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(448, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 138;
            this.label3.Text = "CarDelete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 37);
            this.label4.TabIndex = 137;
            this.label4.Text = "CarUpdate";
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
            this._BacktoMenu.TabIndex = 136;
            this._BacktoMenu.Text = "Back";
            this._BacktoMenu.UseVisualStyleBackColor = false;
            this._BacktoMenu.Click += new System.EventHandler(this._BacktoMenu_Click);
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
            this.label1.TabIndex = 134;
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
            this.label2.TabIndex = 135;
            this.label2.Text = "the best partner for your mobility";
            // 
            // mOBILTableAdapter
            // 
            this.mOBILTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 150;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(588, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 151;
            // 
            // formUpdateMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tanggalBaru2);
            this.Controls.Add(this.udpateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gantiWith);
            this.Controls.Add(this.comboCarGanti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._BacktoMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUpdateMobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUpdateMobil";
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tanggalBaru2;
        private System.Windows.Forms.Button udpateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gantiWith;
        private System.Windows.Forms.ComboBox comboCarGanti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _BacktoMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataMobil dataMobil;
        private System.Windows.Forms.BindingSource mOBILBindingSource;
        private DataMobilTableAdapters.MOBILTableAdapter mOBILTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}