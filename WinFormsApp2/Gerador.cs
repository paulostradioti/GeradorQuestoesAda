using GeradorQuestoes.MultipleChoice;
using GeradorQuestoes.QuestionTypes;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Gerador : Form
    {
        private readonly Dictionary<Type, Control> _controls;
        private readonly Dictionary<Type, Func<Control>> _createNewObject;
        public Gerador()
        {
            InitializeComponent();
            _controls = new Dictionary<Type, Control>()
            {
                { typeof(MultipleChoiceControl), new MultipleChoiceControl() },
                { typeof(TrueFalse), new TrueFalse() },
                { typeof(Gaps), new Gaps() }
            };

            _createNewObject = new Dictionary<Type, Func<Control>>()
            {
                { typeof(MultipleChoiceControl), () => new MultipleChoiceControl() },
                { typeof(TrueFalse), () => new TrueFalse() },
                { typeof(Gaps), () => new Gaps() }
            };
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            pnlQuestion.Controls.Clear();
            pnlQuestion.Controls.Add(_controls[typeof(MultipleChoiceControl)]);
        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            pnlQuestion.Controls.Clear();
            pnlQuestion.Controls.Add(_controls[typeof(TrueFalse)]);
        }

        private void btnGaps_Click(object sender, EventArgs e)
        {
            pnlQuestion.Controls.Clear();
            pnlQuestion.Controls.Add(_controls[typeof(Gaps)]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pnlQuestion.Controls.Count == 0) return;

            var controlType = pnlQuestion.Controls[0].GetType();
            pnlQuestion.Controls.Clear();
            _controls[controlType] = _createNewObject[controlType].Invoke();
            pnlQuestion.Controls.Add(_controls[controlType]);
        }
    }
}