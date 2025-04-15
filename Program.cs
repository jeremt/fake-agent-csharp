enum MessageRole {
    User,
    Assistant
}
class Message {
    public MessageRole Role { get; init; }
    public required string Content { get; init; }
}

abstract class Agent {

    public string SystemPrompt { get; }
    public string Url { get; }
    public Agent(string systemPrompt, string url) {
        SystemPrompt = systemPrompt;
        Url = url;
    }

    public abstract void Connect();
}

class OpenAIAgent: Agent {

    public OpenAIAgent(string systemPrompt) : base(systemPrompt, "https://openai.com/api") {
        Console.WriteLine("Create openai..");
    }

    public override void Connect() {
        Console.WriteLine($"Je me connecte à OpenAI avec {Url}");
    }
}

class DeepseekAgent: Agent {

    public DeepseekAgent(string systemPrompt) : base(systemPrompt, "https://deepseek.com/api") {}

    public override void Connect() {
        Console.WriteLine($"Je me connecte à Deepseek avec {Url}");
    }
}

class Program {
    public static void Main() {
        var message = new Message { Role = MessageRole.User, Content = "Code moi mon projet stp" };

        List<Agent> agents =  [
            new OpenAIAgent("Tu es un agent qui sait super bien coder"),
            new DeepseekAgent("Tu es un agent qui sait un peu coder")
        ];
        foreach (var agent in agents) {
            agent.Connect();
        }
    }
}
