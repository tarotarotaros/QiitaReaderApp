using QiitaEditorApp.Services.Interfaces;

namespace QiitaEditorApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
