namespace K5.v3
{
    partial class Form7
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ieskoti_ParduotuDetaliuFailo = new System.Windows.Forms.Button();
            this.papildyti_K5DBParduotuDetaliuLentele = new System.Windows.Forms.Button();
            this.perziureti_K5DBParduotuDetaliuLentele = new System.Windows.Forms.Button();
            this.close_forma7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.ieskoti_ParduotuDetaliuFailo);
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1. Parduotų detalių .csv failo vieta:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(546, 37);
            this.textBox2.TabIndex = 7;
            // 
            // ieskoti_ParduotuDetaliuFailo
            // 
            this.ieskoti_ParduotuDetaliuFailo.Location = new System.Drawing.Point(566, 21);
            this.ieskoti_ParduotuDetaliuFailo.Name = "ieskoti_ParduotuDetaliuFailo";
            this.ieskoti_ParduotuDetaliuFailo.Size = new System.Drawing.Size(186, 37);
            this.ieskoti_ParduotuDetaliuFailo.TabIndex = 6;
            this.ieskoti_ParduotuDetaliuFailo.Text = "Ieškoti";
            this.ieskoti_ParduotuDetaliuFailo.UseVisualStyleBackColor = true;
            this.ieskoti_ParduotuDetaliuFailo.Click += new System.EventHandler(this.ieskoti_ParduotuDetaliuFailo_Click);
            // 
            // papildyti_K5DBParduotuDetaliuLentele
            // 
            this.papildyti_K5DBParduotuDetaliuLentele.Location = new System.Drawing.Point(566, 70);
            this.papildyti_K5DBParduotuDetaliuLentele.Name = "papildyti_K5DBParduotuDetaliuLentele";
            this.papildyti_K5DBParduotuDetaliuLentele.Size = new System.Drawing.Size(186, 37);
            this.papildyti_K5DBParduotuDetaliuLentele.TabIndex = 3;
            this.papildyti_K5DBParduotuDetaliuLentele.Text = "Papildyti lentelę";
            this.papildyti_K5DBParduotuDetaliuLentele.UseVisualStyleBackColor = true;
            this.papildyti_K5DBParduotuDetaliuLentele.Click += new System.EventHandler(this.papildyti_K5DBParduotuDetaliuLentele_Click);
            // 
            // perziureti_K5DBParduotuDetaliuLentele
            // 
            this.perziureti_K5DBParduotuDetaliuLentele.Location = new System.Drawing.Point(374, 70);
            this.perziureti_K5DBParduotuDetaliuLentele.Name = "perziureti_K5DBParduotuDetaliuLentele";
            this.perziureti_K5DBParduotuDetaliuLentele.Size = new System.Drawing.Size(186, 37);
            this.perziureti_K5DBParduotuDetaliuLentele.TabIndex = 3;
            this.perziureti_K5DBParduotuDetaliuLentele.Text = "Peržiūrėti";
            this.perziureti_K5DBParduotuDetaliuLentele.UseVisualStyleBackColor = true;
            this.perziureti_K5DBParduotuDetaliuLentele.Click += new System.EventHandler(this.perziureti_K5DBParduotuDetaliuLentele_Click);
            // 
            // close_forma7
            // 
            this.close_forma7.Location = new System.Drawing.Point(566, 401);
            this.close_forma7.Name = "close_forma7";
            this.close_forma7.Size = new System.Drawing.Size(185, 37);
            this.close_forma7.TabIndex = 4;
            this.close_forma7.Text = "Uždaryti";
            this.close_forma7.UseVisualStyleBackColor = true;
            this.close_forma7.Click += new System.EventHandler(this.close_forma7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.papildyti_K5DBParduotuDetaliuLentele);
            this.groupBox1.Controls.Add(this.perziureti_K5DBParduotuDetaliuLentele);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Parduotų detalių DB";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_forma7);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form7";
            this.Text = "Parduotų detalių DB atnaujinimas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ieskoti_ParduotuDetaliuFailo;
        private System.Windows.Forms.Button papildyti_K5DBParduotuDetaliuLentele;
        private System.Windows.Forms.Button perziureti_K5DBParduotuDetaliuLentele;
        private System.Windows.Forms.Button close_forma7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}