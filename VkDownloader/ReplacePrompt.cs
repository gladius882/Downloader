/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-04-17
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Downloader
{
	/// <summary>
	/// Description of ReplacePrompt.
	/// </summary>
	public class ReplacePrompt
	{
		
		public static ReplacePromptResult ShowDialog()
		{
			Form prompt = new Form()
			{
				Width = 665,
				Height = 205,
				Margin = new System.Windows.Forms.Padding(4),
				Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F),
				Text = "Replace",
				StartPosition = FormStartPosition.CenterParent,
				FormBorderStyle = FormBorderStyle.FixedToolWindow
			};
			
			Label label1 = new Label()
			{
				Location = new System.Drawing.Point(13, 13),
				Size = new System.Drawing.Size(76, 18),
				Text = "Find what:"
			};
			
			TextBox textBoxFindWhat = new TextBox()
			{
				Location = new System.Drawing.Point(13, 35),
				Size = new System.Drawing.Size(626, 22),
				TabIndex = 0
			};
			
			Label label2 = new Label()
			{
				Location = new System.Drawing.Point(13, 60),
				Size = new System.Drawing.Size(95, 18),
				Text = "Replace with:"
			};
			
			TextBox textBoxReplaceWith = new TextBox()
			{
				Location = new System.Drawing.Point(13, 81),
				Size = new System.Drawing.Size(626, 22),
				TabIndex = 1
			};
			
			Button buttonReplace = new Button()
			{
				Location = new System.Drawing.Point(13,137),
				Size = new System.Drawing.Size(76, 23),
				DialogResult = DialogResult.OK,
				Text = "Replace",
				TabIndex = 2
			};
			
			Button buttonCancel = new Button()
			{
				Location = new System.Drawing.Point(95, 137),
				Size = new System.Drawing.Size(82, 23),
				DialogResult = DialogResult.Cancel,
				Text = "Cancel",
				TabIndex = 3
			};
			
			buttonReplace.Click += (sender, e) => { prompt.Close(); };
			buttonCancel.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(label1);
			prompt.Controls.Add(textBoxFindWhat);
			prompt.Controls.Add(label2);
			prompt.Controls.Add(textBoxReplaceWith);
			prompt.Controls.Add(buttonReplace);
			prompt.Controls.Add(buttonCancel);
			prompt.AcceptButton = buttonReplace;
			prompt.CancelButton = buttonCancel;
			
			DialogResult res = prompt.ShowDialog();
			
			ReplacePromptResult data = new ReplacePromptResult()
			{
				FindWhat = "",
				ReplaceWith = "",
				Canceled = true
			};
			
			if(res == DialogResult.OK)
			{
				data.FindWhat = textBoxFindWhat.Text;
				data.ReplaceWith = textBoxReplaceWith.Text;
				data.Canceled = false;
			}
			
			return data;
		}
		
	}
	
	public struct ReplacePromptResult
	{
		public string FindWhat;
		public string ReplaceWith;
		public bool Canceled;
	}
}
