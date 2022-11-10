using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMDI.ViewModel
{
	public partial class MainPageViewModel : ObservableObject
	{
		[ObservableProperty]
		public string helloString = "Hello world!";

		public MainPageViewModel()
		{
			HelloString = "Hello Dependency Injection!";
		}
	}
}
