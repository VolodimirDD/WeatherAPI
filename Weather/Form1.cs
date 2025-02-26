using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using Weather.Models;

namespace Weather
{
    public partial class Form1 : Form
    {
        private ThemeContext _themeContext;
        private IWeatherService _weatherService;
        private IUIManager _uiManager;
        private ISettingsService _settingsService;

        public Form1()
        {
            InitializeComponent();                     
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.FormClosing += Form1_FormClosing;
            _themeContext = new ThemeContext(new LightTheme());
            _weatherService = new WeatherService();
            _uiManager = new UIManager();
            _settingsService = new SettingsService();           
        }

        private void SetupUI()
        {
            _uiManager.SetupUI(this); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lastCity = _settingsService.GetLastCity(); 
            if (!string.IsNullOrEmpty(lastCity))
            {
                city.Text = lastCity;
            }
            radioButtonLight.Checked = true;
            SetupUI();
        }

        private string lastSavedCity = string.Empty;

        private async void prognoz_Click_1(object sender, EventArgs e)
        {
            string cityName = city.Text;

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Enter the name of the city");
                return;
            }

            if (cityName.Equals(lastSavedCity, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You have already received data for the specified city.");
                return;
            }

            _settingsService.SaveLastCity(cityName);
            lastSavedCity = cityName; 

            WeatherInfo weather = await _weatherService.GetWeatherAsync(cityName);

            if (weather != null)
            {
                temp.Text = $"Temp: {weather.Temp}°C";
                min.Text = $"Min: {weather.TempMin}°C";
                max.Text = $"Max: {weather.TempMax}°C";
                humidity.Text = $"Humid.: {weather.Humidity}%";
                cloudiness.Text = $"Clouds: {weather.Cloudiness}%";
                осади.Text = $"Rain: {(weather.IsRaining ? "Yes" : "No")}";
                descriptionLabel.Text = $"Description: {weather.Description}";
            }
            else
            {
                MessageBox.Show("Weather information could not be retrieved.");
            }
        }

        private bool isClosing = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing)
            {
                isClosing = true; 
                var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
                else
                {
                    e.Cancel = false;  
                }
            }
            else
            {
                isClosing = false;  
            }
        }

        private void SwitchTheme(ITheme theme)
        {
            _themeContext.SetTheme(theme, this);
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLight.Checked)
            {
                SwitchTheme(new LightTheme());
            }
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDark.Checked)
            {
                SwitchTheme(new DarkTheme());
            }
        }
    }
}
