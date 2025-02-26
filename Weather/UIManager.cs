using System.Drawing;
using System.Windows.Forms;
using System;
using Weather;

public class UIManager : IUIManager
{
    public void SetupUI(Form form)
    {
        var city = form.Controls["city"] as TextBox;
        var temp = form.Controls["temp"] as Label;
        var min = form.Controls["min"] as Label;
        var max = form.Controls["max"] as Label;
        var humidity = form.Controls["humidity"] as Label;
        var cloudiness = form.Controls["cloudiness"] as Label;
        var descriptionLabel = form.Controls["descriptionLabel"] as Label;
        var осади = form.Controls["осади"] as Label;
        var prognoz = form.Controls["prognoz"] as Button;
        var radioButtonLight = form.Controls["radioButtonLight"] as RadioButton;
        var radioButtonDark = form.Controls["radioButtonDark"] as RadioButton;

        city.Multiline = true;
        city.TextAlign = HorizontalAlignment.Center;
        city.Font = new Font("Arial", 14, FontStyle.Bold);
        city.Size = new Size(250, 40);
        city.Location = new Point((form.ClientSize.Width - city.Width) / 2, 30);

        Label[] labels = { temp, min, max, humidity, cloudiness, descriptionLabel, осади };
        int offset = city.Bottom + 10;

        foreach (var label in labels)
        {
            label.AutoSize = true;
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point((form.ClientSize.Width - label.Width) / 2, offset);
            offset = label.Bottom + 10;
        }

        prognoz.Size = new Size(200, 50);
        prognoz.Font = new Font("Arial", 12, FontStyle.Bold);
        prognoz.BackColor = Color.LightBlue;
        prognoz.Location = new Point((form.ClientSize.Width - prognoz.Width) / 2, offset + 10);

        int radioButtonWidth = Math.Max(radioButtonLight.Width, radioButtonDark.Width);
        int totalHeight = radioButtonLight.Height + radioButtonDark.Height + 10;
        int xPosition = form.ClientSize.Width - radioButtonWidth - 10;
        int yPosition = (form.ClientSize.Height / 3 - totalHeight / 3);

        radioButtonLight.Location = new Point(xPosition, yPosition);
        radioButtonDark.Location = new Point(xPosition, yPosition + radioButtonLight.Height + 5);

        city.Multiline = false;
        city.ScrollBars = ScrollBars.None;  
        city.WordWrap = false;
    }

    public void ApplyTheme(Form form, ITheme theme)
    {
        theme.ApplyTheme(form);
    }
}
