// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/InventoryService.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ITI.GRPC.Server.Protos {
  public static partial class InventoryService
  {
    static readonly string __ServiceName = "InventoryService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.GetProductByIdRequest> __Marshaller_GetProductByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.GetProductByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.GetProductByIdResponse> __Marshaller_GetProductByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.GetProductByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.AddNewProductRequest> __Marshaller_AddNewProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.AddNewProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.AddNewProductResponse> __Marshaller_AddNewProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.AddNewProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.UpdateProductRequest> __Marshaller_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ITI.GRPC.Server.Protos.UpdateProductResponse> __Marshaller_UpdateProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ITI.GRPC.Server.Protos.UpdateProductResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ITI.GRPC.Server.Protos.GetProductByIdRequest, global::ITI.GRPC.Server.Protos.GetProductByIdResponse> __Method_GetProductById = new grpc::Method<global::ITI.GRPC.Server.Protos.GetProductByIdRequest, global::ITI.GRPC.Server.Protos.GetProductByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_GetProductByIdRequest,
        __Marshaller_GetProductByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ITI.GRPC.Server.Protos.AddNewProductRequest, global::ITI.GRPC.Server.Protos.AddNewProductResponse> __Method_AddNewProduct = new grpc::Method<global::ITI.GRPC.Server.Protos.AddNewProductRequest, global::ITI.GRPC.Server.Protos.AddNewProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddNewProduct",
        __Marshaller_AddNewProductRequest,
        __Marshaller_AddNewProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ITI.GRPC.Server.Protos.UpdateProductRequest, global::ITI.GRPC.Server.Protos.UpdateProductResponse> __Method_UpdateProduct = new grpc::Method<global::ITI.GRPC.Server.Protos.UpdateProductRequest, global::ITI.GRPC.Server.Protos.UpdateProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_UpdateProductRequest,
        __Marshaller_UpdateProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ITI.GRPC.Server.Protos.InventoryServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of InventoryService</summary>
    [grpc::BindServiceMethod(typeof(InventoryService), "BindService")]
    public abstract partial class InventoryServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ITI.GRPC.Server.Protos.GetProductByIdResponse> GetProductById(global::ITI.GRPC.Server.Protos.GetProductByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ITI.GRPC.Server.Protos.AddNewProductResponse> AddNewProduct(global::ITI.GRPC.Server.Protos.AddNewProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ITI.GRPC.Server.Protos.UpdateProductResponse> UpdateProduct(global::ITI.GRPC.Server.Protos.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(InventoryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById)
          .AddMethod(__Method_AddNewProduct, serviceImpl.AddNewProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, InventoryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ITI.GRPC.Server.Protos.GetProductByIdRequest, global::ITI.GRPC.Server.Protos.GetProductByIdResponse>(serviceImpl.GetProductById));
      serviceBinder.AddMethod(__Method_AddNewProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ITI.GRPC.Server.Protos.AddNewProductRequest, global::ITI.GRPC.Server.Protos.AddNewProductResponse>(serviceImpl.AddNewProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ITI.GRPC.Server.Protos.UpdateProductRequest, global::ITI.GRPC.Server.Protos.UpdateProductResponse>(serviceImpl.UpdateProduct));
    }

  }
}
#endregion