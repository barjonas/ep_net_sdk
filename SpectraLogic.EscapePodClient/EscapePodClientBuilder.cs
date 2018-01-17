﻿using System;
using log4net;
using SpectraLogic.EscapePodClient.Runtime;

namespace SpectraLogic.EscapePodClient
{
    public class EscapePodClientBuilder : IEscapePodClientBuilder
    {
        private static readonly ILog Log = LogManager.GetLogger("EscapePodClientBuilder");

        private readonly string _serverName;
        private readonly int _serverPort;
        private readonly string _username;
        private readonly string _password;
        private Uri _proxy;

        public EscapePodClientBuilder(string serverName, int serverPort, string username, string password)
        {
            _serverName = serverName;
            _serverPort = serverPort;
            _username = username;
            _password = password;
        }

        public EscapePodClientBuilder WithProxy(string proxy)
        {
            _proxy = new Uri(proxy);
            return this;
        }

        public EscapePodClientBuilder WithProxy(Uri proxy)
        {
            _proxy = proxy;
            return this;
        }

        public IEscapePodClient Build()
        {
            var network = new Network(_serverName, _serverPort, _username, _password, _proxy);
            return new EscapePodClient(network);
        }
    }
}