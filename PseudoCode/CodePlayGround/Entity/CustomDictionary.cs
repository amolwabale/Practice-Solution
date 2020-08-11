using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround.Entity
{
    public class CustomDictionarys<TKey, TValue> 
    {
        private List<KeyValuePair<TKey, TValue>> _keyVal;

        public CustomDictionarys()
        {
            _keyVal = new List<KeyValuePair<TKey, TValue>>();
        }
       
        public void Add(TKey key, TValue value)
        {
            _keyVal.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        
    }
}
