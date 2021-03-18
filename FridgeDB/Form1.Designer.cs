namespace FridgeDB
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.listFoodType = new System.Windows.Forms.ListBox();
            this.listFoodInTheFridge = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food in the fridge";
            // 
            // listFoodType
            // 
            this.listFoodType.FormattingEnabled = true;
            this.listFoodType.ItemHeight = 16;
            this.listFoodType.Location = new System.Drawing.Point(109, 99);
            this.listFoodType.Name = "listFoodType";
            this.listFoodType.Size = new System.Drawing.Size(120, 84);
            this.listFoodType.TabIndex = 2;
            this.listFoodType.SelectedIndexChanged += new System.EventHandler(this.listFoodType_SelectedIndexChanged);
            // 
            // listFoodInTheFridge
            // 
            this.listFoodInTheFridge.FormattingEnabled = true;
            this.listFoodInTheFridge.ItemHeight = 16;
            this.listFoodInTheFridge.Location = new System.Drawing.Point(323, 99);
            this.listFoodInTheFridge.Name = "listFoodInTheFridge";
            this.listFoodInTheFridge.Size = new System.Drawing.Size(120, 84);
            this.listFoodInTheFridge.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodInTheFridge);
            this.Controls.Add(this.listFoodType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listFoodType;
        private System.Windows.Forms.ListBox listFoodInTheFridge;
    }
}

