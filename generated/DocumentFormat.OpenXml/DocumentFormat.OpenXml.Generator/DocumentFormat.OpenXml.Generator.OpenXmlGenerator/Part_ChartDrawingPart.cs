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
    /// Defines the ChartDrawingPart
    /// </summary>
    public partial class ChartDrawingPart : OpenXmlPart, ISupportExtensibleRelationship<ImagePart>, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes";
        private DocumentFormat.OpenXml.Drawing.Charts.UserShapes? _rootElement;

        /// <summary>
        /// Creates an instance of the ChartDrawingPart OpenXmlType
        /// </summary>
        internal ChartDrawingPart()
        {
        }

        /// <summary>
        /// Gets the ChartPart of the ChartDrawingPart
        /// </summary>
        public ChartPart? ChartPart => GetSubPartOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ExtendedChartPart of the ChartDrawingPart
        /// </summary>
        public ExtendedChartPart? ExtendedChartPart => GetSubPartOfType<ExtendedChartPart>();

        /// <summary>
        /// Gets the ImageParts of the ChartDrawingPart
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
                _rootElement = value as DocumentFormat.OpenXml.Drawing.Charts.UserShapes;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => UserShapes;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Drawing.Charts.UserShapes UserShapes
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Drawing.Charts.UserShapes>();
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
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "drawing";
            string ITargetFeature.Path => "../drawings";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2014/relationships/chartEx", "application/vnd.ms-office.chartex+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
