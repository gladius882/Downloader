/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-11
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Shell;
using System.Threading;

namespace Downloader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private WebClient client = new WebClient();
		private string lastDownloaded = ""; 
		
		#region Construct
		
		public MainForm()
		{
			InitializeComponent();
			this.LoadSettings();
			
			client.DownloadFileCompleted += (s, e) =>
			{
				this.lastDownloaded = this.listViewFiles.SelectedItems[0].SubItems[0].Text;
				this.lastDownloaded = this.lastDownloaded.Split('\\')[this.lastDownloaded.Split('\\').Length-1];
				
				if(e.Cancelled == true)
				{
					notifyIcon.BalloonTipTitle = "Saving canceled";
					notifyIcon.BalloonTipText = "Downloading " + this.lastDownloaded + " has been canceled";
					notifyIcon.ShowBalloonTip(300);
					return;
				}
					
				if(this.WindowState == FormWindowState.Minimized)
				{
					notifyIcon.BalloonTipTitle = "File saved";
					notifyIcon.BalloonTipText = lastDownloaded + " has been successufuly saved";
					notifyIcon.ShowBalloonTip(300);
				}
				
				this.toolStripStatusLabel1.Text = "File saved";
				if (Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported &&
				   this.WindowState != FormWindowState.Minimized)
				{
					var taskbarInstance = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
					taskbarInstance.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.NoProgress);
				}
			};
			
			client.DownloadProgressChanged += (s, e) =>
			{			
				this.toolStripProgressBar.Value = e.ProgressPercentage;
				this.toolStripStatusPercentage.Text = e.ProgressPercentage.ToString() + "%";
				
				if (Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported &&
				   this.WindowState != FormWindowState.Minimized)
				{
				    var taskbarInstance = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
				    taskbarInstance.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
				 
				    taskbarInstance.SetProgressValue(e.ProgressPercentage, 100);
				}
			};
			
			client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
        	client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; Avant TriCore) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131 Safari/537.36");
        	
        	if(SettingsSingleton.Instance.Options["DefaultList"].Trim() != String.Empty)
        	{
				this.LoadList(SettingsSingleton.Instance.Options["DefaultList"].Replace(';', ':'));
        	}
        	
        	
		}
		
		#endregion
		
		public void LoadSettings()
		{
			this.textBoxPath.Text = SettingsSingleton.Instance.Options["DefaultPath"];
			this.toolStripStatusPercentage.Visible = bool.Parse(SettingsSingleton.Instance.Options["DisplayPercentageProgress"]);
		}
		
		public void AddFileToList(string path, string url)
		{
			this.listViewFiles.Items.Add(new ListViewItem(new string[] {path, url}));
		}
		
		private void LoadList(string path)
		{
			this.listViewFiles.Items.Clear();
			string[] files = File.ReadAllLines(path);
			
			foreach(string file in files)
			{
				string[] row = file.Split(';');
				
				this.listViewFiles.Items.Add(new ListViewItem(row));
			}
		}
		
		void NotifyIconDoubleClick(object sender, EventArgs e)
		{
			if(this.WindowState == FormWindowState.Minimized)
			{
				notifyIcon.Visible = false;
				this.Show();
				this.WindowState = FormWindowState.Normal;
			}
		}
		
		#region ListView contextMenu
		
		private void CopyPathToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.listViewFiles.SelectedItems.Count > 0)
			{
				string path = this.listViewFiles.SelectedItems[0].SubItems[0].Text;
				Clipboard.SetText(path);
			}
		}
		
		private void CopyURLToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.listViewFiles.SelectedItems.Count > 0)
			{
				string url = this.listViewFiles.SelectedItems[0].SubItems[1].Text;
				Clipboard.SetText(url);
			}
		}
		
		private void RemoveToolStripMenuItemClick(object sender, EventArgs e)
		{
			foreach(ListViewItem item in this.listViewFiles.SelectedItems)
			{
				this.listViewFiles.Items.Remove(item);
			}
		}
		
		private void DuplicateToolStripMenuItemClick(object sender, EventArgs e)
		{
			string path = this.listViewFiles.SelectedItems[0].SubItems[0].Text;
			string url = this.listViewFiles.SelectedItems[0].SubItems[1].Text;
			
			this.textBoxPath.Text = path;
			this.textBoxUrl.Text = url;
		}
		
		private void ThisItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			string url = this.listViewFiles.SelectedItems[0].SubItems[1].Text;
			string transformedUrl = Vk.TransformUrl(url);
			this.listViewFiles.SelectedItems[0].SubItems[1].Text = transformedUrl;
		}
		
		private void AllItemsToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			for(int i=0; i<this.listViewFiles.Items.Count; i++)
			{
				string url = this.listViewFiles.Items[i].SubItems[1].Text;
				string transformedUrl = Vk.TransformUrl(url);
				this.listViewFiles.Items[i].SubItems[1].Text = transformedUrl;
			}
			Cursor.Current = Cursors.Arrow;
		}
		
		#endregion
		
		#region MainForm events
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		private void MainFormResize(object sender, EventArgs e)
		{
			if(this.WindowState == FormWindowState.Minimized)
			{
				notifyIcon.Visible = true;
				notifyIcon.ShowBalloonTip(500);
				this.Hide();
			}
			else if(this.WindowState == FormWindowState.Normal)
			{
				notifyIcon.Visible = false;
				this.Show();
			}
		}
		
		#endregion
		
		#region MainForm menuStrip options
		
		private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			SettingsForm form = new SettingsForm(this);
			form.ShowDialog();
		}
		
		private void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void DownloadEpisodesFromShindenToolStripMenuItemClick(object sender, EventArgs e)
		{
			Vk form = new Vk(this);
			form.ShowDialog();
		}
		
		private void ReplaceInPathsToolStripMenuItemClick(object sender, EventArgs e)
		{
			ReplacePromptResult res = ReplacePrompt.ShowDialog();
			if(res.Canceled == false)
			{
				foreach(ListViewItem path in this.listViewFiles.Items)
				{
					path.SubItems[0].Text = path.SubItems[0].Text.Replace(res.FindWhat, res.ReplaceWith);
				}
			}
		}
		
		#endregion
		
		#region MainForm buttons on click events
		
		private void ButtonAddClick(object sender, EventArgs e)
		{
			string url = textBoxUrl.Text.Trim();
			string path = textBoxPath.Text.Trim();
			
			if(url == String.Empty)
			{
				MessageBox.Show("No URL typed", "Please type requires data");
				return;
			}
			
			if(IsValidPath(path) == false)
			{
				MessageBox.Show("Invalid path", "Error");
				return;
			}
			
			if(File.Exists(path))
			{
				if(MessageBox.Show("This file is already exists. Replace?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					return;
				}
			}
			
			string[] row = {path, url};
			
			this.listViewFiles.Items.Add(new ListViewItem(row));
		}
		
		private void ButtonSelectFolderClick(object sender, EventArgs e)
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
		
		private void ButtonDownloadClick(object sender, EventArgs e)
		{
			this.DownloadSelected();
		}
		
		private void ButtonDownloadAllClick(object sender, EventArgs e)
		{
			if(isListEmpty() == false)
			{
				this.listViewFiles.Items[0].Selected = true;
				this.listViewFiles.Select();
				
				client.DownloadFileCompleted += (s, ev) =>
				{	
					if(this.SelectNext())
						this.DownloadSelected();
					else
						this.toolStripStatusLabel1.Text = "All files has been downloaded";
				};
				
				this.DownloadSelected();
			}
		}
		
		
		
		private void ButtonSaveClick(object sender, EventArgs e)
		{
			string fileName = "";
			using(var dialog = new SaveFileDialog())
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					fileName = dialog.FileName;
					if(File.Exists(fileName)) {
						File.WriteAllText(fileName, "");
					}
				}
				
			}
			
			foreach(ListViewItem item in this.listViewFiles.Items)
			{
				string path = item.SubItems[0].Text;
				string url = item.SubItems[1].Text;
				
				File.AppendAllLines(fileName, new string[] {path + ";" + url});
			}
			
			this.toolStripStatusLabel1.Text = "List has been saved";
		}
		
		private void ButtonLoadClick(object sender, EventArgs e)
		{
			using(var dialog = new OpenFileDialog())
			{
			    DialogResult result = dialog.ShowDialog();
			
			    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
			    {
			    	this.LoadList(dialog.FileName);
			    }
			}
		}
		
		private void ButtonRemoveClick(object sender, EventArgs e)
		{
			foreach(ListViewItem item in this.listViewFiles.SelectedItems)
			{
				this.listViewFiles.Items.Remove(item);
			}
		}
		
		private void ButtonClearClick(object sender, EventArgs e)
		{
			this.listViewFiles.Items.Clear();
		}
		
		private void ButtonAbortClick(object sender, EventArgs e)
		{
			client.CancelAsync();
		}
		
		#endregion
		
		#region Helper methods
		
		private bool IsValidPath(string path)
		{
			if(path == String.Empty) {
				return false;
			}
			
			if(Directory.Exists(path)) {
				return false;
			}
			
			return true;
		}
		
		private void DownloadSelected()
		{
			string path = this.listViewFiles.SelectedItems[0].SubItems[0].Text;
			string url = this.listViewFiles.SelectedItems[0].SubItems[1].Text;
			
			this.toolStripStatusLabel1.Text = "Downloading " + path.Split(new char[] {'\\', '/'})[path.Split(new char[] {'\\', '/'}).Length-1];
			client.DownloadFileAsync(new Uri(url), path);
		}
		
		private bool SelectNext()
		{
			try {
				int index = this.listViewFiles.SelectedIndices[0];
				
				if(index == -1)
					this.listViewFiles.Items[0].Selected = true;
				else
					this.listViewFiles.Items[index+1].Selected = true;
				this.Select();
				return true;
			}
			catch {
				return false;
			}
		}
		
		private bool isListEmpty()
		{
			if(this.listViewFiles.Items.Count > 0)
				return false;
			return true;
		}
		
		
		private string ExtractFileName(string path)
		{
			try {
				string[] parts = path.Split(new char[] {'/', '\\'});
				string tail = parts[parts.Length-1];
				return tail;
			}
			catch {
				return String.Empty;
			}
		}
		
		#endregion
	}
}
