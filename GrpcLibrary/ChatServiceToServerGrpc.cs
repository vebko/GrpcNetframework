// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatServiceToServer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcLibrary {
  public static partial class GrpcLibrary
  {
    static readonly string __ServiceName = "GrpcLibrary.GrpcLibrary";

    static readonly grpc::Marshaller<global::GrpcLibrary.RequestString> __Marshaller_GrpcLibrary_RequestString = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcLibrary.RequestString.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcLibrary.SendMessage> __Marshaller_GrpcLibrary_SendMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcLibrary.SendMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcLibrary.RequestByte> __Marshaller_GrpcLibrary_RequestByte = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcLibrary.RequestByte.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcLibrary.HelloRequest> __Marshaller_GrpcLibrary_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcLibrary.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcLibrary.HelloReply> __Marshaller_GrpcLibrary_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcLibrary.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcLibrary.RequestString, global::GrpcLibrary.RequestString> __Method_RequestStringFunction = new grpc::Method<global::GrpcLibrary.RequestString, global::GrpcLibrary.RequestString>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestStringFunction",
        __Marshaller_GrpcLibrary_RequestString,
        __Marshaller_GrpcLibrary_RequestString);

    static readonly grpc::Method<global::GrpcLibrary.SendMessage, global::GrpcLibrary.SendMessage> __Method_SendMessageFunction = new grpc::Method<global::GrpcLibrary.SendMessage, global::GrpcLibrary.SendMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendMessageFunction",
        __Marshaller_GrpcLibrary_SendMessage,
        __Marshaller_GrpcLibrary_SendMessage);

    static readonly grpc::Method<global::GrpcLibrary.RequestByte, global::GrpcLibrary.RequestByte> __Method_RequestByteFunction = new grpc::Method<global::GrpcLibrary.RequestByte, global::GrpcLibrary.RequestByte>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestByteFunction",
        __Marshaller_GrpcLibrary_RequestByte,
        __Marshaller_GrpcLibrary_RequestByte);

    static readonly grpc::Method<global::GrpcLibrary.HelloRequest, global::GrpcLibrary.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcLibrary.HelloRequest, global::GrpcLibrary.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_GrpcLibrary_HelloRequest,
        __Marshaller_GrpcLibrary_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcLibrary</summary>
    [grpc::BindServiceMethod(typeof(GrpcLibrary), "BindService")]
    public abstract partial class GrpcLibraryBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcLibrary.RequestString> RequestStringFunction(global::GrpcLibrary.RequestString request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcLibrary.SendMessage> SendMessageFunction(global::GrpcLibrary.SendMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcLibrary.RequestByte> RequestByteFunction(global::GrpcLibrary.RequestByte request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcLibrary.HelloReply> SayHello(global::GrpcLibrary.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GrpcLibrary</summary>
    public partial class GrpcLibraryClient : grpc::ClientBase<GrpcLibraryClient>
    {
      /// <summary>Creates a new client for GrpcLibrary</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GrpcLibraryClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GrpcLibrary that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GrpcLibraryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GrpcLibraryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GrpcLibraryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcLibrary.RequestString RequestStringFunction(global::GrpcLibrary.RequestString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestStringFunction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcLibrary.RequestString RequestStringFunction(global::GrpcLibrary.RequestString request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestStringFunction, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.RequestString> RequestStringFunctionAsync(global::GrpcLibrary.RequestString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestStringFunctionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.RequestString> RequestStringFunctionAsync(global::GrpcLibrary.RequestString request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestStringFunction, null, options, request);
      }
      public virtual global::GrpcLibrary.SendMessage SendMessageFunction(global::GrpcLibrary.SendMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessageFunction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcLibrary.SendMessage SendMessageFunction(global::GrpcLibrary.SendMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendMessageFunction, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.SendMessage> SendMessageFunctionAsync(global::GrpcLibrary.SendMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendMessageFunctionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.SendMessage> SendMessageFunctionAsync(global::GrpcLibrary.SendMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendMessageFunction, null, options, request);
      }
      public virtual global::GrpcLibrary.RequestByte RequestByteFunction(global::GrpcLibrary.RequestByte request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestByteFunction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcLibrary.RequestByte RequestByteFunction(global::GrpcLibrary.RequestByte request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestByteFunction, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.RequestByte> RequestByteFunctionAsync(global::GrpcLibrary.RequestByte request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestByteFunctionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.RequestByte> RequestByteFunctionAsync(global::GrpcLibrary.RequestByte request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestByteFunction, null, options, request);
      }
      public virtual global::GrpcLibrary.HelloReply SayHello(global::GrpcLibrary.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcLibrary.HelloReply SayHello(global::GrpcLibrary.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.HelloReply> SayHelloAsync(global::GrpcLibrary.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcLibrary.HelloReply> SayHelloAsync(global::GrpcLibrary.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GrpcLibraryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GrpcLibraryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcLibraryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RequestStringFunction, serviceImpl.RequestStringFunction)
          .AddMethod(__Method_SendMessageFunction, serviceImpl.SendMessageFunction)
          .AddMethod(__Method_RequestByteFunction, serviceImpl.RequestByteFunction)
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcLibraryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RequestStringFunction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcLibrary.RequestString, global::GrpcLibrary.RequestString>(serviceImpl.RequestStringFunction));
      serviceBinder.AddMethod(__Method_SendMessageFunction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcLibrary.SendMessage, global::GrpcLibrary.SendMessage>(serviceImpl.SendMessageFunction));
      serviceBinder.AddMethod(__Method_RequestByteFunction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcLibrary.RequestByte, global::GrpcLibrary.RequestByte>(serviceImpl.RequestByteFunction));
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcLibrary.HelloRequest, global::GrpcLibrary.HelloReply>(serviceImpl.SayHello));
    }

  }
}
#endregion
