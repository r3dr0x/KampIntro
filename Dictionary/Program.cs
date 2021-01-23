using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryODev
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Uye = new Dictionary<int, string>();

            MyDictionary<int, string> YeniUye = new MyDictionary<int, string>();
            YeniUye.Add(01, "Ecem");
            YeniUye.Add(02, "Emre");

        }
    }
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] key;
        Tvalue[] value;

        public MyDictionary()
        {
            key = new Tkey[0];
            value = new Tvalue[0];
        }
        public void Add(Tkey keys, Tvalue values)
        {
            Tkey[] tempKey = key;
            Tvalue[] tempValue = value;

            key = new Tkey[key.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }
            key[key.Length - 1] = keys;

            value = new Tvalue[value.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
            }
            value[value.Length - 1] = values;





        }
    }
}