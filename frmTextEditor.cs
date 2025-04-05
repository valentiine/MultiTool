using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valentine.sah_project
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }

        private void rtxtbox_Load(object sender, EventArgs e)
        {

        }

        public void OpenFile(string fileName)
        {
            StreamReader textIn = new StreamReader
            (new FileStream(fileName, FileMode.Open, FileAccess.Read));


            while (textIn.Peek() != -1)
            {
                string line = textIn.ReadLine() + "\r\n";
                rtxtbox.Text += line;
            }

            textIn.Close();

            var onlyFileName = System.IO.Path.GetFileName(fileName);
            this.Text = "Text Editor: " + onlyFileName;
        }
    }
}
