﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file MonKhongTinh.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using PMS.Entities.Validation;
#endregion

namespace PMS.Entities
{
	///<summary>
	/// Mon hoc khong tinh khoi luong giang day	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class MonKhongTinhBase : EntityBase, IMonKhongTinh, IEntityId<MonKhongTinhKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private MonKhongTinhEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private MonKhongTinhEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private MonKhongTinhEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<MonKhongTinh> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event MonKhongTinhEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event MonKhongTinhEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="MonKhongTinhBase"/> instance.
		///</summary>
		public MonKhongTinhBase()
		{
			this.entityData = new MonKhongTinhEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="MonKhongTinhBase"/> instance.
		///</summary>
		///<param name="_maMonHoc"></param>
		///<param name="_ngayTao"></param>
		public MonKhongTinhBase(System.String _maMonHoc, System.DateTime? _ngayTao)
		{
			this.entityData = new MonKhongTinhEntityData();
			this.backupData = null;

			this.MaMonHoc = _maMonHoc;
			this.NgayTao = _ngayTao;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="MonKhongTinh"/> instance.
		///</summary>
		///<param name="_maMonHoc"></param>
		///<param name="_ngayTao"></param>
		public static MonKhongTinh CreateMonKhongTinh(System.String _maMonHoc, System.DateTime? _ngayTao)
		{
			MonKhongTinh newMonKhongTinh = new MonKhongTinh();
			newMonKhongTinh.MaMonHoc = _maMonHoc;
			newMonKhongTinh.NgayTao = _ngayTao;
			return newMonKhongTinh;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MaMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 20)]
		public virtual System.String MaMonHoc
		{
			get
			{
				return this.entityData.MaMonHoc; 
			}
			
			set
			{
				if (this.entityData.MaMonHoc == value)
					return;
				
                OnPropertyChanging("MaMonHoc");                    
				OnColumnChanging(MonKhongTinhColumn.MaMonHoc, this.entityData.MaMonHoc);
				this.entityData.MaMonHoc = value;
				this.EntityId.MaMonHoc = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(MonKhongTinhColumn.MaMonHoc, this.entityData.MaMonHoc);
				OnPropertyChanged("MaMonHoc");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the MaMonHoc property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the MaMonHoc property.</remarks>
		/// <value>This type is varchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalMaMonHoc
		{
			get { return this.entityData.OriginalMaMonHoc; }
			set { this.entityData.OriginalMaMonHoc = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the NgayTao property. 
		///		
		/// </summary>
		/// <value>This type is datetime.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null it is up to the developer to check using the HasValue property
		/// and perform business logic appropriately.
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.DateTime? NgayTao
		{
			get
			{
				return this.entityData.NgayTao; 
			}
			
			set
			{
				if (this.entityData.NgayTao == value)
					return;
				
                OnPropertyChanging("NgayTao");                    
				OnColumnChanging(MonKhongTinhColumn.NgayTao, this.entityData.NgayTao);
				this.entityData.NgayTao = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(MonKhongTinhColumn.NgayTao, this.entityData.NgayTao);
				OnPropertyChanged("NgayTao");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
		#endregion Children Collections
		
		#endregion
		#region Validation
		
		/// <summary>
		/// Assigns validation rules to this object based on model definition.
		/// </summary>
		/// <remarks>This method overrides the base class to add schema related validation.</remarks>
		protected override void AddValidationRules()
		{
			//Validation rules based on database schema.
			ValidationRules.AddRule( CommonRules.NotNull,
				new ValidationRuleArgs("MaMonHoc", "Ma Mon Hoc"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MaMonHoc", "Ma Mon Hoc", 20));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "MonKhongTinh"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MaMonHoc", "NgayTao"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as MonKhongTinhEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (MonKhongTinh) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<MonKhongTinh>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as MonKhongTinh);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed MonKhongTinh Entity 
		///</summary>
		protected virtual MonKhongTinh Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			MonKhongTinh copy = new MonKhongTinh();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MaMonHoc = this.MaMonHoc;
					copy.OriginalMaMonHoc = this.OriginalMaMonHoc;
				copy.NgayTao = this.NgayTao;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed MonKhongTinh Entity 
		///</summary>
		public virtual MonKhongTinh Copy()
		{
			return this.Copy(null);	
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy(null);
		}
		
		///<summary>
		/// ICloneableEx.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone(IDictionary existingCopies)
		{
			return this.Copy(existingCopies);
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x, IDictionary existingCopies)
		{
			if (x == null)
				return null;
			
			if (x is ICloneableEx)
			{
				// Return a deep copy of the object
				return ((ICloneableEx)x).Clone(existingCopies);
			}
			else if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable or IClonableEx Interface.");
		}
		
		
		///<summary>
		///  Returns a Typed MonKhongTinh Entity which is a deep copy of the current entity.
		///</summary>
		public virtual MonKhongTinh DeepCopy()
		{
			return EntityHelper.Clone<MonKhongTinh>(this as MonKhongTinh);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as MonKhongTinhEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new MonKhongTinhEntityData();
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as MonKhongTinhEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(MonKhongTinhColumn column)
		{
			switch(column)
			{
					case MonKhongTinhColumn.MaMonHoc:
					return entityData.MaMonHoc != _originalData.MaMonHoc;
					case MonKhongTinhColumn.NgayTao:
					return entityData.NgayTao != _originalData.NgayTao;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="columnName">The column name.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public override bool IsPropertyChanged(string columnName)
		{
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< MonKhongTinhColumn >(columnName));
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if data has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.MaMonHoc != _originalData.MaMonHoc;
			result = result || entityData.NgayTao != _originalData.NgayTao;
			return result;
		}	
		
		///<summary>
		///  Returns a MonKhongTinh Entity with the original data.
		///</summary>
		public MonKhongTinh GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateMonKhongTinh(
				_originalData.MaMonHoc,
				_originalData.NgayTao
				);
				
			return (MonKhongTinh)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="MonKhongTinhBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is MonKhongTinhBase)
				return ValueEquals(this, (MonKhongTinhBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="MonKhongTinhBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MaMonHoc.GetHashCode() ^ 
					((this.NgayTao == null) ? string.Empty : this.NgayTao.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="MonKhongTinhBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(MonKhongTinhBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="MonKhongTinhBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="MonKhongTinhBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="MonKhongTinhBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(MonKhongTinhBase Object1, MonKhongTinhBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MaMonHoc != Object2.MaMonHoc)
				equal = false;
			if ( Object1.NgayTao != null && Object2.NgayTao != null )
			{
				if (Object1.NgayTao != Object2.NgayTao)
					equal = false;
			}
			else if (Object1.NgayTao == null ^ Object2.NgayTao == null )
			{
				equal = false;
			}
					
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((MonKhongTinhBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static MonKhongTinhComparer GetComparer()
        {
            return new MonKhongTinhComparer();
        }
        */

        // Comparer delegates back to MonKhongTinh
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(MonKhongTinh rhs, MonKhongTinhColumn which)
        {
            switch (which)
            {
            	
            	
            	case MonKhongTinhColumn.MaMonHoc:
            		return this.MaMonHoc.CompareTo(rhs.MaMonHoc);
            		
            		                 
            	
            	
            	case MonKhongTinhColumn.NgayTao:
            		return this.NgayTao.Value.CompareTo(rhs.NgayTao.Value);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<MonKhongTinhKey> Members
		
		// member variable for the EntityId property
		private MonKhongTinhKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual MonKhongTinhKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new MonKhongTinhKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) ]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("MonKhongTinh")
					.Append("|").Append( this.MaMonHoc.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{3}{2}- MaMonHoc: {0}{2}- NgayTao: {1}{2}{4}", 
				this.MaMonHoc,
				(this.NgayTao == null) ? string.Empty : this.NgayTao.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'MonKhongTinh' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class MonKhongTinhEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MaMonHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "MonKhongTinh"</remarks>
		public System.String MaMonHoc;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalMaMonHoc;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// NgayTao : 
		/// </summary>
		public System.DateTime? NgayTao = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
        
		#endregion Variable Declarations

		#region Data Properties

		#endregion Data Properties
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			MonKhongTinhEntityData _tmp = new MonKhongTinhEntityData();
						
			_tmp.MaMonHoc = this.MaMonHoc;
			_tmp.OriginalMaMonHoc = this.OriginalMaMonHoc;
			
			_tmp.NgayTao = this.NgayTao;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone(IDictionary existingCopies)
		{
			if (existingCopies == null)
				existingCopies = new Hashtable();
				
			MonKhongTinhEntityData _tmp = new MonKhongTinhEntityData();
						
			_tmp.MaMonHoc = this.MaMonHoc;
			_tmp.OriginalMaMonHoc = this.OriginalMaMonHoc;
			
			_tmp.NgayTao = this.NgayTao;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false)]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct

		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MonKhongTinhColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(MonKhongTinhColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MonKhongTinhColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(MonKhongTinhColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MonKhongTinhColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(MonKhongTinhColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				MonKhongTinhEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new MonKhongTinhEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="MonKhongTinhColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(MonKhongTinhColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				MonKhongTinhEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new MonKhongTinhEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region MonKhongTinhEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="MonKhongTinh"/> object.
	/// </remarks>
	public class MonKhongTinhEventArgs : System.EventArgs
	{
		private MonKhongTinhColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the MonKhongTinhEventArgs class.
		///</summary>
		public MonKhongTinhEventArgs(MonKhongTinhColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the MonKhongTinhEventArgs class.
		///</summary>
		public MonKhongTinhEventArgs(MonKhongTinhColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The MonKhongTinhColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="MonKhongTinhColumn" />
		public MonKhongTinhColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all MonKhongTinh related events.
	///</summary>
	public delegate void MonKhongTinhEventHandler(object sender, MonKhongTinhEventArgs e);
	
	#region MonKhongTinhComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class MonKhongTinhComparer : System.Collections.Generic.IComparer<MonKhongTinh>
	{
		MonKhongTinhColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:MonKhongTinhComparer"/> class.
        /// </summary>
		public MonKhongTinhComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MonKhongTinhComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public MonKhongTinhComparer(MonKhongTinhColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="MonKhongTinh"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="MonKhongTinh"/> to compare.</param>
        /// <param name="b">The second <c>MonKhongTinh</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(MonKhongTinh a, MonKhongTinh b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(MonKhongTinh entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(MonKhongTinh a, MonKhongTinh b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public MonKhongTinhColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region MonKhongTinhKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="MonKhongTinh"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class MonKhongTinhKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the MonKhongTinhKey class.
		/// </summary>
		public MonKhongTinhKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the MonKhongTinhKey class.
		/// </summary>
		public MonKhongTinhKey(MonKhongTinhBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MaMonHoc = entity.MaMonHoc;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the MonKhongTinhKey class.
		/// </summary>
		public MonKhongTinhKey(System.String _maMonHoc)
		{
			#region Init Properties

			this.MaMonHoc = _maMonHoc;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private MonKhongTinhBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public MonKhongTinhBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MaMonHoc property
		private System.String _maMonHoc;
		
		/// <summary>
		/// Gets or sets the MaMonHoc property.
		/// </summary>
		public System.String MaMonHoc
		{
			get { return _maMonHoc; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MaMonHoc = value;
				
				_maMonHoc = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				MaMonHoc = ( values["MaMonHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaMonHoc"], typeof(System.String)) : string.Empty;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("MaMonHoc", MaMonHoc);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MaMonHoc: {0}{1}",
								MaMonHoc,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region MonKhongTinhColumn Enum
	
	/// <summary>
	/// Enumerate the MonKhongTinh columns.
	/// </summary>
	[Serializable]
	public enum MonKhongTinhColumn : int
	{
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		[EnumTextValue("Ma Mon Hoc")]
		[ColumnEnum("MaMonHoc", typeof(System.String), System.Data.DbType.AnsiString, true, false, false, 20)]
		MaMonHoc = 1,
		/// <summary>
		/// NgayTao : 
		/// </summary>
		[EnumTextValue("Ngay Tao")]
		[ColumnEnum("NgayTao", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayTao = 2
	}//End enum

	#endregion MonKhongTinhColumn Enum

} // end namespace
