
namespace Project_8b
{
    partial class Form3
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
            this.enterPersonButt = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.cancelButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPersonButt
            // 
            this.enterPersonButt.Location = new System.Drawing.Point(113, 162);
            this.enterPersonButt.Name = "enterPersonButt";
            this.enterPersonButt.Size = new System.Drawing.Size(100, 23);
            this.enterPersonButt.TabIndex = 0;
            this.enterPersonButt.Text = "Confirm";
            this.enterPersonButt.UseVisualStyleBackColor = true;
            this.enterPersonButt.Click += new System.EventHandler(this.enterPersonButt_Click);
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(62, 39);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(41, 13);
            this.nameText.TabIndex = 1;
            this.nameText.Text = "Name: ";
            this.nameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(62, 80);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(38, 13);
            this.emailText.TabIndex = 2;
            this.emailText.Text = "Email: ";
            // 
            // numText
            // 
            this.numText.AutoSize = true;
            this.numText.Location = new System.Drawing.Point(19, 130);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(84, 13);
            this.numText.TabIndex = 3;
            this.numText.Text = "Phone Number: ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(113, 36);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(113, 77);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 5;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(113, 127);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 6;
            // 
            // cancelButt
            // 
            this.cancelButt.Location = new System.Drawing.Point(113, 201);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(100, 23);
            this.cancelButt.TabIndex = 7;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.UseVisualStyleBackColor = true;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 236);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.enterPersonButt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterPersonButt;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label numText;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button cancelButt;
    }
}