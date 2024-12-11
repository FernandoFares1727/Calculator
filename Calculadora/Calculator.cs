namespace Calculadora
{
    public partial class Calculator : Form
    {
        private double lastResult = 0;
        private readonly char leftBracket = '(';
        private readonly char rightBracket = ')';

        public Calculator()
        {
            InitializeComponent();
        }

        private void addOperation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
                resultTextBox.Text += button.Text;
        }

        private void deleteButton_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text)) // Verifica se o texto não está vazio
            {
                resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
            }
        }

        private void resultButton_Click(Object sender, EventArgs e)
        {
            try
            {
                // Captura o texto da TextBox
                string expressao = resultTextBox.Text;

                // Avalia a expressão matemática
                var resultado = ResultOperations.CalcularExpressao(expressao);
                lastResult = resultado;

                // Mostra o resultado na TextBox
                resultTextBox.Text = resultado.ToString().Replace(',', '.');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetTextBox_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            lastResult = 0;
        }

        private void bracketButton_Click(object sender, EventArgs e)
        {
            var leftBracketCount = resultTextBox.Text.Count(x => x == leftBracket);
            var rightBracketCount = resultTextBox.Text.Count(x => x == rightBracket);

            var diff = leftBracketCount - rightBracketCount;

            resultTextBox.Text += diff == 0
                ? leftBracket
                : rightBracket;
        }

        private void lastResultButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += lastResult;
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += Math.PI;
        }
    }
}
