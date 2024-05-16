namespace ges_scolaire
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btneffacer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnenreg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.cmbspecialite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnrechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrechercher
            // 
            this.txtrechercher.Location = new System.Drawing.Point(122, 443);
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(177, 22);
            this.txtrechercher.TabIndex = 23;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(261, 267);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 21;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Location = new System.Drawing.Point(87, 365);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsuprimer.TabIndex = 20;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btneffacer
            // 
            this.btneffacer.Location = new System.Drawing.Point(261, 365);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(75, 23);
            this.btneffacer.TabIndex = 19;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = true;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 546);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnenreg
            // 
            this.btnenreg.Location = new System.Drawing.Point(78, 267);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(75, 23);
            this.btnenreg.TabIndex = 17;
            this.btnenreg.Text = "Enreg";
            this.btnenreg.UseVisualStyleBackColor = true;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "specialite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "niveau";
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.cmbniveau.Location = new System.Drawing.Point(178, 183);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(180, 24);
            this.cmbniveau.TabIndex = 14;
            // 
            // cmbspecialite
            // 
            this.cmbspecialite.FormattingEnabled = true;
            this.cmbspecialite.Items.AddRange(new object[] {
            "IAGE",
            "GL",
            "FC",
            "RI"});
            this.cmbspecialite.Location = new System.Drawing.Point(178, 95);
            this.cmbspecialite.Name = "cmbspecialite";
            this.cmbspecialite.Size = new System.Drawing.Size(180, 24);
            this.cmbspecialite.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ajout Class";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(181, 67);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(177, 22);
            this.txtid.TabIndex = 24;
            this.txtid.Visible = false;
            // 
            // btnrechercher
            // 
            this.btnrechercher.Location = new System.Drawing.Point(178, 529);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(75, 23);
            this.btnrechercher.TabIndex = 25;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = true;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 616);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnenreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.cmbspecialite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.ComboBox cmbspecialite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnrechercher;
    }
}

