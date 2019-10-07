﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewLoaiHocPhan.cs instead.
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
	/// An object representation of the 'View_LoaiHocPhan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewLoaiHocPhanBase")]
	public abstract partial class ViewLoaiHocPhanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		private System.Byte		  _maLoaiHocPhan = (byte)0;
		
		/// <summary>
		/// TenLoaiHocPhan : 
		/// </summary>
		private System.String		  _tenLoaiHocPhan = string.Empty;
		
		/// <summary>
		/// VietTat : 
		/// </summary>
		private System.String		  _vietTat = null;
		
		/// <summary>
		/// DonViTinh : 
		/// </summary>
		private System.String		  _donViTinh = null;
		
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
		/// Creates a new <see cref="ViewLoaiHocPhanBase"/> instance.
		///</summary>
		public ViewLoaiHocPhanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewLoaiHocPhanBase"/> instance.
		///</summary>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_vietTat"></param>
		///<param name="_donViTinh"></param>
		public ViewLoaiHocPhanBase(System.Byte _maLoaiHocPhan, System.String _tenLoaiHocPhan, System.String _vietTat, System.String _donViTinh)
		{
			this._maLoaiHocPhan = _maLoaiHocPhan;
			this._tenLoaiHocPhan = _tenLoaiHocPhan;
			this._vietTat = _vietTat;
			this._donViTinh = _donViTinh;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLoaiHocPhan"/> instance.
		///</summary>
		///<param name="_maLoaiHocPhan"></param>
		///<param name="_tenLoaiHocPhan"></param>
		///<param name="_vietTat"></param>
		///<param name="_donViTinh"></param>
		public static ViewLoaiHocPhan CreateViewLoaiHocPhan(System.Byte _maLoaiHocPhan, System.String _tenLoaiHocPhan, System.String _vietTat, System.String _donViTinh)
		{
			ViewLoaiHocPhan newViewLoaiHocPhan = new ViewLoaiHocPhan();
			newViewLoaiHocPhan.MaLoaiHocPhan = _maLoaiHocPhan;
			newViewLoaiHocPhan.TenLoaiHocPhan = _tenLoaiHocPhan;
			newViewLoaiHocPhan.VietTat = _vietTat;
			newViewLoaiHocPhan.DonViTinh = _donViTinh;
			return newViewLoaiHocPhan;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaLoaiHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is tinyint</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Byte MaLoaiHocPhan
		{
			get
			{
				return this._maLoaiHocPhan; 
			}
			set
			{
				if (_maLoaiHocPhan == value)
					return;
					
				this._maLoaiHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLoaiHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLoaiHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLoaiHocPhan
		{
			get
			{
				return this._tenLoaiHocPhan; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenLoaiHocPhan does not allow null values.");
				if (_tenLoaiHocPhan == value)
					return;
					
				this._tenLoaiHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLoaiHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the VietTat property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String VietTat
		{
			get
			{
				return this._vietTat; 
			}
			set
			{
				if (_vietTat == value)
					return;
					
				this._vietTat = value;
				this._isDirty = true;
				
				OnPropertyChanged("VietTat");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DonViTinh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String DonViTinh
		{
			get
			{
				return this._donViTinh; 
			}
			set
			{
				if (_donViTinh == value)
					return;
					
				this._donViTinh = value;
				this._isDirty = true;
				
				OnPropertyChanged("DonViTinh");
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
			get { return "View_LoaiHocPhan"; }
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
		///  Returns a Typed ViewLoaiHocPhanBase Entity 
		///</summary>
		public virtual ViewLoaiHocPhanBase Copy()
		{
			//shallow copy entity
			ViewLoaiHocPhan copy = new ViewLoaiHocPhan();
				copy.MaLoaiHocPhan = this.MaLoaiHocPhan;
				copy.TenLoaiHocPhan = this.TenLoaiHocPhan;
				copy.VietTat = this.VietTat;
				copy.DonViTinh = this.DonViTinh;
			copy.AcceptChanges();
			return (ViewLoaiHocPhan)copy;
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
		///<returns>true if toObject is a <see cref="ViewLoaiHocPhanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewLoaiHocPhanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewLoaiHocPhanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewLoaiHocPhanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewLoaiHocPhanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewLoaiHocPhanBase Object1, ViewLoaiHocPhanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaLoaiHocPhan != Object2.MaLoaiHocPhan)
				equal = false;
			if (Object1.TenLoaiHocPhan != Object2.TenLoaiHocPhan)
				equal = false;
			if (Object1.VietTat != null && Object2.VietTat != null )
			{
				if (Object1.VietTat != Object2.VietTat)
					equal = false;
			}
			else if (Object1.VietTat == null ^ Object1.VietTat == null )
			{
				equal = false;
			}
			if (Object1.DonViTinh != null && Object2.DonViTinh != null )
			{
				if (Object1.DonViTinh != Object2.DonViTinh)
					equal = false;
			}
			else if (Object1.DonViTinh == null ^ Object1.DonViTinh == null )
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
		public static object GetPropertyValueByName(ViewLoaiHocPhan entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaLoaiHocPhan":
					return entity.MaLoaiHocPhan;
				case "TenLoaiHocPhan":
					return entity.TenLoaiHocPhan;
				case "VietTat":
					return entity.VietTat;
				case "DonViTinh":
					return entity.DonViTinh;
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
			return GetPropertyValueByName(this as ViewLoaiHocPhan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{5}{4}- MaLoaiHocPhan: {0}{4}- TenLoaiHocPhan: {1}{4}- VietTat: {2}{4}- DonViTinh: {3}{4}", 
				this.MaLoaiHocPhan,
				this.TenLoaiHocPhan,
				(this.VietTat == null) ? string.Empty : this.VietTat.ToString(),
			     
				(this.DonViTinh == null) ? string.Empty : this.DonViTinh.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewLoaiHocPhan columns.
	/// </summary>
	[Serializable]
	public enum ViewLoaiHocPhanColumn
	{
		/// <summary>
		/// MaLoaiHocPhan : 
		/// </summary>
		[EnumTextValue("MaLoaiHocPhan")]
		[ColumnEnum("MaLoaiHocPhan", typeof(System.Byte), System.Data.DbType.Byte, false, false, false)]
		MaLoaiHocPhan,
		/// <summary>
		/// TenLoaiHocPhan : 
		/// </summary>
		[EnumTextValue("TenLoaiHocPhan")]
		[ColumnEnum("TenLoaiHocPhan", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenLoaiHocPhan,
		/// <summary>
		/// VietTat : 
		/// </summary>
		[EnumTextValue("VietTat")]
		[ColumnEnum("VietTat", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 10)]
		VietTat,
		/// <summary>
		/// DonViTinh : 
		/// </summary>
		[EnumTextValue("DonViTinh")]
		[ColumnEnum("DonViTinh", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 10)]
		DonViTinh
	}//End enum

} // end namespace
