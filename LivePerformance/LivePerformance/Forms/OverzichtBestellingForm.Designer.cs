namespace LivePerformance
{
    partial class OverzichtBestellingForm
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
            this.lb_ItemsBestelling = new System.Windows.Forms.ListBox();
            this.bt_AddItem = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Prijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidige items";
            // 
            // lb_ItemsBestelling
            // 
            this.lb_ItemsBestelling.FormattingEnabled = true;
            this.lb_ItemsBestelling.ItemHeight = 16;
            this.lb_ItemsBestelling.Location = new System.Drawing.Point(12, 29);
            this.lb_ItemsBestelling.Name = "lb_ItemsBestelling";
            this.lb_ItemsBestelling.Size = new System.Drawing.Size(223, 324);
            this.lb_ItemsBestelling.TabIndex = 1;
            // 
            // bt_AddItem
            // 
            this.bt_AddItem.Location = new System.Drawing.Point(281, 46);
            this.bt_AddItem.Name = "bt_AddItem";
            this.bt_AddItem.Size = new System.Drawing.Size(188, 33);
            this.bt_AddItem.TabIndex = 2;
            this.bt_AddItem.Text = "Voeg item toe";
            this.bt_AddItem.UseVisualStyleBackColor = true;
            this.bt_AddItem.Click += new System.EventHandler(this.bt_AddItem_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(281, 320);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(188, 33);
            this.bt_Cancel.TabIndex = 3;
            this.bt_Cancel.Text = "Terug naar menu";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Totaalprijs:";
            // 
            // lbl_Prijs
            // 
            this.lbl_Prijs.AutoSize = true;
            this.lbl_Prijs.Location = new System.Drawing.Point(362, 9);
            this.lbl_Prijs.Name = "lbl_Prijs";
            this.lbl_Prijs.Size = new System.Drawing.Size(13, 17);
            this.lbl_Prijs.TabIndex = 5;
            this.lbl_Prijs.Text = "-";
            // 
            // OverzichtBestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Controls.Add(this.lbl_Prijs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_AddItem);
            this.Controls.Add(this.lb_ItemsBestelling);
            this.Controls.Add(this.label1);
            this.Name = "OverzichtBestellingForm";
            this.Text = "Overzicht van de bestelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_ItemsBestelling;
        private System.Windows.Forms.Button bt_AddItem;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Prijs;
    }
}