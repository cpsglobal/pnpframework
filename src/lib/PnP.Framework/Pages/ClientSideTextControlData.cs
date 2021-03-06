﻿using Newtonsoft.Json;

namespace PnP.Framework.Pages
{

    /// <summary>
    /// Control data for controls of type 4 (= text control)
    /// </summary>
    public class ClientSideTextControlData : ClientSideCanvasControlData
    {
        /// <summary>
        /// Gets or sets JsonProperty "editorType"
        /// </summary>
        [JsonProperty(PropertyName = "editorType")]
        public string EditorType { get; set; }
    }
}
