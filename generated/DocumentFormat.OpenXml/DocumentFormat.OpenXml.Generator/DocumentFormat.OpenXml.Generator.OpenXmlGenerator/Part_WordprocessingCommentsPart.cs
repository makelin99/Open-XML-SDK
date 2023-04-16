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
    /// Defines the WordprocessingCommentsPart
    /// </summary>
    public partial class WordprocessingCommentsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments";
        private DocumentFormat.OpenXml.Wordprocessing.Comments? _rootElement;

        /// <summary>
        /// Creates an instance of the WordprocessingCommentsPart OpenXmlType
        /// </summary>
        internal WordprocessingCommentsPart()
        {
        }

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts => GetPartsOfType<AlternativeFormatImportPart>();

        /// <summary>
        /// Gets the ChartParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Comments Comments
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Comments>();
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
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the DiagramColorsParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ExtendedChartParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<ExtendedChartPart> ExtendedChartParts => GetPartsOfType<ExtendedChartPart>();

        /// <summary>
        /// Gets the ImageParts of the WordprocessingCommentsPart
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
                _rootElement = value as DocumentFormat.OpenXml.Wordprocessing.Comments;
            }
        }

        /// <summary>
        /// Gets the Model3DReferenceRelationshipParts of the WordprocessingCommentsPart
        /// </summary>
        public IEnumerable<Model3DReferenceRelationshipPart> Model3DReferenceRelationshipParts => GetPartsOfType<Model3DReferenceRelationshipPart>();

        internal override OpenXmlPartRootElement? PartRootElement => Comments;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="partType">The part type information for the AlternativeFormatImportPart. Required.</param>
        /// <param name="contentType">The content type of the AlternativeFormatImportPart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (AlternativeFormatImportPart)OpenXmlPartExtensions.InitPart(this, new AlternativeFormatImportPart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="partType">The part type information for the EmbeddedControlPersistencePart. Required.</param>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (EmbeddedControlPersistencePart)OpenXmlPartExtensions.InitPart(this, new EmbeddedControlPersistencePart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="partType">The part type information for the EmbeddedObjectPart. Required.</param>
        /// <param name="contentType">The content type of the EmbeddedObjectPart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (EmbeddedObjectPart)OpenXmlPartExtensions.InitPart(this, new EmbeddedObjectPart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="partType">The part type information for the EmbeddedPackagePart. Required.</param>
        /// <param name="contentType">The content type of the EmbeddedPackagePart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (EmbeddedPackagePart)OpenXmlPartExtensions.InitPart(this, new EmbeddedPackagePart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="partType">The part type information for the ImagePart. Required.</param>
        /// <param name="contentType">The content type of the ImagePart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (ImagePart)OpenXmlPartExtensions.InitPart(this, new ImagePart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the WordprocessingCommentsPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature, IKnownDataPartFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "comments";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2014/relationships/chartEx", "application/vnd.ms-office.chartex+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", "application/vnd.ms-office.drawingml.diagramDrawing+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/model3d", "model/gltf-binary", false, true, FileFormatVersions.Office2019 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
            bool IKnownDataPartFeature.IsKnown(string relationshipId) => relationshipId is VideoReferenceRelationship.RelationshipTypeConst;
        }
    
    }
}
