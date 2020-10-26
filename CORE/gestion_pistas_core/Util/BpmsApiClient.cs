using gestion_pistas_core.Models.util;
using gestion_pistas_core.Models.wrapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_pistas_core.Util
{
    public enum EstadoBpmsEnum
    {
        Ready,
        Reserved,
        InProgress,
        //TASK STATES
        started,
        completed,
        released,
        claimed
    }

    public class BpmsApiClient<T>
    {
        private static String urlInstanceProcess = "kie-server/services/rest/server/containers/--containerid--/processes/--bpmprocessid--/instances";
        private static String urlAbortProcess = "kie-server/services/rest/server/containers/--containerid--/processes/instances/--processid--";

        private static String urlTaskState = "kie-server/services/rest/server/containers/--containerid--/tasks/--taskid--/states/--state--";
        private static String urlProcessInstaceTask = "kie-server/services/rest/server/queries/processes/instances/--idprocessinstace--";
        private static String urlTasksInProcessInstances = "kie-server/services/rest/server/queries/tasks/instances/process/--idprocessinstace--";
        private static String urlPotencialOwnerTask = "kie-server/services/rest/server/queries/tasks/instances/pot-owners";
        private static String urlTaskVariables = "kie-server/services/rest/server/containers/--containerid--/tasks/--taskid--?withInputData=true&withOutputData=true";
        private static String urlTaskLiberar = "kie-server/services/rest/server/containers/--containerid--/tasks/--taskid--/states/released?user=--usuario--";
        private static String urlToken = "token/";

        private static String BPMS_DEFAULT_USER = "asesor";
        public static Int32 BPMS_DEFAULT_PORT = 8280;


        private static String empty = "{}";

        /// <summary>
        /// Metodo que inicia el proceso en el BPMS
        /// </summary>
        /// <param name="bpmsUrlService"></param>
        /// <param name="authorization"></param>
        /// <param name="idProyecto"></param>
        /// <param name="versionProyecto"></param>
        /// <param name="bpmProcessId"></param>
        /// <param name="versionProcesoBpm"></param>
        /// <param name="datosIniciales"></param>
        /// <returns>Numero de proceso</returns>
        public static Int32 CallBpmsInitProcesss(String bpmsUrlService, String authorization, String idProyecto,
            String versionProyecto, String bpmProcessId, String versionProcesoBpm, Dictionary<string, string> datosIniciales)
        {

            Console.WriteLine("===> callBpmsInitProcesss con idProyecto " + idProyecto);
            Console.WriteLine("===> callBpmsInitProcesss con versionProyecto " + versionProyecto);
            Console.WriteLine("===> callBpmsInitProcesss con bpmProcessId " + bpmProcessId);
            String containerId = idProyecto + "_" + versionProyecto;
            String service = bpmsUrlService + urlInstanceProcess.Replace("--containerid--", containerId)
            .Replace("--bpmprocessid--", bpmProcessId);
            Console.WriteLine("===> callBpmsInitProcesss con servcio " + service);
            var response = ReRestClient<Dictionary<string, string>, Int32>.CallPost(service, datosIniciales, "application/json", "Basic", authorization, "application/json");
            return response.Result;
        }

        public static String CallBpmsStateTask(String bpmsUrlService, String authorization, String containerId,
            String taskId,String state, String actor, T envioWrapper, Dictionary<string, string> datosIniciales)
        {
            Console.WriteLine("===> callBpmsStateTask con containerId " + containerId);
            //Console.WriteLine("===> callBpmsStateTask con versionProyecto " + versionProyecto);
            Console.WriteLine("===> callBpmsStateTask con taskId " + taskId);
            Console.WriteLine("===> callBpmsStateTask con state " + state);
            Console.WriteLine("===> callBpmsStateTask con actor " + actor);
            Console.WriteLine("===> callBpmsStateTask con envio " + envioWrapper);
            Console.WriteLine("===> callBpmsStateTask con piw " + datosIniciales);
            //String containerId = idProyecto + "_" + versionProyecto;
            String service = bpmsUrlService + urlTaskState.Replace("--containerid--", containerId)
            .Replace("--taskid--", taskId).Replace("--state--", state) + "?user=" + actor;

            if (envioWrapper != null)
            {
                return ReRestClient<T, string>.CallPut(service, envioWrapper, "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
            }
            else
            {

                if (datosIniciales != null)
                {
                    return ReRestClient<Dictionary<string, string>, string>.CallPut(service, datosIniciales, "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
                }
                else
                {
                    return ReRestClient<Dictionary<string, string>, string>.CallPut(service, new Dictionary<string, string>(), "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bpmsUrlService"></param>
        /// <param name="authorization"></param>
        /// <param name="group"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static TaskSummaryWrapper CallBpmsFindPotencialOwnerTask(String bpmsUrlService, String authorization, String group, String user)
        {
            Console.WriteLine("===> callBpmsFindPotencialOwnerTask con idProyecto " + group);
            Console.WriteLine("===> callBpmsFindPotencialOwnerTask con versionProyecto " + user);
            List<KeyValuePair<string, string>> parametrosQuery = new List<KeyValuePair<string, string>>();
            parametrosQuery.Add(new KeyValuePair<string, string>("status", "Ready"));
            parametrosQuery.Add(new KeyValuePair<string, string>("groups", group));
            parametrosQuery.Add(new KeyValuePair<string, string>("page", "0"));
            parametrosQuery.Add(new KeyValuePair<string, string>("pageSize", "1000"));
            parametrosQuery.Add(new KeyValuePair<string, string>("sortOrder", Boolean.TrueString));
            parametrosQuery.Add(new KeyValuePair<string, string>("user", user));

            String service = bpmsUrlService + urlPotencialOwnerTask;
            Console.WriteLine("===> callBpmsFindPotencialOwnerTask con servcio " + service);
            return ReRestClient<string, TaskSummaryWrapper>.CallGet(service, BPMS_DEFAULT_PORT, parametrosQuery, "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bpmsUrlService"></param>
        /// <param name="authorization"></param>
        /// <param name="group"></param>
        /// <param name="user"></param>
        /// <param name="processInstanceId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static TaskItemWrapper CallBpmsFindPotencialOwnerTaskByProcessInstanceAndStatus(
            String bpmsUrlService, String authorization, String group, String user,
            Int32 processInstanceId, EstadoBpmsEnum status)
        {
            Console.WriteLine("===> callBpmsFindPotencialOwnerTaskByProcessInstanceAndStatus con idProyecto " + group);
            Console.WriteLine("===> callBpmsFindPotencialOwnerTaskByProcessInstanceAndStatus con versionProyecto " + user);


            List<KeyValuePair<string, string>> parametrosQuery = new List<KeyValuePair<string, string>>();
            parametrosQuery.Add(new KeyValuePair<string, string>("status", status.ToString()));
            parametrosQuery.Add(new KeyValuePair<string, string>("groups", group));
            parametrosQuery.Add(new KeyValuePair<string, string>("page", "0"));
            parametrosQuery.Add(new KeyValuePair<string, string>("pageSize", "1000"));
            parametrosQuery.Add(new KeyValuePair<string, string>("sortOrder", Boolean.TrueString));
            parametrosQuery.Add(new KeyValuePair<string, string>("user", user));


            String service = bpmsUrlService + urlPotencialOwnerTask;
            Console.WriteLine("===> callBpmsFindPotencialOwnerTaskByProcessInstanceAndStatus con servcio " + service);
            TaskSummaryWrapper sw = ReRestClient<string, TaskSummaryWrapper>.CallGet(service, BPMS_DEFAULT_PORT, parametrosQuery, "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
            if (sw != null && sw.TaskSummary != null && sw.TaskSummary.Count > 0)
            {
                List<TaskItemWrapper> tmp = sw.TaskSummary.FindAll(t => t.TaskProcInstId == processInstanceId);
                if (tmp != null && tmp.Count > 0)
                {
                    Console.WriteLine("===> filtro por procesos y estado ");
                    return tmp[0];
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public static TaskSummaryWrapper CallBpmsFindTasksByProcessInstance(String bpmsUrlService, String authorization, Int32 idProcessInstance, string contentType)
        {
            try
            {
                Console.WriteLine("===>x callBpmsFindTasksByProcessInstance con idProyecto " + idProcessInstance);

                List<KeyValuePair<string, string>> parametrosQuery = new List<KeyValuePair<string, string>>();
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.Ready.ToString()));
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.Reserved.ToString()));
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.InProgress.ToString()));

                String service = bpmsUrlService + urlTasksInProcessInstances
                        .Replace("--idprocessinstace--", Convert.ToString(idProcessInstance));
                TaskSummaryWrapper sw = ReRestClient<string, TaskSummaryWrapper>.CallGet(service, BPMS_DEFAULT_PORT, parametrosQuery, contentType, "Basic", authorization, contentType).Result;

                return sw;
            }
            catch (Exception e)
            {

                Console.WriteLine("error al intentar buscar la tarrea bpm:" + e.Message);
                throw new RelativeException("error al intentar buscar la tarrea bpm", e.Message);
            }


        }

        public static ProcessSummaryWrapper CallBpmsFindByProcessInstance(String bpmsUrlService, String authorization, Int32 idProcessInstance, string contentType)
        {
            try
            {
                Console.WriteLine("===>x callBpmsFindTasksByProcessInstance con idProyecto " + idProcessInstance);

                List<KeyValuePair<string, string>> parametrosQuery = new List<KeyValuePair<string, string>>();
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.Ready.ToString()));
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.Reserved.ToString()));
                parametrosQuery.Add(new KeyValuePair<string, string>("status", EstadoBpmsEnum.InProgress.ToString()));

                String service = bpmsUrlService + urlProcessInstaceTask
                        .Replace("--idprocessinstace--", Convert.ToString(idProcessInstance));
                ProcessSummaryWrapper sw = ReRestClient<string, ProcessSummaryWrapper>.CallGet(service, BPMS_DEFAULT_PORT, parametrosQuery, contentType, "Basic", authorization, contentType).Result;

                return sw;
            }
            catch (Exception e)
            {

                Console.WriteLine("error al intentar buscar la tarrea bpm:" + e.Message);
                throw new RelativeException("error al intentar buscar la tarrea bpm", e.Message);
            }


        }

        public static TaskItemWrapper CallBpmsTaskById(String bpmsUrlService, String authorization, String idProyecto, String versionProyecto, String taskId)
        {
            Console.WriteLine("===> callBpmTaskById con idProyecto " + taskId);
            String containerId = idProyecto + "_" + versionProyecto;
            List<KeyValuePair<string, string>> parametrosQuery = new List<KeyValuePair<string, string>>();
            parametrosQuery.Add(new KeyValuePair<string, string>("withInputData", Boolean.TrueString));
            parametrosQuery.Add(new KeyValuePair<string, string>("withOutputData", Boolean.TrueString));
            String service = bpmsUrlService + urlTaskVariables.Replace("--containerid--", containerId).Replace("--taskid--", taskId);
            TaskItemWrapper sw = ReRestClient<string, TaskItemWrapper>.CallGet(service, BPMS_DEFAULT_PORT, parametrosQuery, "application/json", "Basic", "a2llc2VydmVyOmtpZXNlcnZlcjEh", "application/json").Result;
            return sw;
        }

        public static void callFullBpmsTaskHandle(String bpmsUrlService,  String actor, String idProcessGen, String authorizationBpm, T envio, Dictionary<string, string> piw)
        {
            try
            {
                ProcessSummaryWrapper psw= CallBpmsFindByProcessInstance(bpmsUrlService, authorizationBpm, Convert.ToInt32(idProcessGen), "application/json");
                TaskSummaryWrapper tsw = CallBpmsFindTasksByProcessInstance(bpmsUrlService, authorizationBpm, Convert.ToInt32(idProcessGen), "application/json");
                if (psw != null && tsw != null && tsw.TaskSummary != null && tsw.TaskSummary.Count > 0)
                {
                    Console.WriteLine("===> obtuvo tareas primera tarea " + tsw.TaskSummary[0].TaskId);
                    var status = 0;
                    if (tsw.TaskSummary[0].TaskStatus != "Reserved")
                    {
                        status = Convert.ToInt32(BpmsApiClient<Dictionary<string, string>>.CallBpmsStateTask(bpmsUrlService, authorizationBpm,
                        psw.ContainerId, tsw.TaskSummary[0].TaskId.ToString(), EstadoBpmsEnum.claimed.ToString(),
                        actor != null && actor.Length > 0 ? actor : BPMS_DEFAULT_USER, new Dictionary<string, string>(), null));
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!===>  tomo tarea con status: " + status);
                    }
                    
                    //aki esta un if
                    status = Convert.ToInt32(BpmsApiClient<Dictionary<string, string>>.CallBpmsStateTask(bpmsUrlService, authorizationBpm,
                       psw.ContainerId, tsw.TaskSummary[0].TaskId.ToString(), EstadoBpmsEnum.started.ToString(),
                        actor != null && actor.Length > 0 ? actor : BPMS_DEFAULT_USER, new Dictionary<string, string>(), piw));
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!===>  inicio tarea  con status: " + status);
                    //aki estaba otr if    
                    TaskSummaryWrapper tsws = CallBpmsFindTasksByProcessInstance(bpmsUrlService, authorizationBpm, Convert.ToInt32(idProcessGen), "application/json");
                    status = Convert.ToInt32(CallBpmsStateTask(bpmsUrlService, authorizationBpm,psw.ContainerId,tsws.TaskSummary[0].TaskId.ToString(), EstadoBpmsEnum.completed.ToString(),
                        actor != null && actor.Length > 0 ? actor : BPMS_DEFAULT_USER,envio, null));
                    Console.WriteLine("===>  completo tarea con estatus: " + status);
                    //aki estaba otro if

                    Console.WriteLine("===>  FINALIZACION TOMA, INICIO, Y CIERRE  DE PROCESO " + idProcessGen + " TAREA " + tsw.TaskSummary[0].TaskId);



                }
                else
                {
                    throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "NO SE ENCONTRO NINGUNA TAREA PARA EL PROCESO: " + idProcessGen);
                }
            }
            catch (RelativeException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR AL COMPLETAR LA TARREA," + e.Message);
                throw new RelativeException("ERROR AL COMPLETAR LA TARREA,", e);
            }
        }


    }
}
