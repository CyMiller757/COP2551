
namespace Project_8b
{
    partial class Form2
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
            this.showData = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showData
            // 
            this.showData.AutoSize = true;
            this.showData.Location = new System.Drawing.Point(12, 31);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(35, 13);
            this.showData.TabIndex = 0;
            this.showData.Text = "label1";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(84, 102);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(62, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 137);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.showData);
            this.Name = "Form2";
            this.Text = "Contact:";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showData;
        private System.Windows.Forms.Button OkButton;
    }
}