using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SO.SentenceBuilder
{
    public partial class Form1 : Form
    {
        private Func<String, String> sentenceOutputConverter;

        public Form1()
        {
            InitializeComponent();

            this.cmboCase.SelectedIndex = 0;
            this.sentenceOutputConverter = CultureInfo.InvariantCulture.TextInfo.ToTitleCase;
        }

        private void Fragment_Click(object sender, EventArgs e)
        {
            Button fragment = sender as Button;
            if (fragment != null)
            {
                this.lblSentenceOutput.Text += this.sentenceOutputConverter((String)fragment.Tag);
            }
        }

        private void ClearSentence_Click(object sender, EventArgs e)
        {
            this.lblSentenceOutput.Text = String.Empty;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Case_Change(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                switch (comboBox.Items[comboBox.SelectedIndex].ToString())
                {
                    case "UPPERCASE":
                        this.sentenceOutputConverter = CultureInfo.InvariantCulture.TextInfo.ToUpper;
                        break;
                    case "lowercase":
                        this.sentenceOutputConverter = CultureInfo.InvariantCulture.TextInfo.ToLower;
                        break;
                    case "Title Case":
                    default:
                        this.sentenceOutputConverter = CultureInfo.InvariantCulture.TextInfo.ToTitleCase;
                        break;
                }
            }
            this.UpdateButtonTextsToReflectCase();
        }

        private void UpdateButtonTextsToReflectCase()
        {
            IEnumerable<Button> fragmentButtons = this.grpSentenceComponents.Controls.OfType<Button>();
            foreach (var fragmentButton in fragmentButtons)
            {
                // ignore buttons with whitespace as value
                if (String.IsNullOrWhiteSpace((String)fragmentButton.Tag))
                {
                    continue;
                }
                fragmentButton.Text = this.sentenceOutputConverter((String)fragmentButton.Tag);
            }
        }
    }
}
