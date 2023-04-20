﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class OpenXmlPartExtensions
    {
        internal static OpenXmlPart InitPart(this OpenXmlPartContainer parent, OpenXmlPart childPart, PartTypeInfo partType, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            string contentType = partType.ContentType;

            var partExtension = partType.Extension;
            parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }

    /// <summary>
    /// Defines information used in creating a new part.
    /// </summary>
    public readonly record struct PartTypeInfo
    {
        /// <summary>
        /// Ctor - assign content type and extention.
        /// </summary>
        public PartTypeInfo(string contentType, string extension)
        {
            ContentType = contentType;
            Extension = extension;
        }

        /// <summary>
        /// Gets content type for the part.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Gets the file extension for the part.
        /// </summary>
        public string Extension { get; }
    }

    /// <summary>
    /// Defines the interface for tagging a part that can add extensible parts.
    /// </summary>
    /// <typeparam name="TPart">Extensible part type that is supported by the implementing class.</typeparam>
#pragma warning disable CA1040 // Avoid empty interfaces
    public interface IAddExtensiblePartSupport<TPart>
#pragma warning restore CA1040 // Avoid empty interfaces
        where TPart : OpenXmlPart
    {
    }
}