using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace STalker {
    public partial class frmSTalker : Form {

        public static SpeechSynthesizer synth = new SpeechSynthesizer();
        List<InstalledVoice> voices = new List<InstalledVoice>();
        string productName = Application.ProductName;

        public frmSTalker() {
            InitializeComponent();
        }

        private void frmSTalker_Load(object sender, EventArgs e) {
            loadSettings();
#if DEBUG
            this.dEBUGCurrentSettingsToolStripMenuItem.Visible = true;
#endif

            if (Properties.Settings.Default.playIntro) {
                speak("Shit talker by Antillian");
            }
        }

        private void setupForm() {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.aboutToolStripMenuItem.Text = $"About {productName}...";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            disposeAndExit();
        }

        private void btnSayIt_Click(object sender, EventArgs e) {
            speak(this.txtSayIt.Text);
        }

        private void btnClearIt_Click(object sender, EventArgs e) {
            this.txtSayIt.Clear();
            this.txtSayIt.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAbout about = new frmAbout();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog(this);
        }

        private void speak(string theWords) {
            Console.WriteLine($"Speaking: {theWords}");
            synth.SpeakAsync(theWords);
        }

        private void frmSTalker_FormClosed(object sender, FormClosedEventArgs e) {
            disposeAndExit();
        }

        private void disposeAndExit() {
            synth.Dispose();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            frmSettings settings = new frmSettings();
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog(this);
            settings.Activate();
        }

        private void buttons_Click(object sender, EventArgs e) {
            var button = (Button)sender;
            speak(button.Text);
        }

        public void loadSettings() {

            // setup form.
            setupForm();

            // get voices
            foreach (InstalledVoice v in synth.GetInstalledVoices()) {
                voices.Add(v);
            }

            synth.Volume = Properties.Settings.Default.volume;
            synth.Rate = Properties.Settings.Default.rate;

            try {
                synth.SelectVoice(Properties.Settings.Default.voice);
            } catch (Exception ex) {
                Console.WriteLine($"Exception selecting voice: {ex.ToString()}");
                synth.SelectVoiceByHints(VoiceGender.Male);
            }

            Properties.Settings.Default.voice = synth.Voice.Name;

            Properties.Settings.Default.Save();
        }

        private void dEBUGCurrentSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            frmDebug debug = new frmDebug(synth);
            debug.Show();
            debug.Activate();
        }
    }
}
