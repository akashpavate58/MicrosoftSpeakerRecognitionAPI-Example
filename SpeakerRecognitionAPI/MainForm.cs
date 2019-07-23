using SpeakerRecognitionAPI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            list_profiles.Clear();
            list_profiles.Items.AddRange(
                    profiles.Select(p => new ListViewItem(p.VerificationProfileId)).ToArray());
        }
    }
}
