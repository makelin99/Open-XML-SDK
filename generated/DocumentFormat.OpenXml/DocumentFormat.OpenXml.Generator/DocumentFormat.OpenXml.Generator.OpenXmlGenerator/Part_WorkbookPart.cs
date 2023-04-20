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
    /// Defines the WorkbookPart
    /// </summary>
    public partial class WorkbookPart : OpenXmlPart,
        ISupportedRelationship<CustomXmlPart>,
        ISupportedRelationship<ThumbnailPart>
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private DocumentFormat.OpenXml.Spreadsheet.Workbook? _rootElement;

        /// <summary>
        /// Creates an instance of the WorkbookPart OpenXmlType
        /// </summary>
        internal WorkbookPart()
        {
        }

        /// <summary>
        /// Gets the CalculationChainPart of the WorkbookPart
        /// </summary>
        public CalculationChainPart? CalculationChainPart => GetSubPartOfType<CalculationChainPart>();

        /// <summary>
        /// Gets the CellMetadataPart of the WorkbookPart
        /// </summary>
        public CellMetadataPart? CellMetadataPart => GetSubPartOfType<CellMetadataPart>();

        /// <summary>
        /// Gets the ChartsheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<ChartsheetPart> ChartsheetParts => GetPartsOfType<ChartsheetPart>();

        /// <summary>
        /// Gets the ConnectionsPart of the WorkbookPart
        /// </summary>
        public ConnectionsPart? ConnectionsPart => GetSubPartOfType<ConnectionsPart>();

        /// <summary>
        /// Gets the CT_RdRichValueStructureParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdRichValueStructurePart> CT_RdRichValueStructureParts => GetPartsOfType<RdRichValueStructurePart>();

        /// <summary>
        /// Gets the CustomDataPropertiesParts of the WorkbookPart
        /// </summary>
        public IEnumerable<CustomDataPropertiesPart> CustomDataPropertiesParts => GetPartsOfType<CustomDataPropertiesPart>();

        /// <summary>
        /// Gets the CustomXmlMappingsPart of the WorkbookPart
        /// </summary>
        public CustomXmlMappingsPart? CustomXmlMappingsPart => GetSubPartOfType<CustomXmlMappingsPart>();

        /// <summary>
        /// Gets the CustomXmlParts of the WorkbookPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the DialogsheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<DialogsheetPart> DialogsheetParts => GetPartsOfType<DialogsheetPart>();

        /// <summary>
        /// Gets the ExcelAttachedToolbarsPart of the WorkbookPart
        /// </summary>
        public ExcelAttachedToolbarsPart? ExcelAttachedToolbarsPart => GetSubPartOfType<ExcelAttachedToolbarsPart>();

        /// <summary>
        /// Gets the ExternalWorkbookParts of the WorkbookPart
        /// </summary>
        public IEnumerable<ExternalWorkbookPart> ExternalWorkbookParts => GetPartsOfType<ExternalWorkbookPart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.Workbook;
            }
        }

        /// <summary>
        /// Gets the InternationalMacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<InternationalMacroSheetPart> InternationalMacroSheetParts => GetPartsOfType<InternationalMacroSheetPart>();

        /// <summary>
        /// Gets the MacroSheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<MacroSheetPart> MacroSheetParts => GetPartsOfType<MacroSheetPart>();

        internal override OpenXmlPartRootElement? PartRootElement => Workbook;

        /// <summary>
        /// Gets the PivotTableCacheDefinitionParts of the WorkbookPart
        /// </summary>
        public IEnumerable<PivotTableCacheDefinitionPart> PivotTableCacheDefinitionParts => GetPartsOfType<PivotTableCacheDefinitionPart>();

        /// <summary>
        /// Gets the RdArrayParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdArrayPart> RdArrayParts => GetPartsOfType<RdArrayPart>();

        /// <summary>
        /// Gets the RdRichValueParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdRichValuePart> RdRichValueParts => GetPartsOfType<RdRichValuePart>();

        /// <summary>
        /// Gets the RdRichValueTypesParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdRichValueTypesPart> RdRichValueTypesParts => GetPartsOfType<RdRichValueTypesPart>();

        /// <summary>
        /// Gets the RdRichValueWebImagePart of the WorkbookPart
        /// </summary>
        public RdRichValueWebImagePart? RdRichValueWebImagePart => GetSubPartOfType<RdRichValueWebImagePart>();

        /// <summary>
        /// Gets the RdSupportingPropertyBagParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdSupportingPropertyBagPart> RdSupportingPropertyBagParts => GetPartsOfType<RdSupportingPropertyBagPart>();

        /// <summary>
        /// Gets the RdSupportingPropertyBagStructureParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RdSupportingPropertyBagStructurePart> RdSupportingPropertyBagStructureParts => GetPartsOfType<RdSupportingPropertyBagStructurePart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the RichStylesParts of the WorkbookPart
        /// </summary>
        public IEnumerable<RichStylesPart> RichStylesParts => GetPartsOfType<RichStylesPart>();

        /// <summary>
        /// Gets the SharedStringTablePart of the WorkbookPart
        /// </summary>
        public SharedStringTablePart? SharedStringTablePart => GetSubPartOfType<SharedStringTablePart>();

        /// <summary>
        /// Gets the SlicerCacheParts of the WorkbookPart
        /// </summary>
        public IEnumerable<SlicerCachePart> SlicerCacheParts => GetPartsOfType<SlicerCachePart>();

        /// <summary>
        /// Gets the ThemePart of the WorkbookPart
        /// </summary>
        public ThemePart? ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the ThumbnailPart of the WorkbookPart
        /// </summary>
        public ThumbnailPart? ThumbnailPart => GetSubPartOfType<ThumbnailPart>();

        /// <summary>
        /// Gets the TimeLineCacheParts of the WorkbookPart
        /// </summary>
        public IEnumerable<TimeLineCachePart> TimeLineCacheParts => GetPartsOfType<TimeLineCachePart>();

        /// <summary>
        /// Gets the VbaProjectPart of the WorkbookPart
        /// </summary>
        public VbaProjectPart? VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the VolatileDependenciesPart of the WorkbookPart
        /// </summary>
        public VolatileDependenciesPart? VolatileDependenciesPart => GetSubPartOfType<VolatileDependenciesPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.Workbook Workbook
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.Workbook>();
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
        /// Gets the WorkbookPersonParts of the WorkbookPart
        /// </summary>
        public IEnumerable<WorkbookPersonPart> WorkbookPersonParts => GetPartsOfType<WorkbookPersonPart>();

        /// <summary>
        /// Gets the WorkbookRevisionHeaderPart of the WorkbookPart
        /// </summary>
        public WorkbookRevisionHeaderPart? WorkbookRevisionHeaderPart => GetSubPartOfType<WorkbookRevisionHeaderPart>();

        /// <summary>
        /// Gets the WorkbookStylesPart of the WorkbookPart
        /// </summary>
        public WorkbookStylesPart? WorkbookStylesPart => GetSubPartOfType<WorkbookStylesPart>();

        /// <summary>
        /// Gets the WorkbookUserDataPart of the WorkbookPart
        /// </summary>
        public WorkbookUserDataPart? WorkbookUserDataPart => GetSubPartOfType<WorkbookUserDataPart>();

        /// <summary>
        /// Gets the WorksheetParts of the WorkbookPart
        /// </summary>
        public IEnumerable<WorksheetPart> WorksheetParts => GetPartsOfType<WorksheetPart>();
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "workbook";
            string ITargetFeature.Path => "xl";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain", "application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections", "application/vnd.openxmlformats-officedocument.spreadsheetml.connections+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps", "application/xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings", "application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders", "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames", "application/vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", "application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", null, false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies", "application/vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet", "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet", "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink", "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition", "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars", "application/vnd.ms-excel.attachedToolbars", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/vbaProject", "application/vnd.ms-office.vbaProject", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet", "application/vnd.ms-excel.macrosheet+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet", "application/vnd.ms-excel.intlmacrosheet+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2007/relationships/customDataProps", "application/vnd.ms-excel.customDataProperties+xml", false, true, FileFormatVersions.Office2010 },
                { "http://schemas.microsoft.com/office/2007/relationships/slicerCache", "application/vnd.ms-excel.slicerCache+xml", false, true, FileFormatVersions.Office2010 },
                { "http://schemas.microsoft.com/office/2011/relationships/timelineCache", "application/vnd.ms-excel.timelineCache+xml", false, true, FileFormatVersions.Office2013 },
                { "http://schemas.microsoft.com/office/2017/10/relationships/person", "application/vnd.ms-excel.person+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdRichValue", "application/vnd.ms-excel.rdrichvalue+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdRichValueStructure", "application/vnd.ms-excel.rdrichvaluestructure+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdArray", "application/vnd.ms-excel.rdarray+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/richStyles", "application/vnd.ms-excel.richstyles+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdSupportingPropertyBag", "application/vnd.ms-excel.rdsupportingpropertybag+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdSupportingPropertyBagStructure", "application/vnd.ms-excel.rdsupportingpropertybagstructure+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/rdRichValueTypes", "application/vnd.ms-excel.rdrichvaluetypes+xml", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.microsoft.com/office/2020/07/relationships/rdrichvaluewebimage", "application/vnd.ms-excel.rdrichvaluewebimage+xml", false, false, FileFormatVersions.Office2021 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
