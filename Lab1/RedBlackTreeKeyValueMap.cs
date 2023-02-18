using DSA.DataStructures.Trees;
using System;
using System.Collections.Generic;

namespace Lab1
{
    //TODO
    public class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> redblackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => redblackTreeMap.Height;

        public int Count => redblackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            redblackTreeMap.Add(key, value);
        }

        public void Clear()
        {
            redblackTreeMap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            redblackTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (redblackTreeMap.ContainsKey(key))
            {
                redblackTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}