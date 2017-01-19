namespace LivePerformance
{
    partial class AddItemForm
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
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.rbtn_StandaardPizza = new System.Windows.Forms.RadioButton();
            this.bt_PizzaSamenstellen = new System.Windows.Forms.Button();
            this.rbtn_Salade = new System.Windows.Forms.RadioButton();
            this.rbtn_Drank = new System.Windows.Forms.RadioButton();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Items
            // 
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.ItemHeight = 16;
            this.lb_Items.Location = new System.Drawing.Point(226, 12);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(305, 228);
            this.lb_Items.TabIndex = 0;
            // 
            // rbtn_StandaardPizza
            // 
            this.rbtn_StandaardPizza.AutoSize = true;
            this.rbtn_StandaardPizza.Location = new System.Drawing.Point(12, 12);
            this.rbtn_StandaardPizza.Name = "rbtn_StandaardPizza";
            this.rbtn_StandaardPizza.Size = new System.Drawing.Size(128, 21);
            this.rbtn_StandaardPizza.TabIndex = 1;
            this.rbtn_StandaardPizza.TabStop = true;
            this.rbtn_StandaardPizza.Text = "Standaardpizza";
            this.rbtn_StandaardPizza.UseVisualStyleBackColor = true;
            this.rbtn_StandaardPizza.CheckedChanged += new System.EventHandler(this.rbtn_StandaardPizza_CheckedChanged);
            // 
            // bt_PizzaSamenstellen
            // 
            this.bt_PizzaSamenstellen.Location = new System.Drawing.Point(12, 93);
            this.bt_PizzaSamenstellen.Name = "bt_PizzaSamenstellen";
            this.bt_PizzaSamenstellen.Size = new System.Drawing.Size(208, 38);
            this.bt_PizzaSamenstellen.TabIndex = 2;
            this.bt_PizzaSamenstellen.Text = "Pizza samenstellen";
            this.bt_PizzaSamenstellen.UseVisualStyleBackColor = true;
            // 
            // rbtn_Salade
            // 
            this.rbtn_Salade.AutoSize = true;
            this.rbtn_Salade.Location = new System.Drawing.Point(12, 39);
            this.rbtn_Salade.Name = "rbtn_Salade";
            this.rbtn_Salade.Size = new System.Drawing.Size(73, 21);
            this.rbtn_Salade.TabIndex = 3;
            this.rbtn_Salade.TabStop = true;
            this.rbtn_Salade.Text = "Salade";
            this.rbtn_Salade.UseVisualStyleBackColor = true;
            this.rbtn_Salade.CheckedChanged += new System.EventHandler(this.rbtn_Salade_CheckedChanged);
            // 
            // rbtn_Drank
            // 
            this.rbtn_Drank.AutoSize = true;
            this.rbtn_Drank.Location = new System.Drawing.Point(12, 66);
            this.rbtn_Drank.Name = "rbtn_Drank";
            this.rbtn_Drank.Size = new System.Drawing.Size(67, 21);
            this.rbtn_Drank.TabIndex = 4;
            this.rbtn_Drank.TabStop = true;
            this.rbtn_Drank.Text = "Drank";
            this.rbtn_Drank.UseVisualStyleBackColor = true;
            this.rbtn_Drank.CheckedChanged += new System.EventHandler(this.rbtn_Drank_CheckedChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(290, 246);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(241, 38);
            this.bt_Cancel.TabIndex = 5;
            this.bt_Cancel.Text = "Annuleren";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(12, 246);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(241, 38);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "Geselecteerde item toevoegen";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 298);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.rbtn_Drank);
            this.Controls.Add(this.rbtn_Salade);
            this.Controls.Add(this.bt_PizzaSamenstellen);
            this.Controls.Add(this.rbtn_StandaardPizza);
            this.Controls.Add(this.lb_Items);
            this.Name = "AddItemForm";
            this.Text = "Item toevoegen aan bestelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.RadioButton rbtn_StandaardPizza;
        private System.Windows.Forms.Button bt_PizzaSamenstellen;
        private System.Windows.Forms.RadioButton rbtn_Salade;
        private System.Windows.Forms.RadioButton rbtn_Drank;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Add;
    }
}