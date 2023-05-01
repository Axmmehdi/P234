//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CustomList.COre
//{
//    class CustomList<T>
//    {
//        private List<T> items;

//        public CustomList()
//        {
//            items = new List<T>();
//        }

//        public void Add(T item)
//        {
//            items.Add(item);
//        }

//        public T Find(Predicate<T> match)
//        {
//            return items.Find(match);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CustomList<int> list = new CustomList<int>();
//            list.Add(1);
//            list.Add(2);
//            list.Add(3);

//            int result = list.Find(x => x == 2);

//            Console.WriteLine(result); // Output: 2
//            Console.WriteLine(list.Find(x => x == 4)); // Output: null
//        }
//    }

//}
