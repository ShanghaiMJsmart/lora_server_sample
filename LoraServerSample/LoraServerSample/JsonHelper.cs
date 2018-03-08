using System.IO;
using Newtonsoft.Json;

namespace LoraServerSample
{
    public static class JsonHelper
    {
        /// <summary> 
        /// 序列化为JSON
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObject(object value)
        {
            var timeConverter = new Newtonsoft.Json.Converters.IsoDateTimeConverter();
            timeConverter.DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";

            return JsonConvert.SerializeObject(value, Formatting.Indented, timeConverter);
            
        }

        public static string SerializeObject(object value, Formatting formatting)
        {
            var timeConverter = new Newtonsoft.Json.Converters.IsoDateTimeConverter();
            timeConverter.DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";

            return JsonConvert.SerializeObject(value, formatting, timeConverter);

        }

        /// <summary> 
        /// JSON对象反序列化 
        /// </summary> 
        /// <param name="JSON"></param>  
        /// <returns></returns> 
        public static T DeserializeObject<T>(string JSON)
        {
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            StringReader sr = new StringReader(JSON);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            T result = (T)json.Deserialize(reader, typeof(T));
            reader.Close();
            return result;
        }

        public static object DeserializeObject(string JSON, System.Type type)
        {
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            StringReader sr = new StringReader(JSON);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            object result = json.Deserialize(reader, type);
            reader.Close();
            return result;
        }


        public static T DeserializeObjectToObject<T>(object obj)
        {
            string json = SerializeObject(obj);
            return DeserializeObject<T>(json);
        }

        public static object DeserializeObjectToObject(object obj, System.Type type)
        {
            string json = SerializeObject(obj);
            return DeserializeObject(json, type);
        }

        /// <summary>
        /// Json对象反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">字符流</param>
        /// <returns></returns>
        public static T DeserializeObject<T>(Stream stream)
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            serializer.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            serializer.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            using (var sr = new StreamReader(stream))
            {
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    return serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }
        /// <summary>
        /// Json对象反序列化
        /// </summary>
        /// <param name="stream">字符流</param>
        /// <param name="type">反序列化类型</param>
        /// <returns></returns>
        public static object DeserializeObject(Stream stream, System.Type type)
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            serializer.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            serializer.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            using (var sr = new StreamReader(stream))
            {
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    return serializer.Deserialize(jsonTextReader, type);
                }
            }
        }

        public static Stream SerializeObjectToStream(object value)
        {

            MemoryStream stream = new MemoryStream();

            using (StreamWriter writer = new StreamWriter(stream))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
                {
                    JsonSerializer ser = new JsonSerializer();
                    ser.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                    ser.Serialize(jsonWriter, value);
                    jsonWriter.Flush();
                }
            }

            return stream;
        }
    }
}
