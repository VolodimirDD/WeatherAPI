using System.Drawing;
using System.Windows.Forms;

public class DarkTheme : ITheme
{
    public void ApplyTheme(Form form)
    {
        form.BackColor = Color.FromArgb(30, 30, 30);
        form.ForeColor = Color.White;
    }
}