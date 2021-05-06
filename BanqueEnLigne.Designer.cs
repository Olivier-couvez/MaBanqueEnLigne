
namespace WinFormsMaBanqueEnLigne
{
    partial class BanqueEnLigne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEmetteur = new System.Windows.Forms.GroupBox();
            this.textBoxSoldeEmetteur = new System.Windows.Forms.TextBox();
            this.comboBoxEmetteur = new System.Windows.Forms.ComboBox();
            this.groupBoxBeneficiaire = new System.Windows.Forms.GroupBox();
            this.buttonEurope = new System.Windows.Forms.Button();
            this.buttonFrance = new System.Windows.Forms.Button();
            this.labelAjoutCompte = new System.Windows.Forms.Label();
            this.textBoxSoldeBeneficiaire = new System.Windows.Forms.TextBox();
            this.comboBoxbeneficiaire = new System.Windows.Forms.ComboBox();
            this.groupBoxVirement = new System.Windows.Forms.GroupBox();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.groupBoxEmetteur.SuspendLayout();
            this.groupBoxBeneficiaire.SuspendLayout();
            this.groupBoxVirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmetteur
            // 
            this.groupBoxEmetteur.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxEmetteur.Controls.Add(this.textBoxSoldeEmetteur);
            this.groupBoxEmetteur.Controls.Add(this.comboBoxEmetteur);
            this.groupBoxEmetteur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEmetteur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxEmetteur.Location = new System.Drawing.Point(26, 56);
            this.groupBoxEmetteur.Name = "groupBoxEmetteur";
            this.groupBoxEmetteur.Size = new System.Drawing.Size(743, 89);
            this.groupBoxEmetteur.TabIndex = 0;
            this.groupBoxEmetteur.TabStop = false;
            this.groupBoxEmetteur.Text = "Sélectionner un compte émetteur                                                  " +
    "             Solde indicatif";
            // 
            // textBoxSoldeEmetteur
            // 
            this.textBoxSoldeEmetteur.Location = new System.Drawing.Point(573, 43);
            this.textBoxSoldeEmetteur.Name = "textBoxSoldeEmetteur";
            this.textBoxSoldeEmetteur.Size = new System.Drawing.Size(100, 27);
            this.textBoxSoldeEmetteur.TabIndex = 0;
            // 
            // comboBoxEmetteur
            // 
            this.comboBoxEmetteur.FormattingEnabled = true;
            this.comboBoxEmetteur.Location = new System.Drawing.Point(25, 41);
            this.comboBoxEmetteur.Name = "comboBoxEmetteur";
            this.comboBoxEmetteur.Size = new System.Drawing.Size(289, 27);
            this.comboBoxEmetteur.TabIndex = 0;
            this.comboBoxEmetteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmetteur_SelectedIndexChanged);
            // 
            // groupBoxBeneficiaire
            // 
            this.groupBoxBeneficiaire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxBeneficiaire.Controls.Add(this.buttonEurope);
            this.groupBoxBeneficiaire.Controls.Add(this.buttonFrance);
            this.groupBoxBeneficiaire.Controls.Add(this.labelAjoutCompte);
            this.groupBoxBeneficiaire.Controls.Add(this.textBoxSoldeBeneficiaire);
            this.groupBoxBeneficiaire.Controls.Add(this.comboBoxbeneficiaire);
            this.groupBoxBeneficiaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBeneficiaire.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxBeneficiaire.Location = new System.Drawing.Point(26, 151);
            this.groupBoxBeneficiaire.Name = "groupBoxBeneficiaire";
            this.groupBoxBeneficiaire.Size = new System.Drawing.Size(743, 89);
            this.groupBoxBeneficiaire.TabIndex = 1;
            this.groupBoxBeneficiaire.TabStop = false;
            this.groupBoxBeneficiaire.Text = "Sélectionner un compte bénéficiaire                                              " +
    "           Solde indicatif";
            // 
            // buttonEurope
            // 
            this.buttonEurope.Location = new System.Drawing.Point(433, 43);
            this.buttonEurope.Name = "buttonEurope";
            this.buttonEurope.Size = new System.Drawing.Size(90, 29);
            this.buttonEurope.TabIndex = 7;
            this.buttonEurope.Text = "Europe";
            this.buttonEurope.UseVisualStyleBackColor = true;
            // 
            // buttonFrance
            // 
            this.buttonFrance.Location = new System.Drawing.Point(331, 43);
            this.buttonFrance.Name = "buttonFrance";
            this.buttonFrance.Size = new System.Drawing.Size(96, 29);
            this.buttonFrance.TabIndex = 6;
            this.buttonFrance.Text = "France";
            this.buttonFrance.UseVisualStyleBackColor = true;
            // 
            // labelAjoutCompte
            // 
            this.labelAjoutCompte.AutoSize = true;
            this.labelAjoutCompte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAjoutCompte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAjoutCompte.Location = new System.Drawing.Point(365, 23);
            this.labelAjoutCompte.Name = "labelAjoutCompte";
            this.labelAjoutCompte.Size = new System.Drawing.Size(130, 17);
            this.labelAjoutCompte.TabIndex = 5;
            this.labelAjoutCompte.Text = "Ajouter un compte";
            // 
            // textBoxSoldeBeneficiaire
            // 
            this.textBoxSoldeBeneficiaire.Location = new System.Drawing.Point(573, 39);
            this.textBoxSoldeBeneficiaire.Name = "textBoxSoldeBeneficiaire";
            this.textBoxSoldeBeneficiaire.Size = new System.Drawing.Size(100, 27);
            this.textBoxSoldeBeneficiaire.TabIndex = 2;
            // 
            // comboBoxbeneficiaire
            // 
            this.comboBoxbeneficiaire.FormattingEnabled = true;
            this.comboBoxbeneficiaire.Location = new System.Drawing.Point(25, 39);
            this.comboBoxbeneficiaire.Name = "comboBoxbeneficiaire";
            this.comboBoxbeneficiaire.Size = new System.Drawing.Size(289, 27);
            this.comboBoxbeneficiaire.TabIndex = 1;
            this.comboBoxbeneficiaire.SelectedIndexChanged += new System.EventHandler(this.comboBoxbeneficiaire_SelectedIndexChanged);
            // 
            // groupBoxVirement
            // 
            this.groupBoxVirement.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxVirement.Controls.Add(this.textBoxMotif);
            this.groupBoxVirement.Controls.Add(this.textBoxMontant);
            this.groupBoxVirement.Controls.Add(this.labelEuro);
            this.groupBoxVirement.Controls.Add(this.labelMotif);
            this.groupBoxVirement.Controls.Add(this.labelMontant);
            this.groupBoxVirement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxVirement.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxVirement.Location = new System.Drawing.Point(26, 246);
            this.groupBoxVirement.Name = "groupBoxVirement";
            this.groupBoxVirement.Size = new System.Drawing.Size(743, 145);
            this.groupBoxVirement.TabIndex = 2;
            this.groupBoxVirement.TabStop = false;
            this.groupBoxVirement.Text = "Caractéristique du vireemnt";
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Location = new System.Drawing.Point(195, 86);
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(478, 27);
            this.textBoxMotif.TabIndex = 10;
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(195, 34);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(100, 27);
            this.textBoxMontant.TabIndex = 9;
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEuro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEuro.Location = new System.Drawing.Point(393, 40);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(27, 17);
            this.labelEuro.TabIndex = 8;
            this.labelEuro.Text = "Eur";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMotif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMotif.Location = new System.Drawing.Point(25, 92);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(111, 17);
            this.labelMotif.TabIndex = 7;
            this.labelMotif.Text = "Motif (facultatif)";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMontant.Location = new System.Drawing.Point(25, 40);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(63, 17);
            this.labelMontant.TabIndex = 6;
            this.labelMontant.Text = "Montant";
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValider.Location = new System.Drawing.Point(322, 409);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(153, 29);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(26, 13);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(227, 25);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Effectuer un virement";
            // 
            // BanqueEnLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.groupBoxVirement);
            this.Controls.Add(this.groupBoxBeneficiaire);
            this.Controls.Add(this.groupBoxEmetteur);
            this.Name = "BanqueEnLigne";
            this.Text = "Ma banque en ligne";
            this.Load += new System.EventHandler(this.BanqueEnLigne_Load);
            this.groupBoxEmetteur.ResumeLayout(false);
            this.groupBoxEmetteur.PerformLayout();
            this.groupBoxBeneficiaire.ResumeLayout(false);
            this.groupBoxBeneficiaire.PerformLayout();
            this.groupBoxVirement.ResumeLayout(false);
            this.groupBoxVirement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmetteur;
        private System.Windows.Forms.TextBox textBoxSoldeEmetteur;
        private System.Windows.Forms.ComboBox comboBoxEmetteur;
        private System.Windows.Forms.GroupBox groupBoxBeneficiaire;
        private System.Windows.Forms.Button buttonEurope;
        private System.Windows.Forms.Button buttonFrance;
        private System.Windows.Forms.Label labelAjoutCompte;
        private System.Windows.Forms.TextBox textBoxSoldeBeneficiaire;
        private System.Windows.Forms.ComboBox comboBoxbeneficiaire;
        private System.Windows.Forms.GroupBox groupBoxVirement;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelTitre;
    }
}

