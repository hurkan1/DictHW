using System;
using System.Collections.Generic;
using System.Text;

namespace DictHW
{
    class MyDict <Tkeys, Tvalues>
    {
        Tkeys[] keys;
        Tvalues[] values;

        public MyDict()
        {
            keys = new Tkeys[0];
            values = new Tvalues[0];
        }

        public void Add(Tkeys key, Tvalues value)
        {
            Tkeys[] tempkeys = keys;
            Tvalues[] tempvalues = values;

            keys = new Tkeys[keys.Length + 1];
            values = new Tvalues[values.Length + 1];

            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
            }

            for (int i = 0; i < tempvalues.Length; i++)
            {
                values[i] = tempvalues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void Items()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Ders kodu: " + keys[i] + "Ders Adı: " + values[i]);
                Console.WriteLine("----Ders eklenmiştir!----");
            }
        }
    }


}
