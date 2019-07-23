using Newtonsoft.Json;
using SpeakerRecognitionAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerRecognitionAPI.Services
{
    public class SpeakerRecognitionServiceClient
    {
        private string _subscriptionKey { get; set; }
        private string _baseUrl { get; set; }

        public SpeakerRecognitionServiceClient(string subscriptionKey)
        {
            _subscriptionKey = subscriptionKey ?? throw new ArgumentNullException(nameof(subscriptionKey));
            _baseUrl = "https://westus.api.cognitive.microsoft.com/spid/v1.0";
        }

        public SpeakerRecognitionServiceClient(string subscriptionKey, string baseUrl)
        {
            _subscriptionKey = subscriptionKey ?? throw new ArgumentNullException(nameof(subscriptionKey));
            _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
        }

        public async Task<IEnumerable<VerificationProfile>> FetchVerificationProfiles()
        {
            var client = HTTP_CLIENT;
            var response = await client.GetAsync($"{_baseUrl}/verificationProfiles");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<VerificationProfile>>(content);
        }

        public async Task<IEnumerable<VerificationProfile>> DeleteVerificationProfile(string profileId)
        {
            var client = HTTP_CLIENT;
            var response = await client.DeleteAsync($"{_baseUrl}/verificationProfiles/{profileId}");
            response.EnsureSuccessStatusCode();
            return await FetchVerificationProfiles();
        }

        public async Task<IEnumerable<VerificationPhrase>> FetchVerificationPhrases()
        {
            var client = HTTP_CLIENT;
            var response = await client.GetAsync($"{_baseUrl}/verificationPhrases?locale=en-US");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<VerificationPhrase>>(content);
        }

        public async Task<IEnumerable<VerificationProfile>> CreateProfileId()
        {
            var client = HTTP_CLIENT;
            var content = new
            {
                locale = "en-us"
            };
            var response = await client.PostAsync(
                $"{_baseUrl}/verificationProfiles", 
                new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            return await FetchVerificationProfiles();
        }

        public async Task<string> BeginTraining(string profileId, Stream stream)
        {
            var client = HTTP_CLIENT;
            var url = $"{_baseUrl}/verificationProfiles/{profileId}/enroll";

            var response = await client.PostAsync(
                url, 
                new StreamContent(stream));

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<bool> Verify(string profileId, Stream stream)
        {
            var client = HTTP_CLIENT;
            var url = $"{_baseUrl}/verify?verificationProfileId={profileId}";

            var response = await client.PostAsync(
                url,
                new StreamContent(stream));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return (JsonConvert.DeserializeObject<VerificationResponse>(content)).IsValid;
        }


        private HttpClient HTTP_CLIENT
        {
            get
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);
                return client;
            }
        }
    }
}
