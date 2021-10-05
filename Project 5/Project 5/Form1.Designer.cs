
namespace Project_5
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
            this.LubePanel = new System.Windows.Forms.Panel();
            this.LubeOilText = new System.Windows.Forms.Label();
            this.OilChangeBox = new System.Windows.Forms.CheckBox();
            this.LubeBox = new System.Windows.Forms.CheckBox();
            this.FlushPanel = new System.Windows.Forms.Panel();
            this.TransFlushBox = new System.Windows.Forms.CheckBox();
            this.RadiatorFlushBox = new System.Windows.Forms.CheckBox();
            this.FlushesText = new System.Windows.Forms.Label();
            this.MiscPanel = new System.Windows.Forms.Panel();
            this.MufflerSwapBox = new System.Windows.Forms.CheckBox();
            this.InspectionBox = new System.Windows.Forms.CheckBox();
            this.MiscText = new System.Windows.Forms.Label();
            this.PartsAndLaborPanel = new System.Windows.Forms.Panel();
            this.PartsAndLaborText = new System.Windows.Forms.Label();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.Parts = new System.Windows.Forms.Label();
            this.LaborText = new System.Windows.Forms.TextBox();
            this.Labor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SummaryText = new System.Windows.Forms.Label();
            this.ServiceAndLaborText = new System.Windows.Forms.Label();
            this.PartsText = new System.Windows.Forms.Label();
            this.ServiceandLaborOut = new System.Windows.Forms.TextBox();
            this.PartsOut = new System.Windows.Forms.TextBox();
            this.TaxOut = new System.Windows.Forms.TextBox();
            this.TotalOut = new System.Windows.Forms.TextBox();
            this.TaxText = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TireRotateBox = new System.Windows.Forms.CheckBox();
            this.LubePanel.SuspendLayout();
            this.FlushPanel.SuspendLayout();
            this.MiscPanel.SuspendLayout();
            this.PartsAndLaborPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LubePanel
            // 
            this.LubePanel.Controls.Add(this.LubeBox);
            this.LubePanel.Controls.Add(this.OilChangeBox);
            this.LubePanel.Controls.Add(this.LubeOilText);
            this.LubePanel.Location = new System.Drawing.Point(58, 103);
            this.LubePanel.Name = "LubePanel";
            this.LubePanel.Size = new System.Drawing.Size(136, 68);
            this.LubePanel.TabIndex = 0;
            // 
            // LubeOilText
            // 
            this.LubeOilText.AutoSize = true;
            this.LubeOilText.Location = new System.Drawing.Point(0, 0);
            this.LubeOilText.Name = "LubeOilText";
            this.LubeOilText.Size = new System.Drawing.Size(67, 13);
            this.LubeOilText.TabIndex = 0;
            this.LubeOilText.Text = "Oil and Lube";
            // 
            // OilChangeBox
            // 
            this.OilChangeBox.AutoSize = true;
            this.OilChangeBox.Location = new System.Drawing.Point(4, 17);
            this.OilChangeBox.Name = "OilChangeBox";
            this.OilChangeBox.Size = new System.Drawing.Size(120, 17);
            this.OilChangeBox.TabIndex = 1;
            this.OilChangeBox.Text = "Oil Change ($26.00)";
            this.OilChangeBox.UseVisualStyleBackColor = true;
            // 
            // LubeBox
            // 
            this.LubeBox.AutoSize = true;
            this.LubeBox.Location = new System.Drawing.Point(3, 41);
            this.LubeBox.Name = "LubeBox";
            this.LubeBox.Size = new System.Drawing.Size(112, 17);
            this.LubeBox.TabIndex = 2;
            this.LubeBox.Text = "Lube Job ($18.00)";
            this.LubeBox.UseVisualStyleBackColor = true;
            // 
            // FlushPanel
            // 
            this.FlushPanel.Controls.Add(this.TransFlushBox);
            this.FlushPanel.Controls.Add(this.RadiatorFlushBox);
            this.FlushPanel.Controls.Add(this.FlushesText);
            this.FlushPanel.Location = new System.Drawing.Point(201, 104);
            this.FlushPanel.Name = "FlushPanel";
            this.FlushPanel.Size = new System.Drawing.Size(142, 68);
            this.FlushPanel.TabIndex = 3;
            // 
            // TransFlushBox
            // 
            this.TransFlushBox.AutoSize = true;
            this.TransFlushBox.Location = new System.Drawing.Point(3, 41);
            this.TransFlushBox.Name = "TransFlushBox";
            this.TransFlushBox.Size = new System.Drawing.Size(123, 17);
            this.TransFlushBox.TabIndex = 2;
            this.TransFlushBox.Text = "Trans Flush ($80.00)";
            this.TransFlushBox.UseVisualStyleBackColor = true;
            // 
            // RadiatorFlushBox
            // 
            this.RadiatorFlushBox.AutoSize = true;
            this.RadiatorFlushBox.Location = new System.Drawing.Point(4, 17);
            this.RadiatorFlushBox.Name = "RadiatorFlushBox";
            this.RadiatorFlushBox.Size = new System.Drawing.Size(136, 17);
            this.RadiatorFlushBox.TabIndex = 1;
            this.RadiatorFlushBox.Text = "Radiator Flush ($30.00)";
            this.RadiatorFlushBox.UseVisualStyleBackColor = true;
            // 
            // FlushesText
            // 
            this.FlushesText.AutoSize = true;
            this.FlushesText.Location = new System.Drawing.Point(0, 0);
            this.FlushesText.Name = "FlushesText";
            this.FlushesText.Size = new System.Drawing.Size(43, 13);
            this.FlushesText.TabIndex = 0;
            this.FlushesText.Text = "Flushes";
            // 
            // MiscPanel
            // 
            this.MiscPanel.Controls.Add(this.TireRotateBox);
            this.MiscPanel.Controls.Add(this.MufflerSwapBox);
            this.MiscPanel.Controls.Add(this.InspectionBox);
            this.MiscPanel.Controls.Add(this.MiscText);
            this.MiscPanel.Location = new System.Drawing.Point(58, 177);
            this.MiscPanel.Name = "MiscPanel";
            this.MiscPanel.Size = new System.Drawing.Size(136, 98);
            this.MiscPanel.TabIndex = 4;
            // 
            // MufflerSwapBox
            // 
            this.MufflerSwapBox.AutoSize = true;
            this.MufflerSwapBox.Location = new System.Drawing.Point(3, 41);
            this.MufflerSwapBox.Name = "MufflerSwapBox";
            this.MufflerSwapBox.Size = new System.Drawing.Size(136, 17);
            this.MufflerSwapBox.TabIndex = 2;
            this.MufflerSwapBox.Text = "Muffler Swap ($100.00)";
            this.MufflerSwapBox.UseVisualStyleBackColor = true;
            // 
            // InspectionBox
            // 
            this.InspectionBox.AutoSize = true;
            this.InspectionBox.Location = new System.Drawing.Point(4, 17);
            this.InspectionBox.Name = "InspectionBox";
            this.InspectionBox.Size = new System.Drawing.Size(117, 17);
            this.InspectionBox.TabIndex = 1;
            this.InspectionBox.Text = "Inspection ($15.00)";
            this.InspectionBox.UseVisualStyleBackColor = true;
            // 
            // MiscText
            // 
            this.MiscText.AutoSize = true;
            this.MiscText.Location = new System.Drawing.Point(0, 0);
            this.MiscText.Name = "MiscText";
            this.MiscText.Size = new System.Drawing.Size(29, 13);
            this.MiscText.TabIndex = 0;
            this.MiscText.Text = "Misc";
            // 
            // PartsAndLaborPanel
            // 
            this.PartsAndLaborPanel.Controls.Add(this.Labor);
            this.PartsAndLaborPanel.Controls.Add(this.LaborText);
            this.PartsAndLaborPanel.Controls.Add(this.Parts);
            this.PartsAndLaborPanel.Controls.Add(this.PartsTextBox);
            this.PartsAndLaborPanel.Controls.Add(this.PartsAndLaborText);
            this.PartsAndLaborPanel.Location = new System.Drawing.Point(201, 178);
            this.PartsAndLaborPanel.Name = "PartsAndLaborPanel";
            this.PartsAndLaborPanel.Size = new System.Drawing.Size(140, 97);
            this.PartsAndLaborPanel.TabIndex = 4;
            // 
            // PartsAndLaborText
            // 
            this.PartsAndLaborText.AutoSize = true;
            this.PartsAndLaborText.Location = new System.Drawing.Point(0, 0);
            this.PartsAndLaborText.Name = "PartsAndLaborText";
            this.PartsAndLaborText.Size = new System.Drawing.Size(82, 13);
            this.PartsAndLaborText.TabIndex = 0;
            this.PartsAndLaborText.Text = "Parts and Labor";
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.Location = new System.Drawing.Point(39, 32);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(87, 20);
            this.PartsTextBox.TabIndex = 1;
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Location = new System.Drawing.Point(2, 35);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(34, 13);
            this.Parts.TabIndex = 2;
            this.Parts.Text = "Parts:";
            // 
            // LaborText
            // 
            this.LaborText.Location = new System.Drawing.Point(39, 60);
            this.LaborText.Name = "LaborText";
            this.LaborText.Size = new System.Drawing.Size(87, 20);
            this.LaborText.TabIndex = 3;
            // 
            // Labor
            // 
            this.Labor.AutoSize = true;
            this.Labor.Location = new System.Drawing.Point(0, 63);
            this.Labor.Name = "Labor";
            this.Labor.Size = new System.Drawing.Size(37, 13);
            this.Labor.TabIndex = 4;
            this.Labor.Text = "Labor:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalText);
            this.panel1.Controls.Add(this.TaxText);
            this.panel1.Controls.Add(this.TotalOut);
            this.panel1.Controls.Add(this.TaxOut);
            this.panel1.Controls.Add(this.PartsOut);
            this.panel1.Controls.Add(this.ServiceandLaborOut);
            this.panel1.Controls.Add(this.PartsText);
            this.panel1.Controls.Add(this.ServiceAndLaborText);
            this.panel1.Controls.Add(this.SummaryText);
            this.panel1.Location = new System.Drawing.Point(58, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 135);
            this.panel1.TabIndex = 3;
            // 
            // SummaryText
            // 
            this.SummaryText.AutoSize = true;
            this.SummaryText.Location = new System.Drawing.Point(0, 0);
            this.SummaryText.Name = "SummaryText";
            this.SummaryText.Size = new System.Drawing.Size(50, 13);
            this.SummaryText.TabIndex = 0;
            this.SummaryText.Text = "Summary";
            // 
            // ServiceAndLaborText
            // 
            this.ServiceAndLaborText.AutoSize = true;
            this.ServiceAndLaborText.Location = new System.Drawing.Point(39, 22);
            this.ServiceAndLaborText.Name = "ServiceAndLaborText";
            this.ServiceAndLaborText.Size = new System.Drawing.Size(97, 13);
            this.ServiceAndLaborText.TabIndex = 1;
            this.ServiceAndLaborText.Text = "Service and Labor:";
            // 
            // PartsText
            // 
            this.PartsText.AutoSize = true;
            this.PartsText.Location = new System.Drawing.Point(102, 48);
            this.PartsText.Name = "PartsText";
            this.PartsText.Size = new System.Drawing.Size(34, 13);
            this.PartsText.TabIndex = 2;
            this.PartsText.Text = "Parts:";
            // 
            // ServiceandLaborOut
            // 
            this.ServiceandLaborOut.Enabled = false;
            this.ServiceandLaborOut.Location = new System.Drawing.Point(143, 19);
            this.ServiceandLaborOut.Name = "ServiceandLaborOut";
            this.ServiceandLaborOut.Size = new System.Drawing.Size(87, 20);
            this.ServiceandLaborOut.TabIndex = 5;
            // 
            // PartsOut
            // 
            this.PartsOut.Enabled = false;
            this.PartsOut.Location = new System.Drawing.Point(143, 45);
            this.PartsOut.Name = "PartsOut";
            this.PartsOut.Size = new System.Drawing.Size(87, 20);
            this.PartsOut.TabIndex = 6;
            // 
            // TaxOut
            // 
            this.TaxOut.Enabled = false;
            this.TaxOut.Location = new System.Drawing.Point(143, 71);
            this.TaxOut.Name = "TaxOut";
            this.TaxOut.Size = new System.Drawing.Size(87, 20);
            this.TaxOut.TabIndex = 7;
            // 
            // TotalOut
            // 
            this.TotalOut.Enabled = false;
            this.TotalOut.Location = new System.Drawing.Point(143, 97);
            this.TotalOut.Name = "TotalOut";
            this.TotalOut.Size = new System.Drawing.Size(87, 20);
            this.TotalOut.TabIndex = 8;
            // 
            // TaxText
            // 
            this.TaxText.AutoSize = true;
            this.TaxText.Location = new System.Drawing.Point(108, 74);
            this.TaxText.Name = "TaxText";
            this.TaxText.Size = new System.Drawing.Size(28, 13);
            this.TaxText.TabIndex = 9;
            this.TaxText.Text = "Tax:";
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Location = new System.Drawing.Point(102, 100);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(34, 13);
            this.TotalText.TabIndex = 10;
            this.TotalText.Text = "Total:";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(58, 422);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(163, 422);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(268, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TireRotateBox
            // 
            this.TireRotateBox.AutoSize = true;
            this.TireRotateBox.Location = new System.Drawing.Point(3, 64);
            this.TireRotateBox.Name = "TireRotateBox";
            this.TireRotateBox.Size = new System.Drawing.Size(129, 17);
            this.TireRotateBox.TabIndex = 3;
            this.TireRotateBox.Text = "Tire Rotation ($20.00)";
            this.TireRotateBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 512);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PartsAndLaborPanel);
            this.Controls.Add(this.MiscPanel);
            this.Controls.Add(this.FlushPanel);
            this.Controls.Add(this.LubePanel);
            this.Name = "Form1";
            this.Text = "Joe\'s Auto";
            this.LubePanel.ResumeLayout(false);
            this.LubePanel.PerformLayout();
            this.FlushPanel.ResumeLayout(false);
            this.FlushPanel.PerformLayout();
            this.MiscPanel.ResumeLayout(false);
            this.MiscPanel.PerformLayout();
            this.PartsAndLaborPanel.ResumeLayout(false);
            this.PartsAndLaborPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LubePanel;
        private System.Windows.Forms.CheckBox LubeBox;
        private System.Windows.Forms.CheckBox OilChangeBox;
        private System.Windows.Forms.Label LubeOilText;
        private System.Windows.Forms.Panel FlushPanel;
        private System.Windows.Forms.CheckBox TransFlushBox;
        private System.Windows.Forms.CheckBox RadiatorFlushBox;
        private System.Windows.Forms.Label FlushesText;
        private System.Windows.Forms.Panel MiscPanel;
        private System.Windows.Forms.CheckBox MufflerSwapBox;
        private System.Windows.Forms.CheckBox InspectionBox;
        private System.Windows.Forms.Label MiscText;
        private System.Windows.Forms.Panel PartsAndLaborPanel;
        private System.Windows.Forms.Label Labor;
        private System.Windows.Forms.TextBox LaborText;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.Label PartsAndLaborText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ServiceandLaborOut;
        private System.Windows.Forms.Label PartsText;
        private System.Windows.Forms.Label ServiceAndLaborText;
        private System.Windows.Forms.Label SummaryText;
        private System.Windows.Forms.TextBox TotalOut;
        private System.Windows.Forms.TextBox TaxOut;
        private System.Windows.Forms.TextBox PartsOut;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Label TaxText;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox TireRotateBox;
    }
}

