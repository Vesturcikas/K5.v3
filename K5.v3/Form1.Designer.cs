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
            this.K5DuomenuBaze = new System.Windows.Forms.GroupBox();
            this.perziureti_K5DuomenuBaze = new System.Windows.Forms.Button();
            this.KomplektoDetales = new System.Windows.Forms.GroupBox();
            this.skaiciuoti_K5 = new System.Windows.Forms.Button();
            this.close_forma1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apieProgramąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.K5DuomenuBaze.SuspendLayout();
            this.KomplektoDetales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // K5DuomenuBaze
            // 
            this.K5DuomenuBaze.Controls.Add(this.label3);
            this.K5DuomenuBaze.Controls.Add(this.perziureti_K5DuomenuBaze);
            this.K5DuomenuBaze.Location = new System.Drawing.Point(13, 44);
            this.K5DuomenuBaze.Margin = new System.Windows.Forms.Padding(4);
            this.K5DuomenuBaze.Name = "K5DuomenuBaze";
            this.K5DuomenuBaze.Padding = new System.Windows.Forms.Padding(4);
            this.K5DuomenuBaze.Size = new System.Drawing.Size(480, 125);
            this.K5DuomenuBaze.TabIndex = 1;
            this.K5DuomenuBaze.TabStop = false;
            this.K5DuomenuBaze.Text = "1. K5 duomenų bazės peržiūra, atnaujinimas";
            // 
            // perziureti_K5DuomenuBaze
            // 
            this.perziureti_K5DuomenuBaze.Location = new System.Drawing.Point(7, 88);
            this.perziureti_K5DuomenuBaze.Name = "perziureti_K5DuomenuBaze";
            this.perziureti_K5DuomenuBaze.Size = new System.Drawing.Size(466, 30);
            this.perziureti_K5DuomenuBaze.TabIndex = 5;
            this.perziureti_K5DuomenuBaze.Text = "Peržiūrėti";
            this.perziureti_K5DuomenuBaze.UseVisualStyleBackColor = true;
            this.perziureti_K5DuomenuBaze.Click += new System.EventHandler(this.perziureti_K5DuomenuBaze_Click);
            // 
            // KomplektoDetales
            // 
            this.KomplektoDetales.Controls.Add(this.label2);
            this.KomplektoDetales.Controls.Add(this.skaiciuoti_K5);
            this.KomplektoDetales.Location = new System.Drawing.Point(13, 308);
            this.KomplektoDetales.Margin = new System.Windows.Forms.Padding(4);
            this.KomplektoDetales.Name = "KomplektoDetales";
            this.KomplektoDetales.Padding = new System.Windows.Forms.Padding(4);
            this.KomplektoDetales.Size = new System.Drawing.Size(480, 125);
            this.KomplektoDetales.TabIndex = 2;
            this.KomplektoDetales.TabStop = false;
            this.KomplektoDetales.Text = "3. K5 skaičiavimas";
            // 
            // skaiciuoti_K5
            // 
            this.skaiciuoti_K5.Location = new System.Drawing.Point(7, 87);
            this.skaiciuoti_K5.Name = "skaiciuoti_K5";
            this.skaiciuoti_K5.Size = new System.Drawing.Size(466, 31);
            this.skaiciuoti_K5.TabIndex = 1;
            this.skaiciuoti_K5.Text = "Skaičiuoti K5";
            this.skaiciuoti_K5.UseVisualStyleBackColor = true;
            this.skaiciuoti_K5.Click += new System.EventHandler(this.skaiciuoti_K5_Click);
            // 
            // close_forma1
            // 
            this.close_forma1.Location = new System.Drawing.Point(305, 440);
            this.close_forma1.Name = "close_forma1";
            this.close_forma1.Size = new System.Drawing.Size(188, 37);
            this.close_forma1.TabIndex = 3;
            this.close_forma1.Text = "Uždaryti";
            this.close_forma1.UseVisualStyleBackColor = true;
            this.close_forma1.Click += new System.EventHandler(this.uzdaryti_forma1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Parduotų detalių DB atnaujinimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prieš K5 skaičiavią, rekomenduojama atnaujinti komplektų, \r\nbei komplektuojančių " +
    "detalių duomenų bazes.\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apieProgramąToolStripMenuItem,
            this.autoriusToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.toolStripMenuItem1.Text = "Pagalba";
            // 
            // apieProgramąToolStripMenuItem
            // 
            this.apieProgramąToolStripMenuItem.Name = "apieProgramąToolStripMenuItem";
            this.apieProgramąToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.apieProgramąToolStripMenuItem.Text = "Apie programą";
            this.apieProgramąToolStripMenuItem.Click += new System.EventHandler(this.apieProgramąToolStripMenuItem_Click);
            // 
            // autoriusToolStripMenuItem
            // 
            this.autoriusToolStripMenuItem.Name = "autoriusToolStripMenuItem";
            this.autoriusToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.autoriusToolStripMenuItem.Text = "Autorius";
            this.autoriusToolStripMenuItem.Click += new System.EventHandler(this.autoriusToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(468, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atnaujinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jei turite detalių pardavimų naujus duomenys, \r\nrekomenduojama atnaujinti \"Parduo" +
    "tų detalių DB\".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parduotų komplektų skaičiavimas pagal parduotuves.";
            // 
            // K5skaiciavimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.close_forma1);
            this.Controls.Add(this.KomplektoDetales);
            this.Controls.Add(this.K5DuomenuBaze);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "K5skaiciavimas";
            this.Text = "K5 skaičiavimas";
            this.K5DuomenuBaze.ResumeLayout(false);
            this.K5DuomenuBaze.PerformLayout();
            this.KomplektoDetales.ResumeLayout(false);
            this.KomplektoDetales.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox K5DuomenuBaze;
        private System.Windows.Forms.GroupBox KomplektoDetales;
        private System.Windows.Forms.Button perziureti_K5DuomenuBaze;
        private System.Windows.Forms.Button close_forma1;
        private System.Windows.Forms.Button skaiciuoti_K5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apieProgramąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriusToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

