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
    /// Defines the ThemePart
    /// </summary>
    public partial class ThemePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.theme+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme";
        private DocumentFormat.OpenXml.Drawing.Theme? _rootElement;

        /// <summary>
        /// Creates an instance of the ThemePart OpenXmlType
        /// </summary>
        internal ThemePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ImageParts of the ThemePart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Drawing.Theme;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => Theme;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Drawing.Theme Theme
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Drawing.Theme>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <summary>
        /// Adds a ImagePart to the ThemePart
        /// </summary>
        /// <param name="partType">The part type information for the ImagePart. Required.</param>
        /// <param name="contentType">The content type of the ImagePart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (ImagePart)OpenXmlPartExtensions.InitPart(this, new ImagePart(), partType, contentType, id);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "theme";
            string ITargetFeature.Path => "theme";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
