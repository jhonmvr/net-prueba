using gestion_pistas_core.Models.wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using gestion_pistas_core.Models.util;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Net;
using Newtonsoft.Json;

namespace gestion_pistas_core.Util
{
    public class ReRestClient<T,R>
    {
        private static  HttpClient client = new HttpClient();
        private static CookieContainer cookieContainer = new CookieContainer();

        public async static Task<R> CallPost(String service, T body, String contentType,String authPrefix, String authorizationKey,string accept ) {
            try
            {
                Console.WriteLine("==< ingreso callpost: ");
                Console.WriteLine("==< ingreso callpost body : " + body);
                Console.WriteLine("====url ===>>" + service);
                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer }) ;
                    client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));
                //client.DefaultRequestHeaders.Add("Content-Type", contentType);
                if (authorizationKey != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authPrefix, authorizationKey);
                }
                if (!String.IsNullOrEmpty(accept))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                }
                cookieContainer.Add(new Uri(service), new Cookie("CookieName", "cookie_value"));
                HttpResponseMessage response = await client.PostAsync(service, new StringContent(
                            JsonSerializer.Serialize<T>(body), Encoding.UTF8, "application/json"));
                var responseStr = await response.Content.ReadAsStringAsync();
                var status = Convert.ToInt32(response.StatusCode);

                if (status >= 200 && status < 300)
                {
                    Console.WriteLine("rESPUESTA  CallPost responseStr " + responseStr);
                    if (!String.IsNullOrEmpty(responseStr))
                    {
                        var r = JsonSerializer.Deserialize<R>(responseStr);
                        Console.WriteLine("rESPUESTA  CallPost " + r);
                        return r;
                    }
                    else
                    {
                        return default(R);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR====>>>>:" + response);
                    throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "ERROR EN LA LLAMADA METODO POST "+ status);
                }
                
                
                
            }catch(RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR EN LA LLAMADA METODO POST", e.Message);
                throw new RelativeException("ERROR EN LA LLAMADA METODO POST", e);
            }

        }

        public async static Task<R> CallPut(String service, T body, String contentType, String authPrefix, String authorizationKey, string accept)
        {
            try
            {
                client = new HttpClient();
                Console.WriteLine("==< ingreso callpost: ");
                Console.WriteLine("==< ingreso callpost body : " + body);
                Console.WriteLine("====url ===>>" + service);
                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer }) ;
                    client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));
                //client.DefaultRequestHeaders.Add("Content-Type", contentType);
                if (authorizationKey != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authPrefix, authorizationKey);
                }
                if (!String.IsNullOrEmpty(accept))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                }
                cookieContainer.Add(new Uri(service), new Cookie("CookieName", "cookie_value"));
                var request = new HttpRequestMessage(HttpMethod.Put, service);
              
                var jsonUtf8Bytes = JsonConvert.SerializeObject(body);

                Console.WriteLine("json serializer ===>" + jsonUtf8Bytes);
                request.Content = new StringContent(jsonUtf8Bytes.ToString(), Encoding.UTF8, "application/json");
                 Console.WriteLine("request.Content ===>" + request.Content);
                Console.WriteLine("contenido request===>>>" + request);
                HttpResponseMessage response = await client.SendAsync(request);
                var responseStr = await response.Content.ReadAsStringAsync();
                var status = Convert.ToInt32(response.StatusCode);

                if (status >= 200 && status < 300)
                {
                    Console.WriteLine("rESPUESTA  CallPost responseStr " + responseStr);
                    if (!String.IsNullOrEmpty(responseStr))
                    {
                        var r = JsonSerializer.Deserialize<R>(responseStr);
                        Console.WriteLine("rESPUESTA  CallPost " + r);
                        return r;
                    }
                    else
                    {
                        return default(R);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR====>>>>:" + response);
                    throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "ERROR EN LA LLAMADA METODO POST " + status);
                }



            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR EN LA LLAMADA METODO POST", e.Message);
                throw new RelativeException("ERROR EN LA LLAMADA METODO POST", e);
            }

        }

        public async static Task<R> CallGet(String service,Int32 port, List<KeyValuePair<string, string>> paramQuery, String contentType, String authPrefix, String authorizationKey, string accept)
        {
            try
            {
                Console.WriteLine("==< ingreso CallGet: ");
                Console.WriteLine("==< ingreso CallGet body : " + paramQuery);
                Console.WriteLine("====url ===>>" + service);
                client.DefaultRequestHeaders.Accept.Clear();
                if (!String.IsNullOrEmpty(contentType))
                {
                    client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue(contentType));
                }
               
                //client.DefaultRequestHeaders.Add("Content-Type", contentType);
                if (authorizationKey != null)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authPrefix, authorizationKey);
                }
                if (!String.IsNullOrEmpty(accept))
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                }
                HttpResponseMessage response = await client.GetAsync(GetQueryString(service, port, paramQuery));
                var responseStr = await response.Content.ReadAsStringAsync();
                var status = Convert.ToInt32(response.StatusCode);

                if (status >= 200 && status < 300)
                {
                    Console.WriteLine("Respuesta CallGet str " + responseStr);
                    if (!String.IsNullOrEmpty(responseStr))
                    {
                        var r = JsonSerializer.Deserialize<R>(responseStr);
                        Console.WriteLine("Respuesta CallGet " + r);
                        return r;
                    }
                    else
                    {
                        return default(R);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR====>>>>:" + response.RequestMessage);
                    throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "ERROR EN LA LLAMADA METODO GET "+ status);
                }

            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR EN LA LLAMADA METODO GET", e.Message);
                throw new RelativeException("ERROR EN LA LLAMADA METODO GET", e);
            }
         

        }

        private static string GetQueryString(string service, Int32 port, List<KeyValuePair<string, string>> paramQuery ) {
            var builder = new UriBuilder(service);
            builder.Port = port;
            var query = "";
            foreach (KeyValuePair< string, string> item in paramQuery)
{
                Console.WriteLine(item.Key + "=>" + item.Value);
                query = query +item.Key +"="+item.Value;
                query = query + "&";
                Console.WriteLine("query>"+query);
            }
            Console.WriteLine("query>>>>>"+query);
            builder.Query = query;
            string url = builder.ToString();
            Console.WriteLine( "===>query string " + url  );
            return url;
        }


    }
}
