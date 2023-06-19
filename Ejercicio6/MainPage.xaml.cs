namespace Ejercicio6;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(bases.Text) && !string.IsNullOrEmpty(bases2.Text))
		{
			var alturax = Convert.ToInt32(altura.Text);
			var basex = Convert.ToInt32(bases.Text);
            var basesx = Convert.ToInt32(bases2.Text);
            var resp1 = alturax + basex + alturax + basesx;
			var resp2 = alturax * basex;
			Perimetro.Text = Convert.ToString(resp1);
			Superficie.Text = Convert.ToString(resp2);

		}
		else
		{
			DisplayAlert("Error","Escibre animal","Adoptado");
		}
    }
}

