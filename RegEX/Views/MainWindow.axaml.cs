using Avalonia.Controls;
using Avalonia.Interactivity;
using RegEX.ViewModels;

namespace RegEX.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.FindControl<Button>("OpenFile").Click += async delegate
            {
                var taskPath = new OpenFileDialog()
                .ShowAsync(this);

                string[]? path = await taskPath;
                var context = this.DataContext as MainWindowViewModel;
                if(path is not null)
                {
                    context.ReadFileToInput(string.Join("/", path));
                }
                
            };

            this.FindControl<Button>("SaveFile").Click += async delegate
            {
                var taskPath = new SaveFileDialog()
                .ShowAsync(this);

                string path = await taskPath;
                var context = this.DataContext as MainWindowViewModel;
                if(path is not null)
                {
                    context.SaveOutputInFile(path);
                }

            };

        }
        public void ShowRegexSetWindow(object sender, RoutedEventArgs e)
        {
            new RegexSetWindow().ShowDialog(this);
        }

    }
}
