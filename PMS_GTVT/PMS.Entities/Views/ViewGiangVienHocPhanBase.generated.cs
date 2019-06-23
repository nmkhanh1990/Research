﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Generated on : Tuesday, December 07, 2010
	Important: Do not modify this file. Edit the file ViewGiangVienHocPhan.cs instead.
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
	/// An object representation of the 'View_GiangVien_HocPhan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewGiangVienHocPhanBase")]
	public abstract partial class ViewGiangVienHocPhanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32		  _maGiangVien = (int)0;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = string.Empty;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = string.Empty;
		
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
		/// DonGia : 
		/// </summary>
		private System.Decimal		  _donGia = 0.0m;
		
		/// <summary>
		/// TienThem : 
		/// </summary>
		private System.Decimal		  _tienThem = 0.0m;
		
		/// <summary>
		/// TongCong : 
		/// </summary>
		private System.Decimal?		  _tongCong = null;
		
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		private System.DateTime?		  _ngayBatDau = null;
		
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		private System.DateTime?		  _ngayKetThuc = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = string.Empty;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = string.Empty;
		
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
		/// Creates a new <see cref="ViewGiangVienHocPhanBase"/> instance.
		///</summary>
		public ViewGiangVienHocPhanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewGiangVienHocPhanBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maLoaiHinh"></param>
		///<param name="_maBacLoaiHinh"></param>
		///<param name="_donGia"></param>
		///<param name="_tienThem"></param>
		///<param name="_tongCong"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		public ViewGiangVienHocPhanBase(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maBacDaoTao, System.String _maLoaiHinh, System.String _maBacLoaiHinh, System.Decimal _donGia, System.Decimal _tienThem, System.Decimal? _tongCong, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.String _namHoc, System.String _hocKy)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._maLopHocPhan = _maLopHocPhan;
			this._maBacDaoTao = _maBacDaoTao;
			this._maLoaiHinh = _maLoaiHinh;
			this._maBacLoaiHinh = _maBacLoaiHinh;
			this._donGia = _donGia;
			this._tienThem = _tienThem;
			this._tongCong = _tongCong;
			this._ngayBatDau = _ngayBatDau;
			this._ngayKetThuc = _ngayKetThuc;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiangVienHocPhan"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maLoaiHinh"></param>
		///<param name="_maBacLoaiHinh"></param>
		///<param name="_donGia"></param>
		///<param name="_tienThem"></param>
		///<param name="_tongCong"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		public static ViewGiangVienHocPhan CreateViewGiangVienHocPhan(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _maLopHocPhan, System.String _maBacDaoTao, System.String _maLoaiHinh, System.String _maBacLoaiHinh, System.Decimal _donGia, System.Decimal _tienThem, System.Decimal? _tongCong, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.String _namHoc, System.String _hocKy)
		{
			ViewGiangVienHocPhan newViewGiangVienHocPhan = new ViewGiangVienHocPhan();
			newViewGiangVienHocPhan.MaGiangVien = _maGiangVien;
			newViewGiangVienHocPhan.MaQuanLy = _maQuanLy;
			newViewGiangVienHocPhan.MaLopHocPhan = _maLopHocPhan;
			newViewGiangVienHocPhan.MaBacDaoTao = _maBacDaoTao;
			newViewGiangVienHocPhan.MaLoaiHinh = _maLoaiHinh;
			newViewGiangVienHocPhan.MaBacLoaiHinh = _maBacLoaiHinh;
			newViewGiangVienHocPhan.DonGia = _donGia;
			newViewGiangVienHocPhan.TienThem = _tienThem;
			newViewGiangVienHocPhan.TongCong = _tongCong;
			newViewGiangVienHocPhan.NgayBatDau = _ngayBatDau;
			newViewGiangVienHocPhan.NgayKetThuc = _ngayKetThuc;
			newViewGiangVienHocPhan.NamHoc = _namHoc;
			newViewGiangVienHocPhan.HocKy = _hocKy;
			return newViewGiangVienHocPhan;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if (_maGiangVien == value)
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
		/// 	Gets or Sets the DonGia property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal DonGia
		{
			get
			{
				return this._donGia; 
			}
			set
			{
				if (_donGia == value)
					return;
					
				this._donGia = value;
				this._isDirty = true;
				
				OnPropertyChanged("DonGia");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TienThem property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal TienThem
		{
			get
			{
				return this._tienThem; 
			}
			set
			{
				if (_tienThem == value)
					return;
					
				this._tienThem = value;
				this._isDirty = true;
				
				OnPropertyChanged("TienThem");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TongCong property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTongCongNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TongCong
		{
			get
			{
				return this._tongCong; 
			}
			set
			{
				if (_tongCong == value && TongCong != null )
					return;
					
				this._tongCong = value;
				this._isDirty = true;
				
				OnPropertyChanged("TongCong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayBatDau property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayBatDauNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayBatDau
		{
			get
			{
				return this._ngayBatDau; 
			}
			set
			{
				if (_ngayBatDau == value && NgayBatDau != null )
					return;
					
				this._ngayBatDau = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayBatDau");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayKetThuc property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayKetThucNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayKetThuc
		{
			get
			{
				return this._ngayKetThuc; 
			}
			set
			{
				if (_ngayKetThuc == value && NgayKetThuc != null )
					return;
					
				this._ngayKetThuc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayKetThuc");
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
			get { return "View_GiangVien_HocPhan"; }
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
		///  Returns a Typed ViewGiangVienHocPhanBase Entity 
		///</summary>
		public virtual ViewGiangVienHocPhanBase Copy()
		{
			//shallow copy entity
			ViewGiangVienHocPhan copy = new ViewGiangVienHocPhan();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.MaLoaiHinh = this.MaLoaiHinh;
				copy.MaBacLoaiHinh = this.MaBacLoaiHinh;
				copy.DonGia = this.DonGia;
				copy.TienThem = this.TienThem;
				copy.TongCong = this.TongCong;
				copy.NgayBatDau = this.NgayBatDau;
				copy.NgayKetThuc = this.NgayKetThuc;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
			copy.AcceptChanges();
			return (ViewGiangVienHocPhan)copy;
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
		///<returns>true if toObject is a <see cref="ViewGiangVienHocPhanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewGiangVienHocPhanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewGiangVienHocPhanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewGiangVienHocPhanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewGiangVienHocPhanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewGiangVienHocPhanBase Object1, ViewGiangVienHocPhanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
			if (Object1.MaQuanLy != Object2.MaQuanLy)
				equal = false;
			if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
				equal = false;
			if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
				equal = false;
			if (Object1.MaLoaiHinh != Object2.MaLoaiHinh)
				equal = false;
			if (Object1.MaBacLoaiHinh != Object2.MaBacLoaiHinh)
				equal = false;
			if (Object1.DonGia != Object2.DonGia)
				equal = false;
			if (Object1.TienThem != Object2.TienThem)
				equal = false;
			if (Object1.TongCong != null && Object2.TongCong != null )
			{
				if (Object1.TongCong != Object2.TongCong)
					equal = false;
			}
			else if (Object1.TongCong == null ^ Object1.TongCong == null )
			{
				equal = false;
			}
			if (Object1.NgayBatDau != null && Object2.NgayBatDau != null )
			{
				if (Object1.NgayBatDau != Object2.NgayBatDau)
					equal = false;
			}
			else if (Object1.NgayBatDau == null ^ Object1.NgayBatDau == null )
			{
				equal = false;
			}
			if (Object1.NgayKetThuc != null && Object2.NgayKetThuc != null )
			{
				if (Object1.NgayKetThuc != Object2.NgayKetThuc)
					equal = false;
			}
			else if (Object1.NgayKetThuc == null ^ Object1.NgayKetThuc == null )
			{
				equal = false;
			}
			if (Object1.NamHoc != Object2.NamHoc)
				equal = false;
			if (Object1.HocKy != Object2.HocKy)
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
		public static object GetPropertyValueByName(ViewGiangVienHocPhan entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "MaLoaiHinh":
					return entity.MaLoaiHinh;
				case "MaBacLoaiHinh":
					return entity.MaBacLoaiHinh;
				case "DonGia":
					return entity.DonGia;
				case "TienThem":
					return entity.TienThem;
				case "TongCong":
					return entity.TongCong;
				case "NgayBatDau":
					return entity.NgayBatDau;
				case "NgayKetThuc":
					return entity.NgayKetThuc;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
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
			return GetPropertyValueByName(this as ViewGiangVienHocPhan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{14}{13}- MaGiangVien: {0}{13}- MaQuanLy: {1}{13}- MaLopHocPhan: {2}{13}- MaBacDaoTao: {3}{13}- MaLoaiHinh: {4}{13}- MaBacLoaiHinh: {5}{13}- DonGia: {6}{13}- TienThem: {7}{13}- TongCong: {8}{13}- NgayBatDau: {9}{13}- NgayKetThuc: {10}{13}- NamHoc: {11}{13}- HocKy: {12}{13}", 
				this.MaGiangVien,
				this.MaQuanLy,
				this.MaLopHocPhan,
				this.MaBacDaoTao,
				this.MaLoaiHinh,
				this.MaBacLoaiHinh,
				this.DonGia,
				this.TienThem,
				(this.TongCong == null) ? string.Empty : this.TongCong.ToString(),
			     
				(this.NgayBatDau == null) ? string.Empty : this.NgayBatDau.ToString(),
			     
				(this.NgayKetThuc == null) ? string.Empty : this.NgayKetThuc.ToString(),
			     
				this.NamHoc,
				this.HocKy,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewGiangVienHocPhan columns.
	/// </summary>
	[Serializable]
	public enum ViewGiangVienHocPhanColumn
	{
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaGiangVien,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("MaQuanLy")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaQuanLy,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLopHocPhan,
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		[EnumTextValue("MaBacDaoTao")]
		[ColumnEnum("MaBacDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 10)]
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
		[ColumnEnum("MaBacLoaiHinh", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 33)]
		MaBacLoaiHinh,
		/// <summary>
		/// DonGia : 
		/// </summary>
		[EnumTextValue("DonGia")]
		[ColumnEnum("DonGia", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		DonGia,
		/// <summary>
		/// TienThem : 
		/// </summary>
		[EnumTextValue("TienThem")]
		[ColumnEnum("TienThem", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		TienThem,
		/// <summary>
		/// TongCong : 
		/// </summary>
		[EnumTextValue("TongCong")]
		[ColumnEnum("TongCong", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TongCong,
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		[EnumTextValue("NgayBatDau")]
		[ColumnEnum("NgayBatDau", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayBatDau,
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		[EnumTextValue("NgayKetThuc")]
		[ColumnEnum("NgayKetThuc", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayKetThuc,
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
		HocKy
	}//End enum

} // end namespace
