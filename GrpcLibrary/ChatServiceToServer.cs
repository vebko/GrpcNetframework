// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatServiceToServer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcLibrary {

  /// <summary>Holder for reflection information generated from ChatServiceToServer.proto</summary>
  public static partial class ChatServiceToServerReflection {

    #region Descriptor
    /// <summary>File descriptor for ChatServiceToServer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatServiceToServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGF0U2VydmljZVRvU2VydmVyLnByb3RvEgtHcnBjTGlicmFyeSIHCgVF",
            "bXB0eSIcCgxIZWxsb1JlcXVlc3QSDAoEbmFtZRgBIAEoCSIdCgpIZWxsb1Jl",
            "cGx5Eg8KB21lc3NhZ2UYASABKAkiVwoNUmVxdWVzdFN0cmluZxIQCghzb3Vy",
            "Y2VJZBgBIAEoCRIWCg5kZXN0aW5hdGlvbklEcxgCIAMoCRIMCgRycXN0GAMg",
            "ASgJEg4KBm9wdGlvbhgEIAEoCSJUCgtTZW5kTWVzc2FnZRIQCghzb3VyY2VJ",
            "RBgBIAEoCRIWCg5kZXN0aW5hdGlvbklEcxgCIAMoCRILCgNtc2cYAyABKAkS",
            "DgoGb3B0aW9uGAQgASgJImIKC1JlcXVlc3RCeXRlEhAKCHNvdXJjZUlEGAEg",
            "ASgJEhYKDmRlc3RpbmF0aW9uSURzGAIgAygJEgsKA21zZxgDIAEoCRIMCgRy",
            "cXN0GAQgASgMEg4KBm9wdGlvbhgFIAEoCTK2AgoLR3JwY0xpYnJhcnkSTwoV",
            "UmVxdWVzdFN0cmluZ0Z1bmN0aW9uEhouR3JwY0xpYnJhcnkuUmVxdWVzdFN0",
            "cmluZxoaLkdycGNMaWJyYXJ5LlJlcXVlc3RTdHJpbmcSSQoTU2VuZE1lc3Nh",
            "Z2VGdW5jdGlvbhIYLkdycGNMaWJyYXJ5LlNlbmRNZXNzYWdlGhguR3JwY0xp",
            "YnJhcnkuU2VuZE1lc3NhZ2USSQoTUmVxdWVzdEJ5dGVGdW5jdGlvbhIYLkdy",
            "cGNMaWJyYXJ5LlJlcXVlc3RCeXRlGhguR3JwY0xpYnJhcnkuUmVxdWVzdEJ5",
            "dGUSQAoIU2F5SGVsbG8SGS5HcnBjTGlicmFyeS5IZWxsb1JlcXVlc3QaFy5H",
            "cnBjTGlicmFyeS5IZWxsb1JlcGx5IgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.Empty), global::GrpcLibrary.Empty.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.HelloRequest), global::GrpcLibrary.HelloRequest.Parser, new[]{ "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.HelloReply), global::GrpcLibrary.HelloReply.Parser, new[]{ "Message" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.RequestString), global::GrpcLibrary.RequestString.Parser, new[]{ "SourceId", "DestinationIDs", "Rqst", "Option" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.SendMessage), global::GrpcLibrary.SendMessage.Parser, new[]{ "SourceID", "DestinationIDs", "Msg", "Option" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.RequestByte), global::GrpcLibrary.RequestByte.Parser, new[]{ "SourceID", "DestinationIDs", "Msg", "Rqst", "Option" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty(Empty other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty Clone() {
      return new Empty(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class HelloRequest : pb::IMessage<HelloRequest> {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest(HelloRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest Clone() {
      return new HelloRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class HelloReply : pb::IMessage<HelloReply> {
    private static readonly pb::MessageParser<HelloReply> _parser = new pb::MessageParser<HelloReply>(() => new HelloReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply(HelloReply other) : this() {
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply Clone() {
      return new HelloReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RequestString : pb::IMessage<RequestString> {
    private static readonly pb::MessageParser<RequestString> _parser = new pb::MessageParser<RequestString>(() => new RequestString());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestString> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestString() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestString(RequestString other) : this() {
      sourceId_ = other.sourceId_;
      destinationIDs_ = other.destinationIDs_.Clone();
      rqst_ = other.rqst_;
      option_ = other.option_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestString Clone() {
      return new RequestString(this);
    }

    /// <summary>Field number for the "sourceId" field.</summary>
    public const int SourceIdFieldNumber = 1;
    private string sourceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceId {
      get { return sourceId_; }
      set {
        sourceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destinationIDs" field.</summary>
    public const int DestinationIDsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_destinationIDs_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> destinationIDs_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DestinationIDs {
      get { return destinationIDs_; }
    }

    /// <summary>Field number for the "rqst" field.</summary>
    public const int RqstFieldNumber = 3;
    private string rqst_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Rqst {
      get { return rqst_; }
      set {
        rqst_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "option" field.</summary>
    public const int OptionFieldNumber = 4;
    private string option_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Option {
      get { return option_; }
      set {
        option_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestString);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestString other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceId != other.SourceId) return false;
      if(!destinationIDs_.Equals(other.destinationIDs_)) return false;
      if (Rqst != other.Rqst) return false;
      if (Option != other.Option) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceId.Length != 0) hash ^= SourceId.GetHashCode();
      hash ^= destinationIDs_.GetHashCode();
      if (Rqst.Length != 0) hash ^= Rqst.GetHashCode();
      if (Option.Length != 0) hash ^= Option.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceId);
      }
      destinationIDs_.WriteTo(output, _repeated_destinationIDs_codec);
      if (Rqst.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Rqst);
      }
      if (Option.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Option);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceId);
      }
      size += destinationIDs_.CalculateSize(_repeated_destinationIDs_codec);
      if (Rqst.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rqst);
      }
      if (Option.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Option);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestString other) {
      if (other == null) {
        return;
      }
      if (other.SourceId.Length != 0) {
        SourceId = other.SourceId;
      }
      destinationIDs_.Add(other.destinationIDs_);
      if (other.Rqst.Length != 0) {
        Rqst = other.Rqst;
      }
      if (other.Option.Length != 0) {
        Option = other.Option;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SourceId = input.ReadString();
            break;
          }
          case 18: {
            destinationIDs_.AddEntriesFrom(input, _repeated_destinationIDs_codec);
            break;
          }
          case 26: {
            Rqst = input.ReadString();
            break;
          }
          case 34: {
            Option = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SendMessage : pb::IMessage<SendMessage> {
    private static readonly pb::MessageParser<SendMessage> _parser = new pb::MessageParser<SendMessage>(() => new SendMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessage(SendMessage other) : this() {
      sourceID_ = other.sourceID_;
      destinationIDs_ = other.destinationIDs_.Clone();
      msg_ = other.msg_;
      option_ = other.option_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessage Clone() {
      return new SendMessage(this);
    }

    /// <summary>Field number for the "sourceID" field.</summary>
    public const int SourceIDFieldNumber = 1;
    private string sourceID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceID {
      get { return sourceID_; }
      set {
        sourceID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destinationIDs" field.</summary>
    public const int DestinationIDsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_destinationIDs_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> destinationIDs_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DestinationIDs {
      get { return destinationIDs_; }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "option" field.</summary>
    public const int OptionFieldNumber = 4;
    private string option_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Option {
      get { return option_; }
      set {
        option_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceID != other.SourceID) return false;
      if(!destinationIDs_.Equals(other.destinationIDs_)) return false;
      if (Msg != other.Msg) return false;
      if (Option != other.Option) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceID.Length != 0) hash ^= SourceID.GetHashCode();
      hash ^= destinationIDs_.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (Option.Length != 0) hash ^= Option.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceID);
      }
      destinationIDs_.WriteTo(output, _repeated_destinationIDs_codec);
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (Option.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Option);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceID);
      }
      size += destinationIDs_.CalculateSize(_repeated_destinationIDs_codec);
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (Option.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Option);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendMessage other) {
      if (other == null) {
        return;
      }
      if (other.SourceID.Length != 0) {
        SourceID = other.SourceID;
      }
      destinationIDs_.Add(other.destinationIDs_);
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      if (other.Option.Length != 0) {
        Option = other.Option;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SourceID = input.ReadString();
            break;
          }
          case 18: {
            destinationIDs_.AddEntriesFrom(input, _repeated_destinationIDs_codec);
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
          case 34: {
            Option = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RequestByte : pb::IMessage<RequestByte> {
    private static readonly pb::MessageParser<RequestByte> _parser = new pb::MessageParser<RequestByte>(() => new RequestByte());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestByte> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.ChatServiceToServerReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestByte() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestByte(RequestByte other) : this() {
      sourceID_ = other.sourceID_;
      destinationIDs_ = other.destinationIDs_.Clone();
      msg_ = other.msg_;
      rqst_ = other.rqst_;
      option_ = other.option_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestByte Clone() {
      return new RequestByte(this);
    }

    /// <summary>Field number for the "sourceID" field.</summary>
    public const int SourceIDFieldNumber = 1;
    private string sourceID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceID {
      get { return sourceID_; }
      set {
        sourceID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destinationIDs" field.</summary>
    public const int DestinationIDsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_destinationIDs_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> destinationIDs_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DestinationIDs {
      get { return destinationIDs_; }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rqst" field.</summary>
    public const int RqstFieldNumber = 4;
    private pb::ByteString rqst_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Rqst {
      get { return rqst_; }
      set {
        rqst_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "option" field.</summary>
    public const int OptionFieldNumber = 5;
    private string option_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Option {
      get { return option_; }
      set {
        option_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestByte);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestByte other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceID != other.SourceID) return false;
      if(!destinationIDs_.Equals(other.destinationIDs_)) return false;
      if (Msg != other.Msg) return false;
      if (Rqst != other.Rqst) return false;
      if (Option != other.Option) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceID.Length != 0) hash ^= SourceID.GetHashCode();
      hash ^= destinationIDs_.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (Rqst.Length != 0) hash ^= Rqst.GetHashCode();
      if (Option.Length != 0) hash ^= Option.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceID);
      }
      destinationIDs_.WriteTo(output, _repeated_destinationIDs_codec);
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (Rqst.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Rqst);
      }
      if (Option.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Option);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceID);
      }
      size += destinationIDs_.CalculateSize(_repeated_destinationIDs_codec);
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (Rqst.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Rqst);
      }
      if (Option.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Option);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestByte other) {
      if (other == null) {
        return;
      }
      if (other.SourceID.Length != 0) {
        SourceID = other.SourceID;
      }
      destinationIDs_.Add(other.destinationIDs_);
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      if (other.Rqst.Length != 0) {
        Rqst = other.Rqst;
      }
      if (other.Option.Length != 0) {
        Option = other.Option;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SourceID = input.ReadString();
            break;
          }
          case 18: {
            destinationIDs_.AddEntriesFrom(input, _repeated_destinationIDs_codec);
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
          case 34: {
            Rqst = input.ReadBytes();
            break;
          }
          case 42: {
            Option = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
