using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Cloud.SDK.Core.Http;
using IBM.Watson.TextToSpeech.v1;
using IBM.Watson.TextToSpeech.v1.Model;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO;
using System.Threading.Tasks;


namespace TextSonorous.Services

{

    public class TextSonorousService
    {
        private readonly TextToSpeechService TextToSpeech;

        public TextSonorousService(string apikey, string serviceUrl)
        {
            IamAuthenticator authenticator = new IamAuthenticator(apikey: apikey);
            TextToSpeech = new TextToSpeechService(authenticator);
            TextToSpeech.SetServiceUrl(serviceUrl);
        }
        public async Task<byte[]> ConvertTextToSpeechAsync(string text, string voice = "pt-BR_IsabelaV3Voice")
        {
            var result = TextToSpeech.Synthesize(
                text: text,
                accept: "audio/mp3",
               voice: voice
            );
            
            using var memoryStream = new MemoryStream();
            if (result.Result is Stream responseStream)
            {
                await responseStream.CopyToAsync(memoryStream);
            }

            return memoryStream.ToArray();
        }

       
    }
}






