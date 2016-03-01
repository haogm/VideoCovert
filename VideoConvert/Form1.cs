using System;
using System.Windows.Forms;
//using SharpFFmpeg;
using NReco.VideoConverter;

namespace VideoConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            ofd1.ShowDialog();
            ofd1.Multiselect = true;
            //文件格式
            ofd1.Filter = "所有文件|*.*";
            //还原当前目录
            ofd1.RestoreDirectory = true;
            //默认的文件格式
            ofd1.FilterIndex = 1;
            //if (ofd1.ShowDialog() == DialogResult.OK)
            //{
                this.txtSource.Text = ofd1.FileName;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fbd1.ShowDialog();
            this.txtSave.Text = fbd1.SelectedPath.ToString();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var pathToVideoFile = this.txtSource.Text;
            //var pathToSave = this.textBox2.Text + newFileName + "";
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.ConvertMedia(pathToVideoFile, @"D:\333.flv", Format.flv);//转换
            ffMpeg.GetVideoThumbnail(pathToVideoFile, @"D:\二二.jpg");//截图
        }
    }
}
