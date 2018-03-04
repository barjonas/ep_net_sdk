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
using SpectraLogic.SpectraStorageBrokerClient.Calls;
using SpectraLogic.SpectraStorageBrokerClient.Model;
using SpectraLogic.SpectraStorageBrokerClient.ResponseParsers;
using SpectraLogic.SpectraStorageBrokerClient.Runtime;
using SpectraLogic.SpectraStorageBrokerClient.Utils;

namespace SpectraLogic.SpectraStorageBrokerClient
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="SpectraLogic.SpectraStorageBrokerClient.ISpectraStorageBrokerClient" />
    public class SpectraStorageBrokerClient : ISpectraStorageBrokerClient
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger("SpectraStorageBrokerClient");
        private readonly INetwork _network;

        #endregion Private Fields

        #region Internal Constructors

        internal SpectraStorageBrokerClient(INetwork network)
        {
            _network = network;
        }

        #endregion Internal Constructors

        #region Public Methods

        /// <inheritdoc/>
        public IJob Archive(ArchiveRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new ArchiveResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IJob Cancel(CancelRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new CancelResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IBroker CreateBroker(CreateBrokerRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new CreateBrokerResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public ICluster CreateCluster(CreateClusterRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new CreateClusterResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IDevice CreateDevice(CreateDeviceRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new CreateDeviceResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public void DeleteCluster()
        {
            ExceptionDecorator.Run(() =>
            {
                var request = new DeleteClusterRequest();
                return new DeleteClusterResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IJob DeleteFiles(DeleteFilesRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new DeleteFilesResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public bool DoesBrokerExist(string brokerName)
        {
            return ExceptionDecorator.Run(() =>
            {
                var request = new HeadBrokerRequest(brokerName);
                return new HeadResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public bool DoesDeviceExist(string deviceName)
        {
            return ExceptionDecorator.Run(() =>
            {
                var request = new HeadDeviceRequest(deviceName);
                return new HeadResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IBroker GetBroker(GetBrokerRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new GetBrokerResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public ICluster GetCluster(GetClusterRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new GetClusterResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IDevice GetDevice(GetDeviceRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new GetDeviceResponseParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IJob GetJob(GetJobRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new GetJobParser().Parse(_network.Invoke(request));
            });
        }

        /// <inheritdoc/>
        public IJob Restore(RestoreRequest request)
        {
            return ExceptionDecorator.Run(() =>
            {
                return new RestoreResponseParser().Parse(_network.Invoke(request));
            });
        }

        #endregion Public Methods
    }
}