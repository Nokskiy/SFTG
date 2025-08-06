using System;
using System.IO;
using Newtonsoft.Json;
using SFTG.API;

public static class FileManager
{
    private readonly static string SpecialFolderName = ".SFTG";
    private readonly static string ConfigFileName = ".config.json";

    public static string SpecialFoledPath
    {
        get
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), SpecialFolderName);
            if (!Path.Exists(path)) Directory.CreateDirectory(path);
            return path;
        }
    }
    public static string ConfigurationPath
    {
        get
        {
            string path = Path.Combine(SpecialFoledPath, ConfigFileName);
            if (!Path.Exists(path)) File.Create(path).Close();
            return path;
        }
    }

    public static Configuration ReadConfiguration => JsonConvert.DeserializeObject<Configuration>(ConfigurationPath);
    public static void SaveConfiguration(Configuration newConfig)
    {
        File.WriteAllText(ConfigurationPath, JsonConvert.SerializeObject(newConfig, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Serialize }));
    }
}