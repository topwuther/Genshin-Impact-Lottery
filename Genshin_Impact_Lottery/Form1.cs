using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Genshin_Impact_LotteryApplication
{
    public partial class Form1 : Form
    {
        private int result;
        int[] numList;
        int[] numList2;
        int sum;
        bool[] flag = { false, false, false,false };
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vlcControl1.Width = 1920;
            vlcControl1.Height = 1080;
            CheckForIllegalCrossThreadCalls = false;
            this.WindowState = FormWindowState.Maximized;
            this.Cursor = new Cursor(@"cursor.ico");
        }

        private void pictureBox1_Click(object sender, EventArgs e) => ClickFunction();

        private void label1_Click(object sender, EventArgs e) => ClickFunction();
        private void ClickFunction()
        {
            vlcControl1.Visible = true;
            int temp = rd.Next(1,sum);
            MessageBox.Show(Convert.ToString(temp));
            if (temp <= numList2[0]) 
            {
                result = 1;
                vlcControl1.Play(new FileInfo("1.mp4"));
            }
            else if (temp <= SumList(numList2, 0, 1))
            {
                result = 2;
                vlcControl1.Play(new FileInfo("2.mp4"));
            }
            else if (temp <= SumList(numList2, 0, 2))
            {
                result = 3;
                vlcControl1.Play(new FileInfo("2.mp4"));
            }
            else if (temp <= SumList(numList2, 0, 3))
            {
                result = 4;
                vlcControl1.Play(new FileInfo("2.mp4"));
            }
            else
            {
                result = 5;
                vlcControl1.Play(new FileInfo("3.mp4"));
            }
        }

        private int SumList(int[] numList, int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++) {
                sum += numList[i];
            }
            return sum;
        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }
        private void vlcControl1_Stopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            vlcControl1.Visible = false;
            if (result == 1) {
                label5.Text = "恭喜你，获得了特等奖";
                label5.ForeColor = Color.Gold;
                numList[0] -= 1;
            }
            else if (result == 2)
            {
                numList[1] -= 1;
                label5.ForeColor = Color.BlueViolet;
                label5.Text = "恭喜你，获得了一等奖";
            }
            else if (result == 3)
            {
                numList[2] -= 1;
                label5.ForeColor = Color.BlueViolet;
                label5.Text = "恭喜你，获得了二等奖";
            }
            else if (result == 4)
            {
                numList[3] -= 1;
                label5.ForeColor = Color.BlueViolet;
                label5.Text = "恭喜你，获得了三等奖";
            }
            else
            {
                numList[4] -= 1;
                label5.ForeColor = Color.SkyBlue;
                label5.Text = "恭喜你，获得了纪念奖";
            }
            label5.Visible = true;
            num.Text = toStr(numList);
        }

        private string toStr(int[] numList)
        {
            string temp = "";
            for (int i = 0; i < numList.Length; i++) {
                temp += Convert.ToString(numList[i])+"\n";
            }
            return temp;
        }

        private void Title_Click(object sender, EventArgs e)
        {
            sum = 1;
            int num = 5;
            numList = new int[num];
            numList2 = new int[num];
            string temp = "";
            for (int i = 0; i < num; i++) {
                string input = Interaction.InputBox(String.Format("{0}等奖个数", Convert.ToString(i + 1)), "配置奖池");
                try { 
                numList[i] = Convert.ToInt32(input);
                numList2[i] = Convert.ToInt32(input);
                }
                catch
                {
                    return;
                }
                sum += Convert.ToInt32(input);
                temp += input + "\n";
            }
            this.num.Text = count.Text = temp;
        }

        private void pictureBox2_Click(object sender, EventArgs e) => flag[0] = true;

        private void pictureBox4_Click(object sender, EventArgs e) => flag[1] = true;

        private void pictureBox6_Click(object sender, EventArgs e) => flag[2] = true;

        private void pictureBox5_Click(object sender, EventArgs e) => flag[3] = true;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flag.Length; i++) {
                if (!flag[i]) {
                    flag[0] = flag[1] = flag[2] = flag[3] = false;
                    return;
                }
            }
            int input = 0;
            int input2 = 0;
            try
            {
                input = Convert.ToInt32(Interaction.InputBox(""));
                input2 = Convert.ToInt32(Interaction.InputBox(""));
            }
            catch {
                return;
            }
            numList[input] -= input2;
            num.Text = toStr(numList);
        }
    }
}
