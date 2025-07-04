using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphDemo();
        }

        static void GraphDemo()
        {
            // Создаем граф
            var graph = new Dictionary<string, List<string>>()
            {
                {"A", new List<string>{ "B", "C" } },
                {"B", new List<string>{ "D", "E", "F" } },
                {"C", new List<string> { "G", "H" } },
                {"D", new List<string> { "I" } },
                {"E", new List<string> { "J" } },
                {"F", new List<string> { "K" } },
                {"G", new List<string> { "L" } },
                {"H", new List<string> () },
                {"I", new List<string> () },
                {"J", new List<string> () },
                {"K", new List<string> () },
                {"L", new List<string> () }
            };

            // Выводим граф
            foreach (var item in graph)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
            }
            Console.WriteLine();

            List<string> list = BFS(graph,"A","L");
            Console.Write("Обход в ширину: ");
            Console.Write(string.Join(" ",list)); // A C G L

            Console.WriteLine("\nОбход в длину: ");
            DFS(graph, "A", new HashSet<string>(), new List<string>());

            Console.WriteLine();
            DFSPatch(graph, "A", new HashSet<string>(), new List<string>(), "K");
            Console.ReadKey();

        }

        // Обход в ширину
        public static List<string> BFS(Dictionary<string, List<string>> gra, string start, string goal)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<List<string>>();

            queue.Enqueue(new List<string> { start });
            while (queue.Count > 0)
            {
                var patch = queue.Dequeue();
                var node = patch.Last();

                if (node == goal) return patch;

                if (!visited.Contains(node))
                {
                    visited.Add(node);

                    foreach (var item in gra[node])
                    {
                        var newPatch = new List<string>(patch) { item };
                        queue.Enqueue(newPatch);
                    }
                }
            }

            return null;
        }

        // Обход в длину
        public static void DFS(Dictionary<string,List<string>> graph, string node, HashSet<string> visited, List<string> path)
        {
            if (visited.Contains(node)) return;
            Console.WriteLine(node);
            visited.Add(node);
            path.Add(node);

            Console.WriteLine(string.Join("->", path));

            if (graph.ContainsKey(node))
            {
                foreach (var item in graph[node])
                {
                    DFS(graph, item, visited, path);
                }
            }

            path.RemoveAt(path.Count-1);
            
        }

        public static void DFSPatch(Dictionary<string, List<string>> graph, string node, HashSet<string> visited, List<string> path, string goal)
        {
            if (visited.Contains(node)) return;
            Console.WriteLine(node);
            visited.Add(node);
            path.Add(node);

            if (node == goal)
            {
                Console.WriteLine(string.Join("->", path));
            }

            if (graph.ContainsKey(node))
            {
                foreach (var item in graph[node])
                {
                    DFSPatch(graph, item, visited, path, goal);
                }
            }

            path.RemoveAt(path.Count - 1);

        }
    }
}
