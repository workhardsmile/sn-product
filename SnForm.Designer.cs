namespace SnProduct
{
    partial class SnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnForm));
            this.textVersion = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.labelSn = new System.Windows.Forms.Label();
            this.textSn = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonEncry2 = new System.Windows.Forms.Button();
            this.buttonEncry1 = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.checkIsKey = new System.Windows.Forms.CheckBox();
            this.dateOver = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDecry = new System.Windows.Forms.Button();
            this.textFromSn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textToSn = new System.Windows.Forms.TextBox();
            this.text2Key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textVersion
            // 
            this.textVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textVersion.Location = new System.Drawing.Point(88, 11);
            this.textVersion.Name = "textVersion";
            this.textVersion.Size = new System.Drawing.Size(241, 21);
            this.textVersion.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(8, 14);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(53, 12);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "版本号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "授权次数：";
            // 
            // textCount
            // 
            this.textCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textCount.Location = new System.Drawing.Point(88, 41);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(241, 21);
            this.textCount.TabIndex = 2;
            // 
            // labelSn
            // 
            this.labelSn.AutoSize = true;
            this.labelSn.Location = new System.Drawing.Point(8, 134);
            this.labelSn.Name = "labelSn";
            this.labelSn.Size = new System.Drawing.Size(53, 12);
            this.labelSn.TabIndex = 5;
            this.labelSn.Text = "序列号：";
            // 
            // textSn
            // 
            this.textSn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textSn.Location = new System.Drawing.Point(88, 131);
            this.textSn.Name = "textSn";
            this.textSn.Size = new System.Drawing.Size(241, 21);
            this.textSn.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 226);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEncry2);
            this.tabPage1.Controls.Add(this.buttonEncry1);
            this.tabPage1.Controls.Add(this.textKey);
            this.tabPage1.Controls.Add(this.checkIsKey);
            this.tabPage1.Controls.Add(this.dateOver);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textVersion);
            this.tabPage1.Controls.Add(this.labelSn);
            this.tabPage1.Controls.Add(this.labelText);
            this.tabPage1.Controls.Add(this.textSn);
            this.tabPage1.Controls.Add(this.textCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "加密";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEncry2
            // 
            this.buttonEncry2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncry2.Location = new System.Drawing.Point(254, 158);
            this.buttonEncry2.Name = "buttonEncry2";
            this.buttonEncry2.Size = new System.Drawing.Size(75, 23);
            this.buttonEncry2.TabIndex = 12;
            this.buttonEncry2.Text = "二次加密";
            this.buttonEncry2.UseVisualStyleBackColor = true;
            this.buttonEncry2.Click += new System.EventHandler(this.buttonEncry2_Click);
            // 
            // buttonEncry1
            // 
            this.buttonEncry1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncry1.Location = new System.Drawing.Point(164, 158);
            this.buttonEncry1.Name = "buttonEncry1";
            this.buttonEncry1.Size = new System.Drawing.Size(75, 23);
            this.buttonEncry1.TabIndex = 11;
            this.buttonEncry1.Text = "一次加密";
            this.buttonEncry1.UseVisualStyleBackColor = true;
            this.buttonEncry1.Click += new System.EventHandler(this.buttonEncry1_Click);
            // 
            // textKey
            // 
            this.textKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textKey.Location = new System.Drawing.Point(88, 100);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(241, 21);
            this.textKey.TabIndex = 10;
            // 
            // checkIsKey
            // 
            this.checkIsKey.AutoSize = true;
            this.checkIsKey.Location = new System.Drawing.Point(10, 105);
            this.checkIsKey.Name = "checkIsKey";
            this.checkIsKey.Size = new System.Drawing.Size(72, 16);
            this.checkIsKey.TabIndex = 9;
            this.checkIsKey.Text = "设置密钥";
            this.checkIsKey.UseVisualStyleBackColor = true;
            this.checkIsKey.CheckedChanged += new System.EventHandler(this.checkIsKey_CheckedChanged);
            // 
            // dateOver
            // 
            this.dateOver.Location = new System.Drawing.Point(88, 68);
            this.dateOver.Name = "dateOver";
            this.dateOver.Size = new System.Drawing.Size(241, 21);
            this.dateOver.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "截止日期：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDecry);
            this.tabPage2.Controls.Add(this.textFromSn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textToSn);
            this.tabPage2.Controls.Add(this.text2Key);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "解密";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDecry
            // 
            this.buttonDecry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecry.Location = new System.Drawing.Point(254, 103);
            this.buttonDecry.Name = "buttonDecry";
            this.buttonDecry.Size = new System.Drawing.Size(75, 23);
            this.buttonDecry.TabIndex = 14;
            this.buttonDecry.Text = "解密";
            this.buttonDecry.UseVisualStyleBackColor = true;
            this.buttonDecry.Click += new System.EventHandler(this.buttonDecry_Click);
            // 
            // textFromSn
            // 
            this.textFromSn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textFromSn.Location = new System.Drawing.Point(77, 17);
            this.textFromSn.Name = "textFromSn";
            this.textFromSn.Size = new System.Drawing.Size(252, 21);
            this.textFromSn.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "解密串：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "加密串：";
            // 
            // textToSn
            // 
            this.textToSn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textToSn.Location = new System.Drawing.Point(77, 76);
            this.textToSn.Name = "textToSn";
            this.textToSn.Size = new System.Drawing.Size(252, 21);
            this.textToSn.TabIndex = 12;
            // 
            // text2Key
            // 
            this.text2Key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text2Key.Location = new System.Drawing.Point(77, 47);
            this.text2Key.Name = "text2Key";
            this.text2Key.Size = new System.Drawing.Size(252, 21);
            this.text2Key.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "密钥：";
            // 
            // SnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 229);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SnForm";
            this.Text = "加密解密";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textVersion;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label labelSn;
        private System.Windows.Forms.TextBox textSn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkIsKey;
        private System.Windows.Forms.DateTimePicker dateOver;
        private System.Windows.Forms.TextBox textFromSn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textToSn;
        private System.Windows.Forms.TextBox text2Key;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEncry2;
        private System.Windows.Forms.Button buttonEncry1;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Button buttonDecry;
    }
}

