/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.Hadoop.Hbase.Thrift
{

  /// <summary>
  /// TCell - Used to transport a cell value (byte[]) and the timestamp it was
  /// stored with together as a result for get and getRow methods. This promotes
  /// the timestamp of a cell to a first-class value, making it easy to take
  /// note of temporal data. Cell is used all the way from HStore up to HTable.
  /// </summary>
  public partial class TCell : TBase
  {
    private byte[] _value;
    private long _timestamp;

    public byte[] Value
    {
      get
      {
        return _value;
      }
      set
      {
        __isset.@value = true;
        this._value = value;
      }
    }

    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool @value;
      public bool timestamp;
    }

    public TCell()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Value = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                Timestamp = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TCell");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Value != null && __isset.@value)
        {
          field.Name = "value";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Value, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.timestamp)
        {
          field.Name = "timestamp";
          field.Type = TType.I64;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Timestamp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TCell;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.@value == other.__isset.@value) && ((!__isset.@value) || (System.Object.Equals(Value, other.Value))))
        && ((__isset.timestamp == other.__isset.timestamp) && ((!__isset.timestamp) || (System.Object.Equals(Timestamp, other.Timestamp))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.@value)
          hashcode = (hashcode * 397) + Value.GetHashCode();
        if(__isset.timestamp)
          hashcode = (hashcode * 397) + Timestamp.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TCell(");
      bool __first = true;
      if (Value != null && __isset.@value)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Value: ");
        sb.Append(Value);
      }
      if (__isset.timestamp)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Timestamp: ");
        sb.Append(Timestamp);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
