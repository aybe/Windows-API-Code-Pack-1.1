using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TestApp
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTaskDialogFix_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new TaskDialog
            {
                Caption = "Caption",
                DetailsCollapsedLabel = "DetailsCollapsedLabel",
                DetailsExpanded = true,
                DetailsExpandedLabel = "DetailsExpandedLabel",
                DetailsExpandedText = "DetailsExpandedText",
                ExpansionMode = TaskDialogExpandedDetailsLocation.ExpandContent,
                FooterCheckBoxChecked = true,
                FooterCheckBoxText = "FooterCheckBoxText",
                FooterIcon = TaskDialogStandardIcon.Information,
                FooterText = "FooterText",
                HyperlinksEnabled = true,
                Icon = TaskDialogStandardIcon.Shield,
                InstructionText = "InstructionText",
                ProgressBar = new TaskDialogProgressBar {Value = 100},
                StandardButtons =
                    TaskDialogStandardButtons.Ok | TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No |
                    TaskDialogStandardButtons.Cancel | TaskDialogStandardButtons.Close | TaskDialogStandardButtons.Retry,
                StartupLocation = TaskDialogStartupLocation.CenterScreen,
                Text = "Text"
            })
            {
                dialog.Show();
            }
        }
    }
}