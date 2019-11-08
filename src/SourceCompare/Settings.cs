using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCompare
{
    class Settings
    {
        public string Filename { get; set; }
        public string Folder1 { get; set; }
        public string Folder2 { get; set; }
        public int FileComparison { get; set; }
        public int ShowSame { get; set; }
        public int ShowOnly1 { get; set; }
        public int ShowOnly2 { get; set; }
        public int ShowDifferent { get; set; }

        private static Settings singleton;

        private Settings()
        {
            Filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SourceCompare");
            if (!Directory.Exists(Filename)) Directory.CreateDirectory(Filename);
            Filename = Path.Combine(Filename, "settings");
            Load();
        }

        public void Load()
        {
            Folder1 = string.Empty;
            Folder2 = string.Empty;
            FileComparison = 0;
            ShowSame = 0;
            ShowOnly1 = 0;
            ShowOnly2 = 0;
            ShowDifferent = 0;
			if (File.Exists(Filename))
			{
				string file = File.ReadAllText(Filename);
				foreach (string line in file.Split(new[] { '\n' }).Select(l => l.Trim()))
				{
					if (line.StartsWith("folder1="))
					{
						Folder1 = line.Substring(line.IndexOf("=") + 1);
					}
					else if (line.StartsWith("folder2="))
					{
						Folder2 = line.Substring(line.IndexOf("=") + 1);
					}
					else if (line.StartsWith("filecomparison="))
					{
						FileComparison = int.Parse(line.Substring(line.IndexOf("=") + 1));
					}
					else if (line.StartsWith("showsame="))
					{
						ShowSame = int.Parse(line.Substring(line.IndexOf("=") + 1));
					}
					else if (line.StartsWith("showonly1="))
					{
						ShowOnly1 = int.Parse(line.Substring(line.IndexOf("=") + 1));
					}
					else if (line.StartsWith("showonly2="))
					{
						ShowOnly2 = int.Parse(line.Substring(line.IndexOf("=") + 1));
					}
					else if (line.StartsWith("showdifferent="))
					{
						ShowDifferent = int.Parse(line.Substring(line.IndexOf("=") + 1));
					}
				}
			}
        }

        public void Save()
        {
            StringBuilder file = new StringBuilder();
            file.AppendLine(string.Format("folder1={0}", Folder1));
            file.AppendLine(string.Format("folder2={0}", Folder2));
            file.AppendLine(string.Format("filecomparison={0}", FileComparison));
            file.AppendLine(string.Format("showsame={0}", ShowSame));
            file.AppendLine(string.Format("showonly1={0}", ShowOnly1));
            file.AppendLine(string.Format("showonly2={0}", ShowOnly2));
            file.AppendLine(string.Format("showdifferent={0}", ShowDifferent));
            File.WriteAllText(Filename, file.ToString());
        }

        public static Settings Get()
        {
            if (singleton == null)
            {
                singleton = new Settings();
            }
            return singleton;
        }
    }
}
