using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorQuestoes.MultipleChoice
{
    public class MultipleChoiceModel
    {
        public MultipleChoiceModel()
        {
            Sku = "BE-CS-006";
            Interpreter = 1;
            Type = "MULT";
            Language = "csharp";
            TagsOrConcepts = new[] { "mvc" };
            Text = new[] { string.Empty };
            Alternatives = new MultipleChoiceAlternativeModel[4];
        }

        public string Sku { get; set; }
        public int Interpreter { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string[] TagsOrConcepts { get; set; }
        public string[] Text { get; set; }
        public MultipleChoiceAlternativeModel[] Alternatives { get; set; }
    }

    public class MultipleChoiceAlternativeModel
    {
        public MultipleChoiceAlternativeModel()
        {
            Text = Feedback = string.Empty;
            Correct = false;
        }

        public string Text { get; set; }
        public string Feedback { get; set; }
        public bool Correct { get; set; }
    }
}
