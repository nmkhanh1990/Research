﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqNhomMonHoc.cs instead.
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
	/// An object representation of the 'KcqNhomMonHoc' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class KcqNhomMonHocBase : EntityBase, IKcqNhomMonHoc, IEntityId<KcqNhomMonHocKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private KcqNhomMonHocEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private KcqNhomMonHocEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private KcqNhomMonHocEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<KcqNhomMonHoc> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event KcqNhomMonHocEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event KcqNhomMonHocEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="KcqNhomMonHocBase"/> instance.
		///</summary>
		public KcqNhomMonHocBase()
		{
			this.entityData = new KcqNhomMonHocEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="KcqNhomMonHocBase"/> instance.
		///</summary>
		///<param name="_maQuanLy"></param>
		///<param name="_tenNhomMon"></param>
		public KcqNhomMonHocBase(System.String _maQuanLy, System.String _tenNhomMon)
		{
			this.entityData = new KcqNhomMonHocEntityData();
			this.backupData = null;

			this.MaQuanLy = _maQuanLy;
			this.TenNhomMon = _tenNhomMon;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="KcqNhomMonHoc"/> instance.
		///</summary>
		///<param name="_maQuanLy"></param>
		///<param name="_tenNhomMon"></param>
		public static KcqNhomMonHoc CreateKcqNhomMonHoc(System.String _maQuanLy, System.String _tenNhomMon)
		{
			KcqNhomMonHoc newKcqNhomMonHoc = new KcqNhomMonHoc();
			newKcqNhomMonHoc.MaQuanLy = _maQuanLy;
			newKcqNhomMonHoc.TenNhomMon = _tenNhomMon;
			return newKcqNhomMonHoc;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MaNhomMon property. 
		///		
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		
		[Required(ErrorMessage = "MaNhomMon is required")]




		[ReadOnlyAttribute(false)/*, XmlIgnoreAttribute()*/, DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, true, false)]
		public virtual System.Int32 MaNhomMon
		{
			get
			{
				return this.entityData.MaNhomMon; 
			}
			
			set
			{
				if (this.entityData.MaNhomMon == value)
					return;
				
                OnPropertyChanging("MaNhomMon");                    
				OnColumnChanging(KcqNhomMonHocColumn.MaNhomMon, this.entityData.MaNhomMon);
				this.entityData.MaNhomMon = value;
				this.EntityId.MaNhomMon = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(KcqNhomMonHocColumn.MaNhomMon, this.entityData.MaNhomMon);
				OnPropertyChanged("MaNhomMon");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the MaQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		[Required(ErrorMessage = "MaQuanLy is required")]




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 20)]
		public virtual System.String MaQuanLy
		{
			get
			{
				return this.entityData.MaQuanLy; 
			}
			
			set
			{
				if (this.entityData.MaQuanLy == value)
					return;
				
                OnPropertyChanging("MaQuanLy");                    
				OnColumnChanging(KcqNhomMonHocColumn.MaQuanLy, this.entityData.MaQuanLy);
				this.entityData.MaQuanLy = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(KcqNhomMonHocColumn.MaQuanLy, this.entityData.MaQuanLy);
				OnPropertyChanged("MaQuanLy");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the TenNhomMon property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 200)]
		public virtual System.String TenNhomMon
		{
			get
			{
				return this.entityData.TenNhomMon; 
			}
			
			set
			{
				if (this.entityData.TenNhomMon == value)
					return;
				
                OnPropertyChanging("TenNhomMon");                    
				OnColumnChanging(KcqNhomMonHocColumn.TenNhomMon, this.entityData.TenNhomMon);
				this.entityData.TenNhomMon = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(KcqNhomMonHocColumn.TenNhomMon, this.entityData.TenNhomMon);
				OnPropertyChanged("TenNhomMon");
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
				new ValidationRuleArgs("MaQuanLy", "Ma Quan Ly"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MaQuanLy", "Ma Quan Ly", 20));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("TenNhomMon", "Ten Nhom Mon", 200));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "KcqNhomMonHoc"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MaNhomMon", "MaQuanLy", "TenNhomMon"};
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
	            this.backupData = this.entityData.Clone() as KcqNhomMonHocEntityData;
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
						this.parentCollection.Remove( (KcqNhomMonHoc) this ) ;
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
	            this.parentCollection = value as TList<KcqNhomMonHoc>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as KcqNhomMonHoc);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed KcqNhomMonHoc Entity 
		///</summary>
		protected virtual KcqNhomMonHoc Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			KcqNhomMonHoc copy = new KcqNhomMonHoc();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MaNhomMon = this.MaNhomMon;
				copy.MaQuanLy = this.MaQuanLy;
				copy.TenNhomMon = this.TenNhomMon;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed KcqNhomMonHoc Entity 
		///</summary>
		public virtual KcqNhomMonHoc Copy()
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
		///  Returns a Typed KcqNhomMonHoc Entity which is a deep copy of the current entity.
		///</summary>
		public virtual KcqNhomMonHoc DeepCopy()
		{
			return EntityHelper.Clone<KcqNhomMonHoc>(this as KcqNhomMonHoc);	
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
				this.entityData = this._originalData.Clone() as KcqNhomMonHocEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new KcqNhomMonHocEntityData();
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
			this._originalData = this.entityData.Clone() as KcqNhomMonHocEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(KcqNhomMonHocColumn column)
		{
			switch(column)
			{
					case KcqNhomMonHocColumn.MaNhomMon:
					return entityData.MaNhomMon != _originalData.MaNhomMon;
					case KcqNhomMonHocColumn.MaQuanLy:
					return entityData.MaQuanLy != _originalData.MaQuanLy;
					case KcqNhomMonHocColumn.TenNhomMon:
					return entityData.TenNhomMon != _originalData.TenNhomMon;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< KcqNhomMonHocColumn >(columnName));
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
			result = result || entityData.MaNhomMon != _originalData.MaNhomMon;
			result = result || entityData.MaQuanLy != _originalData.MaQuanLy;
			result = result || entityData.TenNhomMon != _originalData.TenNhomMon;
			return result;
		}	
		
		///<summary>
		///  Returns a KcqNhomMonHoc Entity with the original data.
		///</summary>
		public KcqNhomMonHoc GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateKcqNhomMonHoc(
				_originalData.MaQuanLy,
				_originalData.TenNhomMon
				);
				
			return (KcqNhomMonHoc)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="KcqNhomMonHocBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is KcqNhomMonHocBase)
				return ValueEquals(this, (KcqNhomMonHocBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="KcqNhomMonHocBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MaNhomMon.GetHashCode() ^ 
					this.MaQuanLy.GetHashCode() ^ 
					((this.TenNhomMon == null) ? string.Empty : this.TenNhomMon.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="KcqNhomMonHocBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(KcqNhomMonHocBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="KcqNhomMonHocBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="KcqNhomMonHocBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="KcqNhomMonHocBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(KcqNhomMonHocBase Object1, KcqNhomMonHocBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MaNhomMon != Object2.MaNhomMon)
				equal = false;
			if (Object1.MaQuanLy != Object2.MaQuanLy)
				equal = false;
			if ( Object1.TenNhomMon != null && Object2.TenNhomMon != null )
			{
				if (Object1.TenNhomMon != Object2.TenNhomMon)
					equal = false;
			}
			else if (Object1.TenNhomMon == null ^ Object2.TenNhomMon == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((KcqNhomMonHocBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static KcqNhomMonHocComparer GetComparer()
        {
            return new KcqNhomMonHocComparer();
        }
        */

        // Comparer delegates back to KcqNhomMonHoc
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
        public int CompareTo(KcqNhomMonHoc rhs, KcqNhomMonHocColumn which)
        {
            switch (which)
            {
            	
            	
            	case KcqNhomMonHocColumn.MaNhomMon:
            		return this.MaNhomMon.CompareTo(rhs.MaNhomMon);
            		
            		                 
            	
            	
            	case KcqNhomMonHocColumn.MaQuanLy:
            		return this.MaQuanLy.CompareTo(rhs.MaQuanLy);
            		
            		                 
            	
            	
            	case KcqNhomMonHocColumn.TenNhomMon:
            		return this.TenNhomMon.CompareTo(rhs.TenNhomMon);
            		
            		                 
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
				
		#region IEntityKey<KcqNhomMonHocKey> Members
		
		// member variable for the EntityId property
		private KcqNhomMonHocKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual KcqNhomMonHocKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new KcqNhomMonHocKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("KcqNhomMonHoc")
					.Append("|").Append( this.MaNhomMon.ToString()).ToString();
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
				"{4}{3}- MaNhomMon: {0}{3}- MaQuanLy: {1}{3}- TenNhomMon: {2}{3}{5}", 
				this.MaNhomMon,
				this.MaQuanLy,
				(this.TenNhomMon == null) ? string.Empty : this.TenNhomMon.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'KcqNhomMonHoc' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class KcqNhomMonHocEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MaNhomMon : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "KcqNhomMonHoc"</remarks>
		public System.Int32 MaNhomMon;
			
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		public System.String MaQuanLy = string.Empty;
		
		/// <summary>
		/// TenNhomMon : 
		/// </summary>
		public System.String TenNhomMon = null;
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
			KcqNhomMonHocEntityData _tmp = new KcqNhomMonHocEntityData();
						
			_tmp.MaNhomMon = this.MaNhomMon;
			
			_tmp.MaQuanLy = this.MaQuanLy;
			_tmp.TenNhomMon = this.TenNhomMon;
			
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
				
			KcqNhomMonHocEntityData _tmp = new KcqNhomMonHocEntityData();
						
			_tmp.MaNhomMon = this.MaNhomMon;
			
			_tmp.MaQuanLy = this.MaQuanLy;
			_tmp.TenNhomMon = this.TenNhomMon;
			
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
		/// <param name="column">The <see cref="KcqNhomMonHocColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(KcqNhomMonHocColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="KcqNhomMonHocColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(KcqNhomMonHocColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="KcqNhomMonHocColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(KcqNhomMonHocColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				KcqNhomMonHocEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new KcqNhomMonHocEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="KcqNhomMonHocColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(KcqNhomMonHocColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				KcqNhomMonHocEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new KcqNhomMonHocEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region KcqNhomMonHocEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="KcqNhomMonHoc"/> object.
	/// </remarks>
	public class KcqNhomMonHocEventArgs : System.EventArgs
	{
		private KcqNhomMonHocColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the KcqNhomMonHocEventArgs class.
		///</summary>
		public KcqNhomMonHocEventArgs(KcqNhomMonHocColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the KcqNhomMonHocEventArgs class.
		///</summary>
		public KcqNhomMonHocEventArgs(KcqNhomMonHocColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The KcqNhomMonHocColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="KcqNhomMonHocColumn" />
		public KcqNhomMonHocColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all KcqNhomMonHoc related events.
	///</summary>
	public delegate void KcqNhomMonHocEventHandler(object sender, KcqNhomMonHocEventArgs e);
	
	#region KcqNhomMonHocComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class KcqNhomMonHocComparer : System.Collections.Generic.IComparer<KcqNhomMonHoc>
	{
		KcqNhomMonHocColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:KcqNhomMonHocComparer"/> class.
        /// </summary>
		public KcqNhomMonHocComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:KcqNhomMonHocComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public KcqNhomMonHocComparer(KcqNhomMonHocColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="KcqNhomMonHoc"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="KcqNhomMonHoc"/> to compare.</param>
        /// <param name="b">The second <c>KcqNhomMonHoc</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(KcqNhomMonHoc a, KcqNhomMonHoc b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(KcqNhomMonHoc entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(KcqNhomMonHoc a, KcqNhomMonHoc b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public KcqNhomMonHocColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region KcqNhomMonHocKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class KcqNhomMonHocKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocKey class.
		/// </summary>
		public KcqNhomMonHocKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocKey class.
		/// </summary>
		public KcqNhomMonHocKey(KcqNhomMonHocBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MaNhomMon = entity.MaNhomMon;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocKey class.
		/// </summary>
		public KcqNhomMonHocKey(System.Int32 _maNhomMon)
		{
			#region Init Properties

			this.MaNhomMon = _maNhomMon;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private KcqNhomMonHocBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public KcqNhomMonHocBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MaNhomMon property
		private System.Int32 _maNhomMon;
		
		/// <summary>
		/// Gets or sets the MaNhomMon property.
		/// </summary>
		public System.Int32 MaNhomMon
		{
			get { return _maNhomMon; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MaNhomMon = value;
				
				_maNhomMon = value;
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
				MaNhomMon = ( values["MaNhomMon"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomMon"], typeof(System.Int32)) : (int)0;
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

			values.Add("MaNhomMon", MaNhomMon);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MaNhomMon: {0}{1}",
								MaNhomMon,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region KcqNhomMonHocColumn Enum
	
	/// <summary>
	/// Enumerate the KcqNhomMonHoc columns.
	/// </summary>
	[Serializable]
	public enum KcqNhomMonHocColumn : int
	{
		/// <summary>
		/// MaNhomMon : 
		/// </summary>
		[EnumTextValue("Ma Nhom Mon")]
		[ColumnEnum("MaNhomMon", typeof(System.Int32), System.Data.DbType.Int32, true, true, false)]
		MaNhomMon = 1,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("Ma Quan Ly")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaQuanLy = 2,
		/// <summary>
		/// TenNhomMon : 
		/// </summary>
		[EnumTextValue("Ten Nhom Mon")]
		[ColumnEnum("TenNhomMon", typeof(System.String), System.Data.DbType.String, false, false, true, 200)]
		TenNhomMon = 3
	}//End enum

	#endregion KcqNhomMonHocColumn Enum

} // end namespace