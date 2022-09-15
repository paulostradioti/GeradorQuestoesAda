using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorQuestoes.MultipleChoice
{
    public partial class MultipleChoiceAlternative : UserControl
    {
        public MultipleChoiceAlternative(int index) : this()
        {
            this.Tag = index;
            this.grpTitle.Text += index;
        }

        public MultipleChoiceAlternative()
        {
            InitializeComponent();
        }
    }
}
