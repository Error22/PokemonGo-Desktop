// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/GetIncensePokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetIncensePokemonMessage.proto</summary>
  public static partial class GetIncensePokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetIncensePokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetIncensePokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
            "SW5jZW5zZVBva2Vtb25NZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5ldHdv",
            "cmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMiTQoYR2V0SW5jZW5zZVBva2Vtb25N",
            "ZXNzYWdlEhcKD3BsYXllcl9sYXRpdHVkZRgBIAEoARIYChBwbGF5ZXJfbG9u",
            "Z2l0dWRlGAIgASgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GetIncensePokemonMessage), global::POGOProtos.Networking.Requests.Messages.GetIncensePokemonMessage.Parser, new[]{ "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetIncensePokemonMessage : pb::IMessage<GetIncensePokemonMessage> {
    private static readonly pb::MessageParser<GetIncensePokemonMessage> _parser = new pb::MessageParser<GetIncensePokemonMessage>(() => new GetIncensePokemonMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetIncensePokemonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.GetIncensePokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncensePokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncensePokemonMessage(GetIncensePokemonMessage other) : this() {
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIncensePokemonMessage Clone() {
      return new GetIncensePokemonMessage(this);
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 1;
    private double playerLatitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 2;
    private double playerLongitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetIncensePokemonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetIncensePokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerLatitude != other.PlayerLatitude) return false;
      if (PlayerLongitude != other.PlayerLongitude) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
      if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(PlayerLongitude);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetIncensePokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 17: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code