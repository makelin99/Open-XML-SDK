﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the DigitalSignatureOriginPart
    /// </summary>
    public partial class DigitalSignatureOriginPart : OpenXmlPart,
        IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-package.digital-signature-origin";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin";

        /// <summary>
        /// Creates an instance of the DigitalSignatureOriginPart OpenXmlType
        /// </summary>
        internal DigitalSignatureOriginPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart
        /// </summary>
        public IEnumerable<XmlSignaturePart> XmlSignatureParts => GetPartsOfType<XmlSignaturePart>();
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Extension => ".sigs";
            string ITargetFeature.Name => "origin";
            string ITargetFeature.Path => "_xmlsignatures";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature", "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml", false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
