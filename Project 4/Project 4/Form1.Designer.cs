
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gameStarter = new System.Windows.Forms.Button();
            this.dice1Display = new System.Windows.Forms.PictureBox();
            this.dice2Display = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.turnMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score: ";
            // 
            // p1Score
            // 
            this.p1Score.Enabled = false;
            this.p1Score.Location = new System.Drawing.Point(166, 72);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(100, 20);
            this.p1Score.TabIndex = 5;
            this.p1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2Score
            // 
            this.p2Score.Enabled = false;
            this.p2Score.Location = new System.Drawing.Point(202, 72);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(100, 20);
            this.p2Score.TabIndex = 6;
            this.p2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2Roll
            // 
            this.p2Roll.Location = new System.Drawing.Point(70, 206);
            this.p2Roll.Name = "p2Roll";
            this.p2Roll.Size = new System.Drawing.Size(190, 63);
            this.p2Roll.TabIndex = 7;
            this.p2Roll.Text = "Roll???";
            this.p2Roll.UseVisualStyleBackColor = true;
            this.p2Roll.Click += new System.EventHandler(this.p2Roll_Click);
            // 
            // p1Roll
            // 
            this.p1Roll.Location = new System.Drawing.Point(64, 206);
            this.p1Roll.Name = "p1Roll";
            this.p1Roll.Size = new System.Drawing.Size(190, 63);
            this.p1Roll.TabIndex = 8;
            this.p1Roll.Text = "Roll!!!";
            this.p1Roll.UseVisualStyleBackColor = true;
            this.p1Roll.Click += new System.EventHandler(this.p1Roll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 328);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.p1Roll);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.p1Score);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.p2Roll);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.p2Score);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(752, 354);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 9;
            // 
            // gameStarter
            // 
            this.gameStarter.Location = new System.Drawing.Point(735, 12);
            this.gameStarter.Name = "gameStarter";
            this.gameStarter.Size = new System.Drawing.Size(75, 64);
            this.gameStarter.TabIndex = 10;
            this.gameStarter.Text = "Start Game?";
            this.gameStarter.UseVisualStyleBackColor = true;
            this.gameStarter.Click += new System.EventHandler(this.gameStarter_Click);
            // 
            // dice1Display
            // 
            this.dice1Display.Image = global::Project_4.Properties.Resources.Die6;
            this.dice1Display.Location = new System.Drawing.Point(266, 191);
            this.dice1Display.Name = "dice1Display";
            this.dice1Display.Size = new System.Drawing.Size(107, 113);
            this.dice1Display.TabIndex = 11;
            this.dice1Display.TabStop = false;
            this.dice1Display.Visible = false;
            // 
            // dice2Display
            // 
            this.dice2Display.Location = new System.Drawing.Point(392, 191);
            this.dice2Display.Name = "dice2Display";
            this.dice2Display.Size = new System.Drawing.Size(107, 113);
            this.dice2Display.TabIndex = 12;
            this.dice2Display.TabStop = false;
            this.dice2Display.Visible = false;
            // 
            // turnMessage
            // 
            this.turnMessage.AutoSize = true;
            this.turnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.turnMessage.Location = new System.Drawing.Point(12, 20);
            this.turnMessage.Name = "turnMessage";
            this.turnMessage.Size = new System.Drawing.Size(102, 37);
            this.turnMessage.TabIndex = 13;
            this.turnMessage.Text = "label6";
            this.turnMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 722);
            this.Controls.Add(this.turnMessage);
            this.Controls.Add(this.dice2Display);
            this.Controls.Add(this.dice1Display);
            this.Controls.Add(this.gameStarter);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button gameStarter;
        private System.Windows.Forms.PictureBox dice1Display;
        private System.Windows.Forms.PictureBox dice2Display;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label turnMessage;
    }
}

