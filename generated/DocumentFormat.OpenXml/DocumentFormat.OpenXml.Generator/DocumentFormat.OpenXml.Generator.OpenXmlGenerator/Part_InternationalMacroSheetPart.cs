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
    /// Defines the InternationalMacroSheetPart
    /// </summary>
    public partial class InternationalMacroSheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.intlmacrosheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet";

        /// <summary>
        /// Creates an instance of the InternationalMacroSheetPart OpenXmlType
        /// </summary>
        internal InternationalMacroSheetPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomPropertyParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<CustomPropertyPart> CustomPropertyParts => GetPartsOfType<CustomPropertyPart>();

        /// <summary>
        /// Gets the DrawingsPart of the InternationalMacroSheetPart
        /// </summary>
        public DrawingsPart? DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <summary>
        /// Gets the VmlDrawingParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Gets the WorksheetCommentsPart of the InternationalMacroSheetPart
        /// </summary>
        public WorksheetCommentsPart? WorksheetCommentsPart => GetSubPartOfType<WorksheetCommentsPart>();

        /// <summary>
        /// Adds a CustomPropertyPart to the InternationalMacroSheetPart
        /// </summary>
        /// <param name="partType">The part type information for the CustomPropertyPart. Required.</param>
        /// <param name="contentType">The content type of the CustomPropertyPart. Optional, default to null.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(PartTypeInfo partType, string? contentType = null, string? id = null)
        {
            return (CustomPropertyPart)OpenXmlPartExtensions.InitPart(this, new CustomPropertyPart(), partType, contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the InternationalMacroSheetPart
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
        /// Adds a EmbeddedPackagePart to the InternationalMacroSheetPart
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
        /// Adds a ImagePart to the InternationalMacroSheetPart
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
            string ITargetFeature.Name => "intlsheet";
            string ITargetFeature.Path => "macrosheets";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", "application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", "application/vnd.openxmlformats-officedocument.drawing+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", "application/vnd.openxmlformats-officedocument.vmlDrawing", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", "application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
