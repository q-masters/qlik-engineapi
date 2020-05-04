using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace OpenRPC
{

    public partial class Method
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Param> Params { get; set; }
        public Result Result { get; set; }
        public List<Error> Errors { get; set; }
        public List<string> XQlikSeeAlso { get; set; }
        public string XQlikStability { get; set; }
    }

    public partial class Error
    {
        public string Ref { get; set; }
    }

    public partial class Param
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Required { get; set; }
        public ParamSchema Schema { get; set; }
    }

    public partial class ParamSchema
    {
        public string Type { get; set; }
        public JObject Items { get; set; }
    }

    public partial class Result
    {
        public string Name { get; set; }
        public ResultSchema Schema { get; set; }
    }

    public partial class ResultSchema
    {
        public string Type { get; set; }
        public JToken Properties { get; set; }
    }
}
