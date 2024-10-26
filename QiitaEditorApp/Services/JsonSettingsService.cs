using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QiitaEditorApp.Services
{
    public class JsonSettingsManager
    {
        private readonly string _filePath;
        private Dictionary<string, string> _settings;

        public JsonSettingsManager(string filePath)
        {
            _filePath = filePath;
            _settings = new Dictionary<string, string>();

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(_settings, Formatting.Indented));
            }

            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
        }

        public void Add(string key, string value)
        {
            if (!_settings.ContainsKey(key))
            {
                _settings[key] = value;
                Save();
            }
            else
            {
                throw new Exception("Key already exists.");
            }
        }

        public string Read(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : null;
        }

        public void Update(string key, string value)
        {
            if (_settings.ContainsKey(key))
            {
                _settings[key] = value;
                Save();
            }
            else
            {
                throw new Exception("Key does not exist.");
            }
        }

        public void Delete(string key)
        {
            if (_settings.ContainsKey(key))
            {
                _settings.Remove(key);
                Save();
            }
            else
            {
                throw new Exception("Key does not exist.");
            }
        }
        public bool ExistsKey(string key)
        {
            return _settings.ContainsKey(key);
        }

        private void Save()
        {
            var json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
