// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/divisores.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DivisorsOfNumbers.GrpcService {
  public static partial class Divisores
  {
    static readonly string __ServiceName = "divisores.Divisores";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::DivisorsOfNumbers.GrpcService.Number> __Marshaller_divisores_Number = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DivisorsOfNumbers.GrpcService.Number.Parser));
    static readonly grpc::Marshaller<global::DivisorsOfNumbers.GrpcService.Retorno> __Marshaller_divisores_Retorno = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DivisorsOfNumbers.GrpcService.Retorno.Parser));

    static readonly grpc::Method<global::DivisorsOfNumbers.GrpcService.Number, global::DivisorsOfNumbers.GrpcService.Retorno> __Method_ObtenhaDivisores = new grpc::Method<global::DivisorsOfNumbers.GrpcService.Number, global::DivisorsOfNumbers.GrpcService.Retorno>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ObtenhaDivisores",
        __Marshaller_divisores_Number,
        __Marshaller_divisores_Retorno);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DivisorsOfNumbers.GrpcService.DivisoresReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Divisores</summary>
    [grpc::BindServiceMethod(typeof(Divisores), "BindService")]
    public abstract partial class DivisoresBase
    {
      public virtual global::System.Threading.Tasks.Task<global::DivisorsOfNumbers.GrpcService.Retorno> ObtenhaDivisores(global::DivisorsOfNumbers.GrpcService.Number request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DivisoresBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ObtenhaDivisores, serviceImpl.ObtenhaDivisores).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DivisoresBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ObtenhaDivisores, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DivisorsOfNumbers.GrpcService.Number, global::DivisorsOfNumbers.GrpcService.Retorno>(serviceImpl.ObtenhaDivisores));
    }

  }
}
#endregion
