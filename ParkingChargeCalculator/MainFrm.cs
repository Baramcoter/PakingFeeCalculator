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
            DateTime carInTime = Convert.ToDateTime(tbx_CarInTime.Text);
            DateTime carOutTime = Convert.ToDateTime(tbx_CarOutTime.Text);
            int basicTime = Properties.Settings.Default.basicTime;
            int basicCharge = Properties.Settings.Default.basicCharge;
            int addUnitTime = Properties.Settings.Default.addUnitTime;
            int addUnitCharge = Properties.Settings.Default.addUnitCharge;
            int freeUsingTime = Properties.Settings.Default.freeUsingTime;

            lbl_Charge.Text = GetParkingCharge(carInTime, carOutTime, basicTime, basicCharge, addUnitTime, addUnitCharge, freeUsingTime).ToString();
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

        private int GetParkingCharge(DateTime carInTime, DateTime carOutTime, int basicTime, int basicCharge, int addUnitTime, int addUnitCharge, int freeUsingTime)
        {
            //basicTime : 주차기본시간
            //basicCharge : 주차기본요금
            //addUnitTime : 추가단위시간
            //addUnitCharge : 추가단위요금
            //freeUsingTime : 사용무료시간

            int charge; //요금

            if (basicTime == 0 || basicCharge == 0 || addUnitTime == 0 || addUnitCharge == 0)
            {
                charge = 0;
            }
            else
            {

                TimeSpan usingTime = carOutTime - carInTime; //이용시간 : 출차시간 - 입차시간
                int usingTime_Hour2Minutes = usingTime.Hours * 60; //시간 -> 분단위
                int usingTime_Minutes = usingTime.Minutes;
                int usingTime2Minute = usingTime_Hour2Minutes + usingTime_Minutes; //사용시간 Hour -> Minutes

                //이용시간이 주차기본시간보다 적은 경우
                if (usingTime2Minute <= basicTime)
                {
                    //사용무료시간보다 이용시간이 적을경우 요금부과 X
                    if (usingTime2Minute <= freeUsingTime)
                    {
                        charge = 0;
                    }
                    else
                    {
                        charge = basicCharge;
                    }

                }
                else//주차기본시간을 초과한 경우
                {
                    int overBasicTime = usingTime2Minute - basicTime; //초과시간(주차기본시간 외 사용시간)
                    int overTimeValue = overBasicTime / addUnitTime; //추가요금 계산을 위한 값

                    if (overTimeValue <= 1) //초과시간이 추가단위시간보다 적을경우
                    {
                        charge = basicCharge;
                    }
                    else
                    {
                        int addCharge = overTimeValue * addUnitCharge; //추가요금((초과시간/추가단위시간) * 추가단위요금)
                        charge = basicCharge + addCharge;
                    }
                }
            }

            return charge;
        }
    }
}
