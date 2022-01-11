using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingChargeCalculator
{
    public partial class FeeSetFrm : Form
    {
        public FeeSetFrm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.basicTime = Convert.ToInt32(tbx_BasicTime.Text);
            Properties.Settings.Default.basicCharge = Convert.ToInt32(tbx_BasicCharge.Text);
            Properties.Settings.Default.addUnitTime = Convert.ToInt32(tbx_AddUnitTime.Text);
            Properties.Settings.Default.addUnitCharge = Convert.ToInt32(tbx_AddUnitCharge.Text);
            Properties.Settings.Default.Save();

            tbx_BasicTime.Enabled = false;
            tbx_BasicCharge.Enabled = false;
            tbx_AddUnitTime.Enabled = false;
            tbx_AddUnitCharge.Enabled = false;

            btn_Modify.Enabled = true;
        }

        private void FeeSetFrm_Load(object sender, EventArgs e)
        {
            tbx_BasicTime.Text = Properties.Settings.Default.basicTime.ToString();
            tbx_BasicCharge.Text = Properties.Settings.Default.basicCharge.ToString();
            tbx_AddUnitTime.Text = Properties.Settings.Default.addUnitTime.ToString();
            tbx_AddUnitCharge.Text = Properties.Settings.Default.addUnitCharge.ToString();

            if(getValueExist() == true)
            {
                btn_Save.Enabled = false;
                btn_Modify.Enabled = true;

                tbx_BasicTime.Enabled = false;
                tbx_BasicCharge.Enabled = false;
                tbx_AddUnitTime.Enabled = false;
                tbx_AddUnitCharge.Enabled = false;
            }
            else
            {
                btn_Save.Enabled = true;
                btn_Modify.Enabled = false;

                tbx_BasicTime.Enabled = true;
                tbx_BasicCharge.Enabled = true;
                tbx_AddUnitTime.Enabled = true;
                tbx_AddUnitCharge.Enabled = true;
            }
        }

        private bool getValueExist()
        {
            if(Properties.Settings.Default.basicTime != 0 ||
               Properties.Settings.Default.basicCharge != 0 ||
               Properties.Settings.Default.addUnitTime != 0 ||
               Properties.Settings.Default.addUnitCharge != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            tbx_BasicTime.Enabled = true;
            tbx_BasicCharge.Enabled = true;
            tbx_AddUnitTime.Enabled = true;
            tbx_AddUnitCharge.Enabled = true;

            btn_Modify.Enabled = false;
            btn_Save.Enabled = true;
        }
    }
}
