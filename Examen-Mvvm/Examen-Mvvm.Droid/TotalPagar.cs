namespace Examen_Mvvm;

public class TotalPagar : ContentPage
{
	public TotalPagar()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"


                 double total = subtotal - descuento;
                 labelTotal.Text = total.ToString("C");

                }
			}
		};
	}
}