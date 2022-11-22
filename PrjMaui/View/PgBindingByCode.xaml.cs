namespace PrjMaui.View;

public partial class PgBindingByCode : ContentPage
{
	public PgBindingByCode()
	{
		InitializeComponent();
		lblHi.BindingContext = slider;
		lblHi.SetBinding(Label.FontSizeProperty, "Value");
	}
}