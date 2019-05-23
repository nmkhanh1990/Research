﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NhomGiangVienTinhDinhMuc.cs instead.
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
	/// An object representation of the 'NhomGiangVienTinhDinhMuc' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class NhomGiangVienTinhDinhMucBase : EntityBase, INhomGiangVienTinhDinhMuc, IEntityId<NhomGiangVienTinhDinhMucKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private NhomGiangVienTinhDinhMucEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private NhomGiangVienTinhDinhMucEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private NhomGiangVienTinhDinhMucEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<NhomGiangVienTinhDinhMuc> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NhomGiangVienTinhDinhMucEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NhomGiangVienTinhDinhMucEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="NhomGiangVienTinhDinhMucBase"/> instance.
		///</summary>
		public NhomGiangVienTinhDinhMucBase()
		{
			this.entityData = new NhomGiangVienTinhDinhMucEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="NhomGiangVienTinhDinhMucBase"/> instance.
		///</summary>
		///<param name="_maNhomGiangVien"></param>
		///<param name="_tenNhomGiangVien"></param>
		public NhomGiangVienTinhDinhMucBase(System.String _maNhomGiangVien, System.String _tenNhomGiangVien)
		{
			this.entityData = new NhomGiangVienTinhDinhMucEntityData();
			this.backupData = null;

			this.MaNhomGiangVien = _maNhomGiangVien;
			this.TenNhomGiangVien = _tenNhomGiangVien;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="NhomGiangVienTinhDinhMuc"/> instance.
		///</summary>
		///<param name="_maNhomGiangVien"></param>
		///<param name="_tenNhomGiangVien"></param>
		public static NhomGiangVienTinhDinhMuc CreateNhomGiangVienTinhDinhMuc(System.String _maNhomGiangVien, System.String _tenNhomGiangVien)
		{
			NhomGiangVienTinhDinhMuc newNhomGiangVienTinhDinhMuc = new NhomGiangVienTinhDinhMuc();
			newNhomGiangVienTinhDinhMuc.MaNhomGiangVien = _maNhomGiangVien;
			newNhomGiangVienTinhDinhMuc.TenNhomGiangVien = _tenNhomGiangVien;
			return newNhomGiangVienTinhDinhMuc;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MaNhomGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		[Required(ErrorMessage = "MaNhomGiangVien is required")]




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 50)]
		public virtual System.String MaNhomGiangVien
		{
			get
			{
				return this.entityData.MaNhomGiangVien; 
			}
			
			set
			{
				if (this.entityData.MaNhomGiangVien == value)
					return;
				
                OnPropertyChanging("MaNhomGiangVien");                    
				OnColumnChanging(NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien, this.entityData.MaNhomGiangVien);
				this.entityData.MaNhomGiangVien = value;
				this.EntityId.MaNhomGiangVien = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien, this.entityData.MaNhomGiangVien);
				OnPropertyChanged("MaNhomGiangVien");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the MaNhomGiangVien property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the MaNhomGiangVien property.</remarks>
		/// <value>This type is nvarchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalMaNhomGiangVien
		{
			get { return this.entityData.OriginalMaNhomGiangVien; }
			set { this.entityData.OriginalMaNhomGiangVien = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the TenNhomGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.String TenNhomGiangVien
		{
			get
			{
				return this.entityData.TenNhomGiangVien; 
			}
			
			set
			{
				if (this.entityData.TenNhomGiangVien == value)
					return;
				
                OnPropertyChanging("TenNhomGiangVien");                    
				OnColumnChanging(NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien, this.entityData.TenNhomGiangVien);
				this.entityData.TenNhomGiangVien = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien, this.entityData.TenNhomGiangVien);
				OnPropertyChanged("TenNhomGiangVien");
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
				new ValidationRuleArgs("MaNhomGiangVien", "Ma Nhom Giang Vien"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MaNhomGiangVien", "Ma Nhom Giang Vien", 50));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "NhomGiangVienTinhDinhMuc"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MaNhomGiangVien", "TenNhomGiangVien"};
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
	            this.backupData = this.entityData.Clone() as NhomGiangVienTinhDinhMucEntityData;
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
						this.parentCollection.Remove( (NhomGiangVienTinhDinhMuc) this ) ;
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
	            this.parentCollection = value as TList<NhomGiangVienTinhDinhMuc>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as NhomGiangVienTinhDinhMuc);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed NhomGiangVienTinhDinhMuc Entity 
		///</summary>
		protected virtual NhomGiangVienTinhDinhMuc Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			NhomGiangVienTinhDinhMuc copy = new NhomGiangVienTinhDinhMuc();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MaNhomGiangVien = this.MaNhomGiangVien;
					copy.OriginalMaNhomGiangVien = this.OriginalMaNhomGiangVien;
				copy.TenNhomGiangVien = this.TenNhomGiangVien;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed NhomGiangVienTinhDinhMuc Entity 
		///</summary>
		public virtual NhomGiangVienTinhDinhMuc Copy()
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
		///  Returns a Typed NhomGiangVienTinhDinhMuc Entity which is a deep copy of the current entity.
		///</summary>
		public virtual NhomGiangVienTinhDinhMuc DeepCopy()
		{
			return EntityHelper.Clone<NhomGiangVienTinhDinhMuc>(this as NhomGiangVienTinhDinhMuc);	
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
				this.entityData = this._originalData.Clone() as NhomGiangVienTinhDinhMucEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new NhomGiangVienTinhDinhMucEntityData();
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
			this._originalData = this.entityData.Clone() as NhomGiangVienTinhDinhMucEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(NhomGiangVienTinhDinhMucColumn column)
		{
			switch(column)
			{
					case NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien:
					return entityData.MaNhomGiangVien != _originalData.MaNhomGiangVien;
					case NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien:
					return entityData.TenNhomGiangVien != _originalData.TenNhomGiangVien;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< NhomGiangVienTinhDinhMucColumn >(columnName));
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
			result = result || entityData.MaNhomGiangVien != _originalData.MaNhomGiangVien;
			result = result || entityData.TenNhomGiangVien != _originalData.TenNhomGiangVien;
			return result;
		}	
		
		///<summary>
		///  Returns a NhomGiangVienTinhDinhMuc Entity with the original data.
		///</summary>
		public NhomGiangVienTinhDinhMuc GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateNhomGiangVienTinhDinhMuc(
				_originalData.MaNhomGiangVien,
				_originalData.TenNhomGiangVien
				);
				
			return (NhomGiangVienTinhDinhMuc)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="NhomGiangVienTinhDinhMucBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is NhomGiangVienTinhDinhMucBase)
				return ValueEquals(this, (NhomGiangVienTinhDinhMucBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="NhomGiangVienTinhDinhMucBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MaNhomGiangVien.GetHashCode() ^ 
					((this.TenNhomGiangVien == null) ? string.Empty : this.TenNhomGiangVien.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="NhomGiangVienTinhDinhMucBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(NhomGiangVienTinhDinhMucBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="NhomGiangVienTinhDinhMucBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="NhomGiangVienTinhDinhMucBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="NhomGiangVienTinhDinhMucBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(NhomGiangVienTinhDinhMucBase Object1, NhomGiangVienTinhDinhMucBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MaNhomGiangVien != Object2.MaNhomGiangVien)
				equal = false;
			if ( Object1.TenNhomGiangVien != null && Object2.TenNhomGiangVien != null )
			{
				if (Object1.TenNhomGiangVien != Object2.TenNhomGiangVien)
					equal = false;
			}
			else if (Object1.TenNhomGiangVien == null ^ Object2.TenNhomGiangVien == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((NhomGiangVienTinhDinhMucBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static NhomGiangVienTinhDinhMucComparer GetComparer()
        {
            return new NhomGiangVienTinhDinhMucComparer();
        }
        */

        // Comparer delegates back to NhomGiangVienTinhDinhMuc
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
        public int CompareTo(NhomGiangVienTinhDinhMuc rhs, NhomGiangVienTinhDinhMucColumn which)
        {
            switch (which)
            {
            	
            	
            	case NhomGiangVienTinhDinhMucColumn.MaNhomGiangVien:
            		return this.MaNhomGiangVien.CompareTo(rhs.MaNhomGiangVien);
            		
            		                 
            	
            	
            	case NhomGiangVienTinhDinhMucColumn.TenNhomGiangVien:
            		return this.TenNhomGiangVien.CompareTo(rhs.TenNhomGiangVien);
            		
            		                 
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
				
		#region IEntityKey<NhomGiangVienTinhDinhMucKey> Members
		
		// member variable for the EntityId property
		private NhomGiangVienTinhDinhMucKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual NhomGiangVienTinhDinhMucKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new NhomGiangVienTinhDinhMucKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("NhomGiangVienTinhDinhMuc")
					.Append("|").Append( this.MaNhomGiangVien.ToString()).ToString();
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
				"{3}{2}- MaNhomGiangVien: {0}{2}- TenNhomGiangVien: {1}{2}{4}", 
				this.MaNhomGiangVien,
				(this.TenNhomGiangVien == null) ? string.Empty : this.TenNhomGiangVien.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'NhomGiangVienTinhDinhMuc' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class NhomGiangVienTinhDinhMucEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MaNhomGiangVien : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NhomGiangVienTinhDinhMuc"</remarks>
		public System.String MaNhomGiangVien;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalMaNhomGiangVien;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// TenNhomGiangVien : 
		/// </summary>
		public System.String TenNhomGiangVien = null;
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
			NhomGiangVienTinhDinhMucEntityData _tmp = new NhomGiangVienTinhDinhMucEntityData();
						
			_tmp.MaNhomGiangVien = this.MaNhomGiangVien;
			_tmp.OriginalMaNhomGiangVien = this.OriginalMaNhomGiangVien;
			
			_tmp.TenNhomGiangVien = this.TenNhomGiangVien;
			
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
				
			NhomGiangVienTinhDinhMucEntityData _tmp = new NhomGiangVienTinhDinhMucEntityData();
						
			_tmp.MaNhomGiangVien = this.MaNhomGiangVien;
			_tmp.OriginalMaNhomGiangVien = this.OriginalMaNhomGiangVien;
			
			_tmp.TenNhomGiangVien = this.TenNhomGiangVien;
			
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
		/// <param name="column">The <see cref="NhomGiangVienTinhDinhMucColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(NhomGiangVienTinhDinhMucColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDinhMucColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(NhomGiangVienTinhDinhMucColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDinhMucColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(NhomGiangVienTinhDinhMucColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				NhomGiangVienTinhDinhMucEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new NhomGiangVienTinhDinhMucEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDinhMucColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(NhomGiangVienTinhDinhMucColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				NhomGiangVienTinhDinhMucEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new NhomGiangVienTinhDinhMucEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region NhomGiangVienTinhDinhMucEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="NhomGiangVienTinhDinhMuc"/> object.
	/// </remarks>
	public class NhomGiangVienTinhDinhMucEventArgs : System.EventArgs
	{
		private NhomGiangVienTinhDinhMucColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the NhomGiangVienTinhDinhMucEventArgs class.
		///</summary>
		public NhomGiangVienTinhDinhMucEventArgs(NhomGiangVienTinhDinhMucColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the NhomGiangVienTinhDinhMucEventArgs class.
		///</summary>
		public NhomGiangVienTinhDinhMucEventArgs(NhomGiangVienTinhDinhMucColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The NhomGiangVienTinhDinhMucColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="NhomGiangVienTinhDinhMucColumn" />
		public NhomGiangVienTinhDinhMucColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all NhomGiangVienTinhDinhMuc related events.
	///</summary>
	public delegate void NhomGiangVienTinhDinhMucEventHandler(object sender, NhomGiangVienTinhDinhMucEventArgs e);
	
	#region NhomGiangVienTinhDinhMucComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class NhomGiangVienTinhDinhMucComparer : System.Collections.Generic.IComparer<NhomGiangVienTinhDinhMuc>
	{
		NhomGiangVienTinhDinhMucColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:NhomGiangVienTinhDinhMucComparer"/> class.
        /// </summary>
		public NhomGiangVienTinhDinhMucComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NhomGiangVienTinhDinhMucComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public NhomGiangVienTinhDinhMucComparer(NhomGiangVienTinhDinhMucColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="NhomGiangVienTinhDinhMuc"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="NhomGiangVienTinhDinhMuc"/> to compare.</param>
        /// <param name="b">The second <c>NhomGiangVienTinhDinhMuc</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(NhomGiangVienTinhDinhMuc a, NhomGiangVienTinhDinhMuc b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(NhomGiangVienTinhDinhMuc entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(NhomGiangVienTinhDinhMuc a, NhomGiangVienTinhDinhMuc b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public NhomGiangVienTinhDinhMucColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region NhomGiangVienTinhDinhMucKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="NhomGiangVienTinhDinhMuc"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDinhMucKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucKey class.
		/// </summary>
		public NhomGiangVienTinhDinhMucKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucKey class.
		/// </summary>
		public NhomGiangVienTinhDinhMucKey(NhomGiangVienTinhDinhMucBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MaNhomGiangVien = entity.MaNhomGiangVien;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDinhMucKey class.
		/// </summary>
		public NhomGiangVienTinhDinhMucKey(System.String _maNhomGiangVien)
		{
			#region Init Properties

			this.MaNhomGiangVien = _maNhomGiangVien;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private NhomGiangVienTinhDinhMucBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public NhomGiangVienTinhDinhMucBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MaNhomGiangVien property
		private System.String _maNhomGiangVien;
		
		/// <summary>
		/// Gets or sets the MaNhomGiangVien property.
		/// </summary>
		public System.String MaNhomGiangVien
		{
			get { return _maNhomGiangVien; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MaNhomGiangVien = value;
				
				_maNhomGiangVien = value;
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
				MaNhomGiangVien = ( values["MaNhomGiangVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaNhomGiangVien"], typeof(System.String)) : string.Empty;
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

			values.Add("MaNhomGiangVien", MaNhomGiangVien);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MaNhomGiangVien: {0}{1}",
								MaNhomGiangVien,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region NhomGiangVienTinhDinhMucColumn Enum
	
	/// <summary>
	/// Enumerate the NhomGiangVienTinhDinhMuc columns.
	/// </summary>
	[Serializable]
	public enum NhomGiangVienTinhDinhMucColumn : int
	{
		/// <summary>
		/// MaNhomGiangVien : 
		/// </summary>
		[EnumTextValue("Ma Nhom Giang Vien")]
		[ColumnEnum("MaNhomGiangVien", typeof(System.String), System.Data.DbType.String, true, false, false, 50)]
		MaNhomGiangVien = 1,
		/// <summary>
		/// TenNhomGiangVien : 
		/// </summary>
		[EnumTextValue("Ten Nhom Giang Vien")]
		[ColumnEnum("TenNhomGiangVien", typeof(System.String), System.Data.DbType.String, false, false, true)]
		TenNhomGiangVien = 2
	}//End enum

	#endregion NhomGiangVienTinhDinhMucColumn Enum

} // end namespace
