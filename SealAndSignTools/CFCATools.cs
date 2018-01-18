using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SealAndSignTools
{
    public partial class CFCATools : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Size primarySize;
        string gWritingImage;
        int width;
        int height;
        public CFCATools()
        {
            InitializeComponent();
            width = trustSignplugin.GetExtendScreenWidth();
            height = trustSignplugin.GetExtendScreenHeight();
            trustSignplugin.SetHandwritingDialogPosition(width - 550, height - 350, 500, 300);
            trustSignplugin.SetHandwritingDialogTransparent(80);
        }

        private void toolBarShowToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            trustSignplugin.ToggleToolbar(toolBarShowToolStripMenuItem.Checked);
        }

        private void toolBarShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBarShowToolStripMenuItem.Checked = !toolBarShowToolStripMenuItem.Checked;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "pdf|*.pdf|所有文件|*.*;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openToolStripMenuItem.Enabled = false;
                SaveToolStripMenuItem.Enabled = true;
                SaveAsToolStripMenuItem1.Enabled = true;
                CloseFileToolStripMenuItem.Enabled = true;
                //string file = ofd.FileName;
                //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trustSignplugin.OpenLocalFile(ofd.FileName);
            }
        }

        private void fullSreenShow(bool yesORno) {
            if (yesORno)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                Rectangle ret = Screen.GetWorkingArea(this);

                primarySize = this.trustSignplugin.ClientSize;
                this.trustSignplugin.ClientSize = new Size(ret.Width, ret.Height);
                this.trustSignplugin.Dock = DockStyle.Fill;
                this.trustSignplugin.BringToFront();
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.trustSignplugin.ClientSize = primarySize;//primarySize即是控件的原始尺寸
                this.trustSignplugin.Dock = DockStyle.None;
            }

        }

        private void FullSreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullSreenToolStripMenuItem.Checked = !FullSreenToolStripMenuItem.Checked;
        }

        private void FullSreenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            fullSreenShow(FullSreenToolStripMenuItem.Checked);
        }

        private void CloseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem.Enabled = false;
            SaveAsToolStripMenuItem1.Enabled = false;
            CloseFileToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = true;
            trustSignplugin.CloseFile();
        }

        /// <summary>
        /// 手写签字盖章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandWriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gWritingImage = trustSignplugin.OpenHandwritingDialog(7);
            trustSignplugin.ClickToPlaceSignature(gWritingImage);
        }

        private void trustSignplugin_NotifyDragRect(object sender, AxPDFViewerLib._IAxPDFViewerEvents_NotifyDragRectEvent e)
        {
            trustSignplugin.SignFile_Text(e.nPageNo, e.x0, e.y0, e.x1, e.y1, e.ToString());
        }

        private void SignCertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trustSignplugin.SelectSignCert("","","","");
        }

        private void trustSignplugin_NotifyCtrlReady(object sender, EventArgs e)
        {

        }

        private void trustSignplugin_NotifyClickPoint(object sender, AxPDFViewerLib._IAxPDFViewerEvents_NotifyClickPointEvent e)
        {
            try
            {
                trustSignplugin.SignFile_Image(e.nPageNo, e.x, e.y, gWritingImage);
            }
            catch (Exception)
            {
                MessageBox.Show(trustSignplugin.GetLastErrorDesc(),"签章错误");
            }
        }

        private void trustSignplugin_NotifyClickField(object sender, AxPDFViewerLib._IAxPDFViewerEvents_NotifyClickFieldEvent e)
        {

        }

        private void ImageSignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "png|*.png|所有文件|*.*;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gWritingImage = Convert.ToBase64String(File.ReadAllBytes(ofd.FileName));
                trustSignplugin.ClickToPlaceSignature(gWritingImage);
            }
        }
    }
}
