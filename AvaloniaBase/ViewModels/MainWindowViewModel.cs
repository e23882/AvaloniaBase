using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaBase.Models;

namespace AvaloniaBase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
		#region Declaration
		#endregion

		#region Property
		public string Greeting { get; } = "Welcome to Avalonia!";
		public ObservableCollection<Cat> AllCat { get; } = new ObservableCollection<Cat>();
		#endregion

		#region MemberFunction
		public MainWindowViewModel() 
		{
			AllCat.Add(new Cat()
			{
				Name = "MIMI",
				Age = 6,
				Color = "Black"
			});
		}
		#endregion


	}
}
