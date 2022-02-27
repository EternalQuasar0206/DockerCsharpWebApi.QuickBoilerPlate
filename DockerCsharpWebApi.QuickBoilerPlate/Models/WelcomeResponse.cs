namespace DockerCsharpWebApi.QuickBoilerPlate.Models
{
    public class WelcomeResponse
    {
        public WelcomeResponse(string message)
        {
            Message = message;
        }
        public string Message { get; }
    }
}
