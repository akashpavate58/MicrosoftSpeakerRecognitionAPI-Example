using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerRecognitionAPI.Models
{
    public class VerificationProfile
    {
        public string VerificationProfileId { get; set; }
        public string Locale { get; set; }
        public int EnrollmentsCount { get; set; }
        public int RemainingEnrollmentsCount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public string EnrollmentStatus { get; set; }
        public bool IsActive => EnrollmentStatus == "Enrolled";

    }
}
