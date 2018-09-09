/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-15
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Downloader
{
	partial class SettingsForm
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
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonBrowsePath = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxList = new System.Windows.Forms.TextBox();
			this.buttonBrowseList = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkBoxDisplayPercentage = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Default path";
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(105, 10);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(502, 20);
			this.textBoxPath.TabIndex = 1;
			// 
			// buttonBrowsePath
			// 
			this.buttonBrowsePath.Location = new System.Drawing.Point(613, 9);
			this.buttonBrowsePath.Name = "buttonBrowsePath";
			this.buttonBrowsePath.Size = new System.Drawing.Size(25, 20);
			this.buttonBrowsePath.TabIndex = 2;
			this.buttonBrowsePath.Text = "...";
			this.buttonBrowsePath.UseVisualStyleBackColor = true;
			this.buttonBrowsePath.Click += new System.EventHandler(this.ButtonBrowsePathClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Default list";
			// 
			// textBoxList
			// 
			this.textBoxList.Location = new System.Drawing.Point(105, 32);
			this.textBoxList.Name = "textBoxList";
			this.textBoxList.Size = new System.Drawing.Size(502, 20);
			this.textBoxList.TabIndex = 1;
			// 
			// buttonBrowseList
			// 
			this.buttonBrowseList.Location = new System.Drawing.Point(613, 31);
			this.buttonBrowseList.Name = "buttonBrowseList";
			this.buttonBrowseList.Size = new System.Drawing.Size(25, 20);
			this.buttonBrowseList.TabIndex = 2;
			this.buttonBrowseList.Text = "...";
			this.buttonBrowseList.UseVisualStyleBackColor = true;
			this.buttonBrowseList.Click += new System.EventHandler(this.ButtonBrowseListClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(10, 162);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(91, 162);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// checkBoxDisplayPercentage
			// 
			this.checkBoxDisplayPercentage.Location = new System.Drawing.Point(13, 59);
			this.checkBoxDisplayPercentage.Name = "checkBoxDisplayPercentage";
			this.checkBoxDisplayPercentage.Size = new System.Drawing.Size(165, 22);
			this.checkBoxDisplayPercentage.TabIndex = 6;
			this.checkBoxDisplayPercentage.Text = "Display percentage progress";
			this.checkBoxDisplayPercentage.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 197);
			this.Controls.Add(this.checkBoxDisplayPercentage);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonBrowseList);
			this.Controls.Add(this.buttonBrowsePath);
			this.Controls.Add(this.textBoxList);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.label1);
			this.Name = "SettingsForm";
			this.Text = "Downloader settings";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBoxDisplayPercentage;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonBrowseList;
		private System.Windows.Forms.TextBox textBoxList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonBrowsePath;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Label label1;
	}
}
