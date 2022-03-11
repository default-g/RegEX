using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegEX.Views
{
    public partial class RegexSetWindow : Window
    {
        public RegexSetWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
