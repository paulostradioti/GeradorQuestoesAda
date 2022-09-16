using GeradorQuestoes.MultipleChoice;
using GeradorQuestoes.QuestionTypes;

namespace WinFormsApp2
{
    public partial class Gerador : Form
    {
        private MultipleChoiceControl _multipleChoice;
        private TrueFalse _trueFalse;
        private Gaps _gaps;
        public Gerador()
        {
            InitializeComponent();
            _multipleChoice =  new MultipleChoiceControl();
            _trueFalse = new TrueFalse();
            _gaps = new Gaps();
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            pnlQuestion.Controls.Clear();
            pnlQuestion.Controls.Add(new MultipleChoiceControl());
        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            
            pnlQuestion.Controls.Clear();
            _trueFalse.BackColor = Color.DarkOrange;
            pnlQuestion.Controls.Add(_trueFalse);
        }

        private void btnGaps_Click(object sender, EventArgs e)
        {
            pnlQuestion.Controls.Clear();
            _gaps.BackColor = Color.DarkGoldenrod;
            pnlQuestion.Controls.Add(_gaps);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pnlQuestion.Controls.Count == 0)
                return;

            var control = pnlQuestion.Controls[0];
            var type = control.GetType();
            
            pnlQuestion.Controls.Clear();
            
            switch (type.Name)
            {
                case "MultipleChoice":
                    _multipleChoice = new MultipleChoiceControl();
                    pnlQuestion.Controls.Add(_multipleChoice);
                    break;
                case "TrueFalse":
                    _trueFalse = new TrueFalse();
                    pnlQuestion.Controls.Add(_trueFalse);
                    break;
                case "Gaps":
                    _gaps = new Gaps();
                    pnlQuestion.Controls.Add(_gaps);
                    break;
            }
        }
    }
}