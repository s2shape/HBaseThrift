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
  /// Holds row name and then a map of columns to cells.
  /// </summary>
  public partial class TRowResult : TBase
  {
    private byte[] _row;
    private Dictionary<byte[], TCell> _columns;
    private List<TColumn> _sortedColumns;

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

    public Dictionary<byte[], TCell> Columns
    {
      get
      {
        return _columns;
      }
      set
      {
        __isset.columns = true;
        this._columns = value;
      }
    }

    public List<TColumn> SortedColumns
    {
      get
      {
        return _sortedColumns;
      }
      set
      {
        __isset.sortedColumns = true;
        this._sortedColumns = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool row;
      public bool columns;
      public bool sortedColumns;
    }

    public TRowResult()
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
                Row = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map4 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Columns = new Dictionary<byte[], TCell>(_map4.Count);
                  for(int _i5 = 0; _i5 < _map4.Count; ++_i5)
                  {
                    byte[] _key6;
                    TCell _val7;
                    _key6 = await iprot.ReadBinaryAsync(cancellationToken);
                    _val7 = new TCell();
                    await _val7.ReadAsync(iprot, cancellationToken);
                    Columns[_key6] = _val7;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list8 = await iprot.ReadListBeginAsync(cancellationToken);
                  SortedColumns = new List<TColumn>(_list8.Count);
                  for(int _i9 = 0; _i9 < _list8.Count; ++_i9)
                  {
                    TColumn _elem10;
                    _elem10 = new TColumn();
                    await _elem10.ReadAsync(iprot, cancellationToken);
                    SortedColumns.Add(_elem10);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var struc = new TStruct("TRowResult");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Row != null && __isset.row)
        {
          field.Name = "row";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Row, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Columns != null && __isset.columns)
        {
          field.Name = "columns";
          field.Type = TType.Map;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Struct, Columns.Count), cancellationToken);
            foreach (byte[] _iter11 in Columns.Keys)
            {
              await oprot.WriteBinaryAsync(_iter11, cancellationToken);
              await Columns[_iter11].WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (SortedColumns != null && __isset.sortedColumns)
        {
          field.Name = "sortedColumns";
          field.Type = TType.List;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, SortedColumns.Count), cancellationToken);
            foreach (TColumn _iter12 in SortedColumns)
            {
              await _iter12.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      var other = that as TRowResult;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.row == other.__isset.row) && ((!__isset.row) || (System.Object.Equals(Row, other.Row))))
        && ((__isset.columns == other.__isset.columns) && ((!__isset.columns) || (TCollections.Equals(Columns, other.Columns))))
        && ((__isset.sortedColumns == other.__isset.sortedColumns) && ((!__isset.sortedColumns) || (TCollections.Equals(SortedColumns, other.SortedColumns))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.row)
          hashcode = (hashcode * 397) + Row.GetHashCode();
        if(__isset.columns)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
        if(__isset.sortedColumns)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(SortedColumns);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TRowResult(");
      bool __first = true;
      if (Row != null && __isset.row)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Row: ");
        sb.Append(Row);
      }
      if (Columns != null && __isset.columns)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Columns: ");
        sb.Append(Columns);
      }
      if (SortedColumns != null && __isset.sortedColumns)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("SortedColumns: ");
        sb.Append(SortedColumns);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
