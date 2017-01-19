namespace LivePerformance
{
    partial class NieuwKlantForm
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
            this.bt_AddKlant = new System.Windows.Forms.Button();
            this.tb_Naam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // bt_AddKlant
            // 
            this.bt_AddKlant.Location = new System.Drawing.Point(15, 87);
            this.bt_AddKlant.Name = "bt_AddKlant";
            this.bt_AddKlant.Size = new System.Drawing.Size(82, 35);
            this.bt_AddKlant.TabIndex = 1;
            this.bt_AddKlant.Text = "Bevestig";
            this.bt_AddKlant.UseVisualStyleBackColor = true;
            this.bt_AddKlant.Click += new System.EventHandler(this.bt_AddKlant_Click);
            // 
            // tb_Naam
            // 
            this.tb_Naam.Location = new System.Drawing.Point(111, 6);
            this.tb_Naam.Name = "tb_Naam";
            this.tb_Naam.Size = new System.Drawing.Size(100, 22);
            this.tb_Naam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres:";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(111, 34);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(100, 22);
            this.tb_Adres.TabIndex = 5;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(129, 87);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(82, 35);
            this.bt_Cancel.TabIndex = 6;
            this.bt_Cancel.Text = "Annuleer";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // NieuwKlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 138);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Naam);
            this.Controls.Add(this.bt_AddKlant);
            this.Controls.Add(this.label1);
            this.Name = "NieuwKlantForm";
            this.Text = "Nieuwe klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_AddKlant;
        private System.Windows.Forms.TextBox tb_Naam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.Button bt_Cancel;
    }
}