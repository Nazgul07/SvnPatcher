using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvnPatcher
{
	public partial class Main : Form
	{
		private string _lastSelectedFolder = null;
		public Main()
		{
			InitializeComponent();
		}

		public void LoadFromArguments(string patch, IEnumerable<string> directories)
		{
			txtPatchFile.Text = patch;
			foreach (string directory in directories)
			{
				int index = dataGridView1.Rows.Add();
				dataGridView1.Rows[index].Cells["SVNDirectory"].Value = directory;
				dataGridView1.Rows[index].Cells["Selected"].Value = true;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (e.ColumnIndex == 2 && e.RowIndex >= 0)
			{
				using (FolderBrowserDialog dialog = new FolderBrowserDialog())
				{
					dialog.RootFolder = Environment.SpecialFolder.MyComputer;
					dialog.SelectedPath = _lastSelectedFolder ?? "";
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						senderGrid.Rows[e.RowIndex].Cells["SVNDirectory"].Value = dialog.SelectedPath;
						_lastSelectedFolder = dialog.SelectedPath;
					}
				}
			}
			if (dataGridView1.Rows[e.RowIndex].Cells["Status"].ColumnIndex == e.ColumnIndex && e.RowIndex >= 0 && (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "Success")
			{
				var directory = dataGridView1.Rows[e.RowIndex].Cells["SVNDirectory"].Value;
				Process proc = new Process();
				proc.StartInfo = new ProcessStartInfo()
				{
					FileName = "TortoiseMerge.exe",
					WorkingDirectory = directory as string,
					Arguments = "/diff:\"" + txtPatchFile.Text + "\" /patchpath:\"" + directory + "\"",
					UseShellExecute = false
				};
				proc.Start();
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Filter = "Patch files (*.patch)|*.patch|Diff files (*.diff)|*.diff";
				dialog.CheckFileExists = true;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					txtPatchFile.Text = dialog.FileName;
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Add();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			btnRun.Enabled = false;
			Cursor = Cursors.WaitCursor;
			if (File.Exists(txtPatchFile.Text))
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if ((bool)(row.Cells["Selected"].FormattedValue))
					{
						var directory = row.Cells["SVNDirectory"].Value;
						Process proc = new Process();
						proc.StartInfo = new ProcessStartInfo()
						{
							FileName = "svn.exe",
							WorkingDirectory = directory as string,
							Arguments = $"patch \"{txtPatchFile.Text}\" --ignore-whitespace --dry-run",
							RedirectStandardOutput = true,
							UseShellExecute = false
						};
						proc.Start();
						proc.WaitForExit();
						string result = proc.StandardOutput.ReadToEnd();
						if (!cbDryRun.Checked && !result.Contains("rejected") && !result.Contains("Skipped"))
						{
							proc = new Process();
							proc.StartInfo = new ProcessStartInfo()
							{
								FileName = "svn.exe",
								WorkingDirectory = directory as string,
								Arguments = $"patch \"{txtPatchFile.Text}\" --ignore-whitespace",
								RedirectStandardOutput = true,
								UseShellExecute = false
							};
							proc.Start();
							proc.WaitForExit();
						}
						else if (result.Contains("rejected") || result.Contains("Skipped"))
						{
							row.Cells["Status"].Value = "Error, Apply Manually";
						}
						else
						{
							row.Cells["Status"].Value = "Success";
						}
					}
				}
			}
			btnRun.Enabled = true;
			Cursor = Cursors.Default;
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if ((bool)(row.Cells["Selected"].FormattedValue))
				{
					var directory = row.Cells["SVNDirectory"].Value;
					var bugId = row.Cells["BugId"].Value;
					var message = txtMessage.Text.Replace("\"","'");
					Process proc = new Process();  
					proc.StartInfo = new ProcessStartInfo()
					{
						FileName = "TortoiseProc.exe",
						Arguments = $"/command:commit /path:\"{directory as string}\" /logmsg:\"{message}\" /bugid:{bugId}",
					};
					proc.Start();
				}
			}
		}

		private void btnRevert_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if ((bool)(row.Cells["Selected"].FormattedValue))
				{
					var directory = row.Cells["SVNDirectory"].Value;
					Process proc = new Process();
					proc.StartInfo = new ProcessStartInfo()
					{
						FileName = "TortoiseProc.exe",
						Arguments = $"/command:revert /path:\"{directory as string}\"",
					};
					proc.Start();
				}
			}
		}

		private void btnCleanup_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if ((bool)(row.Cells["Selected"].FormattedValue))
				{
					var directory = row.Cells["SVNDirectory"].Value;
					Process proc = new Process();
					proc.StartInfo = new ProcessStartInfo()
					{
						FileName = "TortoiseProc.exe",
						Arguments = $"/command:cleanup /path:\"{directory as string}\"",
					};
					proc.Start();
				}
			}
		}
	}
}
