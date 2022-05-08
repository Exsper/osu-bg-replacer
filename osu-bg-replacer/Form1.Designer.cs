
namespace osu_bg_replacer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DirectorySelectButton = new System.Windows.Forms.Button();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceDirectoryPath = new System.Windows.Forms.TextBox();
            this.ReplaceDirectorySelectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ElementListBox = new System.Windows.Forms.CheckedListBox();
            this.ReplaceElementListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GetFilesButton = new System.Windows.Forms.Button();
            this.GetReplaceFilesButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "osu!所在文件夹：";
            // 
            // DirectorySelectButton
            // 
            this.DirectorySelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DirectorySelectButton.Location = new System.Drawing.Point(561, 5);
            this.DirectorySelectButton.Name = "DirectorySelectButton";
            this.DirectorySelectButton.Size = new System.Drawing.Size(75, 22);
            this.DirectorySelectButton.TabIndex = 8;
            this.DirectorySelectButton.Text = "浏览...";
            this.DirectorySelectButton.UseVisualStyleBackColor = true;
            this.DirectorySelectButton.Click += new System.EventHandler(this.DirectorySelectButton_Click);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(140, 6);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(415, 21);
            this.DirectoryPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "替换图片所在文件夹：";
            // 
            // ReplaceDirectoryPath
            // 
            this.ReplaceDirectoryPath.Location = new System.Drawing.Point(140, 38);
            this.ReplaceDirectoryPath.Name = "ReplaceDirectoryPath";
            this.ReplaceDirectoryPath.Size = new System.Drawing.Size(415, 21);
            this.ReplaceDirectoryPath.TabIndex = 11;
            // 
            // ReplaceDirectorySelectButton
            // 
            this.ReplaceDirectorySelectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReplaceDirectorySelectButton.Location = new System.Drawing.Point(561, 36);
            this.ReplaceDirectorySelectButton.Name = "ReplaceDirectorySelectButton";
            this.ReplaceDirectorySelectButton.Size = new System.Drawing.Size(75, 22);
            this.ReplaceDirectorySelectButton.TabIndex = 12;
            this.ReplaceDirectorySelectButton.Text = "浏览...";
            this.ReplaceDirectorySelectButton.UseVisualStyleBackColor = true;
            this.ReplaceDirectorySelectButton.Click += new System.EventHandler(this.ReplaceDirectorySelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "替换图片必须为jpg格式，推荐图像大小为2732x1536";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ElementListBox
            // 
            this.ElementListBox.FormattingEnabled = true;
            this.ElementListBox.Location = new System.Drawing.Point(14, 129);
            this.ElementListBox.Name = "ElementListBox";
            this.ElementListBox.Size = new System.Drawing.Size(323, 260);
            this.ElementListBox.TabIndex = 14;
            // 
            // ReplaceElementListBox
            // 
            this.ReplaceElementListBox.FormattingEnabled = true;
            this.ReplaceElementListBox.Location = new System.Drawing.Point(387, 129);
            this.ReplaceElementListBox.Name = "ReplaceElementListBox";
            this.ReplaceElementListBox.Size = new System.Drawing.Size(323, 260);
            this.ReplaceElementListBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "原始图片";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "替换图片";
            // 
            // GetFilesButton
            // 
            this.GetFilesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetFilesButton.Location = new System.Drawing.Point(642, 5);
            this.GetFilesButton.Name = "GetFilesButton";
            this.GetFilesButton.Size = new System.Drawing.Size(89, 22);
            this.GetFilesButton.TabIndex = 18;
            this.GetFilesButton.Text = "获取图片列表";
            this.GetFilesButton.UseVisualStyleBackColor = true;
            this.GetFilesButton.Click += new System.EventHandler(this.GetFilesButton_Click);
            // 
            // GetReplaceFilesButton
            // 
            this.GetReplaceFilesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetReplaceFilesButton.Location = new System.Drawing.Point(642, 36);
            this.GetReplaceFilesButton.Name = "GetReplaceFilesButton";
            this.GetReplaceFilesButton.Size = new System.Drawing.Size(89, 22);
            this.GetReplaceFilesButton.TabIndex = 19;
            this.GetReplaceFilesButton.Text = "获取图片列表";
            this.GetReplaceFilesButton.UseVisualStyleBackColor = true;
            this.GetReplaceFilesButton.Click += new System.EventHandler(this.GetReplaceFilesButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReplaceButton.Location = new System.Drawing.Point(635, 413);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 22);
            this.ReplaceButton.TabIndex = 20;
            this.ReplaceButton.Text = "替换";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 454);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.GetReplaceFilesButton);
            this.Controls.Add(this.GetFilesButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReplaceElementListBox);
            this.Controls.Add(this.ElementListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReplaceDirectorySelectButton);
            this.Controls.Add(this.ReplaceDirectoryPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectorySelectButton);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "替换osu!默认背景";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DirectorySelectButton;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReplaceDirectoryPath;
        private System.Windows.Forms.Button ReplaceDirectorySelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ElementListBox;
        private System.Windows.Forms.CheckedListBox ReplaceElementListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetFilesButton;
        private System.Windows.Forms.Button GetReplaceFilesButton;
        private System.Windows.Forms.Button ReplaceButton;
    }
}

