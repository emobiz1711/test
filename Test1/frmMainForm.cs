using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Test1
{
    
    public partial class frmMainForm : Form
    {
        CarBuilder oCurrentCarBuilder;
        public frmMainForm()
        {
            oCurrentCarBuilder = new CarBuilder();
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.0 TSI BMT – 115 hp – added price per month 339
            //1.5 TSI EVO BM – 130 hp – added price per month 359
            /// 1.5 TSI EVO BMT – 150 hp – added price per month 362
            // Color ==================================
            // Urano Grey – added price per month 0
            // Tornado Red – added price per month 2.51
            // Lapiz Blue Metallic – added price per month 8.11
            // Oryx White Perlmutteffect – added price per month 16.72
            // Security  & Technologies =================
            // Lane Assist – added price per month 9.74
            // Rear View – added price per month 4.51
            // LED Lights – added price per month 28.06
            // Park Assistant – added price per month 9.33
            // Media & Infotainment
            // App Connect – added price per month 3.13
            // Navigational System – added price per month 9.39



        }

        private void cbEngine_SelectedValueChanged(object sender, EventArgs e)
        {
            object oEngine = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex];

            oCurrentCarBuilder.SetEngine(oEngine.ToString());
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();

        }

        private void cbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            object oColor = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex];

            oCurrentCarBuilder.SetColor(oColor.ToString());
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }

        private void checkBox_LaneAssdist_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetLaneAsist(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();

        }

        private void checkBox_RearView_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetRearView(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }

        private void checkBox_LED_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetLED(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }

        private void checkBox_ParkAssistant_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetParkAssistant(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }

        private void checkBox_AppConnect_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetAppConnect(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }

        private void checkBox_Navigation_CheckedChanged(object sender, EventArgs e)
        {
            string strValue;
            if (((CheckBox)sender).Checked)
            {
                strValue = (((CheckBox)sender).Tag).ToString();
            }
            else
            {
                strValue = "0";
            }

            oCurrentCarBuilder.SetNavigationSystem(strValue);
            oCurrentCarBuilder.price();
            finalPrice.Text = oCurrentCarBuilder.fTotalPrice.ToString();
        }
    }
}
