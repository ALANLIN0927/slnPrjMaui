namespace PrjMaui;

public partial class MATH : ContentPage
{
	public MATH()
	{
		InitializeComponent();
		
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		double a =Convert.ToDouble(txtXEntry.Text);
		double b = Convert.ToDouble(txtYEntry.Text);
		double c = Convert.ToDouble(txtZEntry.Text);
		double z =b*b-4*a*c;
		double y = System.Math.Sqrt(z);
		double x = (-b + y) / (2 * a);
		double z2 = (b + y) / (2 * a);
		ans.Text = "X=" + x + "©Î" + z2;
				
	}
}