﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main()
        {
            string[] filePaths = Directory.GetFiles(@"../../", "*.*", SearchOption.AllDirectories);

            List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();

            var sorted =
                files.OrderBy(f => f.Length)
                .GroupBy(f => f.Extension)
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StreamWriter writer = new StreamWriter(desktop + "/report.txt");

            foreach (var group in sorted)
            {
                writer.WriteLine(group.Key);

                foreach (var y in group)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", y.Name, y.Length / 1024.0);
                }
            }

            writer.Close();

            System.Diagnostics.Process.Start(desktop + "/report.txt");
        }
    }
}

