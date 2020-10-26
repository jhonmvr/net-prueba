using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class TaskSummaryWrapper
    {
       

        [JsonPropertyName("task-summary")]
        public List<TaskItemWrapper> TaskSummary { get; set; }

		public override string ToString()
		{
			StringBuilder str = new StringBuilder("TaskSummaryWrapper:[");
			if (TaskSummary != null && TaskSummary.Count>0)
			{
				foreach(TaskItemWrapper item in TaskSummary)
				{
					str.Append("item:[");
					str.Append(item.TaskId);
					str.Append(",");
					str.Append(item.TaskName);
					str.Append(",");
					str.Append(item.TaskProcInstId);
					str.Append(",");
					str.Append(item.TaskStatus);
					str.Append(",");
					str.Append(item.TaskActualOwner);
					str.Append("]");
				}
			}
			str.Append("]");
			return str.ToString();

		}
	}
}
