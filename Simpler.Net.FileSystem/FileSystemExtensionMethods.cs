﻿using System;
using System.IO;
using Simpler.Net.FileSystem.Abstractions;

namespace Simpler.Net.FileSystem
{
	/// <summary>
	/// Extensions for <see cref="IFileSystem"/>.
	/// </summary>
	public static class FileSystemExtensionMethods
    {
	    /// <summary>
	    /// Create all directories in a given path, assuming that the last part is a file.
	    /// </summary>
	    /// <example><code>
	    /// var filePath = "c:\folder\folder.x\file.ext";
	    /// IDirectory dir; // inject / instantiate
	    /// dir.CreateDirectoryForFile(filePath); // Creates "C:\folder\folder.x"
	    /// </code></example>
	    public static DirectoryInfo CreateDirectoryForFile(this IFileSystem fileSystem, String path) =>
				fileSystem.Directory.CreateDirectory(Path.GetDirectoryName(path));
    }
}
