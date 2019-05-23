﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwSoLuongSinhVienLopHocPhan.cs instead.
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
	/// An object representation of the 'vw_SoLuongSinhVienLopHocPhan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwSoLuongSinhVienLopHocPhanBase")]
	public abstract partial class VwSoLuongSinhVienLopHocPhanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = string.Empty;
		
		/// <summary>
		/// SoLuong : 
		/// </summary>
		private System.Int32?		  _soLuong = null;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = string.Empty;
		
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
		/// Creates a new <see cref="VwSoLuongSinhVienLopHocPhanBase"/> instance.
		///</summary>
		public VwSoLuongSinhVienLopHocPhanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwSoLuongSinhVienLopHocPhanBase"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_soLuong"></param>
		///<param name="_maLopHocPhan"></param>
		public VwSoLuongSinhVienLopHocPhanBase(System.String _maLop, System.Int32? _soLuong, System.String _maLopHocPhan)
		{
			this._maLop = _maLop;
			this._soLuong = _soLuong;
			this._maLopHocPhan = _maLopHocPhan;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwSoLuongSinhVienLopHocPhan"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_soLuong"></param>
		///<param name="_maLopHocPhan"></param>
		public static VwSoLuongSinhVienLopHocPhan CreateVwSoLuongSinhVienLopHocPhan(System.String _maLop, System.Int32? _soLuong, System.String _maLopHocPhan)
		{
			VwSoLuongSinhVienLopHocPhan newVwSoLuongSinhVienLopHocPhan = new VwSoLuongSinhVienLopHocPhan();
			newVwSoLuongSinhVienLopHocPhan.MaLop = _maLop;
			newVwSoLuongSinhVienLopHocPhan.SoLuong = _soLuong;
			newVwSoLuongSinhVienLopHocPhan.MaLopHocPhan = _maLopHocPhan;
			return newVwSoLuongSinhVienLopHocPhan;
		}
				
		#endregion Constructors
		
		#region Properties	
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
		/// 	Gets or Sets the SoLuong property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSoLuongNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SoLuong
		{
			get
			{
				return this._soLuong; 
			}
			set
			{
				if (_soLuong == value && SoLuong != null )
					return;
					
				this._soLuong = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoLuong");
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
			get { return "vw_SoLuongSinhVienLopHocPhan"; }
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
		///  Returns a Typed VwSoLuongSinhVienLopHocPhanBase Entity 
		///</summary>
		public virtual VwSoLuongSinhVienLopHocPhanBase Copy()
		{
			//shallow copy entity
			VwSoLuongSinhVienLopHocPhan copy = new VwSoLuongSinhVienLopHocPhan();
				copy.MaLop = this.MaLop;
				copy.SoLuong = this.SoLuong;
				copy.MaLopHocPhan = this.MaLopHocPhan;
			copy.AcceptChanges();
			return (VwSoLuongSinhVienLopHocPhan)copy;
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
		///<returns>true if toObject is a <see cref="VwSoLuongSinhVienLopHocPhanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwSoLuongSinhVienLopHocPhanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwSoLuongSinhVienLopHocPhanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwSoLuongSinhVienLopHocPhanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwSoLuongSinhVienLopHocPhanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwSoLuongSinhVienLopHocPhanBase Object1, VwSoLuongSinhVienLopHocPhanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if (Object1.SoLuong != null && Object2.SoLuong != null )
			{
				if (Object1.SoLuong != Object2.SoLuong)
					equal = false;
			}
			else if (Object1.SoLuong == null ^ Object1.SoLuong == null )
			{
				equal = false;
			}
			if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
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
		public static object GetPropertyValueByName(VwSoLuongSinhVienLopHocPhan entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaLop":
					return entity.MaLop;
				case "SoLuong":
					return entity.SoLuong;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
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
			return GetPropertyValueByName(this as VwSoLuongSinhVienLopHocPhan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- MaLop: {0}{3}- SoLuong: {1}{3}- MaLopHocPhan: {2}{3}", 
				this.MaLop,
				(this.SoLuong == null) ? string.Empty : this.SoLuong.ToString(),
			     
				this.MaLopHocPhan,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwSoLuongSinhVienLopHocPhan columns.
	/// </summary>
	[Serializable]
	public enum VwSoLuongSinhVienLopHocPhanColumn
	{
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLop,
		/// <summary>
		/// SoLuong : 
		/// </summary>
		[EnumTextValue("SoLuong")]
		[ColumnEnum("SoLuong", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SoLuong,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLopHocPhan
	}//End enum

} // end namespace
