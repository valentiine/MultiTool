namespace valentine.sah_project
{
    partial class frmTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtbox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rtxtbox
            // 
            this.rtxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbox.Location = new System.Drawing.Point(0, 0);
            this.rtxtbox.Name = "rtxtbox";
            this.rtxtbox.Size = new System.Drawing.Size(298, 336);
            this.rtxtbox.TabIndex = 0;
            this.rtxtbox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 336);
            this.Controls.Add(this.rtxtbox);
            this.Name = "frmTextEditor";
            this.Text = "frmTextEditor";
            this.Load += new System.EventHandler(this.rtxtbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtxtbox;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}