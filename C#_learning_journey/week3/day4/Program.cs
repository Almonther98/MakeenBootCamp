namespace Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arr<int> a = new arr<int>();    

            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Revers();
            a.Display();

        }
    }


    public class arr<T>
    {
        public T[] items;



        public void Add(T item)
        {
            if (items == null)
            {
                items = new T[] {item};
            }
            else
            {
                T[] temp = new T[items.Length +1] ;

                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                temp[temp.Length - 1] = item;
                items = temp;
            }
        }

        public void RemoveAt(int idx)
        {
            T[] temp = new T[items.Length - 1];
            int pos = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (i == idx) { continue; }
                temp[pos++] = items[i];
            }
            items = temp;

        }

        public bool IsEmpty() => items.Length == 0;
        public int Count() => items.Length ;

        public void Display()
        {
            foreach (T item in items) { Console.Write(item+" "); }
        }

        public void AddAtFirst(T item)
        {
            if (items == null)
            {
                items = new T[] { item };
            }
            else
            {
                T[] temp = new T[items.Length + 1];

                for (int i = temp.Length-1 ; i >0 ; i--)
                {
                    temp[i] = items[i-1];
                }
                temp[0] = item;
                items = temp;
            }
        }

        public  void Cler() { items = new T[] { }; }


        public void Revers()
        {
            T[] temp = new T[items.Length];
            int pos = items.Length-1;
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = items[pos--];
            }
            items = temp;
        }

    }



}