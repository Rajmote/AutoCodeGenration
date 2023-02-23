using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public class OpenApiIntegration
    {


        public async Task<bool> PerformOperation(List<FileInformation> codeFileList, string query, string destinationPath)
        {
            foreach (var file in codeFileList)
            {
                try
                {
                    dynamic request = null;
                    string? OperationUrl = string.Empty;
                    string codeText = System.IO.File.ReadAllText(file.FilePath);

                    string Query = query + codeText;
                
                    request = JsonConvert.DeserializeObject<object>(File.ReadAllText(Utility.MODEL_JSON_PATH));

                    bool isContainPrompt = Utility.DoesPropertyExist(request, "prompt");

                    bool isContainInput = Utility.DoesPropertyExist(request, "input");

                    bool isContainInstruction = Utility.DoesPropertyExist(request, "instruction");
                  
                    if(isContainPrompt)
                    {
                        request.prompt = Query;
                    }

                    if(isContainInput)
                    {
                        request.input = codeText;
                    }

                    if (isContainInstruction)
                    {
                        request.instruction = query;
                    }

                    OperationUrl = Utility.CREATE_URL;

                    var resultText = await CallOpenAIAPI(file.FilePath, OperationUrl, request);

                    if (!String.IsNullOrEmpty(resultText))
                    {
                        string fileName = Path.GetFileName(file.FilePath);
                        var resultFile = Path.Combine(destinationPath, fileName);
                        System.IO.File.WriteAllText(resultFile, resultText);
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogExceptions(ex);
                    continue;
                }
            }
            return true;
        }

        
        public async Task<string?> CallOpenAIAPI(string OperationalFile, string OperationUrl, object Request)
        {
            string? completionText = string.Empty;
            CompletionResponse? completionResponse = null;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (var httpReq = new HttpRequestMessage(HttpMethod.Post, OperationUrl))
                    {
                        httpReq.Headers.Add("Authorization", $"Bearer {Utility.OPENAI_API_KEY}");
                        string requestString = System.Text.Json.JsonSerializer.Serialize(Request);
                        httpReq.Content = new StringContent(requestString, Encoding.UTF8, "application/json");
                        using (HttpResponseMessage? httpResponse = await httpClient.SendAsync(httpReq))
                        {
                            if (httpResponse is not null && httpResponse.IsSuccessStatusCode)
                            {
                                string responseString = await httpResponse.Content.ReadAsStringAsync();
                                {
                                    if (!string.IsNullOrWhiteSpace(responseString))
                                    {
                                        completionResponse = System.Text.Json.JsonSerializer.Deserialize<CompletionResponse>(responseString);
                                    }
                                }
                            }
                            if (completionResponse is not null)
                            {
                                completionText = completionResponse.Choices?[0]?.Text;
                            }
                            else
                            {

                            }
                        }
                    }
                }
                return completionText;
            }
            catch (Exception ex)
            {
                Logger.LogExceptions(ex);
                throw;
            }
        }

    }
}
