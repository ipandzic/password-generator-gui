namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCaps = new System.Windows.Forms.CheckBox();
            this.checkBoxNums = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbol = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Generator";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Use 10 characters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaps
            // 
            this.checkBoxCaps.AutoSize = true;
            this.checkBoxCaps.Location = new System.Drawing.Point(224, 207);
            this.checkBoxCaps.Name = "checkBoxCaps";
            this.checkBoxCaps.Size = new System.Drawing.Size(118, 19);
            this.checkBoxCaps.TabIndex = 3;
            this.checkBoxCaps.Text = "Use capital letters";
            this.checkBoxCaps.UseVisualStyleBackColor = true;
            // 
            // checkBoxNums
            // 
            this.checkBoxNums.AutoSize = true;
            this.checkBoxNums.Location = new System.Drawing.Point(225, 256);
            this.checkBoxNums.Name = "checkBoxNums";
            this.checkBoxNums.Size = new System.Drawing.Size(95, 19);
            this.checkBoxNums.TabIndex = 4;
            this.checkBoxNums.Text = "Use numbers";
            this.checkBoxNums.UseVisualStyleBackColor = true;
            // 
            // checkBoxSymbol
            // 
            this.checkBoxSymbol.AutoSize = true;
            this.checkBoxSymbol.Location = new System.Drawing.Point(224, 295);
            this.checkBoxSymbol.Name = "checkBoxSymbol";
            this.checkBoxSymbol.Size = new System.Drawing.Size(92, 19);
            this.checkBoxSymbol.TabIndex = 5;
            this.checkBoxSymbol.Text = "Use symbols";
            this.checkBoxSymbol.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(222, 350);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(246, 50);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(565, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.checkBoxSymbol);
            this.Controls.Add(this.checkBoxNums);
            this.Controls.Add(this.checkBoxCaps);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBoxCaps;
        private CheckBox checkBoxNums;
        private CheckBox checkBoxSymbol;
        private Button GenerateButton;
        private Button saveButton;
    }
}