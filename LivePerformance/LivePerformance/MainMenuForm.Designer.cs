namespace LivePerformance
{
    partial class MainMenuForm
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
            this.lb_Bestellingen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenBestelling = new System.Windows.Forms.Button();
            this.btn_PrintBon = new System.Windows.Forms.Button();
            this.btn_NieuwBestelling = new System.Windows.Forms.Button();
            this.btn_NieuwKlant = new System.Windows.Forms.Button();
            this.btn_EditStandaardPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Bestellingen
            // 
            this.lb_Bestellingen.FormattingEnabled = true;
            this.lb_Bestellingen.ItemHeight = 16;
            this.lb_Bestellingen.Location = new System.Drawing.Point(12, 45);
            this.lb_Bestellingen.Name = "lb_Bestellingen";
            this.lb_Bestellingen.Size = new System.Drawing.Size(240, 340);
            this.lb_Bestellingen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bestellingen";
            // 
            // btn_OpenBestelling
            // 
            this.btn_OpenBestelling.Location = new System.Drawing.Point(341, 92);
            this.btn_OpenBestelling.Name = "btn_OpenBestelling";
            this.btn_OpenBestelling.Size = new System.Drawing.Size(240, 41);
            this.btn_OpenBestelling.TabIndex = 2;
            this.btn_OpenBestelling.Text = "Open geselecteerde bestelling";
            this.btn_OpenBestelling.UseVisualStyleBackColor = true;
            this.btn_OpenBestelling.Click += new System.EventHandler(this.btn_OpenBestelling_Click);
            // 
            // btn_PrintBon
            // 
            this.btn_PrintBon.Location = new System.Drawing.Point(341, 139);
            this.btn_PrintBon.Name = "btn_PrintBon";
            this.btn_PrintBon.Size = new System.Drawing.Size(240, 41);
            this.btn_PrintBon.TabIndex = 3;
            this.btn_PrintBon.Text = "Print bon";
            this.btn_PrintBon.UseVisualStyleBackColor = true;
            // 
            // btn_NieuwBestelling
            // 
            this.btn_NieuwBestelling.Location = new System.Drawing.Point(341, 186);
            this.btn_NieuwBestelling.Name = "btn_NieuwBestelling";
            this.btn_NieuwBestelling.Size = new System.Drawing.Size(240, 41);
            this.btn_NieuwBestelling.TabIndex = 4;
            this.btn_NieuwBestelling.Text = "Nieuwe bestelling";
            this.btn_NieuwBestelling.UseVisualStyleBackColor = true;
            this.btn_NieuwBestelling.Click += new System.EventHandler(this.btn_NieuwBestelling_Click);
            // 
            // btn_NieuwKlant
            // 
            this.btn_NieuwKlant.Location = new System.Drawing.Point(341, 233);
            this.btn_NieuwKlant.Name = "btn_NieuwKlant";
            this.btn_NieuwKlant.Size = new System.Drawing.Size(240, 41);
            this.btn_NieuwKlant.TabIndex = 5;
            this.btn_NieuwKlant.Text = "Klant toevoegen";
            this.btn_NieuwKlant.UseVisualStyleBackColor = true;
            this.btn_NieuwKlant.Click += new System.EventHandler(this.btn_NieuwKlant_Click);
            // 
            // btn_EditStandaardPizza
            // 
            this.btn_EditStandaardPizza.Location = new System.Drawing.Point(341, 280);
            this.btn_EditStandaardPizza.Name = "btn_EditStandaardPizza";
            this.btn_EditStandaardPizza.Size = new System.Drawing.Size(240, 41);
            this.btn_EditStandaardPizza.TabIndex = 6;
            this.btn_EditStandaardPizza.Text = "Standaardpizza\'s bewerken";
            this.btn_EditStandaardPizza.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.btn_EditStandaardPizza);
            this.Controls.Add(this.btn_NieuwKlant);
            this.Controls.Add(this.btn_NieuwBestelling);
            this.Controls.Add(this.btn_PrintBon);
            this.Controls.Add(this.btn_OpenBestelling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Bestellingen);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Bestellingen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenBestelling;
        private System.Windows.Forms.Button btn_PrintBon;
        private System.Windows.Forms.Button btn_NieuwBestelling;
        private System.Windows.Forms.Button btn_NieuwKlant;
        private System.Windows.Forms.Button btn_EditStandaardPizza;
    }
}

