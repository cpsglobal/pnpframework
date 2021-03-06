﻿using PnP.Framework.Provisioning.Model;
using PnP.Framework.Provisioning.ObjectHandlers;
using System;
using System.Collections.Generic;

namespace PnP.Framework.Test.Framework.Functional.Validators
{
    public class PropertyBagValidator : ValidatorBase
    {
        public bool Validate(PropertyBagEntryCollection sourceCollection, PropertyBagEntryCollection targetCollection, TokenParser tokenParser)
        {
            Dictionary<string, string[]> parserSettings = new Dictionary<string, string[]>
            {
                { "Value", null }
            };
            bool isPropertyBagsMatch = ValidateObjects(sourceCollection, targetCollection, new List<string> { "Key", "Value", "Indexed" }, tokenParser, parserSettings);
            Console.WriteLine("-- Property Bags validation " + isPropertyBagsMatch);
            return isPropertyBagsMatch;
        }
    }
}
