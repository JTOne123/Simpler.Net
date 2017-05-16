﻿using System;
using System.IO;

namespace Simpler.Net.FileSystem.Abstractions.Implementations
{
	/// <summary>
	/// Base class for creating test or other custom <see cref="IDirectory"/> implementations.
	/// </summary>
	public class NullDirectory : IDirectory
	{
		/// <inheritdoc />
		public virtual DirectoryInfo CreateDirectory(String path) => null;

		/// <inheritdoc />
		public String GetCurrentDirectory() => null;
	}
}