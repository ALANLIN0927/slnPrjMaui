using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PrjMaui.View;

public partial class PgLotto : ContentPage
{
	public PgLotto()
	{
		InitializeComponent();
		


        
        //int[] arrnum = new int[6];
        //int[] arrnum = new int[] { num1, num2, num3, num4, num5, num6 };
        //int a = arrnum.Length;
        //while (a > 1)
        //{
        //    a--;
        //    for(int i = 0; i < a; i++)
        //    {
        //        if (arrnum[i] > arrnum[i + 1])  
        //    }
                
        //}
       
        
        

    }

    private void Reset_Clicked(object sender, EventArgs e)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
        Random num = new Random();
        int index = num.Next(0, list.Count);
        int num1 = list[index];
        list.RemoveAt(index);
        index = num.Next(0, list.Count);
        int num2 = list[index];
        list.RemoveAt(index);
        index = num.Next(0, list.Count);
        int num3 = list[index];
        list.RemoveAt(index);
        index = num.Next(0, list.Count);
        int num4 = list[index];
        list.RemoveAt(index);
        index = num.Next(0, list.Count);
        int num5 = list[index];
        list.RemoveAt(index);
        index = num.Next(0, list.Count);
        int num6 = list[index];
        List<int> list2 = new List<int>() { num1, num2, num3, num4, num5, num6 };
        list2.Sort((x, y) => x.CompareTo(y));
        string result = list2[0] + "," + list2[1] + "," + list2[2] + "," + list2[3] + "," + list2[4] + "," + list2[5];
        Lotonum.Text = result;

        txtHello.Text = "HELLO";

    }
}