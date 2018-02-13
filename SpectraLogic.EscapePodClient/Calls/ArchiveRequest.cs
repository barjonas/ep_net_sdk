﻿/*
 * ******************************************************************************
 *   Copyright 2014-2018 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

using Newtonsoft.Json;
using SpectraLogic.EscapePodClient.Model;
using SpectraLogic.EscapePodClient.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpectraLogic.EscapePodClient.Calls
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="SpectraLogic.EscapePodClient.Calls.RestRequest" />
    public class ArchiveRequest : RestRequest
    {
        #region Fields

        /// <summary>
        /// The files to be archive
        /// </summary>
        [JsonProperty(Order = 1, PropertyName = "files")] public IEnumerable<ArchiveFile> Files;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveRequest" /> class.
        /// </summary>
        /// <param name="archiveName">Name of the archive.</param>
        /// <param name="files">The files.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public ArchiveRequest(string archiveName, IEnumerable<ArchiveFile> files)
        {
            Contract.Requires<ArgumentNullException>(archiveName != null, "archiveName");
            Contract.Requires<ArgumentNullException>(files != null, "files");

            ArchiveName = archiveName;
            Files = files;

            QueryParams.Add("operation", "archive");
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the name of the archive.
        /// </summary>
        /// <value>
        /// The name of the archive.
        /// </value>
        [JsonIgnore] public string ArchiveName { get; private set; }

        internal override HttpVerb Verb => HttpVerb.POST;
        internal override string Path => $"/api/archives/{ArchiveName}/jobs";

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Path}?{string.Join(";", QueryParams.Select(q => q.Key + "=" + q.Value))}\n{Verb}\n{GetBody()}";
        }

        internal override string GetBody()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion Methods
    }
}