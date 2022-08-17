using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace YouTubeAPIStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void WriteLog(string msg)
        {
            txtLog.Text = msg + "\n" + txtLog.Text + "\n";
        }

        void UploadVideo(string videoPath)
        {
            pnlContainer.Enabled = false;
            WriteLog("YouTube Data API: Upload Video");
            WriteLog("==============================");

            try
            {
                Run("Title", "Description", new string[] {"2024801030101", "D20KTPM01"}, videoPath).Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            pnlContainer.Enabled = true;
        }

        private async Task Run(string title, string desc, string[] tags, string videoPath)
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = title;
            video.Snippet.Description = desc;
            video.Snippet.Tags = tags;
            video.Snippet.CategoryId = "1"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "public"; // or "private" or "public"
            var filePath = videoPath; // Replace with path to actual movie file.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    WriteLog(string.Format("{0} bytes sent.", progress.BytesSent));
                    break;

                case UploadStatus.Failed:
                    WriteLog(string.Format("An error prevented the upload from completing.\n{0}", progress.Exception));
                    break;
            }
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            WriteLog(string.Format("Video id '{0}' was successfully uploaded.", video.Snippet.Title));
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => {
                UploadVideo(txtVideoPath.Text);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnVideoPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtVideoPath.Text = dialog.FileName;
            }
        }
    }
}
