﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewSinhVienLop.cs instead.
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
	/// An object representation of the 'View_SinhVien_Lop' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewSinhVienLopBase")]
	public abstract partial class ViewSinhVienLopBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaSinhVien : 
		/// </summary>
		private System.String		  _maSinhVien = string.Empty;
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// GioiTinh : 
		/// </summary>
		private System.String		  _gioiTinh = null;
		
		/// <summary>
		/// NgaySinh : 
		/// </summary>
		private System.String		  _ngaySinh = null;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = string.Empty;
		
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		private System.String		  _maKhoa = string.Empty;
		
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
		/// Creates a new <see cref="ViewSinhVienLopBase"/> instance.
		///</summary>
		public ViewSinhVienLopBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewSinhVienLopBase"/> instance.
		///</summary>
		///<param name="_maSinhVien"></param>
		///<param name="_hoTen"></param>
		///<param name="_gioiTinh"></param>
		///<param name="_ngaySinh"></param>
		///<param name="_maLop"></param>
		///<param name="_maKhoa"></param>
		public ViewSinhVienLopBase(System.String _maSinhVien, System.String _hoTen, System.String _gioiTinh, System.String _ngaySinh, System.String _maLop, System.String _maKhoa)
		{
			this._maSinhVien = _maSinhVien;
			this._hoTen = _hoTen;
			this._gioiTinh = _gioiTinh;
			this._ngaySinh = _ngaySinh;
			this._maLop = _maLop;
			this._maKhoa = _maKhoa;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewSinhVienLop"/> instance.
		///</summary>
		///<param name="_maSinhVien"></param>
		///<param name="_hoTen"></param>
		///<param name="_gioiTinh"></param>
		///<param name="_ngaySinh"></param>
		///<param name="_maLop"></param>
		///<param name="_maKhoa"></param>
		public static ViewSinhVienLop CreateViewSinhVienLop(System.String _maSinhVien, System.String _hoTen, System.String _gioiTinh, System.String _ngaySinh, System.String _maLop, System.String _maKhoa)
		{
			ViewSinhVienLop newViewSinhVienLop = new ViewSinhVienLop();
			newViewSinhVienLop.MaSinhVien = _maSinhVien;
			newViewSinhVienLop.HoTen = _hoTen;
			newViewSinhVienLop.GioiTinh = _gioiTinh;
			newViewSinhVienLop.NgaySinh = _ngaySinh;
			newViewSinhVienLop.MaLop = _maLop;
			newViewSinhVienLop.MaKhoa = _maKhoa;
			return newViewSinhVienLop;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaSinhVien property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaSinhVien
		{
			get
			{
				return this._maSinhVien; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaSinhVien does not allow null values.");
				if (_maSinhVien == value)
					return;
					
				this._maSinhVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaSinhVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HoTen property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HoTen
		{
			get
			{
				return this._hoTen; 
			}
			set
			{
				if (_hoTen == value)
					return;
					
				this._hoTen = value;
				this._isDirty = true;
				
				OnPropertyChanged("HoTen");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GioiTinh property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String GioiTinh
		{
			get
			{
				return this._gioiTinh; 
			}
			set
			{
				if (_gioiTinh == value)
					return;
					
				this._gioiTinh = value;
				this._isDirty = true;
				
				OnPropertyChanged("GioiTinh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgaySinh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NgaySinh
		{
			get
			{
				return this._ngaySinh; 
			}
			set
			{
				if (_ngaySinh == value)
					return;
					
				this._ngaySinh = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgaySinh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLop
		{
			get
			{
				return this._maLop; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaLop does not allow null values.");
				if (_maLop == value)
					return;
					
				this._maLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLop");
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
			get { return "View_SinhVien_Lop"; }
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
		///  Returns a Typed ViewSinhVienLopBase Entity 
		///</summary>
		public virtual ViewSinhVienLopBase Copy()
		{
			//shallow copy entity
			ViewSinhVienLop copy = new ViewSinhVienLop();
				copy.MaSinhVien = this.MaSinhVien;
				copy.HoTen = this.HoTen;
				copy.GioiTinh = this.GioiTinh;
				copy.NgaySinh = this.NgaySinh;
				copy.MaLop = this.MaLop;
				copy.MaKhoa = this.MaKhoa;
			copy.AcceptChanges();
			return (ViewSinhVienLop)copy;
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
		///<returns>true if toObject is a <see cref="ViewSinhVienLopBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewSinhVienLopBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewSinhVienLopBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewSinhVienLopBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewSinhVienLopBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewSinhVienLopBase Object1, ViewSinhVienLopBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaSinhVien != Object2.MaSinhVien)
				equal = false;
			if (Object1.HoTen != null && Object2.HoTen != null )
			{
				if (Object1.HoTen != Object2.HoTen)
					equal = false;
			}
			else if (Object1.HoTen == null ^ Object1.HoTen == null )
			{
				equal = false;
			}
			if (Object1.GioiTinh != null && Object2.GioiTinh != null )
			{
				if (Object1.GioiTinh != Object2.GioiTinh)
					equal = false;
			}
			else if (Object1.GioiTinh == null ^ Object1.GioiTinh == null )
			{
				equal = false;
			}
			if (Object1.NgaySinh != null && Object2.NgaySinh != null )
			{
				if (Object1.NgaySinh != Object2.NgaySinh)
					equal = false;
			}
			else if (Object1.NgaySinh == null ^ Object1.NgaySinh == null )
			{
				equal = false;
			}
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if (Object1.MaKhoa != Object2.MaKhoa)
				equal = false;
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
		public static object GetPropertyValueByName(ViewSinhVienLop entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaSinhVien":
					return entity.MaSinhVien;
				case "HoTen":
					return entity.HoTen;
				case "GioiTinh":
					return entity.GioiTinh;
				case "NgaySinh":
					return entity.NgaySinh;
				case "MaLop":
					return entity.MaLop;
				case "MaKhoa":
					return entity.MaKhoa;
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
			return GetPropertyValueByName(this as ViewSinhVienLop, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{7}{6}- MaSinhVien: {0}{6}- HoTen: {1}{6}- GioiTinh: {2}{6}- NgaySinh: {3}{6}- MaLop: {4}{6}- MaKhoa: {5}{6}", 
				this.MaSinhVien,
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.GioiTinh == null) ? string.Empty : this.GioiTinh.ToString(),
			     
				(this.NgaySinh == null) ? string.Empty : this.NgaySinh.ToString(),
			     
				this.MaLop,
				this.MaKhoa,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewSinhVienLop columns.
	/// </summary>
	[Serializable]
	public enum ViewSinhVienLopColumn
	{
		/// <summary>
		/// MaSinhVien : 
		/// </summary>
		[EnumTextValue("MaSinhVien")]
		[ColumnEnum("MaSinhVien", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaSinhVien,
		/// <summary>
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 302)]
		HoTen,
		/// <summary>
		/// GioiTinh : 
		/// </summary>
		[EnumTextValue("GioiTinh")]
		[ColumnEnum("GioiTinh", typeof(System.String), System.Data.DbType.String, false, false, true, 3)]
		GioiTinh,
		/// <summary>
		/// NgaySinh : 
		/// </summary>
		[EnumTextValue("NgaySinh")]
		[ColumnEnum("NgaySinh", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NgaySinh,
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLop,
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		[EnumTextValue("MaKhoa")]
		[ColumnEnum("MaKhoa", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaKhoa
	}//End enum

} // end namespace
