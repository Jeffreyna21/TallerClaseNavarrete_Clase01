using TallerClaseNavarrete_Clase01.Interfaces;

namespace TallerClaseNavarrete_Clase01.Repositories
{
    public class DeepSeekRepository : IChatBotService
    {
        public async Task<string> GetChatbotResponse(string prompt)
        {
            return "Este es un string de Deep Seek";
        }
    }
}
