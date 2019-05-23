﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NamHoc.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using PMS.Entities.Validation;
#endregion

namespace PMS.Entities
{
	///<summary>
	/// An object representation of the 'NamHoc' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class NamHocBase : EntityBase, INamHoc, IEntityId<NamHocKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private NamHocEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private NamHocEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private NamHocEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<NamHoc> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NamHocEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NamHocEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="NamHocBase"/> instance.
		///</summary>
		public NamHocBase()
		{
			this.entityData = new NamHocEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="NamHocBase"/> instance.
		///</summary>
		///<param name="_namHoc"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		public NamHocBase(System.String _namHoc, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc)
		{
			this.entityData = new NamHocEntityData();
			this.backupData = null;

			this.NamHoc = _namHoc;
			this.NgayBatDau = _ngayBatDau;
			this.NgayKetThuc = _ngayKetThuc;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="NamHoc"/> instance.
		///</summary>
		///<param name="_namHoc"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		public static NamHoc CreateNamHoc(System.String _namHoc, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc)
		{
			NamHoc newNamHoc = new NamHoc();
			newNamHoc.NamHoc = _namHoc;
			newNamHoc.NgayBatDau = _ngayBatDau;
			newNamHoc.NgayKetThuc = _ngayKetThuc;
			return newNamHoc;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		[Required(ErrorMessage = "NamHoc is required")]




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 20)]
		public virtual System.String NamHoc
		{
			get
			{
				return this.entityData.NamHoc; 
			}
			
			set
			{
				if (this.entityData.NamHoc == value)
					return;
				
                OnPropertyChanging("NamHoc");                    
				OnColumnChanging(NamHocColumn.NamHoc, this.entityData.NamHoc);
				this.entityData.NamHoc = value;
				this.EntityId.NamHoc = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NamHocColumn.NamHoc, this.entityData.NamHoc);
				OnPropertyChanged("NamHoc");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the NamHoc property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the NamHoc property.</remarks>
		/// <value>This type is varchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalNamHoc
		{
			get { return this.entityData.OriginalNamHoc; }
			set { this.entityData.OriginalNamHoc = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the NgayBatDau property. 
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
		public virtual System.DateTime? NgayBatDau
		{
			get
			{
				return this.entityData.NgayBatDau; 
			}
			
			set
			{
				if (this.entityData.NgayBatDau == value)
					return;
				
                OnPropertyChanging("NgayBatDau");                    
				OnColumnChanging(NamHocColumn.NgayBatDau, this.entityData.NgayBatDau);
				this.entityData.NgayBatDau = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NamHocColumn.NgayBatDau, this.entityData.NgayBatDau);
				OnPropertyChanged("NgayBatDau");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the NgayKetThuc property. 
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
		public virtual System.DateTime? NgayKetThuc
		{
			get
			{
				return this.entityData.NgayKetThuc; 
			}
			
			set
			{
				if (this.entityData.NgayKetThuc == value)
					return;
				
                OnPropertyChanging("NgayKetThuc");                    
				OnColumnChanging(NamHocColumn.NgayKetThuc, this.entityData.NgayKetThuc);
				this.entityData.NgayKetThuc = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NamHocColumn.NgayKetThuc, this.entityData.NgayKetThuc);
				OnPropertyChanged("NgayKetThuc");
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
				new ValidationRuleArgs("NamHoc", "Nam Hoc"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("NamHoc", "Nam Hoc", 20));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "NamHoc"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"NamHoc", "NgayBatDau", "NgayKetThuc"};
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
	            this.backupData = this.entityData.Clone() as NamHocEntityData;
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
						this.parentCollection.Remove( (NamHoc) this ) ;
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
	            this.parentCollection = value as TList<NamHoc>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as NamHoc);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed NamHoc Entity 
		///</summary>
		protected virtual NamHoc Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			NamHoc copy = new NamHoc();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.NamHoc = this.NamHoc;
					copy.OriginalNamHoc = this.OriginalNamHoc;
				copy.NgayBatDau = this.NgayBatDau;
				copy.NgayKetThuc = this.NgayKetThuc;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed NamHoc Entity 
		///</summary>
		public virtual NamHoc Copy()
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
		///  Returns a Typed NamHoc Entity which is a deep copy of the current entity.
		///</summary>
		public virtual NamHoc DeepCopy()
		{
			return EntityHelper.Clone<NamHoc>(this as NamHoc);	
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
				this.entityData = this._originalData.Clone() as NamHocEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new NamHocEntityData();
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
			this._originalData = this.entityData.Clone() as NamHocEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(NamHocColumn column)
		{
			switch(column)
			{
					case NamHocColumn.NamHoc:
					return entityData.NamHoc != _originalData.NamHoc;
					case NamHocColumn.NgayBatDau:
					return entityData.NgayBatDau != _originalData.NgayBatDau;
					case NamHocColumn.NgayKetThuc:
					return entityData.NgayKetThuc != _originalData.NgayKetThuc;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< NamHocColumn >(columnName));
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
			result = result || entityData.NamHoc != _originalData.NamHoc;
			result = result || entityData.NgayBatDau != _originalData.NgayBatDau;
			result = result || entityData.NgayKetThuc != _originalData.NgayKetThuc;
			return result;
		}	
		
		///<summary>
		///  Returns a NamHoc Entity with the original data.
		///</summary>
		public NamHoc GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateNamHoc(
				_originalData.NamHoc,
				_originalData.NgayBatDau,
				_originalData.NgayKetThuc
				);
				
			return (NamHoc)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="NamHocBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is NamHocBase)
				return ValueEquals(this, (NamHocBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="NamHocBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.NamHoc.GetHashCode() ^ 
					((this.NgayBatDau == null) ? string.Empty : this.NgayBatDau.ToString()).GetHashCode() ^ 
					((this.NgayKetThuc == null) ? string.Empty : this.NgayKetThuc.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="NamHocBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(NamHocBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="NamHocBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="NamHocBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="NamHocBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(NamHocBase Object1, NamHocBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.NamHoc != Object2.NamHoc)
				equal = false;
			if ( Object1.NgayBatDau != null && Object2.NgayBatDau != null )
			{
				if (Object1.NgayBatDau != Object2.NgayBatDau)
					equal = false;
			}
			else if (Object1.NgayBatDau == null ^ Object2.NgayBatDau == null )
			{
				equal = false;
			}
			if ( Object1.NgayKetThuc != null && Object2.NgayKetThuc != null )
			{
				if (Object1.NgayKetThuc != Object2.NgayKetThuc)
					equal = false;
			}
			else if (Object1.NgayKetThuc == null ^ Object2.NgayKetThuc == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((NamHocBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static NamHocComparer GetComparer()
        {
            return new NamHocComparer();
        }
        */

        // Comparer delegates back to NamHoc
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
        public int CompareTo(NamHoc rhs, NamHocColumn which)
        {
            switch (which)
            {
            	
            	
            	case NamHocColumn.NamHoc:
            		return this.NamHoc.CompareTo(rhs.NamHoc);
            		
            		                 
            	
            	
            	case NamHocColumn.NgayBatDau:
            		return this.NgayBatDau.Value.CompareTo(rhs.NgayBatDau.Value);
            		
            		                 
            	
            	
            	case NamHocColumn.NgayKetThuc:
            		return this.NgayKetThuc.Value.CompareTo(rhs.NgayKetThuc.Value);
            		
            		                 
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
				
		#region IEntityKey<NamHocKey> Members
		
		// member variable for the EntityId property
		private NamHocKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual NamHocKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new NamHocKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("NamHoc")
					.Append("|").Append( this.NamHoc.ToString()).ToString();
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
				"{4}{3}- NamHoc: {0}{3}- NgayBatDau: {1}{3}- NgayKetThuc: {2}{3}{5}", 
				this.NamHoc,
				(this.NgayBatDau == null) ? string.Empty : this.NgayBatDau.ToString(),
				(this.NgayKetThuc == null) ? string.Empty : this.NgayKetThuc.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'NamHoc' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class NamHocEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// NamHoc : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NamHoc"</remarks>
		public System.String NamHoc;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalNamHoc;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		public System.DateTime? NgayBatDau = null;
		
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		public System.DateTime? NgayKetThuc = null;
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
			NamHocEntityData _tmp = new NamHocEntityData();
						
			_tmp.NamHoc = this.NamHoc;
			_tmp.OriginalNamHoc = this.OriginalNamHoc;
			
			_tmp.NgayBatDau = this.NgayBatDau;
			_tmp.NgayKetThuc = this.NgayKetThuc;
			
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
				
			NamHocEntityData _tmp = new NamHocEntityData();
						
			_tmp.NamHoc = this.NamHoc;
			_tmp.OriginalNamHoc = this.OriginalNamHoc;
			
			_tmp.NgayBatDau = this.NgayBatDau;
			_tmp.NgayKetThuc = this.NgayKetThuc;
			
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
		/// <param name="column">The <see cref="NamHocColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(NamHocColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NamHocColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(NamHocColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NamHocColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(NamHocColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				NamHocEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new NamHocEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NamHocColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(NamHocColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				NamHocEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new NamHocEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region NamHocEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="NamHoc"/> object.
	/// </remarks>
	public class NamHocEventArgs : System.EventArgs
	{
		private NamHocColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the NamHocEventArgs class.
		///</summary>
		public NamHocEventArgs(NamHocColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the NamHocEventArgs class.
		///</summary>
		public NamHocEventArgs(NamHocColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The NamHocColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="NamHocColumn" />
		public NamHocColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all NamHoc related events.
	///</summary>
	public delegate void NamHocEventHandler(object sender, NamHocEventArgs e);
	
	#region NamHocComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class NamHocComparer : System.Collections.Generic.IComparer<NamHoc>
	{
		NamHocColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:NamHocComparer"/> class.
        /// </summary>
		public NamHocComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NamHocComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public NamHocComparer(NamHocColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="NamHoc"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="NamHoc"/> to compare.</param>
        /// <param name="b">The second <c>NamHoc</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(NamHoc a, NamHoc b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(NamHoc entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(NamHoc a, NamHoc b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public NamHocColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region NamHocKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="NamHoc"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class NamHocKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the NamHocKey class.
		/// </summary>
		public NamHocKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the NamHocKey class.
		/// </summary>
		public NamHocKey(NamHocBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.NamHoc = entity.NamHoc;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the NamHocKey class.
		/// </summary>
		public NamHocKey(System.String _namHoc)
		{
			#region Init Properties

			this.NamHoc = _namHoc;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private NamHocBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public NamHocBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the NamHoc property
		private System.String _namHoc;
		
		/// <summary>
		/// Gets or sets the NamHoc property.
		/// </summary>
		public System.String NamHoc
		{
			get { return _namHoc; }
			set
			{
				if ( this.Entity != null )
					this.Entity.NamHoc = value;
				
				_namHoc = value;
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
				NamHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
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

			values.Add("NamHoc", NamHoc);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("NamHoc: {0}{1}",
								NamHoc,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region NamHocColumn Enum
	
	/// <summary>
	/// Enumerate the NamHoc columns.
	/// </summary>
	[Serializable]
	public enum NamHocColumn : int
	{
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("Nam Hoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, true, false, false, 20)]
		NamHoc = 1,
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		[EnumTextValue("Ngay Bat Dau")]
		[ColumnEnum("NgayBatDau", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayBatDau = 2,
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		[EnumTextValue("Ngay Ket Thuc")]
		[ColumnEnum("NgayKetThuc", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayKetThuc = 3
	}//End enum

	#endregion NamHocColumn Enum

} // end namespace
