﻿namespace K5.v3
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.perrasyti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Ieskoti_KomplektoDetaliu = new System.Windows.Forms.Button();
            this.perziureti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ieskoti_KomplektuCsvFailo = new System.Windows.Forms.Button();
            this.perrasyti_KomplektuLenteleK5DB = new System.Windows.Forms.Button();
            this.perziureti_KomplektuLentele = new System.Windows.Forms.Button();
            this.uzdaryti_forma3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.perrasyti_KomplektuDetaliuLentele);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.Ieskoti_KomplektoDetaliu);
            this.groupBox1.Controls.Add(this.perziureti_KomplektuDetaliuLentele);
            this.groupBox1.Location = new System.Drawing.Point(24, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "K5. Komplektu detaliu lentelė";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Komplekto detalių .csv failas:";
            // 
            // perrasyti_KomplektuDetaliuLentele
            // 
            this.perrasyti_KomplektuDetaliuLentele.Enabled = false;
            this.perrasyti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(570, 95);
            this.perrasyti_KomplektuDetaliuLentele.Name = "perrasyti_KomplektuDetaliuLentele";
            this.perrasyti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(186, 37);
            this.perrasyti_KomplektuDetaliuLentele.TabIndex = 1;
            this.perrasyti_KomplektuDetaliuLentele.Text = "Perrašyti";
            this.perrasyti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            this.perrasyti_KomplektuDetaliuLentele.Click += new System.EventHandler(this.perrasyti_KomplektuDetaliuLentele_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 47);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(546, 37);
            this.textBox3.TabIndex = 10;
            // 
            // Ieskoti_KomplektoDetaliu
            // 
            this.Ieskoti_KomplektoDetaliu.Location = new System.Drawing.Point(570, 47);
            this.Ieskoti_KomplektoDetaliu.Margin = new System.Windows.Forms.Padding(4);
            this.Ieskoti_KomplektoDetaliu.Name = "Ieskoti_KomplektoDetaliu";
            this.Ieskoti_KomplektoDetaliu.Size = new System.Drawing.Size(186, 37);
            this.Ieskoti_KomplektoDetaliu.TabIndex = 9;
            this.Ieskoti_KomplektoDetaliu.Text = "Ieškoti";
            this.Ieskoti_KomplektoDetaliu.UseVisualStyleBackColor = true;
            this.Ieskoti_KomplektoDetaliu.Click += new System.EventHandler(this.Ieskoti_KomplektoDetaliu_Click);
            // 
            // perziureti_KomplektuDetaliuLentele
            // 
            this.perziureti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(377, 95);
            this.perziureti_KomplektuDetaliuLentele.Name = "perziureti_KomplektuDetaliuLentele";
            this.perziureti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(186, 37);
            this.perziureti_KomplektuDetaliuLentele.TabIndex = 0;
            this.perziureti_KomplektuDetaliuLentele.Text = "Peržiūrėti";
            this.perziureti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            this.perziureti_KomplektuDetaliuLentele.Click += new System.EventHandler(this.perziureti_KomplektuDetaliuLentele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.ieskoti_KomplektuCsvFailo);
            this.groupBox2.Controls.Add(this.perrasyti_KomplektuLenteleK5DB);
            this.groupBox2.Controls.Add(this.perziureti_KomplektuLentele);
            this.groupBox2.Location = new System.Drawing.Point(24, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "K5. Komplektu lentelė";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Komplektų sąrašo .csv failas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 37);
            this.textBox1.TabIndex = 4;
            // 
            // ieskoti_KomplektuCsvFailo
            // 
            this.ieskoti_KomplektuCsvFailo.Location = new System.Drawing.Point(568, 35);
            this.ieskoti_KomplektuCsvFailo.Name = "ieskoti_KomplektuCsvFailo";
            this.ieskoti_KomplektuCsvFailo.Size = new System.Drawing.Size(186, 37);
            this.ieskoti_KomplektuCsvFailo.TabIndex = 3;
            this.ieskoti_KomplektuCsvFailo.Text = "Ieškoti";
            this.ieskoti_KomplektuCsvFailo.UseVisualStyleBackColor = true;
            this.ieskoti_KomplektuCsvFailo.Click += new System.EventHandler(this.ieskoti_KomplektuCsvFailo_Click);
            // 
            // perrasyti_KomplektuLenteleK5DB
            // 
            this.perrasyti_KomplektuLenteleK5DB.Enabled = false;
            this.perrasyti_KomplektuLenteleK5DB.Location = new System.Drawing.Point(570, 84);
            this.perrasyti_KomplektuLenteleK5DB.Name = "perrasyti_KomplektuLenteleK5DB";
            this.perrasyti_KomplektuLenteleK5DB.Size = new System.Drawing.Size(186, 37);
            this.perrasyti_KomplektuLenteleK5DB.TabIndex = 2;
            this.perrasyti_KomplektuLenteleK5DB.Text = "Perrašyti";
            this.perrasyti_KomplektuLenteleK5DB.UseVisualStyleBackColor = true;
            this.perrasyti_KomplektuLenteleK5DB.Click += new System.EventHandler(this.perrasyti_KomplektuLenteleK5DB_Click);
            // 
            // perziureti_KomplektuLentele
            // 
            this.perziureti_KomplektuLentele.Location = new System.Drawing.Point(377, 84);
            this.perziureti_KomplektuLentele.Name = "perziureti_KomplektuLentele";
            this.perziureti_KomplektuLentele.Size = new System.Drawing.Size(186, 37);
            this.perziureti_KomplektuLentele.TabIndex = 1;
            this.perziureti_KomplektuLentele.Text = "Peržiūrėti";
            this.perziureti_KomplektuLentele.UseVisualStyleBackColor = true;
            this.perziureti_KomplektuLentele.Click += new System.EventHandler(this.perziureti_KomplektuLentele_Click);
            // 
            // uzdaryti_forma3
            // 
            this.uzdaryti_forma3.Location = new System.Drawing.Point(595, 480);
            this.uzdaryti_forma3.Name = "uzdaryti_forma3";
            this.uzdaryti_forma3.Size = new System.Drawing.Size(185, 37);
            this.uzdaryti_forma3.TabIndex = 3;
            this.uzdaryti_forma3.Text = "Baigti";
            this.uzdaryti_forma3.UseVisualStyleBackColor = true;
            this.uzdaryti_forma3.Click += new System.EventHandler(this.uzdaryti_forma3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.uzdaryti_forma3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "K5 duomenu bazes peržiūra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button perziureti_KomplektuDetaliuLentele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uzdaryti_forma3;
        private System.Windows.Forms.Button perziureti_KomplektuLentele;
        private System.Windows.Forms.Button perrasyti_KomplektuDetaliuLentele;
        private System.Windows.Forms.Button perrasyti_KomplektuLenteleK5DB;
        private System.Windows.Forms.Button ieskoti_KomplektuCsvFailo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Ieskoti_KomplektoDetaliu;
    }
}