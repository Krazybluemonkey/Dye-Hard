using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace DyeHard
{
    public static class Config
    {
        public static string DyeAcquisition = "craft";

        //The file will be stored in "Terraria/ModLoader/Mod Configs/Example Mod.json"
        static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "Dye Hard.json");

        static Preferences Configuration = new Preferences(ConfigPath);

        public static void Load()
        {
            //Reading the config file
            bool success = ReadConfig();

            if(!success)
            {
                ErrorLogger.Log("Failed to read Dye Hard's config file! Recreating config...");
                CreateConfig();
            }
        }

        //Returns "true" if the config file was found and successfully loaded.
        static bool ReadConfig()
        {
            if(Configuration.Load())
            {
                Configuration.Get("DyeAcquisition", ref DyeAcquisition);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid. 
        static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("DyeAcquisition", DyeAcquisition);
            Configuration.Save();
        }
    }
}