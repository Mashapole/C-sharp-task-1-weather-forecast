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
    public partial class Multiple_Selection : Form
    {
        public Multiple_Selection()
        {
            InitializeComponent();
        }

        private void Multiple_Selection_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Capturing_Data.City.Length - 1; i++)
            {
                lsbCities.Items.Add(Capturing_Data.City[i]);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel?", "Exit", MessageBoxButtons.YesNo)
                            == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            string startDate = dtpStart.Value.ToShortDateString();
            string EndDate = dtpEnd.Value.ToShortDateString();

            StringBuilder Task1 = new StringBuilder();
            StringBuilder task = new StringBuilder();



            string header = " ";
            header = "**********************************************************************************\n" +
                     "*******************WEATHER FORECAST REPORT***********************\n" +
                     "START DATE FROM:" + " " + startDate + " " + "AND END DATE:" + " " + EndDate + "\n" +
                    " * *********************************************************************************\n ";

            string end = "\n**********************************************************************************\n" +
                               "********************************END OF REPORT*****************************";


            for (int i = 0; i < lsbCities.SelectedItems.Count; i++)
            {

                if ((Convert.ToDateTime(Capturing_Data.Date[i])) >= (Convert.ToDateTime(startDate))
                         && (Convert.ToDateTime(Capturing_Data.Date[i])) <= (Convert.ToDateTime(EndDate)))
                {
                    if (lsbCities.SelectedItems[i] == Capturing_Data.City[i])
                    {
                        Task1.Append("City :" + lsbCities.SelectedItems[i] + "\t \t" + "\n"+
                        "Minimum Temparature :" + "\t \t \t" + Capturing_Data.Min[i].ToString() + "\n" +
                        "Maximum Temparature :" + "\t \t \t" + Capturing_Data.Max[i].ToString() + "\n"
                       + "Precipitation:" + "\t \t \t \t" + Capturing_Data.Precipitation[i].ToString() + "\n"
                       + "Humidty:" + "\t \t \t \t \t" + Capturing_Data.Humidity[i].ToString() + "\n" +
                       "Wind Speed" + "\t \t \t \t" + Capturing_Data.Windspeed[i].ToString() + "\n \n \n");


                      

                    }
                  
                }

               

            }
            rtbReport.Text = header + " " + Task1.ToString() + end;

            task.Append("Lowest Minimum  :" + "\t \t \t" + Lowest_Minimum() + "\n" +
                   "Highest Maximum :" + "\t \t \t" + Maximum() + "" + "\n");
            string headerr = "***************************************************************************\n" +
                      "*****************LOWEST AND HIGHEST DATA***************************\n \n";
            rtbHighestAndLowest.Text = headerr + " " + task.ToString() + " " + end;

        }


        public int Lowest_Minimum()
        {


            int Min = Capturing_Data.Min[0];

            for (int i = 0; i < Capturing_Data.City.Length - 1; i++)
            {
                for (int k = 0; k < lsbCities.SelectedItems.Count; k++)
                {
                    if (lsbCities.SelectedItems[k] == Capturing_Data.City[i])
                        if (Min > Capturing_Data.Min[i])
                    {
                        Min = Capturing_Data.Min[i];
                    }

                }

            }
            return Min;
        }
        //this returns the minimum value


        //this method is responsible for getting a Maximum value entere by the user and returns that value 
        public int Maximum()
        {
            //this stores all maximum values being entered by user, starting from index 0
            int Max = Capturing_Data.Max[0];

            for (int i = 0; i < Capturing_Data.City.Length - 1; i++)
            {
                for (int k = 0; k < lsbCities.SelectedItems.Count; k++)
                {
                    if (lsbCities.SelectedItems[k] == Capturing_Data.City[i])

                        if (Max < Capturing_Data.Max[i])
                    {

                        Max = Capturing_Data.Max[i];
                    }
                }


            }
            //this returns the maximum value within the array
            return Max;
        }
        
    }
}