﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    internal static partial class AlternativeFormatImportPartExtensions
    {
        /// <summary>
        /// Adds a AlternativeFormatImportPart to a parent IAddExtensiblePart class.
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, IAddExtensiblePartSupport<AlternativeFormatImportPart>
        {
            return (AlternativeFormatImportPart)OpenXmlPartExtensions.InitPart(parent, new AlternativeFormatImportPart(), partType, id);
        }
    }
}