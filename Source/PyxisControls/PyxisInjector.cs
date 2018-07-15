using System;
using System.Collections.Generic;

namespace PyxisControls
{
    public class PyxisInjector
    {
        private static PyxisInjector _instance;

        private readonly Dictionary<Type, object> _container;
        public static PyxisInjector Instance => _instance ?? (_instance = new PyxisInjector());

        private PyxisInjector()
        {
            _container = new Dictionary<Type, object>();
        }

        public void Register<T>(T instance) where T : class
        {
            _container.Add(typeof(T), instance);
        }

        public T Inject<T>() where T : class
        {
            return _container[typeof(T)] as T;
        }
    }
}