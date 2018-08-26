using System;
using System.IO;
using ClickCounter;
using StreamCompanionTypes;
using StreamCompanionTypes.DataTypes;
using StreamCompanionTypes.Interfaces;

namespace mp3Exporter
{
    public abstract class Mp3ExporterBase : IPlugin, IMapDataGetter, IDisposable, ISettings
    {
        private readonly SettingNames _names = SettingNames.Instance;

        public bool Started { get; set; }
        public string Description { get; } = "";
        public string Name { get; } = nameof(Mp3Exporter);
        public string Author { get; } = "Piotrekol";
        public string Url { get; } = "";
        public string UpdateUrl { get; } = "";

        protected MapSearchResult CurrentSearchResult = null;
        private ILogger _logger;
        private KeyboardListener _keyboardListener;
        private ISettingsHandler _settings;
        protected string SongsDirectory;
        public virtual void Start(ILogger logger)
        {
            if (Started)
                return;
            _logger = logger;

            //find songs folder location
            var dir = _settings.Get<string>(_names.SongsFolderLocation);
            if (dir == _names.SongsFolderLocation.Default<string>())
            {
                dir = _settings.Get<string>(_names.MainOsuDirectory);
                dir = Path.Combine(dir, "Songs\\");
            }

            if (Directory.Exists(dir))
            {
                SongsDirectory = dir;

                _keyboardListener = new KeyboardListener();
                _keyboardListener.KeyUp += KeyUp;
                _logger?.Log(">Keyboard hooked!", LogLevel.Debug);
            }

            Started = true;
        }

        protected abstract void KeyUp(object sender, RawKeyEventArgs args);

        public virtual void SetNewMap(MapSearchResult map)
        {
            CurrentSearchResult = map;
        }

        public void Dispose()
        {
            _keyboardListener?.Dispose();
        }

        public void SetSettingsHandle(ISettingsHandler settings)
        {
            _settings = settings;
        }
    }
}