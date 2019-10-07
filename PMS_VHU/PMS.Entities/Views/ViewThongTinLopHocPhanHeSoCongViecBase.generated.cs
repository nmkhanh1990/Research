﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThongTinLopHocPhanHeSoCongViec.cs instead.
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
	/// An object representation of the 'View_ThongTinLopHocPhan_HeSoCongViec' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewThongTinLopHocPhanHeSoCongViecBase")]
	public abstract partial class ViewThongTinLopHocPhanHeSoCongViecBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// YearStudy : 
		/// </summary>
		private System.String		  _yearStudy = string.Empty;
		
		/// <summary>
		/// TermID : 
		/// </summary>
		private System.String		  _termId = string.Empty;
		
		/// <summary>
		/// StudyUnitID : 
		/// </summary>
		private System.String		  _studyUnitId = string.Empty;
		
		/// <summary>
		/// ScheduleStudyUnitID : 
		/// </summary>
		private System.String		  _scheduleStudyUnitId = string.Empty;
		
		/// <summary>
		/// CurriculumID : 
		/// </summary>
		private System.String		  _curriculumId = string.Empty;
		
		/// <summary>
		/// CurriculumName : 
		/// </summary>
		private System.String		  _curriculumName = string.Empty;
		
		/// <summary>
		/// Credits : 
		/// </summary>
		private System.Int32?		  _credits = null;
		
		/// <summary>
		/// StudyUnitTypeID : 
		/// </summary>
		private System.Byte		  _studyUnitTypeId = (byte)0;
		
		/// <summary>
		/// StudyUnitTypeName : 
		/// </summary>
		private System.String		  _studyUnitTypeName = string.Empty;
		
		/// <summary>
		/// StudyUnitTypeAbbreviation : 
		/// </summary>
		private System.String		  _studyUnitTypeAbbreviation = null;
		
		/// <summary>
		/// ListOfClassStudentID : 
		/// </summary>
		private System.String		  _listOfClassStudentId = null;
		
		/// <summary>
		/// ListOfProfessorID : 
		/// </summary>
		private System.String		  _listOfProfessorId = null;
		
		/// <summary>
		/// ListOfProfessorFirstName : 
		/// </summary>
		private System.String		  _listOfProfessorFirstName = null;
		
		/// <summary>
		/// MaHeSoCongViec : 
		/// </summary>
		private System.Int32?		  _maHeSoCongViec = null;
		
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
		/// Creates a new <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> instance.
		///</summary>
		public ViewThongTinLopHocPhanHeSoCongViecBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> instance.
		///</summary>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_studyUnitId"></param>
		///<param name="_scheduleStudyUnitId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_credits"></param>
		///<param name="_studyUnitTypeId"></param>
		///<param name="_studyUnitTypeName"></param>
		///<param name="_studyUnitTypeAbbreviation"></param>
		///<param name="_listOfClassStudentId"></param>
		///<param name="_listOfProfessorId"></param>
		///<param name="_listOfProfessorFirstName"></param>
		///<param name="_maHeSoCongViec"></param>
		public ViewThongTinLopHocPhanHeSoCongViecBase(System.String _yearStudy, System.String _termId, System.String _studyUnitId, System.String _scheduleStudyUnitId, System.String _curriculumId, System.String _curriculumName, System.Int32? _credits, System.Byte _studyUnitTypeId, System.String _studyUnitTypeName, System.String _studyUnitTypeAbbreviation, System.String _listOfClassStudentId, System.String _listOfProfessorId, System.String _listOfProfessorFirstName, System.Int32? _maHeSoCongViec)
		{
			this._yearStudy = _yearStudy;
			this._termId = _termId;
			this._studyUnitId = _studyUnitId;
			this._scheduleStudyUnitId = _scheduleStudyUnitId;
			this._curriculumId = _curriculumId;
			this._curriculumName = _curriculumName;
			this._credits = _credits;
			this._studyUnitTypeId = _studyUnitTypeId;
			this._studyUnitTypeName = _studyUnitTypeName;
			this._studyUnitTypeAbbreviation = _studyUnitTypeAbbreviation;
			this._listOfClassStudentId = _listOfClassStudentId;
			this._listOfProfessorId = _listOfProfessorId;
			this._listOfProfessorFirstName = _listOfProfessorFirstName;
			this._maHeSoCongViec = _maHeSoCongViec;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> instance.
		///</summary>
		///<param name="_yearStudy"></param>
		///<param name="_termId"></param>
		///<param name="_studyUnitId"></param>
		///<param name="_scheduleStudyUnitId"></param>
		///<param name="_curriculumId"></param>
		///<param name="_curriculumName"></param>
		///<param name="_credits"></param>
		///<param name="_studyUnitTypeId"></param>
		///<param name="_studyUnitTypeName"></param>
		///<param name="_studyUnitTypeAbbreviation"></param>
		///<param name="_listOfClassStudentId"></param>
		///<param name="_listOfProfessorId"></param>
		///<param name="_listOfProfessorFirstName"></param>
		///<param name="_maHeSoCongViec"></param>
		public static ViewThongTinLopHocPhanHeSoCongViec CreateViewThongTinLopHocPhanHeSoCongViec(System.String _yearStudy, System.String _termId, System.String _studyUnitId, System.String _scheduleStudyUnitId, System.String _curriculumId, System.String _curriculumName, System.Int32? _credits, System.Byte _studyUnitTypeId, System.String _studyUnitTypeName, System.String _studyUnitTypeAbbreviation, System.String _listOfClassStudentId, System.String _listOfProfessorId, System.String _listOfProfessorFirstName, System.Int32? _maHeSoCongViec)
		{
			ViewThongTinLopHocPhanHeSoCongViec newViewThongTinLopHocPhanHeSoCongViec = new ViewThongTinLopHocPhanHeSoCongViec();
			newViewThongTinLopHocPhanHeSoCongViec.YearStudy = _yearStudy;
			newViewThongTinLopHocPhanHeSoCongViec.TermId = _termId;
			newViewThongTinLopHocPhanHeSoCongViec.StudyUnitId = _studyUnitId;
			newViewThongTinLopHocPhanHeSoCongViec.ScheduleStudyUnitId = _scheduleStudyUnitId;
			newViewThongTinLopHocPhanHeSoCongViec.CurriculumId = _curriculumId;
			newViewThongTinLopHocPhanHeSoCongViec.CurriculumName = _curriculumName;
			newViewThongTinLopHocPhanHeSoCongViec.Credits = _credits;
			newViewThongTinLopHocPhanHeSoCongViec.StudyUnitTypeId = _studyUnitTypeId;
			newViewThongTinLopHocPhanHeSoCongViec.StudyUnitTypeName = _studyUnitTypeName;
			newViewThongTinLopHocPhanHeSoCongViec.StudyUnitTypeAbbreviation = _studyUnitTypeAbbreviation;
			newViewThongTinLopHocPhanHeSoCongViec.ListOfClassStudentId = _listOfClassStudentId;
			newViewThongTinLopHocPhanHeSoCongViec.ListOfProfessorId = _listOfProfessorId;
			newViewThongTinLopHocPhanHeSoCongViec.ListOfProfessorFirstName = _listOfProfessorFirstName;
			newViewThongTinLopHocPhanHeSoCongViec.MaHeSoCongViec = _maHeSoCongViec;
			return newViewThongTinLopHocPhanHeSoCongViec;
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
		/// 	Gets or Sets the StudyUnitID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String StudyUnitId
		{
			get
			{
				return this._studyUnitId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "StudyUnitId does not allow null values.");
				if (_studyUnitId == value)
					return;
					
				this._studyUnitId = value;
				this._isDirty = true;
				
				OnPropertyChanged("StudyUnitId");
			}
		}
		
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
		/// 	Gets or Sets the Credits property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsCreditsNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? Credits
		{
			get
			{
				return this._credits; 
			}
			set
			{
				if (_credits == value && Credits != null )
					return;
					
				this._credits = value;
				this._isDirty = true;
				
				OnPropertyChanged("Credits");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the StudyUnitTypeID property. 
		///		
		/// </summary>
		/// <value>This type is tinyint</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Byte StudyUnitTypeId
		{
			get
			{
				return this._studyUnitTypeId; 
			}
			set
			{
				if (_studyUnitTypeId == value)
					return;
					
				this._studyUnitTypeId = value;
				this._isDirty = true;
				
				OnPropertyChanged("StudyUnitTypeId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the StudyUnitTypeName property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String StudyUnitTypeName
		{
			get
			{
				return this._studyUnitTypeName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "StudyUnitTypeName does not allow null values.");
				if (_studyUnitTypeName == value)
					return;
					
				this._studyUnitTypeName = value;
				this._isDirty = true;
				
				OnPropertyChanged("StudyUnitTypeName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the StudyUnitTypeAbbreviation property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String StudyUnitTypeAbbreviation
		{
			get
			{
				return this._studyUnitTypeAbbreviation; 
			}
			set
			{
				if (_studyUnitTypeAbbreviation == value)
					return;
					
				this._studyUnitTypeAbbreviation = value;
				this._isDirty = true;
				
				OnPropertyChanged("StudyUnitTypeAbbreviation");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ListOfClassStudentID property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfClassStudentId
		{
			get
			{
				return this._listOfClassStudentId; 
			}
			set
			{
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
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfProfessorId
		{
			get
			{
				return this._listOfProfessorId; 
			}
			set
			{
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
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ListOfProfessorFirstName
		{
			get
			{
				return this._listOfProfessorFirstName; 
			}
			set
			{
				if (_listOfProfessorFirstName == value)
					return;
					
				this._listOfProfessorFirstName = value;
				this._isDirty = true;
				
				OnPropertyChanged("ListOfProfessorFirstName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaHeSoCongViec property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaHeSoCongViecNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaHeSoCongViec
		{
			get
			{
				return this._maHeSoCongViec; 
			}
			set
			{
				if (_maHeSoCongViec == value && MaHeSoCongViec != null )
					return;
					
				this._maHeSoCongViec = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHeSoCongViec");
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
			get { return "View_ThongTinLopHocPhan_HeSoCongViec"; }
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
		///  Returns a Typed ViewThongTinLopHocPhanHeSoCongViecBase Entity 
		///</summary>
		public virtual ViewThongTinLopHocPhanHeSoCongViecBase Copy()
		{
			//shallow copy entity
			ViewThongTinLopHocPhanHeSoCongViec copy = new ViewThongTinLopHocPhanHeSoCongViec();
				copy.YearStudy = this.YearStudy;
				copy.TermId = this.TermId;
				copy.StudyUnitId = this.StudyUnitId;
				copy.ScheduleStudyUnitId = this.ScheduleStudyUnitId;
				copy.CurriculumId = this.CurriculumId;
				copy.CurriculumName = this.CurriculumName;
				copy.Credits = this.Credits;
				copy.StudyUnitTypeId = this.StudyUnitTypeId;
				copy.StudyUnitTypeName = this.StudyUnitTypeName;
				copy.StudyUnitTypeAbbreviation = this.StudyUnitTypeAbbreviation;
				copy.ListOfClassStudentId = this.ListOfClassStudentId;
				copy.ListOfProfessorId = this.ListOfProfessorId;
				copy.ListOfProfessorFirstName = this.ListOfProfessorFirstName;
				copy.MaHeSoCongViec = this.MaHeSoCongViec;
			copy.AcceptChanges();
			return (ViewThongTinLopHocPhanHeSoCongViec)copy;
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
		///<returns>true if toObject is a <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewThongTinLopHocPhanHeSoCongViecBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewThongTinLopHocPhanHeSoCongViecBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewThongTinLopHocPhanHeSoCongViecBase Object1, ViewThongTinLopHocPhanHeSoCongViecBase Object2)
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
			if (Object1.StudyUnitId != Object2.StudyUnitId)
				equal = false;
			if (Object1.ScheduleStudyUnitId != Object2.ScheduleStudyUnitId)
				equal = false;
			if (Object1.CurriculumId != Object2.CurriculumId)
				equal = false;
			if (Object1.CurriculumName != Object2.CurriculumName)
				equal = false;
			if (Object1.Credits != null && Object2.Credits != null )
			{
				if (Object1.Credits != Object2.Credits)
					equal = false;
			}
			else if (Object1.Credits == null ^ Object1.Credits == null )
			{
				equal = false;
			}
			if (Object1.StudyUnitTypeId != Object2.StudyUnitTypeId)
				equal = false;
			if (Object1.StudyUnitTypeName != Object2.StudyUnitTypeName)
				equal = false;
			if (Object1.StudyUnitTypeAbbreviation != null && Object2.StudyUnitTypeAbbreviation != null )
			{
				if (Object1.StudyUnitTypeAbbreviation != Object2.StudyUnitTypeAbbreviation)
					equal = false;
			}
			else if (Object1.StudyUnitTypeAbbreviation == null ^ Object1.StudyUnitTypeAbbreviation == null )
			{
				equal = false;
			}
			if (Object1.ListOfClassStudentId != null && Object2.ListOfClassStudentId != null )
			{
				if (Object1.ListOfClassStudentId != Object2.ListOfClassStudentId)
					equal = false;
			}
			else if (Object1.ListOfClassStudentId == null ^ Object1.ListOfClassStudentId == null )
			{
				equal = false;
			}
			if (Object1.ListOfProfessorId != null && Object2.ListOfProfessorId != null )
			{
				if (Object1.ListOfProfessorId != Object2.ListOfProfessorId)
					equal = false;
			}
			else if (Object1.ListOfProfessorId == null ^ Object1.ListOfProfessorId == null )
			{
				equal = false;
			}
			if (Object1.ListOfProfessorFirstName != null && Object2.ListOfProfessorFirstName != null )
			{
				if (Object1.ListOfProfessorFirstName != Object2.ListOfProfessorFirstName)
					equal = false;
			}
			else if (Object1.ListOfProfessorFirstName == null ^ Object1.ListOfProfessorFirstName == null )
			{
				equal = false;
			}
			if (Object1.MaHeSoCongViec != null && Object2.MaHeSoCongViec != null )
			{
				if (Object1.MaHeSoCongViec != Object2.MaHeSoCongViec)
					equal = false;
			}
			else if (Object1.MaHeSoCongViec == null ^ Object1.MaHeSoCongViec == null )
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
		public static object GetPropertyValueByName(ViewThongTinLopHocPhanHeSoCongViec entity, string propertyName)
		{
			switch (propertyName)
			{
				case "YearStudy":
					return entity.YearStudy;
				case "TermId":
					return entity.TermId;
				case "StudyUnitId":
					return entity.StudyUnitId;
				case "ScheduleStudyUnitId":
					return entity.ScheduleStudyUnitId;
				case "CurriculumId":
					return entity.CurriculumId;
				case "CurriculumName":
					return entity.CurriculumName;
				case "Credits":
					return entity.Credits;
				case "StudyUnitTypeId":
					return entity.StudyUnitTypeId;
				case "StudyUnitTypeName":
					return entity.StudyUnitTypeName;
				case "StudyUnitTypeAbbreviation":
					return entity.StudyUnitTypeAbbreviation;
				case "ListOfClassStudentId":
					return entity.ListOfClassStudentId;
				case "ListOfProfessorId":
					return entity.ListOfProfessorId;
				case "ListOfProfessorFirstName":
					return entity.ListOfProfessorFirstName;
				case "MaHeSoCongViec":
					return entity.MaHeSoCongViec;
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
			return GetPropertyValueByName(this as ViewThongTinLopHocPhanHeSoCongViec, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{15}{14}- YearStudy: {0}{14}- TermId: {1}{14}- StudyUnitId: {2}{14}- ScheduleStudyUnitId: {3}{14}- CurriculumId: {4}{14}- CurriculumName: {5}{14}- Credits: {6}{14}- StudyUnitTypeId: {7}{14}- StudyUnitTypeName: {8}{14}- StudyUnitTypeAbbreviation: {9}{14}- ListOfClassStudentId: {10}{14}- ListOfProfessorId: {11}{14}- ListOfProfessorFirstName: {12}{14}- MaHeSoCongViec: {13}{14}", 
				this.YearStudy,
				this.TermId,
				this.StudyUnitId,
				this.ScheduleStudyUnitId,
				this.CurriculumId,
				this.CurriculumName,
				(this.Credits == null) ? string.Empty : this.Credits.ToString(),
			     
				this.StudyUnitTypeId,
				this.StudyUnitTypeName,
				(this.StudyUnitTypeAbbreviation == null) ? string.Empty : this.StudyUnitTypeAbbreviation.ToString(),
			     
				(this.ListOfClassStudentId == null) ? string.Empty : this.ListOfClassStudentId.ToString(),
			     
				(this.ListOfProfessorId == null) ? string.Empty : this.ListOfProfessorId.ToString(),
			     
				(this.ListOfProfessorFirstName == null) ? string.Empty : this.ListOfProfessorFirstName.ToString(),
			     
				(this.MaHeSoCongViec == null) ? string.Empty : this.MaHeSoCongViec.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewThongTinLopHocPhanHeSoCongViec columns.
	/// </summary>
	[Serializable]
	public enum ViewThongTinLopHocPhanHeSoCongViecColumn
	{
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
		/// StudyUnitID : 
		/// </summary>
		[EnumTextValue("StudyUnitID")]
		[ColumnEnum("StudyUnitID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		StudyUnitId,
		/// <summary>
		/// ScheduleStudyUnitID : 
		/// </summary>
		[EnumTextValue("ScheduleStudyUnitID")]
		[ColumnEnum("ScheduleStudyUnitID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 30)]
		ScheduleStudyUnitId,
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
		/// Credits : 
		/// </summary>
		[EnumTextValue("Credits")]
		[ColumnEnum("Credits", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		Credits,
		/// <summary>
		/// StudyUnitTypeID : 
		/// </summary>
		[EnumTextValue("StudyUnitTypeID")]
		[ColumnEnum("StudyUnitTypeID", typeof(System.Byte), System.Data.DbType.Byte, false, false, false)]
		StudyUnitTypeId,
		/// <summary>
		/// StudyUnitTypeName : 
		/// </summary>
		[EnumTextValue("StudyUnitTypeName")]
		[ColumnEnum("StudyUnitTypeName", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		StudyUnitTypeName,
		/// <summary>
		/// StudyUnitTypeAbbreviation : 
		/// </summary>
		[EnumTextValue("StudyUnitTypeAbbreviation")]
		[ColumnEnum("StudyUnitTypeAbbreviation", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 10)]
		StudyUnitTypeAbbreviation,
		/// <summary>
		/// ListOfClassStudentID : 
		/// </summary>
		[EnumTextValue("ListOfClassStudentID")]
		[ColumnEnum("ListOfClassStudentID", typeof(System.String), System.Data.DbType.String, false, false, true)]
		ListOfClassStudentId,
		/// <summary>
		/// ListOfProfessorID : 
		/// </summary>
		[EnumTextValue("ListOfProfessorID")]
		[ColumnEnum("ListOfProfessorID", typeof(System.String), System.Data.DbType.String, false, false, true, 250)]
		ListOfProfessorId,
		/// <summary>
		/// ListOfProfessorFirstName : 
		/// </summary>
		[EnumTextValue("ListOfProfessorFirstName")]
		[ColumnEnum("ListOfProfessorFirstName", typeof(System.String), System.Data.DbType.String, false, false, true, 250)]
		ListOfProfessorFirstName,
		/// <summary>
		/// MaHeSoCongViec : 
		/// </summary>
		[EnumTextValue("MaHeSoCongViec")]
		[ColumnEnum("MaHeSoCongViec", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaHeSoCongViec
	}//End enum

} // end namespace
