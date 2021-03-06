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

using System.Collections.Generic;
using SpectraLogic.SpectraRioBrokerClient.Model;
using SpectraLogic.SpectraRioBrokerClient.Utils;

namespace SpectraLogic.SpectraRioBrokerClient.Test
{
    public static class Stubs
    {
        #region Fields

        public static AgentConfig AgentConfig = new AgentConfig("name", "user", "bucket");

        public const string AgentName = "agentName";

        public static readonly IEnumerable<ArchiveFile> ArchiveFiles = new List<ArchiveFile>
        {
            new ArchiveFile(
                "fileName",
                "file://uri".ToUri(),
                1234,
                new Dictionary<string, string>
                {
                    {"key", "value"}
                },
                false)
        };

        public const string BrokerName = "brokerName";

        public static readonly IEnumerable<RestoreFile> RestoreFiles = new List<RestoreFile>
        {
            new RestoreFile("name", "file://dest".ToUri()),
            new RestoreFile("name2", "file://dest2".ToUri(), new ByteRange(0, 10)),
            new RestoreFile("name3", "file://dest3".ToUri(),
                new TimeCodeRange(new TimeCode(01, 00, 00, 00, true), new TimeCode(02, 00, 00, 00, true)))
        };

        #endregion Fields
    }
}