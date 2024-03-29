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
  /// For increments that are not incrementColumnValue
  /// equivalents.
  /// </summary>
  public partial class TIncrement : TBase
  {
    private byte[] _table;
    private byte[] _row;
    private byte[] _column;
    private long _ammount;

    public byte[] Table
    {
      get
      {
        return _table;
      }
      set
      {
        __isset.table = true;
        this._table = value;
      }
    }

    public byte[] Row
    {
      get
      {
        return _row;
      }
      set
      {
        __isset.row = true;
        this._row = value;
      }
    }

    public byte[] Column
    {
      get
      {
        return _column;
      }
      set
      {
        __isset.column = true;
        this._column = value;
      }
    }

    public long Ammount
    {
      get
      {
        return _ammount;
      }
      set
      {
        __isset.ammount = true;
        this._ammount = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool table;
      public bool row;
      public bool column;
      public bool ammount;
    }

    public TIncrement()
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
                Table = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Row = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Column = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Ammount = await iprot.ReadI64Async(cancellationToken);
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
        var struc = new TStruct("TIncrement");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Table != null && __isset.table)
        {
          field.Name = "table";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Table, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Row != null && __isset.row)
        {
          field.Name = "row";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Row, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Column != null && __isset.column)
        {
          field.Name = "column";
          field.Type = TType.String;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Column, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.ammount)
        {
          field.Name = "ammount";
          field.Type = TType.I64;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Ammount, cancellationToken);
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
      var other = that as TIncrement;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.table == other.__isset.table) && ((!__isset.table) || (System.Object.Equals(Table, other.Table))))
        && ((__isset.row == other.__isset.row) && ((!__isset.row) || (System.Object.Equals(Row, other.Row))))
        && ((__isset.column == other.__isset.column) && ((!__isset.column) || (System.Object.Equals(Column, other.Column))))
        && ((__isset.ammount == other.__isset.ammount) && ((!__isset.ammount) || (System.Object.Equals(Ammount, other.Ammount))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.table)
          hashcode = (hashcode * 397) + Table.GetHashCode();
        if(__isset.row)
          hashcode = (hashcode * 397) + Row.GetHashCode();
        if(__isset.column)
          hashcode = (hashcode * 397) + Column.GetHashCode();
        if(__isset.ammount)
          hashcode = (hashcode * 397) + Ammount.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TIncrement(");
      bool __first = true;
      if (Table != null && __isset.table)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Table: ");
        sb.Append(Table);
      }
      if (Row != null && __isset.row)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Row: ");
        sb.Append(Row);
      }
      if (Column != null && __isset.column)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Column: ");
        sb.Append(Column);
      }
      if (__isset.ammount)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Ammount: ");
        sb.Append(Ammount);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
