using System.Windows;
using System.Windows.Controls;

namespace ProdActivity.UI.CustomControls
{
    public class PasswordBoxExtended : Control
    {
        static PasswordBoxExtended()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PasswordBoxExtended), new FrameworkPropertyMetadata(typeof(PasswordBoxExtended)));
        }

        public PasswordBox PasswordBox { get; set; }

    }
}
