using System.IO;
using System.Windows.Input;
using ClickCounter;

namespace mp3Exporter
{
    public class Mp3Exporter : Mp3ExporterBase
    {
        private string baseMp3Location = @"D:\Random\mp3Testing";

        protected override void KeyUp(object sender, RawKeyEventArgs args)
        {
            //TODO: hardcoding inbound
            if (string.IsNullOrEmpty(SongsDirectory) ||
                args.Key != Key.Insert ||
                CurrentSearchResult == null ||
                !CurrentSearchResult.FoundBeatmaps
                )
                return;

            var map = CurrentSearchResult.BeatmapsFound[0];
            var newMp3Name = $"{map.ArtistRoman} - {map.TitleRoman}.mp3";

            var orginalMp3Location = Path.Combine(SongsDirectory, map.Dir, map.Mp3Name);
            var newMp3Location = Path.Combine(baseMp3Location, newMp3Name);

            if (File.Exists(newMp3Location))
                return;

            //TODO: mp3 tag editing

            File.Copy(orginalMp3Location, newMp3Location);
        }
    }
}
