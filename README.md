开发工具：vs 2017

AI 平台：http://ai.baidu.com/

# 准备工作

1、注册百度账号

2、登录百度 AI 开发平台，http://ai.baidu.com/

3、在控制台点击“百度语音”服务，点击“创建应用”，填写必填项，勾选额外接口，点击立即创建获取秘钥。在应用列表中查看自己的id

![](https://github.com/zhongsb/voiceRecogniction/blob/master/images/1.png)

用 360 软件管家安装 vs2017 

![](https://github.com/zhongsb/voiceRecogniction/blob/master/images/2.png)

# 创建自己的项目

## 1、新建项目

打开 vs2017，点击文件，新建项目，选择 visual C# --> windows 桌面 --> windows 窗体应用，选择自己的项目地址，点击确定

![](https://github.com/zhongsb/voiceRecogniction/blob/master/images/3.jpg)


## 2、添加 baiduai 开发包

点击引用 --> 管理 nuGet 程序包，搜索 baiduai，点击下载

![](https://github.com/zhongsb/voiceRecogniction/blob/master/images/4.png)

## 3、UI 设计

直接拖动即可，生成界面如下

![](https://github.com/zhongsb/voiceRecogniction/blob/master/images/5.png)

## 4、后台功能实现

选择文件按钮

    private void button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog fdlg = new OpenFileDialog();
        fdlg.Title = "C# Corner Open File Dialog";
        //fdlg.InitialDirectory = @"c:/";   //@是取消转义字符的意思
        //fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
        ///*
        // * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
        // * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
        // */
        fdlg.FilterIndex = 2;
        ///*
        // *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
        // *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
        // */
        //fdlg.RestoreDirectory = true;
        if (fdlg.ShowDialog() == DialogResult.OK)
        {
            //textBox1.Text = System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName);
            filePath.Text = System.IO.Path.GetFullPath(fdlg.FileName);
    
        }
    }

开始识别按钮

    // 语音合成按钮
    private void button2_Click(object sender, EventArgs e)
    {
        string value = this.videoType.Text;
        String filePath = this.filePath.Text;
        // 设置APPID/AK/SK
        String APP_ID = "14433392";
        String API_KEY = "C7WMYgLeWv3Wm2yogwv5gD08";
        String SECRET_KEY = "xcvwiwikALBDBaIcGisNQ6aQImtj3qua";
        var client = new Asr(APP_ID, API_KEY, SECRET_KEY);
        client.Timeout = 60000;  // 修改超时时间
        client.Timeout = 120000; // 若语音较长，建议设置更大的超时时间. ms
        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] buffur = new byte[fs.Length];
        try
        {
            fs.Read(buffur, 0, (int)fs.Length);
    
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
        }
        finally
        {
            if (fs != null)
            {
                //关闭资源  
                fs.Close();
            }
        }
        var result = client.Recognize(buffur, value, 16000);
        Convert.ToString(result);
    
        JToken resultStr = null;
        result.TryGetValue("result", out resultStr);
        Console.WriteLine("aToken===>"+ resultStr);
        voiceResult.Text = Convert.ToString(resultStr);
        Console.Write(result);
    }

开始合成按钮

调用 api 中 C# SDK 的语音合成 api

https://ai.baidu.com/docs#/ASR-Online-Csharp-SDK/top

    // 开始合成按钮（语音合成功能）
    private void synthesisButton_Click(object sender, EventArgs e)
    {
        String APP_ID = "14433392";
        String API_KEY = "C7WMYgLeWv3Wm2yogwv5gD08";
        String SECRET_KEY = "xcvwiwikALBDBaIcGisNQ6aQImtj3qua";
        // 获取输入框的值
        String value = this.Speech_Synthesis.Text;
        // 将 value 转成语音文件存放到本地
        var client = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);
        // 可选参数
        var option = new Dictionary<string, object>()
        {
            {"spd", 5}, // 语速
            {"vol", 7}, // 音量
            {"per", 3}  // 发音人，4：情感度丫丫童声
        };
        var result = client.Synthesis(value, option);
        try {
            if (result.ErrorCode == 0) { // 或 result.Success
                File.WriteAllBytes("E:/prepared/北航/07_工程实践--AI方向/作业/WindowsFormsApplication1/WindowsFormsApplication1/tmp.mp3", result.Data);
            }
    
        } catch (Exception ex) { Console.Write(ex.StackTrace); }
        Play();
    }


[1]: /img/bVbmvNT
[2]: /img/bVbmvNU
[3]: /img/bVbmvNW
[4]: /img/bVbmvNX
[5]: /img/bVbmvN0

