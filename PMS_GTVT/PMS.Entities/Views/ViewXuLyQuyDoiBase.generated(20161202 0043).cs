﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewXuLyQuyDoi.cs instead.
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
	/// An object representation of the 'View_XuLy_QuyDoi' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewXuLyQuyDoiBase")]
	public abstract partial class ViewXuLyQuyDoiBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaKhoiLuong : 
		/// </summary>
		private System.Int32		  _maKhoiLuong = (int)0;
		
		/// <summary>
		/// MaKetQua : 
		/// </summary>
		private System.Int32?		  _maKetQua = null;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = null;
		
		/// <summary>
		/// LoaiHocPhan : 
		/// </summary>
		private System.String		  _loaiHocPhan = null;
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		private System.Decimal?		  _soTiet = null;
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		private System.Decimal?		  _soTinChi = null;
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		private System.Int32?		  _siSoLop = null;
		
		/// <summary>
		/// ChatLuongCao : 
		/// </summary>
		private System.Decimal		  _chatLuongCao = 0.0m;
		
		/// <summary>
		/// NgoaiGio : 
		/// </summary>
		private System.Decimal?		  _ngoaiGio = null;
		
		/// <summary>
		/// TrongGio : 
		/// </summary>
		private System.Decimal?		  _trongGio = null;
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		private System.Decimal		  _heSoLopDong = 0.0m;
		
		/// <summary>
		/// HeSoCoSo : 
		/// </summary>
		private System.Decimal		  _heSoCoSo = 0.0m;
		
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		private System.Decimal		  _heSoHocKy = 0.0m;
		
		/// <summary>
		/// HeSoThanhPhan : 
		/// </summary>
		private System.Decimal		  _heSoThanhPhan = 0.0m;
		
		/// <summary>
		/// HeSoTrongGio : 
		/// </summary>
		private System.Decimal		  _heSoTrongGio = 0.0m;
		
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		private System.Decimal		  _heSoNgoaiGio = 0.0m;
		
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
		/// Creates a new <see cref="ViewXuLyQuyDoiBase"/> instance.
		///</summary>
		public ViewXuLyQuyDoiBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewXuLyQuyDoiBase"/> instance.
		///</summary>
		///<param name="_maKhoiLuong"></param>
		///<param name="_maKetQua"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_soTiet"></param>
		///<param name="_soTinChi"></param>
		///<param name="_siSoLop"></param>
		///<param name="_chatLuongCao"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_trongGio"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_heSoCoSo"></param>
		///<param name="_heSoHocKy"></param>
		///<param name="_heSoThanhPhan"></param>
		///<param name="_heSoTrongGio"></param>
		///<param name="_heSoNgoaiGio"></param>
		public ViewXuLyQuyDoiBase(System.Int32 _maKhoiLuong, System.Int32? _maKetQua, System.String _maLopHocPhan, System.String _loaiHocPhan, System.Decimal? _soTiet, System.Decimal? _soTinChi, System.Int32? _siSoLop, System.Decimal _chatLuongCao, System.Decimal? _ngoaiGio, System.Decimal? _trongGio, System.Decimal _heSoLopDong, System.Decimal _heSoCoSo, System.Decimal _heSoHocKy, System.Decimal _heSoThanhPhan, System.Decimal _heSoTrongGio, System.Decimal _heSoNgoaiGio)
		{
			this._maKhoiLuong = _maKhoiLuong;
			this._maKetQua = _maKetQua;
			this._maLopHocPhan = _maLopHocPhan;
			this._loaiHocPhan = _loaiHocPhan;
			this._soTiet = _soTiet;
			this._soTinChi = _soTinChi;
			this._siSoLop = _siSoLop;
			this._chatLuongCao = _chatLuongCao;
			this._ngoaiGio = _ngoaiGio;
			this._trongGio = _trongGio;
			this._heSoLopDong = _heSoLopDong;
			this._heSoCoSo = _heSoCoSo;
			this._heSoHocKy = _heSoHocKy;
			this._heSoThanhPhan = _heSoThanhPhan;
			this._heSoTrongGio = _heSoTrongGio;
			this._heSoNgoaiGio = _heSoNgoaiGio;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewXuLyQuyDoi"/> instance.
		///</summary>
		///<param name="_maKhoiLuong"></param>
		///<param name="_maKetQua"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_loaiHocPhan"></param>
		///<param name="_soTiet"></param>
		///<param name="_soTinChi"></param>
		///<param name="_siSoLop"></param>
		///<param name="_chatLuongCao"></param>
		///<param name="_ngoaiGio"></param>
		///<param name="_trongGio"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_heSoCoSo"></param>
		///<param name="_heSoHocKy"></param>
		///<param name="_heSoThanhPhan"></param>
		///<param name="_heSoTrongGio"></param>
		///<param name="_heSoNgoaiGio"></param>
		public static ViewXuLyQuyDoi CreateViewXuLyQuyDoi(System.Int32 _maKhoiLuong, System.Int32? _maKetQua, System.String _maLopHocPhan, System.String _loaiHocPhan, System.Decimal? _soTiet, System.Decimal? _soTinChi, System.Int32? _siSoLop, System.Decimal _chatLuongCao, System.Decimal? _ngoaiGio, System.Decimal? _trongGio, System.Decimal _heSoLopDong, System.Decimal _heSoCoSo, System.Decimal _heSoHocKy, System.Decimal _heSoThanhPhan, System.Decimal _heSoTrongGio, System.Decimal _heSoNgoaiGio)
		{
			ViewXuLyQuyDoi newViewXuLyQuyDoi = new ViewXuLyQuyDoi();
			newViewXuLyQuyDoi.MaKhoiLuong = _maKhoiLuong;
			newViewXuLyQuyDoi.MaKetQua = _maKetQua;
			newViewXuLyQuyDoi.MaLopHocPhan = _maLopHocPhan;
			newViewXuLyQuyDoi.LoaiHocPhan = _loaiHocPhan;
			newViewXuLyQuyDoi.SoTiet = _soTiet;
			newViewXuLyQuyDoi.SoTinChi = _soTinChi;
			newViewXuLyQuyDoi.SiSoLop = _siSoLop;
			newViewXuLyQuyDoi.ChatLuongCao = _chatLuongCao;
			newViewXuLyQuyDoi.NgoaiGio = _ngoaiGio;
			newViewXuLyQuyDoi.TrongGio = _trongGio;
			newViewXuLyQuyDoi.HeSoLopDong = _heSoLopDong;
			newViewXuLyQuyDoi.HeSoCoSo = _heSoCoSo;
			newViewXuLyQuyDoi.HeSoHocKy = _heSoHocKy;
			newViewXuLyQuyDoi.HeSoThanhPhan = _heSoThanhPhan;
			newViewXuLyQuyDoi.HeSoTrongGio = _heSoTrongGio;
			newViewXuLyQuyDoi.HeSoNgoaiGio = _heSoNgoaiGio;
			return newViewXuLyQuyDoi;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaKhoiLuong property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaKhoiLuong
		{
			get
			{
				return this._maKhoiLuong; 
			}
			set
			{
				if (_maKhoiLuong == value)
					return;
					
				this._maKhoiLuong = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKhoiLuong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaKetQua property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaKetQuaNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaKetQua
		{
			get
			{
				return this._maKetQua; 
			}
			set
			{
				if (_maKetQua == value && MaKetQua != null )
					return;
					
				this._maKetQua = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKetQua");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLopHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLopHocPhan
		{
			get
			{
				return this._maLopHocPhan; 
			}
			set
			{
				if (_maLopHocPhan == value)
					return;
					
				this._maLopHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLopHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the LoaiHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String LoaiHocPhan
		{
			get
			{
				return this._loaiHocPhan; 
			}
			set
			{
				if (_loaiHocPhan == value)
					return;
					
				this._loaiHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("LoaiHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTiet property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsSoTietNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SoTiet
		{
			get
			{
				return this._soTiet; 
			}
			set
			{
				if (_soTiet == value && SoTiet != null )
					return;
					
				this._soTiet = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTiet");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTinChi property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsSoTinChiNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SoTinChi
		{
			get
			{
				return this._soTinChi; 
			}
			set
			{
				if (_soTinChi == value && SoTinChi != null )
					return;
					
				this._soTinChi = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTinChi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SiSoLop property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSiSoLopNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SiSoLop
		{
			get
			{
				return this._siSoLop; 
			}
			set
			{
				if (_siSoLop == value && SiSoLop != null )
					return;
					
				this._siSoLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("SiSoLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ChatLuongCao property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal ChatLuongCao
		{
			get
			{
				return this._chatLuongCao; 
			}
			set
			{
				if (_chatLuongCao == value)
					return;
					
				this._chatLuongCao = value;
				this._isDirty = true;
				
				OnPropertyChanged("ChatLuongCao");
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
		/// 	Gets or Sets the HeSoLopDong property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoLopDong
		{
			get
			{
				return this._heSoLopDong; 
			}
			set
			{
				if (_heSoLopDong == value)
					return;
					
				this._heSoLopDong = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoLopDong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HeSoCoSo property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoCoSo
		{
			get
			{
				return this._heSoCoSo; 
			}
			set
			{
				if (_heSoCoSo == value)
					return;
					
				this._heSoCoSo = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoCoSo");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HeSoHocKy property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoHocKy
		{
			get
			{
				return this._heSoHocKy; 
			}
			set
			{
				if (_heSoHocKy == value)
					return;
					
				this._heSoHocKy = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoHocKy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HeSoThanhPhan property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoThanhPhan
		{
			get
			{
				return this._heSoThanhPhan; 
			}
			set
			{
				if (_heSoThanhPhan == value)
					return;
					
				this._heSoThanhPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoThanhPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HeSoTrongGio property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoTrongGio
		{
			get
			{
				return this._heSoTrongGio; 
			}
			set
			{
				if (_heSoTrongGio == value)
					return;
					
				this._heSoTrongGio = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoTrongGio");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HeSoNgoaiGio property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal HeSoNgoaiGio
		{
			get
			{
				return this._heSoNgoaiGio; 
			}
			set
			{
				if (_heSoNgoaiGio == value)
					return;
					
				this._heSoNgoaiGio = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoNgoaiGio");
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
			get { return "View_XuLy_QuyDoi"; }
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
		///  Returns a Typed ViewXuLyQuyDoiBase Entity 
		///</summary>
		public virtual ViewXuLyQuyDoiBase Copy()
		{
			//shallow copy entity
			ViewXuLyQuyDoi copy = new ViewXuLyQuyDoi();
				copy.MaKhoiLuong = this.MaKhoiLuong;
				copy.MaKetQua = this.MaKetQua;
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.LoaiHocPhan = this.LoaiHocPhan;
				copy.SoTiet = this.SoTiet;
				copy.SoTinChi = this.SoTinChi;
				copy.SiSoLop = this.SiSoLop;
				copy.ChatLuongCao = this.ChatLuongCao;
				copy.NgoaiGio = this.NgoaiGio;
				copy.TrongGio = this.TrongGio;
				copy.HeSoLopDong = this.HeSoLopDong;
				copy.HeSoCoSo = this.HeSoCoSo;
				copy.HeSoHocKy = this.HeSoHocKy;
				copy.HeSoThanhPhan = this.HeSoThanhPhan;
				copy.HeSoTrongGio = this.HeSoTrongGio;
				copy.HeSoNgoaiGio = this.HeSoNgoaiGio;
			copy.AcceptChanges();
			return (ViewXuLyQuyDoi)copy;
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
		///<returns>true if toObject is a <see cref="ViewXuLyQuyDoiBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewXuLyQuyDoiBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewXuLyQuyDoiBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewXuLyQuyDoiBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewXuLyQuyDoiBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewXuLyQuyDoiBase Object1, ViewXuLyQuyDoiBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaKhoiLuong != Object2.MaKhoiLuong)
				equal = false;
			if (Object1.MaKetQua != null && Object2.MaKetQua != null )
			{
				if (Object1.MaKetQua != Object2.MaKetQua)
					equal = false;
			}
			else if (Object1.MaKetQua == null ^ Object1.MaKetQua == null )
			{
				equal = false;
			}
			if (Object1.MaLopHocPhan != null && Object2.MaLopHocPhan != null )
			{
				if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
					equal = false;
			}
			else if (Object1.MaLopHocPhan == null ^ Object1.MaLopHocPhan == null )
			{
				equal = false;
			}
			if (Object1.LoaiHocPhan != null && Object2.LoaiHocPhan != null )
			{
				if (Object1.LoaiHocPhan != Object2.LoaiHocPhan)
					equal = false;
			}
			else if (Object1.LoaiHocPhan == null ^ Object1.LoaiHocPhan == null )
			{
				equal = false;
			}
			if (Object1.SoTiet != null && Object2.SoTiet != null )
			{
				if (Object1.SoTiet != Object2.SoTiet)
					equal = false;
			}
			else if (Object1.SoTiet == null ^ Object1.SoTiet == null )
			{
				equal = false;
			}
			if (Object1.SoTinChi != null && Object2.SoTinChi != null )
			{
				if (Object1.SoTinChi != Object2.SoTinChi)
					equal = false;
			}
			else if (Object1.SoTinChi == null ^ Object1.SoTinChi == null )
			{
				equal = false;
			}
			if (Object1.SiSoLop != null && Object2.SiSoLop != null )
			{
				if (Object1.SiSoLop != Object2.SiSoLop)
					equal = false;
			}
			else if (Object1.SiSoLop == null ^ Object1.SiSoLop == null )
			{
				equal = false;
			}
			if (Object1.ChatLuongCao != Object2.ChatLuongCao)
				equal = false;
			if (Object1.NgoaiGio != null && Object2.NgoaiGio != null )
			{
				if (Object1.NgoaiGio != Object2.NgoaiGio)
					equal = false;
			}
			else if (Object1.NgoaiGio == null ^ Object1.NgoaiGio == null )
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
			if (Object1.HeSoLopDong != Object2.HeSoLopDong)
				equal = false;
			if (Object1.HeSoCoSo != Object2.HeSoCoSo)
				equal = false;
			if (Object1.HeSoHocKy != Object2.HeSoHocKy)
				equal = false;
			if (Object1.HeSoThanhPhan != Object2.HeSoThanhPhan)
				equal = false;
			if (Object1.HeSoTrongGio != Object2.HeSoTrongGio)
				equal = false;
			if (Object1.HeSoNgoaiGio != Object2.HeSoNgoaiGio)
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
		public static object GetPropertyValueByName(ViewXuLyQuyDoi entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaKhoiLuong":
					return entity.MaKhoiLuong;
				case "MaKetQua":
					return entity.MaKetQua;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "LoaiHocPhan":
					return entity.LoaiHocPhan;
				case "SoTiet":
					return entity.SoTiet;
				case "SoTinChi":
					return entity.SoTinChi;
				case "SiSoLop":
					return entity.SiSoLop;
				case "ChatLuongCao":
					return entity.ChatLuongCao;
				case "NgoaiGio":
					return entity.NgoaiGio;
				case "TrongGio":
					return entity.TrongGio;
				case "HeSoLopDong":
					return entity.HeSoLopDong;
				case "HeSoCoSo":
					return entity.HeSoCoSo;
				case "HeSoHocKy":
					return entity.HeSoHocKy;
				case "HeSoThanhPhan":
					return entity.HeSoThanhPhan;
				case "HeSoTrongGio":
					return entity.HeSoTrongGio;
				case "HeSoNgoaiGio":
					return entity.HeSoNgoaiGio;
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
			return GetPropertyValueByName(this as ViewXuLyQuyDoi, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{17}{16}- MaKhoiLuong: {0}{16}- MaKetQua: {1}{16}- MaLopHocPhan: {2}{16}- LoaiHocPhan: {3}{16}- SoTiet: {4}{16}- SoTinChi: {5}{16}- SiSoLop: {6}{16}- ChatLuongCao: {7}{16}- NgoaiGio: {8}{16}- TrongGio: {9}{16}- HeSoLopDong: {10}{16}- HeSoCoSo: {11}{16}- HeSoHocKy: {12}{16}- HeSoThanhPhan: {13}{16}- HeSoTrongGio: {14}{16}- HeSoNgoaiGio: {15}{16}", 
				this.MaKhoiLuong,
				(this.MaKetQua == null) ? string.Empty : this.MaKetQua.ToString(),
			     
				(this.MaLopHocPhan == null) ? string.Empty : this.MaLopHocPhan.ToString(),
			     
				(this.LoaiHocPhan == null) ? string.Empty : this.LoaiHocPhan.ToString(),
			     
				(this.SoTiet == null) ? string.Empty : this.SoTiet.ToString(),
			     
				(this.SoTinChi == null) ? string.Empty : this.SoTinChi.ToString(),
			     
				(this.SiSoLop == null) ? string.Empty : this.SiSoLop.ToString(),
			     
				this.ChatLuongCao,
				(this.NgoaiGio == null) ? string.Empty : this.NgoaiGio.ToString(),
			     
				(this.TrongGio == null) ? string.Empty : this.TrongGio.ToString(),
			     
				this.HeSoLopDong,
				this.HeSoCoSo,
				this.HeSoHocKy,
				this.HeSoThanhPhan,
				this.HeSoTrongGio,
				this.HeSoNgoaiGio,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewXuLyQuyDoi columns.
	/// </summary>
	[Serializable]
	public enum ViewXuLyQuyDoiColumn
	{
		/// <summary>
		/// MaKhoiLuong : 
		/// </summary>
		[EnumTextValue("MaKhoiLuong")]
		[ColumnEnum("MaKhoiLuong", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaKhoiLuong,
		/// <summary>
		/// MaKetQua : 
		/// </summary>
		[EnumTextValue("MaKetQua")]
		[ColumnEnum("MaKetQua", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaKetQua,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaLopHocPhan,
		/// <summary>
		/// LoaiHocPhan : 
		/// </summary>
		[EnumTextValue("LoaiHocPhan")]
		[ColumnEnum("LoaiHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		LoaiHocPhan,
		/// <summary>
		/// SoTiet : 
		/// </summary>
		[EnumTextValue("SoTiet")]
		[ColumnEnum("SoTiet", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		SoTiet,
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		[EnumTextValue("SoTinChi")]
		[ColumnEnum("SoTinChi", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		SoTinChi,
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		[EnumTextValue("SiSoLop")]
		[ColumnEnum("SiSoLop", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSoLop,
		/// <summary>
		/// ChatLuongCao : 
		/// </summary>
		[EnumTextValue("ChatLuongCao")]
		[ColumnEnum("ChatLuongCao", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		ChatLuongCao,
		/// <summary>
		/// NgoaiGio : 
		/// </summary>
		[EnumTextValue("NgoaiGio")]
		[ColumnEnum("NgoaiGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		NgoaiGio,
		/// <summary>
		/// TrongGio : 
		/// </summary>
		[EnumTextValue("TrongGio")]
		[ColumnEnum("TrongGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TrongGio,
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		[EnumTextValue("HeSoLopDong")]
		[ColumnEnum("HeSoLopDong", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoLopDong,
		/// <summary>
		/// HeSoCoSo : 
		/// </summary>
		[EnumTextValue("HeSoCoSo")]
		[ColumnEnum("HeSoCoSo", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoCoSo,
		/// <summary>
		/// HeSoHocKy : 
		/// </summary>
		[EnumTextValue("HeSoHocKy")]
		[ColumnEnum("HeSoHocKy", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoHocKy,
		/// <summary>
		/// HeSoThanhPhan : 
		/// </summary>
		[EnumTextValue("HeSoThanhPhan")]
		[ColumnEnum("HeSoThanhPhan", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoThanhPhan,
		/// <summary>
		/// HeSoTrongGio : 
		/// </summary>
		[EnumTextValue("HeSoTrongGio")]
		[ColumnEnum("HeSoTrongGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoTrongGio,
		/// <summary>
		/// HeSoNgoaiGio : 
		/// </summary>
		[EnumTextValue("HeSoNgoaiGio")]
		[ColumnEnum("HeSoNgoaiGio", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		HeSoNgoaiGio
	}//End enum

} // end namespace
