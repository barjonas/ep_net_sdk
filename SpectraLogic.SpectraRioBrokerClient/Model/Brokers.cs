﻿/*
 * ******************************************************************************
 *   Copyright 2014-2019 Spectra Logic Corporation. All Rights Reserved.
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
using System.Collections.Generic;

namespace SpectraLogic.SpectraRioBrokerClient.Model
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="SpectraLogic.SpectraRioBrokerClient.Model.IBrokers" />
    public class Brokers : IBrokers
    {
        #region Private Constructors

        [JsonConstructor]
        private Brokers(IList<Broker> brokerList, PageResult page)
        {
            BrokerList = brokerList;
            Page = page;
        }

        #endregion Private Constructors

        #region Public Properties

        /// <summary>Gets the page.</summary>
        /// <value>The page.</value>
        [JsonProperty(PropertyName = "page")] public PageResult Page { get; }
        
        /// <summary>Gets the broker list.</summary>
        /// <value>The broker list.</value>
        [JsonProperty(PropertyName = "brokers")] public IList<Broker> BrokerList { get; }

        #endregion Public Properties
    }
}