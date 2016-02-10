namespace ProjetGestionStage
{
    partial class Menu
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
            this.btCreerEntreprise = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btSaisirOffre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreerEntreprise
            // 
            this.btCreerEntreprise.Location = new System.Drawing.Point(95, 49);
            this.btCreerEntreprise.Name = "btCreerEntreprise";
            this.btCreerEntreprise.Size = new System.Drawing.Size(83, 70);
            this.btCreerEntreprise.TabIndex = 0;
            this.btCreerEntreprise.Text = "Créer une entreprise";
            this.btCreerEntreprise.UseVisualStyleBackColor = true;
            this.btCreerEntreprise.Click += new System.EventHandler(this.btCreerEntreprise_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btSaisirOffre
            // 
            this.btSaisirOffre.Location = new System.Drawing.Point(260, 49);
            this.btSaisirOffre.Name = "btSaisirOffre";
            this.btSaisirOffre.Size = new System.Drawing.Size(83, 70);
            this.btSaisirOffre.TabIndex = 3;
            this.btSaisirOffre.Text = "Saisir une offre de stage";
            this.btSaisirOffre.UseVisualStyleBackColor = true;
            this.btSaisirOffre.Click += new System.EventHandler(this.btSaisirOffre_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 302);
            this.Controls.Add(this.btSaisirOffre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCreerEntreprise);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreerEntreprise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btSaisirOffre;
    }
}