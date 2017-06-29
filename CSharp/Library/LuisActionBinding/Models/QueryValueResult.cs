﻿namespace Microsoft.Bot.Builder.CognitiveServices.LuisActionBinding
{
    using System;

    [Serializable]
    public class QueryValueResult
    {
        public QueryValueResult(bool succeed)
        {
            this.Succeed = succeed;
        }

        public ILuisAction NewAction { get; set; }

        public string NewIntent { get; set; }

        public bool Succeed { get; private set; }
    }
}
