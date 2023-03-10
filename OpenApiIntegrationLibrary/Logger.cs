using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public static class Logger
    {
        public static void LogExceptions(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(Utility.ERROR_FILE_PATH, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine();

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Message : " + ex.Message);
                    writer.WriteLine("StackTrace : " + ex.StackTrace);

                    ex = ex.InnerException;
                }
            }
        }

        public static void LogExceptions(string ReasonPhrase, string StatusCode, bool IsSuccessStatusCode)
        {
            using (StreamWriter writer = new StreamWriter(Utility.ERROR_FILE_PATH, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString());
                writer.WriteLine("Error has occured....");


                writer.WriteLine("ReasonPhrase : " + ReasonPhrase);
                writer.WriteLine("StatusCode : " + StatusCode);
                writer.WriteLine("IsSuccessStatusCode : " + IsSuccessStatusCode);


            }
        }
    }
}
