using PrjMaui.Model;

namespace PrjMaui.View;

public partial class PgTodoList : ContentPage
{
	public PgTodoList()
	{
		InitializeComponent();
		List<CTodoItem> list = (Application.Current as App).todos;
		lvTodo.ItemsSource = list;
	}

	private void lvTodo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		//App a = Application.Current as App;
		//a.selectedindex=
	}
}