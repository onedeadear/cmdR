﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmdR.Abstract
{
    public interface IRouteCommands
    {
        void RegisterRoute(string commandName, IDictionary<string, ParameterType> parameters, Action<IDictionary<string, string>> action);
        void RegisterRoute(Route route);

        List<Route> GetRoutes();
        Route FindRoute(string commandName, IDictionary<string, string> parameters);
    }
}
