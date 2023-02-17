using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public class OpenApiIntegration
    {
        public async Task<bool> EditCodeFilesForCommentAndErrorCheck()
        {
            var codeFileList = Directory.GetFiles(Utility.CODE_FILES_PATH ?? string.Empty, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(Utility.ALLOWED_FILE_EXTENTIONS));

            foreach (var file in codeFileList)
            {
                try
                {
                    string codeText = System.IO.File.ReadAllText(file);

                    EditRequest editRequest = new EditRequest
                    {
                        Model = Utility.EDIT_MODEL,
                        Input = codeText,
                        Instruction = Utility.EDIT_QUERY,
                        Temperature = Utility.EDIT_TEMPRATURE,
                        Top_p = Utility.EDIT_TOP_P,
                        N = Utility.EDIT_N,
                    };

                    var resultText = await CallOpenAIAPI(file, Utility.EDIT_URL, editRequest);

                    if (!String.IsNullOrEmpty(resultText))
                    {
                        System.IO.File.WriteAllText(file, resultText);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(file + Utility.ERROR_WHILE_OPERATING_FILE + ex.Message);
                    continue;
                }
            }

            return true;
        }

        public async Task<bool> CreateUnitTestFiles()
        {
            var codeFileList = Directory.GetFiles(Utility.CODE_FILES_PATH ?? string.Empty, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(Utility.ALLOWED_FILE_EXTENTIONS));

            foreach (var file in codeFileList)
            {
                try
                {
                    string codeText = System.IO.File.ReadAllText(file);
                    string Query = Utility.CREATE_PROMPT + codeText;
                    CompletionRequest completeRequest = new CompletionRequest 
                    {
                        Model = Utility.CREATE_MODEL,
                        Prompt = Query,
                        MaxTokens = Utility.CREATE_MAX_TOKEN,
                        //Temperature = Utility.CREATE_TEMPRATURE,
                        //N = Utility.CREATE_N,
                        //Stop = Utility.CREATE_STOP
                    };

                    var resultText = await CallOpenAIAPI(file, Utility.CREATE_URL, completeRequest);

                    if (!String.IsNullOrEmpty(resultText))
                    {
                        string fileName = Path.GetFileName(file);
                        var testFile = Path.Combine(Utility.TEST_FILES_PATH, fileName);
                        System.IO.File.WriteAllText(testFile, resultText);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(file + Utility.ERROR_WHILE_OPERATING_FILE + ex.Message);
                    continue;
                }
            }
            return true;
        }

        public async Task<string> CallOpenAIAPI(string OperationalFile, string OperationUrl, object Request)
        {
            string? completionText = string.Empty;
            CompletionResponse completionResponse = null;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (var httpReq = new HttpRequestMessage(HttpMethod.Post, OperationUrl))
                    {
                        httpReq.Headers.Add("Authorization", $"Bearer {Utility.OPENAI_API_KEY}");
                        string requestString = JsonSerializer.Serialize(Request);
                        httpReq.Content = new StringContent(requestString, Encoding.UTF8, "application/json");
                        using (HttpResponseMessage? httpResponse = await httpClient.SendAsync(httpReq))
                        {
                            if (httpResponse is not null && httpResponse.IsSuccessStatusCode)
                            {
                                string responseString = await httpResponse.Content.ReadAsStringAsync();
                                {
                                    if (!string.IsNullOrWhiteSpace(responseString))
                                    {
                                        completionResponse = JsonSerializer.Deserialize<CompletionResponse>(responseString);
                                    }
                                }
                            }
                            if (completionResponse is not null)
                            {
                                completionText = completionResponse.Choices?[0]?.Text;
                                Console.WriteLine(completionText);
                            }
                            else
                            {
                                Console.WriteLine(OperationalFile + Utility.ERROR_WHILE_OPERATING_FILE);
                            }
                            Console.WriteLine("File => "+ OperationalFile);
                            Console.WriteLine("Status Code => " + httpResponse.StatusCode.ToString());
                        }
                    }
                }
                return completionText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(OperationalFile + Utility.ERROR_WHILE_OPERATING_FILE + ex.Message);
                throw;
            }
        }

    }
}
