namespace Ejercicio_1_Invertir;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Numero1.Text) && !string.IsNullOrEmpty(Numero2.Text) && !string.IsNullOrEmpty(Numero3.Text) && !string.IsNullOrEmpty(Numero4.Text))
        {
            double Dato1, Dato2, Dato3, Dato4;
            Dato1 = Convert.ToDouble(Numero1.Text);
            Dato2 = Convert.ToDouble(Numero2.Text);
            Dato3 = Convert.ToDouble(Numero3.Text);
            Dato4 = Convert.ToDouble(Numero4.Text);
            Numero1.Text = Convert.ToString(Dato4);
            Numero2.Text = Convert.ToString(Dato3);
            Numero3.Text = Convert.ToString(Dato2);
            Numero4.Text = Convert.ToString(Dato1);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los números", "Ok");
        }
    }
}