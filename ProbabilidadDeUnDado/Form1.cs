using System;
using System.Windows.Forms;

namespace ProbabilidadDeUnDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LanzarButton_Click(object sender, EventArgs e)
        {
            LanzarDado();
        }

        public void LanzarDado()
        {
            int uno, dos, tres, cuatro, cinco, seis, numero;

            uno = Convert.ToInt32(NumericUpDown1.Value);
            dos = uno + Convert.ToInt32(NumericUpDown2.Value);
            tres = dos + Convert.ToInt32(NumericUpDown3.Value);
            cuatro = tres + Convert.ToInt32(NumericUpDown4.Value);
            cinco = cuatro + Convert.ToInt32(NumericUpDown5.Value);
            seis = cinco + Convert.ToInt32(NumericUpDown6.Value);

            Random random = new Random();
            numero = random.Next(0, 100);
            ResultadoLabel.Text = Convert.ToString(numero);

            if (numero <= uno)
                ResultadoLabel.Text = "1";
            else if (numero > uno && numero <= dos)
                ResultadoLabel.Text = "2";
            else if (numero > dos && numero <= tres)
                ResultadoLabel.Text = "3";
            else if (numero > tres && numero <= cuatro)
                ResultadoLabel.Text = "4";
            else if (numero > cuatro && numero <= cinco)
                ResultadoLabel.Text = "5";
            else
                ResultadoLabel.Text = "6";
        }
    }
}
