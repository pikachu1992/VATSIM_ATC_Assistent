using Eve;
using Newtonsoft.Json;
using System;

namespace VATSIM_ATC_Assistent.UI
{
    class ATCs
    {
        /// <summary>
        /// Gets or sets the unique Id.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("_id")]
        [Remote(Meta.DocumentId)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        /// <value>The ETag.</value>
        [JsonProperty("_etag")]
        [Remote(Meta.ETag)]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last update date and time.
        /// </summary>
        /// <value>The last updated date and time.</value>
        [JsonProperty("_updated")]
        [Remote(Meta.LastUpdated)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>
        [JsonProperty("_created")]
        [Remote(Meta.DateCreated)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the delete state.
        /// </summary>
        /// <value>The creation date.</value>
        [JsonProperty("_deleted")]
        [Remote(Meta.Deleted)]
        public bool Deleted { get; set; }

        [JsonProperty("cid")]
        public string CID { get; set; }

        [JsonProperty("frequency")]
        public string frequency { get; set; }

        [JsonProperty("callsign")]
        public string callsign { get; set; }
    }
}
