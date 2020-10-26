using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json.Serialization;

namespace gestion_pistas_core.Models.wrapper
{
    public class TaskItemWrapper
    {

        [JsonPropertyName("task-id")]
        public int TaskId { get; set; }

        [JsonPropertyName("task-name")]
        public string TaskName{ get; set; }

        [JsonPropertyName("task-subject")]
        public string TaskSubject{ get; set; }

        [JsonPropertyName("task-description")]
        public string TaskDescription{ get; set; }

        [JsonPropertyName("task-status")]
        public string TaskStatus{ get; set; }

        [JsonPropertyName("task-priority")]
        public int TaskPriority{ get; set; }

        [JsonPropertyName("task-is-skipable")]
        public bool TaskIsSkipable{ get; set; }

        [JsonPropertyName("task-actual-owner")]
        public string TaskActualOwner{ get; set; }

        [JsonPropertyName("task-created-by")]
        public string TaskCreatedBy{ get; set; }

        /*[JsonPropertyName("task-created-on")]
        public DateTime TaskCreatedOn{ get; set; }

        [JsonPropertyName("task-activation-time")]
        public DateTime TaskActivationTime { get; set; }

        [JsonPropertyName("task-expiration-time")]
        public object TaskExpirationTime{ get; set; }*/

        [JsonPropertyName("task-proc-inst-id")]
        public int TaskProcInstId{ get; set; }

        [JsonPropertyName("task-proc-def-id")]
        public string TaskProcDefId{ get; set; }

        [JsonPropertyName("task-container-id")]
        public string TaskContainerId{ get; set; }

        [JsonPropertyName("task-parent-id")]
        public int TaskParentId{ get; set; }
    }
}
