using System.Text.Json.Serialization;

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

        [JsonPropertyName("SKU")]
        public string Sku { get; set; }

        [JsonPropertyName("interpreter")]
        public int Interpreter { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("tagsOrConcepts")]
        public string[] TagsOrConcepts { get; set; }

        [JsonPropertyName("text")]
        public string[] Text { get; set; }

        [JsonPropertyName("alternatives")]
        public MultipleChoiceAlternativeModel[] Alternatives { get; set; }
    }

    public class MultipleChoiceAlternativeModel
    {
        public MultipleChoiceAlternativeModel()
        {
            Text = Feedback = string.Empty;
            Correct = false;
        }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("feedback")]
        public string Feedback { get; set; }

        [JsonPropertyName("correct")]
        public bool Correct { get; set; }
    }
}
