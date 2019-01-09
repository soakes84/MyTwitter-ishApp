using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetManager;

namespace Twitter_ish_Form
{
    public partial class Twitter_ish : Form
    {
        TweetsManagerMemory tmm = new TweetsManagerMemory();

        public Twitter_ish()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string msg = tmm.PostTweets(txtTweet.Text);
            lblStatus.Text = msg;
            refreshTweets();    
        }

        void refreshTweets()
        {
            listTweets.Items.Clear();
            string[] tweets = tmm.GetTweets();
            int tweetsCount = tmm.TweetCount();

            for (int i = 0; i < tweetsCount; i++)
                listTweets.Items.Add(tweets[i]);
        }
    }
}
