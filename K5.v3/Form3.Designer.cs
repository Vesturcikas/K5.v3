namespace K5.v3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.perziureti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.uzdaryti_forma3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.perziureti_KomplektuDetaliuLentele);
            this.groupBox1.Location = new System.Drawing.Point(24, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "K5. Komplektu detaliu lentelė";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(24, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "K5. Komplektu lentelė";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "K5. Parduotų detalių lentelė";
            // 
            // perziureti_KomplektuDetaliuLentele
            // 
            this.perziureti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(570, 21);
            this.perziureti_KomplektuDetaliuLentele.Name = "perziureti_KomplektuDetaliuLentele";
            this.perziureti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(186, 37);
            this.perziureti_KomplektuDetaliuLentele.TabIndex = 0;
            this.perziureti_KomplektuDetaliuLentele.Text = "Peržiūrėti";
            this.perziureti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            this.perziureti_KomplektuDetaliuLentele.Click += new System.EventHandler(this.perziureti_KomplektuDetaliuLentele_Click);
            // 
            // uzdaryti_forma3
            // 
            this.uzdaryti_forma3.Location = new System.Drawing.Point(594, 496);
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
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.uzdaryti_forma3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "K5 duomenu bazes peržiūra";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button perziureti_KomplektuDetaliuLentele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uzdaryti_forma3;
    }
}