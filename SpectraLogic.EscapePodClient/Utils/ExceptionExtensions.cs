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

using SpectraLogic.EscapePodClient.Exceptions;
using SpectraLogic.EscapePodClient.Model;
using System;

namespace SpectraLogic.EscapePodClient.Utils
{
    public static class ExceptionExtensions
    {
        #region Methods

        public static UnprocessableErrorResponse ExtractUnprocessableErrorResponse(this Exception ex)
        {
            return (UnprocessableErrorResponse)((ErrorResponseException)ex.InnerException).ErrorResponse;
        }

        #endregion Methods
    }
}