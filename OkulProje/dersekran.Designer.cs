﻿namespace OkulProje
{
    partial class dersekran
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdersad = new System.Windows.Forms.TextBox();
            this.txtkredi = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kredisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğretmeni:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(403, 133);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(216, 26);
            this.txtid.TabIndex = 4;
            // 
            // txtdersad
            // 
            this.txtdersad.Location = new System.Drawing.Point(404, 177);
            this.txtdersad.Name = "txtdersad";
            this.txtdersad.Size = new System.Drawing.Size(216, 26);
            this.txtdersad.TabIndex = 5;
            // 
            // txtkredi
            // 
            this.txtkredi.Location = new System.Drawing.Point(403, 273);
            this.txtkredi.Name = "txtkredi";
            this.txtkredi.Size = new System.Drawing.Size(216, 26);
            this.txtkredi.TabIndex = 6;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(861, 229);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(121, 44);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Onayla";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(706, 229);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(121, 44);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 242);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // dersekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1303, 612);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtkredi);
            this.Controls.Add(this.txtdersad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dersekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DersPaneli";
            this.Load += new System.EventHandler(this.DersPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdersad;
        private System.Windows.Forms.TextBox txtkredi;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}