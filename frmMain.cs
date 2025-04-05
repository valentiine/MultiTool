namespace valentine.sah_project
{
    public partial class frmMain : Form
    {

        private string file_path;
        string path = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editText = new frmTextEditor();
            editText.MdiParent = this;
            editText.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.Enabled = true;

            openFileDialog2.Tag = "Browse Text File";
            openFileDialog2.Filter = "Text File (.txt) | *.txt";
            openFileDialog2.FileName = "";
            openFileDialog2.InitialDirectory = @"c:\";


            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog2.FileName;
                if (fileName.Length != 0)
                {
                    try
                    {
                        file_path = openFileDialog2.FileName;
                        path = openFileDialog2.FileName;

                        frmTextEditor childform = new frmTextEditor();


                        childform.OpenFile(openFileDialog2.FileName);
                        childform.MdiParent = this;
                        childform.Show();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Class : NETD-2202\nFinal Project\nName: Valentine Sah";
            string aboutTitle = "About";
            MessageBox.Show(aboutMessage, aboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog2.AddExtension = true;
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Form activeChildForm = this.ActiveMdiChild;
                if (activeChildForm != null)
                {
                    RichTextBox editText = activeChildForm.ActiveControl as RichTextBox;
                    if (editText != null)
                    {
                        string extension = System.IO.Path.GetExtension(saveFileDialog2.FileName);
                        if (extension.ToLower() == ".txt")
                        {
                            editText.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                        }


                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog2.AddExtension = true;
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Form activeChildForm = this.ActiveMdiChild;
                if (activeChildForm != null)
                {
                    RichTextBox editText = activeChildForm.ActiveControl as RichTextBox;
                    if (editText != null)
                    {
                        string extension = System.IO.Path.GetExtension(saveFileDialog2.FileName);
                        if (extension.ToLower() == ".txt")
                        {
                            editText.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                        }


                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = this.ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }
        }

        private void textEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form editText = new frmTextEditor();
                editText.MdiParent = this;
                editText.Show();
            }
        }

        private void averageUnitSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form editText = new frmAvgUnitsShipped();
                editText.MdiParent = this;
                editText.Show();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox editText = activeChildForm.ActiveControl as RichTextBox;
                if (editText.SelectionLength > 0)
                {
                    Clipboard.SetText(editText.SelectedText);

                }
                else
                {
                    string aboutMessage = "There is no selected text";
                    string aboutTitle = "Error";
                    MessageBox.Show(aboutMessage, aboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox editText = activeChildForm.ActiveControl as RichTextBox;
                editText.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChildForm = this.ActiveMdiChild;
            if (activeChildForm != null)
            {
                RichTextBox editText = activeChildForm.ActiveControl as RichTextBox;
                if (editText.SelectionLength > 0)
                {
                    Clipboard.SetText(editText.SelectedText);
                    editText.SelectedText = "";
                }
                else
                {
                    string aboutMessage = "There is no selected text";
                    string aboutTitle = "Error";
                    MessageBox.Show(aboutMessage, aboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}