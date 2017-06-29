﻿namespace Microsoft.Bot.Builder.CognitiveServices.LuisActionBinding
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    public interface ILuisAction
    {
        Task<object> FulfillAsync();

        bool IsValid(out ICollection<ValidationResult> results);
    }
}
