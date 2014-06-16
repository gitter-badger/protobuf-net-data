﻿// Copyright 2012 Richard Dingwall - http://richarddingwall.name
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace ProtoBuf.Data.Internal
{
    using System;

    /// <summary>
    /// Exclude a type or method from code coverage.
    /// </summary>
    /// <remarks>Using our own because the BCL one is only available in .NET
    /// 4.0 and higher.</remarks>
    [AttributeUsage(AttributeTargets.Class 
        | AttributeTargets.Constructor 
        | AttributeTargets.Method
        | AttributeTargets.Property
        | AttributeTargets.Struct)]
    [ExcludeFromCodeCoverageAttribute]
    internal sealed class ExcludeFromCodeCoverageAttribute : Attribute
    {
    }
}