using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public static class Utility
    {
        // Common Utility variables
        public const string BASE_URL = "https://beta.openai.com/";
        public const string OPENAI_API_KEY = "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";
        public const string ALLOWED_FILE_EXTENTIONS = ".cs";

        // Edit code for Error and Comments
        public const string EDIT_QUERY= "Edit code for Errors insert try catch block as well as code comments";
        public const string CODE_FILES_PATH = @"C:\\Users\rajendra.m\Desktop\Private\Study\GitRepo\chat\codefiles\";
        public const string EDIT_URL = "https://api.openai.com/v1/edits";
        public const string EDIT_MODEL = "code-davinci-edit-001";
        public const int EDIT_TEMPRATURE = 0;
        public const int EDIT_TOP_P = 0;
        public const int EDIT_N = 1;


        // Create Code for Unit Test 
        //public const string CREATE_QUERY = "Create complete Unit Test Class"; 
        public const string TEST_FILES_PATH = @"C:\Users\rajendra.m\Desktop\Private\Study\GitRepo\chat\testfiles\";
        public const string CREATE_URL = "https://api.openai.com/v1/completions";
        public const string CREATE_PROMPT = "# Create Unit Test Class";
        public const string CREATE_MODEL = "text-davinci-003";//"code-cushman-001"; //"code-davinci-002"; //"code-davinci-edit-001";
        public const int CREATE_MAX_TOKEN = 3000;
        public const int CREATE_TEMPRATURE = 0;
        public const int CREATE_TOP_P = 0;
        public const int CREATE_N = 1;
        public const bool CREATE_STREAM = false;
        public const string? CREATE_LOGPROBS = null;
        public const string CREATE_STOP = "\n";

        
        // Error messages
        public const string ERROR_WHILE_OPERATING_FILE = " file has issue, please check code manually.";
        public const string SUCCESS_MESSAGE = " has processed sucessfully.";
    }
}
