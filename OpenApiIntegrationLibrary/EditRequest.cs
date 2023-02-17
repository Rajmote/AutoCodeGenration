using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenApiIntegrationLibrary
{
    public class EditRequest
    {
        // "model": ""code-davinci-edit-001"",
        [JsonPropertyName("model")]
        public string? Model
        {
            get;
            set;
        }

        //"input": "What day of the wek is it?",
        [JsonPropertyName("input")]
        public string? Input
        {
            get;
            set;
        }

        //"max_tokens": "Fix the spelling mistakes",
        [JsonPropertyName("instruction")]
        public string? Instruction
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

    }
}
