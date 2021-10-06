using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            
            TotalOut.Text = TotalCharges().ToString();
            TaxOut.Text = TaxCharges().ToString();
            if(PartsTextBox.Text == "")
            {
                PartsOut.Text = "0";
            }
            else
            {
                PartsOut.Text = PartsTextBox.Text;
            }
            ServiceandLaborOut.Text = CalcPartsAndLabor().ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private double CalcPartsAndLabor()
        {
            double temp, labor;
            temp = OilLubeCharges() + FlushCharges() + MiscCharges();
            if(LaborText.Text == "")
            {
                return temp;
            }
            else
            {
                double.TryParse(LaborText.Text, out labor);
                return temp + labor;
            }
        }

        private double OilLubeCharges()
        {
            double outie = 0;
            if (OilChangeBox.Checked)
            {
                outie += 26;
            }
            if (LubeBox.Checked)
            {
                outie += 18;
            }
            return outie;
        }

        private double FlushCharges()
        {
            double outie = 0;
            if (RadiatorFlushBox.Checked)
            {
                outie += 30;
            }
            if (TransFlushBox.Checked)
            {
                outie += 80;
            }
            return outie;

        }

        private double MiscCharges()
        {
            double outie = 0;
            if (InspectionBox.Checked)
            {
                outie += 15;
            }
            if (MufflerSwapBox.Checked)
            {
                outie += 100;
            }
            if (TireRotateBox.Checked)
            {
                outie += 20;
            }
            return outie;

        }

        private double OtherCharges()
        {
            double parts = 0, labor = 0, outie = 0;
            if(PartsTextBox.Text == "" && LaborText.Text == "")
            {
                return 0;
            }
            else if(double.TryParse(PartsTextBox.Text, out parts))
            {
                outie += parts;
            }
            else
            {
                MessageBox.Show("Please enter Valid Parts Input");
                return 0;
            }
            if (double.TryParse(LaborText.Text, out labor))
            {
                outie += labor;
            }
            else
            {
                MessageBox.Show("Please enter Valid Labor Input");
                return 0;
            }
            return outie;
        }

        private double TaxCharges()
        {
            double outie;
            if(PartsTextBox.Text == "")
            {
                return 0;
            }
            else if (double.TryParse(PartsTextBox.Text, out outie))
            {
                outie *= .06;
                return outie;
            }
            else
            {
                MessageBox.Show("Please enter Valid Parts Input");
                return 0;
            }
        }

        private double TotalCharges()
        {
            return (TaxCharges() + MiscCharges() + OtherCharges() 
                + FlushCharges() + OilLubeCharges());
        }

        private void ClearOilLube()
        {
            OilChangeBox.Checked = false;
            LubeBox.Checked = false;
        }

        private void ClearFlushes()
        {
            RadiatorFlushBox.Checked = false;
            TransFlushBox.Checked = false;
        }

        private void ClearMisc()
        {
            InspectionBox.Checked = false;
            MufflerSwapBox.Checked = false;
            TireRotateBox.Checked = false;
        }

        private void ClearOther()
        {
            PartsTextBox.Text = null;
            LaborText.Text = null;

        }

        private void ClearFees()
        {
            ServiceandLaborOut.Text = null;
            PartsOut.Text = null;
            TaxOut.Text = null;
            TotalOut.Text = null;

        }
    }
}
