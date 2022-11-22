using PrjMaui.Model;
using System;

namespace PrjMaui.View;

public partial class PgList : ContentPage
{
	public PgList()
	{
		InitializeComponent();
		App a = Application.Current as App;
		lvPatient.ItemsSource = a.patients;
	}

	private void lvPatient_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		//lblTitle.Text = e.SelectedItemIndex.ToString();
		
		App a = Application.Current as App;
		a.selectedindex = e.SelectedItemIndex;
		Navigation.PopAsync();
        //Navigation.PushAsync(new PgEditor());
    }
}