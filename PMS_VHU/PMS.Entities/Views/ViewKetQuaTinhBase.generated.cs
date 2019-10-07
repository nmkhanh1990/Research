﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKetQuaTinh.cs instead.
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
	/// An object representation of the 'View_KetQuaTinh' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewKetQuaTinhBase")]
	public abstract partial class ViewKetQuaTinhBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaKetQua : 
		/// </summary>
		private System.Int32		  _maKetQua = (int)0;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32?		  _maGiangVien = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// DonGia : 
		/// </summary>
		private System.Decimal?		  _donGia = null;
		
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		private System.Int32?		  _tietNghiaVu = null;
		
		/// <summary>
		/// TietGioiHan : 
		/// </summary>
		private System.Int32?		  _tietGioiHan = null;
		
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
		/// Creates a new <see cref="ViewKetQuaTinhBase"/> instance.
		///</summary>
		public ViewKetQuaTinhBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewKetQuaTinhBase"/> instance.
		///</summary>
		///<param name="_maKetQua"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_donGia"></param>
		///<param name="_tietNghiaVu"></param>
		///<param name="_tietGioiHan"></param>
		public ViewKetQuaTinhBase(System.Int32 _maKetQua, System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, System.Decimal? _donGia, System.Int32? _tietNghiaVu, System.Int32? _tietGioiHan)
		{
			this._maKetQua = _maKetQua;
			this._maGiangVien = _maGiangVien;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._donGia = _donGia;
			this._tietNghiaVu = _tietNghiaVu;
			this._tietGioiHan = _tietGioiHan;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewKetQuaTinh"/> instance.
		///</summary>
		///<param name="_maKetQua"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_donGia"></param>
		///<param name="_tietNghiaVu"></param>
		///<param name="_tietGioiHan"></param>
		public static ViewKetQuaTinh CreateViewKetQuaTinh(System.Int32 _maKetQua, System.Int32? _maGiangVien, System.String _namHoc, System.String _hocKy, System.Decimal? _donGia, System.Int32? _tietNghiaVu, System.Int32? _tietGioiHan)
		{
			ViewKetQuaTinh newViewKetQuaTinh = new ViewKetQuaTinh();
			newViewKetQuaTinh.MaKetQua = _maKetQua;
			newViewKetQuaTinh.MaGiangVien = _maGiangVien;
			newViewKetQuaTinh.NamHoc = _namHoc;
			newViewKetQuaTinh.HocKy = _hocKy;
			newViewKetQuaTinh.DonGia = _donGia;
			newViewKetQuaTinh.TietNghiaVu = _tietNghiaVu;
			newViewKetQuaTinh.TietGioiHan = _tietGioiHan;
			return newViewKetQuaTinh;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaKetQua property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaKetQua
		{
			get
			{
				return this._maKetQua; 
			}
			set
			{
				if (_maKetQua == value)
					return;
					
				this._maKetQua = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKetQua");
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
		/// 	Gets or Sets the TietGioiHan property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsTietGioiHanNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? TietGioiHan
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
			get { return "View_KetQuaTinh"; }
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
		///  Returns a Typed ViewKetQuaTinhBase Entity 
		///</summary>
		public virtual ViewKetQuaTinhBase Copy()
		{
			//shallow copy entity
			ViewKetQuaTinh copy = new ViewKetQuaTinh();
				copy.MaKetQua = this.MaKetQua;
				copy.MaGiangVien = this.MaGiangVien;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.DonGia = this.DonGia;
				copy.TietNghiaVu = this.TietNghiaVu;
				copy.TietGioiHan = this.TietGioiHan;
			copy.AcceptChanges();
			return (ViewKetQuaTinh)copy;
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
		///<returns>true if toObject is a <see cref="ViewKetQuaTinhBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewKetQuaTinhBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewKetQuaTinhBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewKetQuaTinhBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewKetQuaTinhBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewKetQuaTinhBase Object1, ViewKetQuaTinhBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaKetQua != Object2.MaKetQua)
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
			if (Object1.DonGia != null && Object2.DonGia != null )
			{
				if (Object1.DonGia != Object2.DonGia)
					equal = false;
			}
			else if (Object1.DonGia == null ^ Object1.DonGia == null )
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
			if (Object1.TietGioiHan != null && Object2.TietGioiHan != null )
			{
				if (Object1.TietGioiHan != Object2.TietGioiHan)
					equal = false;
			}
			else if (Object1.TietGioiHan == null ^ Object1.TietGioiHan == null )
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
		public static object GetPropertyValueByName(ViewKetQuaTinh entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaKetQua":
					return entity.MaKetQua;
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "DonGia":
					return entity.DonGia;
				case "TietNghiaVu":
					return entity.TietNghiaVu;
				case "TietGioiHan":
					return entity.TietGioiHan;
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
			return GetPropertyValueByName(this as ViewKetQuaTinh, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{8}{7}- MaKetQua: {0}{7}- MaGiangVien: {1}{7}- NamHoc: {2}{7}- HocKy: {3}{7}- DonGia: {4}{7}- TietNghiaVu: {5}{7}- TietGioiHan: {6}{7}", 
				this.MaKetQua,
				(this.MaGiangVien == null) ? string.Empty : this.MaGiangVien.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				(this.DonGia == null) ? string.Empty : this.DonGia.ToString(),
			     
				(this.TietNghiaVu == null) ? string.Empty : this.TietNghiaVu.ToString(),
			     
				(this.TietGioiHan == null) ? string.Empty : this.TietGioiHan.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewKetQuaTinh columns.
	/// </summary>
	[Serializable]
	public enum ViewKetQuaTinhColumn
	{
		/// <summary>
		/// MaKetQua : 
		/// </summary>
		[EnumTextValue("MaKetQua")]
		[ColumnEnum("MaKetQua", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaKetQua,
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaGiangVien,
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
		/// DonGia : 
		/// </summary>
		[EnumTextValue("DonGia")]
		[ColumnEnum("DonGia", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		DonGia,
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		[EnumTextValue("TietNghiaVu")]
		[ColumnEnum("TietNghiaVu", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		TietNghiaVu,
		/// <summary>
		/// TietGioiHan : 
		/// </summary>
		[EnumTextValue("TietGioiHan")]
		[ColumnEnum("TietGioiHan", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		TietGioiHan
	}//End enum

} // end namespace