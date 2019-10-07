﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NhomGiangVienTinhDonGia.cs instead.
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
	/// An object representation of the 'NhomGiangVienTinhDonGia' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class NhomGiangVienTinhDonGiaBase : EntityBase, INhomGiangVienTinhDonGia, IEntityId<NhomGiangVienTinhDonGiaKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private NhomGiangVienTinhDonGiaEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private NhomGiangVienTinhDonGiaEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private NhomGiangVienTinhDonGiaEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<NhomGiangVienTinhDonGia> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NhomGiangVienTinhDonGiaEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event NhomGiangVienTinhDonGiaEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="NhomGiangVienTinhDonGiaBase"/> instance.
		///</summary>
		public NhomGiangVienTinhDonGiaBase()
		{
			this.entityData = new NhomGiangVienTinhDonGiaEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="NhomGiangVienTinhDonGiaBase"/> instance.
		///</summary>
		///<param name="_maNhom"></param>
		///<param name="_tenNhom"></param>
		///<param name="_ghiChu"></param>
		public NhomGiangVienTinhDonGiaBase(System.String _maNhom, System.String _tenNhom, 
			System.String _ghiChu)
		{
			this.entityData = new NhomGiangVienTinhDonGiaEntityData();
			this.backupData = null;

			this.MaNhom = _maNhom;
			this.TenNhom = _tenNhom;
			this.GhiChu = _ghiChu;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="NhomGiangVienTinhDonGia"/> instance.
		///</summary>
		///<param name="_maNhom"></param>
		///<param name="_tenNhom"></param>
		///<param name="_ghiChu"></param>
		public static NhomGiangVienTinhDonGia CreateNhomGiangVienTinhDonGia(System.String _maNhom, System.String _tenNhom, 
			System.String _ghiChu)
		{
			NhomGiangVienTinhDonGia newNhomGiangVienTinhDonGia = new NhomGiangVienTinhDonGia();
			newNhomGiangVienTinhDonGia.MaNhom = _maNhom;
			newNhomGiangVienTinhDonGia.TenNhom = _tenNhom;
			newNhomGiangVienTinhDonGia.GhiChu = _ghiChu;
			return newNhomGiangVienTinhDonGia;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MaNhom property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		[Required(ErrorMessage = "MaNhom is required")]




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 50)]
		public virtual System.String MaNhom
		{
			get
			{
				return this.entityData.MaNhom; 
			}
			
			set
			{
				if (this.entityData.MaNhom == value)
					return;
				
                OnPropertyChanging("MaNhom");                    
				OnColumnChanging(NhomGiangVienTinhDonGiaColumn.MaNhom, this.entityData.MaNhom);
				this.entityData.MaNhom = value;
				this.EntityId.MaNhom = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NhomGiangVienTinhDonGiaColumn.MaNhom, this.entityData.MaNhom);
				OnPropertyChanged("MaNhom");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the MaNhom property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the MaNhom property.</remarks>
		/// <value>This type is nvarchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalMaNhom
		{
			get { return this.entityData.OriginalMaNhom; }
			set { this.entityData.OriginalMaNhom = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the TenNhom property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.String TenNhom
		{
			get
			{
				return this.entityData.TenNhom; 
			}
			
			set
			{
				if (this.entityData.TenNhom == value)
					return;
				
                OnPropertyChanging("TenNhom");                    
				OnColumnChanging(NhomGiangVienTinhDonGiaColumn.TenNhom, this.entityData.TenNhom);
				this.entityData.TenNhom = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NhomGiangVienTinhDonGiaColumn.TenNhom, this.entityData.TenNhom);
				OnPropertyChanged("TenNhom");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the GhiChu property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.String GhiChu
		{
			get
			{
				return this.entityData.GhiChu; 
			}
			
			set
			{
				if (this.entityData.GhiChu == value)
					return;
				
                OnPropertyChanging("GhiChu");                    
				OnColumnChanging(NhomGiangVienTinhDonGiaColumn.GhiChu, this.entityData.GhiChu);
				this.entityData.GhiChu = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(NhomGiangVienTinhDonGiaColumn.GhiChu, this.entityData.GhiChu);
				OnPropertyChanged("GhiChu");
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
				new ValidationRuleArgs("MaNhom", "Ma Nhom"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MaNhom", "Ma Nhom", 50));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "NhomGiangVienTinhDonGia"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MaNhom", "TenNhom", "GhiChu"};
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
	            this.backupData = this.entityData.Clone() as NhomGiangVienTinhDonGiaEntityData;
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
						this.parentCollection.Remove( (NhomGiangVienTinhDonGia) this ) ;
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
	            this.parentCollection = value as TList<NhomGiangVienTinhDonGia>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as NhomGiangVienTinhDonGia);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed NhomGiangVienTinhDonGia Entity 
		///</summary>
		protected virtual NhomGiangVienTinhDonGia Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			NhomGiangVienTinhDonGia copy = new NhomGiangVienTinhDonGia();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MaNhom = this.MaNhom;
					copy.OriginalMaNhom = this.OriginalMaNhom;
				copy.TenNhom = this.TenNhom;
				copy.GhiChu = this.GhiChu;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed NhomGiangVienTinhDonGia Entity 
		///</summary>
		public virtual NhomGiangVienTinhDonGia Copy()
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
		///  Returns a Typed NhomGiangVienTinhDonGia Entity which is a deep copy of the current entity.
		///</summary>
		public virtual NhomGiangVienTinhDonGia DeepCopy()
		{
			return EntityHelper.Clone<NhomGiangVienTinhDonGia>(this as NhomGiangVienTinhDonGia);	
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
				this.entityData = this._originalData.Clone() as NhomGiangVienTinhDonGiaEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new NhomGiangVienTinhDonGiaEntityData();
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
			this._originalData = this.entityData.Clone() as NhomGiangVienTinhDonGiaEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(NhomGiangVienTinhDonGiaColumn column)
		{
			switch(column)
			{
					case NhomGiangVienTinhDonGiaColumn.MaNhom:
					return entityData.MaNhom != _originalData.MaNhom;
					case NhomGiangVienTinhDonGiaColumn.TenNhom:
					return entityData.TenNhom != _originalData.TenNhom;
					case NhomGiangVienTinhDonGiaColumn.GhiChu:
					return entityData.GhiChu != _originalData.GhiChu;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< NhomGiangVienTinhDonGiaColumn >(columnName));
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
			result = result || entityData.MaNhom != _originalData.MaNhom;
			result = result || entityData.TenNhom != _originalData.TenNhom;
			result = result || entityData.GhiChu != _originalData.GhiChu;
			return result;
		}	
		
		///<summary>
		///  Returns a NhomGiangVienTinhDonGia Entity with the original data.
		///</summary>
		public NhomGiangVienTinhDonGia GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateNhomGiangVienTinhDonGia(
				_originalData.MaNhom,
				_originalData.TenNhom,
				_originalData.GhiChu
				);
				
			return (NhomGiangVienTinhDonGia)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="NhomGiangVienTinhDonGiaBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is NhomGiangVienTinhDonGiaBase)
				return ValueEquals(this, (NhomGiangVienTinhDonGiaBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="NhomGiangVienTinhDonGiaBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MaNhom.GetHashCode() ^ 
					((this.TenNhom == null) ? string.Empty : this.TenNhom.ToString()).GetHashCode() ^ 
					((this.GhiChu == null) ? string.Empty : this.GhiChu.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="NhomGiangVienTinhDonGiaBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(NhomGiangVienTinhDonGiaBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="NhomGiangVienTinhDonGiaBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="NhomGiangVienTinhDonGiaBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="NhomGiangVienTinhDonGiaBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(NhomGiangVienTinhDonGiaBase Object1, NhomGiangVienTinhDonGiaBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MaNhom != Object2.MaNhom)
				equal = false;
			if ( Object1.TenNhom != null && Object2.TenNhom != null )
			{
				if (Object1.TenNhom != Object2.TenNhom)
					equal = false;
			}
			else if (Object1.TenNhom == null ^ Object2.TenNhom == null )
			{
				equal = false;
			}
			if ( Object1.GhiChu != null && Object2.GhiChu != null )
			{
				if (Object1.GhiChu != Object2.GhiChu)
					equal = false;
			}
			else if (Object1.GhiChu == null ^ Object2.GhiChu == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((NhomGiangVienTinhDonGiaBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static NhomGiangVienTinhDonGiaComparer GetComparer()
        {
            return new NhomGiangVienTinhDonGiaComparer();
        }
        */

        // Comparer delegates back to NhomGiangVienTinhDonGia
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
        public int CompareTo(NhomGiangVienTinhDonGia rhs, NhomGiangVienTinhDonGiaColumn which)
        {
            switch (which)
            {
            	
            	
            	case NhomGiangVienTinhDonGiaColumn.MaNhom:
            		return this.MaNhom.CompareTo(rhs.MaNhom);
            		
            		                 
            	
            	
            	case NhomGiangVienTinhDonGiaColumn.TenNhom:
            		return this.TenNhom.CompareTo(rhs.TenNhom);
            		
            		                 
            	
            	
            	case NhomGiangVienTinhDonGiaColumn.GhiChu:
            		return this.GhiChu.CompareTo(rhs.GhiChu);
            		
            		                 
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
				
		#region IEntityKey<NhomGiangVienTinhDonGiaKey> Members
		
		// member variable for the EntityId property
		private NhomGiangVienTinhDonGiaKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual NhomGiangVienTinhDonGiaKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new NhomGiangVienTinhDonGiaKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("NhomGiangVienTinhDonGia")
					.Append("|").Append( this.MaNhom.ToString()).ToString();
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
				"{4}{3}- MaNhom: {0}{3}- TenNhom: {1}{3}- GhiChu: {2}{3}{5}", 
				this.MaNhom,
				(this.TenNhom == null) ? string.Empty : this.TenNhom.ToString(),
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'NhomGiangVienTinhDonGia' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class NhomGiangVienTinhDonGiaEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MaNhom : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NhomGiangVienTinhDonGia"</remarks>
		public System.String MaNhom;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalMaNhom;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// TenNhom : 
		/// </summary>
		public System.String TenNhom = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		public System.String GhiChu = null;
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
			NhomGiangVienTinhDonGiaEntityData _tmp = new NhomGiangVienTinhDonGiaEntityData();
						
			_tmp.MaNhom = this.MaNhom;
			_tmp.OriginalMaNhom = this.OriginalMaNhom;
			
			_tmp.TenNhom = this.TenNhom;
			_tmp.GhiChu = this.GhiChu;
			
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
				
			NhomGiangVienTinhDonGiaEntityData _tmp = new NhomGiangVienTinhDonGiaEntityData();
						
			_tmp.MaNhom = this.MaNhom;
			_tmp.OriginalMaNhom = this.OriginalMaNhom;
			
			_tmp.TenNhom = this.TenNhom;
			_tmp.GhiChu = this.GhiChu;
			
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
		/// <param name="column">The <see cref="NhomGiangVienTinhDonGiaColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(NhomGiangVienTinhDonGiaColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDonGiaColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(NhomGiangVienTinhDonGiaColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDonGiaColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(NhomGiangVienTinhDonGiaColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				NhomGiangVienTinhDonGiaEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new NhomGiangVienTinhDonGiaEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="NhomGiangVienTinhDonGiaColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(NhomGiangVienTinhDonGiaColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				NhomGiangVienTinhDonGiaEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new NhomGiangVienTinhDonGiaEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region NhomGiangVienTinhDonGiaEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="NhomGiangVienTinhDonGia"/> object.
	/// </remarks>
	public class NhomGiangVienTinhDonGiaEventArgs : System.EventArgs
	{
		private NhomGiangVienTinhDonGiaColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the NhomGiangVienTinhDonGiaEventArgs class.
		///</summary>
		public NhomGiangVienTinhDonGiaEventArgs(NhomGiangVienTinhDonGiaColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the NhomGiangVienTinhDonGiaEventArgs class.
		///</summary>
		public NhomGiangVienTinhDonGiaEventArgs(NhomGiangVienTinhDonGiaColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The NhomGiangVienTinhDonGiaColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="NhomGiangVienTinhDonGiaColumn" />
		public NhomGiangVienTinhDonGiaColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all NhomGiangVienTinhDonGia related events.
	///</summary>
	public delegate void NhomGiangVienTinhDonGiaEventHandler(object sender, NhomGiangVienTinhDonGiaEventArgs e);
	
	#region NhomGiangVienTinhDonGiaComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class NhomGiangVienTinhDonGiaComparer : System.Collections.Generic.IComparer<NhomGiangVienTinhDonGia>
	{
		NhomGiangVienTinhDonGiaColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:NhomGiangVienTinhDonGiaComparer"/> class.
        /// </summary>
		public NhomGiangVienTinhDonGiaComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NhomGiangVienTinhDonGiaComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public NhomGiangVienTinhDonGiaComparer(NhomGiangVienTinhDonGiaColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="NhomGiangVienTinhDonGia"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="NhomGiangVienTinhDonGia"/> to compare.</param>
        /// <param name="b">The second <c>NhomGiangVienTinhDonGia</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(NhomGiangVienTinhDonGia a, NhomGiangVienTinhDonGia b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(NhomGiangVienTinhDonGia entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(NhomGiangVienTinhDonGia a, NhomGiangVienTinhDonGia b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public NhomGiangVienTinhDonGiaColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region NhomGiangVienTinhDonGiaKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="NhomGiangVienTinhDonGia"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class NhomGiangVienTinhDonGiaKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaKey class.
		/// </summary>
		public NhomGiangVienTinhDonGiaKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaKey class.
		/// </summary>
		public NhomGiangVienTinhDonGiaKey(NhomGiangVienTinhDonGiaBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MaNhom = entity.MaNhom;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the NhomGiangVienTinhDonGiaKey class.
		/// </summary>
		public NhomGiangVienTinhDonGiaKey(System.String _maNhom)
		{
			#region Init Properties

			this.MaNhom = _maNhom;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private NhomGiangVienTinhDonGiaBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public NhomGiangVienTinhDonGiaBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MaNhom property
		private System.String _maNhom;
		
		/// <summary>
		/// Gets or sets the MaNhom property.
		/// </summary>
		public System.String MaNhom
		{
			get { return _maNhom; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MaNhom = value;
				
				_maNhom = value;
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
				MaNhom = ( values["MaNhom"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaNhom"], typeof(System.String)) : string.Empty;
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

			values.Add("MaNhom", MaNhom);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MaNhom: {0}{1}",
								MaNhom,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region NhomGiangVienTinhDonGiaColumn Enum
	
	/// <summary>
	/// Enumerate the NhomGiangVienTinhDonGia columns.
	/// </summary>
	[Serializable]
	public enum NhomGiangVienTinhDonGiaColumn : int
	{
		/// <summary>
		/// MaNhom : 
		/// </summary>
		[EnumTextValue("Ma Nhom")]
		[ColumnEnum("MaNhom", typeof(System.String), System.Data.DbType.String, true, false, false, 50)]
		MaNhom = 1,
		/// <summary>
		/// TenNhom : 
		/// </summary>
		[EnumTextValue("Ten Nhom")]
		[ColumnEnum("TenNhom", typeof(System.String), System.Data.DbType.String, false, false, true)]
		TenNhom = 2,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("Ghi Chu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true)]
		GhiChu = 3
	}//End enum

	#endregion NhomGiangVienTinhDonGiaColumn Enum

} // end namespace
