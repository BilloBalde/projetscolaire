namespace ges_scolaire
{
    partial class Form2
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
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.btnvalider = new System.Windows.Forms.Button();
            this.txtanne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(662, 122);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(121, 24);
            this.cmbclasse.TabIndex = 39;
            // 
            // txtrechercher
            // 
            this.txtrechercher.Location = new System.Drawing.Point(611, 192);
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(129, 22);
            this.txtrechercher.TabIndex = 38;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(230, 192);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(102, 36);
            this.btnmodifier.TabIndex = 37;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Location = new System.Drawing.Point(349, 192);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(102, 36);
            this.btnsuprimer.TabIndex = 36;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnrechercher
            // 
            this.btnrechercher.Location = new System.Drawing.Point(469, 192);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(102, 36);
            this.btnrechercher.TabIndex = 35;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = true;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 244);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(799, 228);
            this.dGV1.TabIndex = 34;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(106, 192);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(102, 36);
            this.btnvalider.TabIndex = 33;
            this.btnvalider.Text = "valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // txtanne
            // 
            this.txtanne.Location = new System.Drawing.Point(654, 75);
            this.txtanne.Name = "txtanne";
            this.txtanne.Size = new System.Drawing.Size(129, 22);
            this.txtanne.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "année scolaire";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(89, 122);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(129, 22);
            this.txtnom.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "nom";
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(393, 72);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(129, 22);
            this.txtcredit.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "crédit";
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(393, 128);
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(129, 22);
            this.txtreglement.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "montantverser";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(89, 75);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(129, 22);
            this.txtprenom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ajout Etudiant";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(89, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 22);
            this.txtid.TabIndex = 40;
            this.txtid.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 485);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.txtanne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtreglement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.TextBox txtanne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}