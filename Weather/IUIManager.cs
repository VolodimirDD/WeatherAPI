using System.Windows.Forms;

namespace Weather
{
    public interface IUIManager
    {
        void SetupUI(Form form);
        void ApplyTheme(Form form, ITheme theme);
    }
}
