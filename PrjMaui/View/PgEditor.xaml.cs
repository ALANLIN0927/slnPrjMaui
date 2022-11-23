using PrjMaui.Model;
using PrjMaui.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace PrjMaui.View;

public partial class PgEditor : ContentPage
{
	CPatientViewModel _model;

    //List<CPatient> list;
    //int _position = 0;
    public PgEditor()
	{
		InitializeComponent();
		_model=this.BindingContext as CPatientViewModel;
		
	}

	private void first_Clicked(object sender, EventArgs e)
	{
		_model.moveFirst();
	

	}

	private void selectMethod()
	{
		//txtFidEntry.Text =_model.current.fId.ToString();
		//txtNameEntry.Text = _model.current.fName;
		//txtPhoneEntry.Text = _model.current.fPhone;
		//txtEmailEntry.Text = _model.current.fEmail;
		//txtAddressEntry.Text = _model.current.fAddress;
	}

	private void loadData()
	{
		//list = new List<CPatient>();
		//list.Add(new CPatient() { fAddress = "Taipei", fEmail = "marco@gmail.com", fId = 1, fName = "Marco", fPhone = "0936541111" });
		//list.Add(new CPatient() { fAddress = "¥x¤¤", fEmail = "a2233@gmail.com", fId = 2, fName = "Alan", fPhone = "0936541111" });
		//list.Add(new CPatient() { fAddress = "°ª¶¯", fEmail = "a1122@gmail.com", fId = 3, fName = "Marry", fPhone = "0936541111" });

	}

	private void next_Clicked(object sender, EventArgs e)
	{ /*int a = list.Count-1;*/
		//_position++;
		//if (!(_position > a))
		//{
		//          selectMethod();
		//      }
		//else
		//{
		//	_position = 0;
		//          selectMethod();
		//      }
		_model.moveNext();
		//selectMethod();



    }

    private void back_Clicked(object sender, EventArgs e)
	{
		//_position--;
		//if (_position < 0)
		//{
		//	_position=2;
		//}
		_model.movePrevious();
        //selectMethod();


    }

	private void last_Clicked(object sender, EventArgs e)
	{  /* _position = list.Count-1;*/

		_model.moveLast();
        //selectMethod();




    }
	protected override void OnAppearing()
	{
		base.OnAppearing();
		App a = Application.Current as App;
		if (a.selectedindex >= 0)
		{
			_model.moveTo (a.selectedindex);
			selectMethod();
		}
		else if (!string.IsNullOrEmpty(a.keyword))
		{
			if (_model.findByKeyword(a.keyword) != null)
				selectMethod();


		}

	}

	private void btnList_Clicked(object sender, EventArgs e)
	{
		App a = Application.Current as App;
		a.patients =_model.all;
		clearCache();

		Navigation.PushAsync(new PgList());
	}

	private void Select_Clicked(object sender, EventArgs e)
	{
		clearCache();
		Navigation.PushAsync(new PgKeyword());
	}
	private static void clearCache()
	{
		App a =Application.Current as App;
		a.keyword = "";
		a.selectedindex = -1;

	}

}