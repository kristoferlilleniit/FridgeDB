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
            this.FoodType = new System.Windows.Forms.Label();
            this.FoodType1 = new System.Windows.Forms.ListBox();
            this.FoodInTheFridge1 = new System.Windows.Forms.ListBox();
            this.Food = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FoodType
            // 
            this.FoodType.AutoSize = true;
            this.FoodType.Location = new System.Drawing.Point(43, 60);
            this.FoodType.Name = "FoodType";
            this.FoodType.Size = new System.Drawing.Size(55, 13);
            this.FoodType.TabIndex = 0;
            this.FoodType.Text = "FoodType";
            // 
            // FoodType1
            // 
            this.FoodType1.FormattingEnabled = true;
            this.FoodType1.Location = new System.Drawing.Point(46, 96);
            this.FoodType1.Name = "FoodType1";
            this.FoodType1.Size = new System.Drawing.Size(120, 95);
            this.FoodType1.TabIndex = 1;
            this.FoodType1.SelectedIndexChanged += new System.EventHandler(this.FoodType_SelectedIndexChanged);
            // 
            // FoodInTheFridge1
            // 
            this.FoodInTheFridge1.FormattingEnabled = true;
            this.FoodInTheFridge1.Location = new System.Drawing.Point(280, 96);
            this.FoodInTheFridge1.Name = "FoodInTheFridge1";
            this.FoodInTheFridge1.Size = new System.Drawing.Size(120, 95);
            this.FoodInTheFridge1.TabIndex = 2;
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(280, 60);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(31, 13);
            this.Food.TabIndex = 3;
            this.Food.Text = "Food";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.FoodInTheFridge1);
            this.Controls.Add(this.FoodType1);
            this.Controls.Add(this.FoodType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoodType;
        private System.Windows.Forms.ListBox FoodType1;
        private System.Windows.Forms.ListBox FoodInTheFridge1;
        private System.Windows.Forms.Label Food;
    }
}

