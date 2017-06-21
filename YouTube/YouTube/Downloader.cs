using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using YoutubeExtractor;
using System.IO;

namespace YouTube
{
    class Downloader
    {
        public string Url { get; }
        public string Format { get; }
        public int Quality { get; }
        public string SavePath { get; }

        public delegate void ProgressChangeHandler(object sender, double e);
        public event ProgressChangeHandler ProgressChanged;

        private bool UseTitleAsName;

        public Downloader(string Url, string Format, int Quality, string SavePath, bool UseTitleAsName)
        {
            this.Url = Url; this.Format = Format; this.Quality = Quality; this.SavePath = SavePath; this.UseTitleAsName = UseTitleAsName;
        }

        public void ExecuteDownload()
        {
            VideoInfo Video;
            VideoType Type;
            string Output = SavePath;
            switch (this.Format)
            {
                case "3GP":
                    Type = VideoType.Mobile;
                    break;
                case "Flv":
                    Type = VideoType.Flash;
                    break;
                case "Mp4":
                    Type = VideoType.Mp4;
                    break;
                case "WebM":
                    Type = VideoType.WebM;
                    break;

                case "Mp3":
                    DownloadAudio(Quality);
                    return;

                default:
                    throw new Exception("I don't understand that format");
            }

            var Videos = DownloadUrlResolver.GetDownloadUrls(this.Url, false);
            Video = Videos.First(info => info.VideoType == Type && info.Resolution == Quality);
            if (Video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(Video);
            if (UseTitleAsName)
                Output = Path.Combine(SavePath , RemoveIllegalPathCharacters(Video.Title) + Video.VideoExtension);

            var DL = new VideoDownloader(Video, Output);
            DL.DownloadProgressChanged += (sender, e) =>
            {
                if (ProgressChanged == null)
                    return;
                Console.WriteLine("Downloader Progress: " + e.ProgressPercentage);
                ProgressChanged(sender, e.ProgressPercentage);
            };
            DL.Execute();
        }

        private void DownloadAudio(int Quality)
        {

        }  //TODO: Implement Audio Extract

        private string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }
    }
}
