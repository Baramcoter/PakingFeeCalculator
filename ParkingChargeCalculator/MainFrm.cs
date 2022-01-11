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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fee_Setting_Click(object sender, EventArgs e)
        {
            FeeSetFrm settingForm = new FeeSetFrm();
            settingForm.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            string descliption = "기본 " + Properties.Settings.Default.basicTime.ToString() + " 분 당 " + Properties.Settings.Default.basicCharge.ToString() + " 원 입니다. \r\n" +
                                 "이 후 " + Properties.Settings.Default.addUnitTime.ToString() + " 분 당 " + Properties.Settings.Default.addUnitCharge.ToString() + " 원 추가됩니다.";

            tbx_PrkInfoDescliption.Text = descliption;
        }

        private void btn_CarIn_Now_Click(object sender, EventArgs e)
        {
            tbx_CarInTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_CarOut_Now_Click(object sender, EventArgs e)
        {
            tbx_CarOutTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void GetParkingCharge(DateTime carInTime, DateTime carOutTime, int basicTime, int basicCharge, int addUnitTime, int addUnitCharge)
        {

        }
    }
}
