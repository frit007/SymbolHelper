using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper.Storage {
    class SettingsStorage {
        private static SettingsStorage instance = new SettingsStorage();

        public static SettingsStorage getInstance() {
            return instance;
        }

        private Settings settings = new Settings();
        public event Action<Settings> settingsUpdated;

        public void update(Settings newSettings) {
            this.settings = newSettings;
            settingsUpdated?.Invoke(newSettings);
        }

        public Settings getSettings() {
            return settings;
        }
    }
}
