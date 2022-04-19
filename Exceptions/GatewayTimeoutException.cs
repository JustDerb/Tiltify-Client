﻿using System;

namespace Tiltify.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a 504 Http Statuscode</summary>
    public class GatewayTimeoutException : Exception
    {
        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public GatewayTimeoutException(string data)
            : base(data)
        {
        }
    }
}