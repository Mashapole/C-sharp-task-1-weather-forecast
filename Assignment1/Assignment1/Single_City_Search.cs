using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Single_City_Search : Form
    {
        public Single_City_Search()
        {
            InitializeComponent();
        }

        private void ComparingApplication_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Capturing_Data.City.Length - 1; i++)
            {
                CMBCity.Items.Add(Capturing_Data.City[i]);
            }
        }




        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string startDate = dTPStartDate.Value.ToShortDateString();
            string EndDate = dTPEndDate.Value.ToShortDateString();



            string header = " ";
            header = "**********************************************************************************\n" +
                     "*******************WEATHER FORECAST REPORT***********************\n" +
                     "START DATE FROM:" + " " + startDate + " " + "AND END DATE:" + " " + EndDate + "\n" +
                    " ***********************************************************************************\n \n";

            string end = "\n**********************************************************************************\n" +
                               "********************************END OF REPORT*****************************";
            string dataholder = "";
            string dataholder2 = "";

            for (int i = 0; i < Capturing_Data.City.Length-1; i++)
            {
                if (CMBCity.SelectedItem== Capturing_Data.City[i])
                {
                    
                    if ((Convert.ToDateTime(Capturing_Data.Date[i])) >= (Convert.ToDateTime(startDate))
                         &&  (Convert.ToDateTime(Capturing_Data.Date[i])) <= (Convert.ToDateTime(EndDate)))
                    {


                        dataholder+="City :" +" "+CMBCity.Text+"\n"+
                            "Minimum Temparature :" + "\t \t \t" + Capturing_Data.Min[i].ToString() + "\n" +
                            "Maximum Temparature :" + "\t \t \t" + Capturing_Data.Max[i].ToString() + "\n"
                           +"Precipitation:" + "\t \t \t \t" + Capturing_Data.Precipitation[i].ToString() + "\n"
                           +"Humidty:" + "\t \t \t \t \t" + Capturing_Data.Humidity[i].ToString() + "\n" +
                           "Wind Speed" + "\t \t \t \t" + Capturing_Data.Windspeed[i].ToString() + "\n";



                    }

                    rtfSingleCity.Text = header + " " + dataholder + " " + end;
                }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Multiple_Selection().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel?", "Exit", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime StartDate = dtp_StartDate.Value;
            DateTime EndDate = dtpEnd.Value;

            string data_Holder = "";

            for(int i=0;i<Capturing_Data.Date.Length;i++)
            {
                if ((Convert.ToDateTime(Capturing_Data.Date[i].ToShortDateString())) > (Convert.ToDateTime(StartDate.ToShortDateString()))
                                                 &&
                 (Convert.ToDateTime(Capturing_Data.Date[i].ToShortDateString())) < (Convert.ToDateTime(EndDate.ToShortDateString())))
                { 

                    data_Holder += "\n" +
                                "Date :" + Capturing_Data.Date[i].ToShortDateString() + "\n" +
                                 "***********************************************************************************" + "\n" +
                                 "City Name:" + " " + "\t \t \t \t" + " " + Capturing_Data.City[i].ToString() + "\n" +
                                 "Minimum Temparature :" + "\t \t \t" + Capturing_Data.Min[i].ToString() + "\n" +
                                 "Maximum Temparature :" + "\t \t \t" + Capturing_Data.Max[i].ToString() + "\n"
                                + "Precipitation:" + "\t \t \t \t" + Capturing_Data.Precipitation[i].ToString() + "\n"
                                + "Humidty:" + "\t \t \t \t \t" + Capturing_Data.Humidity[i].ToString() + "\n" +
                                "Wind Speed" + "\t \t \t \t" + Capturing_Data.Windspeed[i].ToString() + "\n" +
                                "*************************************************************************************";

                }
                string header = " ";
                header = "***********************************************************************************\n" +
                         "********** DATE RANGE WEATHER FORECAST REPORT**********\n \n" +
                         "START DATE FROM:" + " " + StartDate.ToShortDateString() + " \n" + "AND END DATE:" + " " + EndDate.ToShortDateString() + "\n" +
                        "***********************************************************************************\n \n";

                string end = "*******************************END OF REPORT***************************";
                rTbCityReport.Text = header + " "+data_Holder+" "+end;

            }
        }

        private void btnClearButton_Click(object sender, EventArgs e)
        {
            rtfSingleCity.Clear();
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            rTbCityReport.Clear();
        }
    }

    }
