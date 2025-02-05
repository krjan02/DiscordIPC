﻿namespace Dec.DiscordIPC.Commands {
    public class SetUserVoiceSettings {
        public class Args {
            public string user_id { get; set; }
            public Pan pan { get; set; }
            public int? volume { get; set; }
            public bool? mute { get; set; }
        }

        public class Data {
            public string user_id { get; set; }
            public Pan pan { get; set; }
            public int? volume { get; set; }
            public bool? mute { get; set; }
        }

        public class Pan {
            public float? left { get; set; }
            public float? right { get; set; }
        }
    }
}
