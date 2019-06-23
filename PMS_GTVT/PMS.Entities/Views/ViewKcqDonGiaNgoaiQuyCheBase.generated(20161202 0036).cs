﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKcqDonGiaNgoaiQuyChe.cs instead.
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
	/// An object representation of the 'View_KcqDonGiaNgoaiQuyChe' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewKcqDonGiaNgoaiQuyCheBase")]
	public abstract partial class ViewKcqDonGiaNgoaiQuyCheBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
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
		/// Ho : 
		/// </summary>
		private System.String		  _ho = null;
		
		/// <summary>
		/// Ten : 
		/// </summary>
		private System.String		  _ten = null;
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// DonGiaDaiTra : 
		/// </summary>
		private System.Decimal?		  _donGiaDaiTra = null;
		
		/// <summary>
		/// DonGiaClc : 
		/// </summary>
		private System.Decimal?		  _donGiaClc = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		private System.String		  _ghiChu = null;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.DateTime?		  _ngayCapNhat = null;
		
		/// <summary>
		/// TuNgay : 
		/// </summary>
		private System.DateTime?		  _tuNgay = null;
		
		/// <summary>
		/// DenNgay : 
		/// </summary>
		private System.DateTime?		  _denNgay = null;
		
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
		/// Creates a new <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> instance.
		///</summary>
		public ViewKcqDonGiaNgoaiQuyCheBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_donGiaDaiTra"></param>
		///<param name="_donGiaClc"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_tuNgay"></param>
		///<param name="_denNgay"></param>
		public ViewKcqDonGiaNgoaiQuyCheBase(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _namHoc, System.String _hocKy, System.Decimal? _donGiaDaiTra, System.Decimal? _donGiaClc, System.String _ghiChu, System.DateTime? _ngayCapNhat, System.DateTime? _tuNgay, System.DateTime? _denNgay)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._ho = _ho;
			this._ten = _ten;
			this._hoTen = _hoTen;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._donGiaDaiTra = _donGiaDaiTra;
			this._donGiaClc = _donGiaClc;
			this._ghiChu = _ghiChu;
			this._ngayCapNhat = _ngayCapNhat;
			this._tuNgay = _tuNgay;
			this._denNgay = _denNgay;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKcqDonGiaNgoaiQuyChe"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_donGiaDaiTra"></param>
		///<param name="_donGiaClc"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_tuNgay"></param>
		///<param name="_denNgay"></param>
		public static ViewKcqDonGiaNgoaiQuyChe CreateViewKcqDonGiaNgoaiQuyChe(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _namHoc, System.String _hocKy, System.Decimal? _donGiaDaiTra, System.Decimal? _donGiaClc, System.String _ghiChu, System.DateTime? _ngayCapNhat, System.DateTime? _tuNgay, System.DateTime? _denNgay)
		{
			ViewKcqDonGiaNgoaiQuyChe newViewKcqDonGiaNgoaiQuyChe = new ViewKcqDonGiaNgoaiQuyChe();
			newViewKcqDonGiaNgoaiQuyChe.MaGiangVien = _maGiangVien;
			newViewKcqDonGiaNgoaiQuyChe.MaQuanLy = _maQuanLy;
			newViewKcqDonGiaNgoaiQuyChe.Ho = _ho;
			newViewKcqDonGiaNgoaiQuyChe.Ten = _ten;
			newViewKcqDonGiaNgoaiQuyChe.HoTen = _hoTen;
			newViewKcqDonGiaNgoaiQuyChe.NamHoc = _namHoc;
			newViewKcqDonGiaNgoaiQuyChe.HocKy = _hocKy;
			newViewKcqDonGiaNgoaiQuyChe.DonGiaDaiTra = _donGiaDaiTra;
			newViewKcqDonGiaNgoaiQuyChe.DonGiaClc = _donGiaClc;
			newViewKcqDonGiaNgoaiQuyChe.GhiChu = _ghiChu;
			newViewKcqDonGiaNgoaiQuyChe.NgayCapNhat = _ngayCapNhat;
			newViewKcqDonGiaNgoaiQuyChe.TuNgay = _tuNgay;
			newViewKcqDonGiaNgoaiQuyChe.DenNgay = _denNgay;
			return newViewKcqDonGiaNgoaiQuyChe;
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
		/// 	Gets or Sets the Ho property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
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
		/// 	Gets or Sets the DonGiaDaiTra property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsDonGiaDaiTraNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? DonGiaDaiTra
		{
			get
			{
				return this._donGiaDaiTra; 
			}
			set
			{
				if (_donGiaDaiTra == value && DonGiaDaiTra != null )
					return;
					
				this._donGiaDaiTra = value;
				this._isDirty = true;
				
				OnPropertyChanged("DonGiaDaiTra");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DonGiaClc property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsDonGiaClcNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? DonGiaClc
		{
			get
			{
				return this._donGiaClc; 
			}
			set
			{
				if (_donGiaClc == value && DonGiaClc != null )
					return;
					
				this._donGiaClc = value;
				this._isDirty = true;
				
				OnPropertyChanged("DonGiaClc");
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
		/// 	Gets or Sets the TuNgay property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsTuNgayNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? TuNgay
		{
			get
			{
				return this._tuNgay; 
			}
			set
			{
				if (_tuNgay == value && TuNgay != null )
					return;
					
				this._tuNgay = value;
				this._isDirty = true;
				
				OnPropertyChanged("TuNgay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DenNgay property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsDenNgayNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? DenNgay
		{
			get
			{
				return this._denNgay; 
			}
			set
			{
				if (_denNgay == value && DenNgay != null )
					return;
					
				this._denNgay = value;
				this._isDirty = true;
				
				OnPropertyChanged("DenNgay");
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
			get { return "View_KcqDonGiaNgoaiQuyChe"; }
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
		///  Returns a Typed ViewKcqDonGiaNgoaiQuyCheBase Entity 
		///</summary>
		public virtual ViewKcqDonGiaNgoaiQuyCheBase Copy()
		{
			//shallow copy entity
			ViewKcqDonGiaNgoaiQuyChe copy = new ViewKcqDonGiaNgoaiQuyChe();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.HoTen = this.HoTen;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.DonGiaDaiTra = this.DonGiaDaiTra;
				copy.DonGiaClc = this.DonGiaClc;
				copy.GhiChu = this.GhiChu;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.TuNgay = this.TuNgay;
				copy.DenNgay = this.DenNgay;
			copy.AcceptChanges();
			return (ViewKcqDonGiaNgoaiQuyChe)copy;
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
		///<returns>true if toObject is a <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewKcqDonGiaNgoaiQuyCheBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewKcqDonGiaNgoaiQuyCheBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewKcqDonGiaNgoaiQuyCheBase Object1, ViewKcqDonGiaNgoaiQuyCheBase Object2)
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
			if (Object1.HoTen != null && Object2.HoTen != null )
			{
				if (Object1.HoTen != Object2.HoTen)
					equal = false;
			}
			else if (Object1.HoTen == null ^ Object1.HoTen == null )
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
			if (Object1.DonGiaDaiTra != null && Object2.DonGiaDaiTra != null )
			{
				if (Object1.DonGiaDaiTra != Object2.DonGiaDaiTra)
					equal = false;
			}
			else if (Object1.DonGiaDaiTra == null ^ Object1.DonGiaDaiTra == null )
			{
				equal = false;
			}
			if (Object1.DonGiaClc != null && Object2.DonGiaClc != null )
			{
				if (Object1.DonGiaClc != Object2.DonGiaClc)
					equal = false;
			}
			else if (Object1.DonGiaClc == null ^ Object1.DonGiaClc == null )
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
			if (Object1.NgayCapNhat != null && Object2.NgayCapNhat != null )
			{
				if (Object1.NgayCapNhat != Object2.NgayCapNhat)
					equal = false;
			}
			else if (Object1.NgayCapNhat == null ^ Object1.NgayCapNhat == null )
			{
				equal = false;
			}
			if (Object1.TuNgay != null && Object2.TuNgay != null )
			{
				if (Object1.TuNgay != Object2.TuNgay)
					equal = false;
			}
			else if (Object1.TuNgay == null ^ Object1.TuNgay == null )
			{
				equal = false;
			}
			if (Object1.DenNgay != null && Object2.DenNgay != null )
			{
				if (Object1.DenNgay != Object2.DenNgay)
					equal = false;
			}
			else if (Object1.DenNgay == null ^ Object1.DenNgay == null )
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
		public static object GetPropertyValueByName(ViewKcqDonGiaNgoaiQuyChe entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "Ho":
					return entity.Ho;
				case "Ten":
					return entity.Ten;
				case "HoTen":
					return entity.HoTen;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "DonGiaDaiTra":
					return entity.DonGiaDaiTra;
				case "DonGiaClc":
					return entity.DonGiaClc;
				case "GhiChu":
					return entity.GhiChu;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "TuNgay":
					return entity.TuNgay;
				case "DenNgay":
					return entity.DenNgay;
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
			return GetPropertyValueByName(this as ViewKcqDonGiaNgoaiQuyChe, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{14}{13}- MaGiangVien: {0}{13}- MaQuanLy: {1}{13}- Ho: {2}{13}- Ten: {3}{13}- HoTen: {4}{13}- NamHoc: {5}{13}- HocKy: {6}{13}- DonGiaDaiTra: {7}{13}- DonGiaClc: {8}{13}- GhiChu: {9}{13}- NgayCapNhat: {10}{13}- TuNgay: {11}{13}- DenNgay: {12}{13}", 
				this.MaGiangVien,
				this.MaQuanLy,
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				(this.DonGiaDaiTra == null) ? string.Empty : this.DonGiaDaiTra.ToString(),
			     
				(this.DonGiaClc == null) ? string.Empty : this.DonGiaClc.ToString(),
			     
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
			     
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.TuNgay == null) ? string.Empty : this.TuNgay.ToString(),
			     
				(this.DenNgay == null) ? string.Empty : this.DenNgay.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewKcqDonGiaNgoaiQuyChe columns.
	/// </summary>
	[Serializable]
	public enum ViewKcqDonGiaNgoaiQuyCheColumn
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
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
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
		/// DonGiaDaiTra : 
		/// </summary>
		[EnumTextValue("DonGiaDaiTra")]
		[ColumnEnum("DonGiaDaiTra", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		DonGiaDaiTra,
		/// <summary>
		/// DonGiaClc : 
		/// </summary>
		[EnumTextValue("DonGiaClc")]
		[ColumnEnum("DonGiaClc", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		DonGiaClc,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("GhiChu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true, 2000)]
		GhiChu,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayCapNhat,
		/// <summary>
		/// TuNgay : 
		/// </summary>
		[EnumTextValue("TuNgay")]
		[ColumnEnum("TuNgay", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		TuNgay,
		/// <summary>
		/// DenNgay : 
		/// </summary>
		[EnumTextValue("DenNgay")]
		[ColumnEnum("DenNgay", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		DenNgay
	}//End enum

} // end namespace
