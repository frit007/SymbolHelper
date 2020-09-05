using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper.Storage {
    class WordStorage {
        private static WordStorage instance = new WordStorage();
        public static WordStorage getInstance() {
            return instance;
        }

        // send all words whenever the collection is modified in any way
        // this might prove to be too slow
        public event Action<List<Word>> wordsUpdated;
        public event Action<Word> wordUpdated;
        public event Action<Word> wordDeleted;

        private List<Word> words = new List<Word>();
        

        public List<Word> getWords() {
            return words;
        }


        public void LoadWords(List<Word> words) {
            this.words = words;
            wordsUpdated?.Invoke(words);
        }

        public int getNextId() {
            if(words.Count == 0) {
                return 1;
            }
            return words.Max(word => word.Id) + 1;
        }

        public void AddWord(Word newWord) {
            words.Add(newWord);
            wordUpdated?.Invoke(newWord);
        }

        public void removeWord(int id) {
            Word word = words.Find(w => w.Id == id);

            if(word != null) {
                words.Remove(word);
                wordDeleted?.Invoke(word);
            }
        }

        public void UpdateWord(Word updatedWord) {
            words.Select((word) => {
                if (word.Id == updatedWord.Id) {
                    return updatedWord;
                } else {
                    return word;
                }
            });

            wordUpdated?.Invoke(updatedWord);
        }

        internal Word getWordById(int id) {
            return words.Find(w => w.Id == id);
        }
    }
}
