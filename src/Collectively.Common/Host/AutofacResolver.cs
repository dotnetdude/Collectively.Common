﻿using Autofac;

namespace Collectively.Common.Host
{
    public class AutofacResolver : IResolver
    {
        private readonly ILifetimeScope _scope;

        public AutofacResolver(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public T Resolve<T>() => _scope.Resolve<T>();
    }
}