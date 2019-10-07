﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VGiangVienChucVu.cs instead.
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
	/// An object representation of the 'v_GiangVien_ChucVu' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VGiangVienChucVuBase")]
	public abstract partial class VGiangVienChucVuBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32		  _maGiangVien = (int)0;
		
		/// <summary>
		/// NguongTiet : 
		/// </summary>
		private System.Int32?		  _nguongTiet = null;
		
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		private System.Decimal?		  _tietNghiaVu = null;
		
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
		/// Creates a new <see cref="VGiangVienChucVuBase"/> instance.
		///</summary>
		public VGiangVienChucVuBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VGiangVienChucVuBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_nguongTiet"></param>
		///<param name="_tietNghiaVu"></param>
		public VGiangVienChucVuBase(System.Int32 _maGiangVien, System.Int32? _nguongTiet, System.Decimal? _tietNghiaVu)
		{
			this._maGiangVien = _maGiangVien;
			this._nguongTiet = _nguongTiet;
			this._tietNghiaVu = _tietNghiaVu;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VGiangVienChucVu"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_nguongTiet"></param>
		///<param name="_tietNghiaVu"></param>
		public static VGiangVienChucVu CreateVGiangVienChucVu(System.Int32 _maGiangVien, System.Int32? _nguongTiet, System.Decimal? _tietNghiaVu)
		{
			VGiangVienChucVu newVGiangVienChucVu = new VGiangVienChucVu();
			newVGiangVienChucVu.MaGiangVien = _maGiangVien;
			newVGiangVienChucVu.NguongTiet = _nguongTiet;
			newVGiangVienChucVu.TietNghiaVu = _tietNghiaVu;
			return newVGiangVienChucVu;
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
		/// 	Gets or Sets the NguongTiet property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsNguongTietNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? NguongTiet
		{
			get
			{
				return this._nguongTiet; 
			}
			set
			{
				if (_nguongTiet == value && NguongTiet != null )
					return;
					
				this._nguongTiet = value;
				this._isDirty = true;
				
				OnPropertyChanged("NguongTiet");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietNghiaVu property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTietNghiaVuNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TietNghiaVu
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
			get { return "v_GiangVien_ChucVu"; }
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
		///  Returns a Typed VGiangVienChucVuBase Entity 
		///</summary>
		public virtual VGiangVienChucVuBase Copy()
		{
			//shallow copy entity
			VGiangVienChucVu copy = new VGiangVienChucVu();
				copy.MaGiangVien = this.MaGiangVien;
				copy.NguongTiet = this.NguongTiet;
				copy.TietNghiaVu = this.TietNghiaVu;
			copy.AcceptChanges();
			return (VGiangVienChucVu)copy;
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
		///<returns>true if toObject is a <see cref="VGiangVienChucVuBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VGiangVienChucVuBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VGiangVienChucVuBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VGiangVienChucVuBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VGiangVienChucVuBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VGiangVienChucVuBase Object1, VGiangVienChucVuBase Object2)
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
			if (Object1.NguongTiet != null && Object2.NguongTiet != null )
			{
				if (Object1.NguongTiet != Object2.NguongTiet)
					equal = false;
			}
			else if (Object1.NguongTiet == null ^ Object1.NguongTiet == null )
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
		public static object GetPropertyValueByName(VGiangVienChucVu entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "NguongTiet":
					return entity.NguongTiet;
				case "TietNghiaVu":
					return entity.TietNghiaVu;
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
			return GetPropertyValueByName(this as VGiangVienChucVu, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- MaGiangVien: {0}{3}- NguongTiet: {1}{3}- TietNghiaVu: {2}{3}", 
				this.MaGiangVien,
				(this.NguongTiet == null) ? string.Empty : this.NguongTiet.ToString(),
			     
				(this.TietNghiaVu == null) ? string.Empty : this.TietNghiaVu.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VGiangVienChucVu columns.
	/// </summary>
	[Serializable]
	public enum VGiangVienChucVuColumn
	{
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaGiangVien,
		/// <summary>
		/// NguongTiet : 
		/// </summary>
		[EnumTextValue("NguongTiet")]
		[ColumnEnum("NguongTiet", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		NguongTiet,
		/// <summary>
		/// TietNghiaVu : 
		/// </summary>
		[EnumTextValue("TietNghiaVu")]
		[ColumnEnum("TietNghiaVu", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TietNghiaVu
	}//End enum

} // end namespace
