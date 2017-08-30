using System;
using System.Windows.Forms;

namespace Sensei
{
    public partial class SettingsDialog : Form
    {
        /// <summary>
        /// Constructor - populate the form with data from the Speaker class
        /// </summary>
        public SettingsDialog()
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

            // And populate the form with the settings data
            string v = "";
            decimal r = 0, a = 0;
            Settings.Read(out v, out r, out a);
            if (v.Equals(""))
            {
                // The settings file doesn't exist, so
                // Leave voice as-is and set rate/volume to defaults
                Rate.Value = 0;
                Volume.Value = 100;
            }
            else
            {
                // The settings file exists, so use it
                Voice.Text = v;
                Rate.Value = r;
                Volume.Value = a;
            }
        }

        private void SetVoice(object sender, EventArgs e)
        {
            // Change the voice settings
            Speaker.SetVoice(Voice.Text);
            Speaker.Rate = Convert.ToInt32(Rate.Value);
            Speaker.Volume = Convert.ToInt32(Volume.Value);

            // Save the settings to a file
            Settings.Save(Voice.Text, Rate.Value, Volume.Value);

        }
    }
}
