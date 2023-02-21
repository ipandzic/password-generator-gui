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
            this.checkBoxCaps = new System.Windows.Forms.CheckBox();
            this.checkBoxNums = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbol = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generator zaporke";
            // 
            // checkBoxCaps
            // 
            this.checkBoxCaps.AutoSize = true;
            this.checkBoxCaps.Location = new System.Drawing.Point(225, 209);
            this.checkBoxCaps.Name = "checkBoxCaps";
            this.checkBoxCaps.Size = new System.Drawing.Size(117, 19);
            this.checkBoxCaps.TabIndex = 3;
            this.checkBoxCaps.Text = "Mala/velika slova";
            this.checkBoxCaps.UseVisualStyleBackColor = true;
            // 
            // checkBoxNums
            // 
            this.checkBoxNums.AutoSize = true;
            this.checkBoxNums.Location = new System.Drawing.Point(225, 252);
            this.checkBoxNums.Name = "checkBoxNums";
            this.checkBoxNums.Size = new System.Drawing.Size(62, 19);
            this.checkBoxNums.TabIndex = 4;
            this.checkBoxNums.Text = "Brojevi";
            this.checkBoxNums.UseVisualStyleBackColor = true;
            // 
            // checkBoxSymbol
            // 
            this.checkBoxSymbol.AutoSize = true;
            this.checkBoxSymbol.Location = new System.Drawing.Point(225, 294);
            this.checkBoxSymbol.Name = "checkBoxSymbol";
            this.checkBoxSymbol.Size = new System.Drawing.Size(66, 19);
            this.checkBoxSymbol.TabIndex = 5;
            this.checkBoxSymbol.Text = "Simboli";
            this.checkBoxSymbol.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(222, 350);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(246, 50);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generiraj";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(565, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(333, 156);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(227, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duljina zaporke";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.checkBoxSymbol);
            this.Controls.Add(this.checkBoxNums);
            this.Controls.Add(this.checkBoxCaps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBoxCaps;
        private CheckBox checkBoxNums;
        private CheckBox checkBoxSymbol;
        private Button GenerateButton;
        private Button saveButton;
        private TrackBar trackBar1;
        private Label label2;
    }
}