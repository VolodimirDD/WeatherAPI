using System.Windows.Forms;

public class ThemeContext
{
    private ITheme _theme;

    public ThemeContext(ITheme theme)
    {
        _theme = theme;
    }

    public void SetTheme(ITheme theme, Form form)
    {
        _theme = theme;
        _theme.ApplyTheme(form);
    }
}
