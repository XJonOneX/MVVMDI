using MVVMDI.ViewModel;

namespace MVVMDI;

public partial class App : Application
{
	public App(MainPage mp, MainPageViewModel vm)
	{
		InitializeComponent();

		MainPage = mp; // new MainPage(); //AppShell();
		MainPage.BindingContext= vm;
	}
}
