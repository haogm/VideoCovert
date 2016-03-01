namespace VideoConvert
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConvert = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.ioc1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(174, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(128, 38);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(85, 25);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(312, 21);
            this.txtSource.TabIndex = 1;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(85, 80);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(312, 21);
            this.txtSave.TabIndex = 2;
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(12, 28);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(65, 12);
            this.lblSourceFile.TabIndex = 3;
            this.lblSourceFile.Text = "选择源文件";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(12, 80);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(53, 12);
            this.lblSavePath.TabIndex = 4;
            this.lblSavePath.Text = "保存路径";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "选择";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(431, 23);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(75, 23);
            this.btnSourceFile.TabIndex = 6;
            this.btnSourceFile.Text = "选择";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // ioc1
            // 
            this.ioc1.Icon = ((System.Drawing.Icon)(resources.GetObject("ioc1.Icon")));
            this.ioc1.Text = "Convert";
            this.ioc1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 189);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.lblSourceFile);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "视频编码转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.NotifyIcon ioc1;
    }
}

