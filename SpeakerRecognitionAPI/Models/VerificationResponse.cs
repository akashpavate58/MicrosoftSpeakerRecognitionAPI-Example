using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerRecognitionAPI.Models
{
    public class VerificationResponse
    {
        public string Result { get; set; }
        public string Confidence { get; set; }
        public string Phrase { get; set; }

        public bool IsValid => Result == "Accept";
    }
}
