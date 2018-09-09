/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-11
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Downloader
{
	public partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listViewFiles = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.vkTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusPercentage = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonDownload = new System.Windows.Forms.Button();
			this.buttonDownloadAll = new System.Windows.Forms.Button();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonAbort = new System.Windows.Forms.Button();
			this.buttonSelectFolder = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forAnimeheadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadEpisodesFromShindenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forGuitaristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadFromGtptabscomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadMp4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadMp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceInPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuItem.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(9, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL";
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxUrl.Location = new System.Drawing.Point(52, 29);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(747, 22);
			this.textBoxUrl.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonAdd.Location = new System.Drawing.Point(13, 86);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(100, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add to queue";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// textBoxPath
			// 
			this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxPath.Location = new System.Drawing.Point(52, 57);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(747, 22);
			this.textBoxPath.TabIndex = 2;
			this.textBoxPath.Text = "C:\\Users\\gladius882\\Desktop";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(9, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Path";
			// 
			// listViewFiles
			// 
			this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listViewFiles.ContextMenuStrip = this.contextMenuItem;
			this.listViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listViewFiles.FullRowSelect = true;
			this.listViewFiles.Location = new System.Drawing.Point(12, 116);
			this.listViewFiles.MultiSelect = false;
			this.listViewFiles.Name = "listViewFiles";
			this.listViewFiles.Size = new System.Drawing.Size(787, 260);
			this.listViewFiles.TabIndex = 4;
			this.listViewFiles.UseCompatibleStateImageBehavior = false;
			this.listViewFiles.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Path";
			this.columnHeader1.Width = 391;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "URL";
			this.columnHeader2.Width = 389;
			// 
			// contextMenuItem
			// 
			this.contextMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyPathToolStripMenuItem,
									this.copyURLToolStripMenuItem,
									this.toolStripMenuItem1,
									this.removeToolStripMenuItem,
									this.duplicateToolStripMenuItem,
									this.toolStripMenuItem2,
									this.toolsToolStripMenuItem1});
			this.contextMenuItem.Name = "contextMenuItem";
			this.contextMenuItem.Size = new System.Drawing.Size(130, 126);
			this.contextMenuItem.Text = "-";
			// 
			// copyPathToolStripMenuItem
			// 
			this.copyPathToolStripMenuItem.Name = "copyPathToolStripMenuItem";
			this.copyPathToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.copyPathToolStripMenuItem.Text = "Copy path";
			this.copyPathToolStripMenuItem.Click += new System.EventHandler(this.CopyPathToolStripMenuItemClick);
			// 
			// copyURLToolStripMenuItem
			// 
			this.copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
			this.copyURLToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.copyURLToolStripMenuItem.Text = "Copy URL";
			this.copyURLToolStripMenuItem.Click += new System.EventHandler(this.CopyURLToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
			// 
			// duplicateToolStripMenuItem
			// 
			this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
			this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.duplicateToolStripMenuItem.Text = "Duplicate";
			this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.DuplicateToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 6);
			// 
			// toolsToolStripMenuItem1
			// 
			this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.vkTransformToolStripMenuItem});
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
			this.toolsToolStripMenuItem1.Text = "Tools";
			// 
			// vkTransformToolStripMenuItem
			// 
			this.vkTransformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.thisItemToolStripMenuItem,
									this.allItemsToolStripMenuItem});
			this.vkTransformToolStripMenuItem.Name = "vkTransformToolStripMenuItem";
			this.vkTransformToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.vkTransformToolStripMenuItem.Text = "Vk transform";
			// 
			// thisItemToolStripMenuItem
			// 
			this.thisItemToolStripMenuItem.Name = "thisItemToolStripMenuItem";
			this.thisItemToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.thisItemToolStripMenuItem.Text = "This item";
			this.thisItemToolStripMenuItem.Click += new System.EventHandler(this.ThisItemToolStripMenuItemClick);
			// 
			// allItemsToolStripMenuItem
			// 
			this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
			this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.allItemsToolStripMenuItem.Text = "All items";
			this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.AllItemsToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripProgressBar,
									this.toolStripStatusPercentage});
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(811, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar.Step = 1;
			// 
			// toolStripStatusPercentage
			// 
			this.toolStripStatusPercentage.Name = "toolStripStatusPercentage";
			this.toolStripStatusPercentage.Size = new System.Drawing.Size(23, 17);
			this.toolStripStatusPercentage.Text = "0%";
			// 
			// buttonDownload
			// 
			this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDownload.Location = new System.Drawing.Point(13, 383);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(137, 23);
			this.buttonDownload.TabIndex = 5;
			this.buttonDownload.Text = "Download selected";
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownloadClick);
			// 
			// buttonDownloadAll
			// 
			this.buttonDownloadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDownloadAll.Location = new System.Drawing.Point(156, 383);
			this.buttonDownloadAll.Name = "buttonDownloadAll";
			this.buttonDownloadAll.Size = new System.Drawing.Size(101, 23);
			this.buttonDownloadAll.TabIndex = 6;
			this.buttonDownloadAll.Text = "Download all";
			this.buttonDownloadAll.UseVisualStyleBackColor = true;
			this.buttonDownloadAll.Click += new System.EventHandler(this.ButtonDownloadAllClick);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonLoad.Location = new System.Drawing.Point(360, 382);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(91, 23);
			this.buttonLoad.TabIndex = 8;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSave.Location = new System.Drawing.Point(263, 383);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(91, 23);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonAbort
			// 
			this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonAbort.Location = new System.Drawing.Point(708, 382);
			this.buttonAbort.Name = "buttonAbort";
			this.buttonAbort.Size = new System.Drawing.Size(91, 23);
			this.buttonAbort.TabIndex = 11;
			this.buttonAbort.Text = "Abort";
			this.buttonAbort.UseVisualStyleBackColor = true;
			this.buttonAbort.Click += new System.EventHandler(this.ButtonAbortClick);
			// 
			// buttonSelectFolder
			// 
			this.buttonSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSelectFolder.Location = new System.Drawing.Point(687, 86);
			this.buttonSelectFolder.Name = "buttonSelectFolder";
			this.buttonSelectFolder.Size = new System.Drawing.Size(112, 23);
			this.buttonSelectFolder.TabIndex = 10;
			this.buttonSelectFolder.Text = "Select folder";
			this.buttonSelectFolder.UseVisualStyleBackColor = true;
			this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolderClick);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonRemove.Location = new System.Drawing.Point(457, 383);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(129, 23);
			this.buttonRemove.TabIndex = 9;
			this.buttonRemove.Text = "Remove selected";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonClear.Location = new System.Drawing.Point(592, 383);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(110, 23);
			this.buttonClear.TabIndex = 12;
			this.buttonClear.Text = "Clear list";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.programToolStripMenuItem,
									this.toolsToolStripMenuItem,
									this.searchToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(811, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// programToolStripMenuItem
			// 
			this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.settingsToolStripMenuItem,
									this.toolStripMenuItem3,
									this.exitToolStripMenuItem});
			this.programToolStripMenuItem.Name = "programToolStripMenuItem";
			this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.programToolStripMenuItem.Text = "Program";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.forAnimeheadToolStripMenuItem,
									this.forGuitaristToolStripMenuItem,
									this.youtubecomToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// forAnimeheadToolStripMenuItem
			// 
			this.forAnimeheadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.downloadEpisodesFromShindenToolStripMenuItem});
			this.forAnimeheadToolStripMenuItem.Name = "forAnimeheadToolStripMenuItem";
			this.forAnimeheadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.forAnimeheadToolStripMenuItem.Text = "vk.com";
			// 
			// downloadEpisodesFromShindenToolStripMenuItem
			// 
			this.downloadEpisodesFromShindenToolStripMenuItem.Name = "downloadEpisodesFromShindenToolStripMenuItem";
			this.downloadEpisodesFromShindenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.downloadEpisodesFromShindenToolStripMenuItem.Text = "Direct link from vk.com";
			this.downloadEpisodesFromShindenToolStripMenuItem.Click += new System.EventHandler(this.DownloadEpisodesFromShindenToolStripMenuItemClick);
			// 
			// forGuitaristToolStripMenuItem
			// 
			this.forGuitaristToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.downloadFromGtptabscomToolStripMenuItem});
			this.forGuitaristToolStripMenuItem.Enabled = false;
			this.forGuitaristToolStripMenuItem.Name = "forGuitaristToolStripMenuItem";
			this.forGuitaristToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.forGuitaristToolStripMenuItem.Text = "gtptabs.com";
			// 
			// downloadFromGtptabscomToolStripMenuItem
			// 
			this.downloadFromGtptabscomToolStripMenuItem.Name = "downloadFromGtptabscomToolStripMenuItem";
			this.downloadFromGtptabscomToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.downloadFromGtptabscomToolStripMenuItem.Text = "Download tab";
			// 
			// youtubecomToolStripMenuItem
			// 
			this.youtubecomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.downloadMp4ToolStripMenuItem,
									this.downloadMp3ToolStripMenuItem});
			this.youtubecomToolStripMenuItem.Name = "youtubecomToolStripMenuItem";
			this.youtubecomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.youtubecomToolStripMenuItem.Text = "youtube.com";
			// 
			// downloadMp4ToolStripMenuItem
			// 
			this.downloadMp4ToolStripMenuItem.Name = "downloadMp4ToolStripMenuItem";
			this.downloadMp4ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.downloadMp4ToolStripMenuItem.Text = "Download mp4";
			// 
			// downloadMp3ToolStripMenuItem
			// 
			this.downloadMp3ToolStripMenuItem.Name = "downloadMp3ToolStripMenuItem";
			this.downloadMp3ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.downloadMp3ToolStripMenuItem.Text = "Download mp3";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.replaceInPathsToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.searchToolStripMenuItem.Text = "Search";
			// 
			// replaceInPathsToolStripMenuItem
			// 
			this.replaceInPathsToolStripMenuItem.Name = "replaceInPathsToolStripMenuItem";
			this.replaceInPathsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.replaceInPathsToolStripMenuItem.Text = "Replace in paths";
			this.replaceInPathsToolStripMenuItem.Click += new System.EventHandler(this.ReplaceInPathsToolStripMenuItemClick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipText = "To show the Downloader  window click on icon";
			this.notifyIcon.BalloonTipTitle = "Minimized to tray";
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Downloader";
			this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIconDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 441);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonSelectFolder);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonAbort);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.buttonDownloadAll);
			this.Controls.Add(this.buttonDownload);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.listViewFiles);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Downloader";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.contextMenuItem.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem downloadMp3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem downloadMp4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youtubecomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem downloadFromGtptabscomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem forGuitaristToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceInPathsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPercentage;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thisItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vkTransformToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem downloadEpisodesFromShindenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem forAnimeheadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyURLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyPathToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuItem;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonSelectFolder;
		private System.Windows.Forms.Button buttonAbort;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonDownloadAll;
		private System.Windows.Forms.Button buttonDownload;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewFiles;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.Label label1;
	}
}
