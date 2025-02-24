using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_g2g = 1;
    private double dbl_g2k = 0.001;
    private double dbl_g2m = 1000;
    private double dbl_g2o = 0.03527396195;
    private double dbl_g2p = 0.00220462262185;
    
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = "";
        txtKilograms.Text = "";
        txtMilligrams.Text = "";
        txtOunces.Text = "";
        txtPounds.Text = "";
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = (KeyValue * dbl_g2g).ToString("g9");
        txtKilograms.Text = (KeyValue * dbl_g2k).ToString("g9");
        txtMilligrams.Text = (KeyValue * dbl_g2m).ToString("g9");
        txtOunces.Text = (KeyValue * dbl_g2o).ToString("g9");
        txtPounds.Text = (KeyValue * dbl_g2p).ToString("g9");

    }


    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2g
        double dblNumber;
        var isvalid = Double.TryParse(txtGrams.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2k
        double dblNumber;
        var isvalid = Double.TryParse(txtKilograms.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMilligrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2m
        double dblNumber;
        var isvalid = Double.TryParse(txtMilligrams.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2m;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2o
        double dblNumber;
        var isvalid = Double.TryParse(txtOunces.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2o;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2p
        double dblNumber;
        var isvalid = Double.TryParse(txtPounds.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2p;
        }
        else
        {
            KeyValue = 0;
        }
    }
}