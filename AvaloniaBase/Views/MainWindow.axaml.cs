using Avalonia.Controls;
using AvaloniaBase.ViewModels;

namespace AvaloniaBase.Views
{
    public partial class MainWindow : Window
    {
		#region Declaration
		#endregion

		#region Property
		MainWindowViewModel ViewModel { get; set; }
		#endregion

		#region MemberFunction
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = ViewModel;
		}

		public void InitialViewModel() 
		{
			ViewModel = new MainWindowViewModel();
		}
		#endregion

	}
}