using PrjMaui.Model;

namespace PrjMaui.View;

public partial class PgTodo : ContentPage
{
	public PgTodo()
	{
		InitializeComponent();
	}

	private void btnAdd_Clicked(object sender, EventArgs e)
	{
		int sn = 0;
		if (Preferences.Default.ContainsKey("COUNT"))
			sn = Preferences.Default.Get("COUNT", 0);
			sn++;
		Preferences.Default.Set("COUNT", sn);
		Preferences.Default.Set("T"+sn.ToString(),txtTodo.Text);
		Preferences.Default.Set("D" + sn.ToString(), txtDate.Text);
		txtDate.Text = "";
		txtTodo.Text = "";






	}

	private void btnBrowse_Clicked(object sender, EventArgs e)
	{
        int sn = 0;
        if (Preferences.Default.ContainsKey("COUNT"))
            sn = Preferences.Default.Get("COUNT", 0);

        List<CTodoItem> list = new List<CTodoItem>();
        for (int i = 1; i <= sn; i++)
        {
            string keyT = "T" + i.ToString();
            string keyD = "D" + i.ToString();

            if (Preferences.Default.ContainsKey(keyT))
            {
                CTodoItem x = new CTodoItem()
                {
                    date = Preferences.Default.Get(keyD, ""),
                    todo = Preferences.Default.Get(keyT, "")
                };
                list.Add(x);
            }
        }
            (Application.Current as App).todos = list;
        Navigation.PushAsync(new PgTodoList());
    }

    



}
