namespace Calculadora
{
    public partial class Calculator : Form
    {
        private readonly char leftBracket = '(';
        private readonly char rightBracket = ')';

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addOperation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
                resultTextBox.Text += button.Text;
        }

        private void deleteButton_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text)) // Verifica se o texto n�o est� vazio
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

                // Avalia a express�o matem�tica
                var resultado = CalcularExpressao(expressao);

                // Mostra o resultado na TextBox
                resultTextBox.Text = resultado.ToString().Replace(',', '.');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularExpressao(string expressao)
        {
            expressao = SubstituirPotencia(expressao);

            // Usa DataTable para calcular a express�o
            System.Data.DataTable tabela = new System.Data.DataTable();
            tabela.Columns.Add("Expressao", typeof(string), expressao);
            System.Data.DataRow linha = tabela.NewRow();
            tabela.Rows.Add(linha);

            // Retorna o valor calculado
            return double.Parse((string)linha["Expressao"]);
        }

        private string SubstituirPotencia(string expressao)
        {
            while (expressao.Contains("^"))
            {
                // Localiza a posi��o do operador `^`
                int index = expressao.IndexOf("^");

                // Identifica o operando � esquerda
                int start = index - 1;
                while (start >= 0 && (char.IsDigit(expressao[start]) || expressao[start] == '.'))
                {
                    start--;
                }
                start++;

                // Identifica o operando � direita
                int end = index + 1;
                while (end < expressao.Length && (char.IsDigit(expressao[end]) || expressao[end] == '.'))
                {
                    end++;
                }

                // Extrai os operandos
                string baseValue = expressao.Substring(start, index - start);
                string exponent = expressao.Substring(index + 1, end - index - 1);

                // Substitui na express�o
                string potencia = Math.Pow(double.Parse(baseValue), double.Parse(exponent)).ToString();
                expressao = expressao.Substring(0, start) + potencia + expressao.Substring(end);
            }

            return expressao;
        }


        private void resetTextBox_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
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
    }
}
