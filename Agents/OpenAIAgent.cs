namespace Agents {
    class OpenAIAgent: Agent {

        public OpenAIAgent(string systemPrompt) : base(systemPrompt, "https://openai.com/api") {
            Console.WriteLine("Create openai..");
        }

        public override void Connect() {
            Console.WriteLine($"Je me connecte à OpenAI avec {Url}");
        }
    }
}