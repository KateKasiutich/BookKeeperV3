using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper
{
    public static class IoC
    {
        private static readonly IDictionary<Type, Type> Registered = new Dictionary<Type, Type>();

        public static void Register<TType, TConcrete>() where TConcrete : class, TType
        {
            Registered[typeof(TType)] = typeof(TConcrete);
        }

        public static TTypeToResolve Resolve<TTypeToResolve>()
        {
            return (TTypeToResolve)Resolve(typeof(TTypeToResolve));
        }

        public static object Resolve(Type type)
        {
            return GetInstance(Registered[type]);
        }

        private static object GetInstance(Type type)
        {
            var parameters = ResolveConstructorParameters(type);
            return Activator.CreateInstance(type, parameters.ToArray());
        }

        private static IEnumerable<object> ResolveConstructorParameters(Type type)
        {
            var constructorInfo = type.GetConstructors().First();
            return constructorInfo.GetParameters().Select(parameter => Resolve(parameter.ParameterType));
        }
    }
}