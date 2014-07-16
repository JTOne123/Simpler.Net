﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Simpler.Net.FileSystem
{
    /// <summary>
    /// Methods for working with directories
    /// </summary>
    public class SimplerDirectory
    {
        /// <summary>
        /// Takes a list of paths and builds a tree out of them.
        /// </summary>
        /// <param name="pathList"></param>
        /// <returns></returns>
        public static SimplerTreeNode GetDirectoryTree(ICollection<String> pathList)
        {
            var result = new SimplerTreeNode();
            foreach (var path in pathList)
            {
                var parts = path.Split('\\', '/');
                var parent = result;
                foreach (var part in parts)
                {
                    // Look for the part if it's already added
                    var existing = parent.Children.FirstOrDefault(node => node.Name == part);
                    if (existing != null)
                    {
                        parent = existing;
                        continue;
                    }

                    parent = parent.AddNewChild(part);
                }
            }
            return result;
        }
    }
}
