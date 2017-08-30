using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // All WinForms apps need this
            InitializeComponent();

            // Set up the dropdown menu with the list of voices
            var voices = Speaker.GetVoices();
            if (voices.Length > 0)
            {
                foreach (string voice in voices)
                    Voice.Items.Add(voice);
                Voice.Text = voices[0];
            }
            else
                MessageBox.Show("Unable to find installed voices.");
        }

        private void SetVoice(object sender, EventArgs e)
        {
            Speaker.SetVoice(Voice.Text);
            Speaker.Say(Voice.Text);
        }
    }
}
