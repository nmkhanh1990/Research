﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewLopHocPhanChuyenNganh.cs instead.
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
	/// An object representation of the 'View_LopHocPhanChuyenNganh' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewLopHocPhanChuyenNganhBase")]
	public abstract partial class ViewLopHocPhanChuyenNganhBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = string.Empty;
		
		/// <summary>
		/// TenLopHocPhan : 
		/// </summary>
		private System.String		  _tenLopHocPhan = null;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = string.Empty;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = string.Empty;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = string.Empty;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = null;
		
		/// <summary>
		/// SiSo : 
		/// </summary>
		private System.Int32?		  _siSo = null;
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		private System.Byte		  _maLoaiHocPhan = (byte)0;
		
		/// <summary>
		/// TenLoaiHocPhan : 
		/// </summary>
		private System.String		  _tenLoaiHocPhan = null;
		
		/// <summary>
		/// Nhom : 
		/// </summary>
		private System.String		  _nhom = null;
		
		/// <summary>
		/// TrangThai : 
		/// </summary>
		private System.Boolean?		  _trangThai = null;
		
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
		/// Creates a new <see cref="ViewLopHocPhanChuyenNganhBase"/> instance.
		///</summary>
		public ViewLopHocPhanChuyenNganhBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewLopHocPhanChuyenNganhBase"/> instance.
		///</summary>
		///<param name="_maLopHocPhan"></param>
		///<param name="_tenLopHocPhan"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maLop"></param>
		///<param name="_siSo"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_nhom"></param>
		///<param name="_trangThai"></param>
		public ViewLopHocPhanChuyenNganhBase(System.String _maLopHocPhan, System.String _tenLopHocPhan, System.String _maMonHoc, System.String _tenMonHoc, System.String _namHoc, System.String _hocKy, System.String _maLop, System.Int32? _siSo, System.Byte _maLoaiHocPhan, System.String _tenLoaiHocPhan, System.String _nhom, System.Boolean? _trangThai)
		{
			this._maLopHocPhan = _maLopHocPhan;
			this._tenLopHocPhan = _tenLopHocPhan;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._maLop = _maLop;
			this._siSo = _siSo;
			this._maLoaiHocPhan = _maLoaiHocPhan;
			this._tenLoaiHocPhan = _tenLoaiHocPhan;
			this._nhom = _nhom;
			this._trangThai = _trangThai;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLopHocPhanChuyenNganh"/> instance.
		///</summary>
		///<param name="_maLopHocPhan"></param>
		///<param name="_tenLopHocPhan"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maLop"></param>
		///<param name="_siSo"></param>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_nhom"></param>
		///<param name="_trangThai"></param>
		public static ViewLopHocPhanChuyenNganh CreateViewLopHocPhanChuyenNganh(System.String _maLopHocPhan, System.String _tenLopHocPhan, System.String _maMonHoc, System.String _tenMonHoc, System.String _namHoc, System.String _hocKy, System.String _maLop, System.Int32? _siSo, System.Byte _maLoaiHocPhan, System.String _tenLoaiHocPhan, System.String _nhom, System.Boolean? _trangThai)
		{
			ViewLopHocPhanChuyenNganh newViewLopHocPhanChuyenNganh = new ViewLopHocPhanChuyenNganh();
			newViewLopHocPhanChuyenNganh.MaLopHocPhan = _maLopHocPhan;
			newViewLopHocPhanChuyenNganh.TenLopHocPhan = _tenLopHocPhan;
			newViewLopHocPhanChuyenNganh.MaMonHoc = _maMonHoc;
			newViewLopHocPhanChuyenNganh.TenMonHoc = _tenMonHoc;
			newViewLopHocPhanChuyenNganh.NamHoc = _namHoc;
			newViewLopHocPhanChuyenNganh.HocKy = _hocKy;
			newViewLopHocPhanChuyenNganh.MaLop = _maLop;
			newViewLopHocPhanChuyenNganh.SiSo = _siSo;
			newViewLopHocPhanChuyenNganh.MaLoaiHocPhan = _maLoaiHocPhan;
			newViewLopHocPhanChuyenNganh.TenLoaiHocPhan = _tenLoaiHocPhan;
			newViewLopHocPhanChuyenNganh.Nhom = _nhom;
			newViewLopHocPhanChuyenNganh.TrangThai = _trangThai;
			return newViewLopHocPhanChuyenNganh;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaLopHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLopHocPhan
		{
			get
			{
				return this._maLopHocPhan; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaLopHocPhan does not allow null values.");
				if (_maLopHocPhan == value)
					return;
					
				this._maLopHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLopHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLopHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLopHocPhan
		{
			get
			{
				return this._tenLopHocPhan; 
			}
			set
			{
				if (_tenLopHocPhan == value)
					return;
					
				this._tenLopHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLopHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaMonHoc
		{
			get
			{
				return this._maMonHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaMonHoc does not allow null values.");
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
		/// 	Gets or Sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLop
		{
			get
			{
				return this._maLop; 
			}
			set
			{
				if (_maLop == value)
					return;
					
				this._maLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SiSo property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSiSoNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SiSo
		{
			get
			{
				return this._siSo; 
			}
			set
			{
				if (_siSo == value && SiSo != null )
					return;
					
				this._siSo = value;
				this._isDirty = true;
				
				OnPropertyChanged("SiSo");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLoaiHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is tinyint</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Byte MaLoaiHocPhan
		{
			get
			{
				return this._maLoaiHocPhan; 
			}
			set
			{
				if (_maLoaiHocPhan == value)
					return;
					
				this._maLoaiHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLoaiHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLoaiHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLoaiHocPhan
		{
			get
			{
				return this._tenLoaiHocPhan; 
			}
			set
			{
				if (_tenLoaiHocPhan == value)
					return;
					
				this._tenLoaiHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLoaiHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Nhom property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Nhom
		{
			get
			{
				return this._nhom; 
			}
			set
			{
				if (_nhom == value)
					return;
					
				this._nhom = value;
				this._isDirty = true;
				
				OnPropertyChanged("Nhom");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TrangThai property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsTrangThaiNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean? TrangThai
		{
			get
			{
				return this._trangThai; 
			}
			set
			{
				if (_trangThai == value && TrangThai != null )
					return;
					
				this._trangThai = value;
				this._isDirty = true;
				
				OnPropertyChanged("TrangThai");
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
			get { return "View_LopHocPhanChuyenNganh"; }
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
		///  Returns a Typed ViewLopHocPhanChuyenNganhBase Entity 
		///</summary>
		public virtual ViewLopHocPhanChuyenNganhBase Copy()
		{
			//shallow copy entity
			ViewLopHocPhanChuyenNganh copy = new ViewLopHocPhanChuyenNganh();
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.TenLopHocPhan = this.TenLopHocPhan;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.MaLop = this.MaLop;
				copy.SiSo = this.SiSo;
				copy.MaLoaiHocPhan = this.MaLoaiHocPhan;
				copy.TenLoaiHocPhan = this.TenLoaiHocPhan;
				copy.Nhom = this.Nhom;
				copy.TrangThai = this.TrangThai;
			copy.AcceptChanges();
			return (ViewLopHocPhanChuyenNganh)copy;
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
		///<returns>true if toObject is a <see cref="ViewLopHocPhanChuyenNganhBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewLopHocPhanChuyenNganhBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewLopHocPhanChuyenNganhBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewLopHocPhanChuyenNganhBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewLopHocPhanChuyenNganhBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewLopHocPhanChuyenNganhBase Object1, ViewLopHocPhanChuyenNganhBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
				equal = false;
			if (Object1.TenLopHocPhan != null && Object2.TenLopHocPhan != null )
			{
				if (Object1.TenLopHocPhan != Object2.TenLopHocPhan)
					equal = false;
			}
			else if (Object1.TenLopHocPhan == null ^ Object1.TenLopHocPhan == null )
			{
				equal = false;
			}
			if (Object1.MaMonHoc != Object2.MaMonHoc)
				equal = false;
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.NamHoc != Object2.NamHoc)
				equal = false;
			if (Object1.HocKy != Object2.HocKy)
				equal = false;
			if (Object1.MaLop != null && Object2.MaLop != null )
			{
				if (Object1.MaLop != Object2.MaLop)
					equal = false;
			}
			else if (Object1.MaLop == null ^ Object1.MaLop == null )
			{
				equal = false;
			}
			if (Object1.SiSo != null && Object2.SiSo != null )
			{
				if (Object1.SiSo != Object2.SiSo)
					equal = false;
			}
			else if (Object1.SiSo == null ^ Object1.SiSo == null )
			{
				equal = false;
			}
			if (Object1.MaLoaiHocPhan != Object2.MaLoaiHocPhan)
				equal = false;
			if (Object1.TenLoaiHocPhan != null && Object2.TenLoaiHocPhan != null )
			{
				if (Object1.TenLoaiHocPhan != Object2.TenLoaiHocPhan)
					equal = false;
			}
			else if (Object1.TenLoaiHocPhan == null ^ Object1.TenLoaiHocPhan == null )
			{
				equal = false;
			}
			if (Object1.Nhom != null && Object2.Nhom != null )
			{
				if (Object1.Nhom != Object2.Nhom)
					equal = false;
			}
			else if (Object1.Nhom == null ^ Object1.Nhom == null )
			{
				equal = false;
			}
			if (Object1.TrangThai != null && Object2.TrangThai != null )
			{
				if (Object1.TrangThai != Object2.TrangThai)
					equal = false;
			}
			else if (Object1.TrangThai == null ^ Object1.TrangThai == null )
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
		public static object GetPropertyValueByName(ViewLopHocPhanChuyenNganh entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "TenLopHocPhan":
					return entity.TenLopHocPhan;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "MaLop":
					return entity.MaLop;
				case "SiSo":
					return entity.SiSo;
				case "MaLoaiHocPhan":
					return entity.MaLoaiHocPhan;
				case "TenLoaiHocPhan":
					return entity.TenLoaiHocPhan;
				case "Nhom":
					return entity.Nhom;
				case "TrangThai":
					return entity.TrangThai;
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
			return GetPropertyValueByName(this as ViewLopHocPhanChuyenNganh, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{13}{12}- MaLopHocPhan: {0}{12}- TenLopHocPhan: {1}{12}- MaMonHoc: {2}{12}- TenMonHoc: {3}{12}- NamHoc: {4}{12}- HocKy: {5}{12}- MaLop: {6}{12}- SiSo: {7}{12}- MaLoaiHocPhan: {8}{12}- TenLoaiHocPhan: {9}{12}- Nhom: {10}{12}- TrangThai: {11}{12}", 
				this.MaLopHocPhan,
				(this.TenLopHocPhan == null) ? string.Empty : this.TenLopHocPhan.ToString(),
			     
				this.MaMonHoc,
				this.TenMonHoc,
				this.NamHoc,
				this.HocKy,
				(this.MaLop == null) ? string.Empty : this.MaLop.ToString(),
			     
				(this.SiSo == null) ? string.Empty : this.SiSo.ToString(),
			     
				this.MaLoaiHocPhan,
				(this.TenLoaiHocPhan == null) ? string.Empty : this.TenLoaiHocPhan.ToString(),
			     
				(this.Nhom == null) ? string.Empty : this.Nhom.ToString(),
			     
				(this.TrangThai == null) ? string.Empty : this.TrangThai.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewLopHocPhanChuyenNganh columns.
	/// </summary>
	[Serializable]
	public enum ViewLopHocPhanChuyenNganhColumn
	{
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 30)]
		MaLopHocPhan,
		/// <summary>
		/// TenLopHocPhan : 
		/// </summary>
		[EnumTextValue("TenLopHocPhan")]
		[ColumnEnum("TenLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 30)]
		TenLopHocPhan,
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		[EnumTextValue("MaMonHoc")]
		[ColumnEnum("MaMonHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaMonHoc,
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		[EnumTextValue("TenMonHoc")]
		[ColumnEnum("TenMonHoc", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenMonHoc,
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
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.String, false, false, true)]
		MaLop,
		/// <summary>
		/// SiSo : 
		/// </summary>
		[EnumTextValue("SiSo")]
		[ColumnEnum("SiSo", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSo,
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		[EnumTextValue("MaLoaiHocPhan")]
		[ColumnEnum("MaLoaiHocPhan", typeof(System.Byte), System.Data.DbType.Byte, false, false, false)]
		MaLoaiHocPhan,
		/// <summary>
		/// TenLoaiHocPhan : 
		/// </summary>
		[EnumTextValue("TenLoaiHocPhan")]
		[ColumnEnum("TenLoaiHocPhan", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenLoaiHocPhan,
		/// <summary>
		/// Nhom : 
		/// </summary>
		[EnumTextValue("Nhom")]
		[ColumnEnum("Nhom", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		Nhom,
		/// <summary>
		/// TrangThai : 
		/// </summary>
		[EnumTextValue("TrangThai")]
		[ColumnEnum("TrangThai", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		TrangThai
	}//End enum

} // end namespace