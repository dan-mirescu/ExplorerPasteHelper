using System.Collections.Specialized;

namespace ExplorerPasteHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Log(string text)
        {
            textBox1.AppendText(text);
            textBox1.AppendText(Environment.NewLine);
        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType == WK.Libraries.SharpClipboardNS.SharpClipboard.ContentTypes.Text)
            {
                var potentialFilePath = e.Content.ToString();
                if(File.Exists(potentialFilePath))
                {
                    var paths = new StringCollection
                    {
                        potentialFilePath
                    };
                    Clipboard.SetFileDropList(paths);
                    Log("Processed " + potentialFilePath);
                }
                else
                {
                    Log("File does not exist: " + Utils.PadRight(potentialFilePath, "...", 50));
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}