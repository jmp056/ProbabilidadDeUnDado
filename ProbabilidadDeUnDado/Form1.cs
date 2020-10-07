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

        private void Limpiar()
        {
            NumericUpDown1.Value = 0;
            NumericUpDown2.Value = 0;
            NumericUpDown3.Value = 0;
            NumericUpDown4.Value = 0;
            NumericUpDown5.Value = 0;
            NumericUpDown6.Value = 0;
            ResultadoLabel.Text = string.Empty;

        }

        private void LanzarButton_Click(object sender, EventArgs e)
        {
            LanzarDado();
        }

        public void LanzarDado()
        {
            ValidarCampos();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

      
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private bool ValidarCampos()
        {
            bool comprobar = true;

            if (NumericUpDown1.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            if (NumericUpDown2.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            if (NumericUpDown3.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            if (NumericUpDown4.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            if (NumericUpDown5.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            if (NumericUpDown6.Value > 100)
            {
                MessageBox.Show("La probabilidad debe ser menor a 100%!!");
                comprobar = false;
            }

            return comprobar;
            
        }
    }
}
