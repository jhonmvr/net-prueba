using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class ProcessSummaryWrapper
    {



        [JsonPropertyName("process-instance-id")]
        public int ProcessInstId { set; get; }
        [JsonPropertyName("process - id")]
        public string ProcessId { set; get; }
        [JsonPropertyName("process-name")]
        public string ProcessName { set; get; }
        [JsonPropertyName("process-version")]
        public string ProcessVersion { set; get; }
        [JsonPropertyName("process-instance-state")]
        public int ProcessInstState { set; get; }
        [JsonPropertyName("container-id")]
        public string ContainerId { set; get; }
        [JsonPropertyName("initiator")]
        public string Initiator { set; get; }
        [JsonPropertyName("process-instance-desc")]
        public string ProcessInstDesc { set; get; }
        [JsonPropertyName("correlation-key")]
        public string CorrelationKey { set; get; }
    }

}
