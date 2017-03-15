using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsFeeder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFetchUrl_Click(object sender, EventArgs e)
        {
            var opFileDialog = new OpenFileDialog();
            opFileDialog.Multiselect = false;

            if (opFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Feeds> iListFeeds = Feeds.LoadFeedsFromFile(opFileDialog.FileName);
                dgvFeedsList.DataSource = iListFeeds;
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            
            //InternetFeedsList ifList = InternetFeedsList.LoadFromUrl(@"http://feeds.news24.com/articles/news24/TopStories/rss");
            //dgvFeedsList.DataSource = ifList;
        }
    }
}
