using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace PLAYONE
{
    public partial class Form1 : Form
    {
        private Video video;
        private int pnlHeight;
        private Size videosize;
        private bool timeshift = false;

        public Form1()
        {
            InitializeComponent();
        }
      

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Media Files|*.wmv";
            openFileDialog1.Title = "Select a WMV File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlHeight = pnlVideo.Height;
                video = new Video(openFileDialog1.FileName, false)
                {
                    Owner = pnlVideo
                };
                videosize = new Size(pnlVideo.Width * pnlHeight / pnlVideo.Height, pnlHeight);
                pnlVideo.Size = videosize;
                lblVideo.Text = openFileDialog1.FileName;
                video.Play();
                tmrVideo.Enabled = true;
            }
        }
        

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try {
                if (!video.Playing)
                {
                    video.Play();
                    tmrVideo.Enabled = true;
                    btnPlayPause.Text = "PAUSE";
                }
                else if (video.Playing)
                {
                    video.Pause();
                    tmrVideo.Enabled = false;
                    btnPlayPause.Text = "PLAY";
                }
            }
            catch { }
        }
        

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            video.Audio.Volume = trackVolume.Value;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            trackVolume.Visible = !trackVolume.Visible;
        }

        private void tmrVideo_Tick(object sender, EventArgs e)
        {
            int currentTime = Convert.ToInt32(video.CurrentPosition);
            int maxTime = Convert.ToInt32(video.Duration);

            double pos = video.CurrentPosition * 6666.0 / video.Duration;
            if(timeshift == false)
                trackVideo.Value = Convert.ToInt32(pos);

            lblVideoPosition.Text = string.Format("{0:00}:{1:00}:{2:00}", currentTime / 3600, (currentTime / 60) % 60, currentTime % 60)
                                    + " / " +
                                    string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }
        

        private void trackVideo_MouseDown(object sender, MouseEventArgs e)
        {
            timeshift = true;
        }

        private void trackVideo_MouseUp(object sender, MouseEventArgs e)
        {
            timeshift = false;
            video.CurrentPosition = trackVideo.Value * video.Duration / 6666.0;
        }
    }
}
