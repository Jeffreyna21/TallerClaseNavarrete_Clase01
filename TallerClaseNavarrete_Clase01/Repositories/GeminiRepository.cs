using TallerClaseNavarrete_Clase01.Interfaces;
using TallerClaseNavarrete_Clase01.Models;

namespace TallerClaseNavarrete_Clase01.Repositories
{
    public class GeminiRepository : IChatBotService
    {
        HttpClient _httpClient;
        private string apiKey = "AIzaSyB4UmwD-a0OyYu_wbMfCE3E7oRGKhZRz9s";
            public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetChatbotResponse(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=GEMINI_API_KEY" + apiKey;
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, url);

            GeminiRequest request = new GeminiRequest
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        parts = new List<Part>
                        {
                            new Part
                            {
                                text=prompt
                            }
                        }
                    }
                }
            };

            message.Content = JsonContent.Create<GeminiRequest>(request);
            var response = await _httpClient.SendAsync(message);
            string answer = response.Content.ToString();

            return answer;
        }
    }
}
