using PrjMaui.Model;
using PrjMaui.View;
namespace PrjMaui;

public partial class App : Application
{
	public string userName { get; set; }
	public int selectedindex { get; set; }
	public List<CPatient> patients { get; set; }
	public string keyword { get; set; }
	public List<CTodoItem>todos { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new PgEditor());
		//MainPage = new mathmachine();
	}
}
