using System;
using System.Windows.Forms;

namespace SO.SentenceBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fragment_Click(object sender, EventArgs e)
        {
            Button fragment = sender as Button;
            if (fragment != null)
            {
                String fragmentTag = (String)fragment.Tag;
                this.lblSentenceOutput.Text += fragmentTag;
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
    }
}
