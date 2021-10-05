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
        double preTaxTotal = 0, tax = 0, postTaxTotal = 0;

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

        private double OilLubeCharges()
        {
            double outie = 0;
            if (OilChangeBox.Equals(true))
            {
                outie += 26;
            }
            if (LubeBox.Equals(true))
            {
                outie += 18;
            }
            return outie;
        }

        private double FlushCharges()
        {
            double outie = 0;
            if (RadiatorFlushBox.Equals(true))
            {
                outie += 30;
            }
            if (TransFlushBox.Equals(true))
            {
                outie += 80;
            }
            return outie;

        }

        private double MiscCharges()
        {
            double outie = 0;
            if (InspectionBox.Equals(true))
            {
                outie += 15;
            }
            if (MufflerSwapBox.Equals(true))
            {
                outie += 15;
            }
            if (TireRotateBox.Equals(true))
            {
                outie += 20;
            }
            return outie;

        }

        private double TaxCharges()
        {
            double outie;
            if(PartsTextBox.Text == null)
            {
                return 0;
            }
            else if (outie = double.TryParse(PartsTextBox.Text))
            {
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
