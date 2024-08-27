using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Les123
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			UpdateUI();
		}

		public void UpdateUI()
		{
			NameLabel.Content = StringsUI.Name;
			SurnameLabel.Content = StringsUI.Surname;
			HelloButton.Content = StringsUI.Greeting;
			CancelButton.Content = StringsUI.Cancel;
			PhoneLabel.Content = StringsUI.Greeting;
			SwitchLocUpdateButton.Content = StringsUI.SwitchLocUpdate;
			SwitchLocNoUpdateButton.Content = StringsUI.SwitchLocNoUpdate;
		}

		private void SwitchLoc()
		{
			if (Thread.CurrentThread.CurrentUICulture.Name.Contains("en"))
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
			else
				if (Thread.CurrentThread.CurrentUICulture.Name.Contains("ru"))
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
			else
				if (Thread.CurrentThread.CurrentUICulture.Name.Contains("fr"))
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
		}

		private void SwitchLocUpdateButton_Click(object sender, RoutedEventArgs e)
		{
			SwitchLoc();
			UpdateUI();
		}

		private void SwitchLocNoUpdateButton_Click(object sender, RoutedEventArgs e)
		{
			SwitchLoc();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			SwitchLoc();
			UpdateUI();

		}
	}
}