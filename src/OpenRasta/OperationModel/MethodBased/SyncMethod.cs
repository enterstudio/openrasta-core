﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenRasta.Binding;
using OpenRasta.Collections;
using OpenRasta.TypeSystem;

namespace OpenRasta.OperationModel.MethodBased
{
#pragma warning disable 618
  public class SyncMethod : AbstractMethodOperation, IOperation
#pragma warning restore 618
  {
    public IDictionary ExtendedProperties { get; } = new NullBehaviorDictionary<object, object>();

    public SyncMethod(IMethod method, IObjectBinderLocator binderLocator = null)
      : base(method, binderLocator)
    {
    }

    public IEnumerable<OutputMember> Invoke()
    {
      var instance = CreateInstance(OwnerType, Resolver);
      var parameters = GetParameters();
      return new[]
      {
        new OutputMember
        {
          Member = Method.OutputMembers.Single(),
          Value = Method.Invoke(instance, parameters).First()
        }
      };
    }
  }
}