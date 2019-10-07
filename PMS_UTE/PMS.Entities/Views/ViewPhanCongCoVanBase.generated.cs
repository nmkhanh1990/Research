﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewPhanCongCoVan.cs instead.
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
	/// An object representation of the 'View_PhanCong_CoVan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewPhanCongCoVanBase")]
	public abstract partial class ViewPhanCongCoVanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		private System.String		  _maKhoa = null;
		
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		private System.String		  _tenKhoa = null;
		
		/// <summary>
		/// MaKhoaHoc : 
		/// </summary>
		private System.String		  _maKhoaHoc = string.Empty;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32?		  _maGiangVien = null;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = string.Empty;
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// ChucDanh : 
		/// </summary>
		private System.String		  _chucDanh = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		private System.String		  _maBacDaoTao = string.Empty;
		
		/// <summary>
		/// MaLoaiHinh : 
		/// </summary>
		private System.String		  _maLoaiHinh = string.Empty;
		
		/// <summary>
		/// MaBacLoaiHinh : 
		/// </summary>
		private System.String		  _maBacLoaiHinh = string.Empty;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = null;
		
		/// <summary>
		/// TenLop : 
		/// </summary>
		private System.String		  _tenLop = string.Empty;
		
		/// <summary>
		/// NgayTao : 
		/// </summary>
		private System.DateTime?		  _ngayTao = null;
		
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
		/// Creates a new <see cref="ViewPhanCongCoVanBase"/> instance.
		///</summary>
		public ViewPhanCongCoVanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewPhanCongCoVanBase"/> instance.
		///</summary>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_maKhoaHoc"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_chucDanh"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maLoaiHinh"></param>
		///<param name="_maBacLoaiHinh"></param>
		///<param name="_maLop"></param>
		///<param name="_tenLop"></param>
		///<param name="_ngayTao"></param>
		public ViewPhanCongCoVanBase(System.String _maKhoa, System.String _tenKhoa, System.String _maKhoaHoc, System.Int32? _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _chucDanh, System.String _namHoc, System.String _hocKy, System.String _maBacDaoTao, System.String _maLoaiHinh, System.String _maBacLoaiHinh, System.String _maLop, System.String _tenLop, System.DateTime? _ngayTao)
		{
			this._maKhoa = _maKhoa;
			this._tenKhoa = _tenKhoa;
			this._maKhoaHoc = _maKhoaHoc;
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._hoTen = _hoTen;
			this._chucDanh = _chucDanh;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._maBacDaoTao = _maBacDaoTao;
			this._maLoaiHinh = _maLoaiHinh;
			this._maBacLoaiHinh = _maBacLoaiHinh;
			this._maLop = _maLop;
			this._tenLop = _tenLop;
			this._ngayTao = _ngayTao;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewPhanCongCoVan"/> instance.
		///</summary>
		///<param name="_maKhoa"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_maKhoaHoc"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_chucDanh"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maLoaiHinh"></param>
		///<param name="_maBacLoaiHinh"></param>
		///<param name="_maLop"></param>
		///<param name="_tenLop"></param>
		///<param name="_ngayTao"></param>
		public static ViewPhanCongCoVan CreateViewPhanCongCoVan(System.String _maKhoa, System.String _tenKhoa, System.String _maKhoaHoc, System.Int32? _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _chucDanh, System.String _namHoc, System.String _hocKy, System.String _maBacDaoTao, System.String _maLoaiHinh, System.String _maBacLoaiHinh, System.String _maLop, System.String _tenLop, System.DateTime? _ngayTao)
		{
			ViewPhanCongCoVan newViewPhanCongCoVan = new ViewPhanCongCoVan();
			newViewPhanCongCoVan.MaKhoa = _maKhoa;
			newViewPhanCongCoVan.TenKhoa = _tenKhoa;
			newViewPhanCongCoVan.MaKhoaHoc = _maKhoaHoc;
			newViewPhanCongCoVan.MaGiangVien = _maGiangVien;
			newViewPhanCongCoVan.MaQuanLy = _maQuanLy;
			newViewPhanCongCoVan.HoTen = _hoTen;
			newViewPhanCongCoVan.ChucDanh = _chucDanh;
			newViewPhanCongCoVan.NamHoc = _namHoc;
			newViewPhanCongCoVan.HocKy = _hocKy;
			newViewPhanCongCoVan.MaBacDaoTao = _maBacDaoTao;
			newViewPhanCongCoVan.MaLoaiHinh = _maLoaiHinh;
			newViewPhanCongCoVan.MaBacLoaiHinh = _maBacLoaiHinh;
			newViewPhanCongCoVan.MaLop = _maLop;
			newViewPhanCongCoVan.TenLop = _tenLop;
			newViewPhanCongCoVan.NgayTao = _ngayTao;
			return newViewPhanCongCoVan;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaKhoa property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaKhoa
		{
			get
			{
				return this._maKhoa; 
			}
			set
			{
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
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenKhoa
		{
			get
			{
				return this._tenKhoa; 
			}
			set
			{
				if (_tenKhoa == value)
					return;
					
				this._tenKhoa = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenKhoa");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaKhoaHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaKhoaHoc
		{
			get
			{
				return this._maKhoaHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaKhoaHoc does not allow null values.");
				if (_maKhoaHoc == value)
					return;
					
				this._maKhoaHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKhoaHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaGiangVienNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if (_maGiangVien == value && MaGiangVien != null )
					return;
					
				this._maGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaQuanLy
		{
			get
			{
				return this._maQuanLy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaQuanLy does not allow null values.");
				if (_maQuanLy == value)
					return;
					
				this._maQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaQuanLy");
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
		/// 	Gets or Sets the ChucDanh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ChucDanh
		{
			get
			{
				return this._chucDanh; 
			}
			set
			{
				if (_chucDanh == value)
					return;
					
				this._chucDanh = value;
				this._isDirty = true;
				
				OnPropertyChanged("ChucDanh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NamHoc
		{
			get
			{
				return this._namHoc; 
			}
			set
			{
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
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HocKy
		{
			get
			{
				return this._hocKy; 
			}
			set
			{
				if (_hocKy == value)
					return;
					
				this._hocKy = value;
				this._isDirty = true;
				
				OnPropertyChanged("HocKy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaBacDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaBacDaoTao
		{
			get
			{
				return this._maBacDaoTao; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaBacDaoTao does not allow null values.");
				if (_maBacDaoTao == value)
					return;
					
				this._maBacDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaBacDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLoaiHinh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLoaiHinh
		{
			get
			{
				return this._maLoaiHinh; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaLoaiHinh does not allow null values.");
				if (_maLoaiHinh == value)
					return;
					
				this._maLoaiHinh = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLoaiHinh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaBacLoaiHinh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaBacLoaiHinh
		{
			get
			{
				return this._maBacLoaiHinh; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaBacLoaiHinh does not allow null values.");
				if (_maBacLoaiHinh == value)
					return;
					
				this._maBacLoaiHinh = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaBacLoaiHinh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
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
		/// 	Gets or Sets the TenLop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLop
		{
			get
			{
				return this._tenLop; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenLop does not allow null values.");
				if (_tenLop == value)
					return;
					
				this._tenLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayTao property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayTaoNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayTao
		{
			get
			{
				return this._ngayTao; 
			}
			set
			{
				if (_ngayTao == value && NgayTao != null )
					return;
					
				this._ngayTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayTao");
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
			get { return "View_PhanCong_CoVan"; }
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
		///  Returns a Typed ViewPhanCongCoVanBase Entity 
		///</summary>
		public virtual ViewPhanCongCoVanBase Copy()
		{
			//shallow copy entity
			ViewPhanCongCoVan copy = new ViewPhanCongCoVan();
				copy.MaKhoa = this.MaKhoa;
				copy.TenKhoa = this.TenKhoa;
				copy.MaKhoaHoc = this.MaKhoaHoc;
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.HoTen = this.HoTen;
				copy.ChucDanh = this.ChucDanh;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.MaLoaiHinh = this.MaLoaiHinh;
				copy.MaBacLoaiHinh = this.MaBacLoaiHinh;
				copy.MaLop = this.MaLop;
				copy.TenLop = this.TenLop;
				copy.NgayTao = this.NgayTao;
			copy.AcceptChanges();
			return (ViewPhanCongCoVan)copy;
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
		///<returns>true if toObject is a <see cref="ViewPhanCongCoVanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewPhanCongCoVanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewPhanCongCoVanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewPhanCongCoVanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewPhanCongCoVanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewPhanCongCoVanBase Object1, ViewPhanCongCoVanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaKhoa != null && Object2.MaKhoa != null )
			{
				if (Object1.MaKhoa != Object2.MaKhoa)
					equal = false;
			}
			else if (Object1.MaKhoa == null ^ Object1.MaKhoa == null )
			{
				equal = false;
			}
			if (Object1.TenKhoa != null && Object2.TenKhoa != null )
			{
				if (Object1.TenKhoa != Object2.TenKhoa)
					equal = false;
			}
			else if (Object1.TenKhoa == null ^ Object1.TenKhoa == null )
			{
				equal = false;
			}
			if (Object1.MaKhoaHoc != Object2.MaKhoaHoc)
				equal = false;
			if (Object1.MaGiangVien != null && Object2.MaGiangVien != null )
			{
				if (Object1.MaGiangVien != Object2.MaGiangVien)
					equal = false;
			}
			else if (Object1.MaGiangVien == null ^ Object1.MaGiangVien == null )
			{
				equal = false;
			}
			if (Object1.MaQuanLy != Object2.MaQuanLy)
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
			if (Object1.ChucDanh != null && Object2.ChucDanh != null )
			{
				if (Object1.ChucDanh != Object2.ChucDanh)
					equal = false;
			}
			else if (Object1.ChucDanh == null ^ Object1.ChucDanh == null )
			{
				equal = false;
			}
			if (Object1.NamHoc != null && Object2.NamHoc != null )
			{
				if (Object1.NamHoc != Object2.NamHoc)
					equal = false;
			}
			else if (Object1.NamHoc == null ^ Object1.NamHoc == null )
			{
				equal = false;
			}
			if (Object1.HocKy != null && Object2.HocKy != null )
			{
				if (Object1.HocKy != Object2.HocKy)
					equal = false;
			}
			else if (Object1.HocKy == null ^ Object1.HocKy == null )
			{
				equal = false;
			}
			if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
				equal = false;
			if (Object1.MaLoaiHinh != Object2.MaLoaiHinh)
				equal = false;
			if (Object1.MaBacLoaiHinh != Object2.MaBacLoaiHinh)
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
			if (Object1.TenLop != Object2.TenLop)
				equal = false;
			if (Object1.NgayTao != null && Object2.NgayTao != null )
			{
				if (Object1.NgayTao != Object2.NgayTao)
					equal = false;
			}
			else if (Object1.NgayTao == null ^ Object1.NgayTao == null )
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
		public static object GetPropertyValueByName(ViewPhanCongCoVan entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaKhoa":
					return entity.MaKhoa;
				case "TenKhoa":
					return entity.TenKhoa;
				case "MaKhoaHoc":
					return entity.MaKhoaHoc;
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "HoTen":
					return entity.HoTen;
				case "ChucDanh":
					return entity.ChucDanh;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "MaLoaiHinh":
					return entity.MaLoaiHinh;
				case "MaBacLoaiHinh":
					return entity.MaBacLoaiHinh;
				case "MaLop":
					return entity.MaLop;
				case "TenLop":
					return entity.TenLop;
				case "NgayTao":
					return entity.NgayTao;
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
			return GetPropertyValueByName(this as ViewPhanCongCoVan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{16}{15}- MaKhoa: {0}{15}- TenKhoa: {1}{15}- MaKhoaHoc: {2}{15}- MaGiangVien: {3}{15}- MaQuanLy: {4}{15}- HoTen: {5}{15}- ChucDanh: {6}{15}- NamHoc: {7}{15}- HocKy: {8}{15}- MaBacDaoTao: {9}{15}- MaLoaiHinh: {10}{15}- MaBacLoaiHinh: {11}{15}- MaLop: {12}{15}- TenLop: {13}{15}- NgayTao: {14}{15}", 
				(this.MaKhoa == null) ? string.Empty : this.MaKhoa.ToString(),
			     
				(this.TenKhoa == null) ? string.Empty : this.TenKhoa.ToString(),
			     
				this.MaKhoaHoc,
				(this.MaGiangVien == null) ? string.Empty : this.MaGiangVien.ToString(),
			     
				this.MaQuanLy,
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.ChucDanh == null) ? string.Empty : this.ChucDanh.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				this.MaBacDaoTao,
				this.MaLoaiHinh,
				this.MaBacLoaiHinh,
				(this.MaLop == null) ? string.Empty : this.MaLop.ToString(),
			     
				this.TenLop,
				(this.NgayTao == null) ? string.Empty : this.NgayTao.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewPhanCongCoVan columns.
	/// </summary>
	[Serializable]
	public enum ViewPhanCongCoVanColumn
	{
		/// <summary>
		/// MaKhoa : 
		/// </summary>
		[EnumTextValue("MaKhoa")]
		[ColumnEnum("MaKhoa", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaKhoa,
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		[EnumTextValue("TenKhoa")]
		[ColumnEnum("TenKhoa", typeof(System.String), System.Data.DbType.String, false, false, true, 255)]
		TenKhoa,
		/// <summary>
		/// MaKhoaHoc : 
		/// </summary>
		[EnumTextValue("MaKhoaHoc")]
		[ColumnEnum("MaKhoaHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaKhoaHoc,
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaGiangVien,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("MaQuanLy")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaQuanLy,
		/// <summary>
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// ChucDanh : 
		/// </summary>
		[EnumTextValue("ChucDanh")]
		[ColumnEnum("ChucDanh", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 41)]
		ChucDanh,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		HocKy,
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		[EnumTextValue("MaBacDaoTao")]
		[ColumnEnum("MaBacDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaBacDaoTao,
		/// <summary>
		/// MaLoaiHinh : 
		/// </summary>
		[EnumTextValue("MaLoaiHinh")]
		[ColumnEnum("MaLoaiHinh", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLoaiHinh,
		/// <summary>
		/// MaBacLoaiHinh : 
		/// </summary>
		[EnumTextValue("MaBacLoaiHinh")]
		[ColumnEnum("MaBacLoaiHinh", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 41)]
		MaBacLoaiHinh,
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaLop,
		/// <summary>
		/// TenLop : 
		/// </summary>
		[EnumTextValue("TenLop")]
		[ColumnEnum("TenLop", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenLop,
		/// <summary>
		/// NgayTao : 
		/// </summary>
		[EnumTextValue("NgayTao")]
		[ColumnEnum("NgayTao", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayTao
	}//End enum

} // end namespace
