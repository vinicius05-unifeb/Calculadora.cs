namespace CalcPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CelsiusToFahrenheit()
        {
            CelsiusToFahrenheit celsiusToFahrenheit = new();

            try
            {
                if (!rbCelsius.Checked && !rbCelsius2.Checked &&
                    !rbFahrenheit.Checked && !rbFahrenheit2.Checked &&
                    !rbKelvin.Checked && !rbKelvin2.Checked)
                {
                    MessageBox.Show("Selecione uma unidade de temperatura para converter.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEntrada.Text) || !double.TryParse(txtEntrada.Text, out _))
                {
                    MessageBox.Show("Digite um valor numérico válido.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rbCelsius.Checked && rbFahrenheit2.Checked)
                {
                    double valorEntrada = double.Parse(txtEntrada.Text);
                    double resultado = celsiusToFahrenheit.ConvertToFahrenheit(valorEntrada);

                    txtSaída.Text = $"{resultado.ToString("F2")} °F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: \n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FahrenheitToCelsius()
        {
            FahrenheittoCelsius fahrenheitToCelsius = new();

            try
            {
                if (!rbCelsius.Checked && !rbCelsius2.Checked &&
                    !rbFahrenheit.Checked && !rbFahrenheit2.Checked &&
                    !rbKelvin.Checked && !rbKelvin2.Checked)
                {
                    MessageBox.Show("Selecione uma unidade de temperatura para converter.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEntrada.Text) || !double.TryParse(txtEntrada.Text, out _))
                {
                    MessageBox.Show("Digite um valor numérico válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rbFahrenheit.Checked && rbCelsius2.Checked)
                {
                    double valorEntrada = double.Parse(txtEntrada.Text);
                    double resultado = fahrenheitToCelsius.ConvertToCelsius(valorEntrada);

                    txtSaída.Text = $"{resultado.ToString("F2")} °C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: \n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            CelsiusToFahrenheit();
            FahrenheitToCelsius();
        }
    }
}
