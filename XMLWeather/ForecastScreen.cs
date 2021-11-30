using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        Image sun;
        Image rain;
        Image thunder;
        Image snow;
        Image cloud;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            sun = Properties.Resources.sun;
            snow = Properties.Resources.snow;
            rain = Properties.Resources.rain;
            thunder = Properties.Resources.thunder;
            cloud = Properties.Resources.cloud;

            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("#0°C");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("#0°C");

            if (Convert.ToInt32(Form1.days[1].condition) >= 200 && Convert.ToInt32(Form1.days[1].condition) < 300)
            {
                pictureBox1.Image = thunder;
                conditionOutput1.Text = "Thuderstorm";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 300 && Convert.ToInt32(Form1.days[1].condition) < 600)
            {
                pictureBox1.Image = rain;
                conditionOutput1.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 600 && Convert.ToInt32(Form1.days[1].condition) < 700)
            {
                pictureBox1.Image = snow;
                conditionOutput1.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 700 && Convert.ToInt32(Form1.days[1].condition) < 800)
            {
                pictureBox1.Image = cloud;
                conditionOutput1.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 801 && Convert.ToInt32(Form1.days[1].condition) < 900)
            {
                pictureBox1.Image = cloud;
                conditionOutput1.Text = "Cloudy";
            }
            else
            {
                pictureBox1.Image = sun;
                conditionOutput1.Text = "Sunny";
            }

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("#0°C");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("#0°C");

            if (Convert.ToInt32(Form1.days[2].condition) >= 200 && Convert.ToInt32(Form1.days[2].condition) < 300)
            {
                pictureBox2.Image = thunder;
                conditionOutput2.Text = "Thunder";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 300 && Convert.ToInt32(Form1.days[2].condition) < 600)
            {
                pictureBox2.Image = rain;
                conditionOutput2.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 600 && Convert.ToInt32(Form1.days[2].condition) < 700)
            {
                pictureBox2.Image = snow;
                conditionOutput2.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 700 && Convert.ToInt32(Form1.days[2].condition) < 800)
            {
                pictureBox2.Image = cloud;
                conditionOutput2.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 801 && Convert.ToInt32(Form1.days[2].condition) < 900)
            {
                pictureBox2.Image = cloud;
                conditionOutput2.Text = "Cloudy";
            }
            else
            {
                pictureBox2.Image = sun;
                conditionOutput2.Text = "Sunny";
            }

            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("#0°C");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("#0°C");

            if (Convert.ToInt32(Form1.days[3].condition) >= 200 && Convert.ToInt32(Form1.days[3].condition) < 300)
            {
                pictureBox3.Image = thunder;
                conditionOutput3.Text = "Thunder";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 300 && Convert.ToInt32(Form1.days[3].condition) < 600)
            {
                pictureBox3.Image = rain;
                conditionOutput3.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 600 && Convert.ToInt32(Form1.days[3].condition) < 700)
            {
                pictureBox3.Image = snow;
                conditionOutput3.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 700 && Convert.ToInt32(Form1.days[3].condition) < 800)
            {
                pictureBox3.Image = cloud;
                conditionOutput3.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 801 && Convert.ToInt32(Form1.days[3].condition) < 900)
            {
                pictureBox3.Image = cloud;
                conditionOutput3.Text = "Cloudy";
            }
            else 
            {
                pictureBox3.Image = sun;
                conditionOutput3.Text = "Sunny";
            }

            date4.Text = Form1.days[4].date;
            min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("#0°C");
            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("#0°C");

            if (Convert.ToInt32(Form1.days[4].condition) >= 200 && Convert.ToInt32(Form1.days[4].condition) < 300)
            {
                pictureBox4.Image = thunder;
                conditionOutput4.Text = "Thunder";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 300 && Convert.ToInt32(Form1.days[4].condition) < 600)
            {
                pictureBox4.Image = rain;
                conditionOutput4.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 600 && Convert.ToInt32(Form1.days[4].condition) < 700)
            {
                pictureBox4.Image = snow;
                conditionOutput4.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 700 && Convert.ToInt32(Form1.days[4].condition) < 800)
            {
                pictureBox4.Image = cloud;
                conditionOutput4.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 801 && Convert.ToInt32(Form1.days[4].condition) < 900)
            {
                pictureBox4.Image = cloud;
                conditionOutput4.Text = "Cloudy";
            }
            else 
            {
                pictureBox4.Image = sun;
                conditionOutput4.Text = "Sun";
            }

            date5.Text = Form1.days[5].date;
            min5.Text = Convert.ToDouble(Form1.days[5].tempLow).ToString("#0°C");
            max5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("#0°C");

            if (Convert.ToInt32(Form1.days[5].condition) >= 200 && Convert.ToInt32(Form1.days[5].condition) < 300)
            {
                pictureBox5.Image = thunder;
                conditionOutput5.Text = "Thunder";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 300 && Convert.ToInt32(Form1.days[5].condition) < 600)
            {
                pictureBox5.Image = rain;
                conditionOutput5.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 600 && Convert.ToInt32(Form1.days[5].condition) < 700)
            {
                pictureBox5.Image = snow;
                conditionOutput5.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 700 && Convert.ToInt32(Form1.days[5].condition) < 800)
            {
                pictureBox5.Image = cloud;
                conditionOutput5.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 801 && Convert.ToInt32(Form1.days[5].condition) < 900)
            {
                pictureBox5.Image = cloud;
                conditionOutput5.Text = "Cloudy";
            }
            else 
            {
                pictureBox5.Image = sun;
                conditionOutput5.Text = "Sun";
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.city = citySearchInput.Text;


                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                displayForecast();
            }

            catch
            {
                cityOutput.Text = "Please Enter a Valid City";
            }

        }
    }
}
