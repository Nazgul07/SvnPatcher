using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvnPatcher
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Main mainForm = new Main();
			if (args.Any())
			{
				string patch = args[0];
				IEnumerable<string> directories = args.Skip(1);
				mainForm.LoadFromArguments(patch, directories);
			}
			Application.Run(mainForm);
		}
	}
}
