
namespace Project_2
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
            this.sqrInput = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.perGallonCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter square footage of the wall";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqrInput
            // 
            this.sqrInput.Location = new System.Drawing.Point(12, 34);
            this.sqrInput.Name = "sqrInput";
            this.sqrInput.Size = new System.Drawing.Size(184, 20);
            this.sqrInput.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(12, 136);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(184, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate!";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter cost per gallon of paint:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // perGallonCost
            // 
            this.perGallonCost.Location = new System.Drawing.Point(12, 95);
            this.perGallonCost.Name = "perGallonCost";
            this.perGallonCost.Size = new System.Drawing.Size(184, 20);
            this.perGallonCost.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 171);
            this.Controls.Add(this.perGallonCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.sqrInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sqrInput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox perGallonCost;
    }
}

