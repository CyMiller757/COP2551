
namespace Project_8a
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
            this.studentSelection = new System.Windows.Forms.ListBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchOutput = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentSelection
            // 
            this.studentSelection.FormattingEnabled = true;
            this.studentSelection.Location = new System.Drawing.Point(56, 91);
            this.studentSelection.Name = "studentSelection";
            this.studentSelection.Size = new System.Drawing.Size(118, 173);
            this.studentSelection.TabIndex = 0;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(262, 114);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(120, 20);
            this.searchInput.TabIndex = 1;
            // 
            // searchOutput
            // 
            this.searchOutput.FormattingEnabled = true;
            this.searchOutput.Location = new System.Drawing.Point(262, 169);
            this.searchOutput.Name = "searchOutput";
            this.searchOutput.Size = new System.Drawing.Size(120, 95);
            this.searchOutput.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(262, 140);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(244, 91);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(159, 13);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search for students by birth year";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(56, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(326, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_8a.Properties.Resources.anton_sukhinov__C2A8THeKKs_unsplash_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 398);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchOutput);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.studentSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentSelection;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ListBox searchOutput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button Exit;
    }
}

