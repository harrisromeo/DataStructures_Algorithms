using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace Testing
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string S = "([)()]";
            //string S2 = "{[()()]}";

            //int result = solution(S2);
            //Console.WriteLine(result);  

            //int a = 3605;
            //string answer = Solution.solution(a);
            //Console.WriteLine(answer);

            //IDictionary NodeChildrenPair = new Dictionary<int, List<int>>() 
            //{
            //    { 0, new List<int>(){0,4,0,0,0,0,0,8,0} },
            //    { 1, new List<int>(){4,0,8,0,0,0,0,11,0} },
            //    { 2, new List<int>(){0,8,0,7,0,4,0,0,2} },
            //    { 3, new List<int>(){0,0,7,0,9,14,0,0,0} },
            //    { 4, new List<int>(){0,0,0,9,0,10,0,0,0} },
            //    { 5, new List<int>(){0,0,4,14,10,0,2,0,0} },
            //    { 6, new List<int>(){0,0,0,0,0,2,0,1,6} },
            //    { 7, new List<int>(){8,11,0,0,0,0,1,0,7} },
            //    { 8, new List<int>(){0,0,2,0,0,0,6,7,0} }
            //};    


            //IDictionary<string, double> DepartmentStaffPair = new Dictionary<string, double>()
            //{
            //    {"Applied Maths", 7},
            //    {"R & D", 16},
            //    {"Software Dev", 8},
            //    {"Coporate Services", 12 }
            //};


            //Console.WriteLine(DepartmentStaffPair.Count());
            //Console.WriteLine(DepartmentStaffPair.LongCount());

            //DepartmentStaffPair.TryGetValue("Coporate Services", out double CoporateServicesNumber);
            //Console.WriteLine(CoporateServicesNumber);

            //DepartmentStaffPair.Remove("Coporate Services");
            //foreach (var pair in DepartmentStaffPair)
            //{
            //    Console.Write(pair.Key + " "); Console.WriteLine(pair.Value);
            //}

            //KeyValuePair<string, double> item = new KeyValuePair<string, double>("R & D", 16);
            //if (DepartmentStaffPair.Contains(item))
            //{
            //    Console.WriteLine("Yes. It contains " + item.ToString());

            //}




            Console.ReadLine();



            //////BINARY TREE (In-ORDER DFS Traversal)
            //BinaryTree<int> TestBinaryTree = new BinaryTree<int>(1,
            //                                     new BinaryTree<int>(2,
            //                                         null,
            //                                         new BinaryTree<int>(4,
            //                                             null,
            //                                             null)),
            //                                     new BinaryTree<int>(3,
            //                                         null,
            //                                         new BinaryTree<int>(5,
            //                                             null,
            //                                             null
            //                                         ))
            //                                 );
            //TestBinaryTree.PrintInOrder();
            //Console.ReadLine();


            //Contacts contacts = new Contacts();

            //List<string> the_strings = new List<string>() {"add hack","add hackerrank","find hac","find hak" };

            //foreach (var str in the_strings)
            //{
            //    string[] splitted = str.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            //    if (splitted[0] == "add")
            //        contacts.Add(splitted[1]);
            //    else if (splitted[0] == "find")
            //        Console.WriteLine(contacts.Find(splitted[1]));
            //}
            //Console.ReadLine();


            //List<double> list = new List<double>() {12,4,5,3,8,7 };
            //List<double> runningList = new List<double>();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    double median = RunningMedian(runningList,list[i]);
            //    Console.WriteLine(median);
            //}
            //Console.ReadLine();

            //int x = 5; int y =(int)(x / 2);
            //    Console.WriteLine(y);
            //Console.ReadLine();
            //int n = Convert.ToInt32(Console.ReadLine());

            //List<string> queryList = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    string s = Console.ReadLine();
            //    string result = isBalanced(s);
            //    queryList.Add(result);
            //}

            //foreach (var query in queryList)
            //{
            //    Console.WriteLine(query);
            //}
            //Console.ReadLine();

            //string declared = "Intern pool";
            //string built = new StringBuilder(declared).ToString();
            //string interned = string.Intern(built);

            //Console.WriteLine(object.ReferenceEquals(declared,built));
            //Console.WriteLine(object.ReferenceEquals(declared,interned));
            //Console.ReadLine();

            //////INPUT TO CONSOLE

            //string integers = Console.ReadLine();
            //char[] seperators = { ' ' };
            //string[] integers_splitted = integers.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            //List<int> numIntegers = integers_splitted.Select(i => int.Parse(i)).ToList();
            //BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            //foreach (int integer in numIntegers)
            //{
            //    binarySearchTree.Insert(integer);
            //}

            /////OUTPUT TO CONSOLE
            //binarySearchTree.LevelOrder(binarySearchTree.root); //key point is how you insert. that's the basis for comparison.
            //Console.ReadLine();





            ////INPUT TO CONSOLE

            //string integers = Console.ReadLine();
            //char[] seperators = { ' ' };
            //string[] integers_splitted = integers.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            //List<int> numIntegers = integers_splitted.Select(i => int.Parse(i)).ToList();
            //BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            //foreach (int integer in numIntegers)
            //{
            //    binarySearchTree.Insert(integer);
            //}

            ////OUTPUT TO CONSOLE
            //binarySearchTree.LevelOrder_N2(binarySearchTree.root); //key point is how you insert. that's the basis for comparison.


            //Console.ReadLine();


            //////INPUT TO CONSOLE

            //string n_str = Console.ReadLine();
            //bool n_success = int.TryParse(n_str, out int n);

            //string integers = Console.ReadLine();
            //char[] seperator = { ' ' };
            //string[] integers_splitted = integers.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            //List<int> numIntegers = integers_splitted.Select(i => int.Parse(i)).ToList();
            //BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            //foreach (int integer in numIntegers)
            //{
            //    binarySearchTree.Insert(integer);
            //}

            //int treeHeight = binarySearchTree.getHeight(binarySearchTree.root);


            ////PRINT RESULT TO THE CONSOLE 
            //Console.WriteLine(treeHeight);
            //Console.ReadLine();


            //BinarySearchTree<int> tree = new BinarySearchTree<int>();
            //tree.Insert("Telerik");
            //tree.Insert("Google");
            //tree.Insert("Microsoft");
            ////tree.PrintTreeDFS();
            ////Console.WriteLine(tree.Contains("Telerik"));
            ////Console.WriteLine(tree.Contains("IBM"));
            //tree.Remove("Telerik");
            ////Console.WriteLine(tree.Contains("Telerik"));
            //tree.PrintTreeDFS();
            //Console.ReadLine();



            ////SECTION THAT READS-IN ALL GRAPH QUERY INPUT DATA FROM THE CONSOLE 

            //string queryString = Console.ReadLine();
            //bool queryNumSuccess = int.TryParse(queryString, out int queryNumbers);

            //List<GetShortestNodesPaths> queryList = new List<GetShortestNodesPaths>();

            //for (int i = 0; i < queryNumbers; i++)
            //{
            //    List<int>[] myEdges;
            //    string n_m = Console.ReadLine();
            //    char[] nm_seperator = { ' ' };
            //    string[] nm_Splitted = n_m.Split(nm_seperator, StringSplitOptions.RemoveEmptyEntries);
            //    int n;
            //    bool n_Success = int.TryParse(nm_Splitted[0], out n);
            //    int m;
            //    bool m_Success = int.TryParse(nm_Splitted[1], out m);

            //    myEdges = new List<int>[m];



            //    for (int j = 0; j < m; j++)
            //    {
            //        myEdges[j] = new List<int>();

            //        string u_v = Console.ReadLine();
            //        char[] uv_seperator = { ' ' };
            //        string[] uv_Splitted = u_v.Split(uv_seperator, StringSplitOptions.RemoveEmptyEntries);

            //        int u;
            //        bool u_Success = int.TryParse(uv_Splitted[0], out u);
            //        u = u - 1; //THIS PROGRAM IS BASED ON ZERO-BASED VERTEX (NODES) COUNT
            //        myEdges[j].Add(u);

            //        int v;
            //        bool v_Success = int.TryParse(uv_Splitted[1], out v);
            //        v = v - 1;//THIS PROGRAM IS BASED ON ZERO-BASED VERTEX (NODES) COUNT
            //        myEdges[j].Add(v);


            //        //CLEAR EDGES DATA (TO THEIR DEFAULT VALUES) FOR THE NEXT QUERY.
            //        u_v = null; uv_seperator = null; uv_Splitted = null; u = 0; u_Success = false;
            //        v = 0; v_Success = false;


            //    }


            //    string s_string = Console.ReadLine();
            //    int s;
            //    bool s_success = int.TryParse(s_string, out s);
            //    s = s - 1; //THIS PROGRAM IS BASED ON ZERO-BASED VERTEX (NODES) COUNT

            //    GetShortestNodesPaths myGraph = new GetShortestNodesPaths(myEdges, n, m, s);

            //    queryList.Add(myGraph);
            //    //CLEAR VARIABLES OF THE QUERY LOOP (TO THEIR DEFAULT VALUES) FOR THE NEXT QUERY.
            //    myEdges = null; n_m = null; nm_seperator = null; nm_Splitted = null; n_Success = false;
            //    m_Success = false; s_string = null; s = 0; s_success = false; 
            //}




            ////SECTION THAT PRINTS OUT ALL GRAPH QUERY RESULTS  TO THE CONSOLE 


            //foreach (GetShortestNodesPaths graph in queryList)
            //{
            //    graph.dijkstra();
            //}


            //Console.ReadLine();


            //if (!(numberQueries >= 1 && numberQueries <= 10))
            //{
            //    throw new Exception("The number of queries must be equal or greater than 1 and less than or equal to 10");
            //}

            //if (!(n >= 2 && n <= 1000))
            //{
            //    throw new Exception(" n must be equal or greater than 2 and less than or equal to 1000");
            //}


            //if (!(m >= 1 && m <= (n * n - 1) / 2))
            //{
            //    throw new Exception(" m must be equal or greater than 1 and less than or equal to " + (n * n - 1) / 2);
            //}


            //if (!(u >= 0 && u < n))
            //{
            //    throw new Exception("u must be equal or greater than 1 and less than or equal to " + n);
            //}


            //if (!(v >= 0 && v < n))
            //{
            //    throw new Exception("v must be equal or greater than 1 and less than or equal to n " + n);
            //}




            //if (!(s >= 0 && s < n))
            //{
            //    throw new Exception("s must be equal or greater than 1 and less than or equal to " + n);
            //}




            //int numberQueries2 = int.Parse(Console.ReadLine());









            //int[,] graph = new int[,]  {
            //                                { 0, 6, 0, 0, 6, 0 },
            //                                { 6, 0, 6, 0, 0, 0 },
            //                                { 0, 6, 0, 6, 0, 0},
            //                                { 0, 0, 6, 0, 0, 0},
            //                                { 6, 0, 0, 0, 0, 0},
            //                                { 0, 0, 0, 0, 0, 0 }
            //};

            //GetShortestNodesPaths myGraph = new GetShortestNodesPaths(graph,0);

            //myGraph.dijkstra();
            //Console.ReadLine();



            //int[,] graph = new int[,]     { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            //                                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            //                                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            //                                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            //                                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            //                                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            //                                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            //                                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            //                                { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            //GetShortestNodesPaths t = new GetShortestNodesPaths();

            //t.dijkstra(graph, 0);
            //Console.ReadLine();


            //List<int> testCase = new List<int>(5) {0,0,1,0 };
            //testCase[3] = 2;
            //testCase.Add(3);

            //List<int> nstates = new List<int>() { 1, 6, 3, 5, 6, 1 };

            //WeightedGraph myWeightedGraph = new WeightedGraph(new List<int>[] { new List<int> { 1, 2, 3, 4, 5, 6 }, new List<int> { 0, 7 }, new List<int> { 0, 9 }, new List<int> { 0, 9 },new List<int> { 0,7,8 }, new List<int> {0,9},new List<int> {0,9},new List<int> { 1, 4, 10, 11 },
            //                                                                      new List<int> {4,11,12,13},new List<int> { 2,3,5,6,13,14 }, new List<int> { 7,15,18 },new List<int> { 7,8,16,17 },new List<int> { 8,17 },new List<int> { 8,9,19 },new List<int> { 9,18,20 },
            //                                                                      new List<int> { 10,21 },new List<int> {11,21},new List<int> { 11,12,21 },new List<int> { 10,14,21 }, new List<int> { 13, 21 },new List<int> { 14,21 }, new List<int> { 15,16,17,18,19,20 }

            //}, new List<double>[] { new List<double> { 3, 1, 4, 2, 1, 5 }, new List<double> { 3, 9 }, new List<double> { 1, 2 }, new List<double> { 4, 6 }, new List<double> { 2, 5, 3 }, new List<double> { 1, 5 }, new List<double> { 5, 8 }, new List<double> { 9, 5, 9, 7 }, new List<double> { 3, 8, 3, 2 }, new List<double> { 2, 6, 5, 8, 3, 8 }, new List<double> { 9, 4, 6 },
            //                        new List<double> { 7, 8, 2, 6 }, new List<double> { 3, 4 }, new List<double> { 2, 3, 3 }, new List<double> { 8, 3, 8 },new List<double> { 4, 3 },new List<double> { 2, 2 },new List<double> { 6, 4, 9 },new List<double> { 6, 3, 7 }, new List<double> { 3, 5 }, new List<double> { 8, 2 },new List<double> { 3, 2, 9, 7, 5, 2 }   },
            //nstates);


            //List<int> shortest_States = myWeightedGraph.GetShortestPath();

            //foreach (int state in shortest_States)
            //{
            //    Console.Write(state + " ");
            //}

            //Console.ReadLine();



            //WeightedGraph myWeightedGraph = new WeightedGraph(graphComponents, nstates);
            //List<int> shortest_States = myWeightedGraph.GetShortestPath();

            //foreach (int state in shortest_States)
            //{
            //    Console.Write(state + " ");
            //}
            //Console.ReadLine();




            //double weight = myWeightedGraph.GetEdgeCost(2,2,3);
            //Console.WriteLine(weight);
            //Console.ReadLine();

            //List<int> nstates = new List<int>(){1,6,3,5,6,1};
            //List<int> PreviousStages_Counts = nstates.GetRange(0, 2);
            //int IndexOfLastStateFromAllPreviousStates = PreviousStages_Counts.Sum();
            //Console.WriteLine(IndexOfLastStateFromAllPreviousStates);
            //Console.ReadLine();

            //WeightedGraph myWeightedGraph = new WeightedGraph(graphComponents);

            //double weight = myWeightedGraph.GetEdgeWeight(4,7);
            //Console.WriteLine(weight);
            //Console.ReadLine();



            //int[,] intMatrix = new int[3, 3];

            //intMatrix[1,3] = 1;

            //string str1 = "010"; string str2 = "101";
            //int HammingDistance = GetHammingDistance(str1,str2);
            //Console.WriteLine(HammingDistance);
            //Console.ReadLine();


            //string str = "2173896";
            //string str2 = "2233796";
            //int hammingDistance = 0;

            //if (str.Length == str2.Length)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] != str2[i] )
            //        {
            //            hammingDistance++;
            //        }
            //    }
            //}
            //Console.WriteLine(hammingDistance);
            //Console.ReadLine();

            //byte a = 3; byte b = 5;
            //int ans = a ^ b;
            //Console.WriteLine(ans);
            //Console.ReadLine();

            //string quote = "karolin";//"Hillo";
            //IEnumerable<char> quoteList = quote.ToCharArray().ToList();
            //string quote2 = "kathrin";//"Hellg";
            //IEnumerable<char> quote2List = quote2.ToCharArray().ToList();

            //IEnumerable<char> setDifference = quoteList.Except(quote2List);

            //foreach (char chr in setDifference)
            //{
            //    Console.WriteLine(chr);
            //}
            //Console.ReadLine();

            //string quote = "The main intent of the \"Intro C#\" book is to introduce the C# programming to newbies.";
            //string keyword = "C#";
            //int index = quote.IndexOf(keyword);
            //while (index != -1)
            //{
            //    Console.WriteLine("{0} found at index: {1}", keyword, index);
            //    index = quote.IndexOf(keyword, index + 1);
            //}
            //Console.ReadLine();


            //string str = "C# Programming Course";
            //int index = str.IndexOf("C#"); // index = 0
            //index = str.IndexOf("Course"); // index = 15
            //index = str.IndexOf("COURSE"); // index = -1
            //index = str.IndexOf("ram"); // index = 7
            //index = str.IndexOf("r"); // index = 4
            //index = str.IndexOf("r", 5); // index = 7
            //index = str.IndexOf("r", 10); // index = 18
            //Console.WriteLine(index);
            //Console.ReadLine();


            //string message = "This is a sample string message.";
            //Console.WriteLine("message = {0}", message);
            //Console.WriteLine("message.Length = {0}", message.Length);
            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.WriteLine("message[{0}] = {1}", i, message[i]);
            //}
            //Console.ReadLine();

            //string Text = "Mary had a little lamb little Lamb, little Lamb, Mary had a Little lamb, whose fleece were white as snow.";

            //IDictionary<String, int> wordOccurrenceMap = GetWordOccurrenceMap(Text);
            // PrintWordOccurrenceCount(wordOccurrenceMap);
            // Console.ReadLine();


            ////a. NOTE A DICTIONARY CAN BE IMPLEMENTED TO HAVE OR NOT HAVE A NULL VALUE
            ///b. The two most popular dictionary implementations are dictionaries implemented with a:
            ///   1. BALANCED TREE (red-black tree in .NET) for Sorted Dictionary
            ///   AND
            ///   2. HASH TABLE for Dictionary.
            ///Types of dictionaries in .NET that implements another interface - the IDictionary (without a K,V - pair)
            ///:  HashTable, ListDict. & HybridDict.
            ///NOTE: The only advantage of Sorted dictionary is the ordered nature of the keys.
            ///Searching is slower (log (n)) compared to Hash Table (Dictionary) which requires a fixed number of steps


            //IDictionary<string, double> studentMarks = new Dictionary<string, double>();
            //studentMarks["Paul"] = 3.00;
            //Console.WriteLine("Paul 's mark: {0:0.00}",
            //studentMarks["Paul"]);
            //Console.ReadLine();

            //studentMarks.TryGetValue(studentMarks.Keys.First(), out double value);
            //Console.WriteLine(value);
            //Console.ReadLine();

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Message One");
            //queue.Enqueue("Message Two");
            //queue.Enqueue("Message Three");
            //queue.Enqueue("Message Four");
            //while (queue.Count > 0)
            //{
            //    string msg = queue.Dequeue();
            //    Console.WriteLine(msg);
            //}
            //Console.ReadLine();

            //Stack<string> stack = new Stack<string>();
            //stack.Push("1. John");
            //stack.Push("2. Nicolas");
            //stack.Push("3. Mary");
            //stack.Push("4. George");
            //Console.WriteLine("Top = " + stack.Peek());
            //while (stack.Count > 0)
            //{
            //    string personName = stack.Pop();
            //    Console.WriteLine(personName);
            //}
            //Console.ReadLine();

            //ArrayList list = new ArrayList();
            //list.Add(2);
            //list.Add(3.5f);
            //list.Add(25u);
            //list.Add(" EUR");
            //dynamic sum = 0;

            //for (int i = 0; i < list.Count; i++)
            //{
            //    dynamic value = list[i];
            //    sum = sum + value;
            //}
            //Console.WriteLine("Sum = " + sum);
            //Console.ReadLine();


            //DynamicList<string> shoppingList =
            //    new DynamicList<string>();

            //shoppingList.Add("Milk");
            //shoppingList.Remove("Milk"); // Empty list
            //shoppingList.Add("Honey");
            //shoppingList.Add("Olives");
            //shoppingList.Add("Water");
            //shoppingList[2] = "A lot of " + shoppingList[2];
            //shoppingList.Add("Fruits");
            //shoppingList.RemoveAt(0); // Removes "Honey" (first)
            //shoppingList.RemoveAt(2); // Removes "Fruits" (last)
            //shoppingList.Add(null);
            //shoppingList.Add("Beer");
            //shoppingList.Remove(null);
            //Console.WriteLine("We need to buy:");
            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(" - " + shoppingList[i]);
            //}
            //Console.WriteLine("Position of 'Beer' = {0}",
            //shoppingList.IndexOf("Beer"));
            //Console.WriteLine("Position of 'Water' = {0}",
            //shoppingList.IndexOf("Water"));
            //Console.WriteLine("Do we have to buy Bread? " +
            //shoppingList.Contains("Bread"));

            //Console.ReadLine();

            //CustomArrayList<string> shoppingList =
            //    new CustomArrayList<string>();
            //shoppingList.Add("Milk");
            //shoppingList.Add("Honey");
            //shoppingList.Add("Olives");
            //shoppingList.Add("Water");
            //shoppingList.Add("Beer");
            //shoppingList.Remove("Olives");
            //shoppingList.Insert(1, "Fruits");
            //shoppingList.Insert(0, "Cheese");
            //shoppingList.Insert(6, "Vegetables");
            //shoppingList.RemoveAt(0);
            //shoppingList[3] = "A lot of " + shoppingList[3];
            //Console.WriteLine("We need to buy:");
            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(" - " + shoppingList[i]);
            //}
            //Console.WriteLine("Position of 'Beer' = {0}",
            //shoppingList.IndexOf("Beer"));
            //Console.WriteLine("Position of 'Water' = {0}",
            //shoppingList.IndexOf("Water"));
            //Console.WriteLine("Do we have to buy Bread? " + shoppingList.Contains("Bread"));

            //Console.ReadLine();

            //string[] words = { "cherry", "apple","blueberry"};

            //var wordsSortedByLength =
            //    from word in words
            //    orderby word.Length descending //for sort (ie alphabetical) just use only: orderby word
            //    select word;
            //foreach (var word in wordsSortedByLength)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            //var selectedCultures =
            //from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            //where culture.Name.StartsWith("b")
            //select culture;

            //foreach (var culture in selectedCultures)
            //{
            //    Console.WriteLine(culture);
            //}
            //Console.ReadLine();


            //Func<int,bool> intFunc = (x) => x < 10;
            //int test = 50;
            //if (intFunc(test))
            //{
            //    Console.WriteLine(intFunc(test));
            //}
            //else Console.WriteLine( false);
            //Console.ReadLine();

            //List<int> list = new List<int>() { 20, 1, 4, 8, 9, 44 };

            //var evenNumbers = list.FindAll(i => { return i % 2 == 0; });

            //foreach (var evenNumber in evenNumbers)
            //{
            //    Console.WriteLine(evenNumber);
            //}
            //Console.ReadLine();

            //List<Dog> dogs = new List<Dog>() {
            //                                    new Dog { Name = "Rex", Age = 4 },
            //                                    new Dog { Name = "Sean", Age = 0},
            //                                    new Dog { Name = "Stacy", Age = 3}
            //};
            //var sortedDogs = dogs.OrderByDescending(x => x.Age);
            //foreach (var dog in sortedDogs)
            //{
            //    Console.WriteLine(dog.Name);
            //}
            //Console.ReadLine();

            //List<Dog> dogs = new List<Dog>() {
            //                                    new Dog { Name = "Rex", Age = 4 },
            //                                    new Dog { Name = "Sean", Age = 0},
            //                                    new Dog { Name = "Stacy", Age = 3}
            //};
            //var newDogsList = dogs.Select(x => new {Name = x.Name, AgeAdder = x.Age + 3 });

            //foreach (var item in newDogsList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();


            //List<Dog> dogs = new List<Dog>() {
            //                                    new Dog { Name = "Rex", Age = 4 },
            //                                    new Dog { Name = "Sean", Age = 0},
            //                                    new Dog { Name = "Stacy", Age = 3}
            //};
            //var names = dogs.Select(x => x.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();



            //var arr = new []{ new { X = 3, Y = 5}, new {X = 1, Y = 2 }, new { X = 0, Y = 7} };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadLine();

            //var myCar = new {Color = "Red", Brand = "BMW", Speed = 180 };
            //Console.WriteLine(myCar.Color);
            //Console.WriteLine(myCar.Speed);
            //Console.ReadLine();

            //List<int> numbers = new List<int>{1,2,3,4,5 };
            //Console.WriteLine(numbers.ToString<int>());
            //Console.ReadLine();

            //Point<double> a = new Point<double>(0, 4, 0);
            //Point<double> b = new Point<double>(3,0, 0);

            //double distance = Point<int>.Dist(ref a,ref b);
            //Console.WriteLine(distance);
            //Console.ReadLine();

            //Point<int> a = new Point<int>(3, 4, 5);
            //Point<int> b = new Point<int>(3, 4, 6);

            //int HashCodeA = a.GetHashCode();
            //int HashCodeB = b.GetHashCode();

            //Console.WriteLine(HashCodeA);
            //Console.WriteLine(HashCodeB);
            //Console.ReadLine();

            //Point<int> a = new Point<int>(3,4,5);
            //Point<int> b = new Point<int>(3,4,6);

            //bool IsEqual = a.Equals(b);
            //Console.WriteLine(IsEqual);
            //Console.ReadLine();


            //double[] points = { 0, 3 };
            //Point2D Points = new Point2D(points);
            //Console.WriteLine(Points.X);
            //Console.WriteLine(Points.Y);
            //Console.ReadLine();

            //Point2D myPoint = new Point2D(0,3);
            //Console.WriteLine(myPoint.X);
            //Console.WriteLine(myPoint.Y);
            //Console.ReadLine();


            ////GRAPH

            ////NOTE: IF YOU HAVE YOUR GRAPH DATA, FIRST INSTANTIATE IT HERE USING: GraphTraverserDFS.graph = new Graph(new List<T>[]{new List1, new List2,...});

            //Console.WriteLine("Connected graph components: ");
            //for (int vertice = 0; vertice < GraphTraverserDFS.graph.Size; vertice++)
            //{
            //    if (!GraphTraverserDFS.visited[vertice])
            //    {
            //        GraphTraverserDFS.TraverseDFS(vertice);
            //        Console.WriteLine();
            //    }
            //}
            //Console.ReadLine();



            ////ODERED BINARY SEARCH TREE (UNBALANCED)
            //BinarySearchTree<string> tree = new BinarySearchTree<string>();
            //tree.Insert("Telerik");
            //tree.Insert("Google");
            //tree.Insert("Microsoft");
            //tree.PrintTreeDFS();
            ////Console.WriteLine(tree.Contains("Telerik"));
            ////Console.WriteLine(tree.Contains("IBM"));
            //tree.Remove("Telerik");
            ////Console.WriteLine(tree.Contains("Telerik"));
            //tree.PrintTreeDFS();
            //Console.ReadLine();

            ////BINARY TREE (POST-ORDER DFS Traversal)
            //PostOrderBinaryTree<int> TestPostOrderBinaryTree = new PostOrderBinaryTree<int>(14,
            //                                                     new PostOrderBinaryTree<int>(19,
            //                                                         new PostOrderBinaryTree<int>(23),
            //                                                         new PostOrderBinaryTree<int>(6,
            //                                                             new PostOrderBinaryTree<int>(10),
            //                                                             new PostOrderBinaryTree<int>(21))),
            //                                                     new PostOrderBinaryTree<int>(15,
            //                                                         new PostOrderBinaryTree<int>(3),
            //                                                         null)
            //                                                 );
            //TestPostOrderBinaryTree.PrintPostOrder();
            //Console.ReadLine();


            ////BINARY TREE (PRE-ORDER DFS Traversal)
            //PreOrderBinaryTree<int> TestPreOrderBinaryTree = new PreOrderBinaryTree<int>(14,
            //                                                     new PreOrderBinaryTree<int>(19,
            //                                                         new PreOrderBinaryTree<int>(23),
            //                                                         new PreOrderBinaryTree<int>(6,
            //                                                             new PreOrderBinaryTree<int>(10),
            //                                                             new PreOrderBinaryTree<int>(21))),
            //                                                     new PreOrderBinaryTree<int>(15,
            //                                                         new PreOrderBinaryTree<int>(3),
            //                                                         null)
            //                                                 );
            //TestPreOrderBinaryTree.PrintPreOrder();
            //Console.ReadLine();

            ////BINARY TREE (In-ORDER DFS Traversal)
            //BinaryTree<int> TestBinaryTree = new BinaryTree<int>(14,
            //                                     new BinaryTree<int>(19,
            //                                         new BinaryTree<int>(23),
            //                                         new BinaryTree<int>(6,
            //                                             new BinaryTree<int>(10),
            //                                             new BinaryTree<int>(21))),
            //                                     new BinaryTree<int>(15,
            //                                         new BinaryTree<int>(3),
            //                                         null)
            //                                 );
            //TestBinaryTree.PrintInOrder();
            //Console.ReadLine();


            //DIRECTORY TRAVERSER BY BREATH-FIRST SERACH TRAVERSAL

            //DirectoryTraverserBFS.TraverseDir("C:\\Windows\\assembly");
            //Console.ReadLine();


            ////DIRECTORY TRAVERSER BY DEPTH-FIRST SERACH TRAVERSAL

            //DirectoryTraverserDFS.TraverseDir("C:\\Users\\OBIANUJU ISICHELI\\Documents");
            //Console.ReadLine();


            ////DYNAMIC TREE IMPLEMENTATION (Depth-First Search Traversal)

            //Tree<int> testTree = new Tree<int>(7,
            //                         new Tree<int>(19,
            //                             new Tree<int>(1),
            //                             new Tree<int>(12),
            //                             new Tree<int>(31)),
            //                         new Tree<int>(21),
            //                         new Tree<int>(14,
            //                             new Tree<int>(23),
            //                             new Tree<int>(6))
            //                     );
            //testTree.TraverseDFS();

            //Console.ReadLine();


            //GAS LEAK
            //EXAMPLE 2 - Metric & Field
            //double Volume_IsolatedXmasTree = 70.7; double StartTestPressure = 580;
            //double EndTestPressure = 653; NaturalGas gas = new NaturalGas();
            //double Temperature = 59; double TestDuration = 30; FluidLeaks.UnitType unit = FluidLeaks.UnitType.field;

            //double GasLeakRate = FluidLeaks.GetGasLeakRate(Volume_IsolatedXmasTree, StartTestPressure, EndTestPressure, gas, Temperature, TestDuration, unit);


            //double Volume_IsolatedXmasTree = 2.0; double StartTestPressure = 4;
            //double EndTestPressure = 4.5; NaturalGas gas = new NaturalGas();
            //double Temperature = 15; double TestDuration = 30; FluidLeaks.UnitType unit = FluidLeaks.UnitType.metric;

            //double GasLeakRate = FluidLeaks.GetGasLeakRate(Volume_IsolatedXmasTree, StartTestPressure, EndTestPressure, gas, Temperature, TestDuration, unit);







            //////EXAMPLE 1 - Metric & Field
            //double Volume_IsolatedXmasTree = 0.008; double StartTestPressure = 1;
            //double EndTestPressure = 3; NaturalGas gas = new NaturalGas();
            //double Temperature = 27; double TestDuration = 5; FluidLeaks.UnitType unit = FluidLeaks.UnitType.metric;

            //double GasLeakRate = FluidLeaks.GetGasLeakRate(Volume_IsolatedXmasTree, StartTestPressure, EndTestPressure, gas, Temperature, TestDuration, unit);

            //double Volume_IsolatedXmasTree = 0.28; double StartTestPressure = 145;
            //double EndTestPressure = 435; NaturalGas gas = new NaturalGas();
            //double Temperature = 81; double TestDuration = 5; FluidLeaks.UnitType unit = FluidLeaks.UnitType.field;

            //double GasLeakRate = FluidLeaks.GetGasLeakRate(Volume_IsolatedXmasTree, StartTestPressure, EndTestPressure, gas, Temperature, TestDuration, unit);

            //Console.WriteLine(GasLeakRate);
            //Console.ReadLine();




            //WATER LEAK
            //EXAMPLE 1 - Metric & Field

            //double Volume_XmasTreePlusTestLine = 0.008; double StartTestPressure = 34.5;
            //double EndTestPressure = 26.2; double TestDuration = 15; FluidLeaks.UnitType unit = FluidLeaks.UnitType.metric;

            //double WaterLeakRate = FluidLeaks.GetWaterLeakRate(Volume_XmasTreePlusTestLine, StartTestPressure, EndTestPressure, TestDuration, unit);

            //double Volume_XmasTreePlusTestLine = 0.283; double StartTestPressure = 5000;
            //double EndTestPressure = 3800; double TestDuration = 15; FluidLeaks.UnitType unit = FluidLeaks.UnitType.field;

            //double WaterLeakRate = FluidLeaks.GetWaterLeakRate(Volume_XmasTreePlusTestLine, StartTestPressure, EndTestPressure, TestDuration, unit);

            //Console.WriteLine(WaterLeakRate);
            //Console.ReadLine();


        }

        public static class Solution 
        {
            public static string solution(int X) 
            {
                string stringResult = "Some Output";
                if (X < 60)
                {
                    stringResult = X.ToString();
                    return stringResult;
                }
                else if (X >= 60 && X < (60 * 60))
                {
                    double result = X / 60.0;

                    int minute = (int)result;

                    double seconds = result - minute;
                    if (seconds == 0)
                    {
                        stringResult = minute.ToString() + "m";
                    }
                    else
                    {
                        int seconds1 = (int)(seconds * 60);
                        stringResult = minute.ToString() + "m" + seconds1.ToString() + "s";
                    }

                }
                else if (X >= (60 * 60) && X < (3600 * 24))
                {
                    double result = X / (60.0 * 60.0);

                    int hour = (int)result;

                    double seconds = result - hour;
                    
                    if (seconds == 0)
                    {
                        stringResult = hour.ToString() + "h";
                    }
                    else 
                    {
                        int seconds1 = (int)(seconds * 60 * 60);
                        if (seconds1 > 60)
                        {
                            int min = (int)seconds1 / 60;
                            min++;
                            stringResult = hour.ToString() + "h" + min.ToString() + "m";
                        }
                        else 
                        {
                            seconds1++;
                            stringResult = hour.ToString() + "h" + seconds1.ToString() + "s";
                        }
                        
                    }
                   

                }
                else if (X >= (3600 * 24) && X < (3600 * 24 * 7))
                {
                    double result = X / (60.0 * 60.0 * 24.0);

                    int day = (int)result;

                    double seconds = result - day;
                    if (seconds == 0)
                    {
                        stringResult = day.ToString() + "d";
                    }
                    else 
                    {
                        int seconds1 = (int)(seconds * 60 * 60 * 24);
                        if (seconds1 > 3600)
                        {
                            int hour = (int)seconds1 / 3600;
                            hour++;
                            stringResult = day.ToString() + "d" + hour.ToString() + "h";
                        }
                        else{
                            seconds1++;
                            stringResult = day.ToString() + "d" + seconds1.ToString() + "s";
                        }
                        
                    }
                }
                else
                {
                    double result = X / (60.0 * 60.0 * 24.0 * 7.0);

                    int week = (int)result;

                    double seconds = result - week;
                    if (seconds == 0)
                    {
                        stringResult = week.ToString() + "w";
                    }
                    else 
                    {
                        int seconds1 = (int)(seconds * 60 * 60 * 24 * 7);
                        if (seconds1 > 60 * 60 * 24)
                        {
                            int days = (int)seconds / (60 * 60 * 24);
                            days++;
                            stringResult = week.ToString() + "w" + days.ToString() + "d";
                        }
                        else 
                        {
                            seconds1++;
                            stringResult = week.ToString() + "w" + seconds1.ToString() + "s";
                        }
                        
                    }

                }

                return stringResult;
            }
        }

        public static int solution(string S)
        {
            List<string> S_splitted = new List<string>();

            foreach (var Char in S)
            {
                S_splitted.Add(Char.ToString());
            }

            if (S_splitted.Count == 0)
            {
                return 1;
            }

            Stack<string> BracketsStack = new Stack<string>();
            int counter = 0;
            foreach (string bracket in S_splitted)
            {
                counter++;
                if (bracket == "[" || bracket == "(" || bracket == "{")
                {//It's an opening bracket. Add to stack.

                    BracketsStack.Push(bracket);
                }
                else if (bracket == "]" || bracket == ")" || bracket == "}")
                {//it's a closing bracket so compare with the LATEST opening bracket added to the stack.

                    string LatestOpeningBracket = BracketsStack.Pop(); //Pop rather than peek to reduce accumulation and also keep track of the number
                                                                       //of yet-to-be-matched openingBracket in the utility stack.
                    if (counter == 1)
                    {
                        if (LatestOpeningBracket == "[" || LatestOpeningBracket == "(" || LatestOpeningBracket == "{" || LatestOpeningBracket == "" && counter == 1)
                        {

                            return 0;//Started with closing bracket - negative match
                        }
                    }
                    

                    if (LatestOpeningBracket == "[" && bracket == "]")
                    {

                        continue; // It's a matching bracket so continue to the next iteration of the character array.
                    }
                    else if (LatestOpeningBracket == "(" && bracket == ")")
                    {
                        continue; // It's a matching bracket so continue to the next iteration of the character array.
                    }
                    else if (LatestOpeningBracket == "{" && bracket == "}")
                    {
                        continue; // It's a matching bracket so continue to the next iteration of the character array.
                    }
                    else
                    {
                        return 0;//Doesn't have matching bracket }

                    }

                }

            }

            if (BracketsStack.Count > 0)
            {
                return 0;//unbalanced because there are remaining unmatched brackets.
            }
            else
            { return 1; } // All openingBrackets where matched and removed from utility stack.}
        }


        public static List<int> minHeaviestSetA(List<int> arr)
        {
            int arrCount = arr.Count; int arrA_count = 0;
            if (arrCount % 2 == 0)
            {
                arrA_count = (arrCount / 2) - 1;
            }
            else { arrA_count = (int)(arrCount / 2); }

            int arrB_count = arrCount - arrA_count;




            return null;
        }




        /// <summary>
        /// Implementation of Custom ArrayList (A type-based version)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class CustomArrayList<T>
        {
            private T[] arr;
            private int count;

            /// <summary>
            /// Returns the actual list length
            /// </summary>
            public int Count
            {
                get
                {
                    return this.count;
                }
            }
            private const int INITIAL_CAPACITY = 4;


            /// <summary>
            /// Initializes the array-based list – allocate memory
            /// </summary>
            public CustomArrayList(int capacity = INITIAL_CAPACITY)
            {
                this.arr = new T[capacity];
                this.count = 0;
            }

            /// <summary>
            /// Adds element to the list</summary>
            /// <param name="item">The element you want to add</param>
            public void Add(T item)
            {
                GrowIfArrIsFull();
                this.arr[this.count] = item;
                this.count++;
            }

            /// <summary>
            /// Inserts the specified element at given position in this list
            /// </summary>
            /// <param name="index">
            /// Index, at which the specified element is to be inserted
            /// </param>
            /// <param name="item">
            /// Element to be inserted</param>
            /// <exception cref="System.IndexOutOfRangeException">
            /// Index is invalid
            /// </exception>
            public void Insert(int index, T item)
            {
                if (index > this.count || index < 0)
                {
                    throw new IndexOutOfRangeException(
                    "Invalid index: " + index);
                }
                GrowIfArrIsFull();
                Array.Copy(this.arr, index,
                this.arr, index + 1, this.count - index);
                this.arr[index] = item;
                this.count++;
            }

            /// <summary>
            /// Doubles the size of this.arr (grow) if it is full
            /// </summary>
            private void GrowIfArrIsFull()
            {
                if (this.count + 1 > this.arr.Length)
                {
                    T[] extendedArr = new T[this.arr.Length * 2];
                    Array.Copy(this.arr, extendedArr, this.count);
                    this.arr = extendedArr;
                }
            }

            /// <summary>
            /// Clears the list (remove everything)
            /// </summary>
            public void Clear()
            {
                this.arr = new T[INITIAL_CAPACITY];
                this.count = 0;
            }

            /// <summary>
            /// Returns the index of the first occurrence of the specified
            /// element in this list (or -1 if it does not exist).
            /// </summary>
            /// <param name="item">The element you are searching</param>
            /// <returns>
            /// The index of a given element or -1 if it is not found
            /// </returns>
            public int IndexOf(T item)
            {
                for (int i = 0; i < this.arr.Length; i++)
                {
                    if (object.Equals(item, this.arr[i]))
                    {
                        return i;
                    }
                }
                return -1;
            }

            /// <summary>Checks if an element exists</summary>
            /// <param name="item">The item to be checked</param>
            /// <returns>If the item exists</returns>
            public bool Contains(T item)
            {
                int index = IndexOf(item);
                bool found = (index != -1);
                return found;
            }

            /// <summary>Indexer: access to element at given index</summary>
            /// <param name="index">Index of the element</param>
            /// <returns>The element at the specified position</returns>
            public T this[int index]
            {
                get
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    return this.arr[index];
                }
                set
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    this.arr[index] = value;
                }
            }

            /// <summary>Removes the element at the specified index
            /// </summary>
            /// <param name="index">The index of the element to remove
            /// </param>
            /// <returns>The removed element</returns>
            public T RemoveAt(int index)
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                T item = this.arr[index];
                Array.Copy(this.arr, index + 1,
                this.arr, index, this.count - index - 1);
                this.arr[this.count - 1] = default(T);
                this.count--;
                return item;
            }

            /// <summary>Removes the specified item</summary>
            /// <param name="item">The item to be removed</param>
            /// <returns>The removed item's index or -1 if the item does not exist</returns>
            public int Remove(T item)
            {
                int index = IndexOf(item);
                if (index != -1)
                {
                    this.RemoveAt(index);
                }
                return index;
            }
        }

        /// <summary>
        /// Implementation of Custom Linked-List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class DynamicList<T>
        {
            private class ListNode
            {
                public T Element { get; set; }
                public ListNode NextNode { get; set; }

                public ListNode(T element)
                {
                    this.Element = element;
                    NextNode = null;
                }
                public ListNode(T element, ListNode prevNode)
                {
                    this.Element = element;
                    prevNode.NextNode = this;
                }
            }

            private ListNode head;
            private ListNode tail;
            private int count;

            public DynamicList()
            {
                this.head = null;
                this.tail = null;
                this.count = 0;
            }

            /// <summary>Add element at the end of the list</summary>
            /// <param name="item">The element to be added</param>
            public void Add(T item)
            {
                if (this.head == null)
                {
                    // We have an empty list -> create a new head and tail
                    this.head = new ListNode(item);
                    this.tail = this.head;
                }
                else
                {
                    // We have a non-empty list -> append the item after tail
                    ListNode newNode = new ListNode(item, this.tail);
                    this.tail = newNode;
                }
                this.count++;
            }

            /// <summary>Removes and returns element on the specified index
            /// </summary>
            /// <param name="index">The index of the element to be removed
            /// </param>
            /// <returns>The removed element</returns>
            /// <exception cref="System.ArgumentOutOfRangeException">
            /// if the index is invalid</exception>
            public T RemoveAt(int index)
            {

                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                // Find the element at the specified index
                int currentIndex = 0;
                ListNode currentNode = this.head;
                ListNode prevNode = null;
                while (currentIndex < index)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }

                // Remove the found element from the list of nodes
                RemoveListNode(currentNode, prevNode);
                // Return the removed element
                return currentNode.Element;
            }

            /// <summary>
            /// Remove the specified node from the list of nodes
            /// </summary>
            /// <param name="node">the node for removal</param>
            /// <param name="prevNode">the predecessor of node</param>
            private void RemoveListNode(ListNode node, ListNode prevNode)
            {
                count--;
                if (count == 0)
                {
                    // The list becomes empty -> remove head and tail
                    this.head = null;
                    this.tail = null;
                }
                else if (prevNode == null)
                {
                    // The head node was removed --> update the head
                    this.head = node.NextNode;
                }
                else
                {
                    // Redirect the pointers to skip the removed node
                    prevNode.NextNode = node.NextNode;
                }
                // Fix the tail in case it was removed
                if (object.ReferenceEquals(this.tail, node))
                {
                    this.tail = prevNode;
                }
            }

            /// <summary>
            /// Removes the specified item and return its index.
            /// </summary>
            /// <param name="item">The item for removal</param>
            /// <returns>The index of the element or -1 if it does not exist</returns>
            public int Remove(T item)
            {
                // Find the element containing the searched item
                int currentIndex = 0;
                ListNode currentNode = this.head;
                ListNode prevNode = null;
                while (currentNode != null)
                {
                    if (object.Equals(currentNode.Element, item))
                    {
                        break;
                    }
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }

                if (currentNode != null)
                {
                    // The element is found in the list -> remove it
                    RemoveListNode(currentNode, prevNode);
                    return currentIndex;
                }
                else
                {
                    // The element is not found in the list -> return -1
                    return -1;
                }


            }

            /// <summary>Searches for given element in the list</summary>
            /// <param name="item">The item to be searched</param>
            /// <returns>
            /// The index of the first occurrence of the element
            /// in the list or -1 when it is not found
            /// </returns>
            public int IndexOf(T item)
            {
                int index = 0;
                ListNode currentNode = this.head;
                while (currentNode != null)
                {
                    if (object.Equals(currentNode.Element, item))
                    {
                        return index;
                    }
                    currentNode = currentNode.NextNode;
                    index++;
                }
                return -1;
            }

            /// <summary>
            /// Checks if the specified element exists in the list
            /// </summary>
            /// <param name="item">The item to be checked</param>
            /// <returns>
            /// True if the element exists or false otherwise
            /// </returns>
            public bool Contains(T item)
            {
                int index = IndexOf(item);
                bool found = (index != -1);
                return found;
            }

            /// <summary>
            /// Gets or sets the element at the specified position
            /// </summary>
            /// <param name="index">
            /// The position of the element [0 … count-1]
            /// </param>
            /// <returns>The item at the specified index</returns>
            /// <exception cref="System.ArgumentOutOfRangeException">
            /// When an invalid index is specified
            /// </exception>
            public T this[int index]
            {
                get
                {
                    if (index >= count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    ListNode currentNode = this.head;

                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.NextNode;
                    }
                    return currentNode.Element;
                }

                set
                {
                    if (index >= count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    ListNode currentNode = this.head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.NextNode;
                    }
                    currentNode.Element = value;
                }

            }

            /// <summary>
            /// Gets the count of elements in the list
            /// </summary>
            public int Count
            {
                get
                {
                    return this.count;
                }
            }

        }

        public class TreeNode<T>
        {
            //Contains the value of the node
            private T value;

            //Shows whether the current node has a parent or not
            private bool hasParent;

            //Contains the children of the node (zero or more)
            private List<TreeNode<T>> children;

            /// <summary>
            /// Constructs a tree node
            /// </summary>
            /// <param name="value">the value of the node</param>
            public TreeNode(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Did not pass in any value");
                }
                this.value = value;
                this.children = new List<TreeNode<T>>();
            }


            /// <summary>
            /// The value of the node
            /// </summary>
            public T Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            /// <summary>
            /// The number of node's children
            /// </summary>
            public int ChildrenCount { get { return this.children.Count; } }

            /// <summary>
            /// Adds child to the node
            /// </summary>
            /// <param name="child">the child to be added</param>
            public void AddChild(TreeNode<T> child)
            {
                if (child == null)
                {
                    throw new ArgumentNullException("There is no child to add");
                }

                if (child.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                child.hasParent = true;
                this.children.Add(child);
            }

            /// <summary>
            /// Gets the child of the node at given index
            /// </summary>
            /// <param name="index"></param>
            /// <returns>the index of the desired child</returns>
            public TreeNode<T> GetChild(int index)
            {
                return this.children[index];
            }
        }
        public class Tree<T>
        {
            /// <summary>
            /// The root of the tree
            /// </summary>
            private TreeNode<T> root;

            /// <summary>
            /// Constructs the tree
            /// </summary>
            /// <param name="value">the value of the node</param>
            public Tree(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("There's nothing in value");
                }

                this.root = new TreeNode<T>(value);
            }

            /// <summary>
            /// Constructs the tree
            /// </summary>
            /// <param name="value">the value of the root node</param>
            /// <param name="children">the children of the root node</param>
            public Tree(T value, params Tree<T>[] children) : this(value)
            {
                foreach (Tree<T> child in children)
                {
                    this.root.AddChild(child.root);
                }
            }

            /// <summary>
            /// the root node or null if the root is empty
            /// </summary>
            public TreeNode<T> Root { get { return this.root; } }

            private void PrintDFS(TreeNode<T> root, string SpacesLinker)
            {
                if (root == null)
                {
                    return;
                }

                Console.WriteLine(SpacesLinker + root.Value);

                TreeNode<T> child = null;

                for (int i = 0; i < root.ChildrenCount; i++)
                {
                    child = root.GetChild(i);
                    PrintDFS(child, SpacesLinker + " ");
                }

            }

            /// <summary>
            /// Traverses and prints the tree in Depth-First Search manner
            /// </summary>
            public void TraverseDFS()
            {
                this.PrintDFS(this.root, string.Empty);
            }

        }

        /// <summary>
        /// Traverses recursively given directory based on the Depth-First-Search (DFS) algorithm
        /// </summary>
        public static class DirectoryTraverserDFS
        {
            /// <summary>
            /// Private method that traverses and prints given directory recursively
            /// </summary>
            /// <param name="dir">the directory to be traversed</param>
            /// <param name="spaces">the spaces used for representation of the parent-child relation</param>
            private static void TraverseDir(DirectoryInfo dir, string spaces)
            {
                //Visit the current directory
                Console.WriteLine(spaces + dir.FullName);


                DirectoryInfo[] children = dir.GetDirectories();


                //For each child, go and visit its sub-tree
                foreach (DirectoryInfo child in children)
                {
                    TraverseDir(child, spaces + " ");
                }
            }

            /// <summary>
            /// Public method that traverses and prints the given directory recursively
            /// </summary>
            /// <param name="directoryPath">the path to the directory which should be traversed</param>
            public static void TraverseDir(string directoryPath)
            {
                TraverseDir(new DirectoryInfo(directoryPath), string.Empty);
            }
        }


        /// <summary>
        /// Traverses given directory based on Breath-First Search Algorithm
        /// </summary>
        public static class DirectoryTraverserBFS
        {
            /// <summary>
            /// Traverses and prints given directories with BFS
            /// </summary>
            /// <param name="directoryPath">the path to the directories which should be traversed</param>
            public static void TraverseDir(string directoryPath)
            {
                Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
                visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

                while (visitedDirsQueue.Count > 0)
                {
                    DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                    Console.WriteLine(currentDir.FullName);

                    DirectoryInfo[] children = currentDir.GetDirectories();

                    foreach (DirectoryInfo child in children)
                    {
                        visitedDirsQueue.Enqueue(child);
                    }
                }
            }
        }



        /// <summary>
        /// Represents a binary tree
        /// </summary>
        /// <typeparam name="T">Type of values in the tree</typeparam>
        public class BinaryTree<T>
        {
            /// <summary>
            /// The value stored in the current node
            /// </summary>
            public T Value;

            /// <summary>
            /// The left child of the current node
            /// </summary>
            public BinaryTree<T> LeftChild { get; private set; }

            /// <summary>
            /// The right child of the current node
            /// </summary>
            public BinaryTree<T> RightChild { get; private set; }

            /// <summary>
            /// Constructs the binary tree
            /// </summary>
            /// <param name="value">The value of the node</param>
            /// <param name="leftChild">The left side of the tree</param>
            /// <param name="rightChild">The right side of the tree</param>
            public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
            {
                this.Value = value;
                this.LeftChild = leftChild;
                this.RightChild = rightChild;
            }

            /// <summary>
            /// Constructs the binary tree with no children
            /// </summary>
            /// <param name="value">The value of the tree node</param>
            public BinaryTree(T value) : this(value, null, null)
            {

            }

            /// <summary>
            /// Gets the tree's  height - that is, the number of edges
            /// between the tree's root and its furthest leaf.
            /// </summary>
            /// <returns></returns>
            public int getHeight(BinaryTree<T> root)
            {
                int height = 0;
                if (root == null)
                {
                    return -1;
                }
                else {

                    int LeftChildMaxHeight = getHeight(root.LeftChild);
                    int RightChildMaxHeight = getHeight(root.RightChild);

                    height = Math.Max(LeftChildMaxHeight, RightChildMaxHeight) + 1;

                }

                return height;
            }

            /// <summary>
            /// Traverses the binary tree in in-order
            /// </summary>
            public void PrintInOrder()
            {
                //Visit the left child
                if (this.LeftChild != null)
                {
                    this.LeftChild.PrintInOrder();
                }

                //Visit the root of this sub-tree
                Console.Write(this.Value + " ");

                //Visit the right child
                if (this.RightChild != null)
                {
                    this.RightChild.PrintInOrder();
                }
            }
        }

        /// <summary>
        /// Represents a binary tree in pre-order
        /// </summary>
        /// <typeparam name="T">Type of values in the trees</typeparam>
        public class PreOrderBinaryTree<T>
        {
            /// <summary>
            /// The value stored in the current node
            /// </summary>
            public T Value;

            /// <summary>
            /// The left child of the current node
            /// </summary>
            public PreOrderBinaryTree<T> LeftChild { get; private set; }

            /// <summary>
            /// The right side of the current node
            /// </summary>
            public PreOrderBinaryTree<T> RightChild { get; private set; }

            /// <summary>
            /// Constructs the binary tree
            /// </summary>
            /// <param name="value">The value of the node</param>
            /// <param name="leftChild">The left side of the tree</param>
            /// <param name="rightChild">The right side of the tree</param>
            public PreOrderBinaryTree(T value, PreOrderBinaryTree<T> leftChild, PreOrderBinaryTree<T> rightChild)
            {
                this.Value = value;
                this.LeftChild = leftChild;
                this.RightChild = rightChild;
            }

            /// <summary>
            /// Constructs the binary tree with no children
            /// </summary>
            /// <param name="value">The value of the tree node</param>
            public PreOrderBinaryTree(T value) : this(value, null, null)
            {

            }


            /// <summary>
            /// Gets the tree's  height - that is, the number of edges
            /// between the tree's root and its furthest leaf.
            /// </summary>
            /// <returns></returns>
            public int getHeight(PreOrderBinaryTree<T> root)
            {
                int height = 0;
                if (root == null)
                {
                    return -1;
                }
                else
                {

                    int LeftChildMaxHeight = getHeight(root.LeftChild);
                    int RightChildMaxHeight = getHeight(root.RightChild);

                    height = Math.Max(LeftChildMaxHeight, RightChildMaxHeight) + 1;

                }

                return height;
            }




            /// <summary>
            /// Traverses the binary tree in pre-order
            /// </summary>
            public void PrintPreOrder()
            {
                //Visit the root of this sub-tree
                Console.Write(this.Value + " ");


                //Visit the left child
                if (this.LeftChild != null)
                {
                    this.LeftChild.PrintPreOrder();
                }


                //Visit the right child
                if (this.RightChild != null)
                {
                    this.RightChild.PrintPreOrder();
                }
            }
        }

        /// <summary>
        /// Represents a binary tree in post-order
        /// </summary>
        /// <typeparam name="T">Type of values in the trees</typeparam>
        public class PostOrderBinaryTree<T>
        {
            /// <summary>
            /// The value stored in the current node
            /// </summary>
            public T Value;

            /// <summary>
            /// The left child of the current node
            /// </summary>
            public PostOrderBinaryTree<T> LeftChild { get; private set; }

            /// <summary>
            /// The right side of the current node
            /// </summary>
            public PostOrderBinaryTree<T> RightChild { get; private set; }

            /// <summary>
            /// Constructs the binary tree
            /// </summary>
            /// <param name="value">The value of the node</param>
            /// <param name="leftChild">The left side of the tree</param>
            /// <param name="rightChild">The right side of the tree</param>
            public PostOrderBinaryTree(T value, PostOrderBinaryTree<T> leftChild, PostOrderBinaryTree<T> rightChild)
            {
                this.Value = value;
                this.LeftChild = leftChild;
                this.RightChild = rightChild;
            }

            /// <summary>
            /// Constructs the binary tree with no children
            /// </summary>
            /// <param name="value">The value of the tree node</param>
            public PostOrderBinaryTree(T value) : this(value, null, null)
            {

            }

            /// <summary>
            /// Gets the tree's  height - that is, the number of edges
            /// between the tree's root and its furthest leaf.
            /// </summary>
            /// <returns></returns>
            public int getHeight(PostOrderBinaryTree<T> root)
            {
                int height = 0;
                if (root == null)
                {
                    return -1;
                }
                else
                {

                    int LeftChildMaxHeight = getHeight(root.LeftChild);
                    int RightChildMaxHeight = getHeight(root.RightChild);

                    height = Math.Max(LeftChildMaxHeight, RightChildMaxHeight) + 1;

                }

                return height;
            }


            /// <summary>
            /// Traverses the binary tree in post-order
            /// </summary>
            public void PrintPostOrder()
            {
                //Visit the left child
                if (this.LeftChild != null)
                {
                    this.LeftChild.PrintPostOrder();
                }

                //Visit the right child
                if (this.RightChild != null)
                {
                    this.RightChild.PrintPostOrder();
                }

                //Visit the root of this sub-tree
                Console.Write(this.Value + " ");
            }
        }


        /// <summary>
        /// Represents an unbalanced / non self-balancing, Ordered Binary Search Tree
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BinarySearchTree<T> where T : IComparable<T>
        {

            /// <summary>
            /// Represents a binary tree node
            /// </summary>
            /// <typeparam name="T">Specifies the type for the values in the node</typeparam>
            internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
            {

                //Contains the value of the node
                internal T value;

                //Contains the parent of the node
                internal BinaryTreeNode<T> parent;

                //Contains the leftchild of the node
                internal BinaryTreeNode<T> leftChild;

                //Contains the rightchild of the node
                internal BinaryTreeNode<T> rightChild;

                /// <summary>
                /// Constructs the tree node
                /// </summary>
                /// <param name="value">The value of the tree node</param>
                public BinaryTreeNode(T value)
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("There's nothing to insert and therefore cannot be compared");
                    }

                    this.value = value;
                    this.parent = null;
                    this.leftChild = null;
                    this.rightChild = null;
                }


                public override string ToString()
                {
                    return this.value.ToString();
                }

                public override int GetHashCode()
                {
                    return this.value.GetHashCode();
                }

                public override bool Equals(object obj)
                {
                    BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
                    return this.value.CompareTo(other.value) == 0;
                }

                public int CompareTo(BinaryTreeNode<T> other)
                {
                    return this.value.CompareTo(other.value);
                }


            }


            /// <summary>
            /// The root of the tree
            /// </summary>
            public BinaryTreeNode<T> root; //initially private



            /// <summary>
            /// Constructs the tree
            /// </summary>
            public BinarySearchTree()
            {
                this.root = null;
            }



            //INSERT
            /// <summary>Inserts new value in the binary search tree
            /// </summary>
            /// <param name="value">the value to be inserted</param>
            public void Insert(T value)
            {
                this.root = Insert(value, null, root);

            }

            /// <summary>
            /// Inserts node in the binary search tree by given value
            /// </summary>
            /// <param name="value">the new value</param>
            /// <param name="parentNode">the parent of the new node</param>
            /// <param name="node">current node</param>
            /// <returns>the inserted node</returns>
            private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
            {
                if (node == null)
                {
                    node = new BinaryTreeNode<T>(value);
                    node.parent = parentNode;
                }
                else
                {
                    int compareTo = value.CompareTo(node.value);

                    if (compareTo < 0)
                    {

                        node.leftChild = Insert(value, node, node.leftChild);

                    }
                    else if (compareTo > 0)
                    {

                        node.rightChild = Insert(value, node, node.rightChild);
                    }
                }


                return node;
            }

            public List<int>[] SwapNodes(List<int> Indexes, List<int> K_ValueIntegers)
            {
                List<int> h_depths = new List<int>();

                for (int i = 0; i < K_ValueIntegers.Count; i++)
                {
                    h_depths.Add(i * K_ValueIntegers[i]);
                }


                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {

                    BinaryTreeNode<T> tempNode = queue.Dequeue();
                    Console.Write(tempNode.value + " ");

                    /*Enqueue left child */
                    if (tempNode.leftChild != null)
                    {
                        queue.Enqueue(tempNode.leftChild);
                    }

                    /*Enqueue right child */
                    if (tempNode.rightChild != null)
                    {
                        queue.Enqueue(tempNode.rightChild);
                    }
                }

                return null;
            }



            //SEARCH
            /// <summary>Finds a given value in the tree and
            /// return the node which contains it if such exists
            /// </summary>
            /// <param name="value">the value to be found</param>
            /// <returns>the found node or null if not found</returns>
            public BinaryTreeNode<T> Find(T value)
            {
                BinaryTreeNode<T> node = this.root;

                while (node != null)
                {
                    int compareTo = value.CompareTo(node.value);

                    if (compareTo < 0)
                    {
                        node = node.leftChild;
                    }
                    else if (compareTo > 0)
                    {
                        node = node.rightChild;
                    }
                    else { break; }
                }
                return node;
            }

            /// <summary>Returns whether given value exists in the tree
            /// </summary>
            /// <param name="value">the value to be checked</param>
            /// <returns>true if the value is found in the tree</returns>
            public bool Contains(T value)
            {
                bool found = this.Find(value) != null;
                return found;
            }



            //DELETE
            /// <summary>Removes an element from the tree if exists
            /// </summary>
            /// <param name="value">the value to be deleted</param>
            public void Remove(T value)
            {
                BinaryTreeNode<T> nodeToDelete = Find(value);
                if (nodeToDelete != null)
                {
                    Remove(nodeToDelete);
                }
            }

            private void Remove(BinaryTreeNode<T> node)
            {
                // Case 3: If the node has two children.
                // Note that if we get here at the end
                // the node will be with at most one child
                if (node.leftChild != null && node.rightChild != null)
                {
                    BinaryTreeNode<T> replacement = node.rightChild;
                    while (replacement.leftChild != null)
                    {
                        replacement = replacement.leftChild;
                    }
                    node.value = replacement.value;
                    node = replacement;
                }

                // Case 1 and 2: If the node has at most one child
                BinaryTreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;

                // If the element to be deleted has one child
                if (theChild != null)
                {
                    theChild.parent = node.parent;

                    // Handle the case when the element is the root
                    if (node.parent == null)
                    {
                        root = theChild;
                    }
                    else
                    {
                        // Replace the element with its child sub-tree
                        if (node.parent.leftChild == node)
                        {
                            node.parent.leftChild = theChild;
                        }
                        else
                        {
                            node.parent.rightChild = theChild;
                        }
                    }
                }
                else
                {
                    // Handle the case when the element is the root
                    if (node.parent == null)
                    {
                        root = null;
                    }
                    else
                    {
                        // Remove the element - it is a leaf
                        if (node.parent.leftChild == node)
                        {
                            node.parent.leftChild = null;
                        }
                        else
                        {
                            node.parent.rightChild = null;
                        }
                    }
                }
            }

            /// <summary>
            /// Gets the tree's  height - that is, the number of edges
            /// between the tree's root and its furthest leaf.
            /// </summary>
            /// <returns></returns>
            public int getHeight_LevelOrder(BinaryTreeNode<T> node)
            {
                int height;
                if (node == null)
                {
                    return 0;
                }
                else
                {

                    int LeftChildMaxHeight = getHeight_LevelOrder(node.leftChild);
                    int RightChildMaxHeight = getHeight_LevelOrder(node.rightChild);

                    height = Math.Max(LeftChildMaxHeight, RightChildMaxHeight); //consider putting the + 1 here.

                }

                return height + 1;
            }


            /// <summary>
            /// Gets the tree's  height - that is, the number of edges
            /// between the tree's root and its furthest leaf.
            /// </summary>
            /// <returns></returns>
            public int getHeight(BinaryTreeNode<T> node)
            {
                int height;
                if (node == null)
                {
                    return -1;
                }
                else
                {

                    int LeftChildMaxHeight = getHeight(node.leftChild);
                    int RightChildMaxHeight = getHeight(node.rightChild);

                    height = Math.Max(LeftChildMaxHeight, RightChildMaxHeight);

                }

                return height + 1;
            }


            /// <summary>
            /// Prints the nodes of a Binary Tree in Level (Height) - Order from Left to Right
            /// </summary>
            /// <param name="root"></param>
            public void LevelOrder(BinaryTreeNode<T> root)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {

                    BinaryTreeNode<T> tempNode = queue.Dequeue();
                    Console.Write(tempNode.value + " ");

                    /*Enqueue left child */
                    if (tempNode.leftChild != null)
                    {
                        queue.Enqueue(tempNode.leftChild);
                    }

                    /*Enqueue right child */
                    if (tempNode.rightChild != null)
                    {
                        queue.Enqueue(tempNode.rightChild);
                    }
                }
            }



            /// <summary>
            /// Traverses and prints level order values, that is in breath first search print.
            /// </summary>
            /// <param name="root">the path to the directories which should be traversed</param>
            public void LevelOrder_N2(BinaryTreeNode<T> root)
            {
                int height = getHeight_LevelOrder(root);
                int i;
                for (i = 1; i <= height; i++)
                {
                    printCurrentLevel_N2(root, i);
                }
            }


            private void printCurrentLevel_N2(BinaryTreeNode<T> root, int currentLevel)
            {
                if (root == null)
                {
                    return;
                }
                if (currentLevel == 1) {
                    Console.Write(root.value + " ");
                }
                else if (currentLevel > 1)
                {
                    printCurrentLevel_N2(root.leftChild, currentLevel - 1);
                    printCurrentLevel_N2(root.rightChild, currentLevel - 1);
                }
            }



            //PRINT
            /// <summary>
            /// Traverses and prints the tree
            /// </summary>
            public void PrintTreeDFS()
            {
                PrintTreeDFS(this.root);
                Console.WriteLine();
            }

            /// <summary>Traverses and prints the ordered binary search tree
            /// starting from given root node.</summary>
            /// <param name="node">the starting node</param>
            private void PrintTreeDFS(BinaryTreeNode<T> node)
            {
                if (node != null)
                {
                    PrintTreeDFS(node.leftChild);
                    Console.Write(node.value + " ");
                    PrintTreeDFS(node.rightChild);
                }
            }
        }

        /// <summary>
        /// Represents a directed unweighted graph structure
        /// </summary>
        public class Graph
        {
            //Contains the child nodes for each vertex of the graph
            //assuming that the vertices are numbered 0 ... Size - 1.
            private List<int>[] childNodes;

            /// <summary>
            /// Constructs an empty graph of given size
            /// </summary>
            /// <param name="size">number of vertices</param>
            public Graph(int size)
            {
                this.childNodes = new List<int>[size];
                for (int i = 0; i < size; i++)
                {
                    //Assuming an empty list of adjacents for each vertex
                    this.childNodes[i] = new List<int>();
                }
            }

            /// <summary>
            /// Constructs a graph by given list of child nodes (successors) for each vertex
            /// </summary>
            /// <param name="childNodes">children for each node</param>
            public Graph(List<int>[] childNodes)
            {
                this.childNodes = childNodes;
            }

            /// <summary>
            /// Returns the size of the graph (number of vertices)
            /// </summary>
            public int Size
            {
                get { return this.childNodes.Length; }
            }

            /// <summary>
            /// Adds new edge from u to v
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            public void AddEdge(int u, int v)
            {
                childNodes[u].Add(v);
            }

            /// <summary>
            /// Removes the edge from u to v if such exists
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            public void RemoveEdge(int u, int v)
            {
                childNodes[u].Remove(v);
            }

            /// <summary>
            /// Checks whether there is an edge between vertex u and v
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            /// <returns>true if there is an edge between vertex u and vertex v</returns>
            public bool HasEdge(int u, int v)
            {
                bool hasEdge = childNodes[u].Contains(v);
                return hasEdge;
            }



            /// <summary>
            /// Returns the successors of a given vertex
            /// </summary>
            /// <param name="v">the vertex</param>
            /// <returns>list of all successors of vertex v</returns>
            public IList<int> GetSuccessors(int v)
            {
                return childNodes[v];
            }



        }


        /// <summary>
        /// Represents a directed weighted graph structure
        /// </summary>
        public class WeightedGraph
        {
            //Contains the child nodes for each vertex of the graph
            //assuming that the vertices are numbered 0 ... Size - 1.
            private readonly List<int>[] childNodes;
            private readonly List<double>[] WeightsList;
            private readonly List<int> nstates;
            private readonly List<List<int>> allLocations;
            private int allLocations_count;

            /// <summary>
            /// Constructs an empty graph of given size
            /// </summary>
            /// <param name="size">number of vertices</param>
            public WeightedGraph(int size)
            {
                this.childNodes = new List<int>[size];
                for (int i = 0; i < size; i++)
                {
                    //Assuming an empty list of adjacents for each vertex
                    this.childNodes[i] = new List<int>();
                    this.WeightsList[i] = new List<double>();
                }
            }

            /// <summary>
            /// Constructs a graph by given list of child nodes (successors) for each vertex
            /// </summary>
            /// <param name="childNodes">children for each node</param>
            public WeightedGraph(List<int>[] ChildNodes, List<double>[] WeightsList, List<int> nstates,List<List<int>> allLocations)
            {
                List<double> theWeights = new List<double>();

                foreach (var point in allLocations)
                { 
                    theWeights.Add(Math.Sqrt((point.First() * point.First()) + point.Last() * point.Last()));
                }
	
                int allLocations_count = allLocations.Count;
                this.WeightsList[0] = theWeights;

                for (int i = 1; i < this.allLocations_count; i++)
                {
                            

                }
	
                this.childNodes = ChildNodes;
                this.WeightsList = WeightsList;
                this.nstates = nstates;
                
                
            }

            /// <summary>
            /// Returns the size of the graph (number of vertices)
            /// </summary>
            public int Size
            {
                get { return this.childNodes.Length; }
            }

            /// <summary>
            /// Adds new edge from u to v
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            public void AddEdge(int u, int v)
            {
                childNodes[u].Add(v);
            }

            /// <summary>
            /// Removes the edge from u to v if such exists
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            public void RemoveEdge(int u, int v)
            {
                childNodes[u].Remove(v);
            }

            /// <summary>
            /// Checks whether there is an edge between vertex u and v
            /// </summary>
            /// <param name="u">the starting vertex</param>
            /// <param name="v">the ending vertex</param>
            /// <returns>true if there is an edge between vertex u and vertex v</returns>
            public bool HasEdge(int u, int v)
            {
                bool hasEdge = childNodes[u].Contains(v);
                return hasEdge;
            }

            public double GetEdgeWeight(int u, int v)
            {
                if (this.HasEdge(u, v))
                {
                    List<int> currentChildNodes = this.GetSuccessors(u).ToList();

                    List<double> currentWeights = WeightsList[u];

                    double foundWeight = double.PositiveInfinity;
                    for (int i = 0; i < currentChildNodes.Count; i++)
                    {
                        if (currentChildNodes[i] == v)
                        {
                            foundWeight = currentWeights[i];
                            break;
                        }
                    }
                    return foundWeight;
                }
                else { return double.PositiveInfinity; }

            }

            /// <summary>
            /// Returns the successors of a given vertex
            /// </summary>
            /// <param name="v">the vertex</param>
            /// <returns>list of all successors of vertex v</returns>
            public IList<int> GetSuccessors(int v)
            {
                return childNodes[v];
            }

            /// <summary>
            /// Returns the cost of moving between state (vertice) j of stage i and state (vertice) k of stage i + 1.
            /// </summary>
            /// <param name="state_j"></param>
            /// <param name="state_k"></param>
            /// <param name="stage_i"></param>
            /// <returns></returns>
            public double GetEdgeCost(int state_j, int state_k, int stage_i)
            {
                if (stage_i >= (this.nstates.Count - 1))
                {
                    throw new Exception("jth stage must be less than index of last stage ");
                }
                List<int> PreviousStages_Counts = this.nstates.GetRange(0, stage_i);
                int IndexOfLastStateFromAllStatesInPreviousStages = PreviousStages_Counts.Sum();

                int u = IndexOfLastStateFromAllStatesInPreviousStages + state_j;


                List<int> Stages_Counts = this.nstates.GetRange(0, stage_i + 1);
                int IndexOfLastStateFromAllStatesUpToCurrentStage = Stages_Counts.Sum();

                int v = IndexOfLastStateFromAllStatesUpToCurrentStage + state_k;

                double EdgeCost = GetEdgeWeight(u, v);
                return EdgeCost;
            }

            /// <summary>
            /// Given the vector nstate whose integer values are the number of states in each stage (1 for the first and last stages),
            /// And also utilised in this routine, a function cost(j,k,i) that returns the cost of moving between state j of stage i
            /// and state k of stage i + 1, this routine returns a vector of the same length as nstate containing the state numbers of the lowest cost path.
            /// Note that states number from 0, and the first and last components of the returned vector will thus always be 0.
            /// </summary>
            /// <returns></returns>
            /// <exception cref="Exception"></exception>
            public List<int> GetShortestPath()
            {
                const double BIG = double.PositiveInfinity;
                const double EPS = double.Epsilon;

                int i, j, k, nstage = nstates.Count - 1;
                double a, b;
                List<int> answer = new int[nstage + 1].ToList();
                List<int> zeroBasedNodesIndex = new List<int>();
                List<int> zeroBasedShortestPathNodes = new List<int>();

                if (nstates[0] != 1 || nstates[nstage] != 1)
                {
                    throw new Exception("One state allowed in first and last stages");
                }

                double[][] best = new double[nstage + 1][]; //Allocate array-of-arrays for storing scores. 
                best[0] = new double[nstates[0]];
                best[0][0] = 0;


                for (i = 1; i <= nstage; i++)    //Forward sweep through stages (left to right)
                {
                    best[i] = new double[nstates[i]];
                    for (k = 0; k < nstates[i]; k++)
                    {
                        b = BIG;
                        for (j = 0; j < nstates[i - 1]; j++) //Find predecessor that gave minimum cost
                        {
                            if ((a = best[i - 1][j] + this.GetEdgeCost(j, k, i - 1)) < b)
                            {
                                b = a;
                            }
                        }
                        best[i][k] = b;  // Find successor least cost
                    }
                }


                answer[nstage] = answer[0] = 0;

                for (i = nstage - 1; i > 0; i--)     //Begin backward track.
                {
                    k = answer[i + 1];

                    b = best[i + 1][k];
                    for (j = 0; j < nstates[i]; j++) //Find the predecessor that gave minimum cost
                    {
                        double temp = best[i][j] + GetEdgeCost(j, k, i);
                        if (Math.Abs(b - temp) < (EPS * Math.Abs(temp)))
                        {
                            answer[i] = j;
                            break;
                        }
                    }

                }

                int cum_StageCountPrevious = 0;
                for (int stage = 0; stage <= nstage; stage++)
                {
                    for (int states = 0; states < nstates[stage]; states++)
                    {
                        if (stage == 0 && states == 0)
                        {
                            zeroBasedNodesIndex.Add(0);
                            cum_StageCountPrevious = nstates[stage];
                            break;
                        }
                        else if (stage > 0 && stage < nstage)
                        {
                            zeroBasedNodesIndex.Add(cum_StageCountPrevious + states);
                            if (states == nstates[stage] - 1)
                            {
                                cum_StageCountPrevious += nstates[stage];
                            }
                        }
                        else if (stage == nstage && states == 0)
                        {
                            zeroBasedNodesIndex.Add(nstates.Sum() - 1);
                            cum_StageCountPrevious = nstates[stage];
                            break;
                        }

                    }

                }

                int cum_prev_StageCounts = 0;
                for (int ans = 0; ans < answer.Count; ans++)
                {
                    if (ans == 0)
                    {
                        zeroBasedShortestPathNodes.Add(0);
                    }
                    else
                    {
                        int previousStageCount = nstates[ans - 1];
                        cum_prev_StageCounts += previousStageCount;
                        zeroBasedShortestPathNodes.Add(cum_prev_StageCounts + answer[ans]);
                    }
                }



                return answer;
            }

        }





        // A C# program for Dijkstra's single source shortest path algorithm.
        // The program is for adjacency matrix representation of the graph
        public class GetShortestNodesPaths
        {
            // A utility function to find the
            // vertex with minimum distance
            // value, from the set of vertices
            // not yet included in shortest
            // path tree

            public int V;

            public int m;
            public int[,] graph;
            public int src;
            public List<int>[] myEdges;
            public List<int>[] childNodes;



            public GetShortestNodesPaths(int[,] graph, int n, int m, int s)
            {
                this.src = s; this.graph = new int[n, n];

                this.V = n; this.m = m;

                this.graph = graph;


            }

            public GetShortestNodesPaths(List<int>[] myEdges, int n, int m, int s)
            {
                this.src = s; this.graph = new int[n, n];

                this.V = n; this.m = m;

                this.myEdges = new List<int>[m]; this.myEdges = myEdges;

                this.childNodes = new List<int>[n];

                for (int i = 0; i < graph.GetLength(0); i++)
                {

                    for (int j = 0; j < this.myEdges.Count(); j++)
                    {
                        if (myEdges[j].Contains(i))
                        {
                            int VertexNumber1_Edge = myEdges[j].First();
                            int VertexNumber2_Edge = myEdges[j].Last();

                            if (i == myEdges[j].First())
                            {
                                this.graph[i, VertexNumber2_Edge] = 6;
                            }

                            if (i == myEdges[j].Last())
                            {
                                this.graph[i, VertexNumber1_Edge] = 6;
                            }
                        }

                    }

                }





            }



            int minDistanceVertex(int[] dist, bool[] sptSet)
            {
                // Initialize min value
                int min = int.MaxValue, min_index = -1;

                for (int v = 0; v < V; v++)
                    if (sptSet[v] == false && dist[v] <= min)
                    {
                        min = dist[v];
                        min_index = v;
                    }

                return min_index;
            }

            // A utility function to print
            // the constructed distance array
            void printSolution(int[] dist)
            {
                //Console.Write("Vertex \t\t Distance "
                //            + "from Source\n");

                for (int i = 0; i < V; i++)
                {
                    if (i == this.src)
                    { continue; }
                    //Console.Write(i + " \t\t " + dist[i] + "\n");
                    Console.Write(dist[i] + " ");
                }
                Console.WriteLine();
            }

            // Function that implements Dijkstra's
            // single source shortest path algorithm
            // for a graph represented using adjacency
            // matrix representation
            public void dijkstra()
            {
                int[] dist = new int[V]; // The output array. dist[i]
                                         // will hold the shortest
                                         // distance from given src to  all i's (the vertices)

                // sptSet[i] will true if vertex
                // i is included in shortest path
                // tree or shortest distance from
                // src to i is finalized
                bool[] sptSet = new bool[V];

                // Initialize all distances as
                // INFINITE and stpSet[] as false
                for (int i = 0; i < V; i++)
                {
                    dist[i] = int.MaxValue;
                    sptSet[i] = false;
                }

                // Distance of source vertex
                // from itself is always 0
                dist[this.src] = 0;


                // Find shortest path for all vertices
                for (int count = 0; count < V - 1; count++)
                {

                    // Pick the minimum distance vertex from the set of vertices not yet
                    // processed. u is always equal to src in first iteration.
                    int u = minDistanceVertex(dist, sptSet);

                    // Mark the picked vertex as processed
                    sptSet[u] = true;


                    // Update dist value of the adjacent
                    // vertices of the picked vertex.
                    for (int v = 0; v < V; v++)
                    {
                        // Update dist[v] only if is not in sptSet, there is an edge from u
                        // to v, and total weight of path from src to v through u is smaller
                        // than current value of dist[v]

                        if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                            dist[v] = dist[u] + graph[u, v];
                    }

                }

                //change the default value for the vertices having no path to the source / start index
                for (int i = 0; i < dist.Length; i++)
                {
                    if (dist[i] == int.MaxValue)
                    {
                        dist[i] = -1;
                    }
                    if (this.src != 0)
                    {
                        dist[this.src] = -1;
                    }
                }

                // print the constructed distance array
                printSolution(dist);
            }



        }
















        /// <summary>
        /// Instantiates and traverses graph based on DFS
        /// </summary>
        public static class GraphTraverserDFS
        {
            public static Graph graph = new Graph(new List<int>[]{new List<int>(){4},           //successors of vertice 0
                                                    new List<int>(){1, 2, 6},                  //successors of vertice 1
                                                    new List<int>(){1, 6},                    //successors of vertice 2
                                                    new List<int>(){6},                      //successors of vertice 3
                                                    new List<int>(){0},                     //successors of vertice 4
                                                    new List<int>(){},                     //successors of vertices 5
                                                    new List<int>(){1,2,3}                //successors of vertices 6
            });

            public static bool[] visited = new bool[graph.Size];

            public static void TraverseDFS(int vertice)
            {
                if (!visited[vertice])
                {
                    Console.Write(vertice + " ");
                    visited[vertice] = true;
                    foreach (int child in graph.GetSuccessors(vertice))
                    {
                        TraverseDFS(child);
                    }
                }
            }


        }



        public static IDictionary<string, int> GetWordOccurrenceMap(string text)
        {

            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');
            IDictionary<string, int> words =
            new SortedDictionary<string, int>();
            foreach (string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if (!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }
            return words;
        }
        public static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccurenceMap)
        {
            foreach (var wordEntry in wordOccurenceMap)
            {
                Console.WriteLine(
                "Word '{0}' occurs {1} time(s) in the text",
                wordEntry.Key, wordEntry.Value);
            }
        }

        public static int GetHammingDistance(string str1, string str2)
        {

            int hammingDistance = 0;


            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        hammingDistance++;
                    }
                }
            }

            return hammingDistance;
        }

        public class Point2D
        {
            private double x;
            private double y;
            private double[] coordinates = new double[2];

            public Point2D(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public Point2D(double[] coordinates)
            {
                this.coordinates = coordinates;
                this.x = coordinates[0];
                this.y = coordinates[1];
            }

            public double X
            {
                get { return this.x; }
                set { this.x = value; }
            }

            public double Y
            {
                get { return this.y; }
                set { this.y = value; }
            }

            public double[] Coordinates { get { return this.coordinates; } set { this.coordinates = value; } }

        }

        public class Point<T> : IComparable<Point<T>> where T : IComparable<T>
        {
            const int DIM = 3;
            public readonly T[] x = new T[DIM];

            public Point(T x0, T x1, T x2)
            {
                this.x[0] = x0;

                if (DIM > 1) this.x[1] = x1;
                if (DIM > 2) this.x[2] = x2;
                if (DIM > 3) throw new Exception("Point not implemented for DIM > 3");
            }

            public Point(T[] x_values)
            {
                this.x = x_values;
            }

            public Point()
            {

            }



            public int CompareTo(Point<T> other)
            {

                if (DIM == 1 && this.x[0].CompareTo(other.x[0]) == 0)
                {
                    return this.x[0].CompareTo(other.x[0]);
                }
                else if (DIM == 2 && this.x[0].CompareTo(other.x[0]) == 0 && this.x[1].CompareTo(other.x[1]) == 0)
                {
                    return this.x[0].CompareTo(other.x[0]);
                }
                else if (DIM == 3 && this.x[0].CompareTo(other.x[0]) == 0 && this.x[1].CompareTo(other.x[1]) == 0 && this.x[2].CompareTo(other.x[2]) == 0)
                {
                    return this.x[0].CompareTo(other.x[0]);
                }

                return -2; //returns a value with a different meaning from the possible return values of IComparable.CompareTo(T other).

            }

            public override bool Equals(object obj)
            {
                Point<T> other = (Point<T>)obj;
                return this.CompareTo(other) == 0;
            }

            public override int GetHashCode()
            {
                return this.x.GetHashCode();
            }

            public static double Dist(ref Point<double> P, ref Point<double> Q)
            {
                double dd = 0;

                for (int j = 0; j < DIM; j++)
                {
                    dd += SQR(Q.x[j] - P.x[j]);
                }

                return Math.Sqrt(dd);
            }

            public static double Dist(ref Point<int> P, ref Point<int> Q)
            {
                double dd = 0;

                for (int j = 0; j < DIM; j++)
                {
                    dd += SQR(Q.x[j] - P.x[j]);
                }

                return Math.Sqrt(dd);
            }

            private static double SQR(double y)
            {
                return y * y;
            }

            private static int SQR(int y)
            {
                return y * y;
            }
        }

        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");
            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }

            if (result.Length > 1)
            {
                result.Remove(result.Length - 2, 2);
                result.Append("]");

            }

            return result.ToString();
        }

        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class AirPlaneSeatingProgram
        {
            public static int[][,] AirPlaneSeats = new int[4][,];
            public int[] compartmentIDs = { 1, 2, 3, 4 };
            public int[] PassengerID;


            private class AirPlaneSeaterObject
            {
                public int[,] compartment;


                public AirPlaneSeaterObject(int rows, int columns)
                {
                    this.compartment = new int[rows, columns];
                }

                private void FillAisleSeatsByCompartment(int compartmentID, int[] PassengerID)
                {

                    switch (compartmentID)//THIS ALGORITHM IS BASED ON COMPARTMENT ID
                    {

                        case 1: //In this compartment, Row First!
                            int startValue1 = 1;
                            this.compartment[0, 2] = startValue1;
                            this.compartment[1, 2] = startValue1 + 2 + 2 + 1 + 1;
                            break;

                        case 2: //In this compartment, Row First!
                            int startValue2 = 2;
                            this.compartment[0, 0] = startValue2;
                            this.compartment[0, 3] = this.compartment[0, 0] + 1;
                            this.compartment[1, 0] = this.compartment[0, 3] + 2 + 1 + 1 + 1;
                            this.compartment[1, 3] = this.compartment[1, 0] + 1;
                            this.compartment[2, 0] = this.compartment[1, 3] + 2 + 1 + 1;
                            this.compartment[2, 3] = this.compartment[2, 0] + 1;
                            break;

                        case 3: //In this compartment, Row First!
                            int startValue3 = 4;
                            this.compartment[0, 0] = startValue3;
                            this.compartment[0, 1] = this.compartment[0, 0] + 1;
                            this.compartment[1, 0] = this.compartment[0, 1] + 1 + 1 + 2 + 1;
                            this.compartment[1, 1] = this.compartment[1, 0] + 1;
                            this.compartment[2, 0] = this.compartment[1, 1] + 1 + 2 + 1;
                            this.compartment[2, 1] = this.compartment[2, 0] + 1;
                            break;

                        case 4: //In this compartment, Row First!
                            int startValue4 = 6;
                            this.compartment[0, 0] = startValue4;
                            this.compartment[1, 0] = this.compartment[0, 0] + 1 + 2 + 2 + 1;
                            this.compartment[2, 0] = this.compartment[1, 0] + 2 + 2 + 1;
                            this.compartment[3, 0] = this.compartment[2, 0] + 1;
                            break;


                    }




                }



            }











            public AirPlaneSeatingProgram(int[][] airPlaneSeaters, int NumberOfPassengers)
            {
                PassengerID = new int[NumberOfPassengers];
                for (int i = 1; i < PassengerID.Length; i++)
                {
                    this.PassengerID[i] = i;
                }
            }

        }

        /// <summary>
        /// Sorts an array arr[0...n-1] into ascending numerical order, by straight insertion.
        /// ArrayToSort array is replaced on output by its sorted arrangement.
        /// </summary>
        /// <param name="ArrayToSort"></param>
        public static void StraightInsertionSort(ref List<int> ArrayToSort)
        {
            int i, j, n = ArrayToSort.Count;
            int a;
            for (j = 1; j < n; j++)
            {
                a = ArrayToSort[j];
                i = j;

                while (i > 0 && ArrayToSort[i - 1] > a)
                {
                    ArrayToSort[i] = ArrayToSort[i - 1];
                    i--;
                }
                ArrayToSort[i] = a;
            }

        }
        public static void StraightInsertionSort(ref List<double> ArrayToSort)
        {
            int i, j, n = ArrayToSort.Count;
            double a;
            for (j = 1; j < n; j++)
            {
                a = ArrayToSort[j];
                i = j;
                while (i > 0 && ArrayToSort[i - 1] > a)
                {
                    ArrayToSort[i] = ArrayToSort[i - 1];
                    i--;
                }
                ArrayToSort[i] = a;
            }

        }

        public static void StraightInsertionSortPair(ref List<double> ArrayToSort, ref List<double> ArrayToSort2)
        {
            int i, j, n = ArrayToSort.Count;
            double a;
            double b;
            for (j = 1; j < n; j++)
            {
                a = ArrayToSort[j];
                b = ArrayToSort2[j];
                i = j;
                while (i > 0 && ArrayToSort[i - 1] > a)
                {
                    ArrayToSort[i] = ArrayToSort[i - 1];
                    ArrayToSort2[i] = ArrayToSort2[i - 1];
                    i--;
                }
                ArrayToSort[i] = a;
                ArrayToSort2[i] = b;
            }

        }

        /// <summary>
        /// Sort an array a[0..n-1] into ascending numerical order by Shell’s method (diminishing increment sort).
        /// a is replaced on output by its sorted rearrangement. Normally, the optional
        ///argument m should be omitted, but if it is set to a positive value, then only the first m elements are sorted.
        /// </summary>
        /// <param name="ArrayToSort"></param>
        /// <param name="m"></param>
        public static void ShellSort(ref List<double> ArrayToSort, int m = -1)
        {

            int i, j, inc, n = ArrayToSort.Count();
            double v;
            if (m > 0) n = Math.Min(m, n); //Use optional argument.
            inc = 1; //Determine the starting increment.
            do
            {
                inc *= 3;
                inc++;
            } while (inc <= n);

            do
            {
                inc /= 3;
                for (i = inc; i < n; i++)
                {
                    //Outer loop of straight insertion.
                    v = ArrayToSort[i];
                    j = i;
                    while (ArrayToSort[j - inc] > v)
                    {
                        //Inner loop of straight insertion.
                        ArrayToSort[j] = ArrayToSort[j - inc];
                        j -= inc;
                        if (j < inc) break;
                    }

                    ArrayToSort[j] = v;
                }

            } while (inc > 1);


        }

        /// <summary>
        /// Sort an array arr[0..n-1] into ascending numerical order using the Quicksort algorithm. arr
        /// is replaced on output by its sorted rearrangement. Normally, the optional argument m should be
        /// omitted, but if it is set to a positive value, then only the first m elements of arr are sorted.
        /// </summary>
        /// <param name="arr"></param>
        public static void QuickSort(ref List<double> arr, int m = -1)
        {

            const int M = 7, NSTACK = 64;

            //Here M is the size of subarrays sorted by straight insertion and NSTACK is the required
            //auxiliary storage.
            int i, ir, j, k, jstack = -1, l = 0, n = arr.Count();
            double a;
            List<int> istack = new int[NSTACK].ToList();
            if (m > 0) n = Math.Min(m, n); //Use optional argument.
            ir = n - 1;
            for (; ; )
            {
                //Insertion sort when subarray small enough.
                if (ir - l < M)
                {
                    for (j = l + 1; j <= ir; j++)
                    {
                        a = arr[j];
                        for (i = j - 1; i >= l; i--)
                        {
                            if (arr[i] <= a) break;
                            arr[i + 1] = arr[i];
                        }
                        arr[i + 1] = a;
                    }
                    if (jstack < 0) break;
                    ir = istack[jstack--]; //Pop stack and begin a new round of partil = istack[jstack--]; tioning.
                }
                else
                {
                    k = (l + ir) >> 1; //Choose median of left, center, and right elements as partitioning element a. Also
                                       //rearrange so that a[l]  a[l + 1]  a[ir].
                    SWAP(ref arr, k, l + 1);
                    if (arr[l] > arr[ir])
                    {
                        SWAP(ref arr, l, ir);
                    }
                    if (arr[l + 1] > arr[ir])
                    {
                        SWAP(ref arr, l + 1, ir);
                    }
                    if (arr[l] > arr[l + 1])
                    {
                        SWAP(ref arr, l, l + 1);
                    }
                    i = l + 1; //Initialize pointers for partitioning.
                    j = ir;
                    a = arr[l + 1]; //Partitioning element.
                    for (; ; )
                    {
                        //Beginning of innermost loop.
                        do i++; while (arr[i] < a); //Scan up to find element > a.
                        do j--; while (arr[j] > a); //Scan down to find element < a.
                        if (j < i) break; //Pointers crossed. Partitioning complete.
                        SWAP(ref arr, i, j); //Exchange elements.
                    }
                    //End of innermost loop.
                    arr[l + 1] = arr[j]; //Insert partitioning element.
                    arr[j] = a;
                    jstack += 2;
                    //Push pointers to larger subarray on stack; process smaller subarray immediately
                    if (jstack >= NSTACK) throw new Exception("NSTACK too small in sort.");
                    if (ir - i + 1 >= j - l)
                    {
                        istack[jstack] = ir;
                        istack[jstack - 1] = i;
                        ir = j - 1;
                    }
                    else
                    {
                        istack[jstack] = j - 1;
                        istack[jstack - 1] = l;
                        l = i;
                    }


                }
            }
        }

        public static string isBalanced(string s)
        {

            int sLength = s.Length;
            if ((sLength % 2) != 0)
            {
                return "NO";
            }

            List<char> s_chars = s.ToCharArray().ToList();
            Stack<char> s_charStacks = new Stack<char>();
            s_chars.ForEach(i => s_charStacks.Push(i));//List-wise transfer to a stack.

            Dictionary<char, char> bracketsMap = new Dictionary<char, char>();
            bracketsMap.Add('{', '}'); bracketsMap.Add('[', ']'); bracketsMap.Add('(', ')');

            while (s_charStacks.Count > 1)
            {
                char popped_Last = s_charStacks.Pop();
                char peekedOne = s_charStacks.Peek();
                if (bracketsMap.ContainsValue(popped_Last)) // last must be  a value
                {
                    if (bracketsMap.ContainsKey(peekedOne)) //check if next is a key
                    {
                        bracketsMap.TryGetValue(peekedOne, out char checkValue);
                        if (checkValue == popped_Last)
                        {//Then the key form a key-value pair with the last popped value.

                            s_charStacks.Pop();// So pop the peeked one as well.
                            if (s_charStacks.Count == 0)
                            {
                                return "YES";
                            }
                            else { continue; }

                        }
                        else { return "NO"; }//Wrongly placed key.

                    }
                    else
                    {   //Next value from the right is not a key. it is a value.
                        //Therefore Remove the first key (from the right) for which the
                        //last popped value makes a key-value pair.

                        char poppedLast_Key = '\u0000'; //Default value for char.
                        foreach (var bracketPair in bracketsMap)
                        {
                            if (bracketPair.Value == popped_Last)
                            {
                                poppedLast_Key = bracketPair.Key;
                                break;//could have other values with the same key.
                            }
                        }
                        List<char> currentChars = new List<char>();
                        currentChars = s_charStacks.ToList(); //stackwise transfer to a list(last one - first in)

                        //reverse for possible removal and finding of sub-brackets
                        currentChars.Reverse();

                        int indexLeftToRight = IndexOfOpeningBracket(poppedLast_Key, currentChars);

                        if (indexLeftToRight == -1)//bracket not balanced.
                        {
                            return "NO";
                        }
                        else
                        {
                            //gets the right-to-left based index for sub-brackets checking
                            int indexOfKeyFromRightToLeft = currentChars.Count - indexLeftToRight - 1;


                            if (indexOfKeyFromRightToLeft > 1) //there may be sub-brackets existing
                            {
                                //Remove from left to right, the value of the item at this index
                                currentChars.RemoveAt(indexLeftToRight);

                                List<string> new_sList = currentChars.Select(i => i.ToString()).ToList();
                                string new_s = string.Join("", new_sList);
                                string result = isBalanced(new_s);
                                if (result == "NO") return result;
                            }

                            s_charStacks.Clear();
                            currentChars.ForEach(i => s_charStacks.Push(i));
                            continue;
                        }

                    }
                }
                else { return "NO"; }

            }


            return null;
        }

        //Conditional Method
        private static int IndexOfOpeningBracket(char OpeningBracket, List<char> Characters)
        {
            List<char> CharctersCopy = new List<char>();
            CharctersCopy = Characters;

            int index = CharctersCopy.LastIndexOf(OpeningBracket);
            if (index == -1) return index;
            if (index == 0) return index;
            else
            {
                while (index > 0 && index < CharctersCopy.Count)
                {

                    if (OpeningBracket == CharctersCopy[index] && index % 2 == 0)
                    {//It exists. its even we are good!
                        return index;

                    }
                    else if (OpeningBracket == CharctersCopy[index] && index % 2 != 0)
                    {//It exists but its odd. return the next preceeding index of "Opening Bracket".
                        List<char> subSet = new List<char>(); subSet = CharctersCopy;
                        subSet.RemoveRange(index, CharctersCopy.Count - index);
                        index = subSet.LastIndexOf(OpeningBracket);
                        return index;
                    }
                    else { index--; } //No luck currently. Try again.


                }
            }

            return index;
        }






        public static void SWAP(ref List<double> arr, int i, int j)
        {
            double x = arr[i];
            double y = arr[j];

            double temp = x;
            arr[i] = y;
            arr[j] = temp;
        }

        public static void SWAP(ref double[] arr, int i, int j)
        {
            double x = arr[i];
            double y = arr[j];

            double temp = x;
            arr[i] = y;
            arr[j] = temp;
        }

        public static void SWAP(ref int[] arr, int i, int j)
        {
            int x = arr[i];
            int y = arr[j];

            int temp = x;
            arr[i] = y;
            arr[j] = temp;
        }


        public static void sift_down(ref List<double> ra, int l, int r)
        //Carry out the sift-down on element ra(l) to maintain the heap structure.l and r determine
        //the “left” and “right” range of the sift-down.
        {
            int j, jold;
            double a;
            a = ra[l];
            jold = l;
            j = 2 * l + 1;
            while (j <= r) {
                if (j < r && ra[j] < ra[j + 1]) j++; //Compare to the better underling.
                if (a >= ra[j]) break; //Found a’s level.Terminate the siftdown.Otherwise, demote a and continue.
                ra[jold] = ra[j];
                jold = j;
                j = 2 * j + 1;
            }
            ra[jold] = a; //Put a into its slot.
        }

        public static void hpsort(ref List<double> ra)
        //Sort an array ra[0..n - 1] into ascending numerical order using the Heapsort algorithm.ra is
        //replaced on output by its sorted rearrangement.
        {
            int i, n = ra.Count();
            for (i = n / 2 - 1; i >= 0; i--)//NEEDS TO BE INVESTIGATED
                                            //            The index i, which here determines the “left” range of the sift-down, i.e., the element
                                            //to be sifted down, is decremented from n / 2 - 1 down to 0 during the “hiring” (heap
                                            //creation) phase.
                sift_down(ref ra, i, n - 1);
            for (i = n - 1; i > 0; i--)
            {
                //Here the “right” range of the sift-down is decremented from n - 2 down to 0 during the
                //“retirement - and - promotion” (heap selection) phase.
                SWAP(ref ra, 0, i); //Clear a space at the end of the array, and retire
                                    //hpsort_util::sift_down(ra, 0, i - 1); the top of the heap into it.
            }
        }

        public static double RunningMedian(List<double> RunningList, double newmember)
        {
            if (RunningList.Count == 0) RunningList.Add(newmember);
            else
            {
                int i = RunningList.FindIndex(d => d > newmember);
                RunningList.Insert(i,newmember);
            }
            double ii = RunningList.Count - 1;
            ii /= 2;

            if ((int)ii == ii)
            {
                return RunningList[(int)ii];
            }
            else { return (RunningList[(int)ii] + RunningList[(int)ii + 1]) / 2; };

        }


        public class Contacts 
        {
            public List<string> strings = new List<string>();

            public void Add(string name) 
            {
                strings.Add(name);
            }

            public int Find(string partial) 
            {
                int count = 0;
                foreach (string s in strings)
                    if (s.IndexOf(partial) >= 0)
                        count++;
                return count;
            }
        
        }

        public class KnapSack_Table
        {
            private readonly List<double>[] Table;
            List<double> Weights;
            List<double> Values;
            IEnumerable<string> ItemNames;

            public KnapSack_Table(List<double> values, List<double> weights, List<string> itemNames, int KnapSackCapacity)
            {
                this.Table = new List<double>[weights.Count]; this.Values = values; this.Weights = weights;
                this.ItemNames = itemNames;

                for (int i = 0; i < this.Weights.Count; i++)
                {
                    for (int j = 1; j <= KnapSackCapacity; j++)
                    {
                        double C = 0; C++;
                        List<double> possibleWeights = new List<double>();
                        possibleWeights = Weights.FindAll(x => x > C);

                        List<double> possibleValues = new List<double>();   
                        
                    }
                }


            }
            private bool predi(double x) 
            { 
                
                return false;
            }
            
        }

    }

        
}

    


