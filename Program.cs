using Agents;
using Tools;

enum MessageRole {
    User,
    Assistant
}
class Message {
    public MessageRole Role { get; init; }
    public required string Content { get; init; }
}

class Program {
    public static void Main() {
        var message = new Message { Role = MessageRole.User, Content = "Code moi mon projet stp" };

        List<Agent> agents =  [
            new OpenAIAgent("Tu es un agent qui sait super bien coder"),
            new DeepseekAgent("Tu es un agent qui sait un peu coder")
        ];

        agents[0].AddTool(new WebSearch());
        agents[0].AddTool(new PdfToText());
        agents[0].ExecuteAllTools();
        foreach (var agent in agents) {
            agent.Connect();
        }
    }
}
