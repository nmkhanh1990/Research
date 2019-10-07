﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewTongHopGioDay.cs instead.
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
	/// An object representation of the 'View_TongHop_GioDay' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewTongHopGioDayBase")]
	public abstract partial class ViewTongHopGioDayBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// Ho : 
		/// </summary>
		private System.String		  _ho = null;
		
		/// <summary>
		/// Ten : 
		/// </summary>
		private System.String		  _ten = null;
		
		/// <summary>
		/// TenLop : 
		/// </summary>
		private System.String		  _tenLop = string.Empty;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = string.Empty;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = string.Empty;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		private System.Int32?		  _siSoLop = null;
		
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		private System.Decimal?		  _heSoLopDong = null;
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		private System.String		  _maBacDaoTao = null;
		
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		private System.String		  _maHeDaoTao = null;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.String		  _maGiangVien = string.Empty;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = string.Empty;
		
		/// <summary>
		/// LyThuyet : 
		/// </summary>
		private System.Decimal		  _lyThuyet = 0.0m;
		
		/// <summary>
		/// LyThuyetHS : 
		/// </summary>
		private System.Decimal?		  _lyThuyetHs = null;
		
		/// <summary>
		/// ThucHanh : 
		/// </summary>
		private System.Decimal		  _thucHanh = 0.0m;
		
		/// <summary>
		/// ThucHanhHS : 
		/// </summary>
		private System.Decimal?		  _thucHanhHs = null;
		
		/// <summary>
		/// Tong : 
		/// </summary>
		private System.Decimal?		  _tong = null;
		
		/// <summary>
		/// TongHS : 
		/// </summary>
		private System.Decimal?		  _tongHs = null;
		
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
		/// Creates a new <see cref="ViewTongHopGioDayBase"/> instance.
		///</summary>
		public ViewTongHopGioDayBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewTongHopGioDayBase"/> instance.
		///</summary>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_tenLop"></param>
		///<param name="_maLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_lyThuyet"></param>
		///<param name="_lyThuyetHs"></param>
		///<param name="_thucHanh"></param>
		///<param name="_thucHanhHs"></param>
		///<param name="_tong"></param>
		///<param name="_tongHs"></param>
		public ViewTongHopGioDayBase(System.String _ho, System.String _ten, System.String _tenLop, System.String _maLop, System.String _maMonHoc, System.String _tenMonHoc, System.Int32? _siSoLop, System.Decimal? _heSoLopDong, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maGiangVien, System.String _maLopHocPhan, System.Decimal _lyThuyet, System.Decimal? _lyThuyetHs, System.Decimal _thucHanh, System.Decimal? _thucHanhHs, System.Decimal? _tong, System.Decimal? _tongHs)
		{
			this._ho = _ho;
			this._ten = _ten;
			this._tenLop = _tenLop;
			this._maLop = _maLop;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._siSoLop = _siSoLop;
			this._heSoLopDong = _heSoLopDong;
			this._maBacDaoTao = _maBacDaoTao;
			this._maHeDaoTao = _maHeDaoTao;
			this._maGiangVien = _maGiangVien;
			this._maLopHocPhan = _maLopHocPhan;
			this._lyThuyet = _lyThuyet;
			this._lyThuyetHs = _lyThuyetHs;
			this._thucHanh = _thucHanh;
			this._thucHanhHs = _thucHanhHs;
			this._tong = _tong;
			this._tongHs = _tongHs;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewTongHopGioDay"/> instance.
		///</summary>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_tenLop"></param>
		///<param name="_maLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_heSoLopDong"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_lyThuyet"></param>
		///<param name="_lyThuyetHs"></param>
		///<param name="_thucHanh"></param>
		///<param name="_thucHanhHs"></param>
		///<param name="_tong"></param>
		///<param name="_tongHs"></param>
		public static ViewTongHopGioDay CreateViewTongHopGioDay(System.String _ho, System.String _ten, System.String _tenLop, System.String _maLop, System.String _maMonHoc, System.String _tenMonHoc, System.Int32? _siSoLop, System.Decimal? _heSoLopDong, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maGiangVien, System.String _maLopHocPhan, System.Decimal _lyThuyet, System.Decimal? _lyThuyetHs, System.Decimal _thucHanh, System.Decimal? _thucHanhHs, System.Decimal? _tong, System.Decimal? _tongHs)
		{
			ViewTongHopGioDay newViewTongHopGioDay = new ViewTongHopGioDay();
			newViewTongHopGioDay.Ho = _ho;
			newViewTongHopGioDay.Ten = _ten;
			newViewTongHopGioDay.TenLop = _tenLop;
			newViewTongHopGioDay.MaLop = _maLop;
			newViewTongHopGioDay.MaMonHoc = _maMonHoc;
			newViewTongHopGioDay.TenMonHoc = _tenMonHoc;
			newViewTongHopGioDay.SiSoLop = _siSoLop;
			newViewTongHopGioDay.HeSoLopDong = _heSoLopDong;
			newViewTongHopGioDay.MaBacDaoTao = _maBacDaoTao;
			newViewTongHopGioDay.MaHeDaoTao = _maHeDaoTao;
			newViewTongHopGioDay.MaGiangVien = _maGiangVien;
			newViewTongHopGioDay.MaLopHocPhan = _maLopHocPhan;
			newViewTongHopGioDay.LyThuyet = _lyThuyet;
			newViewTongHopGioDay.LyThuyetHs = _lyThuyetHs;
			newViewTongHopGioDay.ThucHanh = _thucHanh;
			newViewTongHopGioDay.ThucHanhHs = _thucHanhHs;
			newViewTongHopGioDay.Tong = _tong;
			newViewTongHopGioDay.TongHs = _tongHs;
			return newViewTongHopGioDay;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the Ho property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Ho
		{
			get
			{
				return this._ho; 
			}
			set
			{
				if (_ho == value)
					return;
					
				this._ho = value;
				this._isDirty = true;
				
				OnPropertyChanged("Ho");
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
		/// 	Gets or Sets the SiSoLop property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSiSoLopNull() and perform business logic appropriately.
		/// </remarks>
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
		/// 	Gets or Sets the HeSoLopDong property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsHeSoLopDongNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? HeSoLopDong
		{
			get
			{
				return this._heSoLopDong; 
			}
			set
			{
				if (_heSoLopDong == value && HeSoLopDong != null )
					return;
					
				this._heSoLopDong = value;
				this._isDirty = true;
				
				OnPropertyChanged("HeSoLopDong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaBacDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaBacDaoTao
		{
			get
			{
				return this._maBacDaoTao; 
			}
			set
			{
				if (_maBacDaoTao == value)
					return;
					
				this._maBacDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaBacDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaHeDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHeDaoTao
		{
			get
			{
				return this._maHeDaoTao; 
			}
			set
			{
				if (_maHeDaoTao == value)
					return;
					
				this._maHeDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHeDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaGiangVien does not allow null values.");
				if (_maGiangVien == value)
					return;
					
				this._maGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVien");
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
		/// 	Gets or Sets the LyThuyet property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal LyThuyet
		{
			get
			{
				return this._lyThuyet; 
			}
			set
			{
				if (_lyThuyet == value)
					return;
					
				this._lyThuyet = value;
				this._isDirty = true;
				
				OnPropertyChanged("LyThuyet");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the LyThuyetHS property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsLyThuyetHsNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? LyThuyetHs
		{
			get
			{
				return this._lyThuyetHs; 
			}
			set
			{
				if (_lyThuyetHs == value && LyThuyetHs != null )
					return;
					
				this._lyThuyetHs = value;
				this._isDirty = true;
				
				OnPropertyChanged("LyThuyetHs");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ThucHanh property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal ThucHanh
		{
			get
			{
				return this._thucHanh; 
			}
			set
			{
				if (_thucHanh == value)
					return;
					
				this._thucHanh = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThucHanh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ThucHanhHS property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsThucHanhHsNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? ThucHanhHs
		{
			get
			{
				return this._thucHanhHs; 
			}
			set
			{
				if (_thucHanhHs == value && ThucHanhHs != null )
					return;
					
				this._thucHanhHs = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThucHanhHs");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Tong property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTongNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? Tong
		{
			get
			{
				return this._tong; 
			}
			set
			{
				if (_tong == value && Tong != null )
					return;
					
				this._tong = value;
				this._isDirty = true;
				
				OnPropertyChanged("Tong");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TongHS property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTongHsNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TongHs
		{
			get
			{
				return this._tongHs; 
			}
			set
			{
				if (_tongHs == value && TongHs != null )
					return;
					
				this._tongHs = value;
				this._isDirty = true;
				
				OnPropertyChanged("TongHs");
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
			get { return "View_TongHop_GioDay"; }
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
		///  Returns a Typed ViewTongHopGioDayBase Entity 
		///</summary>
		public virtual ViewTongHopGioDayBase Copy()
		{
			//shallow copy entity
			ViewTongHopGioDay copy = new ViewTongHopGioDay();
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.TenLop = this.TenLop;
				copy.MaLop = this.MaLop;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.SiSoLop = this.SiSoLop;
				copy.HeSoLopDong = this.HeSoLopDong;
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.MaHeDaoTao = this.MaHeDaoTao;
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.LyThuyet = this.LyThuyet;
				copy.LyThuyetHs = this.LyThuyetHs;
				copy.ThucHanh = this.ThucHanh;
				copy.ThucHanhHs = this.ThucHanhHs;
				copy.Tong = this.Tong;
				copy.TongHs = this.TongHs;
			copy.AcceptChanges();
			return (ViewTongHopGioDay)copy;
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
		///<returns>true if toObject is a <see cref="ViewTongHopGioDayBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewTongHopGioDayBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewTongHopGioDayBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewTongHopGioDayBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewTongHopGioDayBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewTongHopGioDayBase Object1, ViewTongHopGioDayBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.Ho != null && Object2.Ho != null )
			{
				if (Object1.Ho != Object2.Ho)
					equal = false;
			}
			else if (Object1.Ho == null ^ Object1.Ho == null )
			{
				equal = false;
			}
			if (Object1.Ten != null && Object2.Ten != null )
			{
				if (Object1.Ten != Object2.Ten)
					equal = false;
			}
			else if (Object1.Ten == null ^ Object1.Ten == null )
			{
				equal = false;
			}
			if (Object1.TenLop != Object2.TenLop)
				equal = false;
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if (Object1.MaMonHoc != Object2.MaMonHoc)
				equal = false;
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.SiSoLop != null && Object2.SiSoLop != null )
			{
				if (Object1.SiSoLop != Object2.SiSoLop)
					equal = false;
			}
			else if (Object1.SiSoLop == null ^ Object1.SiSoLop == null )
			{
				equal = false;
			}
			if (Object1.HeSoLopDong != null && Object2.HeSoLopDong != null )
			{
				if (Object1.HeSoLopDong != Object2.HeSoLopDong)
					equal = false;
			}
			else if (Object1.HeSoLopDong == null ^ Object1.HeSoLopDong == null )
			{
				equal = false;
			}
			if (Object1.MaBacDaoTao != null && Object2.MaBacDaoTao != null )
			{
				if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
					equal = false;
			}
			else if (Object1.MaBacDaoTao == null ^ Object1.MaBacDaoTao == null )
			{
				equal = false;
			}
			if (Object1.MaHeDaoTao != null && Object2.MaHeDaoTao != null )
			{
				if (Object1.MaHeDaoTao != Object2.MaHeDaoTao)
					equal = false;
			}
			else if (Object1.MaHeDaoTao == null ^ Object1.MaHeDaoTao == null )
			{
				equal = false;
			}
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
			if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
				equal = false;
			if (Object1.LyThuyet != Object2.LyThuyet)
				equal = false;
			if (Object1.LyThuyetHs != null && Object2.LyThuyetHs != null )
			{
				if (Object1.LyThuyetHs != Object2.LyThuyetHs)
					equal = false;
			}
			else if (Object1.LyThuyetHs == null ^ Object1.LyThuyetHs == null )
			{
				equal = false;
			}
			if (Object1.ThucHanh != Object2.ThucHanh)
				equal = false;
			if (Object1.ThucHanhHs != null && Object2.ThucHanhHs != null )
			{
				if (Object1.ThucHanhHs != Object2.ThucHanhHs)
					equal = false;
			}
			else if (Object1.ThucHanhHs == null ^ Object1.ThucHanhHs == null )
			{
				equal = false;
			}
			if (Object1.Tong != null && Object2.Tong != null )
			{
				if (Object1.Tong != Object2.Tong)
					equal = false;
			}
			else if (Object1.Tong == null ^ Object1.Tong == null )
			{
				equal = false;
			}
			if (Object1.TongHs != null && Object2.TongHs != null )
			{
				if (Object1.TongHs != Object2.TongHs)
					equal = false;
			}
			else if (Object1.TongHs == null ^ Object1.TongHs == null )
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
		public static object GetPropertyValueByName(ViewTongHopGioDay entity, string propertyName)
		{
			switch (propertyName)
			{
				case "Ho":
					return entity.Ho;
				case "Ten":
					return entity.Ten;
				case "TenLop":
					return entity.TenLop;
				case "MaLop":
					return entity.MaLop;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "SiSoLop":
					return entity.SiSoLop;
				case "HeSoLopDong":
					return entity.HeSoLopDong;
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "MaHeDaoTao":
					return entity.MaHeDaoTao;
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "LyThuyet":
					return entity.LyThuyet;
				case "LyThuyetHs":
					return entity.LyThuyetHs;
				case "ThucHanh":
					return entity.ThucHanh;
				case "ThucHanhHs":
					return entity.ThucHanhHs;
				case "Tong":
					return entity.Tong;
				case "TongHs":
					return entity.TongHs;
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
			return GetPropertyValueByName(this as ViewTongHopGioDay, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{19}{18}- Ho: {0}{18}- Ten: {1}{18}- TenLop: {2}{18}- MaLop: {3}{18}- MaMonHoc: {4}{18}- TenMonHoc: {5}{18}- SiSoLop: {6}{18}- HeSoLopDong: {7}{18}- MaBacDaoTao: {8}{18}- MaHeDaoTao: {9}{18}- MaGiangVien: {10}{18}- MaLopHocPhan: {11}{18}- LyThuyet: {12}{18}- LyThuyetHs: {13}{18}- ThucHanh: {14}{18}- ThucHanhHs: {15}{18}- Tong: {16}{18}- TongHs: {17}{18}", 
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				this.TenLop,
				this.MaLop,
				this.MaMonHoc,
				this.TenMonHoc,
				(this.SiSoLop == null) ? string.Empty : this.SiSoLop.ToString(),
			     
				(this.HeSoLopDong == null) ? string.Empty : this.HeSoLopDong.ToString(),
			     
				(this.MaBacDaoTao == null) ? string.Empty : this.MaBacDaoTao.ToString(),
			     
				(this.MaHeDaoTao == null) ? string.Empty : this.MaHeDaoTao.ToString(),
			     
				this.MaGiangVien,
				this.MaLopHocPhan,
				this.LyThuyet,
				(this.LyThuyetHs == null) ? string.Empty : this.LyThuyetHs.ToString(),
			     
				this.ThucHanh,
				(this.ThucHanhHs == null) ? string.Empty : this.ThucHanhHs.ToString(),
			     
				(this.Tong == null) ? string.Empty : this.Tong.ToString(),
			     
				(this.TongHs == null) ? string.Empty : this.TongHs.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewTongHopGioDay columns.
	/// </summary>
	[Serializable]
	public enum ViewTongHopGioDayColumn
	{
		/// <summary>
		/// Ho : 
		/// </summary>
		[EnumTextValue("Ho")]
		[ColumnEnum("Ho", typeof(System.String), System.Data.DbType.String, false, false, true, 101)]
		Ho,
		/// <summary>
		/// Ten : 
		/// </summary>
		[EnumTextValue("Ten")]
		[ColumnEnum("Ten", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		Ten,
		/// <summary>
		/// TenLop : 
		/// </summary>
		[EnumTextValue("TenLop")]
		[ColumnEnum("TenLop", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenLop,
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLop,
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
		/// SiSoLop : 
		/// </summary>
		[EnumTextValue("SiSoLop")]
		[ColumnEnum("SiSoLop", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSoLop,
		/// <summary>
		/// HeSoLopDong : 
		/// </summary>
		[EnumTextValue("HeSoLopDong")]
		[ColumnEnum("HeSoLopDong", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		HeSoLopDong,
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		[EnumTextValue("MaBacDaoTao")]
		[ColumnEnum("MaBacDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaBacDaoTao,
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		[EnumTextValue("MaHeDaoTao")]
		[ColumnEnum("MaHeDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaHeDaoTao,
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaGiangVien,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLopHocPhan,
		/// <summary>
		/// LyThuyet : 
		/// </summary>
		[EnumTextValue("LyThuyet")]
		[ColumnEnum("LyThuyet", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		LyThuyet,
		/// <summary>
		/// LyThuyetHS : 
		/// </summary>
		[EnumTextValue("LyThuyetHS")]
		[ColumnEnum("LyThuyetHS", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		LyThuyetHs,
		/// <summary>
		/// ThucHanh : 
		/// </summary>
		[EnumTextValue("ThucHanh")]
		[ColumnEnum("ThucHanh", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		ThucHanh,
		/// <summary>
		/// ThucHanhHS : 
		/// </summary>
		[EnumTextValue("ThucHanhHS")]
		[ColumnEnum("ThucHanhHS", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		ThucHanhHs,
		/// <summary>
		/// Tong : 
		/// </summary>
		[EnumTextValue("Tong")]
		[ColumnEnum("Tong", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		Tong,
		/// <summary>
		/// TongHS : 
		/// </summary>
		[EnumTextValue("TongHS")]
		[ColumnEnum("TongHS", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TongHs
	}//End enum

} // end namespace