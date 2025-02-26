namespace Weather
{
    public interface ISettingsService
    {
        string GetLastCity();
        void SaveLastCity(string city);
    }

    public class SettingsService : ISettingsService
    {
        public string GetLastCity()
        {
            return Weather.Properties.Settings.Default.LastCity;
        }

        public void SaveLastCity(string city)
        {
            Weather.Properties.Settings.Default.LastCity = city;
            Weather.Properties.Settings.Default.Save();
        }
    }
}
