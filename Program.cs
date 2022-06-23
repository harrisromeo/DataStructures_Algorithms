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

            // IDictionary<String, int> wordOccurrenceMap = GetWordOccurrenceMap(Text);
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
            ////tree.PrintTreeDFS();
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
            public Tree(T value, params Tree<T>[] children):this(value)
            {
                foreach (Tree<T> child in children)
                {
                    this.root.AddChild(child.root);
                }
            }

            /// <summary>
            /// the root node or null if the root is empty
            /// </summary>
            public TreeNode<T> Root { get { return this.root;} }

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
                    TraverseDir(child,spaces + " ");
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
            public BinaryTree(T value):this(value,null, null)
            {
                
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

                internal void Insert(T t, object value)
                {
                    throw new NotImplementedException();
                }
            }

            /// <summary>
            /// The root of the tree
            /// </summary>
            private BinaryTreeNode<T> root;

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



            //SEARCH
            /// <summary>Finds a given value in the tree and
            /// return the node which contains it if such exists
            /// </summary>
            /// <param name="value">the value to be found</param>
            /// <returns>the found node or null if not found</returns>
            private BinaryTreeNode<T> Find(T value)
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
                                this.compartment[3,0] = this.compartment[2, 0] + 1;
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

        
    }

        
}

    


