//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled

// Option: light framework (CF/Silverlight) enabled

// Generated from: NetPostUtil.proto
namespace Protobuf.Data
{
  [global::ProtoBuf.ProtoContract(Name=@"RegistData")]
  public partial class RegistData : global::ProtoBuf.IExtensible
  {
    public RegistData() {}
    
    private string _loginChannel;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"loginChannel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LoginChannel
    {
      get { return _loginChannel?? ""; }
      set { _loginChannel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool LoginChannelSpecified
    {
      get { return this._loginChannel != null; }
      set { if (value == (this._loginChannel== null)) this._loginChannel = value ? this.LoginChannel : (string)null; }
    }
    private bool ShouldSerializeLoginChannel() { return LoginChannelSpecified; }
    private void ResetLoginChannel() { LoginChannelSpecified = false; }
    
    private string _logoutChannel;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"logoutChannel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LogoutChannel
    {
      get { return _logoutChannel?? ""; }
      set { _logoutChannel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool LogoutChannelSpecified
    {
      get { return this._logoutChannel != null; }
      set { if (value == (this._logoutChannel== null)) this._logoutChannel = value ? this.LogoutChannel : (string)null; }
    }
    private bool ShouldSerializeLogoutChannel() { return LogoutChannelSpecified; }
    private void ResetLogoutChannel() { LogoutChannelSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}