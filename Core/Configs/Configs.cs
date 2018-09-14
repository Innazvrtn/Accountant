using Core.Encription;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Core.Configs
{
    public class Configs : IEnumerable<Config>
    {
        #region Fields&Properties

        private static List<Config> configs;

        #endregion

        #region Constructors

        private Configs()
        {
            configs = new List<Config>();

            Init();
        }

        void Init()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                 + "\\AccountantDesktop\\config\\" + FileStrings.ConfigFileName);

            if (File.Exists(filePath))
            {
                string text = "";

                using (var decryptor = new Decryptor())
                {
                    text = decryptor.Decrypt(File.ReadAllText(filePath));
                }

                configs = JsonConvert.DeserializeObject<List<Config>>(text);
            }
            else
            {
                if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AccountantDesktop\\config")))
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AccountantDesktop\\config"));
                File.WriteAllText(filePath, FileStrings.StartConfig);
            }
        }

        #endregion

        #region SingletonItems

        private static Configs instance;

        public static Configs GetInstance()
        {
            if (instance == null)
                instance = new Configs();
            return instance;
        }

        #endregion

        #region IEnumerable methods

        public Config this[string name]
        {
            get
            {
                return configs.FirstOrDefault(c => c.Name == name);
            }
        }

        public IEnumerator<Config> GetEnumerator()
        {
            foreach (var config in configs)
            {
                yield return config;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var config in configs)
            {
                yield return config;
            }
        }

        public void Add(string name, string value)
        {
            if (configs.Where(c => c.Name == name).Count() > 0)
                configs.FirstOrDefault(c => c.Name == name).Value = value;
            else
                configs.Add(new Config() { Name = name, Value = value });
        }

        public void Add(Config config)
        {
            if (configs.Where(c => c.Name == config.Name).Count() > 0)
                configs.FirstOrDefault(c => c.Name == config.Name).Value = config.Value;
            else
                configs.Add(config);
        }

        public void SaveChanges()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                 + "\\AccountantDesktop\\config\\" + FileStrings.ConfigFileName);

            if (File.Exists(filePath))
            {
                string text = JsonConvert.SerializeObject(configs);

                using (var encryptor = new Encryptor())
                {
                    File.WriteAllText(filePath, encryptor.Encrypt(text));
                }
            }
            else
                throw new FileNotFoundException("Can not find config file");
        }

        #endregion
    }
}
