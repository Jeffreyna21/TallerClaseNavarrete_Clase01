namespace TallerClaseNavarrete_Clase01.Interfaces
{
    public interface IChatBotService
    {
        public Task<string> GetChatbotResponse(string prompt);
    }
}
