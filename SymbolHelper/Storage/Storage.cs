using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SymbolHelper.Storage {
    class StorageJSON {
        public Settings settings { get; set; }
        public List<Word> words { get; set; }
    }
    class Storage {

        private static Storage instance = new Storage();
        static string folder = AssemblyDirectory;
        private static string file = Path.Combine(folder, "words.json");

        public static string AssemblyDirectory {
            get {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static Storage getInstance() {
            return instance;
        }

        public Storage() {
        }

        private System.Timers.Timer saveTimer;

        public void StartSaveTimer() {
            saveTimer.Stop();
            saveTimer.Start();
        }

        public void Setup() {
            Load();

            saveTimer = new System.Timers.Timer();
            // save 5s after last change
            saveTimer.Interval = 1000 * 5;
            saveTimer.Elapsed += onSaveTimerExpire;

            var wordStorage = WordStorage.getInstance();
            wordStorage.wordDeleted += (_) => {
                StartSaveTimer();
            };
            wordStorage.wordsUpdated += (_) => {
                StartSaveTimer();
            };
            wordStorage.wordUpdated+= (_) => {
                StartSaveTimer();
            };
            SettingsStorage.getInstance().settingsUpdated += (_) => {
                StartSaveTimer();
            };
        }

        public void onSaveTimerExpire(object _, ElapsedEventArgs _2) {
            saveTimer.Stop();
            Save();
        }

        public void Load() {
            try {
                var serialized = System.IO.File.ReadAllText(file);
                var json = JsonConvert.DeserializeObject<StorageJSON>(serialized);

                SettingsStorage.getInstance().update(json.settings);
                WordStorage.getInstance().LoadWords(json.words);
            } catch(Exception e) {
                Console.WriteLine("Could not load file because it doesn't exist");
            }
        }

        public void Save() {
            Console.WriteLine("Saving changes...");
            var serialized = JsonConvert.SerializeObject(new StorageJSON() {
                settings = SettingsStorage.getInstance().getSettings(), 
                words = WordStorage.getInstance().getWords()
            });

            System.IO.Directory.CreateDirectory(folder);
            System.IO.File.WriteAllText(file, serialized);
            Console.WriteLine("Changes saved!");
        }
    }
}
