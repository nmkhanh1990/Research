﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewMonThucTapTotNghiep.cs instead.
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
	/// An object representation of the 'View_MonThucTapTotNghiep' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewMonThucTapTotNghiepBase")]
	public abstract partial class ViewMonThucTapTotNghiepBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = string.Empty;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = string.Empty;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = null;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// Stc : 
		/// </summary>
		private System.Decimal		  _stc = 0.0m;
		
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		private System.String		  _maKhoa = string.Empty;
		
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		private System.String		  _tenKhoa = string.Empty;
		
		/// <summary>
		/// SoTuan : 
		/// </summary>
		private System.Int32?		  _soTuan = null;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.DateTime?		  _ngayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		private System.String		  _nguoiCapNhat = null;
		
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
		/// Creates a new <see cref="ViewMonThucTapTotNghiepBase"/> instance.
		///</summary>
		public ViewMonThucTapTotNghiepBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewMonThucTapTotNghiepBase"/> instance.
		///</summary>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_stc"></param>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_soTuan"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public ViewMonThucTapTotNghiepBase(System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal _stc, System.String _maKhoa, System.String _tenKhoa, System.Int32? _soTuan, System.DateTime? _ngayCapNhat, System.String _nguoiCapNhat)
		{
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._stc = _stc;
			this._maKhoa = _maKhoa;
			this._tenKhoa = _tenKhoa;
			this._soTuan = _soTuan;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewMonThucTapTotNghiep"/> instance.
		///</summary>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_stc"></param>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_soTuan"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static ViewMonThucTapTotNghiep CreateViewMonThucTapTotNghiep(System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal _stc, System.String _maKhoa, System.String _tenKhoa, System.Int32? _soTuan, System.DateTime? _ngayCapNhat, System.String _nguoiCapNhat)
		{
			ViewMonThucTapTotNghiep newViewMonThucTapTotNghiep = new ViewMonThucTapTotNghiep();
			newViewMonThucTapTotNghiep.NamHoc = _namHoc;
			newViewMonThucTapTotNghiep.HocKy = _hocKy;
			newViewMonThucTapTotNghiep.MaMonHoc = _maMonHoc;
			newViewMonThucTapTotNghiep.TenMonHoc = _tenMonHoc;
			newViewMonThucTapTotNghiep.Stc = _stc;
			newViewMonThucTapTotNghiep.MaKhoa = _maKhoa;
			newViewMonThucTapTotNghiep.TenKhoa = _tenKhoa;
			newViewMonThucTapTotNghiep.SoTuan = _soTuan;
			newViewMonThucTapTotNghiep.NgayCapNhat = _ngayCapNhat;
			newViewMonThucTapTotNghiep.NguoiCapNhat = _nguoiCapNhat;
			return newViewMonThucTapTotNghiep;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NamHoc
		{
			get
			{
				return this._namHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "NamHoc does not allow null values.");
				if (_namHoc == value)
					return;
					
				this._namHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NamHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HocKy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HocKy
		{
			get
			{
				return this._hocKy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "HocKy does not allow null values.");
				if (_hocKy == value)
					return;
					
				this._hocKy = value;
				this._isDirty = true;
				
				OnPropertyChanged("HocKy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaMonHoc
		{
			get
			{
				return this._maMonHoc; 
			}
			set
			{
				if (_maMonHoc == value)
					return;
					
				this._maMonHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaMonHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenMonHoc
		{
			get
			{
				return this._tenMonHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenMonHoc does not allow null values.");
				if (_tenMonHoc == value)
					return;
					
				this._tenMonHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenMonHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Stc property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal Stc
		{
			get
			{
				return this._stc; 
			}
			set
			{
				if (_stc == value)
					return;
					
				this._stc = value;
				this._isDirty = true;
				
				OnPropertyChanged("Stc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaKhoa property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaKhoa
		{
			get
			{
				return this._maKhoa; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaKhoa does not allow null values.");
				if (_maKhoa == value)
					return;
					
				this._maKhoa = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKhoa");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenKhoa property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenKhoa
		{
			get
			{
				return this._tenKhoa; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenKhoa does not allow null values.");
				if (_tenKhoa == value)
					return;
					
				this._tenKhoa = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenKhoa");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTuan property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSoTuanNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SoTuan
		{
			get
			{
				return this._soTuan; 
			}
			set
			{
				if (_soTuan == value && SoTuan != null )
					return;
					
				this._soTuan = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTuan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayCapNhatNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayCapNhat
		{
			get
			{
				return this._ngayCapNhat; 
			}
			set
			{
				if (_ngayCapNhat == value && NgayCapNhat != null )
					return;
					
				this._ngayCapNhat = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayCapNhat");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NguoiCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NguoiCapNhat
		{
			get
			{
				return this._nguoiCapNhat; 
			}
			set
			{
				if (_nguoiCapNhat == value)
					return;
					
				this._nguoiCapNhat = value;
				this._isDirty = true;
				
				OnPropertyChanged("NguoiCapNhat");
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
			get { return "View_MonThucTapTotNghiep"; }
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
		///  Returns a Typed ViewMonThucTapTotNghiepBase Entity 
		///</summary>
		public virtual ViewMonThucTapTotNghiepBase Copy()
		{
			//shallow copy entity
			ViewMonThucTapTotNghiep copy = new ViewMonThucTapTotNghiep();
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.Stc = this.Stc;
				copy.MaKhoa = this.MaKhoa;
				copy.TenKhoa = this.TenKhoa;
				copy.SoTuan = this.SoTuan;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
			copy.AcceptChanges();
			return (ViewMonThucTapTotNghiep)copy;
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
		///<returns>true if toObject is a <see cref="ViewMonThucTapTotNghiepBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewMonThucTapTotNghiepBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewMonThucTapTotNghiepBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewMonThucTapTotNghiepBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewMonThucTapTotNghiepBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewMonThucTapTotNghiepBase Object1, ViewMonThucTapTotNghiepBase Object2)
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
			if (Object1.HocKy != Object2.HocKy)
				equal = false;
			if (Object1.MaMonHoc != null && Object2.MaMonHoc != null )
			{
				if (Object1.MaMonHoc != Object2.MaMonHoc)
					equal = false;
			}
			else if (Object1.MaMonHoc == null ^ Object1.MaMonHoc == null )
			{
				equal = false;
			}
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.Stc != Object2.Stc)
				equal = false;
			if (Object1.MaKhoa != Object2.MaKhoa)
				equal = false;
			if (Object1.TenKhoa != Object2.TenKhoa)
				equal = false;
			if (Object1.SoTuan != null && Object2.SoTuan != null )
			{
				if (Object1.SoTuan != Object2.SoTuan)
					equal = false;
			}
			else if (Object1.SoTuan == null ^ Object1.SoTuan == null )
			{
				equal = false;
			}
			if (Object1.NgayCapNhat != null && Object2.NgayCapNhat != null )
			{
				if (Object1.NgayCapNhat != Object2.NgayCapNhat)
					equal = false;
			}
			else if (Object1.NgayCapNhat == null ^ Object1.NgayCapNhat == null )
			{
				equal = false;
			}
			if (Object1.NguoiCapNhat != null && Object2.NguoiCapNhat != null )
			{
				if (Object1.NguoiCapNhat != Object2.NguoiCapNhat)
					equal = false;
			}
			else if (Object1.NguoiCapNhat == null ^ Object1.NguoiCapNhat == null )
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
		public static object GetPropertyValueByName(ViewMonThucTapTotNghiep entity, string propertyName)
		{
			switch (propertyName)
			{
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "Stc":
					return entity.Stc;
				case "MaKhoa":
					return entity.MaKhoa;
				case "TenKhoa":
					return entity.TenKhoa;
				case "SoTuan":
					return entity.SoTuan;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "NguoiCapNhat":
					return entity.NguoiCapNhat;
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
			return GetPropertyValueByName(this as ViewMonThucTapTotNghiep, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{11}{10}- NamHoc: {0}{10}- HocKy: {1}{10}- MaMonHoc: {2}{10}- TenMonHoc: {3}{10}- Stc: {4}{10}- MaKhoa: {5}{10}- TenKhoa: {6}{10}- SoTuan: {7}{10}- NgayCapNhat: {8}{10}- NguoiCapNhat: {9}{10}", 
				this.NamHoc,
				this.HocKy,
				(this.MaMonHoc == null) ? string.Empty : this.MaMonHoc.ToString(),
			     
				this.TenMonHoc,
				this.Stc,
				this.MaKhoa,
				this.TenKhoa,
				(this.SoTuan == null) ? string.Empty : this.SoTuan.ToString(),
			     
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewMonThucTapTotNghiep columns.
	/// </summary>
	[Serializable]
	public enum ViewMonThucTapTotNghiepColumn
	{
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		NamHoc,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		HocKy,
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		[EnumTextValue("MaMonHoc")]
		[ColumnEnum("MaMonHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaMonHoc,
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		[EnumTextValue("TenMonHoc")]
		[ColumnEnum("TenMonHoc", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenMonHoc,
		/// <summary>
		/// Stc : 
		/// </summary>
		[EnumTextValue("Stc")]
		[ColumnEnum("Stc", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		Stc,
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		[EnumTextValue("MaKhoa")]
		[ColumnEnum("MaKhoa", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaKhoa,
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		[EnumTextValue("TenKhoa")]
		[ColumnEnum("TenKhoa", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenKhoa,
		/// <summary>
		/// SoTuan : 
		/// </summary>
		[EnumTextValue("SoTuan")]
		[ColumnEnum("SoTuan", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SoTuan,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayCapNhat,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("NguoiCapNhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat
	}//End enum

} // end namespace
