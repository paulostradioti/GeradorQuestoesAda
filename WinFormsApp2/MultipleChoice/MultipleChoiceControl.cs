using System.Text.Json;

namespace GeradorQuestoes.MultipleChoice
{
    public partial class MultipleChoiceControl : UserControl
    {
        public MultipleChoiceControl()
        {
            InitializeComponent();
            this.BringToFront();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var modelo = new MultipleChoiceModel
            {
                Text = txtEnunciado.Text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries),
                Alternatives = GenerateAlternatives(),
            };

            var content = JsonSerializer.Serialize(modelo, new JsonSerializerOptions() { WriteIndented = true });

            Clipboard.SetText(content);
            
            MessageBox.Show("Copiado para a área de transferência.", "Copiado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private MultipleChoiceAlternativeModel[] GenerateAlternatives()
        {
            return new MultipleChoiceAlternativeModel[]
            {
                new()
                {
                    Text = txtAlternativa1.Text,
                    Feedback = txtFeedback1.Text,
                    Correct = chkCorrect1.Checked
                },
                new()
                {
                    Text = txtAlternativa2.Text,
                    Feedback = txtFeedback2.Text,
                    Correct = chkCorrect2.Checked
                },
                new()
                {
                    Text = txtAlternativa3.Text,
                    Feedback = txtFeedback3.Text,
                    Correct = chkCorrect3.Checked
                },
                new()
                {
                    Text = txtAlternativa4.Text,
                    Feedback = txtFeedback4.Text,
                    Correct = chkCorrect4.Checked
                }
            };
        }
    }
}
