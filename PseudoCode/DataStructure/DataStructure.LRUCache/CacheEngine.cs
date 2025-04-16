using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LRUCache
{
    public class CacheEngine<x,y>
    {
        private int _cacheLimit = 10;
        private Dictionary<x, y> _cache;
        private LinkedList<x> _lruList;

        public CacheEngine()
        {
            _cache = new Dictionary<x, y>();
            _lruList = new LinkedList<x>();
        }

        public y Get(x key)
        {
            if (_cache.ContainsKey(key))
            {
                EvictCache(key);
                return _cache[key];
            }
            else
                return default(y);
        }

        public void Add(x key, y value)
        {
            if (!_cache.ContainsKey(key))
            {
                _cache.Add(key, value);
                
            }
            else
            {
                _cache[key] = value;
            }
            EvictCache(key);
        }

        private void EvictCache(x key)
        {
            if(_lruList.Count >= _cacheLimit)
            {
                var keyToRemove = _lruList.Last;
                _lruList.RemoveLast();
                if (_cache.ContainsKey(keyToRemove.Value))
                    _cache.Remove(keyToRemove.Value);
            }
            _lruList.Remove(key);
            _lruList.AddFirst(key);
        }

    }
}
