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

using SpectraLogic.EscapePodClient.Calls;
using SpectraLogic.EscapePodClient.Model;

namespace SpectraLogic.EscapePodClient
{
    /// <summary>
    ///
    /// </summary>
    public interface IEscapePodClient
    {
        //TODO update all the comments with the proper exception when the api is done with all error handling exceptions

        #region Methods

        /// <summary>
        /// Gets the archive.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <exception cref="SpectraLogic.EscapePodClient.Exceptions.ArchiveNotFoundException" />
        /// <exception cref="SpectraLogic.EscapePodClient.Exceptions.InvalidEscapePodServerCredentialsException" />
        /// <exception cref="SpectraLogic.EscapePodClient.Exceptions.ErrorResponseException" />
        /// <returns></returns>
        IEscapePodArchive GetArchive(GetArchiveRequest request);

        /// <summary>
        /// Gets the job.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodJob GetJob(GetEscapePodJobRequest request);

        /// <summary>
        /// Deletes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodJob Delete(DeleteRequest request);

        /// <summary>
        /// Restores the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodJob Restore(RestoreRequest request);

        /// <summary>
        /// Archives the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodJob Archive(ArchiveRequest request);

        /// <summary>
        /// Cancels the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodJob Cancel(CancelRequest request);

        /// <summary>
        /// Creates the archive.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodArchive CreateArchive(CreateArchiveRequest request);

        /// <summary>
        /// Creates the device.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodDevice CreateDevice(CreateDeviceRequest request);

        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodDevice GetDevice(GetDeviceRequest request);

        /// <summary>
        /// Creates the cluster.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodCluster CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Gets the cluster.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        IEscapePodCluster GetCluster(GetClusterRequest request);

        /// <summary>
        /// Determines whether [is device exist] [the specified device name].
        /// </summary>
        /// <param name="deviceName">Name of the device.</param>
        /// <returns>
        ///   <c>true</c> if [is device exist] [the specified device name]; otherwise, <c>false</c>.
        /// </returns>
        bool IsDeviceExist(string deviceName);

        /// <summary>
        /// Determines whether [is archive exist] [the specified archive name].
        /// </summary>
        /// <param name="archiveName">Name of the archive.</param>
        /// <returns>
        ///   <c>true</c> if [is archive exist] [the specified archive name]; otherwise, <c>false</c>.
        /// </returns>
        bool IsArchiveExist(string archiveName);

        /// <summary>
        /// Deletes the cluster.
        /// </summary>
        void DeleteCluster();

        #endregion Methods
    }
}