using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string APIKey = "be6798bd536796d0d7544e97351539d4";

        private void Form1_Load(object sender, EventArgs e)
        {
            TbCity.Text = "Input city";
            TbCity.ForeColor = Color.Gray;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getWeather();
            }
            catch
            {
                MessageBox.Show("Such a settlement does not exist! Try again!");
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lab_condition_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void brn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picture_icon.ImageLocation = "https://raw.githubusercontent.com/SlavaKolesnik/weatherApi/main/icons/" + Info.weather[0].icon + ".png";
                pct_cat.ImageLocation = "https://raw.githubusercontent.com/SlavaKolesnik/weatherApi/main/cat-temp/" + Info.weather[0].icon + ".png";
                pct_cat.SizeMode = PictureBoxSizeMode.Zoom;

                lab_condition.Text = Info.weather[0].main;
                lab_detail.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_windspeed.Text = Info.wind.speed.ToString();
                lab_pressure.Text = Info.main.pressure.ToString();
                lab_temp.Text = (Info.main.temp - 273.15).ToString("0.##");




            }

            DateTime convertDateTime(long millis)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                day = day.AddSeconds(millis).ToLocalTime();
                return day;
            }
        }

        private void pic_icon_Click(object sender, EventArgs e)
        {

        }

        private void picture_icon_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void brn_search_MouseLeave(object sender, EventArgs e)
        {
            brn_search.BackColor = Color.Transparent;
        }

        private void brn_search_MouseEnter(object sender, EventArgs e)
        {
            brn_search.BackColor = Color.FromArgb(70, 168, 168);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_db_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `days` (`day`, `city`, `temperature`, `detail`, `wind speed`, `pressure`, `conditions`, `sunrise`, `sunset`) VALUES(@day, @city, @temperature, @detail, @wind_speed, @pressure, @conditions,  @sunrise, @sunset)", db.getConnection());

            DateTime currentDate = DateTime.Now;

            command.Parameters.Add("@day", MySqlDbType.VarChar).Value = currentDate.ToString("yyyy-MM-dd");
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = TbCity.Text;
            command.Parameters.Add("@temperature", MySqlDbType.VarChar).Value = lab_temp.Text;
            command.Parameters.Add("@detail", MySqlDbType.VarChar).Value = lab_detail.Text;
            command.Parameters.Add("@wind_speed", MySqlDbType.VarChar).Value = lab_windspeed.Text;
            command.Parameters.Add("@pressure", MySqlDbType.VarChar).Value = lab_pressure.Text;
            command.Parameters.Add("@conditions", MySqlDbType.VarChar).Value = lab_condition.Text;
            command.Parameters.Add("@sunrise", MySqlDbType.VarChar).Value = lab_sunrise.Text;
            command.Parameters.Add("@sunset", MySqlDbType.VarChar).Value = lab_sunset.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Weather added to the weather list!");
            }
            else
            {
                MessageBox.Show("Error! Something went wrong!");
            }

            db.closeConnection();
        }


        private void TbCity_Enter(object sender, EventArgs e)
        {
            if (TbCity.Text == "Input city")
            {
                TbCity.Text = "";
                TbCity.ForeColor = Color.Black;
            }

        }

        private void TbCity_Leave(object sender, EventArgs e)
        {
            if (TbCity.Text == "")
            {
                TbCity.Text = "Input city";
                TbCity.ForeColor = Color.Gray;
            }

        }

        private void btn_show_data_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherHistory weatherHistory = new WeatherHistory();
            weatherHistory.Show();
        }
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }

}