/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-15
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Downloader
{
	/// <summary>
	/// Description of SettingsSingleton.
	/// </summary>
	public sealed class SettingsSingleton
	{
		private static readonly SettingsSingleton instance = new SettingsSingleton();
		private const string settingsPath = "settings.ini";
		
		public Dictionary<string, string> Options = new Dictionary<string, string>();
		
		public static SettingsSingleton Instance {
			get {
				return instance;
			}
		}
		
		private SettingsSingleton()
		{
			try {
				Options = IniFile.ReadAllOptions(settingsPath);
			}
			catch {
				MessageBox.Show("Cannot find the settings.ini file in application directory or this file is broken. " +
				                "Please restore this file or reinstall app to fix this problem.",
				                "Fatal error",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
			}
		}
		
		public static void Save()
		{
			File.WriteAllText("settings.ini", "");
			foreach(KeyValuePair<string, string> opt in SettingsSingleton.Instance.Options)
			{
				File.AppendAllText("settings.ini", opt.Key + ":" + opt.Value.Replace(':', ';') + Environment.NewLine);
			}
		}
		
	}
}
