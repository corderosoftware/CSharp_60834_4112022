using IMC.Services;
namespace IMC_WinForms
{
    public partial class FrmDiagnostico : Form
    {
        IMC.Services.Metodos ServiciosIMC = new IMC.Services.Metodos();
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Peso = double.Parse(TxtPeso.Text);
            double Altura = double.Parse(TxtAltura.Text);

            double IMC = ServiciosIMC.CalcularIMC(Peso, Altura );

            LblIMC.Text = IMC.ToString();

        }
    }
}
