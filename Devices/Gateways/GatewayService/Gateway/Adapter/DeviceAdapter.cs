﻿namespace Microsoft.ConnectTheDots.Gateway
{
    using System;
    using Microsoft.ConnectTheDots.Common;

    //--//

    public delegate void DataArrivalEventHandler( string data );

    public abstract class DeviceAdapterAbstract : IDeviceAdapter
    {
        protected ILogger _logger;

        //--//

        protected DeviceAdapterAbstract( ILogger logger )
        {
            _logger = SafeLogger.FromLogger( logger );
        }

        public abstract bool Start( Func<string, int> enqueue );

        public abstract bool Stop( );

        public abstract bool SetEndpoint( SensorEndpoint endpoint = null );
    }
}