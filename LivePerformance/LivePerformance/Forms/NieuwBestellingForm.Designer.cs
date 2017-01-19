namespace LivePerformance
{
    partial class NieuwBestellingForm
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
            this.lb_Klanten = new System.Windows.Forms.ListBox();
            this.bt_SelectKlant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SelectedKlant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Klanten
            // 
            this.lb_Klanten.FormattingEnabled = true;
            this.lb_Klanten.ItemHeight = 16;
            this.lb_Klanten.Location = new System.Drawing.Point(12, 50);
            this.lb_Klanten.Name = "lb_Klanten";
            this.lb_Klanten.Size = new System.Drawing.Size(233, 340);
            this.lb_Klanten.TabIndex = 0;
            // 
            // bt_SelectKlant
            // 
            this.bt_SelectKlant.Location = new System.Drawing.Point(267, 127);
            this.bt_SelectKlant.Name = "bt_SelectKlant";
            this.bt_SelectKlant.Size = new System.Drawing.Size(129, 46);
            this.bt_SelectKlant.TabIndex = 1;
            this.bt_SelectKlant.Text = "Selecteer klant";
            this.bt_SelectKlant.UseVisualStyleBackColor = true;
            this.bt_SelectKlant.Click += new System.EventHandler(this.bt_SelectKlant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alle klanten";
            // 
            // tb_SelectedKlant
            // 
            this.tb_SelectedKlant.Location = new System.Drawing.Point(267, 80);
            this.tb_SelectedKlant.Name = "tb_SelectedKlant";
            this.tb_SelectedKlant.ReadOnly = true;
            this.tb_SelectedKlant.Size = new System.Drawing.Size(177, 22);
            this.tb_SelectedKlant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Huidige klant";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(267, 179);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(129, 46);
            this.bt_Clear.TabIndex = 5;
            this.bt_Clear.Text = "Clear selectie";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.Location = new System.Drawing.Point(402, 127);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(129, 46);
            this.bt_Confirm.TabIndex = 6;
            this.bt_Confirm.Text = "Bevestig bestelling";
            this.bt_Confirm.UseVisualStyleBackColor = true;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(402, 179);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(129, 46);
            this.bt_Back.TabIndex = 7;
            this.bt_Back.Text = "Terug naar menu";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // NieuwBestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 406);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_Confirm);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SelectedKlant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_SelectKlant);
            this.Controls.Add(this.lb_Klanten);
            this.Name = "NieuwBestellingForm";
            this.Text = "Nieuwe bestelling maken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Klanten;
        private System.Windows.Forms.Button bt_SelectKlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SelectedKlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Confirm;
        private System.Windows.Forms.Button bt_Back;
    }
}