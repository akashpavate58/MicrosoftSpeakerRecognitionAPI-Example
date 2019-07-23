using SpeakerRecognitionAPI.Models;
using SpeakerRecognitionAPI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakerRecognitionAPI
{
    public partial class MainForm : Form
    {
        private string API_KEY { get; set; }
        private SpeakerRecognitionServiceClient SR_Client{ get; set; }
        private string chosenProfileId = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void Btn_verify_Click(object sender, EventArgs e)
        {
            string apiKey = txt_apiKey.Text.Trim();
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                MessageBox.Show("Please enter an API Key in the textbox");
                return;
            }

            var client = new SpeakerRecognitionServiceClient(apiKey);

            try
            {
                var profiles = await client.FetchVerificationProfiles();
                list_profiles.Items.AddRange(
                    profiles.Select(p => new ListViewItem(p.VerificationProfileId)).ToArray());

                var phrases = await client.FetchVerificationPhrases();
                list_phrases.Items.AddRange(phrases.Select(p => p.Phrase).ToArray());
                list_phrases.SelectedIndex = 0;
                EnableControls();

                SR_Client = client;
            }
            catch (Exception)
            {
                MessageBox.Show("Please try with a valid API Key in the textbox");
                return;
            }

        }

        private void EnableControls()
        {
            btn_verify.Enabled = false;
            list_profiles.Enabled = true;
            txt_apiKey.Enabled = false;
            btn_reset.Enabled = true;
            btn_addProfileId.Enabled = true;
        }

        private void List_profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView item = sender as ListView;
            if(item.SelectedItems != null && item.SelectedItems.Count > 0)
            {
                chosenProfileId = item.SelectedItems[0].Text;
                lbl_selectedProfileId.Text = chosenProfileId;
                text_Log.Text = $"Profile Selected: {chosenProfileId}";
                tabControl1.Enabled = true;
            }
            
            
        }

        private async void Btn_addProfileId_Click(object sender, EventArgs e)
        {
            var profiles = await SR_Client.CreateProfileId();
            lbl_selectedProfileId.Text = "";
            list_profiles.Clear();
            list_profiles.Items.AddRange(
                    profiles.Select(p => new ListViewItem(p.VerificationProfileId)).ToArray());
        }

        private void Btn_record_train_Click(object sender, EventArgs e)
        {
            WavAudioRecorder.StartRecording();
            btn_record_train.Enabled = false;
            btn_stop_train.Enabled = true;
            text_Log.AppendText("\nRecording...");
        }

        private Stream _stream;
        private void Btn_stop_train_Click(object sender, EventArgs e)
        {
            _stream = WavAudioRecorder.StopRecording();
            btn_stop_train.Enabled = false;
            btn_train.Enabled = true;
            text_Log.AppendText("\nRecording Complete. Click Train to begin training the model");
        }

        private async void Btn_train_Click(object sender, EventArgs e)
        {
            try
            {
                string text = await SR_Client.BeginTraining(lbl_selectedProfileId.Text, _stream);
                text_Log.AppendText($"\nSuccess: \n{text}");
                btn_record_train.Enabled = true;
                btn_stop_train.Enabled = false;
                btn_train.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Btn_test_record_Click(object sender, EventArgs e)
        {
            WavAudioRecorder.StartRecording();
            btn_test_record.Enabled = false;
            btn_test_stop.Enabled = true;
        }

        private void Btn_test_stop_Click(object sender, EventArgs e)
        {
            _stream = WavAudioRecorder.StopRecording();
            btn_test_stop.Enabled = false;
            btn_test_record.Enabled = true;
            btn_test_record.Enabled = true;
            btn_recognize.Enabled = true;
        }

        private async void Btn_recognize_Click(object sender, EventArgs e)
        {
            btn_recognize.Enabled = false;
            try
            {
                bool valid = await SR_Client.Verify(lbl_selectedProfileId.Text, _stream);
                if (valid)
                {
                    MessageBox.Show("SUCCESS", "API Responded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("FAILED", "API Responded", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private async void Btn_deleteProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var profiles = await SR_Client.DeleteVerificationProfile(lbl_selectedProfileId.Text);
                lbl_selectedProfileId.Text = "";
                list_profiles.Clear();
                list_profiles.Items.AddRange(
                        profiles.Select(p => new ListViewItem(p.VerificationProfileId)).ToArray());

                tabControl1.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
