namespace Examen_Mvvm;

public class Subtotal : ContentPage
{
	public Subtotal()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"


                 double subtotal = producto1 + producto2 + producto3;
                 labelSubtotal.Text = subtotal.ToString("C");

                }
			}
		};
	}
}