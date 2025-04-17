using Microsoft.AspNetCore.Mvc;
using TextSonorous.Services;
using TextSonorous.Models;

namespace TextSonorous.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextToSpeechController : ControllerBase
    {
        private readonly TextSonorousService _textSonorousService;

        public TextToSpeechController(TextSonorousService textSonorousService)
        {
            _textSonorousService = textSonorousService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] 
        TextToSpeechRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Text))
                return BadRequest("O texto precisa ser preenchido");

            try
            {
                byte[] audioBytes = await _textSonorousService.ConvertTextToSpeechAsync(request.Text);

                if (audioBytes == null || audioBytes.Length == 0)

                {
                    return StatusCode(500, "Erro ao gerar o áudio.");
                }

                var fileName = $"voz-thaina_{DateTime.Now:yyyyMMdd_HHmmss}.mp3";
                return File(audioBytes, "audio/mpeg", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar a requisição: {ex.Message}");
                return StatusCode(500, "Erro interno do servidor.");
            }
        }
    }
}













