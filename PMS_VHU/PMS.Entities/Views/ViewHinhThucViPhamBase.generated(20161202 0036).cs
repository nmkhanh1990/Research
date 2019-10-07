﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewHinhThucViPham.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace PMS.Entities
{
	///<summary>
	/// An object representation of the 'view_HinhThucViPham' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewHinhThucViPhamBase")]
	public abstract partial class ViewHinhThucViPhamBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// Oid : 
		/// </summary>
		private System.Guid		  _oid = Guid.Empty;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = null;
		
		/// <summary>
		/// TenHinhThucViPham : 
		/// </summary>
		private System.String		  _tenHinhThucViPham = null;
		
		/// <summary>
		/// OptimisticLockField : 
		/// </summary>
		private System.Int32?		  _optimisticLockField = null;
		
		/// <summary>
		/// GCRecord : 
		/// </summary>
		private System.Int32?		  _gcRecord = null;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewHinhThucViPhamBase"/> instance.
		///</summary>
		public ViewHinhThucViPhamBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewHinhThucViPhamBase"/> instance.
		///</summary>
		///<param name="_oid"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_tenHinhThucViPham"></param>
		///<param name="_optimisticLockField"></param>
		///<param name="_gcRecord"></param>
		public ViewHinhThucViPhamBase(System.Guid _oid, System.String _maQuanLy, System.String _tenHinhThucViPham, System.Int32? _optimisticLockField, System.Int32? _gcRecord)
		{
			this._oid = _oid;
			this._maQuanLy = _maQuanLy;
			this._tenHinhThucViPham = _tenHinhThucViPham;
			this._optimisticLockField = _optimisticLockField;
			this._gcRecord = _gcRecord;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewHinhThucViPham"/> instance.
		///</summary>
		///<param name="_oid"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_tenHinhThucViPham"></param>
		///<param name="_optimisticLockField"></param>
		///<param name="_gcRecord"></param>
		public static ViewHinhThucViPham CreateViewHinhThucViPham(System.Guid _oid, System.String _maQuanLy, System.String _tenHinhThucViPham, System.Int32? _optimisticLockField, System.Int32? _gcRecord)
		{
			ViewHinhThucViPham newViewHinhThucViPham = new ViewHinhThucViPham();
			newViewHinhThucViPham.Oid = _oid;
			newViewHinhThucViPham.MaQuanLy = _maQuanLy;
			newViewHinhThucViPham.TenHinhThucViPham = _tenHinhThucViPham;
			newViewHinhThucViPham.OptimisticLockField = _optimisticLockField;
			newViewHinhThucViPham.GcRecord = _gcRecord;
			return newViewHinhThucViPham;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the Oid property. 
		///		
		/// </summary>
		/// <value>This type is uniqueidentifier</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Guid Oid
		{
			get
			{
				return this._oid; 
			}
			set
			{
				if (_oid == value)
					return;
					
				this._oid = value;
				this._isDirty = true;
				
				OnPropertyChanged("Oid");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaQuanLy
		{
			get
			{
				return this._maQuanLy; 
			}
			set
			{
				if (_maQuanLy == value)
					return;
					
				this._maQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaQuanLy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHinhThucViPham property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHinhThucViPham
		{
			get
			{
				return this._tenHinhThucViPham; 
			}
			set
			{
				if (_tenHinhThucViPham == value)
					return;
					
				this._tenHinhThucViPham = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHinhThucViPham");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the OptimisticLockField property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsOptimisticLockFieldNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? OptimisticLockField
		{
			get
			{
				return this._optimisticLockField; 
			}
			set
			{
				if (_optimisticLockField == value && OptimisticLockField != null )
					return;
					
				this._optimisticLockField = value;
				this._isDirty = true;
				
				OnPropertyChanged("OptimisticLockField");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GCRecord property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsGcRecordNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? GcRecord
		{
			get
			{
				return this._gcRecord; 
			}
			set
			{
				if (_gcRecord == value && GcRecord != null )
					return;
					
				this._gcRecord = value;
				this._isDirty = true;
				
				OnPropertyChanged("GcRecord");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "view_HinhThucViPham"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed ViewHinhThucViPhamBase Entity 
		///</summary>
		public virtual ViewHinhThucViPhamBase Copy()
		{
			//shallow copy entity
			ViewHinhThucViPham copy = new ViewHinhThucViPham();
				copy.Oid = this.Oid;
				copy.MaQuanLy = this.MaQuanLy;
				copy.TenHinhThucViPham = this.TenHinhThucViPham;
				copy.OptimisticLockField = this.OptimisticLockField;
				copy.GcRecord = this.GcRecord;
			copy.AcceptChanges();
			return (ViewHinhThucViPham)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="ViewHinhThucViPhamBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewHinhThucViPhamBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewHinhThucViPhamBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewHinhThucViPhamBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewHinhThucViPhamBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewHinhThucViPhamBase Object1, ViewHinhThucViPhamBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.Oid != Object2.Oid)
				equal = false;
			if (Object1.MaQuanLy != null && Object2.MaQuanLy != null )
			{
				if (Object1.MaQuanLy != Object2.MaQuanLy)
					equal = false;
			}
			else if (Object1.MaQuanLy == null ^ Object1.MaQuanLy == null )
			{
				equal = false;
			}
			if (Object1.TenHinhThucViPham != null && Object2.TenHinhThucViPham != null )
			{
				if (Object1.TenHinhThucViPham != Object2.TenHinhThucViPham)
					equal = false;
			}
			else if (Object1.TenHinhThucViPham == null ^ Object1.TenHinhThucViPham == null )
			{
				equal = false;
			}
			if (Object1.OptimisticLockField != null && Object2.OptimisticLockField != null )
			{
				if (Object1.OptimisticLockField != Object2.OptimisticLockField)
					equal = false;
			}
			else if (Object1.OptimisticLockField == null ^ Object1.OptimisticLockField == null )
			{
				equal = false;
			}
			if (Object1.GcRecord != null && Object2.GcRecord != null )
			{
				if (Object1.GcRecord != Object2.GcRecord)
					equal = false;
			}
			else if (Object1.GcRecord == null ^ Object1.GcRecord == null )
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
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(ViewHinhThucViPham entity, string propertyName)
		{
			switch (propertyName)
			{
				case "Oid":
					return entity.Oid;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "TenHinhThucViPham":
					return entity.TenHinhThucViPham;
				case "OptimisticLockField":
					return entity.OptimisticLockField;
				case "GcRecord":
					return entity.GcRecord;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as ViewHinhThucViPham, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{6}{5}- Oid: {0}{5}- MaQuanLy: {1}{5}- TenHinhThucViPham: {2}{5}- OptimisticLockField: {3}{5}- GcRecord: {4}{5}", 
				this.Oid,
				(this.MaQuanLy == null) ? string.Empty : this.MaQuanLy.ToString(),
			     
				(this.TenHinhThucViPham == null) ? string.Empty : this.TenHinhThucViPham.ToString(),
			     
				(this.OptimisticLockField == null) ? string.Empty : this.OptimisticLockField.ToString(),
			     
				(this.GcRecord == null) ? string.Empty : this.GcRecord.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewHinhThucViPham columns.
	/// </summary>
	[Serializable]
	public enum ViewHinhThucViPhamColumn
	{
		/// <summary>
		/// Oid : 
		/// </summary>
		[EnumTextValue("Oid")]
		[ColumnEnum("Oid", typeof(System.Guid), System.Data.DbType.Guid, false, false, false)]
		Oid,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("MaQuanLy")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		MaQuanLy,
		/// <summary>
		/// TenHinhThucViPham : 
		/// </summary>
		[EnumTextValue("TenHinhThucViPham")]
		[ColumnEnum("TenHinhThucViPham", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenHinhThucViPham,
		/// <summary>
		/// OptimisticLockField : 
		/// </summary>
		[EnumTextValue("OptimisticLockField")]
		[ColumnEnum("OptimisticLockField", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		OptimisticLockField,
		/// <summary>
		/// GCRecord : 
		/// </summary>
		[EnumTextValue("GCRecord")]
		[ColumnEnum("GCRecord", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		GcRecord
	}//End enum

} // end namespace