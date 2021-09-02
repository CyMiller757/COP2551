
namespace Project_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputUnits = new System.Windows.Forms.ListBox();
            this.outputUnits = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputUnits
            // 
            this.inputUnits.FormattingEnabled = true;
            this.inputUnits.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.inputUnits.Location = new System.Drawing.Point(382, 208);
            this.inputUnits.Name = "inputUnits";
            this.inputUnits.Size = new System.Drawing.Size(41, 43);
            this.inputUnits.TabIndex = 0;
            // 
            // outputUnits
            // 
            this.outputUnits.FormattingEnabled = true;
            this.outputUnits.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.outputUnits.Location = new System.Drawing.Point(461, 316);
            this.outputUnits.Name = "outputUnits";
            this.outputUnits.Size = new System.Drawing.Size(41, 43);
            this.outputUnits.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(261, 219);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(145, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convert";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(406, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outBox
            // 
            this.outBox.AutoSize = true;
            this.outBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.outBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outBox.Location = new System.Drawing.Point(502, 658);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(0, 31);
            this.outBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 732);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputUnits);
            this.Controls.Add(this.inputUnits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputUnits;
        private System.Windows.Forms.ListBox outputUnits;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outBox;
    }
}

