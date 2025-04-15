namespace Agents {
    class DeepseekAgent: Agent {

        public DeepseekAgent(string systemPrompt) : base(systemPrompt, "https://deepseek.com/api") {}

        public override void Connect() {
            Console.WriteLine($"Je me connecte à Deepseek avec {Url}");
        }
    }
}