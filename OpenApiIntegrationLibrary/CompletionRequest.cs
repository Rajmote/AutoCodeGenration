using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public class CompletionRequest
    {
        // "model": "code-davinci-002",
        [JsonPropertyName("model")]
        public string? Model
        {
            get;
            set;
        }

        //"prompt": "Say this is a test",
        [JsonPropertyName("prompt")]
        public string? Prompt
        {
            get;
            set;
        }

        //"max_tokens": 7,
        [JsonPropertyName("max_tokens")]
        public int? MaxTokens
        {
            get;
            set;
        }

        // "temperature": 0,
        [JsonPropertyName("temperature")]
        public int? Temperature
        {
            get;
            set;
        }

        //"top_p": 1,
        [JsonPropertyName("top_p")]
        public int? Top_p
        {
            get;
            set;
        }

        //"n": 1,
        [JsonPropertyName("n")]
        public int? N
        {
            get;
            set;
        }

        //  "stream": false,
        [JsonPropertyName("stream")]
        public bool? Stream
        {
            get;
            set;
        }

        //  "logprobs": null,
        [JsonPropertyName("logprobs")]
        public int? Logprobs
        {
            get;
            set;
        }

        //  "stop": "\n",
        [JsonPropertyName("stop")]
        public string? Stop
        {
            get;
            set;
        }
    }
}
