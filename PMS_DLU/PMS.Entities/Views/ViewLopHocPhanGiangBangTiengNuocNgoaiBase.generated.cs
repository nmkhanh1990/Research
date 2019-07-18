﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewLopHocPhanGiangBangTiengNuocNgoai.cs instead.
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
	/// An object representation of the 'View_LopHocPhanGiangBangTiengNuocNgoai' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewLopHocPhanGiangBangTiengNuocNgoaiBase")]
	public abstract partial class ViewLopHocPhanGiangBangTiengNuocNgoaiBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// ScheduleStudyUnitID : 
		/// </summary>
		private System.String		  _scheduleStudyUnitId = string.Empty;
		
		/// <summary>
		/// StudyUnitID : 
		/// </summary>
		private System.String		  _studyUnitId = null;
		
		/// <summary>
		/// CurriculumID : 
		/// </summary>
		private System.String		  _curriculumId = string.Empty;
		
		/// <summary>
		/// CurriculumName : 
		/// </summary>
		private System.String		  _curriculumName = string.Empty;
		
		/// <summary>
		/// ListOfClassStudentID : 
		/// </summary>
		private System.String		  _listOfClassStudentId = string.Empty;
		
		/// <summary>
		/// ListOfProfessorID : 
		/// </summary>
		private System.String		  _listOfProfessorId = string.Empty;
		
		/// <summary>
		/// ListOfProfessorFirstName : 
		/// </summary>
		private System.String		  _listOfProfessorFirstName = string.Empty;
		
		/// <summary>
		/// YearStudy : 
		/// </summary>
		private System.String		  _yearStudy = string.Empty;
		
		/// <summary>
		/// TermID : 
		/// </summary>
		private System.String		  _termId = string.Empty;
		
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
		/// Creates a new <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> instance.
		///</summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> instance.
		///</summary>
		///<param name="_scheduleStudyUnitId"></param>
		///<param name="_studyUnitId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_listOfClassStudentId"></param>
		///<param name="_listOfProfessorId"></param>
		///<param name="_listOfProfessorFirstName"></param>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_chon"></param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBase(System.String _scheduleStudyUnitId, System.String _studyUnitId, System.String _curriculumId, System.String _curriculumName, System.String _listOfClassStudentId, System.String _listOfProfessorId, System.String _listOfProfessorFirstName, System.String _yearStudy, System.String _termId, System.Boolean? _chon)
		{
			this._scheduleStudyUnitId = _scheduleStudyUnitId;
			this._studyUnitId = _studyUnitId;
			this._curriculumId = _curriculumId;
			this._curriculumName = _curriculumName;
			this._listOfClassStudentId = _listOfClassStudentId;
			this._listOfProfessorId = _listOfProfessorId;
			this._listOfProfessorFirstName = _listOfProfessorFirstName;
			this._yearStudy = _yearStudy;
			this._termId = _termId;
			this._chon = _chon;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> instance.
		///</summary>
		///<param name="_scheduleStudyUnitId"></param>
		///<param name="_studyUnitId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_listOfClassStudentId"></param>
		///<param name="_listOfProfessorId"></param>
		///<param name="_listOfProfessorFirstName"></param>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_chon"></param>
		public static ViewLopHocPhanGiangBangTiengNuocNgoai CreateViewLopHocPhanGiangBangTiengNuocNgoai(System.String _scheduleStudyUnitId, System.String _studyUnitId, System.String _curriculumId, System.String _curriculumName, System.String _listOfClassStudentId, System.String _listOfProfessorId, System.String _listOfProfessorFirstName, System.String _yearStudy, System.String _termId, System.Boolean? _chon)
		{
			ViewLopHocPhanGiangBangTiengNuocNgoai newViewLopHocPhanGiangBangTiengNuocNgoai = new ViewLopHocPhanGiangBangTiengNuocNgoai();
			newViewLopHocPhanGiangBangTiengNuocNgoai.ScheduleStudyUnitId = _scheduleStudyUnitId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.StudyUnitId = _studyUnitId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.CurriculumId = _curriculumId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.CurriculumName = _curriculumName;
			newViewLopHocPhanGiangBangTiengNuocNgoai.ListOfClassStudentId = _listOfClassStudentId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.ListOfProfessorId = _listOfProfessorId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.ListOfProfessorFirstName = _listOfProfessorFirstName;
			newViewLopHocPhanGiangBangTiengNuocNgoai.YearStudy = _yearStudy;
			newViewLopHocPhanGiangBangTiengNuocNgoai.TermId = _termId;
			newViewLopHocPhanGiangBangTiengNuocNgoai.Chon = _chon;
			return newViewLopHocPhanGiangBangTiengNuocNgoai;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the ScheduleStudyUnitID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ScheduleStudyUnitId
		{
			get
			{
				return this._scheduleStudyUnitId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ScheduleStudyUnitId does not allow null values.");
				if (_scheduleStudyUnitId == value)
					return;
					
				this._scheduleStudyUnitId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ScheduleStudyUnitId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the StudyUnitID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String StudyUnitId
		{
			get
			{
				return this._studyUnitId; 
			}
			set
			{
				if (_studyUnitId == value)
					return;
					
				this._studyUnitId = value;
				this._isDirty = true;
				
				OnPropertyChanged("StudyUnitId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CurriculumID property. 
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
		/// 	Gets or Sets the ListOfClassStudentID property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfClassStudentId
		{
			get
			{
				return this._listOfClassStudentId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ListOfClassStudentId does not allow null values.");
				if (_listOfClassStudentId == value)
					return;
					
				this._listOfClassStudentId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ListOfClassStudentId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ListOfProfessorID property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfProfessorId
		{
			get
			{
				return this._listOfProfessorId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ListOfProfessorId does not allow null values.");
				if (_listOfProfessorId == value)
					return;
					
				this._listOfProfessorId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ListOfProfessorId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ListOfProfessorFirstName property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfProfessorFirstName
		{
			get
			{
				return this._listOfProfessorFirstName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ListOfProfessorFirstName does not allow null values.");
				if (_listOfProfessorFirstName == value)
					return;
					
				this._listOfProfessorFirstName = value;
				this._isDirty = true;
				
				OnPropertyChanged("ListOfProfessorFirstName");
			}
		}
		
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
		/// 	Gets or Sets the TermID property. 
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
		/// 	Gets or Sets the Chon property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsChonNull() and perform business logic appropriately.
		/// </remarks>
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
			get { return "View_LopHocPhanGiangBangTiengNuocNgoai"; }
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
		///  Returns a Typed ViewLopHocPhanGiangBangTiengNuocNgoaiBase Entity 
		///</summary>
		public virtual ViewLopHocPhanGiangBangTiengNuocNgoaiBase Copy()
		{
			//shallow copy entity
			ViewLopHocPhanGiangBangTiengNuocNgoai copy = new ViewLopHocPhanGiangBangTiengNuocNgoai();
				copy.ScheduleStudyUnitId = this.ScheduleStudyUnitId;
				copy.StudyUnitId = this.StudyUnitId;
				copy.CurriculumId = this.CurriculumId;
				copy.CurriculumName = this.CurriculumName;
				copy.ListOfClassStudentId = this.ListOfClassStudentId;
				copy.ListOfProfessorId = this.ListOfProfessorId;
				copy.ListOfProfessorFirstName = this.ListOfProfessorFirstName;
				copy.YearStudy = this.YearStudy;
				copy.TermId = this.TermId;
				copy.Chon = this.Chon;
			copy.AcceptChanges();
			return (ViewLopHocPhanGiangBangTiengNuocNgoai)copy;
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
		///<returns>true if toObject is a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewLopHocPhanGiangBangTiengNuocNgoaiBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewLopHocPhanGiangBangTiengNuocNgoaiBase Object1, ViewLopHocPhanGiangBangTiengNuocNgoaiBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.ScheduleStudyUnitId != Object2.ScheduleStudyUnitId)
				equal = false;
			if (Object1.StudyUnitId != null && Object2.StudyUnitId != null )
			{
				if (Object1.StudyUnitId != Object2.StudyUnitId)
					equal = false;
			}
			else if (Object1.StudyUnitId == null ^ Object1.StudyUnitId == null )
			{
				equal = false;
			}
			if (Object1.CurriculumId != Object2.CurriculumId)
				equal = false;
			if (Object1.CurriculumName != Object2.CurriculumName)
				equal = false;
			if (Object1.ListOfClassStudentId != Object2.ListOfClassStudentId)
				equal = false;
			if (Object1.ListOfProfessorId != Object2.ListOfProfessorId)
				equal = false;
			if (Object1.ListOfProfessorFirstName != Object2.ListOfProfessorFirstName)
				equal = false;
			if (Object1.YearStudy != Object2.YearStudy)
				equal = false;
			if (Object1.TermId != Object2.TermId)
				equal = false;
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
		public static object GetPropertyValueByName(ViewLopHocPhanGiangBangTiengNuocNgoai entity, string propertyName)
		{
			switch (propertyName)
			{
				case "ScheduleStudyUnitId":
					return entity.ScheduleStudyUnitId;
				case "StudyUnitId":
					return entity.StudyUnitId;
				case "CurriculumId":
					return entity.CurriculumId;
				case "CurriculumName":
					return entity.CurriculumName;
				case "ListOfClassStudentId":
					return entity.ListOfClassStudentId;
				case "ListOfProfessorId":
					return entity.ListOfProfessorId;
				case "ListOfProfessorFirstName":
					return entity.ListOfProfessorFirstName;
				case "YearStudy":
					return entity.YearStudy;
				case "TermId":
					return entity.TermId;
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
			return GetPropertyValueByName(this as ViewLopHocPhanGiangBangTiengNuocNgoai, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{11}{10}- ScheduleStudyUnitId: {0}{10}- StudyUnitId: {1}{10}- CurriculumId: {2}{10}- CurriculumName: {3}{10}- ListOfClassStudentId: {4}{10}- ListOfProfessorId: {5}{10}- ListOfProfessorFirstName: {6}{10}- YearStudy: {7}{10}- TermId: {8}{10}- Chon: {9}{10}", 
				this.ScheduleStudyUnitId,
				(this.StudyUnitId == null) ? string.Empty : this.StudyUnitId.ToString(),
			     
				this.CurriculumId,
				this.CurriculumName,
				this.ListOfClassStudentId,
				this.ListOfProfessorId,
				this.ListOfProfessorFirstName,
				this.YearStudy,
				this.TermId,
				(this.Chon == null) ? string.Empty : this.Chon.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewLopHocPhanGiangBangTiengNuocNgoai columns.
	/// </summary>
	[Serializable]
	public enum ViewLopHocPhanGiangBangTiengNuocNgoaiColumn
	{
		/// <summary>
		/// ScheduleStudyUnitID : 
		/// </summary>
		[EnumTextValue("ScheduleStudyUnitID")]
		[ColumnEnum("ScheduleStudyUnitID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 30)]
		ScheduleStudyUnitId,
		/// <summary>
		/// StudyUnitID : 
		/// </summary>
		[EnumTextValue("StudyUnitID")]
		[ColumnEnum("StudyUnitID", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 30)]
		StudyUnitId,
		/// <summary>
		/// CurriculumID : 
		/// </summary>
		[EnumTextValue("CurriculumID")]
		[ColumnEnum("CurriculumID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		CurriculumId,
		/// <summary>
		/// CurriculumName : 
		/// </summary>
		[EnumTextValue("CurriculumName")]
		[ColumnEnum("CurriculumName", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		CurriculumName,
		/// <summary>
		/// ListOfClassStudentID : 
		/// </summary>
		[EnumTextValue("ListOfClassStudentID")]
		[ColumnEnum("ListOfClassStudentID", typeof(System.String), System.Data.DbType.String, false, false, false)]
		ListOfClassStudentId,
		/// <summary>
		/// ListOfProfessorID : 
		/// </summary>
		[EnumTextValue("ListOfProfessorID")]
		[ColumnEnum("ListOfProfessorID", typeof(System.String), System.Data.DbType.String, false, false, false, 250)]
		ListOfProfessorId,
		/// <summary>
		/// ListOfProfessorFirstName : 
		/// </summary>
		[EnumTextValue("ListOfProfessorFirstName")]
		[ColumnEnum("ListOfProfessorFirstName", typeof(System.String), System.Data.DbType.String, false, false, false, 250)]
		ListOfProfessorFirstName,
		/// <summary>
		/// YearStudy : 
		/// </summary>
		[EnumTextValue("YearStudy")]
		[ColumnEnum("YearStudy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		YearStudy,
		/// <summary>
		/// TermID : 
		/// </summary>
		[EnumTextValue("TermID")]
		[ColumnEnum("TermID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		TermId,
		/// <summary>
		/// Chon : 
		/// </summary>
		[EnumTextValue("Chon")]
		[ColumnEnum("Chon", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		Chon
	}//End enum

} // end namespace