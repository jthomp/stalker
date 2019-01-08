using System;
using System.Windows.Forms;

namespace STalker {
    public partial class frmSplash : Form {
        public frmSplash() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.Close();
        }

        private void frmSplash_Load(object sender, EventArgs e) {

        }

        private void frmSplash_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
