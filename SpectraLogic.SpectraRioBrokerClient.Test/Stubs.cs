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

using SpectraLogic.SpectraRioBrokerClient.Model;
using System.Collections.Generic;

namespace SpectraLogic.SpectraRioBrokerClient.Test
{
    public static class Stubs
    {
        #region Public Fields

        public static AgentConfig AgentConfig = new AgentConfig("name", "user", "bucket", false);

        public static IEnumerable<ArchiveFile> ArchiveFiles = new List<ArchiveFile>
        {
            new ArchiveFile(
                "fileName",
                "uri",
                1234,
                new Dictionary<string, string> {
                    { "key", "value" }
                },
                false,
                false)
        };

        public static string BrokerName = "brokerName";
        public static string AgentName = "agentName";

        public static IEnumerable<RestoreFile> RestoreFiles = new List<RestoreFile>
        {
            new RestoreFile("name", "dest", true),
            new RestoreFile("name2", "dest2", new ByteRange(0, 10)),
            new RestoreFile("name3", "dest3", "01:00:00;00-02:00:00;00")
        };

        #endregion Public Fields
    }
}