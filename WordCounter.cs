using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class WordCounter
    {
        public delegate void WordCountChangedEventHandler(int newWordCount);
        public event WordCountChangedEventHandler WordCountChanged;

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnWordCountChanged();
            }
        }

        public WordCounter(string text)
        {
            _text = text;
        }

        private void OnWordCountChanged()
        {
            WordCountChanged?.Invoke(_text.WordCount());
        }
    }
}