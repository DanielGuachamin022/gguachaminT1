namespace gguachaminT1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    private void btnCalcularAporte_Clicked(object sender, EventArgs e)
    {
		string nombre = txtNombre.Text;
		string apellido = txtApellido.Text;
		int edad = Convert.ToInt32(txtEdad.Text);
		double salario = Convert.ToDouble(txtSalario.Text) * 0.0945;
		DisplayAlert("Alerta", "Bievenid@ " + nombre + " " + apellido + "\nTienes " + edad + " años"+"\nTu aporte mensual es $"+salario.ToString("F2"),"Cerrar");
    }
}

