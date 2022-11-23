namespace PrjMaui.View;

public partial class PgFileDemo : ContentPage
{
	public PgFileDemo()
	{
		InitializeComponent();
	}

	private void btnSave_Clicked(object sender, EventArgs e)
	{
		string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string path = Path.Combine(folder, "text.txt");
		File.WriteAllText(path,txtSet.Text);
		txtSet.Text = "";
	}

	private void btnRead_Clicked(object sender, EventArgs e)
	{
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "text.txt");
		lblGet.Text=File.ReadAllText(path);
    }
}