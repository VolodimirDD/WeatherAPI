using System.Drawing;
using System.Windows.Forms;

public class LightTheme : ITheme
{
    public void ApplyTheme(Form form)
    {
        form.BackColor = Color.White;
        form.ForeColor = Color.Black;
    }
}
