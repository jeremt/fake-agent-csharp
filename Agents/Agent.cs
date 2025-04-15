namespace Agents {

    interface ITool {
        void Setup(string config);
        void Execute();
    }

    abstract class Agent: IComparable<Agent> {

        public string SystemPrompt { get; }
        public string Url { get; }

        private List<ITool> tools = [];

        public Agent(string systemPrompt, string url) {
            SystemPrompt = systemPrompt;
            Url = url;
        }

        public int CompareTo(Agent? other) {
            if (other == null) {
                return 0;
            }
            return other.Url == Url ? 1 : 0;
        }

        public void AddTool(ITool tool) {
            tools.Add(tool);
        }

        public void ExecuteAllTools() {
            foreach (var tool in tools) {
                tool.Execute();
            }
        }

        public abstract void Connect();
    }
}