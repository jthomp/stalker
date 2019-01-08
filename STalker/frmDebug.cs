using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace STalker {
    public partial class frmDebug : Form {

        SpeechSynthesizer _synth = new SpeechSynthesizer();

        public frmDebug(SpeechSynthesizer synth) {
            _synth = synth;
            InitializeComponent();
        }

        private void frmDebug_Load(object sender, EventArgs e) {
            setupForm();
            loadDebugInformation();
        }

        private void setupForm() {
            this.Text = $"{Application.ProductName} - DEBUG";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loadDebugInformation() {
            this.lblProductNameValue.Text = Application.ProductName;
            this.lblProductVersionValue.Text = Application.ProductVersion;
            this.lblCurrentVoiceValue.Text = _synth.Voice.Name;
            this.lblCurrentVoiceGenderValue.Text = _synth.Voice.Gender.ToString();
            this.lblCurrentVoiceRateValue.Text = _synth.Rate.ToString();
            this.lblCurrentVoiceVolumeValue.Text = _synth.Volume.ToString();
            this.lblPlayIntroValue.Text = Properties.Settings.Default.playIntro.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
