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

namespace SpectraLogic.SpectraRioBrokerClient.Integration.Test
{
    internal static class StringExtensions
    {
        #region Public Methods

<<<<<<< Updated upstream
        public static string ToFileUri(this string str)
        {
            return string.Format("{0}{1}", "file:///", str.Replace("\\", "/").Replace(" ", "%20"));
        }
=======
        public static Uri ToFileUri(this string str) => $"file://{str.Replace("\\", "/").Replace(" ", "%20")}".ToUri();

        public static Uri ToHttpsUri(this string str) => $"https://{str}".ToUri();
>>>>>>> Stashed changes

        #endregion Public Methods
    }
}