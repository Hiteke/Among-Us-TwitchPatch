using System;
using System.IO;

namespace TwitchPatch
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Patch Created by Hiteke#8281\n");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Remove(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Length - 7), "LocalLow\\Innersloth\\Among Us\\secureNew");
			Console.WriteLine("Savefile path: " + text);
			Console.WriteLine("\nCreating backup...");
			File.Copy(text, text + "_bak");
			Console.WriteLine("Patching file...");
			File.AppendAllText(text, "/OI]uLIBHI8AWGkASDL");
			Console.WriteLine("\nPatching done, enjoy your Twitch Exclusives!");
			Console.ReadKey();
		}
    }
}
