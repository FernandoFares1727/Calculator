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
