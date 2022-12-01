using IMC.Services;
using ConsoleIMC;
namespace IMC_WinForms
{
    public partial class FrmDiagnostico : Form
    {
        IMC.Services.Metodos ServiciosIMC = new IMC.Services.Metodos();
        Validaciones ServicioValidacion = new Validaciones();

        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
                        
            try
            {
                double Peso;
                string ValoresRequeridos;

                ValoresRequeridos = ServicioValidacion.NombreRequerido(TxtPaciente.Text);
                if (ValoresRequeridos != null)
                {
                    MessageBox.Show(ValoresRequeridos);
                    return;
                }

                ValoresRequeridos = ServicioValidacion.PesoRequerido(TxtPeso.Text);
                if (ValoresRequeridos != null)
                {
                    MessageBox.Show(ValoresRequeridos);
                    return;
                }
                else
                {
                    Peso = double.Parse(TxtPeso.Text);
                }
                

                double Altura = double.Parse(TxtAltura.Text);

                double IMC = ServiciosIMC.CalcularIMC(Peso, Altura);

                LblIMC.Text = IMC.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }


            

        }
    }
}
