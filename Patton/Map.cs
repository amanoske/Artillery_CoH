using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Patton
{ 
    public class Map
    {
        public Map()
        {
            Path = "";
            Name = "";
            Description = "";
            Players = "";
            Preview = null;
        }

        private void SetFromFile(String path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    switch (lines[i])
                    {
                        case 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public string Path,
                      Name,
                      Description,
                      Players;

        public Image Preview;
    }
}
