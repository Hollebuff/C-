namespace datalogo
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
            this.components = new System.ComponentModel.Container();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_look_contdition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_look = new System.Windows.Forms.Button();
            this.btn_tj = new System.Windows.Forms.Button();
            this.btn_look_tj = new System.Windows.Forms.Button();
            this.txt_showall = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_condition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.bnt_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(118, 35);
            this.txt_filepath.Multiline = true;
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(350, 64);
            this.txt_filepath.TabIndex = 0;
            // 
            // btn_open_file
            // 
            this.btn_open_file.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_open_file.Location = new System.Drawing.Point(489, 39);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(170, 60);
            this.btn_open_file.TabIndex = 1;
            this.btn_open_file.Text = "打开文件";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择文件：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "打开文件";
            // 
            // txt_look_contdition
            // 
            this.txt_look_contdition.Location = new System.Drawing.Point(118, 129);
            this.txt_look_contdition.Multiline = true;
            this.txt_look_contdition.Name = "txt_look_contdition";
            this.txt_look_contdition.Size = new System.Drawing.Size(350, 90);
            this.txt_look_contdition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(11, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "查询条件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "多个条件查询时候，请用符号,分开";
            // 
            // btn_look
            // 
            this.btn_look.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_look.Location = new System.Drawing.Point(489, 129);
            this.btn_look.Name = "btn_look";
            this.btn_look.Size = new System.Drawing.Size(85, 45);
            this.btn_look.TabIndex = 6;
            this.btn_look.Text = "查询匹配";
            this.btn_look.UseVisualStyleBackColor = true;
            this.btn_look.Click += new System.EventHandler(this.btn_look_Click);
            // 
            // btn_tj
            // 
            this.btn_tj.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_tj.Location = new System.Drawing.Point(576, 129);
            this.btn_tj.Name = "btn_tj";
            this.btn_tj.Size = new System.Drawing.Size(85, 45);
            this.btn_tj.TabIndex = 7;
            this.btn_tj.Text = "统计";
            this.btn_tj.UseVisualStyleBackColor = true;
            this.btn_tj.Click += new System.EventHandler(this.btn_tj_Click);
            // 
            // btn_look_tj
            // 
            this.btn_look_tj.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_look_tj.Location = new System.Drawing.Point(490, 180);
            this.btn_look_tj.Name = "btn_look_tj";
            this.btn_look_tj.Size = new System.Drawing.Size(170, 45);
            this.btn_look_tj.TabIndex = 8;
            this.btn_look_tj.Text = "查询条件和统计";
            this.btn_look_tj.UseVisualStyleBackColor = true;
            this.btn_look_tj.Click += new System.EventHandler(this.btn_look_tj_Click);
            // 
            // txt_showall
            // 
            this.txt_showall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_showall.Location = new System.Drawing.Point(12, 299);
            this.txt_showall.Multiline = true;
            this.txt_showall.Name = "txt_showall";
            this.txt_showall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_showall.Size = new System.Drawing.Size(1014, 305);
            this.txt_showall.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 18F);
            this.button4.Location = new System.Drawing.Point(810, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 139);
            this.button4.TabIndex = 10;
            this.button4.Text = "嗯？？还没想好做什么";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "当前查询条件：";
            // 
            // lbl_condition
            // 
            this.lbl_condition.AutoSize = true;
            this.lbl_condition.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_condition.Location = new System.Drawing.Point(167, 277);
            this.lbl_condition.Name = "lbl_condition";
            this.lbl_condition.Size = new System.Drawing.Size(0, 12);
            this.lbl_condition.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "当前日期：";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(527, 276);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 12);
            this.lbl_date.TabIndex = 14;
            // 
            // bnt_clear
            // 
            this.bnt_clear.Font = new System.Drawing.Font("宋体", 12F);
            this.bnt_clear.Location = new System.Drawing.Point(681, 106);
            this.bnt_clear.Name = "bnt_clear";
            this.bnt_clear.Size = new System.Drawing.Size(95, 64);
            this.bnt_clear.TabIndex = 15;
            this.bnt_clear.Text = "清除内容";
            this.bnt_clear.UseVisualStyleBackColor = true;
            this.bnt_clear.Click += new System.EventHandler(this.bnt_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "必须输入文件路径，否则出错！！";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnt_clear);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_condition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_showall);
            this.Controls.Add(this.btn_look_tj);
            this.Controls.Add(this.btn_tj);
            this.Controls.Add(this.btn_look);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_look_contdition);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "网站日志分析工具1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_look_contdition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_look;
        private System.Windows.Forms.Button btn_tj;
        private System.Windows.Forms.Button btn_look_tj;
        private System.Windows.Forms.TextBox txt_showall;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_condition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button bnt_clear;
        private System.Windows.Forms.Label label5;
    }
}

