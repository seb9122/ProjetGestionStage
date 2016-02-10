namespace ProjetGestionStage
{
    partial class FormSaisirOffre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbNom = new System.Windows.Forms.ComboBox();
            this.cbDomaine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEnvoyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'entreprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domaine de l\'offre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libelle de l\'offre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de debut de stage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(223, 160);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(223, 204);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(121, 20);
            this.txtDuree.TabIndex = 9;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(223, 116);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(121, 20);
            this.txtLibelle.TabIndex = 10;
            // 
            // txtDomaine
            // 
            this.txtDomaine.Location = new System.Drawing.Point(223, 63);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(121, 20);
            this.txtDomaine.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(223, 246);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 85);
            this.txtDescription.TabIndex = 13;
            // 
            // cbNom
            // 
            this.cbNom.FormattingEnabled = true;
            this.cbNom.Location = new System.Drawing.Point(223, 18);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(121, 21);
            this.cbNom.TabIndex = 14;
            // 
            // cbDomaine
            // 
            this.cbDomaine.FormattingEnabled = true;
            this.cbDomaine.Location = new System.Drawing.Point(397, 62);
            this.cbDomaine.Name = "cbDomaine";
            this.cbDomaine.Size = new System.Drawing.Size(121, 21);
            this.cbDomaine.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ou :";
            // 
            // btEnvoyer
            // 
            this.btEnvoyer.Location = new System.Drawing.Point(81, 367);
            this.btEnvoyer.Name = "btEnvoyer";
            this.btEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btEnvoyer.TabIndex = 17;
            this.btEnvoyer.Text = "Envoyer";
            this.btEnvoyer.UseVisualStyleBackColor = true;
            this.btEnvoyer.Click += new System.EventHandler(this.btEnvoyer_Click);
            // 
            // FormSaisirOffre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 402);
            this.Controls.Add(this.btEnvoyer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDomaine);
            this.Controls.Add(this.cbNom);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDomaine);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSaisirOffre";
            this.Text = "FormSaisirOffre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDomaine;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbNom;
        private System.Windows.Forms.ComboBox cbDomaine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEnvoyer;
    }
}