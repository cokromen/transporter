namespace FP
{
    partial class lihatMobil
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mOBILBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataUser = new FP.DataUser();
            this._BacktoMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataMobil = new FP.DataMobil();
            this.mOBILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOBILTableAdapter = new FP.DataMobilTableAdapters.MOBILTableAdapter();
            this.mOBILTableAdapter1 = new FP.DataUserTableAdapters.MOBILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 46);
            this.label4.TabIndex = 96;
            this.label4.Text = "Mobil";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(19, 146);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(769, 344);
            this.dataGridView2.TabIndex = 95;
            // 
            // mOBILBindingSource1
            // 
            this.mOBILBindingSource1.DataMember = "MOBIL";
            this.mOBILBindingSource1.DataSource = this.dataUser;
            // 
            // dataUser
            // 
            this.dataUser.DataSetName = "DataUser";
            this.dataUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _BacktoMenu
            // 
            this._BacktoMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this._BacktoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._BacktoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BacktoMenu.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BacktoMenu.ForeColor = System.Drawing.Color.White;
            this._BacktoMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._BacktoMenu.Location = new System.Drawing.Point(710, 10);
            this._BacktoMenu.Name = "_BacktoMenu";
            this._BacktoMenu.Size = new System.Drawing.Size(78, 31);
            this._BacktoMenu.TabIndex = 94;
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
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 92;
            this.label1.Text = "AutoExpress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 93;
            this.label2.Text = "the best partner for your mobility";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(20, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 97;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // mOBILTableAdapter1
            // 
            this.mOBILTableAdapter1.ClearBeforeFill = true;
            // 
            // lihatMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this._BacktoMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lihatMobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lihatMobil";
            this.Load += new System.EventHandler(this.lihatMobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button _BacktoMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DataMobil dataMobil;
        private System.Windows.Forms.BindingSource mOBILBindingSource;
        private DataMobilTableAdapters.MOBILTableAdapter mOBILTableAdapter;
        private DataUser dataUser;
        private System.Windows.Forms.BindingSource mOBILBindingSource1;
        private DataUserTableAdapters.MOBILTableAdapter mOBILTableAdapter1;
    }
}