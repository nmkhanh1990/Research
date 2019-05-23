﻿
/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file LopChatLuongCao.cs instead.
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
	/// An object representation of the 'LopChatLuongCao' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class LopChatLuongCaoBase : EntityBase, ILopChatLuongCao, IEntityId<LopChatLuongCaoKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private LopChatLuongCaoEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private LopChatLuongCaoEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private LopChatLuongCaoEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<LopChatLuongCao> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event LopChatLuongCaoEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event LopChatLuongCaoEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="LopChatLuongCaoBase"/> instance.
		///</summary>
		public LopChatLuongCaoBase()
		{
			this.entityData = new LopChatLuongCaoEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="LopChatLuongCaoBase"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public LopChatLuongCaoBase(System.String _maLop, System.String _ngayCapNhat, System.String _nguoiCapNhat)
		{
			this.entityData = new LopChatLuongCaoEntityData();
			this.backupData = null;

			this.MaLop = _maLop;
			this.NgayCapNhat = _ngayCapNhat;
			this.NguoiCapNhat = _nguoiCapNhat;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="LopChatLuongCao"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static LopChatLuongCao CreateLopChatLuongCao(System.String _maLop, System.String _ngayCapNhat, System.String _nguoiCapNhat)
		{
			LopChatLuongCao newLopChatLuongCao = new LopChatLuongCao();
			newLopChatLuongCao.MaLop = _maLop;
			newLopChatLuongCao.NgayCapNhat = _ngayCapNhat;
			newLopChatLuongCao.NguoiCapNhat = _nguoiCapNhat;
			return newLopChatLuongCao;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		
		




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 50)]
		public virtual System.String MaLop
		{
			get
			{
				return this.entityData.MaLop; 
			}
			
			set
			{
				if (this.entityData.MaLop == value)
					return;
				
                OnPropertyChanging("MaLop");                    
				OnColumnChanging(LopChatLuongCaoColumn.MaLop, this.entityData.MaLop);
				this.entityData.MaLop = value;
				this.EntityId.MaLop = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(LopChatLuongCaoColumn.MaLop, this.entityData.MaLop);
				OnPropertyChanged("MaLop");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the MaLop property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the MaLop property.</remarks>
		/// <value>This type is nvarchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalMaLop
		{
			get { return this.entityData.OriginalMaLop; }
			set { this.entityData.OriginalMaLop = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 50)]
		public virtual System.String NgayCapNhat
		{
			get
			{
				return this.entityData.NgayCapNhat; 
			}
			
			set
			{
				if (this.entityData.NgayCapNhat == value)
					return;
				
                OnPropertyChanging("NgayCapNhat");                    
				OnColumnChanging(LopChatLuongCaoColumn.NgayCapNhat, this.entityData.NgayCapNhat);
				this.entityData.NgayCapNhat = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(LopChatLuongCaoColumn.NgayCapNhat, this.entityData.NgayCapNhat);
				OnPropertyChanged("NgayCapNhat");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the NguoiCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		
		




		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 50)]
		public virtual System.String NguoiCapNhat
		{
			get
			{
				return this.entityData.NguoiCapNhat; 
			}
			
			set
			{
				if (this.entityData.NguoiCapNhat == value)
					return;
				
                OnPropertyChanging("NguoiCapNhat");                    
				OnColumnChanging(LopChatLuongCaoColumn.NguoiCapNhat, this.entityData.NguoiCapNhat);
				this.entityData.NguoiCapNhat = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(LopChatLuongCaoColumn.NguoiCapNhat, this.entityData.NguoiCapNhat);
				OnPropertyChanged("NguoiCapNhat");
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
				new ValidationRuleArgs("MaLop", "Ma Lop"));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("MaLop", "Ma Lop", 50));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("NgayCapNhat", "Ngay Cap Nhat", 50));
			ValidationRules.AddRule( CommonRules.StringMaxLength, 
				new CommonRules.MaxLengthRuleArgs("NguoiCapNhat", "Nguoi Cap Nhat", 50));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "LopChatLuongCao"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"MaLop", "NgayCapNhat", "NguoiCapNhat"};
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
	            this.backupData = this.entityData.Clone() as LopChatLuongCaoEntityData;
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
						this.parentCollection.Remove( (LopChatLuongCao) this ) ;
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
	            this.parentCollection = value as TList<LopChatLuongCao>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as LopChatLuongCao);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed LopChatLuongCao Entity 
		///</summary>
		protected virtual LopChatLuongCao Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			LopChatLuongCao copy = new LopChatLuongCao();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.MaLop = this.MaLop;
					copy.OriginalMaLop = this.OriginalMaLop;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed LopChatLuongCao Entity 
		///</summary>
		public virtual LopChatLuongCao Copy()
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
		///  Returns a Typed LopChatLuongCao Entity which is a deep copy of the current entity.
		///</summary>
		public virtual LopChatLuongCao DeepCopy()
		{
			return EntityHelper.Clone<LopChatLuongCao>(this as LopChatLuongCao);	
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
				this.entityData = this._originalData.Clone() as LopChatLuongCaoEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new LopChatLuongCaoEntityData();
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
			this._originalData = this.entityData.Clone() as LopChatLuongCaoEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(LopChatLuongCaoColumn column)
		{
			switch(column)
			{
					case LopChatLuongCaoColumn.MaLop:
					return entityData.MaLop != _originalData.MaLop;
					case LopChatLuongCaoColumn.NgayCapNhat:
					return entityData.NgayCapNhat != _originalData.NgayCapNhat;
					case LopChatLuongCaoColumn.NguoiCapNhat:
					return entityData.NguoiCapNhat != _originalData.NguoiCapNhat;
			
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
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< LopChatLuongCaoColumn >(columnName));
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
			result = result || entityData.MaLop != _originalData.MaLop;
			result = result || entityData.NgayCapNhat != _originalData.NgayCapNhat;
			result = result || entityData.NguoiCapNhat != _originalData.NguoiCapNhat;
			return result;
		}	
		
		///<summary>
		///  Returns a LopChatLuongCao Entity with the original data.
		///</summary>
		public LopChatLuongCao GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateLopChatLuongCao(
				_originalData.MaLop,
				_originalData.NgayCapNhat,
				_originalData.NguoiCapNhat
				);
				
			return (LopChatLuongCao)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="LopChatLuongCaoBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is LopChatLuongCaoBase)
				return ValueEquals(this, (LopChatLuongCaoBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="LopChatLuongCaoBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.MaLop.GetHashCode() ^ 
					((this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString()).GetHashCode() ^ 
					((this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="LopChatLuongCaoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(LopChatLuongCaoBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="LopChatLuongCaoBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="LopChatLuongCaoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="LopChatLuongCaoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(LopChatLuongCaoBase Object1, LopChatLuongCaoBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if ( Object1.NgayCapNhat != null && Object2.NgayCapNhat != null )
			{
				if (Object1.NgayCapNhat != Object2.NgayCapNhat)
					equal = false;
			}
			else if (Object1.NgayCapNhat == null ^ Object2.NgayCapNhat == null )
			{
				equal = false;
			}
			if ( Object1.NguoiCapNhat != null && Object2.NguoiCapNhat != null )
			{
				if (Object1.NguoiCapNhat != Object2.NguoiCapNhat)
					equal = false;
			}
			else if (Object1.NguoiCapNhat == null ^ Object2.NguoiCapNhat == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((LopChatLuongCaoBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static LopChatLuongCaoComparer GetComparer()
        {
            return new LopChatLuongCaoComparer();
        }
        */

        // Comparer delegates back to LopChatLuongCao
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
        public int CompareTo(LopChatLuongCao rhs, LopChatLuongCaoColumn which)
        {
            switch (which)
            {
            	
            	
            	case LopChatLuongCaoColumn.MaLop:
            		return this.MaLop.CompareTo(rhs.MaLop);
            		
            		                 
            	
            	
            	case LopChatLuongCaoColumn.NgayCapNhat:
            		return this.NgayCapNhat.CompareTo(rhs.NgayCapNhat);
            		
            		                 
            	
            	
            	case LopChatLuongCaoColumn.NguoiCapNhat:
            		return this.NguoiCapNhat.CompareTo(rhs.NguoiCapNhat);
            		
            		                 
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
				
		#region IEntityKey<LopChatLuongCaoKey> Members
		
		// member variable for the EntityId property
		private LopChatLuongCaoKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual LopChatLuongCaoKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new LopChatLuongCaoKey(this);
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
					entityTrackingKey = new System.Text.StringBuilder("LopChatLuongCao")
					.Append("|").Append( this.MaLop.ToString()).ToString();
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
				"{4}{3}- MaLop: {0}{3}- NgayCapNhat: {1}{3}- NguoiCapNhat: {2}{3}{5}", 
				this.MaLop,
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'LopChatLuongCao' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class LopChatLuongCaoEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// MaLop : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "LopChatLuongCao"</remarks>
		public System.String MaLop;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalMaLop;
		
		#endregion
		
		#region Non Primary key(s)
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		public System.String NgayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		public System.String NguoiCapNhat = null;
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
			LopChatLuongCaoEntityData _tmp = new LopChatLuongCaoEntityData();
						
			_tmp.MaLop = this.MaLop;
			_tmp.OriginalMaLop = this.OriginalMaLop;
			
			_tmp.NgayCapNhat = this.NgayCapNhat;
			_tmp.NguoiCapNhat = this.NguoiCapNhat;
			
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
				
			LopChatLuongCaoEntityData _tmp = new LopChatLuongCaoEntityData();
						
			_tmp.MaLop = this.MaLop;
			_tmp.OriginalMaLop = this.OriginalMaLop;
			
			_tmp.NgayCapNhat = this.NgayCapNhat;
			_tmp.NguoiCapNhat = this.NguoiCapNhat;
			
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
		/// <param name="column">The <see cref="LopChatLuongCaoColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(LopChatLuongCaoColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="LopChatLuongCaoColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(LopChatLuongCaoColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="LopChatLuongCaoColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(LopChatLuongCaoColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
                EntityManager.StopTracking(entityTrackingKey);
                
			if (!SuppressEntityEvents)
			{
				LopChatLuongCaoEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new LopChatLuongCaoEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="LopChatLuongCaoColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(LopChatLuongCaoColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				LopChatLuongCaoEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new LopChatLuongCaoEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region LopChatLuongCaoEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="LopChatLuongCao"/> object.
	/// </remarks>
	public class LopChatLuongCaoEventArgs : System.EventArgs
	{
		private LopChatLuongCaoColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the LopChatLuongCaoEventArgs class.
		///</summary>
		public LopChatLuongCaoEventArgs(LopChatLuongCaoColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the LopChatLuongCaoEventArgs class.
		///</summary>
		public LopChatLuongCaoEventArgs(LopChatLuongCaoColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The LopChatLuongCaoColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="LopChatLuongCaoColumn" />
		public LopChatLuongCaoColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all LopChatLuongCao related events.
	///</summary>
	public delegate void LopChatLuongCaoEventHandler(object sender, LopChatLuongCaoEventArgs e);
	
	#region LopChatLuongCaoComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class LopChatLuongCaoComparer : System.Collections.Generic.IComparer<LopChatLuongCao>
	{
		LopChatLuongCaoColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:LopChatLuongCaoComparer"/> class.
        /// </summary>
		public LopChatLuongCaoComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:LopChatLuongCaoComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public LopChatLuongCaoComparer(LopChatLuongCaoColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <see cref="LopChatLuongCao"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <see cref="LopChatLuongCao"/> to compare.</param>
        /// <param name="b">The second <c>LopChatLuongCao</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(LopChatLuongCao a, LopChatLuongCao b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(LopChatLuongCao entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(LopChatLuongCao a, LopChatLuongCao b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public LopChatLuongCaoColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region LopChatLuongCaoKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="LopChatLuongCao"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class LopChatLuongCaoKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoKey class.
		/// </summary>
		public LopChatLuongCaoKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoKey class.
		/// </summary>
		public LopChatLuongCaoKey(LopChatLuongCaoBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.MaLop = entity.MaLop;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the LopChatLuongCaoKey class.
		/// </summary>
		public LopChatLuongCaoKey(System.String _maLop)
		{
			#region Init Properties

			this.MaLop = _maLop;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private LopChatLuongCaoBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public LopChatLuongCaoBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the MaLop property
		private System.String _maLop;
		
		/// <summary>
		/// Gets or sets the MaLop property.
		/// </summary>
		public System.String MaLop
		{
			get { return _maLop; }
			set
			{
				if ( this.Entity != null )
					this.Entity.MaLop = value;
				
				_maLop = value;
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
				MaLop = ( values["MaLop"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String)) : string.Empty;
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

			values.Add("MaLop", MaLop);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("MaLop: {0}{1}",
								MaLop,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region LopChatLuongCaoColumn Enum
	
	/// <summary>
	/// Enumerate the LopChatLuongCao columns.
	/// </summary>
	[Serializable]
	public enum LopChatLuongCaoColumn : int
	{
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("Ma Lop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.String, true, false, false, 50)]
		MaLop = 1,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("Ngay Cap Nhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NgayCapNhat = 2,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("Nguoi Cap Nhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat = 3
	}//End enum

	#endregion LopChatLuongCaoColumn Enum

} // end namespace
