﻿using Mono.Cecil;
using Mono.Collections.Generic;

namespace Equals.Fody.Extensions
{
    public static class CollectionParameterDefinitionExtensions
    {
        public static ParameterDefinition Add(this Collection<ParameterDefinition> parameters, string name, TypeReference type)
        {
            var parameter = new ParameterDefinition("right", ParameterAttributes.None, type);
            parameters.Add(parameter);
            return parameter;
        }
    }
}