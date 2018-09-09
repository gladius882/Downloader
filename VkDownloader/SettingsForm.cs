/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-15
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Downloader
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		private MainForm _parent;
		
		public SettingsForm(MainForm f)
		{
			InitializeComponent();
			this._parent = f;
			
			this.textBoxPath.Text = SettingsSingleton.Instance.Options["DefaultPath"];
			this.textBoxList.Text = SettingsSingleton.Instance.Options["DefaultList"];
			this.checkBoxDisplayPercentage.Checked = bool.Parse(SettingsSingleton.Instance.Options["DisplayPercentageProgress"]);
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			SettingsSingleton.Instance.Options["DefaultPath"] = this.textBoxPath.Text;
			SettingsSingleton.Instance.Options["DefaultList"] = this.textBoxList.Text;
			SettingsSingleton.Instance.Options["DisplayPercentageProgress"] = this.checkBoxDisplayPercentage.Checked.ToString();
			
			SettingsSingleton.Save();
			
			this._parent.LoadSettings();
			this.Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButtonBrowsePathClick(object sender, EventArgs e)
		{
			using(var dialog = new FolderBrowserDialog())
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					this.textBoxPath.Text = dialog.SelectedPath;
				}
				else
				{
					return;
				}
			}
		}
		
		void ButtonBrowseListClick(object sender, EventArgs e)
		{
			using(var dialog = new OpenFileDialog())
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					this.textBoxList.Text = dialog.FileName;
				}
				else
				{
					return;
				}
			}
		}
	}
}
