namespace calculadorasimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            double valorA, valorB, resultado;
            try
            {
                valorA = Double.Parse(text1.Text);
                valorB = Double.Parse(text2.Text);

                resultado = valorA + valorB;

                textresultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ingrese caracteres validos, solo umeros");
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            double valorA, valorB,  resultado;
            try
            {
                valorA = Double.Parse(text1.Text);
                valorB = Double.Parse(text2.Text);

                resultado = valorA - valorB  ;

                textresultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ingrese caracteres validos, solo umeros");
            }
        }

        }
    }
