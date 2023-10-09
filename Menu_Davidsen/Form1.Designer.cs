
namespace Menu_Davidsen
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
            this.burgersCheckBox = new System.Windows.Forms.CheckBox();
            this.friesCheckBox = new System.Windows.Forms.CheckBox();
            this.drinksCheckBox = new System.Windows.Forms.CheckBox();
            this.burgerBox = new System.Windows.Forms.GroupBox();
            this.friBox = new System.Windows.Forms.GroupBox();
            this.drinkBox = new System.Windows.Forms.GroupBox();
            this.regularButton = new System.Windows.Forms.RadioButton();
            this.cheeseButton = new System.Windows.Forms.RadioButton();
            this.baconButton = new System.Windows.Forms.RadioButton();
            this.baconCheeseButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.largeButton = new System.Windows.Forms.RadioButton();
            this.sodaButton = new System.Windows.Forms.RadioButton();
            this.waterButton = new System.Windows.Forms.RadioButton();
            this.computeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.burgerBox.SuspendLayout();
            this.friBox.SuspendLayout();
            this.drinkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // burgersCheckBox
            // 
            this.burgersCheckBox.AutoSize = true;
            this.burgersCheckBox.Location = new System.Drawing.Point(12, 12);
            this.burgersCheckBox.Name = "burgersCheckBox";
            this.burgersCheckBox.Size = new System.Drawing.Size(62, 17);
            this.burgersCheckBox.TabIndex = 0;
            this.burgersCheckBox.Text = "Burgers";
            this.burgersCheckBox.UseVisualStyleBackColor = true;
            this.burgersCheckBox.CheckedChanged += new System.EventHandler(this.burgersCheckBox_CheckedChanged);
            // 
            // friesCheckBox
            // 
            this.friesCheckBox.AutoSize = true;
            this.friesCheckBox.Location = new System.Drawing.Point(12, 148);
            this.friesCheckBox.Name = "friesCheckBox";
            this.friesCheckBox.Size = new System.Drawing.Size(48, 17);
            this.friesCheckBox.TabIndex = 1;
            this.friesCheckBox.Text = "Fries";
            this.friesCheckBox.UseVisualStyleBackColor = true;
            this.friesCheckBox.CheckedChanged += new System.EventHandler(this.friesCheckBox_CheckedChanged);
            // 
            // drinksCheckBox
            // 
            this.drinksCheckBox.AutoSize = true;
            this.drinksCheckBox.Location = new System.Drawing.Point(12, 249);
            this.drinksCheckBox.Name = "drinksCheckBox";
            this.drinksCheckBox.Size = new System.Drawing.Size(56, 17);
            this.drinksCheckBox.TabIndex = 2;
            this.drinksCheckBox.Text = "Drinks";
            this.drinksCheckBox.UseVisualStyleBackColor = true;
            this.drinksCheckBox.CheckedChanged += new System.EventHandler(this.drinksCheckBox_CheckedChanged);
            // 
            // burgerBox
            // 
            this.burgerBox.Controls.Add(this.baconCheeseButton);
            this.burgerBox.Controls.Add(this.baconButton);
            this.burgerBox.Controls.Add(this.cheeseButton);
            this.burgerBox.Controls.Add(this.regularButton);
            this.burgerBox.Location = new System.Drawing.Point(85, 12);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(200, 112);
            this.burgerBox.TabIndex = 3;
            this.burgerBox.TabStop = false;
            this.burgerBox.Text = "Choice for Burgers";
            this.burgerBox.Visible = false;
            // 
            // friBox
            // 
            this.friBox.Controls.Add(this.largeButton);
            this.friBox.Controls.Add(this.mediumButton);
            this.friBox.Controls.Add(this.smallButton);
            this.friBox.Location = new System.Drawing.Point(85, 148);
            this.friBox.Name = "friBox";
            this.friBox.Size = new System.Drawing.Size(200, 95);
            this.friBox.TabIndex = 4;
            this.friBox.TabStop = false;
            this.friBox.Text = "Choice for Fries";
            this.friBox.Visible = false;
            // 
            // drinkBox
            // 
            this.drinkBox.Controls.Add(this.waterButton);
            this.drinkBox.Controls.Add(this.sodaButton);
            this.drinkBox.Location = new System.Drawing.Point(85, 249);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(200, 73);
            this.drinkBox.TabIndex = 5;
            this.drinkBox.TabStop = false;
            this.drinkBox.Text = "Choice for Drinks";
            this.drinkBox.Visible = false;
            // 
            // regularButton
            // 
            this.regularButton.AutoSize = true;
            this.regularButton.Location = new System.Drawing.Point(7, 20);
            this.regularButton.Name = "regularButton";
            this.regularButton.Size = new System.Drawing.Size(92, 17);
            this.regularButton.TabIndex = 0;
            this.regularButton.TabStop = true;
            this.regularButton.Text = "Regular (4.19)";
            this.regularButton.UseVisualStyleBackColor = true;
            // 
            // cheeseButton
            // 
            this.cheeseButton.AutoSize = true;
            this.cheeseButton.Location = new System.Drawing.Point(7, 44);
            this.cheeseButton.Name = "cheeseButton";
            this.cheeseButton.Size = new System.Drawing.Size(106, 17);
            this.cheeseButton.TabIndex = 1;
            this.cheeseButton.TabStop = true;
            this.cheeseButton.Text = "w/ cheese (4.79)";
            this.cheeseButton.UseVisualStyleBackColor = true;
            // 
            // baconButton
            // 
            this.baconButton.AutoSize = true;
            this.baconButton.Location = new System.Drawing.Point(7, 68);
            this.baconButton.Name = "baconButton";
            this.baconButton.Size = new System.Drawing.Size(101, 17);
            this.baconButton.TabIndex = 2;
            this.baconButton.TabStop = true;
            this.baconButton.Text = "w/ bacon (4.79)";
            this.baconButton.UseVisualStyleBackColor = true;
            // 
            // baconCheeseButton
            // 
            this.baconCheeseButton.AutoSize = true;
            this.baconCheeseButton.Location = new System.Drawing.Point(6, 89);
            this.baconCheeseButton.Name = "baconCheeseButton";
            this.baconCheeseButton.Size = new System.Drawing.Size(160, 17);
            this.baconCheeseButton.TabIndex = 3;
            this.baconCheeseButton.TabStop = true;
            this.baconCheeseButton.Text = "w/ bacon and cheese (5.39)";
            this.baconCheeseButton.UseVisualStyleBackColor = true;
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(7, 20);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(80, 17);
            this.smallButton.TabIndex = 0;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "Small (2.39)";
            this.smallButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(6, 44);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(92, 17);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.TabStop = true;
            this.mediumButton.Text = "Medium (3.09)";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // largeButton
            // 
            this.largeButton.AutoSize = true;
            this.largeButton.Location = new System.Drawing.Point(7, 68);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(82, 17);
            this.largeButton.TabIndex = 2;
            this.largeButton.TabStop = true;
            this.largeButton.Text = "Large (4.99)";
            this.largeButton.UseVisualStyleBackColor = true;
            // 
            // sodaButton
            // 
            this.sodaButton.AutoSize = true;
            this.sodaButton.Location = new System.Drawing.Point(7, 19);
            this.sodaButton.Name = "sodaButton";
            this.sodaButton.Size = new System.Drawing.Size(80, 17);
            this.sodaButton.TabIndex = 0;
            this.sodaButton.TabStop = true;
            this.sodaButton.Text = "Soda (1.69)";
            this.sodaButton.UseVisualStyleBackColor = true;
            // 
            // waterButton
            // 
            this.waterButton.AutoSize = true;
            this.waterButton.Location = new System.Drawing.Point(7, 43);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(117, 17);
            this.waterButton.TabIndex = 1;
            this.waterButton.TabStop = true;
            this.waterButton.Text = "Bottled water (1.49)";
            this.waterButton.UseVisualStyleBackColor = true;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(331, 255);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(91, 34);
            this.computeButton.TabIndex = 6;
            this.computeButton.Text = "Compute Cost of Meal";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cost of meal: ";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(381, 295);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(100, 20);
            this.outputBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 336);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.friBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinksCheckBox);
            this.Controls.Add(this.friesCheckBox);
            this.Controls.Add(this.burgersCheckBox);
            this.Name = "Form1";
            this.Text = "Menu";
            this.burgerBox.ResumeLayout(false);
            this.burgerBox.PerformLayout();
            this.friBox.ResumeLayout(false);
            this.friBox.PerformLayout();
            this.drinkBox.ResumeLayout(false);
            this.drinkBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox burgersCheckBox;
        private System.Windows.Forms.CheckBox friesCheckBox;
        private System.Windows.Forms.CheckBox drinksCheckBox;
        private System.Windows.Forms.GroupBox burgerBox;
        private System.Windows.Forms.RadioButton baconCheeseButton;
        private System.Windows.Forms.RadioButton baconButton;
        private System.Windows.Forms.RadioButton cheeseButton;
        private System.Windows.Forms.RadioButton regularButton;
        private System.Windows.Forms.GroupBox friBox;
        private System.Windows.Forms.RadioButton largeButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.GroupBox drinkBox;
        private System.Windows.Forms.RadioButton waterButton;
        private System.Windows.Forms.RadioButton sodaButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
    }
}

