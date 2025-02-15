// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Io.Cloudevents.V1 {

  /// <summary>Holder for reflection information generated from spec.proto</summary>
  public static partial class SpecReflection {

    #region Descriptor
    /// <summary>File descriptor for spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpzcGVjLnByb3RvEhFpby5jbG91ZGV2ZW50cy52MRoZZ29vZ2xlL3Byb3Rv",
            "YnVmL2FueS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byKwBAoKQ2xvdWRFdmVudBIKCgJpZBgBIAEoCRIOCgZzb3VyY2UYAiABKAkS",
            "FAoMc3BlY192ZXJzaW9uGAMgASgJEgwKBHR5cGUYBCABKAkSQQoKYXR0cmli",
            "dXRlcxgFIAMoCzItLmlvLmNsb3VkZXZlbnRzLnYxLkNsb3VkRXZlbnQuQXR0",
            "cmlidXRlc0VudHJ5EhUKC2JpbmFyeV9kYXRhGAYgASgMSAASEwoJdGV4dF9k",
            "YXRhGAcgASgJSAASKgoKcHJvdG9fZGF0YRgIIAEoCzIULmdvb2dsZS5wcm90",
            "b2J1Zi5BbnlIABppCg9BdHRyaWJ1dGVzRW50cnkSCwoDa2V5GAEgASgJEkUK",
            "BXZhbHVlGAIgASgLMjYuaW8uY2xvdWRldmVudHMudjEuQ2xvdWRFdmVudC5D",
            "bG91ZEV2ZW50QXR0cmlidXRlVmFsdWU6AjgBGtMBChhDbG91ZEV2ZW50QXR0",
            "cmlidXRlVmFsdWUSFAoKY2VfYm9vbGVhbhgBIAEoCEgAEhQKCmNlX2ludGVn",
            "ZXIYAiABKAVIABITCgljZV9zdHJpbmcYAyABKAlIABISCghjZV9ieXRlcxgE",
            "IAEoDEgAEhAKBmNlX3VyaRgFIAEoCUgAEhQKCmNlX3VyaV9yZWYYBiABKAlI",
            "ABIyCgxjZV90aW1lc3RhbXAYByABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
            "ZXN0YW1wSABCBgoEYXR0ckIGCgRkYXRhQm4KF2lvLmNsb3VkZXZlbnRzLnYx",
            "LnByb3RvUAFaGmNsb3VkZXZlbnRzLmlvL2dlbnByb3RvL3YxygIXSW9cQ2xv",
            "dWRFdmVudHNcVjFcUHJvdG/qAhpJbzo6Q2xvdWRFdmVudHM6OlYxOjpQcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Io.Cloudevents.V1.CloudEvent), global::Io.Cloudevents.V1.CloudEvent.Parser, new[]{ "Id", "Source", "SpecVersion", "Type", "Attributes", "BinaryData", "TextData", "ProtoData" }, new[]{ "Data" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, new pbr::GeneratedClrTypeInfo(typeof(global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue), global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue.Parser, new[]{ "CeBoolean", "CeInteger", "CeString", "CeBytes", "CeUri", "CeUriRef", "CeTimestamp" }, new[]{ "Attr" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CloudEvent : pb::IMessage<CloudEvent> {
    private static readonly pb::MessageParser<CloudEvent> _parser = new pb::MessageParser<CloudEvent>(() => new CloudEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CloudEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Io.Cloudevents.V1.SpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent(CloudEvent other) : this() {
      id_ = other.id_;
      source_ = other.source_;
      specVersion_ = other.specVersion_;
      type_ = other.type_;
      attributes_ = other.attributes_.Clone();
      switch (other.DataCase) {
        case DataOneofCase.BinaryData:
          BinaryData = other.BinaryData;
          break;
        case DataOneofCase.TextData:
          TextData = other.TextData;
          break;
        case DataOneofCase.ProtoData:
          ProtoData = other.ProtoData.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CloudEvent Clone() {
      return new CloudEvent(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Required Attributes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 2;
    private string source_ = "";
    /// <summary>
    /// URI-reference
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "spec_version" field.</summary>
    public const int SpecVersionFieldNumber = 3;
    private string specVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpecVersion {
      get { return specVersion_; }
      set {
        specVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 5;
    private static readonly pbc::MapField<string, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue>.Codec _map_attributes_codec
        = new pbc::MapField<string, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue.Parser), 42);
    private readonly pbc::MapField<string, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue> attributes_ = new pbc::MapField<string, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue>();
    /// <summary>
    /// Optional &amp; Extension Attributes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Io.Cloudevents.V1.CloudEvent.Types.CloudEventAttributeValue> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "binary_data" field.</summary>
    public const int BinaryDataFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString BinaryData {
      get { return dataCase_ == DataOneofCase.BinaryData ? (pb::ByteString) data_ : pb::ByteString.Empty; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.BinaryData;
      }
    }

    /// <summary>Field number for the "text_data" field.</summary>
    public const int TextDataFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TextData {
      get { return dataCase_ == DataOneofCase.TextData ? (string) data_ : ""; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.TextData;
      }
    }

    /// <summary>Field number for the "proto_data" field.</summary>
    public const int ProtoDataFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any ProtoData {
      get { return dataCase_ == DataOneofCase.ProtoData ? (global::Google.Protobuf.WellKnownTypes.Any) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.ProtoData;
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      BinaryData = 6,
      TextData = 7,
      ProtoData = 8,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CloudEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CloudEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Source != other.Source) return false;
      if (SpecVersion != other.SpecVersion) return false;
      if (Type != other.Type) return false;
      if (!Attributes.Equals(other.Attributes)) return false;
      if (BinaryData != other.BinaryData) return false;
      if (TextData != other.TextData) return false;
      if (!object.Equals(ProtoData, other.ProtoData)) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (SpecVersion.Length != 0) hash ^= SpecVersion.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= Attributes.GetHashCode();
      if (dataCase_ == DataOneofCase.BinaryData) hash ^= BinaryData.GetHashCode();
      if (dataCase_ == DataOneofCase.TextData) hash ^= TextData.GetHashCode();
      if (dataCase_ == DataOneofCase.ProtoData) hash ^= ProtoData.GetHashCode();
      hash ^= (int) dataCase_;
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Source);
      }
      if (SpecVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SpecVersion);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Type);
      }
      attributes_.WriteTo(output, _map_attributes_codec);
      if (dataCase_ == DataOneofCase.BinaryData) {
        output.WriteRawTag(50);
        output.WriteBytes(BinaryData);
      }
      if (dataCase_ == DataOneofCase.TextData) {
        output.WriteRawTag(58);
        output.WriteString(TextData);
      }
      if (dataCase_ == DataOneofCase.ProtoData) {
        output.WriteRawTag(66);
        output.WriteMessage(ProtoData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (SpecVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpecVersion);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += attributes_.CalculateSize(_map_attributes_codec);
      if (dataCase_ == DataOneofCase.BinaryData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(BinaryData);
      }
      if (dataCase_ == DataOneofCase.TextData) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TextData);
      }
      if (dataCase_ == DataOneofCase.ProtoData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProtoData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CloudEvent other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.SpecVersion.Length != 0) {
        SpecVersion = other.SpecVersion;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      attributes_.Add(other.attributes_);
      switch (other.DataCase) {
        case DataOneofCase.BinaryData:
          BinaryData = other.BinaryData;
          break;
        case DataOneofCase.TextData:
          TextData = other.TextData;
          break;
        case DataOneofCase.ProtoData:
          if (ProtoData == null) {
            ProtoData = new global::Google.Protobuf.WellKnownTypes.Any();
          }
          ProtoData.MergeFrom(other.ProtoData);
          break;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Source = input.ReadString();
            break;
          }
          case 26: {
            SpecVersion = input.ReadString();
            break;
          }
          case 34: {
            Type = input.ReadString();
            break;
          }
          case 42: {
            attributes_.AddEntriesFrom(input, _map_attributes_codec);
            break;
          }
          case 50: {
            BinaryData = input.ReadBytes();
            break;
          }
          case 58: {
            TextData = input.ReadString();
            break;
          }
          case 66: {
            global::Google.Protobuf.WellKnownTypes.Any subBuilder = new global::Google.Protobuf.WellKnownTypes.Any();
            if (dataCase_ == DataOneofCase.ProtoData) {
              subBuilder.MergeFrom(ProtoData);
            }
            input.ReadMessage(subBuilder);
            ProtoData = subBuilder;
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CloudEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class CloudEventAttributeValue : pb::IMessage<CloudEventAttributeValue> {
        private static readonly pb::MessageParser<CloudEventAttributeValue> _parser = new pb::MessageParser<CloudEventAttributeValue>(() => new CloudEventAttributeValue());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CloudEventAttributeValue> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Io.Cloudevents.V1.CloudEvent.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CloudEventAttributeValue() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CloudEventAttributeValue(CloudEventAttributeValue other) : this() {
          switch (other.AttrCase) {
            case AttrOneofCase.CeBoolean:
              CeBoolean = other.CeBoolean;
              break;
            case AttrOneofCase.CeInteger:
              CeInteger = other.CeInteger;
              break;
            case AttrOneofCase.CeString:
              CeString = other.CeString;
              break;
            case AttrOneofCase.CeBytes:
              CeBytes = other.CeBytes;
              break;
            case AttrOneofCase.CeUri:
              CeUri = other.CeUri;
              break;
            case AttrOneofCase.CeUriRef:
              CeUriRef = other.CeUriRef;
              break;
            case AttrOneofCase.CeTimestamp:
              CeTimestamp = other.CeTimestamp.Clone();
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CloudEventAttributeValue Clone() {
          return new CloudEventAttributeValue(this);
        }

        /// <summary>Field number for the "ce_boolean" field.</summary>
        public const int CeBooleanFieldNumber = 1;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool CeBoolean {
          get { return attrCase_ == AttrOneofCase.CeBoolean ? (bool) attr_ : false; }
          set {
            attr_ = value;
            attrCase_ = AttrOneofCase.CeBoolean;
          }
        }

        /// <summary>Field number for the "ce_integer" field.</summary>
        public const int CeIntegerFieldNumber = 2;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CeInteger {
          get { return attrCase_ == AttrOneofCase.CeInteger ? (int) attr_ : 0; }
          set {
            attr_ = value;
            attrCase_ = AttrOneofCase.CeInteger;
          }
        }

        /// <summary>Field number for the "ce_string" field.</summary>
        public const int CeStringFieldNumber = 3;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CeString {
          get { return attrCase_ == AttrOneofCase.CeString ? (string) attr_ : ""; }
          set {
            attr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            attrCase_ = AttrOneofCase.CeString;
          }
        }

        /// <summary>Field number for the "ce_bytes" field.</summary>
        public const int CeBytesFieldNumber = 4;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString CeBytes {
          get { return attrCase_ == AttrOneofCase.CeBytes ? (pb::ByteString) attr_ : pb::ByteString.Empty; }
          set {
            attr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            attrCase_ = AttrOneofCase.CeBytes;
          }
        }

        /// <summary>Field number for the "ce_uri" field.</summary>
        public const int CeUriFieldNumber = 5;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CeUri {
          get { return attrCase_ == AttrOneofCase.CeUri ? (string) attr_ : ""; }
          set {
            attr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            attrCase_ = AttrOneofCase.CeUri;
          }
        }

        /// <summary>Field number for the "ce_uri_ref" field.</summary>
        public const int CeUriRefFieldNumber = 6;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CeUriRef {
          get { return attrCase_ == AttrOneofCase.CeUriRef ? (string) attr_ : ""; }
          set {
            attr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            attrCase_ = AttrOneofCase.CeUriRef;
          }
        }

        /// <summary>Field number for the "ce_timestamp" field.</summary>
        public const int CeTimestampFieldNumber = 7;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Timestamp CeTimestamp {
          get { return attrCase_ == AttrOneofCase.CeTimestamp ? (global::Google.Protobuf.WellKnownTypes.Timestamp) attr_ : null; }
          set {
            attr_ = value;
            attrCase_ = value == null ? AttrOneofCase.None : AttrOneofCase.CeTimestamp;
          }
        }

        private object attr_;
        /// <summary>Enum of possible cases for the "attr" oneof.</summary>
        public enum AttrOneofCase {
          None = 0,
          CeBoolean = 1,
          CeInteger = 2,
          CeString = 3,
          CeBytes = 4,
          CeUri = 5,
          CeUriRef = 6,
          CeTimestamp = 7,
        }
        private AttrOneofCase attrCase_ = AttrOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AttrOneofCase AttrCase {
          get { return attrCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearAttr() {
          attrCase_ = AttrOneofCase.None;
          attr_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as CloudEventAttributeValue);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CloudEventAttributeValue other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (CeBoolean != other.CeBoolean) return false;
          if (CeInteger != other.CeInteger) return false;
          if (CeString != other.CeString) return false;
          if (CeBytes != other.CeBytes) return false;
          if (CeUri != other.CeUri) return false;
          if (CeUriRef != other.CeUriRef) return false;
          if (!object.Equals(CeTimestamp, other.CeTimestamp)) return false;
          if (AttrCase != other.AttrCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (attrCase_ == AttrOneofCase.CeBoolean) hash ^= CeBoolean.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeInteger) hash ^= CeInteger.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeString) hash ^= CeString.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeBytes) hash ^= CeBytes.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeUri) hash ^= CeUri.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeUriRef) hash ^= CeUriRef.GetHashCode();
          if (attrCase_ == AttrOneofCase.CeTimestamp) hash ^= CeTimestamp.GetHashCode();
          hash ^= (int) attrCase_;
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
          if (attrCase_ == AttrOneofCase.CeBoolean) {
            output.WriteRawTag(8);
            output.WriteBool(CeBoolean);
          }
          if (attrCase_ == AttrOneofCase.CeInteger) {
            output.WriteRawTag(16);
            output.WriteInt32(CeInteger);
          }
          if (attrCase_ == AttrOneofCase.CeString) {
            output.WriteRawTag(26);
            output.WriteString(CeString);
          }
          if (attrCase_ == AttrOneofCase.CeBytes) {
            output.WriteRawTag(34);
            output.WriteBytes(CeBytes);
          }
          if (attrCase_ == AttrOneofCase.CeUri) {
            output.WriteRawTag(42);
            output.WriteString(CeUri);
          }
          if (attrCase_ == AttrOneofCase.CeUriRef) {
            output.WriteRawTag(50);
            output.WriteString(CeUriRef);
          }
          if (attrCase_ == AttrOneofCase.CeTimestamp) {
            output.WriteRawTag(58);
            output.WriteMessage(CeTimestamp);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (attrCase_ == AttrOneofCase.CeBoolean) {
            size += 1 + 1;
          }
          if (attrCase_ == AttrOneofCase.CeInteger) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(CeInteger);
          }
          if (attrCase_ == AttrOneofCase.CeString) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CeString);
          }
          if (attrCase_ == AttrOneofCase.CeBytes) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(CeBytes);
          }
          if (attrCase_ == AttrOneofCase.CeUri) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CeUri);
          }
          if (attrCase_ == AttrOneofCase.CeUriRef) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CeUriRef);
          }
          if (attrCase_ == AttrOneofCase.CeTimestamp) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(CeTimestamp);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CloudEventAttributeValue other) {
          if (other == null) {
            return;
          }
          switch (other.AttrCase) {
            case AttrOneofCase.CeBoolean:
              CeBoolean = other.CeBoolean;
              break;
            case AttrOneofCase.CeInteger:
              CeInteger = other.CeInteger;
              break;
            case AttrOneofCase.CeString:
              CeString = other.CeString;
              break;
            case AttrOneofCase.CeBytes:
              CeBytes = other.CeBytes;
              break;
            case AttrOneofCase.CeUri:
              CeUri = other.CeUri;
              break;
            case AttrOneofCase.CeUriRef:
              CeUriRef = other.CeUriRef;
              break;
            case AttrOneofCase.CeTimestamp:
              if (CeTimestamp == null) {
                CeTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
              }
              CeTimestamp.MergeFrom(other.CeTimestamp);
              break;
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
              case 8: {
                CeBoolean = input.ReadBool();
                break;
              }
              case 16: {
                CeInteger = input.ReadInt32();
                break;
              }
              case 26: {
                CeString = input.ReadString();
                break;
              }
              case 34: {
                CeBytes = input.ReadBytes();
                break;
              }
              case 42: {
                CeUri = input.ReadString();
                break;
              }
              case 50: {
                CeUriRef = input.ReadString();
                break;
              }
              case 58: {
                global::Google.Protobuf.WellKnownTypes.Timestamp subBuilder = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                if (attrCase_ == AttrOneofCase.CeTimestamp) {
                  subBuilder.MergeFrom(CeTimestamp);
                }
                input.ReadMessage(subBuilder);
                CeTimestamp = subBuilder;
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
