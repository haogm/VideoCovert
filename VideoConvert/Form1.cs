﻿using System;
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
            var newFileName = "NewName";
            var pathToSaveVideo = this.txtSave.Text + "\\" + newFileName + "." + Format.flv.ToString();
            var pathToSavePicture = this.txtSave.Text + "\\" + newFileName + ".jpg";
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.ConvertMedia(pathToVideoFile, pathToSaveVideo, Format.flv);//转换
            ffMpeg.GetVideoThumbnail(pathToVideoFile, pathToSavePicture);//截图
        }
    }
}
