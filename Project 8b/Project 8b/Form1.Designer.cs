
namespace Project_8b
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
            this.peopleOutput = new System.Windows.Forms.ListBox();
            this.show = new System.Windows.Forms.Button();
            this.addPerson = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleOutput
            // 
            this.peopleOutput.FormattingEnabled = true;
            this.peopleOutput.Location = new System.Drawing.Point(53, 12);
            this.peopleOutput.Name = "peopleOutput";
            this.peopleOutput.Size = new System.Drawing.Size(126, 95);
            this.peopleOutput.TabIndex = 0;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(79, 128);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 1;
            this.show.Text = "Show Info";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(79, 176);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(75, 23);
            this.addPerson.TabIndex = 2;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(79, 224);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Exit";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 270);
            this.Controls.Add(this.close);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.show);
            this.Controls.Add(this.peopleOutput);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox peopleOutput;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button close;
    }
}

