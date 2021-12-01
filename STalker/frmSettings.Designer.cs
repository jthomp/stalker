namespace STalker {
    partial class frmSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbVoice = new System.Windows.Forms.GroupBox();
            this.nudVolume = new System.Windows.Forms.NumericUpDown();
            this.lblVolume = new System.Windows.Forms.Label();
            this.nudVoiceRate = new System.Windows.Forms.NumericUpDown();
            this.lblVoiceRate = new System.Windows.Forms.Label();
            this.cmbVoices = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.gbDefaults = new System.Windows.Forms.GroupBox();
            this.cbIntro = new System.Windows.Forms.CheckBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoiceRate)).BeginInit();
            this.gbDefaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVoice
            // 
            this.gbVoice.Controls.Add(this.nudVolume);
            this.gbVoice.Controls.Add(this.lblVolume);
            this.gbVoice.Controls.Add(this.nudVoiceRate);
            this.gbVoice.Controls.Add(this.lblVoiceRate);
            this.gbVoice.Controls.Add(this.cmbVoices);
            this.gbVoice.Controls.Add(this.lblGender);
            this.gbVoice.Location = new System.Drawing.Point(12, 12);
            this.gbVoice.Name = "gbVoice";
            this.gbVoice.Size = new System.Drawing.Size(299, 114);
            this.gbVoice.TabIndex = 0;
            this.gbVoice.TabStop = false;
            this.gbVoice.Text = "Voice";
            // 
            // nudVolume
            // 
            this.nudVolume.Location = new System.Drawing.Point(66, 81);
            this.nudVolume.Name = "nudVolume";
            this.nudVolume.Size = new System.Drawing.Size(215, 20);
            this.nudVolume.TabIndex = 5;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(15, 81);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume:";
            // 
            // nudVoiceRate
            // 
            this.nudVoiceRate.Location = new System.Drawing.Point(66, 53);
            this.nudVoiceRate.Name = "nudVoiceRate";
            this.nudVoiceRate.Size = new System.Drawing.Size(215, 20);
            this.nudVoiceRate.TabIndex = 3;
            // 
            // lblVoiceRate
            // 
            this.lblVoiceRate.AutoSize = true;
            this.lblVoiceRate.Location = new System.Drawing.Point(15, 55);
            this.lblVoiceRate.Name = "lblVoiceRate";
            this.lblVoiceRate.Size = new System.Drawing.Size(33, 13);
            this.lblVoiceRate.TabIndex = 2;
            this.lblVoiceRate.Text = "Rate:";
            // 
            // cmbVoices
            // 
            this.cmbVoices.FormattingEnabled = true;
            this.cmbVoices.Location = new System.Drawing.Point(66, 24);
            this.cmbVoices.Name = "cmbVoices";
            this.cmbVoices.Size = new System.Drawing.Size(215, 21);
            this.cmbVoices.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Voice:";
            // 
            // gbDefaults
            // 
            this.gbDefaults.Controls.Add(this.cbIntro);
            this.gbDefaults.Location = new System.Drawing.Point(13, 132);
            this.gbDefaults.Name = "gbDefaults";
            this.gbDefaults.Size = new System.Drawing.Size(299, 45);
            this.gbDefaults.TabIndex = 1;
            this.gbDefaults.TabStop = false;
            this.gbDefaults.Text = "Defaults";
            // 
            // cbIntro
            // 
            this.cbIntro.AutoSize = true;
            this.cbIntro.Location = new System.Drawing.Point(6, 19);
            this.cbIntro.Name = "cbIntro";
            this.cbIntro.Size = new System.Drawing.Size(119, 17);
            this.cbIntro.TabIndex = 1;
            this.cbIntro.Text = "Play intro on launch";
            this.cbIntro.UseVisualStyleBackColor = true;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.White;
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 191);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(324, 51);
            this.lblFooter.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 242);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.gbDefaults);
            this.Controls.Add(this.gbVoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbVoice.ResumeLayout(false);
            this.gbVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoiceRate)).EndInit();
            this.gbDefaults.ResumeLayout(false);
            this.gbDefaults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVoice;
        private System.Windows.Forms.ComboBox cmbVoices;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.NumericUpDown nudVoiceRate;
        private System.Windows.Forms.Label lblVoiceRate;
        private System.Windows.Forms.GroupBox gbDefaults;
        private System.Windows.Forms.CheckBox cbIntro;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudVolume;
        private System.Windows.Forms.Label lblVolume;
    }
}