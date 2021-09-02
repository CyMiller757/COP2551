
namespace Project_4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.TextBox();
            this.p2Score = new System.Windows.Forms.TextBox();
            this.p2Roll = new System.Windows.Forms.Button();
            this.p1Roll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(101, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(871, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(871, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score: ";
            // 
            // p1Score
            // 
            this.p1Score.Location = new System.Drawing.Point(969, 44);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(100, 20);
            this.p1Score.TabIndex = 5;
            // 
            // p2Score
            // 
            this.p2Score.Location = new System.Drawing.Point(969, 467);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(100, 20);
            this.p2Score.TabIndex = 6;
            // 
            // p2Roll
            // 
            this.p2Roll.Location = new System.Drawing.Point(997, 519);
            this.p2Roll.Name = "p2Roll";
            this.p2Roll.Size = new System.Drawing.Size(190, 63);
            this.p2Roll.TabIndex = 7;
            this.p2Roll.Text = "Roll???";
            this.p2Roll.UseVisualStyleBackColor = true;
            this.p2Roll.Click += new System.EventHandler(this.p2Roll_Click);
            // 
            // p1Roll
            // 
            this.p1Roll.Location = new System.Drawing.Point(997, 99);
            this.p1Roll.Name = "p1Roll";
            this.p1Roll.Size = new System.Drawing.Size(190, 63);
            this.p1Roll.TabIndex = 8;
            this.p1Roll.Text = "Roll!!!";
            this.p1Roll.UseVisualStyleBackColor = true;
            this.p1Roll.Click += new System.EventHandler(this.p1Roll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 624);
            this.Controls.Add(this.p1Roll);
            this.Controls.Add(this.p2Roll);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p1Score;
        private System.Windows.Forms.TextBox p2Score;
        private System.Windows.Forms.Button p2Roll;
        private System.Windows.Forms.Button p1Roll;
    }
}

