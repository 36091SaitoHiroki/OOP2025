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
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(628, 14);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(83, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(13, 53);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(696, 172);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(13, 231);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(696, 392);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            wvRssLink.SourceChanged += wvRssLink_SourceChanged;
            // 
            // tbGoBack
            // 
            tbGoBack.Location = new Point(14, 14);
            tbGoBack.Name = "tbGoBack";
            tbGoBack.Size = new Size(46, 33);
            tbGoBack.TabIndex = 4;
            tbGoBack.Text = "戻る";
            tbGoBack.UseVisualStyleBackColor = true;
            tbGoBack.Click += tbGoBack_Click;
            // 
            // tbGoForward
            // 
            tbGoForward.Location = new Point(66, 15);
            tbGoForward.Name = "tbGoForward";
            tbGoForward.Size = new Size(52, 32);
            tbGoForward.TabIndex = 5;
            tbGoForward.Text = "進む";
            tbGoForward.UseVisualStyleBackColor = true;
            tbGoForward.Click += tbGoForward_Click;
            // 
            // cbUrl
            // 
            cbUrl.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(124, 15);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(493, 29);
            cbUrl.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 646);
            Controls.Add(cbUrl);
            Controls.Add(tbGoForward);
            Controls.Add(tbGoBack);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
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
    }
}
