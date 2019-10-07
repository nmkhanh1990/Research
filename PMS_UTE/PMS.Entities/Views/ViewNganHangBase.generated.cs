﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewNganHang.cs instead.
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
	/// An object representation of the 'View_NganHang' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewNganHangBase")]
	public abstract partial class ViewNganHangBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// HRMID : 
		/// </summary>
		private System.Guid		  _hrmid = Guid.Empty;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = null;
		
		/// <summary>
		/// TenNganHang : 
		/// </summary>
		private System.String		  _tenNganHang = null;
		
		/// <summary>
		/// TenVietTat : 
		/// </summary>
		private System.String		  _tenVietTat = null;
		
		/// <summary>
		/// TrucThuoc : 
		/// </summary>
		private System.String		  _trucThuoc = string.Empty;
		
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
		/// Creates a new <see cref="ViewNganHangBase"/> instance.
		///</summary>
		public ViewNganHangBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewNganHangBase"/> instance.
		///</summary>
		///<param name="_hrmid"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_tenNganHang"></param>
		///<param name="_tenVietTat"></param>
		///<param name="_trucThuoc"></param>
		public ViewNganHangBase(System.Guid _hrmid, System.String _maQuanLy, System.String _tenNganHang, System.String _tenVietTat, System.String _trucThuoc)
		{
			this._hrmid = _hrmid;
			this._maQuanLy = _maQuanLy;
			this._tenNganHang = _tenNganHang;
			this._tenVietTat = _tenVietTat;
			this._trucThuoc = _trucThuoc;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewNganHang"/> instance.
		///</summary>
		///<param name="_hrmid"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_tenNganHang"></param>
		///<param name="_tenVietTat"></param>
		///<param name="_trucThuoc"></param>
		public static ViewNganHang CreateViewNganHang(System.Guid _hrmid, System.String _maQuanLy, System.String _tenNganHang, System.String _tenVietTat, System.String _trucThuoc)
		{
			ViewNganHang newViewNganHang = new ViewNganHang();
			newViewNganHang.Hrmid = _hrmid;
			newViewNganHang.MaQuanLy = _maQuanLy;
			newViewNganHang.TenNganHang = _tenNganHang;
			newViewNganHang.TenVietTat = _tenVietTat;
			newViewNganHang.TrucThuoc = _trucThuoc;
			return newViewNganHang;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the HRMID property. 
		///		
		/// </summary>
		/// <value>This type is uniqueidentifier</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Guid Hrmid
		{
			get
			{
				return this._hrmid; 
			}
			set
			{
				if (_hrmid == value)
					return;
					
				this._hrmid = value;
				this._isDirty = true;
				
				OnPropertyChanged("Hrmid");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaQuanLy
		{
			get
			{
				return this._maQuanLy; 
			}
			set
			{
				if (_maQuanLy == value)
					return;
					
				this._maQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaQuanLy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenNganHang property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenNganHang
		{
			get
			{
				return this._tenNganHang; 
			}
			set
			{
				if (_tenNganHang == value)
					return;
					
				this._tenNganHang = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenNganHang");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenVietTat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenVietTat
		{
			get
			{
				return this._tenVietTat; 
			}
			set
			{
				if (_tenVietTat == value)
					return;
					
				this._tenVietTat = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenVietTat");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TrucThuoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TrucThuoc
		{
			get
			{
				return this._trucThuoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TrucThuoc does not allow null values.");
				if (_trucThuoc == value)
					return;
					
				this._trucThuoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("TrucThuoc");
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
			get { return "View_NganHang"; }
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
		///  Returns a Typed ViewNganHangBase Entity 
		///</summary>
		public virtual ViewNganHangBase Copy()
		{
			//shallow copy entity
			ViewNganHang copy = new ViewNganHang();
				copy.Hrmid = this.Hrmid;
				copy.MaQuanLy = this.MaQuanLy;
				copy.TenNganHang = this.TenNganHang;
				copy.TenVietTat = this.TenVietTat;
				copy.TrucThuoc = this.TrucThuoc;
			copy.AcceptChanges();
			return (ViewNganHang)copy;
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
		///<returns>true if toObject is a <see cref="ViewNganHangBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewNganHangBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewNganHangBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewNganHangBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewNganHangBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewNganHangBase Object1, ViewNganHangBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.Hrmid != Object2.Hrmid)
				equal = false;
			if (Object1.MaQuanLy != null && Object2.MaQuanLy != null )
			{
				if (Object1.MaQuanLy != Object2.MaQuanLy)
					equal = false;
			}
			else if (Object1.MaQuanLy == null ^ Object1.MaQuanLy == null )
			{
				equal = false;
			}
			if (Object1.TenNganHang != null && Object2.TenNganHang != null )
			{
				if (Object1.TenNganHang != Object2.TenNganHang)
					equal = false;
			}
			else if (Object1.TenNganHang == null ^ Object1.TenNganHang == null )
			{
				equal = false;
			}
			if (Object1.TenVietTat != null && Object2.TenVietTat != null )
			{
				if (Object1.TenVietTat != Object2.TenVietTat)
					equal = false;
			}
			else if (Object1.TenVietTat == null ^ Object1.TenVietTat == null )
			{
				equal = false;
			}
			if (Object1.TrucThuoc != Object2.TrucThuoc)
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
		public static object GetPropertyValueByName(ViewNganHang entity, string propertyName)
		{
			switch (propertyName)
			{
				case "Hrmid":
					return entity.Hrmid;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "TenNganHang":
					return entity.TenNganHang;
				case "TenVietTat":
					return entity.TenVietTat;
				case "TrucThuoc":
					return entity.TrucThuoc;
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
			return GetPropertyValueByName(this as ViewNganHang, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{6}{5}- Hrmid: {0}{5}- MaQuanLy: {1}{5}- TenNganHang: {2}{5}- TenVietTat: {3}{5}- TrucThuoc: {4}{5}", 
				this.Hrmid,
				(this.MaQuanLy == null) ? string.Empty : this.MaQuanLy.ToString(),
			     
				(this.TenNganHang == null) ? string.Empty : this.TenNganHang.ToString(),
			     
				(this.TenVietTat == null) ? string.Empty : this.TenVietTat.ToString(),
			     
				this.TrucThuoc,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewNganHang columns.
	/// </summary>
	[Serializable]
	public enum ViewNganHangColumn
	{
		/// <summary>
		/// HRMID : 
		/// </summary>
		[EnumTextValue("HRMID")]
		[ColumnEnum("HRMID", typeof(System.Guid), System.Data.DbType.Guid, false, false, false)]
		Hrmid,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("MaQuanLy")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		MaQuanLy,
		/// <summary>
		/// TenNganHang : 
		/// </summary>
		[EnumTextValue("TenNganHang")]
		[ColumnEnum("TenNganHang", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenNganHang,
		/// <summary>
		/// TenVietTat : 
		/// </summary>
		[EnumTextValue("TenVietTat")]
		[ColumnEnum("TenVietTat", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenVietTat,
		/// <summary>
		/// TrucThuoc : 
		/// </summary>
		[EnumTextValue("TrucThuoc")]
		[ColumnEnum("TrucThuoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 1)]
		TrucThuoc
	}//End enum

} // end namespace
