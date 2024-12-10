namespace Calculadora
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            resultTextBox.Text += button0.Text;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += dotButton.Text;
        }

        private void deleteButton_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text)) // Verifica se o texto não está vazio
            {
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button9.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += addButton.Text;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += subButton.Text;
        }

        private void prodButton_Click(Object sender, EventArgs e)
        {
            resultTextBox.Text += prodButton.Text;
        }

        private void divButton_Click(Object sender, EventArgs e)
        {
            resultTextBox.Text += divButton.Text;
        }

        private void resultButton_Click(Object sender, EventArgs e)
        {
            try
            {
                // Captura o texto da TextBox
                string expressao = resultTextBox.Text;

                // Avalia a expressão matemática
                var resultado = CalcularExpressao(expressao);

                // Mostra o resultado na TextBox
                resultTextBox.Text = resultado.ToString().Replace(',','.');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularExpressao(string expressao)
        {
            // Usa DataTable para calcular a expressão
            System.Data.DataTable tabela = new System.Data.DataTable();
            tabela.Columns.Add("Expressao", typeof(string), expressao);
            System.Data.DataRow linha = tabela.NewRow();
            tabela.Rows.Add(linha);

            // Retorna o valor calculado
            return double.Parse((string)linha["Expressao"]);
        }
    }
}
