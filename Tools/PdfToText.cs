using Agents;

namespace Tools {

    class PdfToText: ITool {
        public void Setup(string config) {
            Console.WriteLine("Init pdf to text with config " + config);
        }

        public void Execute() {
            Console.WriteLine("load pdf...");
        }
    }

}