using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using Should;

namespace NGeo
{
    public static class ExtensionMethods
    {
        public static TAttribute[] GetAttributes<TTarget, TType, TAttribute>(this Expression<Func<TTarget, TType>> expression,
            bool inherit = false)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression != null)
                return memberExpression.Member.GetCustomAttributes(typeof(TAttribute), inherit) as TAttribute[];

            var methodCallExpression = expression.Body as MethodCallExpression;
            if (methodCallExpression != null)
                return methodCallExpression.Method.GetCustomAttributes(typeof(TAttribute), inherit) as TAttribute[];

            throw new NotImplementedException("GetAttributes expression body was unexpected.");
        }

        [DebuggerStepThrough]
        public static void ShouldHaveDataMemberAttributes<TClass, TType>(
            this Dictionary<string, Expression<Func<TClass, TType>>> properties)
        {
            foreach (var property in properties)
            {
                var attributes = property.Value.GetAttributes<TClass, TType, DataMemberAttribute>();
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldBeType<DataMemberAttribute>();
                attributes[0].Name.ShouldEqual(property.Key);
            }
        }

        //[DebuggerStepThrough]
        public static void ShouldHaveOperationContractAttributes<TClass, TType>(
            this Dictionary<string, Expression<Func<TClass, TType>>> methods)
        {
            foreach (var method in methods)
            {
                var memberExpression = (MethodCallExpression)method.Value.Body;
                var attributes = memberExpression.Method.GetCustomAttributes(typeof(OperationContractAttribute), false);
                attributes.ShouldNotBeNull();
                attributes.Length.ShouldEqual(1);
                attributes[0].ShouldBeType<OperationContractAttribute>();
                var operationContract = (OperationContractAttribute)attributes[0];
                operationContract.Name.ShouldEqual(method.Key);
            }
        }

        [DebuggerStepThrough]
        public static void ShouldHaveEnumMemberAttribute(this Enum value, string enumAttributeValue)
        {
            var attribute = value.GetEnumMemberAttribute();
            attribute.ShouldNotBeNull();
            Debug.Assert(attribute != null);
            attribute.Value.ShouldEqual(enumAttributeValue);
        }

    }
}
