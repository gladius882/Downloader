/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-15
 * Time: 13:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace Downloader
{
	public partial class Vk : Form
	{
		private MainForm _parent;
		private WebClient client = new WebClient();
		private List<string> Queue = new List<string>();
		
		public Vk(MainForm f)
		{
			InitializeComponent();
			this._parent = f;
			
			client.DownloadFileCompleted += (s, e) =>
			{
				string quality = this.comboBoxQuality.Items[this.comboBoxQuality.SelectedIndex].ToString();
				
				string html = File.ReadAllText("cache/vk.html");
				string reg = "\"url" + quality + "\":\"(.*?)\"";
				string url = Regex.Match(html, reg, RegexOptions.Singleline | RegexOptions.IgnoreCase).Value;
				
				url = url.Replace("\"", "").Replace("url" + quality + ":", "").Replace("\\", "");
				this._parent.AddFileToList(this.textBoxPath.Text.Trim(), url);
				this.toolStripStatusLabel1.Text = "Done: " + url;
				
				if(Queue.Count != 0) {
					string[] row = Queue[0].Split(';');
					Queue.RemoveAt(0);
					
					this.textBoxPath.Text = row[0];
					client.DownloadFileAsync(new Uri(row[1]), "cache/vk.html");
				}
				else {
					this.Close();
				}
			};
			
			client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
			client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; Avant TriCore) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131 Safari/537.36");
			
			this.comboBoxQuality.SelectedIndex = 0;
		}
		
		public static string TransformUrl(string url, string quality = "240")
		{
			WebClient client = new WebClient();
			client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
			client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; Avant TriCore) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131 Safari/537.36");
			
			client.DownloadFile(url, "cache/vk.html");
			string html = File.ReadAllText("cache/vk.html");
			string reg = "\"url" + quality + "\":\"(.*?)\"";
			string transformedUrl = Regex.Match(html, reg, RegexOptions.Singleline | RegexOptions.IgnoreCase).Value;
				
			transformedUrl = transformedUrl.Replace("\"", "").Replace("url" + quality + ":", "").Replace("\\", "");
			
			return transformedUrl;
		}
		
		void ButtonSelectPathClick(object sender, EventArgs e)
		{
			using(var dialog = new FolderBrowserDialog())
			{
			    DialogResult result = dialog.ShowDialog();
			
			    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
			    {
			        this.textBoxPath.Text = dialog.SelectedPath;
			    }
			}			
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			this.toolStripStatusLabel1.Text = "Fetching direct link...";
			
			client.DownloadFileAsync(new Uri(this.textBoxUrl.Text.Trim()), "cache/vk.html");
		}
		
		void ButtonLoadClick(object sender, EventArgs e)
		{
			string fileName = "";
			using(var dialog = new OpenFileDialog())
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					fileName = dialog.FileName;
				}
				else
					return;
			}
			
			string[] files = File.ReadAllLines(fileName);
			foreach(string file in files)
			{
				Queue.Add(file);
			}
			
			string[] row = Queue[0].Split(';');
			Queue.RemoveAt(0);
			this.textBoxPath.Text = row[0];
			client.DownloadFileAsync(new Uri(row[1]), "cache/vk.html");
		}
	}
}
