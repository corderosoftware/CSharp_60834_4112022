using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ShowDate();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmDiagnostico frmDiagnostico = new FrmDiagnostico();
            frmDiagnostico.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowDate();
        }

        private void ShowDate()
        {
            LblFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            //https://www.c-sharpcorner.com/UploadFile/mahesh/working-with-datetime-using-C-Sharp/
        }
    }
}
