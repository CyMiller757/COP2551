
namespace Project_7
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
            this.fruitBox1 = new System.Windows.Forms.PictureBox();
            this.fruitBox3 = new System.Windows.Forms.PictureBox();
            this.fruitBox2 = new System.Windows.Forms.PictureBox();
            this.oneBet = new System.Windows.Forms.Button();
            this.fiveBet = new System.Windows.Forms.Button();
            this.tenBet = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.bankBox = new System.Windows.Forms.TextBox();
            this.bankText = new System.Windows.Forms.Label();
            this.enteredText = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.winningText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitBox1
            // 
            this.fruitBox1.Image = global::Project_7.Properties.Resources.Apple;
            this.fruitBox1.Location = new System.Drawing.Point(64, 157);
            this.fruitBox1.Name = "fruitBox1";
            this.fruitBox1.Size = new System.Drawing.Size(127, 127);
            this.fruitBox1.TabIndex = 0;
            this.fruitBox1.TabStop = false;
            // 
            // fruitBox3
            // 
            this.fruitBox3.Image = global::Project_7.Properties.Resources.Apple;
            this.fruitBox3.Location = new System.Drawing.Point(373, 157);
            this.fruitBox3.Name = "fruitBox3";
            this.fruitBox3.Size = new System.Drawing.Size(127, 127);
            this.fruitBox3.TabIndex = 1;
            this.fruitBox3.TabStop = false;
            // 
            // fruitBox2
            // 
            this.fruitBox2.Image = global::Project_7.Properties.Resources.Apple;
            this.fruitBox2.Location = new System.Drawing.Point(217, 157);
            this.fruitBox2.Name = "fruitBox2";
            this.fruitBox2.Size = new System.Drawing.Size(127, 127);
            this.fruitBox2.TabIndex = 2;
            this.fruitBox2.TabStop = false;
            // 
            // oneBet
            // 
            this.oneBet.Location = new System.Drawing.Point(161, 351);
            this.oneBet.Name = "oneBet";
            this.oneBet.Size = new System.Drawing.Size(75, 23);
            this.oneBet.TabIndex = 3;
            this.oneBet.Text = "$1 Bet";
            this.oneBet.UseVisualStyleBackColor = true;
            this.oneBet.Click += new System.EventHandler(this.oneBet_Click);
            // 
            // fiveBet
            // 
            this.fiveBet.Location = new System.Drawing.Point(233, 322);
            this.fiveBet.Name = "fiveBet";
            this.fiveBet.Size = new System.Drawing.Size(75, 23);
            this.fiveBet.TabIndex = 4;
            this.fiveBet.Text = "$5 Bet";
            this.fiveBet.UseVisualStyleBackColor = true;
            this.fiveBet.Click += new System.EventHandler(this.fiveBet_Click);
            // 
            // tenBet
            // 
            this.tenBet.Location = new System.Drawing.Point(305, 351);
            this.tenBet.Name = "tenBet";
            this.tenBet.Size = new System.Drawing.Size(75, 23);
            this.tenBet.TabIndex = 5;
            this.tenBet.Text = "$10 Bet";
            this.tenBet.UseVisualStyleBackColor = true;
            this.tenBet.Click += new System.EventHandler(this.tenBet_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(64, 421);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(411, 421);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(89, 23);
            this.quit.TabIndex = 7;
            this.quit.Text = "Cash Out (Quit)";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // bankBox
            // 
            this.bankBox.Enabled = false;
            this.bankBox.Location = new System.Drawing.Point(161, 63);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(219, 20);
            this.bankBox.TabIndex = 8;
            this.bankBox.Text = "$0";
            this.bankBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bankText
            // 
            this.bankText.AutoSize = true;
            this.bankText.Location = new System.Drawing.Point(230, 36);
            this.bankText.Name = "bankText";
            this.bankText.Size = new System.Drawing.Size(85, 13);
            this.bankText.TabIndex = 9;
            this.bankText.Text = "Amount in Bank:";
            // 
            // enteredText
            // 
            this.enteredText.AutoSize = true;
            this.enteredText.Location = new System.Drawing.Point(190, 390);
            this.enteredText.Name = "enteredText";
            this.enteredText.Size = new System.Drawing.Size(154, 13);
            this.enteredText.TabIndex = 10;
            this.enteredText.Text = "You Have Entered a total of $0";
            this.enteredText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(201, 99);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(35, 13);
            this.resultText.TabIndex = 11;
            this.resultText.Text = "label1";
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultText.Visible = false;
            // 
            // winningText
            // 
            this.winningText.AutoSize = true;
            this.winningText.Location = new System.Drawing.Point(246, 131);
            this.winningText.Name = "winningText";
            this.winningText.Size = new System.Drawing.Size(35, 13);
            this.winningText.TabIndex = 12;
            this.winningText.Text = "label1";
            this.winningText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 475);
            this.Controls.Add(this.winningText);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.enteredText);
            this.Controls.Add(this.bankText);
            this.Controls.Add(this.bankBox);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tenBet);
            this.Controls.Add(this.fiveBet);
            this.Controls.Add(this.oneBet);
            this.Controls.Add(this.fruitBox2);
            this.Controls.Add(this.fruitBox3);
            this.Controls.Add(this.fruitBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fruitBox1;
        private System.Windows.Forms.PictureBox fruitBox3;
        private System.Windows.Forms.PictureBox fruitBox2;
        private System.Windows.Forms.Button oneBet;
        private System.Windows.Forms.Button fiveBet;
        private System.Windows.Forms.Button tenBet;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.TextBox bankBox;
        private System.Windows.Forms.Label bankText;
        private System.Windows.Forms.Label enteredText;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label winningText;
    }
}

