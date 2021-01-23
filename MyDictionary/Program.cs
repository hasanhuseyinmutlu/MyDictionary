using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(434, "Hasan Hüseyin Mutlu");
            Ogrenci.Add(234, "Ahmet Kıyar");
            Ogrenci.Add(123, "Mehmet Kır");
        }
    }
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            for (int j = 0; j < tempKeys.Length; j++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key cannot be null.");
                }
                else if (tempKeys[j].Equals(key))
                {
                    throw new ArgumentException("An element with the same key already exists in key array");
                }
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void GetAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
        }

    }
}
