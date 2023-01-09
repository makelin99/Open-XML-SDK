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
    /// Defines the DocumentSettingsPart
    /// </summary>
    public partial class DocumentSettingsPart : TypedOpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
        private DocumentFormat.OpenXml.Wordprocessing.Settings? _rootElement;

        /// <summary>
        /// Creates an instance of the DocumentSettingsPart OpenXmlType
        /// </summary>
        internal protected DocumentSettingsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ImageParts of the DocumentSettingsPart
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
                _rootElement = value as DocumentFormat.OpenXml.Wordprocessing.Settings;
            }
        }

        /// <summary>
        /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart
        /// </summary>
        public MailMergeRecipientDataPart? MailMergeRecipientDataPart => GetSubPartOfType<MailMergeRecipientDataPart>();

        internal override OpenXmlPartRootElement? PartRootElement => Settings;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Settings Settings
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Settings>();
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
        /// Adds a ImagePart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the MailMergeRecipientDataPart</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType)
        {
            var childPart = new MailMergeRecipientDataPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the MailMergeRecipientDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType, string id)
        {
            var childPart = new MailMergeRecipientDataPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the MailMergeRecipientDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType, string id)
        {
            var contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
            var partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddMailMergeRecipientDataPart(contentType, id);
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the MailMergeRecipientDataPart</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType)
        {
            var contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
            var partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddMailMergeRecipientDataPart(contentType);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "settings";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData", null, false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
