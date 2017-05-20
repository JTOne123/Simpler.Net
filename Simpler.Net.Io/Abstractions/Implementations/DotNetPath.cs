﻿using System;
using System.IO;

namespace Simpler.Net.Io.Abstractions.Implementations
{
	/// <inheritdoc />
	public class DotNetPath : IPath
	{
		/// <inheritdoc />
		public String GetTempFileName() => Path.GetTempFileName();
	}
}