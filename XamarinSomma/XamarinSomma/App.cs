using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinSomma
{
    public class App : Application
    {

Entry primoNumero;
Entry secondoNumero;
Button somma;
Label totale;

public App()
{

    primoNumero = new Entry {Placeholder = "Primo numero", Keyboard = Keyboard.Numeric};
    secondoNumero = new Entry { Placeholder = "Secondo numero", Keyboard = Keyboard.Numeric };
    somma = new Button {Text = "Somma"};
    totale = new Label {Text = "Totale"};

    somma.Clicked += Somma_Clicked;
    
    // The root page of your application
    var content = new ContentPage
    {
        Title = "Somma",

        Content = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            Children = {
                primoNumero,
                secondoNumero,
                somma,
                totale
            }
        }
    };

    MainPage = new NavigationPage(content);
}

private void Somma_Clicked(object sender, EventArgs eventArgs)
{
    int iPrimoNumero;
    int iSecondoNumero;

    if (!int.TryParse(primoNumero.Text, out iPrimoNumero))
    {
        totale.Text = "(n/a)";
        return;
    }

    if (!int.TryParse(secondoNumero.Text, out iSecondoNumero))
    {
        totale.Text = "(n/a)";
        return;
    }

    totale.Text = string.Format("{0}", iPrimoNumero + iSecondoNumero);
}


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
