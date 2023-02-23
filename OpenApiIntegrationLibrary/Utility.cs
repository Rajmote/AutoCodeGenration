using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Configuration;
using System.Dynamic;

namespace OpenApiIntegrationLibrary
{
    public static class Utility
    {
        #region "Variables"

        // Common Utility variables
        public static readonly string? BASE_URL = ConfigurationManager.AppSettings["BASE_URL"];
        public static readonly string? OPENAI_API_KEY = ConfigurationManager.AppSettings["OPENAI_API_KEY"];
        public static readonly string? ALLOWED_FILE_EXTENTIONS = ConfigurationManager.AppSettings["ALLOWED_FILE_EXTENTIONS"];
        public static readonly string? OPERATIONS = ConfigurationManager.AppSettings["OPERATIONS"];
        public static readonly string? CREATE_URL = ConfigurationManager.AppSettings["CREATE_URL"];
        public static readonly string? ERROR_FILE_PATH = ConfigurationManager.AppSettings["ERROR_FILE_PATH"];
        public static readonly string? MODEL_JSON_PATH = ConfigurationManager.AppSettings["MODEL_JSON_PATH"];

        // Edit code for Error and Comments
        //public static readonly string? EDIT_QUERY= GetSettings.AppSettings["EDIT_QUERY"]; 
        //public static readonly string? CODE_FILES_PATH = GetSettings.AppSettings["CODE_FILES_PATH"];  
        //public static readonly string? EDIT_URL = ConfigurationManager.AppSettings["EDIT_URL"];
        //public static readonly string? EDIT_MODEL = ConfigurationManager.AppSettings["EDIT_MODEL"]; 
        //public static readonly int? EDIT_TEMPRATURE = Convert.ToInt32(ConfigurationManager.AppSettings["EDIT_TEMPRATURE"]); 
        //public static readonly int? EDIT_TOP_P = Convert.ToInt32(ConfigurationManager.AppSettings["EDIT_TOP_P"]);
        //public static readonly int? EDIT_N = Convert.ToInt32(ConfigurationManager.AppSettings["EDIT_N"]); 

        // Create Code for Unit Test 
        //public const string CREATE_QUERY = "Create complete Unit Test Class"; 
        //public static readonly string? TEST_FILES_PATH = GetSettings.AppSettings["TEST_FILES_PATH"];
        //public static readonly string? CREATE_PROMPT = GetSettings.AppSettings["CREATE_PROMPT"];


        //public static readonly string? CREATE_MODEL = ConfigurationManager.AppSettings["CREATE_MODEL"];
        //public static readonly int? CREATE_MAX_TOKEN = Convert.ToInt32(ConfigurationManager.AppSettings["CREATE_MAX_TOKEN"]);
        //public static readonly double? CREATE_TEMPRATURE = Convert.ToDouble(ConfigurationManager.AppSettings["CREATE_TEMPRATURE"]);
        //public static readonly int? CREATE_TOP_P = Convert.ToInt32(ConfigurationManager.AppSettings["CREATE_TOP_P"]);
        //public static readonly int? CREATE_N = Convert.ToInt32(ConfigurationManager.AppSettings["CREATE_N"]);
        //public static readonly bool? CREATE_STREAM = Convert.ToBoolean(ConfigurationManager.AppSettings["CREATE_STREAM"]);
        //public static readonly string? CREATE_LOGPROBS = ConfigurationManager.AppSettings["CREATE_LOGPROBS"];
        //public static readonly string? CREATE_STOP = ConfigurationManager.AppSettings["CREATE_STOP"];

        // Error messages
        //public static readonly string? ERROR_WHILE_OPERATING_FILE = GetSettings.AppSettings["ERROR_WHILE_OPERATING_FILE"];
        //public static readonly string? SUCCESS_MESSAGE = GetSettings.AppSettings["SUCCESS_MESSAGE"];

        #endregion

        public static List<string> GetAllowedFileExtentions()
        {
            var arrayOfExtention = Utility.ALLOWED_FILE_EXTENTIONS.Split(";");
            return arrayOfExtention.ToList();
        }

        public static List<string> GetOperations()
        {
            var arrayOfOperations = Utility.OPERATIONS.Split(";");
            return arrayOfOperations.ToList();
        }

        public static bool DoesPropertyExist(dynamic item, string? propertyName)
        {
            
            if (item.GetType() == typeof(Newtonsoft.Json.Linq.JObject))
            {               
                foreach (var property in item)
                {
                    if (property.Name.ToString().ToLower() == propertyName.ToLower())
                    {
                        return true;
                    }                    
                }
            }
               

            return false;
        }

    }

    public class FileInformation
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }

}
