﻿using Newtonsoft.Json;

namespace JeremyTCD.DocFx.Plugins.MimoMarkdown
{
    public class Range : ClippingArea
    {
        [JsonProperty(Required = Required.Always)]
        public int Start { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int End { get; set; }
    }
}