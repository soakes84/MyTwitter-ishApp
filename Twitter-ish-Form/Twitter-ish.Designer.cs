namespace Twitter_ish_Form
{
    partial class Twitter_ish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tweets = new System.Windows.Forms.GroupBox();
            this.listTweets = new System.Windows.Forms.ListBox();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Tweets.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tweets
            // 
            this.Tweets.Controls.Add(this.listTweets);
            this.Tweets.Location = new System.Drawing.Point(12, 12);
            this.Tweets.Name = "Tweets";
            this.Tweets.Size = new System.Drawing.Size(353, 221);
            this.Tweets.TabIndex = 0;
            this.Tweets.TabStop = false;
            this.Tweets.Text = "Tweets";
            // 
            // listTweets
            // 
            this.listTweets.FormattingEnabled = true;
            this.listTweets.Location = new System.Drawing.Point(23, 28);
            this.listTweets.Name = "listTweets";
            this.listTweets.Size = new System.Drawing.Size(308, 173);
            this.listTweets.TabIndex = 0;
            this.listTweets.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(13, 274);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(352, 20);
            this.txtTweet.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(267, 311);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 342);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "...";
            // 
            // Twitter_ish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 367);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.Tweets);
            this.Name = "Twitter_ish";
            this.Text = "Twitter-ish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tweets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Tweets;
        private System.Windows.Forms.ListBox listTweets;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblStatus;
    }
}

