﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VThanhToanThuLao.cs instead.
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
	/// An object representation of the 'v_ThanhToan_ThuLao' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VThanhToanThuLaoBase")]
	public abstract partial class VThanhToanThuLaoBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		private System.Int32?		  _maLoaiGiangVien = null;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32		  _maGiangVien = (int)0;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = string.Empty;
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// HoDem : 
		/// </summary>
		private System.String		  _hoDem = string.Empty;
		
		/// <summary>
		/// Ten : 
		/// </summary>
		private System.String		  _ten = null;
		
		/// <summary>
		/// ChucDanh : 
		/// </summary>
		private System.String		  _chucDanh = null;
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		private System.String		  _maDonVi = null;
		
		/// <summary>
		/// MaNhomKhoiLuong : 
		/// </summary>
		private System.String		  _maNhomKhoiLuong = null;
		
		/// <summary>
		/// TietGioiHan : 
		/// </summary>
		private System.Decimal?		  _tietGioiHan = null;
		
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		private System.Int32?		  _tietNghiaVu = null;
		
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		private System.Decimal?		  _tietQuyDoi = null;
		
		/// <summary>
		/// TietDoAn : 
		/// </summary>
		private System.Decimal?		  _tietDoAn = null;
		
		/// <summary>
		/// TrongGio : 
		/// </summary>
		private System.Decimal?		  _trongGio = null;
		
		/// <summary>
		/// NgoaiGio : 
		/// </summary>
		private System.Decimal?		  _ngoaiGio = null;
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		private System.Decimal?		  _donGia = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
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
		/// Creates a new <see cref="VThanhToanThuLaoBase"/> instance.
		///</summary>
		public VThanhToanThuLaoBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VThanhToanThuLaoBase"/> instance.
		///</summary>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_hoDem"></param>
		///<param name="_ten"></param>
		///<param name="_chucDanh"></param>
		///<param name="_maDonVi"></param>
		///<param name="_maNhomKhoiLuong"></param>
		///<param name="_tietGioiHan"></param>
		///<param name="_tietNghiaVu"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_tietDoAn"></param>
		///<param name="_trongGio"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_donGia"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		public VThanhToanThuLaoBase(System.Int32? _maLoaiGiangVien, System.Int32 _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _hoDem, System.String _ten, System.String _chucDanh, System.String _maDonVi, System.String _maNhomKhoiLuong, System.Decimal? _tietGioiHan, System.Int32? _tietNghiaVu, System.Decimal? _tietQuyDoi, System.Decimal? _tietDoAn, System.Decimal? _trongGio, System.Decimal? _ngoaiGio, System.Decimal? _donGia, System.String _hocKy, System.String _namHoc)
		{
			this._maLoaiGiangVien = _maLoaiGiangVien;
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._hoTen = _hoTen;
			this._hoDem = _hoDem;
			this._ten = _ten;
			this._chucDanh = _chucDanh;
			this._maDonVi = _maDonVi;
			this._maNhomKhoiLuong = _maNhomKhoiLuong;
			this._tietGioiHan = _tietGioiHan;
			this._tietNghiaVu = _tietNghiaVu;
			this._tietQuyDoi = _tietQuyDoi;
			this._tietDoAn = _tietDoAn;
			this._trongGio = _trongGio;
			this._ngoaiGio = _ngoaiGio;
			this._donGia = _donGia;
			this._hocKy = _hocKy;
			this._namHoc = _namHoc;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VThanhToanThuLao"/> instance.
		///</summary>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_hoDem"></param>
		///<param name="_ten"></param>
		///<param name="_chucDanh"></param>
		///<param name="_maDonVi"></param>
		///<param name="_maNhomKhoiLuong"></param>
		///<param name="_tietGioiHan"></param>
		///<param name="_tietNghiaVu"></param>
		///<param name="_tietQuyDoi"></param>
		///<param name="_tietDoAn"></param>
		///<param name="_trongGio"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_donGia"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		public static VThanhToanThuLao CreateVThanhToanThuLao(System.Int32? _maLoaiGiangVien, System.Int32 _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _hoDem, System.String _ten, System.String _chucDanh, System.String _maDonVi, System.String _maNhomKhoiLuong, System.Decimal? _tietGioiHan, System.Int32? _tietNghiaVu, System.Decimal? _tietQuyDoi, System.Decimal? _tietDoAn, System.Decimal? _trongGio, System.Decimal? _ngoaiGio, System.Decimal? _donGia, System.String _hocKy, System.String _namHoc)
		{
			VThanhToanThuLao newVThanhToanThuLao = new VThanhToanThuLao();
			newVThanhToanThuLao.MaLoaiGiangVien = _maLoaiGiangVien;
			newVThanhToanThuLao.MaGiangVien = _maGiangVien;
			newVThanhToanThuLao.MaQuanLy = _maQuanLy;
			newVThanhToanThuLao.HoTen = _hoTen;
			newVThanhToanThuLao.HoDem = _hoDem;
			newVThanhToanThuLao.Ten = _ten;
			newVThanhToanThuLao.ChucDanh = _chucDanh;
			newVThanhToanThuLao.MaDonVi = _maDonVi;
			newVThanhToanThuLao.MaNhomKhoiLuong = _maNhomKhoiLuong;
			newVThanhToanThuLao.TietGioiHan = _tietGioiHan;
			newVThanhToanThuLao.TietNghiaVu = _tietNghiaVu;
			newVThanhToanThuLao.TietQuyDoi = _tietQuyDoi;
			newVThanhToanThuLao.TietDoAn = _tietDoAn;
			newVThanhToanThuLao.TrongGio = _trongGio;
			newVThanhToanThuLao.NgoaiGio = _ngoaiGio;
			newVThanhToanThuLao.DonGia = _donGia;
			newVThanhToanThuLao.HocKy = _hocKy;
			newVThanhToanThuLao.NamHoc = _namHoc;
			return newVThanhToanThuLao;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaLoaiGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaLoaiGiangVienNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaLoaiGiangVien
		{
			get
			{
				return this._maLoaiGiangVien; 
			}
			set
			{
				if (_maLoaiGiangVien == value && MaLoaiGiangVien != null )
					return;
					
				this._maLoaiGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLoaiGiangVien");
			}
		}
		
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
		/// 	Gets or Sets the HoDem property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HoDem
		{
			get
			{
				return this._hoDem; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "HoDem does not allow null values.");
				if (_hoDem == value)
					return;
					
				this._hoDem = value;
				this._isDirty = true;
				
				OnPropertyChanged("HoDem");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Ten property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Ten
		{
			get
			{
				return this._ten; 
			}
			set
			{
				if (_ten == value)
					return;
					
				this._ten = value;
				this._isDirty = true;
				
				OnPropertyChanged("Ten");
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
		/// 	Gets or Sets the MaDonVi property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaDonVi
		{
			get
			{
				return this._maDonVi; 
			}
			set
			{
				if (_maDonVi == value)
					return;
					
				this._maDonVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaDonVi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaNhomKhoiLuong property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaNhomKhoiLuong
		{
			get
			{
				return this._maNhomKhoiLuong; 
			}
			set
			{
				if (_maNhomKhoiLuong == value)
					return;
					
				this._maNhomKhoiLuong = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaNhomKhoiLuong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietGioiHan property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTietGioiHanNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TietGioiHan
		{
			get
			{
				return this._tietGioiHan; 
			}
			set
			{
				if (_tietGioiHan == value && TietGioiHan != null )
					return;
					
				this._tietGioiHan = value;
				this._isDirty = true;
				
				OnPropertyChanged("TietGioiHan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietNghiaVu property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsTietNghiaVuNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? TietNghiaVu
		{
			get
			{
				return this._tietNghiaVu; 
			}
			set
			{
				if (_tietNghiaVu == value && TietNghiaVu != null )
					return;
					
				this._tietNghiaVu = value;
				this._isDirty = true;
				
				OnPropertyChanged("TietNghiaVu");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietQuyDoi property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTietQuyDoiNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TietQuyDoi
		{
			get
			{
				return this._tietQuyDoi; 
			}
			set
			{
				if (_tietQuyDoi == value && TietQuyDoi != null )
					return;
					
				this._tietQuyDoi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TietQuyDoi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietDoAn property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTietDoAnNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TietDoAn
		{
			get
			{
				return this._tietDoAn; 
			}
			set
			{
				if (_tietDoAn == value && TietDoAn != null )
					return;
					
				this._tietDoAn = value;
				this._isDirty = true;
				
				OnPropertyChanged("TietDoAn");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TrongGio property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTrongGioNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TrongGio
		{
			get
			{
				return this._trongGio; 
			}
			set
			{
				if (_trongGio == value && TrongGio != null )
					return;
					
				this._trongGio = value;
				this._isDirty = true;
				
				OnPropertyChanged("TrongGio");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgoaiGio property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsNgoaiGioNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? NgoaiGio
		{
			get
			{
				return this._ngoaiGio; 
			}
			set
			{
				if (_ngoaiGio == value && NgoaiGio != null )
					return;
					
				this._ngoaiGio = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgoaiGio");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DonGia property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsDonGiaNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? DonGia
		{
			get
			{
				return this._donGia; 
			}
			set
			{
				if (_donGia == value && DonGia != null )
					return;
					
				this._donGia = value;
				this._isDirty = true;
				
				OnPropertyChanged("DonGia");
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
			get { return "v_ThanhToan_ThuLao"; }
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
		///  Returns a Typed VThanhToanThuLaoBase Entity 
		///</summary>
		public virtual VThanhToanThuLaoBase Copy()
		{
			//shallow copy entity
			VThanhToanThuLao copy = new VThanhToanThuLao();
				copy.MaLoaiGiangVien = this.MaLoaiGiangVien;
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.HoTen = this.HoTen;
				copy.HoDem = this.HoDem;
				copy.Ten = this.Ten;
				copy.ChucDanh = this.ChucDanh;
				copy.MaDonVi = this.MaDonVi;
				copy.MaNhomKhoiLuong = this.MaNhomKhoiLuong;
				copy.TietGioiHan = this.TietGioiHan;
				copy.TietNghiaVu = this.TietNghiaVu;
				copy.TietQuyDoi = this.TietQuyDoi;
				copy.TietDoAn = this.TietDoAn;
				copy.TrongGio = this.TrongGio;
				copy.NgoaiGio = this.NgoaiGio;
				copy.DonGia = this.DonGia;
				copy.HocKy = this.HocKy;
				copy.NamHoc = this.NamHoc;
			copy.AcceptChanges();
			return (VThanhToanThuLao)copy;
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
		///<returns>true if toObject is a <see cref="VThanhToanThuLaoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VThanhToanThuLaoBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VThanhToanThuLaoBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VThanhToanThuLaoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VThanhToanThuLaoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VThanhToanThuLaoBase Object1, VThanhToanThuLaoBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaLoaiGiangVien != null && Object2.MaLoaiGiangVien != null )
			{
				if (Object1.MaLoaiGiangVien != Object2.MaLoaiGiangVien)
					equal = false;
			}
			else if (Object1.MaLoaiGiangVien == null ^ Object1.MaLoaiGiangVien == null )
			{
				equal = false;
			}
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
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
			if (Object1.HoDem != Object2.HoDem)
				equal = false;
			if (Object1.Ten != null && Object2.Ten != null )
			{
				if (Object1.Ten != Object2.Ten)
					equal = false;
			}
			else if (Object1.Ten == null ^ Object1.Ten == null )
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
			if (Object1.MaDonVi != null && Object2.MaDonVi != null )
			{
				if (Object1.MaDonVi != Object2.MaDonVi)
					equal = false;
			}
			else if (Object1.MaDonVi == null ^ Object1.MaDonVi == null )
			{
				equal = false;
			}
			if (Object1.MaNhomKhoiLuong != null && Object2.MaNhomKhoiLuong != null )
			{
				if (Object1.MaNhomKhoiLuong != Object2.MaNhomKhoiLuong)
					equal = false;
			}
			else if (Object1.MaNhomKhoiLuong == null ^ Object1.MaNhomKhoiLuong == null )
			{
				equal = false;
			}
			if (Object1.TietGioiHan != null && Object2.TietGioiHan != null )
			{
				if (Object1.TietGioiHan != Object2.TietGioiHan)
					equal = false;
			}
			else if (Object1.TietGioiHan == null ^ Object1.TietGioiHan == null )
			{
				equal = false;
			}
			if (Object1.TietNghiaVu != null && Object2.TietNghiaVu != null )
			{
				if (Object1.TietNghiaVu != Object2.TietNghiaVu)
					equal = false;
			}
			else if (Object1.TietNghiaVu == null ^ Object1.TietNghiaVu == null )
			{
				equal = false;
			}
			if (Object1.TietQuyDoi != null && Object2.TietQuyDoi != null )
			{
				if (Object1.TietQuyDoi != Object2.TietQuyDoi)
					equal = false;
			}
			else if (Object1.TietQuyDoi == null ^ Object1.TietQuyDoi == null )
			{
				equal = false;
			}
			if (Object1.TietDoAn != null && Object2.TietDoAn != null )
			{
				if (Object1.TietDoAn != Object2.TietDoAn)
					equal = false;
			}
			else if (Object1.TietDoAn == null ^ Object1.TietDoAn == null )
			{
				equal = false;
			}
			if (Object1.TrongGio != null && Object2.TrongGio != null )
			{
				if (Object1.TrongGio != Object2.TrongGio)
					equal = false;
			}
			else if (Object1.TrongGio == null ^ Object1.TrongGio == null )
			{
				equal = false;
			}
			if (Object1.NgoaiGio != null && Object2.NgoaiGio != null )
			{
				if (Object1.NgoaiGio != Object2.NgoaiGio)
					equal = false;
			}
			else if (Object1.NgoaiGio == null ^ Object1.NgoaiGio == null )
			{
				equal = false;
			}
			if (Object1.DonGia != null && Object2.DonGia != null )
			{
				if (Object1.DonGia != Object2.DonGia)
					equal = false;
			}
			else if (Object1.DonGia == null ^ Object1.DonGia == null )
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
			if (Object1.NamHoc != null && Object2.NamHoc != null )
			{
				if (Object1.NamHoc != Object2.NamHoc)
					equal = false;
			}
			else if (Object1.NamHoc == null ^ Object1.NamHoc == null )
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
		public static object GetPropertyValueByName(VThanhToanThuLao entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaLoaiGiangVien":
					return entity.MaLoaiGiangVien;
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "HoTen":
					return entity.HoTen;
				case "HoDem":
					return entity.HoDem;
				case "Ten":
					return entity.Ten;
				case "ChucDanh":
					return entity.ChucDanh;
				case "MaDonVi":
					return entity.MaDonVi;
				case "MaNhomKhoiLuong":
					return entity.MaNhomKhoiLuong;
				case "TietGioiHan":
					return entity.TietGioiHan;
				case "TietNghiaVu":
					return entity.TietNghiaVu;
				case "TietQuyDoi":
					return entity.TietQuyDoi;
				case "TietDoAn":
					return entity.TietDoAn;
				case "TrongGio":
					return entity.TrongGio;
				case "NgoaiGio":
					return entity.NgoaiGio;
				case "DonGia":
					return entity.DonGia;
				case "HocKy":
					return entity.HocKy;
				case "NamHoc":
					return entity.NamHoc;
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
			return GetPropertyValueByName(this as VThanhToanThuLao, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{19}{18}- MaLoaiGiangVien: {0}{18}- MaGiangVien: {1}{18}- MaQuanLy: {2}{18}- HoTen: {3}{18}- HoDem: {4}{18}- Ten: {5}{18}- ChucDanh: {6}{18}- MaDonVi: {7}{18}- MaNhomKhoiLuong: {8}{18}- TietGioiHan: {9}{18}- TietNghiaVu: {10}{18}- TietQuyDoi: {11}{18}- TietDoAn: {12}{18}- TrongGio: {13}{18}- NgoaiGio: {14}{18}- DonGia: {15}{18}- HocKy: {16}{18}- NamHoc: {17}{18}", 
				(this.MaLoaiGiangVien == null) ? string.Empty : this.MaLoaiGiangVien.ToString(),
			     
				this.MaGiangVien,
				this.MaQuanLy,
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				this.HoDem,
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.ChucDanh == null) ? string.Empty : this.ChucDanh.ToString(),
			     
				(this.MaDonVi == null) ? string.Empty : this.MaDonVi.ToString(),
			     
				(this.MaNhomKhoiLuong == null) ? string.Empty : this.MaNhomKhoiLuong.ToString(),
			     
				(this.TietGioiHan == null) ? string.Empty : this.TietGioiHan.ToString(),
			     
				(this.TietNghiaVu == null) ? string.Empty : this.TietNghiaVu.ToString(),
			     
				(this.TietQuyDoi == null) ? string.Empty : this.TietQuyDoi.ToString(),
			     
				(this.TietDoAn == null) ? string.Empty : this.TietDoAn.ToString(),
			     
				(this.TrongGio == null) ? string.Empty : this.TrongGio.ToString(),
			     
				(this.NgoaiGio == null) ? string.Empty : this.NgoaiGio.ToString(),
			     
				(this.DonGia == null) ? string.Empty : this.DonGia.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VThanhToanThuLao columns.
	/// </summary>
	[Serializable]
	public enum VThanhToanThuLaoColumn
	{
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		[EnumTextValue("MaLoaiGiangVien")]
		[ColumnEnum("MaLoaiGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaLoaiGiangVien,
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
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// HoDem : 
		/// </summary>
		[EnumTextValue("HoDem")]
		[ColumnEnum("HoDem", typeof(System.String), System.Data.DbType.String, false, false, false, 101)]
		HoDem,
		/// <summary>
		/// Ten : 
		/// </summary>
		[EnumTextValue("Ten")]
		[ColumnEnum("Ten", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		Ten,
		/// <summary>
		/// ChucDanh : 
		/// </summary>
		[EnumTextValue("ChucDanh")]
		[ColumnEnum("ChucDanh", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		ChucDanh,
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		[EnumTextValue("MaDonVi")]
		[ColumnEnum("MaDonVi", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaDonVi,
		/// <summary>
		/// MaNhomKhoiLuong : 
		/// </summary>
		[EnumTextValue("MaNhomKhoiLuong")]
		[ColumnEnum("MaNhomKhoiLuong", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 50)]
		MaNhomKhoiLuong,
		/// <summary>
		/// TietGioiHan : 
		/// </summary>
		[EnumTextValue("TietGioiHan")]
		[ColumnEnum("TietGioiHan", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TietGioiHan,
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		[EnumTextValue("TietNghiaVu")]
		[ColumnEnum("TietNghiaVu", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		TietNghiaVu,
		/// <summary>
		/// TietQuyDoi : 
		/// </summary>
		[EnumTextValue("TietQuyDoi")]
		[ColumnEnum("TietQuyDoi", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TietQuyDoi,
		/// <summary>
		/// TietDoAn : 
		/// </summary>
		[EnumTextValue("TietDoAn")]
		[ColumnEnum("TietDoAn", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TietDoAn,
		/// <summary>
		/// TrongGio : 
		/// </summary>
		[EnumTextValue("TrongGio")]
		[ColumnEnum("TrongGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TrongGio,
		/// <summary>
		/// NgoaiGio : 
		/// </summary>
		[EnumTextValue("NgoaiGio")]
		[ColumnEnum("NgoaiGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		NgoaiGio,
		/// <summary>
		/// DonGia : 
		/// </summary>
		[EnumTextValue("DonGia")]
		[ColumnEnum("DonGia", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		DonGia,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		HocKy,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc
	}//End enum

} // end namespace
