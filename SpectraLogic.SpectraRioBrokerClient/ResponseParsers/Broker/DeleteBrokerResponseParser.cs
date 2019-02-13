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

using log4net;
using SpectraLogic.SpectraRioBrokerClient.Model;
using SpectraLogic.SpectraRioBrokerClient.Runtime;
using SpectraLogic.SpectraRioBrokerClient.Utils;
using System.Linq;
using System.Net;

namespace SpectraLogic.SpectraRioBrokerClient.ResponseParsers
{
    internal class DeleteBrokerResponseParser : IResponseParser<Void>
    {
        #region Private Fields

        private static readonly ILog LOG = LogManager.GetLogger("DeleteBrokerResponseParser");

        #endregion Private Fields

        #region Methods

        public Void Parse(IHttpWebResponse response)
        {
            using (response)
            {
                ResponseParseUtils.HandleStatusCode(response, HttpStatusCode.NoContent);
                var requestId = response.Headers["request-id"].First();
                LOG.Debug($"Request: {requestId}");
                return new Void();
            }
        }
    }

    #endregion Methods
}