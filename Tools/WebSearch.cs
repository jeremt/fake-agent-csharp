using Agents;

namespace Tools {

    class WebSearch: ITool {
        public void Setup(string config) {
            Console.WriteLine("Init web search with config " + config);
        }

        public void Execute() {
            Console.WriteLine("Search the web...");
        }
    }

}