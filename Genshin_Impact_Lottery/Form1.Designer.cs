namespace Genshin_Impact_LotteryApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.go = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.backdoor1 = new System.Windows.Forms.PictureBox();
            this.backdoor5 = new System.Windows.Forms.PictureBox();
            this.backdoor2 = new System.Windows.Forms.PictureBox();
            this.backdoor4 = new System.Windows.Forms.PictureBox();
            this.backdoor3 = new System.Windows.Forms.PictureBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Genshin_Impact_Lottery.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(1273, 864);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.BackColor = System.Drawing.Color.White;
            this.go.Font = new System.Drawing.Font("隶书", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.go.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(197)))), ((int)(((byte)(140)))));
            this.go.Location = new System.Drawing.Point(1409, 888);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(97, 40);
            this.go.TabIndex = 1;
            this.go.Text = "祈愿";
            this.go.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("隶书", 40F);
            this.title.Location = new System.Drawing.Point(872, 134);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(165, 67);
            this.title.TabIndex = 3;
            this.title.Text = "奖池";
            this.title.Click += new System.EventHandler(this.Title_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Font = new System.Drawing.Font("隶书", 30F);
            this.text.Location = new System.Drawing.Point(600, 256);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(672, 250);
            this.text.TabIndex = 4;
            this.text.Text = "特等奖：        剩余数量：\r\n一等奖：        剩余数量：\r\n二等奖：        剩余数量：\r\n三等奖：        剩余数量：\r\n纪念奖： " +
    "       剩余数量：\r\n";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Font = new System.Drawing.Font("隶书", 30F);
            this.num.Location = new System.Drawing.Point(1278, 262);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(47, 250);
            this.num.TabIndex = 5;
            this.num.Text = "0\r\n0\r\n0\r\n0\r\n0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("隶书", 50F);
            this.label5.Location = new System.Drawing.Point(433, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 84);
            this.label5.TabIndex = 6;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Transparent;
            this.count.Font = new System.Drawing.Font("隶书", 30F);
            this.count.Location = new System.Drawing.Point(813, 262);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(47, 250);
            this.count.TabIndex = 7;
            this.count.Text = "0\r\n0\r\n0\r\n0\r\n0";
            // 
            // backdoor1
            // 
            this.backdoor1.BackColor = System.Drawing.Color.Transparent;
            this.backdoor1.Location = new System.Drawing.Point(400, 101);
            this.backdoor1.Name = "backdoor1";
            this.backdoor1.Size = new System.Drawing.Size(100, 50);
            this.backdoor1.TabIndex = 8;
            this.backdoor1.TabStop = false;
            this.backdoor1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // backdoor5
            // 
            this.backdoor5.BackColor = System.Drawing.Color.Transparent;
            this.backdoor5.Location = new System.Drawing.Point(400, 320);
            this.backdoor5.Name = "backdoor5";
            this.backdoor5.Size = new System.Drawing.Size(100, 50);
            this.backdoor5.TabIndex = 9;
            this.backdoor5.TabStop = false;
            this.backdoor5.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // backdoor2
            // 
            this.backdoor2.BackColor = System.Drawing.Color.Transparent;
            this.backdoor2.Location = new System.Drawing.Point(213, 212);
            this.backdoor2.Name = "backdoor2";
            this.backdoor2.Size = new System.Drawing.Size(100, 50);
            this.backdoor2.TabIndex = 10;
            this.backdoor2.TabStop = false;
            this.backdoor2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // backdoor4
            // 
            this.backdoor4.BackColor = System.Drawing.Color.Transparent;
            this.backdoor4.Location = new System.Drawing.Point(590, 212);
            this.backdoor4.Name = "backdoor4";
            this.backdoor4.Size = new System.Drawing.Size(100, 50);
            this.backdoor4.TabIndex = 11;
            this.backdoor4.TabStop = false;
            this.backdoor4.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // backdoor3
            // 
            this.backdoor3.BackColor = System.Drawing.Color.Transparent;
            this.backdoor3.Location = new System.Drawing.Point(400, 212);
            this.backdoor3.Name = "backdoor3";
            this.backdoor3.Size = new System.Drawing.Size(100, 50);
            this.backdoor3.TabIndex = 12;
            this.backdoor3.TabStop = false;
            this.backdoor3.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Margin = new System.Windows.Forms.Padding(0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(0, 0);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 13;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.Visible = false;
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            this.vlcControl1.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.vlcControl1_Stopped);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Genshin_Impact_Lottery.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1924, 1057);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.backdoor3);
            this.Controls.Add(this.backdoor4);
            this.Controls.Add(this.backdoor2);
            this.Controls.Add(this.backdoor5);
            this.Controls.Add(this.backdoor1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Controls.Add(this.go);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdoor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label go;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.PictureBox backdoor1;
        private System.Windows.Forms.PictureBox backdoor5;
        private System.Windows.Forms.PictureBox backdoor2;
        private System.Windows.Forms.PictureBox backdoor4;
        private System.Windows.Forms.PictureBox backdoor3;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
    }
}

