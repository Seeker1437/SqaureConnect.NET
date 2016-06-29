using System;
using System.Collections;
using System.Collections.Generic;

namespace SquareConnect.Util
{
    public class SimpleNamedValueCollection : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly List<KeyValuePair<string, string>> _namedValuePairs;

        public SimpleNamedValueCollection()
        {
            _namedValuePairs = new List<KeyValuePair<string, string>>();
        }

        public void Add(string key, string value)
        {
            Remove(key);

            _namedValuePairs.Add(new KeyValuePair<string, string>(key, value));
        }

        public bool Remove(string key)
        {
            return _namedValuePairs.RemoveAll(kvPair => kvPair.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)) > 0;
        }

        public string Get(string key, string @default = null)
        {
            foreach (KeyValuePair<string, string> namedValuePair in _namedValuePairs)
            {
                if (namedValuePair.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase))
                {
                    return namedValuePair.Value;
                }
            }

            return @default;
        }

        public string this[string index]
        {
            get { return Get(index); }
            set { Add(index, value); }
        }


        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, string>>)_namedValuePairs).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
