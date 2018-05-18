using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace datalogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 显示当前日期
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();         //定义打开文件
            filename.InitialDirectory = Application.StartupPath;    //初始路径，
            filename.Filter = "所有文件(*log*)|*.log*";             //设置打开类型为.log文件
            filename.FilterIndex = 1;           //设置文本显示顺序（log文件为第一位）    
            filename.RestoreDirectory = true;   //对话框记录之前打开的目录
            filename.Multiselect = true;
            if (filename.ShowDialog(this) == DialogResult.OK)
            {
                if (filename.FileName != " ")
                {
                    foreach (string s in filename.FileNames)    //遍历完所有文件，并逐条显示
                    {
                        txt_filepath.Text += s + ",";   //显示路径到文本框
                    }
                }
                
            }
        }

        // 查询匹配
        private void btn_look_Click(object sender, EventArgs e)
        {
            // 显示当前查询的条件
            lbl_condition.Text = txt_look_contdition.Text;
            // 查询条件
            string tiaojian = @txt_look_contdition.Text;

            String RegexStr = string.Empty;
            string str_fp = @"(.*?log:\d+?.\d+?.\d+?.\d+? - - \[.*?\] .?GET .+?";
            string ste_pp = @".+?\d+? .?-.? .*? .?-.? .*? \d+?.\d+?.\d+?.\d+?.\d+? 0.\d+)+?";
            // 正则
            RegexStr = str_fp + tiaojian + ste_pp;
            string file_open_path = txt_filepath.Text.Substring(0, txt_filepath.Text.Length - 1); //正常使用
            string[] strArray = file_open_path.Split(',');
            // 统计开始
            for (int i = 0; i < strArray.Length; i++)
            {
                StreamReader sr = new StreamReader(strArray[i].ToString(), Encoding.Default);
                string content;
                while ((content = sr.ReadLine()) != null)
                {
                    String str_content = sr.ReadToEnd();
                    if (tiaojian != string.Empty)
                    {
                        Regex r = new Regex(RegexStr, RegexOptions.IgnoreCase);
                        Match m = r.Match(str_content);

                        // 统计
                        while (m.Success)
                        {
                            Group g = m.Groups[1];
                            m = m.NextMatch();
                            txt_showall.Text += m + "\r\n";
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入要查询的条件：如anli, 200 ");
                    }

                }
            }

        }
           

        // 查询和统计
        private void btn_look_tj_Click(object sender, EventArgs e)
        {
            // 显示当前查询的条件
            lbl_condition.Text = txt_look_contdition.Text;

            // 获取输入查询条件
            var list = @txt_look_contdition.Text.Split(',');
            foreach (var li in list)
            {
                int mathcount = 0;
                string file_open_path = txt_filepath.Text.Substring(0, txt_filepath.Text.Length - 1); //正常使用
                // 读取文件内容
                string[] strArray = file_open_path.Split(',');
                // 统计开始
                for (int i = 0; i < strArray.Length; i++)
                {
                    StreamReader sr = new StreamReader(strArray[i].ToString(), Encoding.Default);
                    string content;
                    while ((content = sr.ReadLine()) != null)
                    {
                        String str_content = sr.ReadToEnd();
                        if (li != string.Empty)
                        {
                            Regex r = new Regex(li, RegexOptions.IgnoreCase);
                            Match m = r.Match(str_content);

                            // 统计
                            while (m.Success)
                            {
                                ++mathcount;
                                Group g = m.Groups[1];
                                m = m.NextMatch();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请输入要查询的条件：如anli, 200 ");
                        }
                    }
                }
                txt_showall.Text += "查询条件:" + li + "\t\t统计数量:" + mathcount + "\r\n";
            }
        }

        // 统计
        private void btn_tj_Click(object sender, EventArgs e)
        {
            // 显示当前查询的条件
            lbl_condition.Text = txt_look_contdition.Text;

            // 获取输入查询条件
            var list = @txt_look_contdition.Text.Split(',');
            foreach (var li in list)
            {
                int mathcount = 0;
                string file_open_path = txt_filepath.Text.Substring(0, txt_filepath.Text.Length - 1); //正常使用
                // 读取文件内容
                string[] strArray = file_open_path.Split(',');
                // 统计开始
                for (int i = 0; i < strArray.Length; i++)
                {
                    StreamReader sr = new StreamReader(strArray[i].ToString(), Encoding.Default);
                    string content;
                    while ((content = sr.ReadLine()) != null)
                    {
                        String str_content = sr.ReadToEnd();
                        if (li != string.Empty)
                        {
                            Regex r = new Regex(li, RegexOptions.IgnoreCase);
                            Match m = r.Match(str_content);

                            // 统计
                            while (m.Success)
                            {
                                ++mathcount;
                                Group g = m.Groups[1];
                                m = m.NextMatch();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请输入要查询的条件：如anli, 200 ");
                        }
                    }
                }
                txt_showall.Text += mathcount + "\r\n";

            }
        }

        private void bnt_clear_Click(object sender, EventArgs e)
        {
            txt_showall.Clear();
        }
    }
}
