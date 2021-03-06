﻿namespace PLAYONE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnVolume = new System.Windows.Forms.Button();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblVideoPosition = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.trackVideo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolume
            // 
            this.btnVolume.Image = global::PLAYONE.Properties.Resources.orangebutton;
            this.btnVolume.Location = new System.Drawing.Point(620, 484);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(112, 35);
            this.btnVolume.TabIndex = 20;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(742, 484);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackVolume.Maximum = 0;
            this.trackVolume.Minimum = -10000;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(230, 69);
            this.trackVolume.TabIndex = 19;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVolume.Visible = false;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PLAYONE.Properties.Resources.bluebutton;
            this.btnNext.Location = new System.Drawing.Point(18, 514);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Open File";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblVideoPosition
            // 
            this.lblVideoPosition.AutoSize = true;
            this.lblVideoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoPosition.Image = global::PLAYONE.Properties.Resources.orangebutton;
            this.lblVideoPosition.Location = new System.Drawing.Point(276, 546);
            this.lblVideoPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideoPosition.Name = "lblVideoPosition";
            this.lblVideoPosition.Size = new System.Drawing.Size(184, 25);
            this.lblVideoPosition.TabIndex = 16;
            this.lblVideoPosition.Text = "00:00:00 / 00:00:00";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Image = global::PLAYONE.Properties.Resources.bluebutton;
            this.btnPlayPause.Location = new System.Drawing.Point(18, 578);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(112, 35);
            this.btnPlayPause.TabIndex = 15;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVideo.Location = new System.Drawing.Point(0, 554);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(1017, 100);
            this.lblVideo.TabIndex = 13;
            this.lblVideo.Text = "Please choose your WMV video";
            this.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Location = new System.Drawing.Point(48, 15);
            this.pnlVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(823, 445);
            this.pnlVideo.TabIndex = 11;
            // 
            // tmrVideo
            // 
            this.tmrVideo.Tick += new System.EventHandler(this.tmrVideo_Tick);
            // 
            // trackVideo
            // 
            this.trackVideo.Location = new System.Drawing.Point(154, 497);
            this.trackVideo.Maximum = 6666;
            this.trackVideo.Name = "trackVideo";
            this.trackVideo.Size = new System.Drawing.Size(434, 69);
            this.trackVideo.TabIndex = 21;
            this.trackVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackVideo_MouseDown);
            this.trackVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackVideo_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1066, 758);
            this.Controls.Add(this.lblVideoPosition);
            this.Controls.Add(this.trackVideo);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.lblVideo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PLAYONE";
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblVideoPosition;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.Timer tmrVideo;
        private System.Windows.Forms.TrackBar trackVideo;
    }
}

