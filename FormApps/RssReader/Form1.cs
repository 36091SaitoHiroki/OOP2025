using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        Dictionary<string, string> rssUrlDict = new Dictionary<string, string>() {
            {"��v","https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
            {"����","https://news.yahoo.co.jp/rss/categories/domestic.xml"},
            {"�o��","https://news.yahoo.co.jp/rss/categories/business.xml"},
            {"�G���^��","https://news.yahoo.co.jp/rss/categories/entertainment.xml"},
            {"�X�|�[�c","https://news.yahoo.co.jp/rss/categories/sports.xml"},
            {"IT","https://news.yahoo.co.jp/rss/categories/it.xml"},
            {"�Ȋw","https://news.yahoo.co.jp/rss/categories/science.xml"},
            {"���C�t","https://news.yahoo.co.jp/rss/categories/life.xml"},
            {"�n��","https://news.yahoo.co.jp/rss/categories/local.xml"},

        };

        public Form1() {
            InitializeComponent();
            GoForwardBtEnableSet();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbUrl.DataSource = rssUrlDict.Select(x => x.Key).ToList();
            cbUrl.SelectedIndex = -1;
        }

        private async void btRssGet_Click(object sender, EventArgs e) {

            using (var hc = new HttpClient()) {

                string xml = await hc.GetStringAsync(getRssUrl(cbUrl.Text));
                XDocument xdoc = XDocument.Parse(xml);
                //XDocument xdoc = XDocument.Parse(await hc.GetStringAsync(tbUrl.Text));

                //RSS����͂��ĕK�v�ȗv�f���擾
                items = xdoc.Root.Descendants("item")
                    .Select(x => new ItemData {
                        Title = (string?)x.Element("title"),
                        Link = (string?)x.Element("link"),
                    })
                    .ToList();

                //���X�g�{�b�N�X�փ^�C�g����\��
                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "�f�[�^�Ȃ�"));
            }
        }

        private string getRssUrl(string str) {
            if (rssUrlDict.ContainsKey(str)) {
                return rssUrlDict[str];
            }
            return str;
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            wvRssLink.Source = new Uri(items[lbTitles.SelectedIndex].Link);
        }

        private void tbGoBack_Click(object sender, EventArgs e) {
            wvRssLink.GoBack();
        }

        private void tbGoForward_Click(object sender, EventArgs e) {
            wvRssLink.GoForward();
        }

        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            GoForwardBtEnableSet();
        }

        private void GoForwardBtEnableSet() {
            tbGoBack.Enabled = wvRssLink.CanGoBack;
            tbGoForward.Enabled = wvRssLink.CanGoForward;
        }

        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //�`��Ώۂ̍s
            if (idx == -1) return;                                                  //�͈͊O�Ȃ牽�����Ȃ�
            var sts = e.State;                                                      //�Z���̏��
            var fnt = e.Font;                                                       //�t�H���g
            var _bnd = e.Bounds;                                                    //�`��͈�(�I���W�i��)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //�`��͈�(�`��p)
            var txt = (string)lbTitles.Items[idx];                                  //���X�g�{�b�N�X���̕���
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //�����F
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //�I���s��
            var odd = (idx % 2 == 1);                                               //��s��
            var fore = Brushes.WhiteSmoke;                                         //�����s�̔w�i�F
            var bak = Brushes.AliceBlue;                                           //��s�̔w�i�F

            e.DrawBackground();                                                     //�w�i�`��

            //����ڂ̔w�i�F��ς���i�I���s�͏����j
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //������`��
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }

        private void wvRssLink_Click(object sender, EventArgs e) {

        }
    }
}
