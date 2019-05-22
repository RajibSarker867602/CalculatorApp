namespace CalculatorApp
{
    partial class Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(225, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Number";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.DivideButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.MultiplyButton);
            this.groupBox1.Controls.Add(this.SubtractButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.secondNumberTextBox);
            this.groupBox1.Controls.Add(this.firstNumberTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(128, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Second Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(98, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Result";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(163, 40);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(179, 26);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(163, 76);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(179, 26);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(163, 112);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(179, 26);
            this.resultTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Lime;
            this.AddButton.Location = new System.Drawing.Point(163, 145);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 35);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SubtractButton.Location = new System.Drawing.Point(255, 145);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(87, 35);
            this.SubtractButton.TabIndex = 4;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = false;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MultiplyButton.Location = new System.Drawing.Point(163, 186);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(86, 31);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.Red;
            this.DivideButton.Location = new System.Drawing.Point(255, 186);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(87, 31);
            this.DivideButton.TabIndex = 6;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Navy;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(163, 223);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(179, 36);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(599, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

