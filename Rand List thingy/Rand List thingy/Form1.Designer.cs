
namespace Rand_List_thingy
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
            this.runButt = new System.Windows.Forms.Button();
            this.inputThing = new System.Windows.Forms.TextBox();
            this.outputData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runButt
            // 
            this.runButt.Location = new System.Drawing.Point(42, 231);
            this.runButt.Name = "runButt";
            this.runButt.Size = new System.Drawing.Size(254, 154);
            this.runButt.TabIndex = 0;
            this.runButt.Text = "Generate!";
            this.runButt.UseVisualStyleBackColor = true;
            this.runButt.Click += new System.EventHandler(this.runButt_Click);
            // 
            // inputThing
            // 
            this.inputThing.Location = new System.Drawing.Point(120, 147);
            this.inputThing.Name = "inputThing";
            this.inputThing.Size = new System.Drawing.Size(100, 23);
            this.inputThing.TabIndex = 1;
            // 
            // outputData
            // 
            this.outputData.AutoSize = true;
            this.outputData.Location = new System.Drawing.Point(517, 77);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(38, 15);
            this.outputData.TabIndex = 2;
            this.outputData.Text = "label1";
            this.outputData.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputData);
            this.Controls.Add(this.inputThing);
            this.Controls.Add(this.runButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButt;
        private System.Windows.Forms.TextBox inputThing;
        private System.Windows.Forms.Label outputData;
    }
}

