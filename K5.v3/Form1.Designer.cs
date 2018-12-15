namespace K5.v3
{
    partial class K5skaiciavimas
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
            this.K5DuomenuBaze = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ieskoti_K5DuomenuBazes = new System.Windows.Forms.Button();
            this.Prisijungti = new System.Windows.Forms.Button();
            this.KomplektoDetales = new System.Windows.Forms.GroupBox();
            this.atnaujinti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ieskoti_KomplektoDetaliu = new System.Windows.Forms.Button();
            this.redaguoti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.irasyti_KomplektuDetaliuLentele = new System.Windows.Forms.Button();
            this.K5DuomenuBaze.SuspendLayout();
            this.KomplektoDetales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa skirta suskaičiuoti parduotose detalėse komplektus ir jų komplektiškumus.";
            // 
            // K5DuomenuBaze
            // 
            this.K5DuomenuBaze.Controls.Add(this.label3);
            this.K5DuomenuBaze.Controls.Add(this.textBox2);
            this.K5DuomenuBaze.Controls.Add(this.ieskoti_K5DuomenuBazes);
            this.K5DuomenuBaze.Controls.Add(this.Prisijungti);
            this.K5DuomenuBaze.Location = new System.Drawing.Point(22, 55);
            this.K5DuomenuBaze.Margin = new System.Windows.Forms.Padding(4);
            this.K5DuomenuBaze.Name = "K5DuomenuBaze";
            this.K5DuomenuBaze.Padding = new System.Windows.Forms.Padding(4);
            this.K5DuomenuBaze.Size = new System.Drawing.Size(969, 138);
            this.K5DuomenuBaze.TabIndex = 1;
            this.K5DuomenuBaze.TabStop = false;
            this.K5DuomenuBaze.Text = "Prisijungimas prie K5 Duomenų bazės";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "K5 duomenų bazė:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(8, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(760, 30);
            this.textBox2.TabIndex = 2;
            // 
            // ieskoti_K5DuomenuBazes
            // 
            this.ieskoti_K5DuomenuBazes.Location = new System.Drawing.Point(773, 56);
            this.ieskoti_K5DuomenuBazes.Margin = new System.Windows.Forms.Padding(4);
            this.ieskoti_K5DuomenuBazes.Name = "ieskoti_K5DuomenuBazes";
            this.ieskoti_K5DuomenuBazes.Size = new System.Drawing.Size(188, 30);
            this.ieskoti_K5DuomenuBazes.TabIndex = 1;
            this.ieskoti_K5DuomenuBazes.Text = "Ieškoti";
            this.ieskoti_K5DuomenuBazes.UseVisualStyleBackColor = true;
            this.ieskoti_K5DuomenuBazes.Click += new System.EventHandler(this.ieskoti_K5DuomenuBazes_Click);
            // 
            // Prisijungti
            // 
            this.Prisijungti.Location = new System.Drawing.Point(773, 94);
            this.Prisijungti.Margin = new System.Windows.Forms.Padding(4);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(188, 30);
            this.Prisijungti.TabIndex = 0;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = true;
            // 
            // KomplektoDetales
            // 
            this.KomplektoDetales.Controls.Add(this.irasyti_KomplektuDetaliuLentele);
            this.KomplektoDetales.Controls.Add(this.redaguoti_KomplektuDetaliuLentele);
            this.KomplektoDetales.Controls.Add(this.atnaujinti_KomplektuDetaliuLentele);
            this.KomplektoDetales.Controls.Add(this.label2);
            this.KomplektoDetales.Controls.Add(this.textBox1);
            this.KomplektoDetales.Controls.Add(this.Ieskoti_KomplektoDetaliu);
            this.KomplektoDetales.Location = new System.Drawing.Point(22, 210);
            this.KomplektoDetales.Margin = new System.Windows.Forms.Padding(4);
            this.KomplektoDetales.Name = "KomplektoDetales";
            this.KomplektoDetales.Padding = new System.Windows.Forms.Padding(4);
            this.KomplektoDetales.Size = new System.Drawing.Size(971, 138);
            this.KomplektoDetales.TabIndex = 2;
            this.KomplektoDetales.TabStop = false;
            this.KomplektoDetales.Text = "Komplekto detalės";
            // 
            // atnaujinti_KomplektuDetaliuLentele
            // 
            this.atnaujinti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(582, 101);
            this.atnaujinti_KomplektuDetaliuLentele.Name = "atnaujinti_KomplektuDetaliuLentele";
            this.atnaujinti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(188, 30);
            this.atnaujinti_KomplektuDetaliuLentele.TabIndex = 3;
            this.atnaujinti_KomplektuDetaliuLentele.Text = "Atnaujinti";
            this.atnaujinti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            //this.atnaujinti_KomplektuDetaliuLentele.Click += new System.EventHandler(this.atnaujinti_KomplektuDetaliuLentele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Komplekto detalių .csv failas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 30);
            this.textBox1.TabIndex = 1;
            // 
            // Ieskoti_KomplektoDetaliu
            // 
            this.Ieskoti_KomplektoDetaliu.Location = new System.Drawing.Point(776, 56);
            this.Ieskoti_KomplektoDetaliu.Margin = new System.Windows.Forms.Padding(4);
            this.Ieskoti_KomplektoDetaliu.Name = "Ieskoti_KomplektoDetaliu";
            this.Ieskoti_KomplektoDetaliu.Size = new System.Drawing.Size(188, 30);
            this.Ieskoti_KomplektoDetaliu.TabIndex = 0;
            this.Ieskoti_KomplektoDetaliu.Text = "Ieškoti";
            this.Ieskoti_KomplektoDetaliu.UseVisualStyleBackColor = true;
            this.Ieskoti_KomplektoDetaliu.Click += new System.EventHandler(this.Ieskoti_KomplektoDetaliu_Click);
            // 
            // redaguoti_KomplektuDetaliuLentele
            // 
            this.redaguoti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(776, 101);
            this.redaguoti_KomplektuDetaliuLentele.Name = "redaguoti_KomplektuDetaliuLentele";
            this.redaguoti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(188, 30);
            this.redaguoti_KomplektuDetaliuLentele.TabIndex = 4;
            this.redaguoti_KomplektuDetaliuLentele.Text = "Redaguoti";
            this.redaguoti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            // 
            // irasyti_KomplektuDetaliuLentele
            // 
            this.irasyti_KomplektuDetaliuLentele.Location = new System.Drawing.Point(388, 101);
            this.irasyti_KomplektuDetaliuLentele.Name = "irasyti_KomplektuDetaliuLentele";
            this.irasyti_KomplektuDetaliuLentele.Size = new System.Drawing.Size(188, 30);
            this.irasyti_KomplektuDetaliuLentele.TabIndex = 5;
            this.irasyti_KomplektuDetaliuLentele.Text = "Įrašyti";
            this.irasyti_KomplektuDetaliuLentele.UseVisualStyleBackColor = true;
            this.irasyti_KomplektuDetaliuLentele.Click += new System.EventHandler(this.irasyti_KomplektuDetaliuLentele_Click);
            // 
            // K5skaiciavimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 620);
            this.Controls.Add(this.KomplektoDetales);
            this.Controls.Add(this.K5DuomenuBaze);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "K5skaiciavimas";
            this.Text = "K5 skaičiavimas";
            this.K5DuomenuBaze.ResumeLayout(false);
            this.K5DuomenuBaze.PerformLayout();
            this.KomplektoDetales.ResumeLayout(false);
            this.KomplektoDetales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox K5DuomenuBaze;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.GroupBox KomplektoDetales;
        private System.Windows.Forms.Button Ieskoti_KomplektoDetaliu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button atnaujinti_KomplektuDetaliuLentele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ieskoti_K5DuomenuBazes;
        private System.Windows.Forms.Button redaguoti_KomplektuDetaliuLentele;
        private System.Windows.Forms.Button irasyti_KomplektuDetaliuLentele;
    }
}

