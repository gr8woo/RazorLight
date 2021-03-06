﻿using System;
using System.IO;

namespace RazorLight.MVC.Tests
{
	public class PathUtility
    {
		public static string GetViewsPath()
		{
			string isTesting = Environment.GetEnvironmentVariable("IS_TESTING_ENVIRONMENT");

			if (!string.IsNullOrEmpty(isTesting) && isTesting.Equals("true"))
			{
				return Path.Combine(Directory.GetCurrentDirectory(), "tests", "RazorLight.MVC.Tests");
			}

			return Directory.GetCurrentDirectory();
		}
	}
}
