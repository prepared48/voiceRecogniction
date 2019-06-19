namespace WindowsFormsApplication1
{
    partial class form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voiceResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.videoType = new System.Windows.Forms.ComboBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.Speech_Synthesis = new System.Windows.Forms.TextBox();
            this.语音合成 = new System.Windows.Forms.GroupBox();
            this.synthesisButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.语音合成.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voiceResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.videoType);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音识别";
            // 
            // voiceResult
            // 
            this.voiceResult.Location = new System.Drawing.Point(23, 154);
            this.voiceResult.Multiline = true;
            this.voiceResult.Name = "voiceResult";
            this.voiceResult.Size = new System.Drawing.Size(277, 98);
            this.voiceResult.TabIndex = 6;
            this.voiceResult.TextChanged += new System.EventHandler(this.voiceResult_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "识别结果";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "开始识别";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "音频格式";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // videoType
            // 
            this.videoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoType.FormattingEnabled = true;
            this.videoType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.videoType.Items.AddRange(new object[] {
            "PCM",
            "WAV",
            "AMR"});
            this.videoType.Location = new System.Drawing.Point(95, 83);
            this.videoType.Name = "videoType";
            this.videoType.Size = new System.Drawing.Size(123, 20);
            this.videoType.TabIndex = 1;
            this.videoType.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(23, 32);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(195, 21);
            this.filePath.TabIndex = 0;
            this.filePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Speech_Synthesis
            // 
            this.Speech_Synthesis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Speech_Synthesis.Location = new System.Drawing.Point(15, 20);
            this.Speech_Synthesis.Multiline = true;
            this.Speech_Synthesis.Name = "Speech_Synthesis";
            this.Speech_Synthesis.Size = new System.Drawing.Size(268, 219);
            this.Speech_Synthesis.TabIndex = 2;
            this.Speech_Synthesis.Text = "北京航空航天大学";
            this.Speech_Synthesis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // 语音合成
            // 
            this.语音合成.Controls.Add(this.synthesisButton);
            this.语音合成.Controls.Add(this.Speech_Synthesis);
            this.语音合成.Location = new System.Drawing.Point(378, 31);
            this.语音合成.Name = "语音合成";
            this.语音合成.Size = new System.Drawing.Size(301, 278);
            this.语音合成.TabIndex = 4;
            this.语音合成.TabStop = false;
            this.语音合成.Text = "语音合成";
            // 
            // synthesisButton
            // 
            this.synthesisButton.Location = new System.Drawing.Point(193, 246);
            this.synthesisButton.Name = "synthesisButton";
            this.synthesisButton.Size = new System.Drawing.Size(75, 23);
            this.synthesisButton.TabIndex = 3;
            this.synthesisButton.Text = "开始合成";
            this.synthesisButton.UseVisualStyleBackColor = true;
            this.synthesisButton.Click += new System.EventHandler(this.synthesisButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 428);
            this.Controls.Add(this.语音合成);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "AI-语音";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.语音合成.ResumeLayout(false);
            this.语音合成.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox videoType;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TextBox Speech_Synthesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox voiceResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox 语音合成;
        private System.Windows.Forms.Button synthesisButton;
    }
}

