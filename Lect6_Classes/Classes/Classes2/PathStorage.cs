using System;
using System.Collections.Generic;
using System.IO;

namespace Classes2
{
    public static class PathStorage
    {
        public static void SavePathInFile(string fileName, Path path)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    writer.WriteLine();
                }
            }
        }
    }
}
