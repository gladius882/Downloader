/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-15
 * Time: 13:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Downloader
{
	public partial class Vk
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.buttonSelectPath = new System.Windows.Forms.Button();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.comboBoxQuality = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Paste URL here";
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(110, 10);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(493, 20);
			this.textBoxUrl.TabIndex = 1;
			// 
			// buttonSelectPath
			// 
			this.buttonSelectPath.Location = new System.Drawing.Point(13, 35);
			this.buttonSelectPath.Name = "buttonSelectPath";
			this.buttonSelectPath.Size = new System.Drawing.Size(91, 23);
			this.buttonSelectPath.TabIndex = 2;
			this.buttonSelectPath.Text = "Select path";
			this.buttonSelectPath.UseVisualStyleBackColor = true;
			this.buttonSelectPath.Click += new System.EventHandler(this.ButtonSelectPathClick);
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(110, 35);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(493, 20);
			this.textBoxPath.TabIndex = 3;
			this.textBoxPath.Text = "C:\\Users\\gladius882\\Desktop";
			// 
			// comboBoxQuality
			// 
			this.comboBoxQuality.DisplayMember = "240";
			this.comboBoxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.comboBoxQuality.FormattingEnabled = true;
			this.comboBoxQuality.Items.AddRange(new object[] {
									"240",
									"360",
									"480",
									"720"});
			this.comboBoxQuality.Location = new System.Drawing.Point(110, 62);
			this.comboBoxQuality.Name = "comboBoxQuality";
			this.comboBoxQuality.Size = new System.Drawing.Size(47, 21);
			this.comboBoxQuality.TabIndex = 4;
			this.comboBoxQuality.ValueMember = "240";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Choose quality";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(163, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "px";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(13, 106);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(91, 23);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(110, 106);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(91, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 140);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(615, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// Vk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 162);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxQuality);
			this.Controls.Add(this.buttonSelectPath);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Vk";
			this.Text = "Vk";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxQuality;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonSelectPath;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.Label label1;
	}
}
