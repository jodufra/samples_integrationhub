#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace ApplicationLib	
{
	public partial class Record
	{
		private int _idRecord;
		public virtual int IdRecord
		{
			get
			{
				return this._idRecord;
			}
			set
			{
				this._idRecord = value;
			}
		}
		
		private int _nodeId;
		public virtual int NodeId
		{
			get
			{
				return this._nodeId;
			}
			set
			{
				this._nodeId = value;
			}
		}
		
		private string _channel;
		public virtual string Channel
		{
			get
			{
				return this._channel;
			}
			set
			{
				this._channel = value;
			}
		}
		
		private DateTime _dateCreated;
		public virtual DateTime DateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				this._dateCreated = value;
			}
		}
		
		private long _dateCreatedTicks;
		public virtual long DateCreatedTicks
		{
			get
			{
				return this._dateCreatedTicks;
			}
			set
			{
				this._dateCreatedTicks = value;
			}
		}
		
		private float _value;
		public virtual float Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
		
	}
}
#pragma warning restore 1591