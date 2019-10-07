﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewMonTinhTheoQuyCheMoi.cs instead.
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
	/// An object representation of the 'View_MonTinhTheoQuyCheMoi' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewMonTinhTheoQuyCheMoiBase")]
	public abstract partial class ViewMonTinhTheoQuyCheMoiBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// Id : 
		/// </summary>
		private System.Int32		  _id = (int)0;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = string.Empty;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// SoTinChi : 
		/// </summary>
		private System.Decimal		  _soTinChi = 0.0m;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.String		  _ngayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		private System.String		  _nguoiCapNhat = null;
		
		/// <summary>
		/// Chon : 
		/// </summary>
		private System.Boolean?		  _chon = null;
		
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
		/// Creates a new <see cref="ViewMonTinhTheoQuyCheMoiBase"/> instance.
		///</summary>
		public ViewMonTinhTheoQuyCheMoiBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewMonTinhTheoQuyCheMoiBase"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_soTinChi"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_chon"></param>
		public ViewMonTinhTheoQuyCheMoiBase(System.Int32 _id, System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal _soTinChi, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.Boolean? _chon)
		{
			this._id = _id;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._soTinChi = _soTinChi;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
			this._chon = _chon;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewMonTinhTheoQuyCheMoi"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_soTinChi"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_chon"></param>
		public static ViewMonTinhTheoQuyCheMoi CreateViewMonTinhTheoQuyCheMoi(System.Int32 _id, System.String _namHoc, System.String _hocKy, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal _soTinChi, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.Boolean? _chon)
		{
			ViewMonTinhTheoQuyCheMoi newViewMonTinhTheoQuyCheMoi = new ViewMonTinhTheoQuyCheMoi();
			newViewMonTinhTheoQuyCheMoi.Id = _id;
			newViewMonTinhTheoQuyCheMoi.NamHoc = _namHoc;
			newViewMonTinhTheoQuyCheMoi.HocKy = _hocKy;
			newViewMonTinhTheoQuyCheMoi.MaMonHoc = _maMonHoc;
			newViewMonTinhTheoQuyCheMoi.TenMonHoc = _tenMonHoc;
			newViewMonTinhTheoQuyCheMoi.SoTinChi = _soTinChi;
			newViewMonTinhTheoQuyCheMoi.NgayCapNhat = _ngayCapNhat;
			newViewMonTinhTheoQuyCheMoi.NguoiCapNhat = _nguoiCapNhat;
			newViewMonTinhTheoQuyCheMoi.Chon = _chon;
			return newViewMonTinhTheoQuyCheMoi;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the Id property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 Id
		{
			get
			{
				return this._id; 
			}
			set
			{
				if (_id == value)
					return;
					
				this._id = value;
				this._isDirty = true;
				
				OnPropertyChanged("Id");
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
		/// 	Gets or Sets the SoTinChi property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal SoTinChi
		{
			get
			{
				return this._soTinChi; 
			}
			set
			{
				if (_soTinChi == value)
					return;
					
				this._soTinChi = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTinChi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
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
		/// 	Gets or Sets the Chon property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsChonNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean? Chon
		{
			get
			{
				return this._chon; 
			}
			set
			{
				if (_chon == value && Chon != null )
					return;
					
				this._chon = value;
				this._isDirty = true;
				
				OnPropertyChanged("Chon");
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
			get { return "View_MonTinhTheoQuyCheMoi"; }
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
		///  Returns a Typed ViewMonTinhTheoQuyCheMoiBase Entity 
		///</summary>
		public virtual ViewMonTinhTheoQuyCheMoiBase Copy()
		{
			//shallow copy entity
			ViewMonTinhTheoQuyCheMoi copy = new ViewMonTinhTheoQuyCheMoi();
				copy.Id = this.Id;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.SoTinChi = this.SoTinChi;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
				copy.Chon = this.Chon;
			copy.AcceptChanges();
			return (ViewMonTinhTheoQuyCheMoi)copy;
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
		///<returns>true if toObject is a <see cref="ViewMonTinhTheoQuyCheMoiBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewMonTinhTheoQuyCheMoiBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewMonTinhTheoQuyCheMoiBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewMonTinhTheoQuyCheMoiBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewMonTinhTheoQuyCheMoiBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewMonTinhTheoQuyCheMoiBase Object1, ViewMonTinhTheoQuyCheMoiBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.Id != Object2.Id)
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
			if (Object1.HocKy != null && Object2.HocKy != null )
			{
				if (Object1.HocKy != Object2.HocKy)
					equal = false;
			}
			else if (Object1.HocKy == null ^ Object1.HocKy == null )
			{
				equal = false;
			}
			if (Object1.MaMonHoc != Object2.MaMonHoc)
				equal = false;
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.SoTinChi != Object2.SoTinChi)
				equal = false;
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
			if (Object1.Chon != null && Object2.Chon != null )
			{
				if (Object1.Chon != Object2.Chon)
					equal = false;
			}
			else if (Object1.Chon == null ^ Object1.Chon == null )
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
		public static object GetPropertyValueByName(ViewMonTinhTheoQuyCheMoi entity, string propertyName)
		{
			switch (propertyName)
			{
				case "Id":
					return entity.Id;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "SoTinChi":
					return entity.SoTinChi;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "NguoiCapNhat":
					return entity.NguoiCapNhat;
				case "Chon":
					return entity.Chon;
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
			return GetPropertyValueByName(this as ViewMonTinhTheoQuyCheMoi, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{10}{9}- Id: {0}{9}- NamHoc: {1}{9}- HocKy: {2}{9}- MaMonHoc: {3}{9}- TenMonHoc: {4}{9}- SoTinChi: {5}{9}- NgayCapNhat: {6}{9}- NguoiCapNhat: {7}{9}- Chon: {8}{9}", 
				this.Id,
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				this.MaMonHoc,
				this.TenMonHoc,
				this.SoTinChi,
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				(this.Chon == null) ? string.Empty : this.Chon.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewMonTinhTheoQuyCheMoi columns.
	/// </summary>
	[Serializable]
	public enum ViewMonTinhTheoQuyCheMoiColumn
	{
		/// <summary>
		/// Id : 
		/// </summary>
		[EnumTextValue("Id")]
		[ColumnEnum("Id", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		Id,
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
		/// SoTinChi : 
		/// </summary>
		[EnumTextValue("SoTinChi")]
		[ColumnEnum("SoTinChi", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		SoTinChi,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 50)]
		NgayCapNhat,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("NguoiCapNhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat,
		/// <summary>
		/// Chon : 
		/// </summary>
		[EnumTextValue("Chon")]
		[ColumnEnum("Chon", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		Chon
	}//End enum

} // end namespace