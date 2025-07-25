namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            tbGoBack = new Button();
            tbGoForward = new Button();
            cbUrl = new ComboBox();
            bt = new Button();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Anchor = AnchorStyles.Top;
            btRssGet.BackColor = Color.Blue;
            btRssGet.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btRssGet.ForeColor = Color.White;
            btRssGet.Location = new Point(786, 15);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(83, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = false;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top;
            lbTitles.BackColor = Color.White;
            lbTitles.DrawMode = DrawMode.OwnerDrawFixed;
            lbTitles.Font = new Font("游ゴシック", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.ForeColor = Color.Black;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(14, 54);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(855, 172);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            lbTitles.DrawItem += lbTitles_DrawItem;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvRssLink.BackColor = SystemColors.ControlLightLight;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(14, 242);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(855, 392);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            wvRssLink.SourceChanged += wvRssLink_SourceChanged;
            wvRssLink.Click += wvRssLink_Click;
            // 
            // tbGoBack
            // 
            tbGoBack.BackColor = Color.White;
            tbGoBack.Location = new Point(13, 14);
            tbGoBack.Name = "tbGoBack";
            tbGoBack.Size = new Size(47, 33);
            tbGoBack.TabIndex = 4;
            tbGoBack.Text = "戻る";
            tbGoBack.UseVisualStyleBackColor = false;
            tbGoBack.Click += tbGoBack_Click;
            // 
            // tbGoForward
            // 
            tbGoForward.BackColor = Color.White;
            tbGoForward.Location = new Point(66, 15);
            tbGoForward.Name = "tbGoForward";
            tbGoForward.Size = new Size(52, 32);
            tbGoForward.TabIndex = 5;
            tbGoForward.Text = "進む";
            tbGoForward.UseVisualStyleBackColor = false;
            tbGoForward.Click += tbGoForward_Click;
            // 
            // cbUrl
            // 
            cbUrl.Anchor = AnchorStyles.Top;
            cbUrl.BackColor = SystemColors.ControlLightLight;
            cbUrl.Font = new Font("游ゴシック", 12.75F);
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(135, 15);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(545, 30);
            cbUrl.TabIndex = 6;
            // 
            // bt
            // 
            bt.Anchor = AnchorStyles.Top;
            bt.BackColor = Color.Blue;
            bt.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            bt.ForeColor = Color.White;
            bt.Location = new Point(698, 15);
            bt.Name = "bt";
            bt.Size = new Size(82, 33);
            bt.TabIndex = 7;
            bt.Text = "登録";
            bt.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(883, 646);
            Controls.Add(bt);
            Controls.Add(cbUrl);
            Controls.Add(tbGoForward);
            Controls.Add(tbGoBack);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            ForeColor = SystemColors.InactiveCaptionText;
            Name = "Form1";
            Text = "RSSリーダー";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button tbGoBack;
        private Button tbGoForward;
        private ComboBox cbUrl;
        private Button bt;
    }
}
