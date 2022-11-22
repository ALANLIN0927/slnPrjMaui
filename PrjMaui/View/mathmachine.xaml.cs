
using Microsoft.Maui.Controls;

namespace PrjMaui.View;

public partial class mathmachine : ContentPage
{
	public mathmachine()
	{
		InitializeComponent();
	}
	List<int>number=new List<int>();
	int resultnumber = 0;
	int n1 = 0;
	string method;
	private void calculate_Clicked(object sender, EventArgs e)
	{
		
		int t =Convert.ToInt32(result.Text);
		Button btn =sender as Button;
		if (t == 0)
		{ result.Text = btn.Text; }
		else
		{ result.Text += btn.Text; };
        resultnumber = int.Parse(result.Text);



    }

	private void plus_Clicked(object sender, EventArgs e)
	{
		n1=Convert.ToInt32(result.Text);
		Button btn = sender as Button;
		result.Text = "0";



        method=plus.Text;

        //number.Add(resultnumber);
        

        //foreach (int i in number)
        //{
        //    result.Text = number.Sum().ToString();
        //}
        //result.Text = "0";
    }

	private void equal_Clicked(object sender, EventArgs e)
	{
		int n2=Convert.ToInt32(result.Text);
		if (method == "+")
		{
			result.Text=(n1+n2).ToString();
		}

	}

	private void reset_Clicked(object sender, EventArgs e)
	{
		result.Text="0";
	}
}