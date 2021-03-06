﻿using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A Source is a descriptor for source code. 
    /// It is returned from the debug adapter as part of a StackFrame and it is used by clients when specifying breakpoints.
    /// </summary>
    public class Source
    {
        /// <summary>
        /// The short name of the source. 
        /// Every source returned from the debug adapter has a name. 
        /// When sending a source to the debug adapter this name is optional.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The path of the source to be shown in the UI. 
        /// It is only used to locate and load the content of the source if no sourceReference is specified (or its vaule is 0).
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// If sourceReference > 0 the contents of the source must be retrieved through the SourceRequest (even if a path is specified). 
        /// A sourceReference is only valid for a session, so it must not be used to persist a source.
        /// </summary>
        [JsonProperty("sourceReference")]
        public int SourceReference { get; set; }

        /// <summary>
        /// An optional hint for how to present the source in the UI. 
        /// A value of 'deemphasize' can be used to indicate that the source is not available or that it is skipped on stepping.
        /// </summary>
        [JsonProperty("presentationHint")]
        public string PresentationHint { get; set; }

        /// <summary>
        /// The (optional) origin of this source: possible values 'internal module', 'inlined content from source map', etc.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Optional data that a debug adapter might want to loop through the client. 
        /// The client should leave the data intact and persist it across sessions. 
        /// The client should not interpret the data.
        /// </summary>
        [JsonProperty("adapterData")]
        public object AdapterData { get; set; }

        /// <summary>
        /// The checksums associated with this file.
        /// </summary>
        [JsonProperty("checksums")]
        public Checksum[] Checksums { get; set; }
    }
}
