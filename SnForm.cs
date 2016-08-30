using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnProduct
{
    public partial class SnForm : Form
    {
        public SnForm()
        {
            InitializeComponent();
        }

        private void checkIsKey_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkIsKey.Checked)
            {
                this.labelText.Text = "被加密串";
                this.textCount.Enabled = false;
                this.dateOver.Enabled = false;
                this.labelSn.Text = "加密串";
            }
            else
            {
                this.labelText.Text = "版本号";
                this.textCount.Enabled = true;
                this.dateOver.Enabled = true;
                this.labelSn.Text = "序列号";
            }
        }

        private void buttonEncry1_Click(object sender, EventArgs e)
        {
            string version = this.textVersion.Text.Trim();
            string key = this.textKey.Text.Trim();
            string countStr = this.textCount.Text.Trim();
            string dateEnd = this.dateOver.Value.ToString("yyyy-MM-dd");
            EncryDecryUtil edu;

            if (this.checkIsKey.Checked)
            {
                if (version.Equals("")||key.Equals(""))
                {
                    MessageBox.Show("被加密串和密钥不能为空！", "信息提示");
                    return;
                }
                edu = new EncryDecryUtil();
                string sn = edu.EncryptString(version, key);
                this.textSn.Text = sn;
            }
            else
            {
                long count=1;
                if (version.Equals("") || countStr.Equals(""))
                {
                    MessageBox.Show("版本号和授权次数不能为空！", "信息提示");
                    return;
                }
                try
                {
                    count = Convert.ToInt64(countStr);
                    if (count > 1000)
                    {
                        MessageBox.Show("授权次数不能大于1000次！", "信息提示");
                        return;
                    }
                }
                catch { }
                edu = new EncryDecryUtil();
                string sn = edu.EncryptString("$`" + dateEnd + "`" + count +"`update`$", "iron" + version.Replace(".", ""));
                this.textSn.Text = sn;
            }
        }

        private void buttonEncry2_Click(object sender, EventArgs e)
        {
            string version = this.textVersion.Text.Trim();
            string key = this.textKey.Text.Trim();
            string countStr = this.textCount.Text.Trim();
            string dateEnd = this.dateOver.Value.ToString("yyyy-MM-dd");
            EncryDecryUtil edu;
            string time = DateTime.Now.AddHours(3).AddSeconds(-5).ToString("ddHHmmss");

            if (this.checkIsKey.Checked)
            {
                if (version.Equals("") || key.Equals(""))
                {
                    MessageBox.Show("被加密串和密钥不能为空！", "信息提示");
                    return;
                }
                edu = new EncryDecryUtil();
                string sn0 = edu.EncryptString(version, time);
                string sn = edu.EncryptString("E2`"+sn0 + "`" + time, key);
                this.textSn.Text = sn;

            }
            else
            {
                long count = 1;
                if (version.Equals("") || countStr.Equals(""))
                {
                    MessageBox.Show("版本号、序列号和授权次数不能为空！", "信息提示");
                    return;
                }
                try
                {
                    count = Convert.ToInt64(countStr);
                    if (count > 1000)
                    {
                        MessageBox.Show("授权次数不能大于1000次！", "信息提示");
                        return;
                    }
                }
                catch { }
                edu = new EncryDecryUtil();
                string sn0 = edu.EncryptString("$`" + dateEnd + "`" + count + "`update`$", time);
                string sn = edu.EncryptString("E2`" + sn0 + "`" + time, "iron" + version.Replace(".", ""));
                this.textSn.Text = sn;
            }
        }

        private void buttonDecry_Click(object sender, EventArgs e)
        {
            string snFrom = this.textFromSn.Text.Trim();
            string key = this.text2Key.Text.Trim();
            EncryDecryUtil edu;
            if (snFrom.Equals("") | key.Equals(""))
            {
                MessageBox.Show("加密串和密钥不能为空！", "信息提示");
                return;
            }
            edu = new EncryDecryUtil();
            string sn = edu.DecryptString(snFrom, key);
            this.textToSn.Text = sn;
        }
    }
}
