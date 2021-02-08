using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keysArray;
        TValue[] valuesArray;
        public MyDictionary()
        {
            keysArray = new TKey[0];
            valuesArray = new TValue[0];
        }
        public TValue this[TKey i]
        {
            get 
            {
                return valuesArray[FindIndex(i)];
            }
            set
            {
                valuesArray[FindIndex(i)] = value;
            }
        }
        public void Add(TKey keyItem, TValue valueitem)
        {
            TKey[] tempKeys = keysArray;
            TValue[] tempValues = valuesArray;
            keysArray = new TKey[keysArray.Length + 1];
            valuesArray = new TValue[valuesArray.Length + 1];
            Array.Copy(tempKeys, keysArray, tempKeys.Length);
            Array.Copy(tempValues, valuesArray, tempValues.Length);
            keysArray[keysArray.Length - 1] = keyItem;
            valuesArray[valuesArray.Length - 1] = valueitem;
        }
        private int FindIndex(TKey i)
        {
            int j = 0;
            for (; j < keysArray.Length; j++)
            {
                if (keysArray[j].Equals(i))
                {
                    break;
                }
            }
            return j;
        }
    }
}