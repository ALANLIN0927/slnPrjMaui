namespace PrjMaui;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{	

		InitializeComponent();
		List<string> list = new List<string>() { "紅", "黃", "藍", "綠" };
		Random random = new Random();
		int index =random.Next(0,4);
		labFirst.Text = list[index];

        list.RemoveAt(index);
        index = random.Next(0, 3);
        labtwo.Text = list[index];
        list.RemoveAt(index);
        index = random.Next(0, 2);
        labthree.Text = list[index];
        list.RemoveAt(index);
        labfour.Text = list[index];

		











    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

