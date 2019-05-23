﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewSoTietCoiThiTieuChuanCuaGiangVien.cs instead.
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
	/// An object representation of the 'View_SoTietCoiThiTieuChuanCuaGiangVien' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewSoTietCoiThiTieuChuanCuaGiangVienBase")]
	public abstract partial class ViewSoTietCoiThiTieuChuanCuaGiangVienBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
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
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// TenHocHam : 
		/// </summary>
		private System.String		  _tenHocHam = null;
		
		/// <summary>
		/// TenHocVi : 
		/// </summary>
		private System.String		  _tenHocVi = null;
		
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		private System.String		  _tenLoaiGiangVien = null;
		
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		private System.String		  _tenDonVi = string.Empty;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// SoTietCoiThiTieuChuan : 
		/// </summary>
		private System.Decimal?		  _soTietCoiThiTieuChuan = null;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.String		  _ngayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		private System.String		  _nguoiCapNhat = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		private System.String		  _ghiChu = null;
		
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
		/// Creates a new <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> instance.
		///</summary>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_soTietCoiThiTieuChuan"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_ghiChu"></param>
		public ViewSoTietCoiThiTieuChuanCuaGiangVienBase(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _tenDonVi, System.String _namHoc, System.Decimal? _soTietCoiThiTieuChuan, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.String _ghiChu)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._hoTen = _hoTen;
			this._tenHocHam = _tenHocHam;
			this._tenHocVi = _tenHocVi;
			this._tenLoaiGiangVien = _tenLoaiGiangVien;
			this._tenDonVi = _tenDonVi;
			this._namHoc = _namHoc;
			this._soTietCoiThiTieuChuan = _soTietCoiThiTieuChuan;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
			this._ghiChu = _ghiChu;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_soTietCoiThiTieuChuan"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_ghiChu"></param>
		public static ViewSoTietCoiThiTieuChuanCuaGiangVien CreateViewSoTietCoiThiTieuChuanCuaGiangVien(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _hoTen, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _tenDonVi, System.String _namHoc, System.Decimal? _soTietCoiThiTieuChuan, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.String _ghiChu)
		{
			ViewSoTietCoiThiTieuChuanCuaGiangVien newViewSoTietCoiThiTieuChuanCuaGiangVien = new ViewSoTietCoiThiTieuChuanCuaGiangVien();
			newViewSoTietCoiThiTieuChuanCuaGiangVien.MaGiangVien = _maGiangVien;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.MaQuanLy = _maQuanLy;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.HoTen = _hoTen;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.TenHocHam = _tenHocHam;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.TenHocVi = _tenHocVi;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.TenLoaiGiangVien = _tenLoaiGiangVien;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.TenDonVi = _tenDonVi;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.NamHoc = _namHoc;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.SoTietCoiThiTieuChuan = _soTietCoiThiTieuChuan;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.NgayCapNhat = _ngayCapNhat;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.NguoiCapNhat = _nguoiCapNhat;
			newViewSoTietCoiThiTieuChuanCuaGiangVien.GhiChu = _ghiChu;
			return newViewSoTietCoiThiTieuChuanCuaGiangVien;
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
		/// 	Gets or Sets the TenHocHam property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHocHam
		{
			get
			{
				return this._tenHocHam; 
			}
			set
			{
				if (_tenHocHam == value)
					return;
					
				this._tenHocHam = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHocHam");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHocVi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHocVi
		{
			get
			{
				return this._tenHocVi; 
			}
			set
			{
				if (_tenHocVi == value)
					return;
					
				this._tenHocVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHocVi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLoaiGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLoaiGiangVien
		{
			get
			{
				return this._tenLoaiGiangVien; 
			}
			set
			{
				if (_tenLoaiGiangVien == value)
					return;
					
				this._tenLoaiGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLoaiGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenDonVi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenDonVi
		{
			get
			{
				return this._tenDonVi; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenDonVi does not allow null values.");
				if (_tenDonVi == value)
					return;
					
				this._tenDonVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenDonVi");
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
		/// 	Gets or Sets the SoTietCoiThiTieuChuan property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsSoTietCoiThiTieuChuanNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SoTietCoiThiTieuChuan
		{
			get
			{
				return this._soTietCoiThiTieuChuan; 
			}
			set
			{
				if (_soTietCoiThiTieuChuan == value && SoTietCoiThiTieuChuan != null )
					return;
					
				this._soTietCoiThiTieuChuan = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTietCoiThiTieuChuan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NgayCapNhat
		{
			get
			{
				return this._ngayCapNhat; 
			}
			set
			{
				if (_ngayCapNhat == value)
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
		/// 	Gets or Sets the GhiChu property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String GhiChu
		{
			get
			{
				return this._ghiChu; 
			}
			set
			{
				if (_ghiChu == value)
					return;
					
				this._ghiChu = value;
				this._isDirty = true;
				
				OnPropertyChanged("GhiChu");
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
			get { return "View_SoTietCoiThiTieuChuanCuaGiangVien"; }
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
		///  Returns a Typed ViewSoTietCoiThiTieuChuanCuaGiangVienBase Entity 
		///</summary>
		public virtual ViewSoTietCoiThiTieuChuanCuaGiangVienBase Copy()
		{
			//shallow copy entity
			ViewSoTietCoiThiTieuChuanCuaGiangVien copy = new ViewSoTietCoiThiTieuChuanCuaGiangVien();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.HoTen = this.HoTen;
				copy.TenHocHam = this.TenHocHam;
				copy.TenHocVi = this.TenHocVi;
				copy.TenLoaiGiangVien = this.TenLoaiGiangVien;
				copy.TenDonVi = this.TenDonVi;
				copy.NamHoc = this.NamHoc;
				copy.SoTietCoiThiTieuChuan = this.SoTietCoiThiTieuChuan;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
				copy.GhiChu = this.GhiChu;
			copy.AcceptChanges();
			return (ViewSoTietCoiThiTieuChuanCuaGiangVien)copy;
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
		///<returns>true if toObject is a <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewSoTietCoiThiTieuChuanCuaGiangVienBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVienBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewSoTietCoiThiTieuChuanCuaGiangVienBase Object1, ViewSoTietCoiThiTieuChuanCuaGiangVienBase Object2)
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
			if (Object1.HoTen != null && Object2.HoTen != null )
			{
				if (Object1.HoTen != Object2.HoTen)
					equal = false;
			}
			else if (Object1.HoTen == null ^ Object1.HoTen == null )
			{
				equal = false;
			}
			if (Object1.TenHocHam != null && Object2.TenHocHam != null )
			{
				if (Object1.TenHocHam != Object2.TenHocHam)
					equal = false;
			}
			else if (Object1.TenHocHam == null ^ Object1.TenHocHam == null )
			{
				equal = false;
			}
			if (Object1.TenHocVi != null && Object2.TenHocVi != null )
			{
				if (Object1.TenHocVi != Object2.TenHocVi)
					equal = false;
			}
			else if (Object1.TenHocVi == null ^ Object1.TenHocVi == null )
			{
				equal = false;
			}
			if (Object1.TenLoaiGiangVien != null && Object2.TenLoaiGiangVien != null )
			{
				if (Object1.TenLoaiGiangVien != Object2.TenLoaiGiangVien)
					equal = false;
			}
			else if (Object1.TenLoaiGiangVien == null ^ Object1.TenLoaiGiangVien == null )
			{
				equal = false;
			}
			if (Object1.TenDonVi != Object2.TenDonVi)
				equal = false;
			if (Object1.NamHoc != null && Object2.NamHoc != null )
			{
				if (Object1.NamHoc != Object2.NamHoc)
					equal = false;
			}
			else if (Object1.NamHoc == null ^ Object1.NamHoc == null )
			{
				equal = false;
			}
			if (Object1.SoTietCoiThiTieuChuan != null && Object2.SoTietCoiThiTieuChuan != null )
			{
				if (Object1.SoTietCoiThiTieuChuan != Object2.SoTietCoiThiTieuChuan)
					equal = false;
			}
			else if (Object1.SoTietCoiThiTieuChuan == null ^ Object1.SoTietCoiThiTieuChuan == null )
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
			if (Object1.GhiChu != null && Object2.GhiChu != null )
			{
				if (Object1.GhiChu != Object2.GhiChu)
					equal = false;
			}
			else if (Object1.GhiChu == null ^ Object1.GhiChu == null )
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
		public static object GetPropertyValueByName(ViewSoTietCoiThiTieuChuanCuaGiangVien entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "HoTen":
					return entity.HoTen;
				case "TenHocHam":
					return entity.TenHocHam;
				case "TenHocVi":
					return entity.TenHocVi;
				case "TenLoaiGiangVien":
					return entity.TenLoaiGiangVien;
				case "TenDonVi":
					return entity.TenDonVi;
				case "NamHoc":
					return entity.NamHoc;
				case "SoTietCoiThiTieuChuan":
					return entity.SoTietCoiThiTieuChuan;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "NguoiCapNhat":
					return entity.NguoiCapNhat;
				case "GhiChu":
					return entity.GhiChu;
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
			return GetPropertyValueByName(this as ViewSoTietCoiThiTieuChuanCuaGiangVien, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{13}{12}- MaGiangVien: {0}{12}- MaQuanLy: {1}{12}- HoTen: {2}{12}- TenHocHam: {3}{12}- TenHocVi: {4}{12}- TenLoaiGiangVien: {5}{12}- TenDonVi: {6}{12}- NamHoc: {7}{12}- SoTietCoiThiTieuChuan: {8}{12}- NgayCapNhat: {9}{12}- NguoiCapNhat: {10}{12}- GhiChu: {11}{12}", 
				this.MaGiangVien,
				this.MaQuanLy,
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.TenHocHam == null) ? string.Empty : this.TenHocHam.ToString(),
			     
				(this.TenHocVi == null) ? string.Empty : this.TenHocVi.ToString(),
			     
				(this.TenLoaiGiangVien == null) ? string.Empty : this.TenLoaiGiangVien.ToString(),
			     
				this.TenDonVi,
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.SoTietCoiThiTieuChuan == null) ? string.Empty : this.SoTietCoiThiTieuChuan.ToString(),
			     
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewSoTietCoiThiTieuChuanCuaGiangVien columns.
	/// </summary>
	[Serializable]
	public enum ViewSoTietCoiThiTieuChuanCuaGiangVienColumn
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
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// TenHocHam : 
		/// </summary>
		[EnumTextValue("TenHocHam")]
		[ColumnEnum("TenHocHam", typeof(System.String), System.Data.DbType.String, false, false, true, 200)]
		TenHocHam,
		/// <summary>
		/// TenHocVi : 
		/// </summary>
		[EnumTextValue("TenHocVi")]
		[ColumnEnum("TenHocVi", typeof(System.String), System.Data.DbType.String, false, false, true, 200)]
		TenHocVi,
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		[EnumTextValue("TenLoaiGiangVien")]
		[ColumnEnum("TenLoaiGiangVien", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenLoaiGiangVien,
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		[EnumTextValue("TenDonVi")]
		[ColumnEnum("TenDonVi", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenDonVi,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// SoTietCoiThiTieuChuan : 
		/// </summary>
		[EnumTextValue("SoTietCoiThiTieuChuan")]
		[ColumnEnum("SoTietCoiThiTieuChuan", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		SoTietCoiThiTieuChuan,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NgayCapNhat,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("NguoiCapNhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("GhiChu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true, 500)]
		GhiChu
	}//End enum

} // end namespace