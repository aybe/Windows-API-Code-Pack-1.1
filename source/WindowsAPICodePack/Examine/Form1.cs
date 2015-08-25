using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Examine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DirtyMem();
			try
			{

				var tdError = new TaskDialog
				{
					DetailsExpanded = false,
					Cancelable = false,
					Icon = TaskDialogStandardIcon.Error,
					Caption = "This dialog works",
					InstructionText = "A good news for you - this dialog works!",
					Text = "It might be possible to continue by pressing Ignore button. This error has been reported to Credit Master Support.",
					DetailsExpandedLabel = "Hide details",
					DetailsCollapsedLabel = "Show details",
					ExpansionMode = TaskDialogExpandedDetailsLocation.Hide
				};

				tdError.DetailsExpandedText = "Exception Text";
				tdError.ExpansionMode = TaskDialogExpandedDetailsLocation.ExpandFooter;

				var ignoreButton = new TaskDialogCommandLink("ignore", "Ignore\nDo not close the application.");
				ignoreButton.Click += (s, e1) => tdError.Close(TaskDialogResult.Retry);
				tdError.Controls.Add(ignoreButton);

				var closeButton = new TaskDialogCommandLink("close", "Close\nClose the application and exit.");
				closeButton.Click += (s, e1) => tdError.Close(TaskDialogResult.Cancel);
				tdError.Controls.Add(closeButton);

				var copyButton = new TaskDialogCommandLink("copy", "Copy Details to Clipboard\nCopy error details to clipboard for further investigation.");
				copyButton.Click += (s, e1) => MessageBox.Show("");
				tdError.Controls.Add(copyButton);

				tdError.OwnerWindowHandle = Handle;
				Text = tdError.Show().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private byte[] _buf;
		private static readonly Random _rnd = new Random();

		private void DirtyMem()
		{
			Fill(100000000);
			GC.Collect();
			Fill(100000000);
			GC.Collect();
			Fill(100000000);
			GC.Collect();
			Fill(100000000);
			GC.Collect();
			Fill(100000000);
			GC.Collect();
			Fill(100000000);
			GC.Collect();
		}

		private void Fill(int size)
		{
			_buf = new byte[size];
			_rnd.NextBytes(_buf);
			_buf = null;
		}
	}
}
