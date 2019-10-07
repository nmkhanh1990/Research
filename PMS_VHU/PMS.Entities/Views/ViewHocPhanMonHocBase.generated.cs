﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewHocPhanMonHoc.cs instead.
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
	/// An object representation of the 'View_HocPhan_MonHoc' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewHocPhanMonHocBase")]
	public abstract partial class ViewHocPhanMonHocBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// YearStudy : 
		/// </summary>
		private System.String		  _yearStudy = string.Empty;
		
		/// <summary>
		/// TermId : 
		/// </summary>
		private System.String		  _termId = string.Empty;
		
		/// <summary>
		/// CurriculumId : 
		/// </summary>
		private System.String		  _curriculumId = string.Empty;
		
		/// <summary>
		/// CurriculumName : 
		/// </summary>
		private System.String		  _curriculumName = string.Empty;
		
		/// <summary>
		/// Credits : 
		/// </summary>
		private System.Decimal		  _credits = 0.0m;
		
		/// <summary>
		/// DepartmentId : 
		/// </summary>
		private System.String		  _departmentId = string.Empty;
		
		/// <summary>
		/// DepartmentName : 
		/// </summary>
		private System.String		  _departmentName = string.Empty;
		
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
		/// Creates a new <see cref="ViewHocPhanMonHocBase"/> instance.
		///</summary>
		public ViewHocPhanMonHocBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewHocPhanMonHocBase"/> instance.
		///</summary>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_credits"></param>
		///<param name="_departmentId"></param>
		///<param name="_departmentName"></param>
		public ViewHocPhanMonHocBase(System.String _yearStudy, System.String _termId, System.String _curriculumId, System.String _curriculumName, System.Decimal _credits, System.String _departmentId, System.String _departmentName)
		{
			this._yearStudy = _yearStudy;
			this._termId = _termId;
			this._curriculumId = _curriculumId;
			this._curriculumName = _curriculumName;
			this._credits = _credits;
			this._departmentId = _departmentId;
			this._departmentName = _departmentName;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewHocPhanMonHoc"/> instance.
		///</summary>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_credits"></param>
		///<param name="_departmentId"></param>
		///<param name="_departmentName"></param>
		public static ViewHocPhanMonHoc CreateViewHocPhanMonHoc(System.String _yearStudy, System.String _termId, System.String _curriculumId, System.String _curriculumName, System.Decimal _credits, System.String _departmentId, System.String _departmentName)
		{
			ViewHocPhanMonHoc newViewHocPhanMonHoc = new ViewHocPhanMonHoc();
			newViewHocPhanMonHoc.YearStudy = _yearStudy;
			newViewHocPhanMonHoc.TermId = _termId;
			newViewHocPhanMonHoc.CurriculumId = _curriculumId;
			newViewHocPhanMonHoc.CurriculumName = _curriculumName;
			newViewHocPhanMonHoc.Credits = _credits;
			newViewHocPhanMonHoc.DepartmentId = _departmentId;
			newViewHocPhanMonHoc.DepartmentName = _departmentName;
			return newViewHocPhanMonHoc;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the YearStudy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String YearStudy
		{
			get
			{
				return this._yearStudy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "YearStudy does not allow null values.");
				if (_yearStudy == value)
					return;
					
				this._yearStudy = value;
				this._isDirty = true;
				
				OnPropertyChanged("YearStudy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TermId property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TermId
		{
			get
			{
				return this._termId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TermId does not allow null values.");
				if (_termId == value)
					return;
					
				this._termId = value;
				this._isDirty = true;
				
				OnPropertyChanged("TermId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CurriculumId property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CurriculumId
		{
			get
			{
				return this._curriculumId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CurriculumId does not allow null values.");
				if (_curriculumId == value)
					return;
					
				this._curriculumId = value;
				this._isDirty = true;
				
				OnPropertyChanged("CurriculumId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CurriculumName property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CurriculumName
		{
			get
			{
				return this._curriculumName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CurriculumName does not allow null values.");
				if (_curriculumName == value)
					return;
					
				this._curriculumName = value;
				this._isDirty = true;
				
				OnPropertyChanged("CurriculumName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Credits property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal Credits
		{
			get
			{
				return this._credits; 
			}
			set
			{
				if (_credits == value)
					return;
					
				this._credits = value;
				this._isDirty = true;
				
				OnPropertyChanged("Credits");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DepartmentId property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String DepartmentId
		{
			get
			{
				return this._departmentId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "DepartmentId does not allow null values.");
				if (_departmentId == value)
					return;
					
				this._departmentId = value;
				this._isDirty = true;
				
				OnPropertyChanged("DepartmentId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DepartmentName property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String DepartmentName
		{
			get
			{
				return this._departmentName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "DepartmentName does not allow null values.");
				if (_departmentName == value)
					return;
					
				this._departmentName = value;
				this._isDirty = true;
				
				OnPropertyChanged("DepartmentName");
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
			get { return "View_HocPhan_MonHoc"; }
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
		///  Returns a Typed ViewHocPhanMonHocBase Entity 
		///</summary>
		public virtual ViewHocPhanMonHocBase Copy()
		{
			//shallow copy entity
			ViewHocPhanMonHoc copy = new ViewHocPhanMonHoc();
				copy.YearStudy = this.YearStudy;
				copy.TermId = this.TermId;
				copy.CurriculumId = this.CurriculumId;
				copy.CurriculumName = this.CurriculumName;
				copy.Credits = this.Credits;
				copy.DepartmentId = this.DepartmentId;
				copy.DepartmentName = this.DepartmentName;
			copy.AcceptChanges();
			return (ViewHocPhanMonHoc)copy;
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
		///<returns>true if toObject is a <see cref="ViewHocPhanMonHocBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewHocPhanMonHocBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewHocPhanMonHocBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewHocPhanMonHocBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewHocPhanMonHocBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewHocPhanMonHocBase Object1, ViewHocPhanMonHocBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.YearStudy != Object2.YearStudy)
				equal = false;
			if (Object1.TermId != Object2.TermId)
				equal = false;
			if (Object1.CurriculumId != Object2.CurriculumId)
				equal = false;
			if (Object1.CurriculumName != Object2.CurriculumName)
				equal = false;
			if (Object1.Credits != Object2.Credits)
				equal = false;
			if (Object1.DepartmentId != Object2.DepartmentId)
				equal = false;
			if (Object1.DepartmentName != Object2.DepartmentName)
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
		public static object GetPropertyValueByName(ViewHocPhanMonHoc entity, string propertyName)
		{
			switch (propertyName)
			{
				case "YearStudy":
					return entity.YearStudy;
				case "TermId":
					return entity.TermId;
				case "CurriculumId":
					return entity.CurriculumId;
				case "CurriculumName":
					return entity.CurriculumName;
				case "Credits":
					return entity.Credits;
				case "DepartmentId":
					return entity.DepartmentId;
				case "DepartmentName":
					return entity.DepartmentName;
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
			return GetPropertyValueByName(this as ViewHocPhanMonHoc, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{8}{7}- YearStudy: {0}{7}- TermId: {1}{7}- CurriculumId: {2}{7}- CurriculumName: {3}{7}- Credits: {4}{7}- DepartmentId: {5}{7}- DepartmentName: {6}{7}", 
				this.YearStudy,
				this.TermId,
				this.CurriculumId,
				this.CurriculumName,
				this.Credits,
				this.DepartmentId,
				this.DepartmentName,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewHocPhanMonHoc columns.
	/// </summary>
	[Serializable]
	public enum ViewHocPhanMonHocColumn
	{
		/// <summary>
		/// YearStudy : 
		/// </summary>
		[EnumTextValue("YearStudy")]
		[ColumnEnum("YearStudy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		YearStudy,
		/// <summary>
		/// TermId : 
		/// </summary>
		[EnumTextValue("TermId")]
		[ColumnEnum("TermId", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		TermId,
		/// <summary>
		/// CurriculumId : 
		/// </summary>
		[EnumTextValue("CurriculumId")]
		[ColumnEnum("CurriculumId", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		CurriculumId,
		/// <summary>
		/// CurriculumName : 
		/// </summary>
		[EnumTextValue("CurriculumName")]
		[ColumnEnum("CurriculumName", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		CurriculumName,
		/// <summary>
		/// Credits : 
		/// </summary>
		[EnumTextValue("Credits")]
		[ColumnEnum("Credits", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, false)]
		Credits,
		/// <summary>
		/// DepartmentId : 
		/// </summary>
		[EnumTextValue("DepartmentId")]
		[ColumnEnum("DepartmentId", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		DepartmentId,
		/// <summary>
		/// DepartmentName : 
		/// </summary>
		[EnumTextValue("DepartmentName")]
		[ColumnEnum("DepartmentName", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		DepartmentName
	}//End enum

} // end namespace
