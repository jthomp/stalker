using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace STalker {
    public partial class frmSettings : Form {

        SpeechSynthesizer synth = new SpeechSynthesizer();
        List<InstalledVoice> voices = new List<InstalledVoice>();

        public frmSettings() {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e) {
            loadSettings();
        }

        private void setupForm() {
            this.Text = "Settings";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.nudVoiceRate.Minimum = -100;
            this.nudVoiceRate.Maximum = 100;
            this.nudVolume.Minimum = 1;
            this.nudVolume.Maximum = 100;
        }

        private void setupVoices() {

            foreach (InstalledVoice v in synth.GetInstalledVoices()) {
                voices.Add(v);
            }

            this.cmbVoices.DisplayMember = "Text";
            this.cmbVoices.ValueMember = "Value";

            // populate the items.
            foreach (InstalledVoice v in voices) {
                Console.WriteLine($"Adding voice: {v.VoiceInfo.Name}...");
                object newItem = new { Text = v.VoiceInfo.Name, Value = v };
                if (!this.cmbVoices.Items.Contains(newItem)) {
                    this.cmbVoices.Items.Add(newItem);
                }
            }

            // set the rate.
            this.nudVoiceRate.Value = Properties.Settings.Default.rate;

            // set the volume.
            this.nudVolume.Value = Properties.Settings.Default.volume;

            // set the voice.
            this.cmbVoices.SelectedText = Properties.Settings.Default.voice;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // save settings...
            saveSettings();
   
            // show the main form and reload settings.
            var form = (frmSTalker)this.Owner;
            if (form != null) {
                form.loadSettings();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void loadSettings() {
            setupForm();
            setupVoices();

            // set the intro checkbox.
            this.cbIntro.Checked = Properties.Settings.Default.playIntro;
        }

        private void saveSettings() {
            Properties.Settings.Default.voice = cmbVoices.Text;
            Properties.Settings.Default.rate = Convert.ToInt32(Math.Round(this.nudVoiceRate.Value, 0));
            Properties.Settings.Default.volume = Convert.ToInt32(Math.Round(this.nudVolume.Value, 0));
            Properties.Settings.Default.playIntro = this.cbIntro.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
