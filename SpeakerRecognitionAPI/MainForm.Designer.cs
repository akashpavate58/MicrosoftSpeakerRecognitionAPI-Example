namespace SpeakerRecognitionAPI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_apiKey = new System.Windows.Forms.TextBox();
            this.btn_verify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_profiles = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_addProfileId = new System.Windows.Forms.Button();
            this.btn_record_train = new System.Windows.Forms.Button();
            this.btn_stop_train = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Log = new System.Windows.Forms.TextBox();
            this.list_phrases = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_selectedProfileId = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_apiKey
            // 
            this.txt_apiKey.Location = new System.Drawing.Point(81, 32);
            this.txt_apiKey.Name = "txt_apiKey";
            this.txt_apiKey.Size = new System.Drawing.Size(429, 20);
            this.txt_apiKey.TabIndex = 0;
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(516, 30);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(51, 23);
            this.btn_verify.TabIndex = 1;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.Btn_verify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "API Key";
            // 
            // list_profiles
            // 
            this.list_profiles.Enabled = false;
            this.list_profiles.HideSelection = false;
            this.list_profiles.Location = new System.Drawing.Point(33, 109);
            this.list_profiles.Name = "list_profiles";
            this.list_profiles.Size = new System.Drawing.Size(233, 206);
            this.list_profiles.TabIndex = 3;
            this.list_profiles.UseCompatibleStateImageBehavior = false;
            this.list_profiles.View = System.Windows.Forms.View.List;
            this.list_profiles.SelectedIndexChanged += new System.EventHandler(this.List_profiles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profiles";
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.Location = new System.Drawing.Point(573, 30);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(58, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_addProfileId
            // 
            this.btn_addProfileId.Enabled = false;
            this.btn_addProfileId.Location = new System.Drawing.Point(145, 321);
            this.btn_addProfileId.Name = "btn_addProfileId";
            this.btn_addProfileId.Size = new System.Drawing.Size(121, 23);
            this.btn_addProfileId.TabIndex = 6;
            this.btn_addProfileId.Text = "Add";
            this.btn_addProfileId.UseVisualStyleBackColor = true;
            this.btn_addProfileId.Click += new System.EventHandler(this.Btn_addProfileId_Click);
            // 
            // btn_record_train
            // 
            this.btn_record_train.Location = new System.Drawing.Point(26, 63);
            this.btn_record_train.Name = "btn_record_train";
            this.btn_record_train.Size = new System.Drawing.Size(75, 23);
            this.btn_record_train.TabIndex = 7;
            this.btn_record_train.Text = "Record";
            this.btn_record_train.UseVisualStyleBackColor = true;
            // 
            // btn_stop_train
            // 
            this.btn_stop_train.Location = new System.Drawing.Point(137, 63);
            this.btn_stop_train.Name = "btn_stop_train";
            this.btn_stop_train.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_train.TabIndex = 8;
            this.btn_stop_train.Text = "Stop";
            this.btn_stop_train.UseVisualStyleBackColor = true;
            // 
            // btn_train
            // 
            this.btn_train.Location = new System.Drawing.Point(245, 63);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(75, 23);
            this.btn_train.TabIndex = 9;
            this.btn_train.Text = "Train";
            this.btn_train.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(272, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 206);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_selectedProfileId);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.text_Log);
            this.tabPage1.Controls.Add(this.list_phrases);
            this.tabPage1.Controls.Add(this.btn_record_train);
            this.tabPage1.Controls.Add(this.btn_train);
            this.tabPage1.Controls.Add(this.btn_stop_train);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Train";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phrases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log";
            // 
            // text_Log
            // 
            this.text_Log.Location = new System.Drawing.Point(26, 112);
            this.text_Log.Multiline = true;
            this.text_Log.Name = "text_Log";
            this.text_Log.Size = new System.Drawing.Size(294, 56);
            this.text_Log.TabIndex = 11;
            // 
            // list_phrases
            // 
            this.list_phrases.FormattingEnabled = true;
            this.list_phrases.Location = new System.Drawing.Point(26, 36);
            this.list_phrases.Name = "list_phrases";
            this.list_phrases.Size = new System.Drawing.Size(294, 21);
            this.list_phrases.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_selectedProfileId
            // 
            this.lbl_selectedProfileId.AutoSize = true;
            this.lbl_selectedProfileId.Location = new System.Drawing.Point(254, 7);
            this.lbl_selectedProfileId.Name = "lbl_selectedProfileId";
            this.lbl_selectedProfileId.Size = new System.Drawing.Size(35, 13);
            this.lbl_selectedProfileId.TabIndex = 14;
            this.lbl_selectedProfileId.Text = "label5";
            this.lbl_selectedProfileId.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 384);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_addProfileId);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_profiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.txt_apiKey);
            this.Name = "MainForm";
            this.Text = "Speaker Recognition Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_apiKey;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_profiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_addProfileId;
        private System.Windows.Forms.Button btn_record_train;
        private System.Windows.Forms.Button btn_stop_train;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox list_phrases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Log;
        private System.Windows.Forms.Label lbl_selectedProfileId;
    }
}

