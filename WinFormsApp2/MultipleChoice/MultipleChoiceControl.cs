using GeradorQuestoes.MultipleChoice;

namespace GeradorQuestoes.QuestionTypes
{
    public partial class MultipleChoiceControl : UserControl
    {
        public MultipleChoiceControl()
        {
            InitializeComponent();

            pnlAlternatives.SuspendLayout();
            pnlAlternatives.Controls.Clear();
            for (var i = 0; i < 4; i++)
            {
                var alternative =  new MultipleChoiceAlternative(i+1);
                pnlAlternatives.SetRow(alternative, i);
            }
            pnlAlternatives.ResumeLayout(true);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var question = new MultipleChoiceModel();
        }

        private void MultipleChoiceControl_Load(object sender, EventArgs e)
        {
        }
    }
}
