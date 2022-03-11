using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using RegEX.ViewModels;
using System;
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
            this.FindControl<Button>("OK").Click += delegate
            {
                var context = this.Owner.DataContext as MainWindowViewModel;
                var inputField = this.FindControl<TextBox>("RegexInputField");
                context.Regex = inputField.Text;
                this.CloseWindow();
            };
            this.FindControl<Button>("Close").Click += delegate
            {
                CloseWindow();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CloseWindow()
        {
            this.Close();
        }
      
    }
}
