namespace DataStructSample
{
    public class DataStructTester
    {
        #region LISTS

        public void IterateList(List<int> list)
        {
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"List[{i}]: {list[i]}");
                }
            }
        }

        public List<int> AddElements(List<int> source, int[] elements)
        {
            List<int> result;

            if (source == null)
            {
                result = new List<int>();
            }
            else
            {
                result = new List<int>(source);
            }

            if (elements != null && elements.Length > 0)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    result.Add(elements[i]);
                }
            }

            return result;
        }

        #endregion LISTS

        public void IterateList(int[] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"List[{i}]: {arr[i]}");
                }
            }
        }

        public int[] AddElements(int[] source, int[] elements)
        {
            int[] result;

            if (source == null)
            {
                result = new int[0];
            }
            else
            {
                result = source;
            }

            if (elements != null && elements.Length > 0)
            {
                result = new int[source.Length + elements.Length];

                for (int i = 0; i < source.Length; i++)
                {
                    result[i] = source[i];
                }

                for (int i = 0; i < elements.Length; i++)
                {
                    result[i + source.Length] = elements[i];
                }
            }

            return result;
        }

        #region QUEUE

        public bool IsElementInCollection(string str, Queue<string> queue)
        {
            bool result = false;

            do
            {
                result = str.Equals(queue.Dequeue()); //str == queue.Dequeue();
            }
            while (!result && queue.Count > 0);

            return result;
        }

        public void Populate(string[] strs, Queue<string> queue)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                queue.Enqueue(strs[i]);
            }
        }

        #endregion QUEUE

        public bool IsElementInCollection(string str, Stack<string> stack)
        {
            bool result = false;

            do
            {
                result = str.Equals(stack.Pop()); //str == stack.Pop();
            }
            while (!result && stack.Count > 0);

            return result;
        }

        public void Populate(string[] strs, Stack<string> stack)
        {
            foreach (string str in strs)
            {
                stack.Push(str);
            }
        }

        public Dictionary<int, string> CreateDictionary(int[] ids, string[] names)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            //int dictLength = Math.Min(ids.Length, names.Length);
            //int dictLength = (ids.Length < names.Length) ? ids.Length : names.Length;

            int dictLength = 0;

            if (ids.Length < names.Length)
            {
                dictLength = ids.Length;
            }
            else
            {
                dictLength = names.Length;
            }

            for (int i = 0; i < dictLength; i++)
            {
                result.Add(ids[i], names[i]);
            }

            return result;
        }

        public void PrintDictionary(Dictionary<int, string> dict)
        {
            if (dict.Count < 1)
            {
                Console.WriteLine("dict is empty");
            }
            else
            {
                foreach (var registry in dict)
                {
                    Console.WriteLine(registry.ToString());
                }
            }
        }

        public bool IsValueInDictionary(string val, Dictionary<int, string> dict)
        {
            bool result = false;

            //foreach (var key in dict.Keys)
            //{
            //    result = dict[key] == val;

            //    if (result)
            //    {
            //        break;
            //    }
            //}

            foreach (var dictValue in dict.Values)
            {
                result = val == dictValue;

                if (result)
                {
                    break;
                }
            }

            return result;
        }
    }
}