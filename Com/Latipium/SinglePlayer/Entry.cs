// Entry.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using Com.Latipium.Security;

namespace Com.Latipium.SinglePlayer {
	/// <summary>
	/// The main class for the server.
	/// </summary>
	public class Entry {
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args) {
			LatipiumSecurity.Initialize("Com.Latipium.Modules.SinglePlayer", args.Length > 0 ? args[0] : null);
		}
	}
}

