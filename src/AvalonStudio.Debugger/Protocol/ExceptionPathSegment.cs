﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// An ExceptionPathSegment represents a segment in a path that is used to match leafs or nodes in a tree of exceptions. 
    /// If a segment consists of more than one name, it matches the names provided if 'negate' is false or missing or it matches anything except the names provided if 'negate' is true.
    /// </summary>
    public class ExceptionPathSegment
    {
        /// <summary>
        /// If false or missing this segment matches the names provided, otherwise it matches anything except the names provided.
        /// </summary>
        [JsonProperty("negate")]
        public bool Negate { get; set; }

        /// <summary>
        /// Depending on the value of 'negate' the names that should match or not match.
        /// </summary>
        [JsonProperty("names")]
        public IList<string> Names { get; set; }
    }
}
