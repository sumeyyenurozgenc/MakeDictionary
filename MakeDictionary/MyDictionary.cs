using System;
using System.Collections.Generic;
using System.Text;

namespace MakeDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = _key;
            TValue[] tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;

        }
    }
}
