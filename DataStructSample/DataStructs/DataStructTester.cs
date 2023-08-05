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
    }
}