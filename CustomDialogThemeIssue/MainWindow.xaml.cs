using System.Windows;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;

namespace CustomDialogThemeIssue
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ShowClick(object sender, RoutedEventArgs e)
        {
            var dlg = (CustomDialog) Resources["CustomDialogTest"];

            DialogCoordinator.Instance.ShowMetroDialogAsync(this, dlg);
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            var dlg = (CustomDialog)Resources["CustomDialogTest"];

            DialogCoordinator.Instance.HideMetroDialogAsync(this, dlg);
        }

        private void LightThemeChosen(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeAppTheme(Application.Current, "BaseLight");
        }

        private void DarkThemeChosen(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeAppTheme(Application.Current, "BaseDark");
        }
    }
}
