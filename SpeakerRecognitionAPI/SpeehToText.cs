using Microsoft.CognitiveServices.Speech;
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
    public partial class SpeehToText : Form
    {
        public SpeehToText()
        {
            InitializeComponent();
            text_output.Text = "";
        }

        private async void Btn_start_Click(object sender, EventArgs e)
        {
            text_output.AppendText("Say something\n\n");
            var text = await RecognizeSpeechAsync(txt_key.Text, txt_region.Text);
            text_output.AppendText($"Output: {text}\n");
        }

        public static async Task<string> RecognizeSpeechAsync(string key, string region)
        {
            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key // and service region (e.g., "westus").
            var config = SpeechConfig.FromSubscription(key, region);

            // Creates a speech recognizer.
            using (var recognizer = new SpeechRecognizer(config))
            {
                
                // Starts speech recognition, and returns after a single utterance is recognized. The end of a
                // single utterance is determined by listening for silence at the end or until a maximum of 15
                // seconds of audio is processed.  The task returns the recognition text as result. 
                // Note: Since RecognizeOnceAsync() returns only a single utterance, it is suitable only for single
                // shot recognition like command or query. 
                // For long-running multi-utterance recognition, use StartContinuousRecognitionAsync() instead.
                var result = await recognizer.RecognizeOnceAsync();

                // Checks result.
                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    return result.Text;
                    
                }
                else if (result.Reason == ResultReason.NoMatch)
                {
                    return $"NOMATCH: Speech could not be recognized.";
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = CancellationDetails.FromResult(result);
                    return $"CANCELED: Reason={cancellation.Reason}";
                    
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
