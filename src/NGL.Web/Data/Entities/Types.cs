﻿ 

using System.ComponentModel;

namespace NGL.Web.Data.Entities.Types
{

	public enum CourseRepeatCodeTypeEnum
	{
		[Description("Repeat Counted")]
		RepeatCounted = 1,                               
		[Description("Repeat NotCounted")]
		RepeatNotCounted = 2,                               
		[Description("Replacement Counted")]
		ReplacementCounted = 3,                               
		[Description("Replaced NotCounted")]
		ReplacedNotCounted = 4,                               
		[Description("Repeat Other Institution")]
		RepeatOtherInstitution = 5,                               
		[Description("Not Counted Other")]
		NotCountedOther = 6,                               
	}

	public enum ProgramAssignmentTypeEnum
	{
		[Description("Regular Education")]
		RegularEducation = 1,                               
		[Description("Title I-Academic")]
		TitleI_Academic = 2,                               
		[Description("Title I-Non-Academic")]
		TitleI_Non_Academic = 3,                               
		[Description("Special Education")]
		SpecialEducation = 4,                               
		[Description("Bilingual/English as a Second Language")]
		BilingualEnglishasaSecondLanguage = 5,                               
		[Description("Other")]
		Other = 6,                               
	}

	public enum RecognitionTypeEnum
	{
		[Description("Athletic awards")]
		Athleticawards = 1,                               
		[Description("Awarding of units of value")]
		Awardingofunitsofvalue = 2,                               
		[Description("Citizenship award/recognition")]
		Citizenshipawardrecognition = 3,                               
		[Description("Completion of requirement, but no units of value awarded")]
		Completionofrequirementbutnounitsofvalueawarded = 4,                               
		[Description("Certificate")]
		Certificate = 5,                               
		[Description("Honor award")]
		Honoraward = 6,                               
		[Description("Letter of commendation")]
		Letterofcommendation = 7,                               
		[Description("Medals")]
		Medals = 8,                               
		[Description("Monogram/letter")]
		Monogramletter = 9,                               
		[Description("Points")]
		Points = 10,                               
		[Description("Promotion or advancement")]
		Promotionoradvancement = 11,                               
		[Description("Other")]
		Other = 12,                               
	}

	public enum EventCircumstanceTypeEnum
	{
		[Description("Long-term suspension - non-special education")]
		Long_termsuspension_non_specialeducation = 1,                               
		[Description("Short-term suspension - non-special education")]
		Short_termsuspension_non_specialeducation = 2,                               
		[Description("Suspension - special education")]
		Suspension_specialeducation = 3,                               
		[Description("Truancy - paperwork filed")]
		Truancy_paperworkfiled = 4,                               
		[Description("Truancy - no paperwork filed")]
		Truancy_nopaperworkfiled = 5,                               
		[Description("Earlier truancy")]
		Earliertruancy = 6,                               
		[Description("Chronic absences")]
		Chronicabsences = 7,                               
		[Description("Catastrophic illness or accident")]
		Catastrophicillnessoraccident = 8,                               
		[Description("Home schooled for assessed subjects")]
		Homeschooledforassessedsubjects = 9,                               
		[Description("Student took this grade level assessment last year")]
		Studenttookthisgradelevelassessmentlastyear = 10,                               
		[Description("Incarcerated at adult facility")]
		Incarceratedatadultfacility = 11,                               
		[Description("Special treatment center")]
		Specialtreatmentcenter = 12,                               
		[Description("Special detention center")]
		Specialdetentioncenter = 13,                               
		[Description("Parent refusal")]
		Parentrefusal = 14,                               
		[Description("Cheating")]
		Cheating = 15,                               
		[Description("Psychological factors of emotional trauma")]
		Psychologicalfactorsofemotionaltrauma = 16,                               
		[Description("Student not showing adequate effort")]
		Studentnotshowingadequateeffort = 17,                               
		[Description("Homebound")]
		Homebound = 18,                               
		[Description("Foreign exchange student")]
		Foreignexchangestudent = 19,                               
		[Description("Student refusal")]
		Studentrefusal = 20,                               
		[Description("Reading passage read to student (IEP)")]
		Readingpassagereadtostudent_IEP = 21,                               
		[Description("Non-special education student used calculator on non-calculator items")]
		Non_specialeducationstudentusedcalculatoronnon_calculatoritems = 22,                               
		[Description("Student used math journal (non-IEP)")]
		Studentusedmathjournal_non_IEP = 23,                               
		[Description("Other reason for ineligibility")]
		Otherreasonforineligibility = 24,                               
		[Description("Other reason for nonparticipation")]
		Otherreasonfornonparticipation = 25,                               
		[Description("Left testing")]
		Lefttesting = 26,                               
		[Description("Cross-enrolled")]
		Cross_enrolled = 27,                               
		[Description("Only for writing")]
		Onlyforwriting = 28,                               
		[Description("Administration or system failure")]
		Administrationorsystemfailure = 29,                               
		[Description("Teacher cheating or mis-admin")]
		Teachercheatingormis_admin = 30,                               
		[Description("Fire alarm")]
		Firealarm = 31,                               
		[Description("Other")]
		Other = 32,                               
	}

	public enum WeaponTypeEnum
	{
		[Description("Handgun")]
		Handgun = 1,                               
		[Description("Rifle/Shotgun")]
		RifleShotgun = 2,                               
		[Description("Other Firearm")]
		OtherFirearm = 3,                               
		[Description("Club")]
		Club = 4,                               
		[Description("Other Sharp Objects")]
		OtherSharpObjects = 5,                               
		[Description("Other Object")]
		OtherObject = 6,                               
		[Description("Substance Used as Weapon")]
		SubstanceUsedasWeapon = 7,                               
		[Description("Knife")]
		Knife = 8,                               
		[Description("Unknown")]
		Unknown = 9,                               
		[Description("Other")]
		Other = 10,                               
	}

	public enum PublicationStatusTypeEnum
	{
		[Description("Adopted")]
		Adopted = 1,                               
		[Description("Draft")]
		Draft = 2,                               
		[Description("Published")]
		Published = 3,                               
		[Description("Deprecated")]
		Deprecated = 4,                               
		[Description("Unknown")]
		Unknown = 5,                               
	}

	public enum CohortScopeTypeEnum
	{
		[Description("District")]
		District = 1,                               
		[Description("School")]
		School = 2,                               
		[Description("Network")]
		Network = 3,                               
		[Description("Classroom")]
		Classroom = 4,                               
		[Description("Teacher")]
		Teacher = 5,                               
		[Description("Principal")]
		Principal = 6,                               
		[Description("Counselor")]
		Counselor = 7,                               
		[Description("Statewide")]
		Statewide = 8,                               
		[Description("Other")]
		Other = 9,                               
		[Description("Campus")]
		Campus = 10,                               
	}

	public enum LimitedEnglishProficiencyTypeEnum
	{
		[Description("NotLimited")]
		NotLimited = 1,                               
		[Description("Limited")]
		Limited = 2,                               
		[Description("Limited Monitored 1")]
		LimitedMonitored1 = 3,                               
		[Description("Limited Monitored 2")]
		LimitedMonitored2 = 4,                               
	}

	public enum RelationTypeEnum
	{
		[Description("Aunt")]
		Aunt = 1,                               
		[Description("Brother")]
		Brother = 2,                               
		[Description("BrotherInLaw")]
		BrotherInLaw = 3,                               
		[Description("CourtAppointedGuardian")]
		CourtAppointedGuardian = 4,                               
		[Description("Daughter")]
		Daughter = 5,                               
		[Description("DaughterInLaw")]
		DaughterInLaw = 6,                               
		[Description("Employer")]
		Employer = 7,                               
		[Description("Father")]
		Father = 8,                               
		[Description("FathersSignificantOther")]
		FathersSignificantOther = 9,                               
		[Description("FathersCivilPartner")]
		FathersCivilPartner = 10,                               
		[Description("FatherInLaw")]
		FatherInLaw = 11,                               
		[Description("Fiance")]
		Fiance = 12,                               
		[Description("Fiancee")]
		Fiancee = 13,                               
		[Description("Friend")]
		Friend = 14,                               
		[Description("Grandfather")]
		Grandfather = 15,                               
		[Description("Grandmother")]
		Grandmother = 16,                               
		[Description("Husband")]
		Husband = 17,                               
		[Description("MothersSignificantOther")]
		MothersSignificantOther = 18,                               
		[Description("Mother")]
		Mother = 19,                               
		[Description("MothersCivilPartner")]
		MothersCivilPartner = 20,                               
		[Description("Nephew")]
		Nephew = 21,                               
		[Description("Niece")]
		Niece = 22,                               
		[Description("Other")]
		Other = 23,                               
		[Description("SignificantOther")]
		SignificantOther = 24,                               
		[Description("Sister")]
		Sister = 25,                               
		[Description("Son")]
		Son = 26,                               
		[Description("Unknown")]
		Unknown = 27,                               
		[Description("Uncle")]
		Uncle = 28,                               
		[Description("Ward")]
		Ward = 29,                               
		[Description("Wife")]
		Wife = 30,                               
		[Description("Great Grandparent")]
		GreatGrandparent = 31,                               
		[Description("Foster parent")]
		Fosterparent = 32,                               
		[Description("Mother, step")]
		Motherstep = 33,                               
		[Description("Father, step")]
		Fatherstep = 34,                               
		[Description("Great aunt")]
		Greataunt = 35,                               
		[Description("Great uncle")]
		Greatuncle = 36,                               
		[Description("Cousin")]
		Cousin = 37,                               
	}

	public enum ExitWithdrawTypeEnum
	{
		[Description("Transferred")]
		Transferred = 1,                               
		[Description("Graduated")]
		Graduated = 2,                               
		[Description("Completed ")]
		Completed = 3,                               
		[Description("Died or is permanently incapacitated")]
		Diedorispermanentlyincapacitated = 4,                               
		[Description("Withdrawn")]
		Withdrawn = 5,                               
		[Description("Expelled")]
		Expelled = 6,                               
		[Description("Reached maximum age")]
		Reachedmaximumage = 7,                               
		[Description("Enrolled in a high school diploma program")]
		Enrolledinahighschooldiplomaprogram = 8,                               
		[Description("Involuntarily Removed")]
		InvoluntarilyRemoved = 9,                               
		[Description("Incarcerated")]
		Incarcerated = 10,                               
		[Description("Dropout")]
		Dropout = 11,                               
		[Description("End of school year")]
		Endofschoolyear = 12,                               
		[Description("Invalid enrollment")]
		Invalidenrollment = 13,                               
		[Description("No show")]
		Noshow = 14,                               
		[Description("Other")]
		Other = 15,                               
	}

	public enum StaffClassificationTypeEnum
	{
		[Description("Counselor")]
		Counselor = 2,                               
		[Description("Teacher")]
		Teacher = 6,                               
		[Description("Other")]
		Other = 11,                               
		[Description("Assistant Superintendent")]
		AssistantSuperintendent = 15,                               
		[Description("Superintendent")]
		Superintendent = 16,                               
		[Description("LEA Administrator")]
		LEAAdministrator = 17,                               
		[Description("School Administrator")]
		SchoolAdministrator = 18,                               
		[Description("School Specialist")]
		SchoolSpecialist = 19,                               
		[Description("LEA Specialist")]
		LEASpecialist = 20,                               
		[Description("Substitute Teacher")]
		SubstituteTeacher = 22,                               
		[Description("School Leader")]
		SchoolLeader = 23,                               
		[Description("Instructional Coordinator")]
		InstructionalCoordinator = 24,                               
		[Description("Librarians/Media Specialists")]
		LibrariansMediaSpecialists = 25,                               
		[Description("Support Services Staff")]
		SupportServicesStaff = 28,                               
		[Description("Operational Support")]
		OperationalSupport = 29,                               
		[Description("Instructional Aide")]
		InstructionalAide = 30,                               
		[Description("State Administrator")]
		StateAdministrator = 31,                               
		[Description("Principal")]
		Principal = 32,                               
		[Description("Assistant Principal")]
		AssistantPrincipal = 33,                               
		[Description("LEA System Administrator")]
		LEASystemAdministrator = 34,                               
	}

	public enum InternetAccessTypeEnum
	{
		[Description("High Speed")]
		HighSpeed = 1,                               
		[Description("Less Than High Speed")]
		LessThanHighSpeed = 2,                               
	}

	public enum TeachingCredentialTypeEnum
	{
		[Description("Emergency")]
		Emergency = 1,                               
		[Description("Intern")]
		Intern = 2,                               
		[Description("Master")]
		Master = 3,                               
		[Description("Nonrenewable")]
		Nonrenewable = 4,                               
		[Description("Other")]
		Other = 5,                               
		[Description("Paraprofessional")]
		Paraprofessional = 6,                               
		[Description("Professional")]
		Professional = 7,                               
		[Description("Probationary/Initial")]
		ProbationaryInitial = 8,                               
		[Description("Provisional")]
		Provisional = 9,                               
		[Description("Regular/Standard")]
		RegularStandard = 10,                               
		[Description("Retired")]
		Retired = 11,                               
		[Description("Specialist")]
		Specialist = 12,                               
		[Description("Substitute")]
		Substitute = 13,                               
		[Description("Teacher Assistant")]
		TeacherAssistant = 14,                               
		[Description("Temporary")]
		Temporary = 15,                               
	}

	public enum CohortTypeEnum
	{
		[Description("Academic Intervention")]
		AcademicIntervention = 1,                               
		[Description("Attendance Intervention")]
		AttendanceIntervention = 2,                               
		[Description("Discipline Intervention")]
		DisciplineIntervention = 3,                               
		[Description("Classroom Pullout")]
		ClassroomPullout = 4,                               
		[Description("Extracurricular Activity")]
		ExtracurricularActivity = 5,                               
		[Description("Field Trip")]
		FieldTrip = 6,                               
		[Description("Principal Watch List")]
		PrincipalWatchList = 7,                               
		[Description("Counselor List")]
		CounselorList = 8,                               
		[Description("In-school Suspension")]
		In_schoolSuspension = 9,                               
		[Description("Study Hall")]
		StudyHall = 10,                               
		[Description("Other")]
		Other = 11,                               
	}

	public enum SchoolFoodServicesEligibilityTypeEnum
	{
		[Description("Free")]
		Free = 1,                               
		[Description("Full price")]
		Fullprice = 2,                               
		[Description("Reduced price")]
		Reducedprice = 3,                               
		[Description("Unknown")]
		Unknown = 4,                               
	}

	public enum StudentCharacteristicTypeEnum
	{
		[Description("Asylee")]
		Asylee = 1,                               
		[Description("Displaced Homemaker")]
		DisplacedHomemaker = 2,                               
		[Description("Foster Care")]
		FosterCare = 3,                               
		[Description("Homeless")]
		Homeless = 4,                               
		[Description("Immigrant")]
		Immigrant = 5,                               
		[Description("Neglected or Delinquent")]
		NeglectedorDelinquent = 6,                               
		[Description("Migrant")]
		Migrant = 7,                               
		[Description("Parent in Military")]
		ParentinMilitary = 8,                               
		[Description("Pregnant")]
		Pregnant = 9,                               
		[Description("Refugee")]
		Refugee = 10,                               
		[Description("Section 504 Handicapped")]
		Section504Handicapped = 11,                               
		[Description("Single Parent")]
		SingleParent = 12,                               
		[Description("Unaccompanied Youth")]
		UnaccompaniedYouth = 13,                               
	}

	public enum InteractivityStyleTypeEnum
	{
		[Description("Active")]
		Active = 1,                               
		[Description("Expositive")]
		Expositive = 2,                               
		[Description("Mixed")]
		Mixed = 3,                               
	}

	public enum AcademicHonorCategoryTypeEnum
	{
		[Description("Honor roll")]
		Honorroll = 1,                               
		[Description("Honor society")]
		Honorsociety = 2,                               
		[Description("Honorable mention")]
		Honorablemention = 3,                               
		[Description("Honors program")]
		Honorsprogram = 4,                               
		[Description("Prize awards")]
		Prizeawards = 5,                               
		[Description("Scholarships")]
		Scholarships = 6,                               
		[Description("Awarding of units of value")]
		Awardingofunitsofvalue = 7,                               
		[Description("Citizenship award/recognition, but no units of value awarded")]
		Citizenshipawardrecognitionbutnounitsofvalueawarded = 8,                               
		[Description("Completion of requirement")]
		Completionofrequirement = 9,                               
		[Description("Attendance award")]
		Attendanceaward = 10,                               
		[Description("Certificate")]
		Certificate = 11,                               
		[Description("Honor award")]
		Honoraward = 12,                               
		[Description("Letter of student commendation")]
		Letterofstudentcommendation = 13,                               
		[Description("Medals")]
		Medals = 14,                               
		[Description("National Merit scholar")]
		NationalMeritscholar = 15,                               
		[Description("Points")]
		Points = 16,                               
		[Description("Promotion or advancement")]
		Promotionoradvancement = 17,                               
		[Description("Other")]
		Other = 18,                               
	}

	public enum PostingResultTypeEnum
	{
		[Description("Position Filled")]
		PositionFilled = 1,                               
		[Description("Posting Cancelled")]
		PostingCancelled = 2,                               
	}

	public enum TermTypeEnum
	{
		[Description("Fall Semester")]
		FallSemester = 1,                               
		[Description("Spring Semester")]
		SpringSemester = 2,                               
		[Description("Summer Semester")]
		SummerSemester = 3,                               
		[Description("Year Round")]
		YearRound = 4,                               
		[Description("First Trimester")]
		FirstTrimester = 5,                               
		[Description("Second Trimester")]
		SecondTrimester = 6,                               
		[Description("Third Trimester")]
		ThirdTrimester = 7,                               
		[Description("MiniTerm")]
		MiniTerm = 8,                               
		[Description("First Quarter")]
		FirstQuarter = 9,                               
		[Description("Second Quarter")]
		SecondQuarter = 10,                               
		[Description("Third Quarter")]
		ThirdQuarter = 11,                               
		[Description("Fourth Quarter")]
		FourthQuarter = 12,                               
	}

	public enum TeachingCredentialBasisTypeEnum
	{
		[Description("4-year bachelor's degree")]
		_4_yearbachelorsdegree = 1,                               
		[Description("5-year bachelor's degree")]
		_5_yearbachelorsdegree = 2,                               
		[Description("Master's degree")]
		Mastersdegree = 3,                               
		[Description("Doctoral degree")]
		Doctoraldegree = 4,                               
		[Description("Met state testing requirement")]
		Metstatetestingrequirement = 5,                               
		[Description("Special/alternative program completion")]
		Specialalternativeprogramcompletion = 6,                               
		[Description("Relevant experience")]
		Relevantexperience = 7,                               
		[Description("Credentials based on reciprocation with another state")]
		Credentialsbasedonreciprocationwithanotherstate = 8,                               
	}

	public enum StateAbbreviationTypeEnum
	{
		[Description("AL")]
		AL = 1,                               
		[Description("AK")]
		AK = 2,                               
		[Description("AZ")]
		AZ = 3,                               
		[Description("AR")]
		AR = 4,                               
		[Description("CA")]
		CA = 5,                               
		[Description("CO")]
		CO = 6,                               
		[Description("CT")]
		CT = 7,                               
		[Description("DC")]
		DC = 8,                               
		[Description("DE")]
		DE = 9,                               
		[Description("FL")]
		FL = 10,                               
		[Description("GA")]
		GA = 11,                               
		[Description("GU")]
		GU = 12,                               
		[Description("HI")]
		HI = 13,                               
		[Description("ID")]
		ID = 14,                               
		[Description("IL")]
		IL = 15,                               
		[Description("IN")]
		IN = 16,                               
		[Description("IA")]
		IA = 17,                               
		[Description("KS")]
		KS = 18,                               
		[Description("KY")]
		KY = 19,                               
		[Description("LA")]
		LA = 20,                               
		[Description("ME")]
		ME = 21,                               
		[Description("MD")]
		MD = 22,                               
		[Description("MA")]
		MA = 23,                               
		[Description("MI")]
		MI = 24,                               
		[Description("MN")]
		MN = 25,                               
		[Description("MS")]
		MS = 26,                               
		[Description("MO")]
		MO = 27,                               
		[Description("MT")]
		MT = 28,                               
		[Description("NE")]
		NE = 29,                               
		[Description("NV")]
		NV = 30,                               
		[Description("NH")]
		NH = 31,                               
		[Description("NJ")]
		NJ = 32,                               
		[Description("NM")]
		NM = 33,                               
		[Description("NY")]
		NY = 34,                               
		[Description("NC")]
		NC = 35,                               
		[Description("ND")]
		ND = 36,                               
		[Description("OH")]
		OH = 37,                               
		[Description("OK")]
		OK = 38,                               
		[Description("OR")]
		OR = 39,                               
		[Description("PA")]
		PA = 40,                               
		[Description("PR")]
		PR = 41,                               
		[Description("RI")]
		RI = 42,                               
		[Description("SC")]
		SC = 43,                               
		[Description("SD")]
		SD = 44,                               
		[Description("TN")]
		TN = 45,                               
		[Description("TX")]
		TX = 46,                               
		[Description("UT")]
		UT = 47,                               
		[Description("VT")]
		VT = 48,                               
		[Description("VA")]
		VA = 49,                               
		[Description("WA")]
		WA = 50,                               
		[Description("WV")]
		WV = 51,                               
		[Description("WI")]
		WI = 52,                               
		[Description("WY")]
		WY = 53,                               
	}

	public enum RepeatIdentifierTypeEnum
	{
		[Description("Repeated,  counted in grade point average")]
		Repeatedcountedingradepointaverage = 1,                               
		[Description("Repeated, not  counted in grade point average")]
		Repeatednotcountedingradepointaverage = 2,                               
		[Description("Replacement counted")]
		Replacementcounted = 3,                               
		[Description("Replacement not counted")]
		Replacementnotcounted = 4,                               
		[Description("Repeated,  counted in grade point average, other institution")]
		Repeatedcountedingradepointaverageotherinstitution = 5,                               
		[Description("Not repeated")]
		Notrepeated = 6,                               
		[Description("Other, not counted in GPA")]
		OthernotcountedinGPA = 7,                               
		[Description("Other")]
		Other = 8,                               
	}

	public enum AcademicSubjectTypeEnum
	{
		[Description("Reading")]
		Reading = 1,                               
		[Description("English Language Arts")]
		EnglishLanguageArts = 2,                               
		[Description("Mathematics")]
		Mathematics = 3,                               
		[Description("Writing")]
		Writing = 4,                               
		[Description("Social Studies")]
		SocialStudies = 5,                               
		[Description("Science")]
		Science = 6,                               
		[Description("Social Sciences and History")]
		SocialSciencesandHistory = 7,                               
		[Description("English")]
		English = 8,                               
		[Description("Critical Reading")]
		CriticalReading = 9,                               
		[Description("Life and Physical Sciences")]
		LifeandPhysicalSciences = 10,                               
		[Description("Fine and Performing Arts")]
		FineandPerformingArts = 11,                               
		[Description("Foreign Language and Literature")]
		ForeignLanguageandLiterature = 12,                               
		[Description("Religious Education and Theology")]
		ReligiousEducationandTheology = 13,                               
		[Description("Physical, Health, and Safety Education")]
		PhysicalHealthandSafetyEducation = 14,                               
		[Description("Military Science")]
		MilitaryScience = 15,                               
		[Description("Other")]
		Other = 31,                               
		[Description("Career and Technical Education")]
		CareerandTechnicalEducation = 32,                               
		[Description("Composite")]
		Composite = 33,                               
	}

	public enum CohortYearTypeEnum
	{
		[Description("Eighth grade")]
		Eighthgrade = 1,                               
		[Description("Eleventh grade")]
		Eleventhgrade = 2,                               
		[Description("Fifth grade")]
		Fifthgrade = 3,                               
		[Description("First grade")]
		Firstgrade = 4,                               
		[Description("Fourth grade")]
		Fourthgrade = 5,                               
		[Description("Ninth grade")]
		Ninthgrade = 6,                               
		[Description("Second grade")]
		Secondgrade = 7,                               
		[Description("Seventh grade")]
		Seventhgrade = 8,                               
		[Description("Sixth grade")]
		Sixthgrade = 9,                               
		[Description("Tenth grade")]
		Tenthgrade = 10,                               
		[Description("Third grade")]
		Thirdgrade = 11,                               
		[Description("Twelfth grade")]
		Twelfthgrade = 12,                               
	}

	public enum AssessmentIdentificationSystemTypeEnum
	{
		[Description("School")]
		School = 1,                               
		[Description("District")]
		District = 2,                               
		[Description("State")]
		State = 3,                               
		[Description("Federal")]
		Federal = 4,                               
		[Description("Other Federal")]
		OtherFederal = 5,                               
		[Description("Test Contractor")]
		TestContractor = 6,                               
		[Description("Other")]
		Other = 7,                               
	}

	public enum TitleIPartAParticipantTypeEnum
	{
		[Description("Public Targeted Assistance Program")]
		PublicTargetedAssistanceProgram = 1,                               
		[Description("Public Schoolwide Program")]
		PublicSchoolwideProgram = 2,                               
		[Description("Private school students participating")]
		Privateschoolstudentsparticipating = 3,                               
		[Description("Local Neglected Program")]
		LocalNeglectedProgram = 4,                               
		[Description("Was not served")]
		Wasnotserved = 5,                               
	}

	public enum CareerPathwayTypeEnum
	{
		[Description("Agriculture, Food and Natural Resources")]
		AgricultureFoodandNaturalResources = 1,                               
		[Description("Architecture and Construction")]
		ArchitectureandConstruction = 2,                               
		[Description("Arts, A/V Technology and Communications")]
		ArtsAVTechnologyandCommunications = 3,                               
		[Description("Business, Management and Administration")]
		BusinessManagementandAdministration = 4,                               
		[Description("Education and Training")]
		EducationandTraining = 5,                               
		[Description("Finance")]
		Finance = 6,                               
		[Description("Government and Public Administration")]
		GovernmentandPublicAdministration = 7,                               
		[Description("Health Science")]
		HealthScience = 8,                               
		[Description("Hospitality and Tourism")]
		HospitalityandTourism = 9,                               
		[Description("Human Services")]
		HumanServices = 10,                               
		[Description("Information Technology")]
		InformationTechnology = 11,                               
		[Description("Law, Public Safety, Corrections and Security")]
		LawPublicSafetyCorrectionsandSecurity = 12,                               
		[Description("Manufacturing")]
		Manufacturing = 13,                               
		[Description("Marketing, Sales and Service")]
		MarketingSalesandService = 14,                               
		[Description("Science, Technology, Engineering and Mathematics")]
		ScienceTechnologyEngineeringandMathematics = 15,                               
		[Description("Transportation, Distribution and Logistics")]
		TransportationDistributionandLogistics = 16,                               
	}

	public enum GradingPeriodTypeEnum
	{
		[Description("First Six Weeks")]
		FirstSixWeeks = 1,                               
		[Description("Second Six Weeks")]
		SecondSixWeeks = 2,                               
		[Description("Third Six Weeks")]
		ThirdSixWeeks = 3,                               
		[Description("Fourth Six Weeks")]
		FourthSixWeeks = 4,                               
		[Description("Fifth Six Weeks")]
		FifthSixWeeks = 5,                               
		[Description("Sixth Six Weeks")]
		SixthSixWeeks = 6,                               
		[Description("First Semester")]
		FirstSemester = 7,                               
		[Description("Second Semester")]
		SecondSemester = 8,                               
		[Description("Summer Semester")]
		SummerSemester = 9,                               
		[Description("First Nine Weeks")]
		FirstNineWeeks = 10,                               
		[Description("Second Nine Weeks")]
		SecondNineWeeks = 11,                               
		[Description("Third Nine Weeks")]
		ThirdNineWeeks = 12,                               
		[Description("Fourth Nine Weeks")]
		FourthNineWeeks = 13,                               
		[Description("End of Year")]
		EndofYear = 14,                               
		[Description("First Summer Session")]
		FirstSummerSession = 15,                               
		[Description("Second Summer Session")]
		SecondSummerSession = 16,                               
		[Description("Third Summer Session")]
		ThirdSummerSession = 17,                               
		[Description("First Trimester")]
		FirstTrimester = 18,                               
		[Description("Second Trimester")]
		SecondTrimester = 19,                               
		[Description("Third Trimester")]
		ThirdTrimester = 20,                               
	}

	public enum CourseDefinedByTypeEnum
	{
		[Description("LEA")]
		LEA = 1,                               
		[Description("National Organization")]
		NationalOrganization = 2,                               
		[Description("SEA")]
		SEA = 3,                               
		[Description("School")]
		School = 4,                               
	}

	public enum OtherNameTypeEnum
	{
		[Description("Alias")]
		Alias = 1,                               
		[Description("Nickname")]
		Nickname = 2,                               
		[Description("Other Name")]
		OtherName = 3,                               
		[Description("Previous Legal Name")]
		PreviousLegalName = 4,                               
	}

	public enum LanguageTypeEnum
	{
		[Description("English")]
		English = 1,                               
		[Description("Spanish")]
		Spanish = 2,                               
		[Description("Other")]
		Other = 27,                               
	}

	public enum OperationalStatusTypeEnum
	{
		[Description("Active")]
		Active = 1,                               
		[Description("Added")]
		Added = 2,                               
		[Description("Changed Agency")]
		ChangedAgency = 3,                               
		[Description("Closed")]
		Closed = 4,                               
		[Description("Continuing")]
		Continuing = 5,                               
		[Description("Future")]
		Future = 6,                               
		[Description("Inactive")]
		Inactive = 7,                               
		[Description("New")]
		New = 8,                               
		[Description("Reopened")]
		Reopened = 9,                               
	}

	public enum MethodCreditEarnedTypeEnum
	{
		[Description("Classroom credit")]
		Classroomcredit = 1,                               
		[Description("Converted occupational experience credit")]
		Convertedoccupationalexperiencecredit = 2,                               
		[Description("Correspondence credit")]
		Correspondencecredit = 3,                               
		[Description("Credit by examination")]
		Creditbyexamination = 4,                               
		[Description("Credit recovery")]
		Creditrecovery = 5,                               
		[Description("Online credit")]
		Onlinecredit = 6,                               
		[Description("Transfer credit")]
		Transfercredit = 7,                               
	}

	public enum ContentClassTypeEnum
	{
		[Description("Presentation")]
		Presentation = 1,                               
		[Description("Education Research")]
		EducationResearch = 2,                               
		[Description("Vendor Intervention Offering")]
		VendorInterventionOffering = 3,                               
		[Description("Written Activity")]
		WrittenActivity = 4,                               
		[Description("Video")]
		Video = 5,                               
	}

	public enum CourseGPAApplicabilityTypeEnum
	{
		[Description("Applicable")]
		Applicable = 1,                               
		[Description("Not Applicable")]
		NotApplicable = 2,                               
		[Description("Weighted")]
		Weighted = 3,                               
	}

	public enum StaffIdentificationSystemTypeEnum
	{
		[Description("Drivers License")]
		DriversLicense = 1,                               
		[Description("Health Record")]
		HealthRecord = 2,                               
		[Description("Medicaid")]
		Medicaid = 3,                               
		[Description("Professional Certificate")]
		ProfessionalCertificate = 4,                               
		[Description("School")]
		School = 5,                               
		[Description("District")]
		District = 6,                               
		[Description("State")]
		State = 7,                               
		[Description("Federal")]
		Federal = 8,                               
		[Description("Other Federal")]
		OtherFederal = 9,                               
		[Description("Selective Service")]
		SelectiveService = 10,                               
		[Description("SSN")]
		SSN = 11,                               
		[Description("US Visa")]
		USVisa = 12,                               
		[Description("PIN")]
		PIN = 13,                               
		[Description("Canadian SIN")]
		CanadianSIN = 14,                               
		[Description("Other")]
		Other = 15,                               
	}

	public enum ContinuationOfServicesReasonTypeEnum
	{
		[Description("Ceased to be migratory during school term")]
		Ceasedtobemigratoryduringschoolterm = 1,                               
		[Description("Ceased to be migratory during previous school term and no comparable servic")]
		Ceasedtobemigratoryduringpreviousschooltermandnocomparableservic = 2,                               
		[Description("Previously migratory secondary student continuing secondary school credit a")]
		Previouslymigratorysecondarystudentcontinuingsecondaryschoolcredita = 3,                               
	}

	public enum CreditTypeEnum
	{
		[Description("Adult education credit")]
		Adulteducationcredit = 1,                               
		[Description("Career and Technical Education credit")]
		CareerandTechnicalEducationcredit = 2,                               
		[Description("Carnegie unit")]
		Carnegieunit = 3,                               
		[Description("Converted occupational experience credit")]
		Convertedoccupationalexperiencecredit = 4,                               
		[Description("Correspondence credit")]
		Correspondencecredit = 5,                               
		[Description("Credit by examination")]
		Creditbyexamination = 6,                               
		[Description("Intersession hour credit")]
		Intersessionhourcredit = 7,                               
		[Description("Long session hour credit")]
		Longsessionhourcredit = 8,                               
		[Description("Mini-term hour credit")]
		Mini_termhourcredit = 9,                               
		[Description("Nine month year hour credit")]
		Ninemonthyearhourcredit = 10,                               
		[Description("Quarter hour credit")]
		Quarterhourcredit = 11,                               
		[Description("Quinmester hour credit")]
		Quinmesterhourcredit = 12,                               
		[Description("Semester hour credit")]
		Semesterhourcredit = 13,                               
		[Description("Summer term hour credit")]
		Summertermhourcredit = 14,                               
		[Description("Trimester hour credit")]
		Trimesterhourcredit = 15,                               
		[Description("Twelve month year hour credit")]
		Twelvemonthyearhourcredit = 16,                               
		[Description("Other")]
		Other = 17,                               
	}

	public enum ResidencyStatusTypeEnum
	{
		[Description("Resident of administrative unit and usual school attendance area")]
		Residentofadministrativeunitandusualschoolattendancearea = 1,                               
		[Description("Resident of administrative unit, but of other school attendance area")]
		Residentofadministrativeunitbutofotherschoolattendancearea = 2,                               
		[Description("Resident of this state, but not of this administrative unit")]
		Residentofthisstatebutnotofthisadministrativeunit = 3,                               
		[Description("Resident of an administrative unit that crosses state boundaries")]
		Residentofanadministrativeunitthatcrossesstateboundaries = 4,                               
		[Description("Resident of another state")]
		Residentofanotherstate = 5,                               
	}

	public enum StudentParticipationCodeTypeEnum
	{
		[Description("Victim")]
		Victim = 1,                               
		[Description("Perpetrator")]
		Perpetrator = 2,                               
		[Description("Witness")]
		Witness = 3,                               
		[Description("Reporter")]
		Reporter = 4,                               
	}

	public enum GradeTypeEnum
	{
		[Description("Conduct")]
		Conduct = 1,                               
		[Description("Exam")]
		Exam = 2,                               
		[Description("Final")]
		Final = 3,                               
		[Description("Grading Period")]
		GradingPeriod = 4,                               
		[Description("Mid-Term Grade")]
		Mid_TermGrade = 5,                               
		[Description("Progress Report")]
		ProgressReport = 6,                               
		[Description("Semester")]
		Semester = 7,                               
	}

	public enum AssessmentItemCategoryTypeEnum
	{
		[Description("Analytic")]
		Analytic = 1,                               
		[Description("Essay")]
		Essay = 2,                               
		[Description("Fill-in-the-blank")]
		Fill_in_the_blank = 3,                               
		[Description("Innovative")]
		Innovative = 4,                               
		[Description("Labeling")]
		Labeling = 5,                               
		[Description("List Question")]
		ListQuestion = 6,                               
		[Description("Math Matrix")]
		MathMatrix = 7,                               
		[Description("Matching")]
		Matching = 8,                               
		[Description("Multiple-choice")]
		Multiple_choice = 9,                               
		[Description("Other")]
		Other = 10,                               
		[Description("Other constructed response")]
		Otherconstructedresponse = 11,                               
		[Description("Other extended response")]
		Otherextendedresponse = 12,                               
		[Description("Performance task")]
		Performancetask = 13,                               
		[Description("Prose")]
		Prose = 14,                               
		[Description("Reordering")]
		Reordering = 15,                               
		[Description("Rubric")]
		Rubric = 16,                               
		[Description("Short answer")]
		Shortanswer = 17,                               
		[Description("Show your work")]
		Showyourwork = 18,                               
		[Description("Substitution")]
		Substitution = 19,                               
		[Description("True-False")]
		True_False = 20,                               
		[Description("Visual representation")]
		Visualrepresentation = 21,                               
	}

	public enum LevelOfEducationTypeEnum
	{
		[Description("Did Not Graduate High School")]
		DidNotGraduateHighSchool = 1,                               
		[Description("High School Diploma")]
		HighSchoolDiploma = 2,                               
		[Description("Some College No Degree")]
		SomeCollegeNoDegree = 3,                               
		[Description("Bachelor's")]
		Bachelors = 4,                               
		[Description("Master's")]
		Masters = 5,                               
		[Description("Doctorate")]
		Doctorate = 6,                               
		[Description("Associate's Degree (two years or more)")]
		AssociatesDegree_twoyearsormore = 7,                               
	}

	public enum PersonalInformationVerificationTypeEnum
	{
		[Description("Baptismal or church certificate")]
		Baptismalorchurchcertificate = 1,                               
		[Description("Birth certificate")]
		Birthcertificate = 2,                               
		[Description("Drivers license")]
		Driverslicense = 3,                               
		[Description("Entry in family Bible")]
		EntryinfamilyBible = 4,                               
		[Description("Hospital certificate")]
		Hospitalcertificate = 5,                               
		[Description("Immigration document/visa")]
		Immigrationdocumentvisa = 6,                               
		[Description("Life insurance policy")]
		Lifeinsurancepolicy = 7,                               
		[Description("Other")]
		Other = 8,                               
		[Description("Other non-official document")]
		Othernon_officialdocument = 9,                               
		[Description("Other official document")]
		Otherofficialdocument = 10,                               
		[Description("Parents affidavit")]
		Parentsaffidavit = 11,                               
		[Description("Passport")]
		Passport = 12,                               
		[Description("Physicians certificate")]
		Physicianscertificate = 13,                               
		[Description("Previously verified school records")]
		Previouslyverifiedschoolrecords = 14,                               
		[Description("State-issued ID")]
		State_issuedID = 15,                               
	}

	public enum ResponseIndicatorTypeEnum
	{
		[Description("Nonscorable response")]
		Nonscorableresponse = 1,                               
		[Description("Ineffective response")]
		Ineffectiveresponse = 2,                               
		[Description("Effective response")]
		Effectiveresponse = 3,                               
		[Description("Partial response")]
		Partialresponse = 4,                               
	}

	public enum EducationOrganizationCategoryTypeEnum
	{
		[Description("Education Service Center")]
		EducationServiceCenter = 1,                               
		[Description("Local Education Agency")]
		LocalEducationAgency = 2,                               
		[Description("School")]
		School = 3,                               
		[Description("State Education Agency")]
		StateEducationAgency = 4,                               
		[Description("Education Organization Network")]
		EducationOrganizationNetwork = 5,                               
	}

	public enum GradebookEntryTypeEnum
	{
		[Description("Activity")]
		Activity = 1,                               
		[Description("Assignment")]
		Assignment = 2,                               
		[Description("Classroom Assessment")]
		ClassroomAssessment = 3,                               
		[Description("Homework")]
		Homework = 4,                               
		[Description("Lesson")]
		Lesson = 5,                               
		[Description("Oral Presentation")]
		OralPresentation = 6,                               
		[Description("Quiz")]
		Quiz = 7,                               
		[Description("Unit Test")]
		UnitTest = 8,                               
	}

	public enum CredentialTypeEnum
	{
		[Description("Certification")]
		Certification = 1,                               
		[Description("Endorsement")]
		Endorsement = 2,                               
		[Description("Licensure")]
		Licensure = 3,                               
		[Description("Other")]
		Other = 4,                               
		[Description("Registration")]
		Registration = 5,                               
	}

	public enum AccommodationTypeEnum
	{
		[Description("Scheduling accommodation")]
		Schedulingaccommodation = 1,                               
		[Description("Settings accommodation")]
		Settingsaccommodation = 2,                               
		[Description("Student equipment/technology")]
		Studentequipmenttechnology = 3,                               
		[Description("Test administration accommodation")]
		Testadministrationaccommodation = 4,                               
		[Description("Test material accommodation")]
		Testmaterialaccommodation = 5,                               
		[Description("Test response accommodation")]
		Testresponseaccommodation = 6,                               
		[Description("English language learner accommodation")]
		Englishlanguagelearneraccommodation = 7,                               
		[Description("504 accommodation")]
		_504accommodation = 8,                               
		[Description("Other")]
		Other = 9,                               
	}

	public enum ResponsibilityTypeEnum
	{
		[Description("Accountability")]
		Accountability = 1,                               
		[Description("Attendance")]
		Attendance = 2,                               
		[Description("Funding")]
		Funding = 3,                               
		[Description("Graduation")]
		Graduation = 4,                               
		[Description("Individualized Education Program")]
		IndividualizedEducationProgram = 5,                               
		[Description("Transportation")]
		Transportation = 6,                               
	}

	public enum SexTypeEnum
	{
		[Description("Female")]
		Female = 1,                               
		[Description("Male")]
		Male = 2,                               
	}

	public enum EducationOrganizationIdentificationSystemTypeEnum
	{
		[Description("School")]
		School = 1,                               
		[Description("ACT")]
		ACT = 2,                               
		[Description("LEA")]
		LEA = 3,                               
		[Description("SEA")]
		SEA = 4,                               
		[Description("NCES")]
		NCES = 5,                               
		[Description("Federal")]
		Federal = 6,                               
		[Description("DUNS")]
		DUNS = 7,                               
		[Description("Other Federal")]
		OtherFederal = 8,                               
		[Description("Other")]
		Other = 9,                               
		[Description("Integrated Postsecondary Education Data System")]
		IntegratedPostsecondaryEducationDataSystem = 10,                               
		[Description("U.S. Department of Education's Office of Postsecondary Education ")]
		USDepartmentofEducationsOfficeofPostsecondaryEducation = 11,                               
	}

	public enum DeliveryMethodTypeEnum
	{
		[Description("Individual")]
		Individual = 1,                               
		[Description("Small Group")]
		SmallGroup = 2,                               
		[Description("Whole Class")]
		WholeClass = 3,                               
		[Description("Whole School")]
		WholeSchool = 4,                               
	}

	public enum OldEthnicityTypeEnum
	{
		[Description("American Indian Or Alaskan Native")]
		AmericanIndianOrAlaskanNative = 1,                               
		[Description("Asian Or Pacific Islander")]
		AsianOrPacificIslander = 2,                               
		[Description("Black, Not Of Hispanic Origin")]
		BlackNotOfHispanicOrigin = 3,                               
		[Description("Hispanic")]
		Hispanic = 4,                               
		[Description("White, Not Of Hispanic Origin")]
		WhiteNotOfHispanicOrigin = 5,                               
	}

	public enum LanguageUseTypeEnum
	{
		[Description("Home language")]
		Homelanguage = 1,                               
		[Description("Spoken language")]
		Spokenlanguage = 2,                               
		[Description("Written language")]
		Writtenlanguage = 3,                               
		[Description("Correspondence language")]
		Correspondencelanguage = 4,                               
		[Description("Dominant language")]
		Dominantlanguage = 5,                               
		[Description("Native language")]
		Nativelanguage = 6,                               
		[Description("Other language proficiency")]
		Otherlanguageproficiency = 7,                               
		[Description("Other")]
		Other = 8,                               
	}

	public enum MediumOfInstructionTypeEnum
	{
		[Description("Televised")]
		Televised = 1,                               
		[Description("Telepresence/video conference")]
		Telepresencevideoconference = 2,                               
		[Description("Videotaped/prerecorded video")]
		Videotapedprerecordedvideo = 3,                               
		[Description("Other technology-based instruction")]
		Othertechnology_basedinstruction = 4,                               
		[Description("Technology-based instruction in classroom")]
		Technology_basedinstructioninclassroom = 5,                               
		[Description("Correspondence instruction")]
		Correspondenceinstruction = 6,                               
		[Description("Face-to-face instruction")]
		Face_to_faceinstruction = 7,                               
		[Description("Virtual/On-line Distance learning")]
		VirtualOn_lineDistancelearning = 8,                               
		[Description("Center-based instruction")]
		Center_basedinstruction = 9,                               
		[Description("Independent study")]
		Independentstudy = 10,                               
		[Description("Internship")]
		Internship = 11,                               
		[Description("Other")]
		Other = 12,                               
	}

	public enum TelephoneNumberTypeEnum
	{
		[Description("Home")]
		Home = 1,                               
		[Description("Fax")]
		Fax = 2,                               
		[Description("Mobile")]
		Mobile = 3,                               
		[Description("Unlisted")]
		Unlisted = 4,                               
		[Description("Work")]
		Work = 5,                               
		[Description("Other")]
		Other = 6,                               
		[Description("Emergency 1")]
		Emergency1 = 7,                               
		[Description("Emergency 2")]
		Emergency2 = 8,                               
	}

	public enum DiagnosisTypeEnum
	{
		[Description("Low Attendance")]
		LowAttendance = 1,                               
		[Description("Dropout Risk")]
		DropoutRisk = 2,                               
	}

	public enum AssessmentItemResultTypeEnum
	{
		[Description("Correct")]
		Correct = 1,                               
		[Description("Incorrect")]
		Incorrect = 2,                               
		[Description("Above Standard")]
		AboveStandard = 3,                               
		[Description("Below Standard")]
		BelowStandard = 4,                               
		[Description("Met Standard")]
		MetStandard = 5,                               
	}

	public enum InstitutionTelephoneNumberTypeEnum
	{
		[Description("Main")]
		Main = 1,                               
		[Description("Administrative")]
		Administrative = 2,                               
		[Description("Health Clinic")]
		HealthClinic = 3,                               
		[Description("Attendance")]
		Attendance = 4,                               
		[Description("Other")]
		Other = 5,                               
		[Description("Fax")]
		Fax = 6,                               
		[Description("Food Service")]
		FoodService = 7,                               
	}

	public enum SchoolYearTypeEnum
	{
		[Description("1988-1989")]
		Year1989 = 1989,                               
		[Description("1989-1990")]
		Year1990 = 1990,                               
		[Description("1990-1991")]
		Year1991 = 1991,                               
		[Description("1991-1992")]
		Year1992 = 1992,                               
		[Description("1992-1993")]
		Year1993 = 1993,                               
		[Description("1993-1994")]
		Year1994 = 1994,                               
		[Description("1994-1995")]
		Year1995 = 1995,                               
		[Description("1995-1996")]
		Year1996 = 1996,                               
		[Description("1996-1997")]
		Year1997 = 1997,                               
		[Description("1997-1998")]
		Year1998 = 1998,                               
		[Description("1998-1999")]
		Year1999 = 1999,                               
		[Description("1999-2000")]
		Year2000 = 2000,                               
		[Description("2000-2001")]
		Year2001 = 2001,                               
		[Description("2001-2002")]
		Year2002 = 2002,                               
		[Description("2002-2003")]
		Year2003 = 2003,                               
		[Description("2003-2004")]
		Year2004 = 2004,                               
		[Description("2004-2005")]
		Year2005 = 2005,                               
		[Description("2005-2006")]
		Year2006 = 2006,                               
		[Description("2006-2007")]
		Year2007 = 2007,                               
		[Description("2007-2008")]
		Year2008 = 2008,                               
		[Description("2008-2009")]
		Year2009 = 2009,                               
		[Description("2009-2010")]
		Year2010 = 2010,                               
		[Description("2010-2011")]
		Year2011 = 2011,                               
		[Description("2011-2012")]
		Year2012 = 2012,                               
		[Description("2012-2013")]
		Year2013 = 2013,                               
		[Description("2013-2014")]
		Year2014 = 2014,                               
		[Description("2014-2015")]
		Year2015 = 2015,                               
		[Description("2015-2016")]
		Year2016 = 2016,                               
		[Description("2016-2017")]
		Year2017 = 2017,                               
		[Description("2017-2018")]
		Year2018 = 2018,                               
		[Description("2018-2019")]
		Year2019 = 2019,                               
		[Description("2019-2020")]
		Year2020 = 2020,                               
		[Description("2020-2021")]
		Year2021 = 2021,                               
		[Description("2021-2022")]
		Year2022 = 2022,                               
		[Description("2022-2023")]
		Year2023 = 2023,                               
		[Description("2023-2024")]
		Year2024 = 2024,                               
		[Description("2024-2025")]
		Year2025 = 2025,                               
		[Description("2025-2026")]
		Year2026 = 2026,                               
		[Description("2026-2027")]
		Year2027 = 2027,                               
		[Description("2027-2028")]
		Year2028 = 2028,                               
		[Description("2028-2029")]
		Year2029 = 2029,                               
		[Description("2029-2030")]
		Year2030 = 2030,                               
		[Description("2030-2031")]
		Year2031 = 2031,                               
		[Description("2031-2032")]
		Year2032 = 2032,                               
		[Description("2032-2033")]
		Year2033 = 2033,                               
		[Description("2033-2034")]
		Year2034 = 2034,                               
		[Description("2034-2035")]
		Year2035 = 2035,                               
		[Description("2035-2036")]
		Year2036 = 2036,                               
		[Description("2036-2037")]
		Year2037 = 2037,                               
		[Description("2037-2038")]
		Year2038 = 2038,                               
		[Description("2038-2039")]
		Year2039 = 2039,                               
	}

	public enum PopulationServedTypeEnum
	{
		[Description("Regular Students")]
		RegularStudents = 1,                               
		[Description("Bilingual Students")]
		BilingualStudents = 2,                               
		[Description("Compensatory/Remedial Education Students")]
		CompensatoryRemedialEducationStudents = 3,                               
		[Description("Gifted and Talented Students")]
		GiftedandTalentedStudents = 4,                               
		[Description("Career and Technical Education Students")]
		CareerandTechnicalEducationStudents = 5,                               
		[Description("Special Education Students")]
		SpecialEducationStudents = 6,                               
		[Description("ESL Students")]
		ESLStudents = 7,                               
		[Description("Adult Basic Education Students")]
		AdultBasicEducationStudents = 8,                               
		[Description("Honors Students")]
		HonorsStudents = 9,                               
		[Description("Migrant Students")]
		MigrantStudents = 10,                               
		[Description("Economic Disadvantaged")]
		EconomicDisadvantaged = 11,                               
	}

	public enum StudentIdentificationSystemTypeEnum
	{
		[Description("Canadian SIN")]
		CanadianSIN = 1,                               
		[Description("District")]
		District = 2,                               
		[Description("Family")]
		Family = 3,                               
		[Description("Federal")]
		Federal = 4,                               
		[Description("Local")]
		Local = 5,                               
		[Description("National Migrant")]
		NationalMigrant = 6,                               
		[Description("Other")]
		Other = 7,                               
		[Description("School")]
		School = 8,                               
		[Description("SSN")]
		SSN = 9,                               
		[Description("State")]
		State = 10,                               
		[Description("State Migrant")]
		StateMigrant = 11,                               
	}

	public enum GraduationPlanTypeEnum
	{
		[Description("Career and Technical Education")]
		CareerandTechnicalEducation = 1,                               
		[Description("Distinguished")]
		Distinguished = 2,                               
		[Description("Minimum")]
		Minimum = 3,                               
		[Description("Recommended")]
		Recommended = 4,                               
		[Description("Standard")]
		Standard = 5,                               
	}

	public enum RestraintEventReasonTypeEnum
	{
		[Description("Imminent Serious Physical Harm To Themselves")]
		ImminentSeriousPhysicalHarmToThemselves = 1,                               
		[Description("Imminent Serious Physical Harm To Others")]
		ImminentSeriousPhysicalHarmToOthers = 2,                               
		[Description("Imminent Serious Property Destruction")]
		ImminentSeriousPropertyDestruction = 3,                               
	}

	public enum DiplomaLevelTypeEnum
	{
		[Description("Minimum")]
		Minimum = 1,                               
		[Description("Recommended")]
		Recommended = 2,                               
		[Description("Distinguished")]
		Distinguished = 3,                               
		[Description("Open Enrollment")]
		OpenEnrollment = 4,                               
		[Description("Cum laude")]
		Cumlaude = 5,                               
		[Description("Magna cum laude")]
		Magnacumlaude = 6,                               
		[Description("Summa cum laude")]
		Summacumlaude = 7,                               
	}

	public enum EducationalEnvironmentTypeEnum
	{
		[Description("Classroom")]
		Classroom = 1,                               
		[Description("Homebound")]
		Homebound = 2,                               
		[Description("Hospital class")]
		Hospitalclass = 3,                               
		[Description("In-school suspension")]
		In_schoolsuspension = 4,                               
		[Description("Laboratory")]
		Laboratory = 5,                               
		[Description("Mainstream (Special Education)")]
		Mainstream_SpecialEducation = 6,                               
		[Description("Off-school center")]
		Off_schoolcenter = 7,                               
		[Description("Pull-out class")]
		Pull_outclass = 8,                               
		[Description("Resource room")]
		Resourceroom = 9,                               
		[Description("Single Sex Classroom")]
		SingleSexClassroom = 10,                               
		[Description("Self-contained (Special Education)")]
		Self_contained_SpecialEducation = 11,                               
		[Description("Self-study")]
		Self_study = 12,                               
		[Description("Shop")]
		Shop = 13,                               
	}

	public enum PerformanceBaseConversionTypeEnum
	{
		[Description("Advanced")]
		Advanced = 1,                               
		[Description("Proficient")]
		Proficient = 2,                               
		[Description("Basic")]
		Basic = 3,                               
		[Description("Below Basic")]
		BelowBasic = 4,                               
		[Description("Well Below Basic")]
		WellBelowBasic = 5,                               
		[Description("Pass")]
		Pass = 6,                               
		[Description("Fail")]
		Fail = 7,                               
	}

	public enum CostRateTypeEnum
	{
		[Description("Flat Fee")]
		FlatFee = 1,                               
		[Description("Per Student")]
		PerStudent = 2,                               
	}

	public enum DiplomaTypeEnum
	{
		[Description("Regular diploma")]
		Regulardiploma = 1,                               
		[Description("Endorsed/advanced diploma")]
		Endorsedadvanceddiploma = 2,                               
		[Description("Regents diploma")]
		Regentsdiploma = 3,                               
		[Description("International Baccalaureate")]
		InternationalBaccalaureate = 4,                               
		[Description("Modified diploma")]
		Modifieddiploma = 5,                               
		[Description("Other diploma")]
		Otherdiploma = 6,                               
		[Description("Alternative credential")]
		Alternativecredential = 7,                               
		[Description("Certificate of attendance")]
		Certificateofattendance = 8,                               
		[Description("Certificate of completion")]
		Certificateofcompletion = 9,                               
		[Description("High school equivalency credential, other than GED")]
		HighschoolequivalencycredentialotherthanGED = 10,                               
		[Description("General Educational Development (GED) credential")]
		GeneralEducationalDevelopment_GEDcredential = 11,                               
		[Description("Post graduate certificate (grade 13)")]
		Postgraduatecertificate_grade13 = 12,                               
		[Description("Career and Technical Education certificate")]
		CareerandTechnicalEducationcertificate = 13,                               
		[Description("Other")]
		Other = 14,                               
		[Description("Occupational License")]
		OccupationalLicense = 15,                               
		[Description("Industry-recognized Certification")]
		Industry_recognizedCertification = 16,                               
		[Description("Apprenticeship Certificate")]
		ApprenticeshipCertificate = 17,                               
	}

	public enum PostSecondaryEventCategoryTypeEnum
	{
		[Description("Certification Received")]
		CertificationReceived = 1,                               
		[Description("College Application")]
		CollegeApplication = 2,                               
		[Description("College Acceptance")]
		CollegeAcceptance = 3,                               
		[Description("College Degree Received")]
		CollegeDegreeReceived = 4,                               
		[Description("College Enrollment")]
		CollegeEnrollment = 5,                               
		[Description("College Selection")]
		CollegeSelection = 6,                               
		[Description("FAFSA Application")]
		FAFSAApplication = 7,                               
		[Description("Student Interest")]
		StudentInterest = 8,                               
		[Description("Remedial Enrollment - ELA")]
		RemedialEnrollment_ELA = 9,                               
		[Description("Remedial Enrollment - Math")]
		RemedialEnrollment_Math = 10,                               
		[Description("College Exit Date")]
		CollegeExitDate = 11,                               
	}

	public enum InterventionClassTypeEnum
	{
		[Description("Curriculum")]
		Curriculum = 1,                               
		[Description("Supplement")]
		Supplement = 2,                               
		[Description("Practice")]
		Practice = 3,                               
	}

	public enum RetestIndicatorTypeEnum
	{
		[Description("Primary Administration")]
		PrimaryAdministration = 1,                               
		[Description("1st Retest")]
		_1stRetest = 2,                               
		[Description("2nd Retest")]
		_2ndRetest = 3,                               
		[Description("3nd or more Retest")]
		_3ndormoreRetest = 4,                               
	}

	public enum ResultDatatypeTypeEnum
	{
		[Description("Integer")]
		Integer = 1,                               
		[Description("Decimal")]
		Decimal = 2,                               
		[Description("Percentile")]
		Percentile = 3,                               
		[Description("Range")]
		Range = 4,                               
		[Description("Level")]
		Level = 5,                               
	}

	public enum CountryCodeTypeEnum
	{
		[Description("ANDORRA")]
		ANDORRA = 1,                               
		[Description("UNITED ARAB EMIRATES")]
		UNITEDARABEMIRATES = 2,                               
		[Description("AFGHANISTAN")]
		AFGHANISTAN = 3,                               
		[Description("ANTIGUA AND BARBUDA")]
		ANTIGUAANDBARBUDA = 4,                               
		[Description("ANGUILLA")]
		ANGUILLA = 5,                               
		[Description("ALBANIA")]
		ALBANIA = 6,                               
		[Description("ARMENIA")]
		ARMENIA = 7,                               
		[Description("ANGOLA")]
		ANGOLA = 8,                               
		[Description("ANTARCTICA")]
		ANTARCTICA = 9,                               
		[Description("ARGENTINA")]
		ARGENTINA = 10,                               
		[Description("AMERICAN SAMOA")]
		AMERICANSAMOA = 11,                               
		[Description("AUSTRIA")]
		AUSTRIA = 12,                               
		[Description("AUSTRALIA")]
		AUSTRALIA = 13,                               
		[Description("ARUBA")]
		ARUBA = 14,                               
		[Description("ÅLAND ISLANDS")]
		ÅLANDISLANDS = 15,                               
		[Description("AZERBAIJAN")]
		AZERBAIJAN = 16,                               
		[Description("BOSNIA AND HERZEGOVINA")]
		BOSNIAANDHERZEGOVINA = 17,                               
		[Description("BARBADOS")]
		BARBADOS = 18,                               
		[Description("BANGLADESH")]
		BANGLADESH = 19,                               
		[Description("BELGIUM")]
		BELGIUM = 20,                               
		[Description("BURKINA FASO")]
		BURKINAFASO = 21,                               
		[Description("BULGARIA")]
		BULGARIA = 22,                               
		[Description("BAHRAIN")]
		BAHRAIN = 23,                               
		[Description("BURUNDI")]
		BURUNDI = 24,                               
		[Description("BENIN")]
		BENIN = 25,                               
		[Description("SAINT BARTHÉLEMY")]
		SAINTBARTHÉLEMY = 26,                               
		[Description("BERMUDA")]
		BERMUDA = 27,                               
		[Description("BRUNEI DARUSSALAM")]
		BRUNEIDARUSSALAM = 28,                               
		[Description("BOLIVIA, PLURINATIONAL STATE OF")]
		BOLIVIAPLURINATIONALSTATEOF = 29,                               
		[Description("BONAIRE, SINT EUSTATIUS AND SABA")]
		BONAIRESINTEUSTATIUSANDSABA = 30,                               
		[Description("BRAZIL")]
		BRAZIL = 31,                               
		[Description("BAHAMAS")]
		BAHAMAS = 32,                               
		[Description("BHUTAN")]
		BHUTAN = 33,                               
		[Description("BOUVET ISLAND")]
		BOUVETISLAND = 34,                               
		[Description("BOTSWANA")]
		BOTSWANA = 35,                               
		[Description("BELARUS")]
		BELARUS = 36,                               
		[Description("BELIZE")]
		BELIZE = 37,                               
		[Description("CANADA")]
		CANADA = 38,                               
		[Description("COCOS (KEELING) ISLANDS")]
		COCOS_KEELINGISLANDS = 39,                               
		[Description("CONGO, THE DEMOCRATIC REPUBLIC OF THE")]
		CONGOTHEDEMOCRATICREPUBLICOFTHE = 40,                               
		[Description("CENTRAL AFRICAN REPUBLIC")]
		CENTRALAFRICANREPUBLIC = 41,                               
		[Description("CONGO")]
		CONGO = 42,                               
		[Description("SWITZERLAND")]
		SWITZERLAND = 43,                               
		[Description("CÔTE D'IVOIRE")]
		CÔTEDIVOIRE = 44,                               
		[Description("COOK ISLANDS")]
		COOKISLANDS = 45,                               
		[Description("CHILE")]
		CHILE = 46,                               
		[Description("CAMEROON")]
		CAMEROON = 47,                               
		[Description("CHINA")]
		CHINA = 48,                               
		[Description("COLOMBIA")]
		COLOMBIA = 49,                               
		[Description("COSTA RICA")]
		COSTARICA = 50,                               
		[Description("CUBA")]
		CUBA = 51,                               
		[Description("CAPE VERDE")]
		CAPEVERDE = 52,                               
		[Description("CURAÇAO")]
		CURAÇAO = 53,                               
		[Description("CHRISTMAS ISLAND")]
		CHRISTMASISLAND = 54,                               
		[Description("CYPRUS")]
		CYPRUS = 55,                               
		[Description("CZECH REPUBLIC")]
		CZECHREPUBLIC = 56,                               
		[Description("GERMANY")]
		GERMANY = 57,                               
		[Description("DJIBOUTI")]
		DJIBOUTI = 58,                               
		[Description("DENMARK")]
		DENMARK = 59,                               
		[Description("DOMINICA")]
		DOMINICA = 60,                               
		[Description("DOMINICAN REPUBLIC")]
		DOMINICANREPUBLIC = 61,                               
		[Description("ALGERIA")]
		ALGERIA = 62,                               
		[Description("ECUADOR")]
		ECUADOR = 63,                               
		[Description("ESTONIA")]
		ESTONIA = 64,                               
		[Description("EGYPT")]
		EGYPT = 65,                               
		[Description("WESTERN SAHARA")]
		WESTERNSAHARA = 66,                               
		[Description("ERITREA")]
		ERITREA = 67,                               
		[Description("SPAIN")]
		SPAIN = 68,                               
		[Description("ETHIOPIA")]
		ETHIOPIA = 69,                               
		[Description("FINLAND")]
		FINLAND = 70,                               
		[Description("FIJI")]
		FIJI = 71,                               
		[Description("FALKLAND ISLANDS (MALVINAS)")]
		FALKLANDISLANDS_MALVINAS = 72,                               
		[Description("MICRONESIA, FEDERATED STATES OF")]
		MICRONESIAFEDERATEDSTATESOF = 73,                               
		[Description("FAROE ISLANDS")]
		FAROEISLANDS = 74,                               
		[Description("FRANCE")]
		FRANCE = 75,                               
		[Description("GABON")]
		GABON = 76,                               
		[Description("UNITED KINGDOM")]
		UNITEDKINGDOM = 77,                               
		[Description("GRENADA")]
		GRENADA = 78,                               
		[Description("GEORGIA")]
		GEORGIA = 79,                               
		[Description("FRENCH GUIANA")]
		FRENCHGUIANA = 80,                               
		[Description("GUERNSEY")]
		GUERNSEY = 81,                               
		[Description("GHANA")]
		GHANA = 82,                               
		[Description("GIBRALTAR")]
		GIBRALTAR = 83,                               
		[Description("GREENLAND")]
		GREENLAND = 84,                               
		[Description("GAMBIA")]
		GAMBIA = 85,                               
		[Description("GUINEA")]
		GUINEA = 86,                               
		[Description("GUADELOUPE")]
		GUADELOUPE = 87,                               
		[Description("EQUATORIAL GUINEA")]
		EQUATORIALGUINEA = 88,                               
		[Description("GREECE")]
		GREECE = 89,                               
		[Description("SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS")]
		SOUTHGEORGIAANDTHESOUTHSANDWICHISLANDS = 90,                               
		[Description("GUATEMALA")]
		GUATEMALA = 91,                               
		[Description("GUAM")]
		GUAM = 92,                               
		[Description("GUINEA-BISSAU")]
		GUINEA_BISSAU = 93,                               
		[Description("GUYANA")]
		GUYANA = 94,                               
		[Description("HONG KONG")]
		HONGKONG = 95,                               
		[Description("HEARD ISLAND AND MCDONALD ISLANDS")]
		HEARDISLANDANDMCDONALDISLANDS = 96,                               
		[Description("HONDURAS")]
		HONDURAS = 97,                               
		[Description("CROATIA")]
		CROATIA = 98,                               
		[Description("HAITI")]
		HAITI = 99,                               
		[Description("HUNGARY")]
		HUNGARY = 100,                               
		[Description("INDONESIA")]
		INDONESIA = 101,                               
		[Description("IRELAND")]
		IRELAND = 102,                               
		[Description("ISRAEL")]
		ISRAEL = 103,                               
		[Description("ISLE OF MAN")]
		ISLEOFMAN = 104,                               
		[Description("INDIA")]
		INDIA = 105,                               
		[Description("BRITISH INDIAN OCEAN TERRITORY")]
		BRITISHINDIANOCEANTERRITORY = 106,                               
		[Description("IRAQ")]
		IRAQ = 107,                               
		[Description("IRAN, ISLAMIC REPUBLIC OF")]
		IRANISLAMICREPUBLICOF = 108,                               
		[Description("ICELAND")]
		ICELAND = 109,                               
		[Description("ITALY")]
		ITALY = 110,                               
		[Description("JERSEY")]
		JERSEY = 111,                               
		[Description("JAMAICA")]
		JAMAICA = 112,                               
		[Description("JORDAN")]
		JORDAN = 113,                               
		[Description("JAPAN")]
		JAPAN = 114,                               
		[Description("KENYA")]
		KENYA = 115,                               
		[Description("KYRGYZSTAN")]
		KYRGYZSTAN = 116,                               
		[Description("CAMBODIA")]
		CAMBODIA = 117,                               
		[Description("KIRIBATI")]
		KIRIBATI = 118,                               
		[Description("COMOROS")]
		COMOROS = 119,                               
		[Description("SAINT KITTS AND NEVIS")]
		SAINTKITTSANDNEVIS = 120,                               
		[Description("KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF")]
		KOREADEMOCRATICPEOPLESREPUBLICOF = 121,                               
		[Description("KOREA, REPUBLIC OF")]
		KOREAREPUBLICOF = 122,                               
		[Description("KUWAIT")]
		KUWAIT = 123,                               
		[Description("CAYMAN ISLANDS")]
		CAYMANISLANDS = 124,                               
		[Description("KAZAKHSTAN")]
		KAZAKHSTAN = 125,                               
		[Description("LAO PEOPLE'S DEMOCRATIC REPUBLIC")]
		LAOPEOPLESDEMOCRATICREPUBLIC = 126,                               
		[Description("LEBANON")]
		LEBANON = 127,                               
		[Description("SAINT LUCIA")]
		SAINTLUCIA = 128,                               
		[Description("LIECHTENSTEIN")]
		LIECHTENSTEIN = 129,                               
		[Description("SRI LANKA")]
		SRILANKA = 130,                               
		[Description("LIBERIA")]
		LIBERIA = 131,                               
		[Description("LESOTHO")]
		LESOTHO = 132,                               
		[Description("LITHUANIA")]
		LITHUANIA = 133,                               
		[Description("LUXEMBOURG")]
		LUXEMBOURG = 134,                               
		[Description("LATVIA")]
		LATVIA = 135,                               
		[Description("LIBYAN ARAB JAMAHIRIYA")]
		LIBYANARABJAMAHIRIYA = 136,                               
		[Description("MOROCCO")]
		MOROCCO = 137,                               
		[Description("MONACO")]
		MONACO = 138,                               
		[Description("MOLDOVA, REPUBLIC OF")]
		MOLDOVAREPUBLICOF = 139,                               
		[Description("MONTENEGRO")]
		MONTENEGRO = 140,                               
		[Description("SAINT MARTIN (FRENCH PART)")]
		SAINTMARTIN_FRENCHPART = 141,                               
		[Description("MADAGASCAR")]
		MADAGASCAR = 142,                               
		[Description("MARSHALL ISLANDS")]
		MARSHALLISLANDS = 143,                               
		[Description("MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF")]
		MACEDONIATHEFORMERYUGOSLAVREPUBLICOF = 144,                               
		[Description("MALI")]
		MALI = 145,                               
		[Description("MYANMAR")]
		MYANMAR = 146,                               
		[Description("MONGOLIA")]
		MONGOLIA = 147,                               
		[Description("MACAO")]
		MACAO = 148,                               
		[Description("NORTHERN MARIANA ISLANDS")]
		NORTHERNMARIANAISLANDS = 149,                               
		[Description("MARTINIQUE")]
		MARTINIQUE = 150,                               
		[Description("MAURITANIA")]
		MAURITANIA = 151,                               
		[Description("MONTSERRAT")]
		MONTSERRAT = 152,                               
		[Description("MALTA")]
		MALTA = 153,                               
		[Description("MAURITIUS")]
		MAURITIUS = 154,                               
		[Description("MALDIVES")]
		MALDIVES = 155,                               
		[Description("MALAWI")]
		MALAWI = 156,                               
		[Description("MEXICO")]
		MEXICO = 157,                               
		[Description("MALAYSIA")]
		MALAYSIA = 158,                               
		[Description("MOZAMBIQUE")]
		MOZAMBIQUE = 159,                               
		[Description("NAMIBIA")]
		NAMIBIA = 160,                               
		[Description("NEW CALEDONIA")]
		NEWCALEDONIA = 161,                               
		[Description("NIGER")]
		NIGER = 162,                               
		[Description("NORFOLK ISLAND")]
		NORFOLKISLAND = 163,                               
		[Description("NIGERIA")]
		NIGERIA = 164,                               
		[Description("NICARAGUA")]
		NICARAGUA = 165,                               
		[Description("NETHERLANDS")]
		NETHERLANDS = 166,                               
		[Description("NORWAY")]
		NORWAY = 167,                               
		[Description("NEPAL")]
		NEPAL = 168,                               
		[Description("NAURU")]
		NAURU = 169,                               
		[Description("NIUE")]
		NIUE = 170,                               
		[Description("NEW ZEALAND")]
		NEWZEALAND = 171,                               
		[Description("OMAN")]
		OMAN = 172,                               
		[Description("PANAMA")]
		PANAMA = 173,                               
		[Description("PERU")]
		PERU = 174,                               
		[Description("FRENCH POLYNESIA")]
		FRENCHPOLYNESIA = 175,                               
		[Description("PAPUA NEW GUINEA")]
		PAPUANEWGUINEA = 176,                               
		[Description("PHILIPPINES")]
		PHILIPPINES = 177,                               
		[Description("PAKISTAN")]
		PAKISTAN = 178,                               
		[Description("POLAND")]
		POLAND = 179,                               
		[Description("SAINT PIERRE AND MIQUELON")]
		SAINTPIERREANDMIQUELON = 180,                               
		[Description("PITCAIRN")]
		PITCAIRN = 181,                               
		[Description("PUERTO RICO")]
		PUERTORICO = 182,                               
		[Description("PALESTINIAN TERRITORY, OCCUPIED")]
		PALESTINIANTERRITORYOCCUPIED = 183,                               
		[Description("PORTUGAL")]
		PORTUGAL = 184,                               
		[Description("PALAU")]
		PALAU = 185,                               
		[Description("PARAGUAY")]
		PARAGUAY = 186,                               
		[Description("QATAR")]
		QATAR = 187,                               
		[Description("RÉUNION")]
		RÉUNION = 188,                               
		[Description("ROMANIA")]
		ROMANIA = 189,                               
		[Description("SERBIA")]
		SERBIA = 190,                               
		[Description("RUSSIAN FEDERATION")]
		RUSSIANFEDERATION = 191,                               
		[Description("RWANDA")]
		RWANDA = 192,                               
		[Description("SAUDI ARABIA")]
		SAUDIARABIA = 193,                               
		[Description("SOLOMON ISLANDS")]
		SOLOMONISLANDS = 194,                               
		[Description("SEYCHELLES")]
		SEYCHELLES = 195,                               
		[Description("SUDAN")]
		SUDAN = 196,                               
		[Description("SWEDEN")]
		SWEDEN = 197,                               
		[Description("SINGAPORE")]
		SINGAPORE = 198,                               
		[Description("SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA")]
		SAINTHELENAASCENSIONANDTRISTANDACUNHA = 199,                               
		[Description("SLOVENIA")]
		SLOVENIA = 200,                               
		[Description("SVALBARD AND JAN MAYEN")]
		SVALBARDANDJANMAYEN = 201,                               
		[Description("SLOVAKIA")]
		SLOVAKIA = 202,                               
		[Description("SIERRA LEONE")]
		SIERRALEONE = 203,                               
		[Description("SAN MARINO")]
		SANMARINO = 204,                               
		[Description("SENEGAL")]
		SENEGAL = 205,                               
		[Description("SOMALIA")]
		SOMALIA = 206,                               
		[Description("SURINAME")]
		SURINAME = 207,                               
		[Description("SOUTH SUDAN")]
		SOUTHSUDAN = 208,                               
		[Description("SAO TOME AND PRINCIPE")]
		SAOTOMEANDPRINCIPE = 209,                               
		[Description("EL SALVADOR")]
		ELSALVADOR = 210,                               
		[Description("SINT MAARTEN (DUTCH PART)")]
		SINTMAARTEN_DUTCHPART = 211,                               
		[Description("SYRIAN ARAB REPUBLIC")]
		SYRIANARABREPUBLIC = 212,                               
		[Description("SWAZILAND")]
		SWAZILAND = 213,                               
		[Description("TURKS AND CAICOS ISLANDS")]
		TURKSANDCAICOSISLANDS = 214,                               
		[Description("CHAD")]
		CHAD = 215,                               
		[Description("FRENCH SOUTHERN TERRITORIES")]
		FRENCHSOUTHERNTERRITORIES = 216,                               
		[Description("TOGO")]
		TOGO = 217,                               
		[Description("THAILAND")]
		THAILAND = 218,                               
		[Description("TAJIKISTAN")]
		TAJIKISTAN = 219,                               
		[Description("TOKELAU")]
		TOKELAU = 220,                               
		[Description("TIMOR-LESTE")]
		TIMOR_LESTE = 221,                               
		[Description("TURKMENISTAN")]
		TURKMENISTAN = 222,                               
		[Description("TUNISIA")]
		TUNISIA = 223,                               
		[Description("TONGA")]
		TONGA = 224,                               
		[Description("TURKEY")]
		TURKEY = 225,                               
		[Description("TRINIDAD AND TOBAGO")]
		TRINIDADANDTOBAGO = 226,                               
		[Description("TUVALU")]
		TUVALU = 227,                               
		[Description("TAIWAN, PROVINCE OF CHINA")]
		TAIWANPROVINCEOFCHINA = 228,                               
		[Description("TANZANIA, UNITED REPUBLIC OF")]
		TANZANIAUNITEDREPUBLICOF = 229,                               
		[Description("UKRAINE")]
		UKRAINE = 230,                               
		[Description("UGANDA")]
		UGANDA = 231,                               
		[Description("UNITED STATES MINOR OUTLYING ISLANDS")]
		UNITEDSTATESMINOROUTLYINGISLANDS = 232,                               
		[Description("UNITED STATES")]
		UNITEDSTATES = 233,                               
		[Description("URUGUAY")]
		URUGUAY = 234,                               
		[Description("UZBEKISTAN")]
		UZBEKISTAN = 235,                               
		[Description("HOLY SEE (VATICAN CITY STATE)")]
		HOLYSEE_VATICANCITYSTATE = 236,                               
		[Description("SAINT VINCENT AND THE GRENADINES")]
		SAINTVINCENTANDTHEGRENADINES = 237,                               
		[Description("VENEZUELA, BOLIVARIAN REPUBLIC OF")]
		VENEZUELABOLIVARIANREPUBLICOF = 238,                               
		[Description("VIRGIN ISLANDS, BRITISH")]
		VIRGINISLANDSBRITISH = 239,                               
		[Description("VIRGIN ISLANDS, U.S.")]
		VIRGINISLANDSUS = 240,                               
		[Description("VIET NAM")]
		VIETNAM = 241,                               
		[Description("VANUATU")]
		VANUATU = 242,                               
		[Description("WALLIS AND FUTUNA")]
		WALLISANDFUTUNA = 243,                               
		[Description("SAMOA")]
		SAMOA = 244,                               
		[Description("YEMEN")]
		YEMEN = 245,                               
		[Description("MAYOTTE")]
		MAYOTTE = 246,                               
		[Description("SOUTH AFRICA")]
		SOUTHAFRICA = 247,                               
		[Description("ZAMBIA")]
		ZAMBIA = 248,                               
		[Description("ZIMBABWE")]
		ZIMBABWE = 249,                               
	}

	public enum DisabilityCategoryTypeEnum
	{
		[Description("Individuals with Disabilities Education Act")]
		IndividualswithDisabilitiesEducationAct = 1,                               
		[Description("Section 504")]
		Section504 = 2,                               
		[Description("Other")]
		Other = 3,                               
	}

	public enum SchoolCategoryTypeEnum
	{
		[Description("Elementary/Secondary School")]
		ElementarySecondarySchool = 1,                               
		[Description("High School")]
		HighSchool = 2,                               
		[Description("Middle School")]
		MiddleSchool = 3,                               
		[Description("Junior High School")]
		JuniorHighSchool = 4,                               
		[Description("Elementary School")]
		ElementarySchool = 5,                               
		[Description("Ungraded")]
		Ungraded = 6,                               
		[Description("SecondarySchool")]
		SecondarySchool = 7,                               
		[Description("Adult School")]
		AdultSchool = 8,                               
		[Description("Infant/toddler School")]
		InfanttoddlerSchool = 9,                               
		[Description("Preschool/early childhood")]
		Preschoolearlychildhood = 10,                               
		[Description("Primary School")]
		PrimarySchool = 11,                               
		[Description("Intermediate School")]
		IntermediateSchool = 12,                               
		[Description("All Levels")]
		AllLevels = 13,                               
	}

	public enum AssessmentReportingMethodTypeEnum
	{
		[Description("Achievement/proficiency level")]
		Achievementproficiencylevel = 1,                               
		[Description("ACT score")]
		ACTscore = 2,                               
		[Description("Adaptive scale score")]
		Adaptivescalescore = 3,                               
		[Description("Age score")]
		Agescore = 4,                               
		[Description("C-scaled scores")]
		C_scaledscores = 5,                               
		[Description("College Board examination scores")]
		CollegeBoardexaminationscores = 6,                               
		[Description("Composite Score")]
		CompositeScore = 7,                               
		[Description("Composite Rating")]
		CompositeRating = 8,                               
		[Description("Composition Score")]
		CompositionScore = 9,                               
		[Description("Grade equivalent or grade-level indicator")]
		Gradeequivalentorgrade_levelindicator = 11,                               
		[Description("Graduation score")]
		Graduationscore = 12,                               
		[Description("Growth/value-added/indexing")]
		Growthvalue_addedindexing = 13,                               
		[Description("International Baccalaureate score")]
		InternationalBaccalaureatescore = 14,                               
		[Description("Letter grade/mark")]
		Lettergrademark = 15,                               
		[Description("Mastery level")]
		Masterylevel = 16,                               
		[Description("Normal curve equivalent")]
		Normalcurveequivalent = 17,                               
		[Description("Normalized standard score")]
		Normalizedstandardscore = 18,                               
		[Description("Number score")]
		Numberscore = 19,                               
		[Description("Pass-fail")]
		Pass_fail = 20,                               
		[Description("Percentile")]
		Percentile = 21,                               
		[Description("Percentile rank")]
		Percentilerank = 22,                               
		[Description("Proficiency level")]
		Proficiencylevel = 23,                               
		[Description("Promotion score")]
		Promotionscore = 24,                               
		[Description("Ranking")]
		Ranking = 25,                               
		[Description("Ratio IQ's")]
		RatioIQs = 26,                               
		[Description("Raw score")]
		Rawscore = 27,                               
		[Description("Scale score")]
		Scalescore = 28,                               
		[Description("Standard age score")]
		Standardagescore = 29,                               
		[Description("Standard error measurement")]
		Standarderrormeasurement = 30,                               
		[Description("Stanine score")]
		Staninescore = 31,                               
		[Description("Sten score")]
		Stenscore = 32,                               
		[Description("Theta")]
		Theta = 33,                               
		[Description("T-score")]
		T_score = 34,                               
		[Description("Vertical score")]
		Verticalscore = 35,                               
		[Description("Workplace readiness score")]
		Workplacereadinessscore = 36,                               
		[Description("Z-score")]
		Z_score = 37,                               
		[Description("Other")]
		Other = 38,                               
		[Description("Not applicable")]
		Notapplicable = 39,                               
		[Description("Quantile Measure")]
		QuantileMeasure = 40,                               
		[Description("Lexile Measure")]
		LexileMeasure = 41,                               
		[Description("Vertical Scale Score")]
		VerticalScaleScore = 42,                               
		[Description("National College-Bound Percentile")]
		NationalCollege_BoundPercentile = 43,                               
		[Description("State College-Bound Percentile")]
		StateCollege_BoundPercentile = 44,                               
		[Description("RIT scale score")]
		RITscalescore = 45,                               
	}

	public enum DisabilityTypeEnum
	{
		[Description("Autism Spectrum Disorders")]
		AutismSpectrumDisorders = 1,                               
		[Description("Deaf-Blindness")]
		Deaf_Blindness = 2,                               
		[Description("Hearing Impairment, including Deafness")]
		HearingImpairmentincludingDeafness = 3,                               
		[Description("Intellectual Disability")]
		IntellectualDisability = 4,                               
		[Description("Infant/Toddler with a Disability")]
		InfantToddlerwithaDisability = 5,                               
		[Description("Medical condition")]
		Medicalcondition = 6,                               
		[Description("Mental impairment")]
		Mentalimpairment = 7,                               
		[Description("Motor impairment")]
		Motorimpairment = 8,                               
		[Description("Multiple Disabilities")]
		MultipleDisabilities = 9,                               
		[Description("Orthopedic Impairment")]
		OrthopedicImpairment = 10,                               
		[Description("Other")]
		Other = 11,                               
		[Description("Other Health Impairment")]
		OtherHealthImpairment = 12,                               
		[Description("Physical Disability")]
		PhysicalDisability = 13,                               
		[Description("Preschooler with a Disability")]
		PreschoolerwithaDisability = 14,                               
		[Description("Sensory impairment")]
		Sensoryimpairment = 15,                               
		[Description("Serious Emotional Disability")]
		SeriousEmotionalDisability = 16,                               
		[Description("Speech or Language Impairment")]
		SpeechorLanguageImpairment = 17,                               
		[Description("Specific Learning Disability")]
		SpecificLearningDisability = 18,                               
		[Description("Traumatic Brain Injury")]
		TraumaticBrainInjury = 19,                               
		[Description("Visual Impairment, including Blindness")]
		VisualImpairmentincludingBlindness = 20,                               
	}

	public enum PostSecondaryInstitutionLevelTypeEnum
	{
		[Description("Four or more years")]
		Fourormoreyears = 1,                               
		[Description("At least 2 but less than 4 years")]
		Atleast2butlessthan4years = 2,                               
		[Description("Less than 2 years (below associate)")]
		Lessthan2years_belowassociate = 3,                               
	}

	public enum LeaveEventCategoryTypeEnum
	{
		[Description("Vacation")]
		Vacation = 1,                               
		[Description("Jury duty")]
		Juryduty = 2,                               
		[Description("Professional development")]
		Professionaldevelopment = 3,                               
		[Description("Flex time")]
		Flextime = 4,                               
		[Description("Work compensation")]
		Workcompensation = 5,                               
		[Description("Administrative")]
		Administrative = 6,                               
		[Description("Annual leave")]
		Annualleave = 7,                               
		[Description("Bereavement")]
		Bereavement = 8,                               
		[Description("Compensatory leave time")]
		Compensatoryleavetime = 9,                               
		[Description("Family and medical leave")]
		Familyandmedicalleave = 10,                               
		[Description("Government-requested")]
		Government_requested = 11,                               
		[Description("Military leave")]
		Militaryleave = 12,                               
		[Description("Personal")]
		Personal = 13,                               
		[Description("Release time")]
		Releasetime = 14,                               
		[Description("Sabbatical leave")]
		Sabbaticalleave = 15,                               
		[Description("Sick leave")]
		Sickleave = 16,                               
		[Description("Suspension")]
		Suspension = 17,                               
		[Description("Other")]
		Other = 18,                               
	}

	public enum VisaTypeEnum
	{
		[Description("F1 - Foreign Student Visa")]
		F1_ForeignStudentVisa = 1,                               
		[Description("M1 - Foreign Student pursuing vocational or non-academic studies Visa")]
		M1_ForeignStudentpursuingvocationalornon_academicstudiesVisa = 2,                               
		[Description("H1 - Employment Visa")]
		H1_EmploymentVisa = 3,                               
		[Description("B1 - Business Visa")]
		B1_BusinessVisa = 4,                               
		[Description("B2 - Tourist Visa")]
		B2_TouristVisa = 5,                               
		[Description("J1 - Exchange Scholar Visa")]
		J1_ExchangeScholarVisa = 6,                               
		[Description("Other Visa")]
		OtherVisa = 7,                               
	}

	public enum CourseAttemptResultTypeEnum
	{
		[Description("Pass")]
		Pass = 1,                               
		[Description("Fail")]
		Fail = 2,                               
		[Description("Incomplete")]
		Incomplete = 3,                               
		[Description("Withdrawn")]
		Withdrawn = 4,                               
	}

	public enum AttendanceEventCategoryTypeEnum
	{
		[Description("In Attendance")]
		InAttendance = 1,                               
		[Description("Excused Absence")]
		ExcusedAbsence = 2,                               
		[Description("Unexcused Absence")]
		UnexcusedAbsence = 3,                               
		[Description("Tardy")]
		Tardy = 4,                               
		[Description("Early departure")]
		Earlydeparture = 5,                               
	}

	public enum GunFreeSchoolsActReportingStatusTypeEnum
	{
		[Description("Yes, with reporting of one or more students for an offense")]
		Yeswithreportingofoneormorestudentsforanoffense = 1,                               
		[Description("Yes, with no reported offenses")]
		Yeswithnoreportedoffenses = 2,                               
		[Description("No")]
		No = 3,                               
		[Description("Not applicable")]
		Notapplicable = 4,                               
	}

	public enum ProgramSponsorTypeEnum
	{
		[Description("Business")]
		Business = 1,                               
		[Description("Federal government")]
		Federalgovernment = 2,                               
		[Description("State Education Agency")]
		StateEducationAgency = 3,                               
		[Description("Education Service Center")]
		EducationServiceCenter = 4,                               
		[Description("Local Education Agency")]
		LocalEducationAgency = 5,                               
		[Description("School")]
		School = 6,                               
		[Description("Private organization")]
		Privateorganization = 7,                               
		[Description("Non-profit organization")]
		Non_profitorganization = 8,                               
		[Description("Postsecondary institution")]
		Postsecondaryinstitution = 9,                               
		[Description("Religious organization")]
		Religiousorganization = 10,                               
		[Description("Education organization network")]
		Educationorganizationnetwork = 11,                               
		[Description("Other")]
		Other = 12,                               
	}

	public enum NetworkPurposeTypeEnum
	{
		[Description("Shared Services")]
		SharedServices = 1,                               
		[Description("Collective Procurement")]
		CollectiveProcurement = 2,                               
	}

	public enum CourseCodeSystemTypeEnum
	{
		[Description("CSSC course code")]
		CSSCcoursecode = 1,                               
		[Description("Intermediate agency course code")]
		Intermediateagencycoursecode = 2,                               
		[Description("LEA course code")]
		LEAcoursecode = 3,                               
		[Description("NCES Pilot SNCCS course code")]
		NCESPilotSNCCScoursecode = 4,                               
		[Description("Other")]
		Other = 5,                               
		[Description("SCED course code")]
		SCEDcoursecode = 6,                               
		[Description("School course code")]
		Schoolcoursecode = 7,                               
		[Description("State course code")]
		Statecoursecode = 8,                               
		[Description("University course code")]
		Universitycoursecode = 9,                               
	}

	public enum IdentificationDocumentUseTypeEnum
	{
		[Description("Personal Information Verification")]
		PersonalInformationVerification = 1,                               
		[Description("US Citizenship Identification")]
		USCitizenshipIdentification = 2,                               
		[Description("Foreign Citizenship Identification")]
		ForeignCitizenshipIdentification = 3,                               
	}

	public enum BehaviorTypeEnum
	{
		[Description("State Offense")]
		StateOffense = 1,                               
		[Description("School Violation")]
		SchoolViolation = 2,                               
		[Description("Other")]
		Other = 3,                               
		[Description("School Code of Conduct")]
		SchoolCodeofConduct = 4,                               
	}

	public enum ProgramTypeEnum
	{
		[Description("Bilingual")]
		Bilingual = 1,                               
		[Description("Bilingual Summer")]
		BilingualSummer = 2,                               
		[Description("Career and Technical Education")]
		CareerandTechnicalEducation = 3,                               
		[Description("English as a Second Language (ESL)")]
		EnglishasaSecondLanguage_ESL = 4,                               
		[Description("Gifted and Talented")]
		GiftedandTalented = 5,                               
		[Description("Special Education")]
		SpecialEducation = 6,                               
		[Description("Title I Part A")]
		TitleIPartA = 7,                               
		[Description("Adult/Continuing Education")]
		AdultContinuingEducation = 9,                               
		[Description("Alternative Education")]
		AlternativeEducation = 10,                               
		[Description("Athletics")]
		Athletics = 11,                               
		[Description("Cocurricular Programs")]
		CocurricularPrograms = 12,                               
		[Description("College Preparatory")]
		CollegePreparatory = 13,                               
		[Description("Community Service Program")]
		CommunityServiceProgram = 14,                               
		[Description("Community/Junior College Education Program")]
		CommunityJuniorCollegeEducationProgram = 15,                               
		[Description("Compensatory Services for Disadvantaged Students")]
		CompensatoryServicesforDisadvantagedStudents = 16,                               
		[Description("Counseling Services")]
		CounselingServices = 17,                               
		[Description("Even Start")]
		EvenStart = 18,                               
		[Description("Extended Day/Child Care Services")]
		ExtendedDayChildCareServices = 19,                               
		[Description("Head Start")]
		HeadStart = 20,                               
		[Description("Health Services Program")]
		HealthServicesProgram = 21,                               
		[Description("High School Equivalency Program (HSEP)")]
		HighSchoolEquivalencyProgram_HSEP = 22,                               
		[Description("IDEA")]
		IDEA = 23,                               
		[Description("Immigrant Education")]
		ImmigrantEducation = 24,                               
		[Description("Indian Education")]
		IndianEducation = 25,                               
		[Description("International Baccalaureate")]
		InternationalBaccalaureate = 26,                               
		[Description("Library/Media Services Program")]
		LibraryMediaServicesProgram = 27,                               
		[Description("Magnet/Special Program Emphasis")]
		MagnetSpecialProgramEmphasis = 28,                               
		[Description("Migrant Education")]
		MigrantEducation = 29,                               
		[Description("Neglected and Delinquent Program")]
		NeglectedandDelinquentProgram = 30,                               
		[Description("Optional Flexible School Day Program (OFSDP)")]
		OptionalFlexibleSchoolDayProgram_OFSDP = 31,                               
		[Description("Other")]
		Other = 32,                               
		[Description("Regular Education")]
		RegularEducation = 33,                               
		[Description("Remedial Education")]
		RemedialEducation = 34,                               
		[Description("Service Learning")]
		ServiceLearning = 35,                               
		[Description("Student Retention/Dropout Prevention")]
		StudentRetentionDropoutPrevention = 36,                               
		[Description("Substance Abuse Education/Prevention")]
		SubstanceAbuseEducationPrevention = 37,                               
		[Description("Teacher Professional Development/Mentoring")]
		TeacherProfessionalDevelopmentMentoring = 38,                               
		[Description("Technical Preparatory")]
		TechnicalPreparatory = 39,                               
		[Description("Vocational Education")]
		VocationalEducation = 40,                               
		[Description("District-Funded GED")]
		District_FundedGED = 41,                               
		[Description("Expelled Education")]
		ExpelledEducation = 42,                               
		[Description("Independent Study")]
		IndependentStudy = 43,                               
		[Description("Section 504 Placement")]
		Section504Placement = 44,                               
		[Description("Early Head Start")]
		EarlyHeadStart = 45,                               
		[Description("Early Intervention Services Part C")]
		EarlyInterventionServicesPartC = 46,                               
		[Description("Fee For Service")]
		FeeForService = 47,                               
		[Description("Home Visiting")]
		HomeVisiting = 48,                               
		[Description("Preschool Special Education")]
		PreschoolSpecialEducation = 49,                               
		[Description("Public Preschool")]
		PublicPreschool = 50,                               
		[Description("Kindergarten - Full Day")]
		Kindergarten_FullDay = 51,                               
		[Description("Kindergarten - Half Day")]
		Kindergarten_HalfDay = 52,                               
		[Description("Kindergarten - Extended Day")]
		Kindergarten_ExtendedDay = 53,                               
		[Description("Prekindergarten - Full Day")]
		Prekindergarten_FullDay = 54,                               
		[Description("Prekindergarten - Half Day")]
		Prekindergarten_HalfDay = 55,                               
		[Description("Prekindergarten - Extended Day")]
		Prekindergarten_ExtendedDay = 56,                               
		[Description("Title I Part D Subpart 1")]
		TitleIPartDSubpart1 = 57,                               
		[Description("Title I Part D Subpart 2")]
		TitleIPartDSubpart2 = 58,                               
	}

	public enum AddressTypeEnum
	{
		[Description("Home")]
		Home = 1,                               
		[Description("Physical")]
		Physical = 2,                               
		[Description("Mailing")]
		Mailing = 3,                               
		[Description("Other")]
		Other = 4,                               
		[Description("Work")]
		Work = 5,                               
		[Description("Billing")]
		Billing = 6,                               
		[Description("Temporary")]
		Temporary = 7,                               
		[Description("Father Address")]
		FatherAddress = 8,                               
		[Description("Guardian Address")]
		GuardianAddress = 9,                               
		[Description("Mother Address")]
		MotherAddress = 10,                               
		[Description("Shipping")]
		Shipping = 11,                               
		[Description("Shelters, Transitional housing, Awaiting Foster Care")]
		SheltersTransitionalhousingAwaitingFosterCare = 12,                               
		[Description("Doubled - up (i.e., living with another family)")]
		Doubled_up_ielivingwithanotherfamily = 13,                               
		[Description("Unsheltered (e.g. cars, parks, campgrounds, temporary trailers including FEMA trailers, or abandoned buildings)")]
		Unsheltered_egcarsparkscampgroundstemporarytrailersincludingFEMAtrailersorabandonedbuildings = 14,                               
		[Description("Hotels/Motels")]
		HotelsMotels = 15,                               
	}

	public enum SectionCharacteristicTypeEnum
	{
		[Description("Attendance Tracked")]
		AttendanceTracked = 1,                               
		[Description("Graded Credit Available")]
		GradedCreditAvailable = 2,                               
	}

	public enum ProgramCharacteristicTypeEnum
	{
		[Description("A McKinney-Vento Program for Homlessness")]
		AMcKinney_VentoProgramforHomlessness = 1,                               
	}

	public enum SchoolChoiceImplementStatusTypeEnum
	{
		[Description("Implemented at all grades")]
		Implementedatallgrades = 1,                               
		[Description("Implemented at some but not all grade levels")]
		Implementedatsomebutnotallgradelevels = 2,                               
		[Description("Unable to implement at any grades levels")]
		Unabletoimplementatanygradeslevels = 3,                               
		[Description("Not required to implement public school choice")]
		Notrequiredtoimplementpublicschoolchoice = 4,                               
	}

	public enum DisciplineTypeEnum
	{
		[Description("Removal from Classroom")]
		RemovalfromClassroom = 1,                               
		[Description("In School Suspension")]
		InSchoolSuspension = 2,                               
		[Description("Out of School Suspension")]
		OutofSchoolSuspension = 3,                               
		[Description("Expulsion")]
		Expulsion = 4,                               
		[Description("Community Service")]
		CommunityService = 5,                               
		[Description("Other")]
		Other = 6,                               
		[Description("Expulsion with Services")]
		ExpulsionwithServices = 7,                               
	}

	public enum AdministrationEnvironmentTypeEnum
	{
		[Description("Classroom")]
		Classroom = 1,                               
		[Description("School")]
		School = 2,                               
		[Description("Testing Center")]
		TestingCenter = 3,                               
	}

	public enum AdministrativeFundingControlTypeEnum
	{
		[Description("Public School")]
		PublicSchool = 1,                               
		[Description("Private School")]
		PrivateSchool = 2,                               
		[Description("Other")]
		Other = 3,                               
	}

	public enum EducationPlanTypeEnum
	{
		[Description("504 Plan")]
		_504Plan = 1,                               
		[Description("Career Pathways")]
		CareerPathways = 2,                               
		[Description("Career Suggestions")]
		CareerSuggestions = 3,                               
		[Description("Completion and Reach Age 22")]
		CompletionandReachAge22 = 4,                               
		[Description("Full Time Employment")]
		FullTimeEmployment = 5,                               
		[Description("Employability Skills")]
		EmployabilitySkills = 6,                               
		[Description("High School Education Plan")]
		HighSchoolEducationPlan = 7,                               
		[Description("IDEA IEP")]
		IDEAIEP = 8,                               
		[Description("Outside Service Access")]
		OutsideServiceAccess = 9,                               
		[Description("Personal Graduation Plan")]
		PersonalGraduationPlan = 10,                               
		[Description("Student Success Plan")]
		StudentSuccessPlan = 11,                               
	}

	public enum SeparationReasonTypeEnum
	{
		[Description("Employment elsewhere")]
		Employmentelsewhere = 1,                               
		[Description("Retirement")]
		Retirement = 2,                               
		[Description("Family/personal relocation")]
		Familypersonalrelocation = 3,                               
		[Description("Change of assignment")]
		Changeofassignment = 4,                               
		[Description("Formal study or research")]
		Formalstudyorresearch = 5,                               
		[Description("Illness/disability/death")]
		Illnessdisabilitydeath = 6,                               
		[Description("Layoff")]
		Layoff = 7,                               
		[Description("Discharge")]
		Discharge = 8,                               
		[Description("Personal reason")]
		Personalreason = 9,                               
		[Description("Unknown")]
		Unknown = 10,                               
		[Description("Other")]
		Other = 11,                               
	}

	public enum ReporterDescriptionTypeEnum
	{
		[Description("Parent/guardian")]
		Parentguardian = 1,                               
		[Description("Staff")]
		Staff = 2,                               
		[Description("Student")]
		Student = 3,                               
		[Description("Non-school personnel")]
		Non_schoolpersonnel = 4,                               
		[Description("Law enforcement officer")]
		Lawenforcementofficer = 5,                               
		[Description("Other")]
		Other = 6,                               
	}

	public enum ElectronicMailTypeEnum
	{
		[Description("Home/Personal")]
		HomePersonal = 1,                               
		[Description("Organization")]
		Organization = 2,                               
		[Description("Other")]
		Other = 3,                               
		[Description("Work")]
		Work = 4,                               
	}

	public enum MeetingDayTypeEnum
	{
		[Description("Monday")]
		Monday = 1,                               
		[Description("Tuesday")]
		Tuesday = 2,                               
		[Description("Wednesday")]
		Wednesday = 3,                               
		[Description("Thursday")]
		Thursday = 4,                               
		[Description("Friday")]
		Friday = 5,                               
		[Description("Saturday")]
		Saturday = 6,                               
		[Description("Sunday")]
		Sunday = 7,                               
	}

	public enum GradeLevelTypeEnum
	{
		[Description("Early Education")]
		EarlyEducation = -3,                               
		[Description("Infant/toddler")]
		Infanttoddler = -2,                               
		[Description("Preschool/Prekindergarten")]
		PreschoolPrekindergarten = -1,                               
		[Description("Kindergarten")]
		Kindergarten = 0,                               
		[Description("1st Grade")]
		_1stGrade = 1,                               
		[Description("2nd Grade")]
		_2ndGrade = 2,                               
		[Description("3rd Grade")]
		_3rdGrade = 3,                               
		[Description("4th Grade")]
		_4thGrade = 4,                               
		[Description("5th Grade")]
		_5thGrade = 5,                               
		[Description("6th Grade")]
		_6thGrade = 6,                               
		[Description("7th Grade")]
		_7thGrade = 7,                               
		[Description("8th Grade")]
		_8thGrade = 8,                               
		[Description("9th Grade")]
		_9thGrade = 9,                               
		[Description("10th Grade")]
		_10thGrade = 10,                               
		[Description("11th Grade")]
		_11thGrade = 11,                               
		[Description("12th Grade")]
		_12thGrade = 12,                               
		[Description("Postsecondary")]
		Postsecondary = 13,                               
		[Description("Ungraded")]
		Ungraded = 14,                               
		[Description("Other")]
		Other = 15,                               
		[Description("Grade 13")]
		Grade13 = 16,                               
		[Description("Adult Education")]
		AdultEducation = 17,                               
	}

	public enum CalendarEventTypeEnum
	{
		[Description("Instructional day")]
		Instructionalday = 1,                               
		[Description("Teacher only day")]
		Teacheronlyday = 2,                               
		[Description("Holiday")]
		Holiday = 3,                               
		[Description("Make-up day")]
		Make_upday = 4,                               
		[Description("Weather day")]
		Weatherday = 5,                               
		[Description("Student late arrival/early dismissal")]
		Studentlatearrivalearlydismissal = 6,                               
		[Description("Emergency day")]
		Emergencyday = 7,                               
		[Description("Strike")]
		Strike = 8,                               
		[Description("Other")]
		Other = 9,                               
	}

	public enum SeparationTypeEnum
	{
		[Description("Voluntary separation")]
		Voluntaryseparation = 1,                               
		[Description("Involuntary separation")]
		Involuntaryseparation = 2,                               
		[Description("Mutual agreement")]
		Mutualagreement = 3,                               
		[Description("Other")]
		Other = 4,                               
	}

	public enum EmploymentStatusTypeEnum
	{
		[Description("Probationary")]
		Probationary = 1,                               
		[Description("Contractual")]
		Contractual = 2,                               
		[Description("Substitute/temporary")]
		Substitutetemporary = 3,                               
		[Description("Tenured or permanent")]
		Tenuredorpermanent = 4,                               
		[Description("Volunteer/no contract")]
		Volunteernocontract = 5,                               
		[Description("Employed or affiliated with outside organization")]
		Employedoraffiliatedwithoutsideorganization = 6,                               
		[Description("Non-contractual")]
		Non_contractual = 7,                               
		[Description("Employed part-time")]
		Employedpart_time = 8,                               
		[Description("Employed or affiliated with outside agency part-time")]
		Employedoraffiliatedwithoutsideagencypart_time = 9,                               
		[Description("Other")]
		Other = 10,                               
	}

	public enum IncidentLocationTypeEnum
	{
		[Description("On campus")]
		Oncampus = 1,                               
		[Description("Administrative offices area")]
		Administrativeofficesarea = 2,                               
		[Description("Cafeteria area")]
		Cafeteriaarea = 3,                               
		[Description("Classroom")]
		Classroom = 4,                               
		[Description("Hallway or stairs")]
		Hallwayorstairs = 5,                               
		[Description("Locker room or gym areas")]
		Lockerroomorgymareas = 6,                               
		[Description("Restroom")]
		Restroom = 7,                               
		[Description("Library/media center")]
		Librarymediacenter = 8,                               
		[Description("Computer lab")]
		Computerlab = 9,                               
		[Description("Auditorium")]
		Auditorium = 10,                               
		[Description("On-campus other inside area")]
		On_campusotherinsidearea = 11,                               
		[Description("Athletic field or playground")]
		Athleticfieldorplayground = 12,                               
		[Description("Stadium")]
		Stadium = 13,                               
		[Description("Parking lot")]
		Parkinglot = 14,                               
		[Description("On-campus other outside area")]
		On_campusotheroutsidearea = 15,                               
		[Description("Off campus")]
		Offcampus = 16,                               
		[Description("Bus stop")]
		Busstop = 17,                               
		[Description("School bus")]
		Schoolbus = 18,                               
		[Description("Walking to or from school")]
		Walkingtoorfromschool = 19,                               
		[Description("Off-campus at other school")]
		Off_campusatotherschool = 20,                               
		[Description("Off-campus at other school district facility")]
		Off_campusatotherschooldistrictfacility = 21,                               
		[Description("Off-campus at a school sponsored activity")]
		Off_campusataschoolsponsoredactivity = 22,                               
		[Description("Off-campus at another location unrelated to school")]
		Off_campusatanotherlocationunrelatedtoschool = 23,                               
		[Description("Online")]
		Online = 24,                               
		[Description("Unknown")]
		Unknown = 25,                               
	}

	public enum CourseLevelCharacteristicTypeEnum
	{
		[Description("Accepted as high school equivalent")]
		Acceptedashighschoolequivalent = 1,                               
		[Description("Advanced")]
		Advanced = 2,                               
		[Description("Advanced Placement")]
		AdvancedPlacement = 3,                               
		[Description("Basic")]
		Basic = 4,                               
		[Description("College-level")]
		College_level = 5,                               
		[Description("Core Subject")]
		CoreSubject = 6,                               
		[Description("Correspondence")]
		Correspondence = 7,                               
		[Description("Career and Technical Education")]
		CareerandTechnicalEducation = 8,                               
		[Description("Distance Learning")]
		DistanceLearning = 9,                               
		[Description("Dual Credit")]
		DualCredit = 10,                               
		[Description("English Language Learner")]
		EnglishLanguageLearner = 11,                               
		[Description("General")]
		General = 12,                               
		[Description("Gifted and Talented")]
		GiftedandTalented = 13,                               
		[Description("Graduation Credit")]
		GraduationCredit = 14,                               
		[Description("Honors")]
		Honors = 15,                               
		[Description("International Baccalaureate")]
		InternationalBaccalaureate = 16,                               
		[Description("Magnet")]
		Magnet = 17,                               
		[Description("Pre-AP")]
		Pre_AP = 18,                               
		[Description("Pre-IB")]
		Pre_IB = 19,                               
		[Description("Remedial")]
		Remedial = 20,                               
		[Description("Students with disabilities")]
		Studentswithdisabilities = 21,                               
		[Description("Untracked")]
		Untracked = 22,                               
		[Description("Other")]
		Other = 23,                               
	}

	public enum RaceTypeEnum
	{
		[Description("American Indian - Alaskan Native")]
		AmericanIndian_AlaskanNative = 1,                               
		[Description("Asian")]
		Asian = 2,                               
		[Description("Black - African American")]
		Black_AfricanAmerican = 3,                               
		[Description("Native Hawaiian - Pacific Islander")]
		NativeHawaiian_PacificIslander = 4,                               
		[Description("White")]
		White = 5,                               
	}

	public enum InterventionEffectivenessRatingTypeEnum
	{
		[Description("Positive Effects")]
		PositiveEffects = 1,                               
		[Description("Potentially Positive Effects")]
		PotentiallyPositiveEffects = 2,                               
		[Description("Mixed Effects")]
		MixedEffects = 3,                               
		[Description("Potentially Negative Effects")]
		PotentiallyNegativeEffects = 4,                               
		[Description("Negative Effects")]
		NegativeEffects = 5,                               
		[Description("No Discernible Effects")]
		NoDiscernibleEffects = 6,                               
	}

	public enum CharterStatusTypeEnum
	{
		[Description("School Charter")]
		SchoolCharter = 1,                               
		[Description("College/University Charter")]
		CollegeUniversityCharter = 2,                               
		[Description("Open Enrollment")]
		OpenEnrollment = 3,                               
		[Description("Not a Charter School")]
		NotaCharterSchool = 4,                               
	}

	public enum AssessmentCategoryTypeEnum
	{
		[Description("Achievement test")]
		Achievementtest = 1,                               
		[Description("Advanced Placement")]
		AdvancedPlacement = 2,                               
		[Description("Alternate assessment/ELL")]
		AlternateassessmentELL = 3,                               
		[Description("Alternate assessment/grade-level standards")]
		Alternateassessmentgrade_levelstandards = 4,                               
		[Description("Alternative assessment/modified standards")]
		Alternativeassessmentmodifiedstandards = 5,                               
		[Description("Aptitude test")]
		Aptitudetest = 6,                               
		[Description("Attitudinal test")]
		Attitudinaltest = 7,                               
		[Description("Benchmark test")]
		Benchmarktest = 8,                               
		[Description("Class test")]
		Classtest = 9,                               
		[Description("Class quiz")]
		Classquiz = 10,                               
		[Description("College entrance exam")]
		Collegeentranceexam = 11,                               
		[Description("Cognitive and perceptual skills test")]
		Cognitiveandperceptualskillstest = 12,                               
		[Description("Developmental observation")]
		Developmentalobservation = 13,                               
		[Description("Diagnostic")]
		Diagnostic = 14,                               
		[Description("English proficiency screening test")]
		Englishproficiencyscreeningtest = 15,                               
		[Description("Foreign language proficiency test")]
		Foreignlanguageproficiencytest = 16,                               
		[Description("Formative")]
		Formative = 17,                               
		[Description("Interest inventory")]
		Interestinventory = 18,                               
		[Description("Interim")]
		Interim = 19,                               
		[Description("International Baccalaureate")]
		InternationalBaccalaureate = 20,                               
		[Description("Language proficiency test")]
		Languageproficiencytest = 21,                               
		[Description("Manual dexterity test")]
		Manualdexteritytest = 22,                               
		[Description("Mental ability (intelligence) test")]
		Mentalability_intelligencetest = 23,                               
		[Description("Performance assessment")]
		Performanceassessment = 24,                               
		[Description("Personality test")]
		Personalitytest = 25,                               
		[Description("Portfolio assessment")]
		Portfolioassessment = 26,                               
		[Description("Prekindergarten Readiness")]
		PrekindergartenReadiness = 27,                               
		[Description("Psychological test")]
		Psychologicaltest = 28,                               
		[Description("Psychomotor test")]
		Psychomotortest = 29,                               
		[Description("Reading readiness test")]
		Readingreadinesstest = 30,                               
		[Description("State summative assessment 3-8 general")]
		Statesummativeassessment3_8general = 31,                               
		[Description("State high school subject assessment")]
		Statehighschoolsubjectassessment = 32,                               
		[Description("State high school course assessment")]
		Statehighschoolcourseassessment = 33,                               
		[Description("State alternative assessment/grade-level standards")]
		Statealternativeassessmentgrade_levelstandards = 34,                               
		[Description("State alternative assessment/modified standards")]
		Statealternativeassessmentmodifiedstandards = 35,                               
		[Description("State alternate assessment/ELL")]
		StatealternateassessmentELL = 36,                               
		[Description("State English proficiency test")]
		StateEnglishproficiencytest = 37,                               
		[Description("Other")]
		Other = 38,                               
		[Description("EL - Approaches toward learning")]
		EL_Approachestowardlearning = 39,                               
		[Description("EL - Cognition and general knowledge")]
		EL_Cognitionandgeneralknowledge = 40,                               
		[Description("EL - Language and literacy development")]
		EL_Languageandliteracydevelopment = 41,                               
		[Description("EL - Physical well-being and motor development")]
		EL_Physicalwell_beingandmotordevelopment = 42,                               
		[Description("EL - Social and emotional development")]
		EL_Socialandemotionaldevelopment = 43,                               
	}

	public enum ReasonExitedTypeEnum
	{
		[Description("Died or is permanently incapacitated")]
		Diedorispermanentlyincapacitated = 1,                               
		[Description("Reached maximum age")]
		Reachedmaximumage = 2,                               
		[Description("Discontinued schooling")]
		Discontinuedschooling = 3,                               
		[Description("Suspended or expelled from school")]
		Suspendedorexpelledfromschool = 4,                               
		[Description("Graduated with a high school diploma")]
		Graduatedwithahighschooldiploma = 5,                               
		[Description("Received certificate of completion, modified diploma, or finished IEP requi")]
		ReceivedcertificateofcompletionmodifieddiplomaorfinishedIEPrequi = 6,                               
		[Description("Transferred to another district or school")]
		Transferredtoanotherdistrictorschool = 7,                               
		[Description("Moved out of state")]
		Movedoutofstate = 8,                               
		[Description("Withdrawal by a parent (or guardian)")]
		Withdrawalbyaparent_orguardian = 9,                               
		[Description("Other")]
		Other = 10,                               
		[Description("Unknown reason")]
		Unknownreason = 11,                               
	}

	public enum EntryGradeLevelReasonTypeEnum
	{
		[Description("Promotion - Accelerated promotion")]
		Promotion_Acceleratedpromotion = 1,                               
		[Description("Promotion - Continuous promotion")]
		Promotion_Continuouspromotion = 2,                               
		[Description("Promotion - Probationary promotion")]
		Promotion_Probationarypromotion = 3,                               
		[Description("Promotion - Regular promotion")]
		Promotion_Regularpromotion = 4,                               
		[Description("Promotion - Variable progress")]
		Promotion_Variableprogress = 5,                               
		[Description("Promotion - Other")]
		Promotion_Other = 6,                               
		[Description("Nonpromotion - Failed to meet testing requirements")]
		Nonpromotion_Failedtomeettestingrequirements = 7,                               
		[Description("Nonpromotion - Illness")]
		Nonpromotion_Illness = 8,                               
		[Description("Nonpromotion - Immaturity")]
		Nonpromotion_Immaturity = 9,                               
		[Description("Nonpromotion - Inadequate performance")]
		Nonpromotion_Inadequateperformance = 10,                               
		[Description("Nonpromotion - Insufficient credits")]
		Nonpromotion_Insufficientcredits = 11,                               
		[Description("Nonpromotion - Prolonged absence")]
		Nonpromotion_Prolongedabsence = 12,                               
		[Description("Nonpromotion - Other")]
		Nonpromotion_Other = 13,                               
	}

	public enum CurriculumUsedTypeEnum
	{
		[Description("Creative curriculum infants/toddlers")]
		Creativecurriculuminfantstoddlers = 1,                               
		[Description("Creative curriculum preschool")]
		Creativecurriculumpreschool = 2,                               
		[Description("Creative curriculum family child care")]
		Creativecurriculumfamilychildcare = 3,                               
		[Description("Highscope preschoolers")]
		Highscopepreschoolers = 4,                               
		[Description("Highscope infants/toddlers")]
		Highscopeinfantstoddlers = 5,                               
		[Description("Montessori curriculum")]
		Montessoricurriculum = 6,                               
		[Description("Locally designed curriculum")]
		Locallydesignedcurriculum = 7,                               
		[Description("Other curriculum")]
		Othercurriculum = 8,                               
		[Description("None")]
		None = 9,                               
	}

	public enum CitizenshipStatusTypeEnum
	{
		[Description("US Citizen")]
		USCitizen = 1,                               
		[Description("Permanent Resident")]
		PermanentResident = 2,                               
		[Description("Resident alien")]
		Residentalien = 3,                               
		[Description("Non-resident alien")]
		Non_residentalien = 4,                               
		[Description("Refugee")]
		Refugee = 5,                               
	}

	public enum TitleIPartASchoolDesignationTypeEnum
	{
		[Description("Not designated as a Title I Part A school")]
		NotdesignatedasaTitleIPartAschool = 1,                               
		[Description("Title I Part A Schoolwide Assistance Program School")]
		TitleIPartASchoolwideAssistanceProgramSchool = 2,                               
		[Description("Title I Part A Targeted Assistance School")]
		TitleIPartATargetedAssistanceSchool = 3,                               
		[Description("Title I targeted eligible school - no program")]
		TitleItargetedeligibleschool_noprogram = 4,                               
		[Description("Title I targeted school")]
		TitleItargetedschool = 5,                               
		[Description("Title I school wide eligible - Title I targeted program")]
		TitleIschoolwideeligible_TitleItargetedprogram = 6,                               
		[Description("Title I school wide eligible school - no program")]
		TitleIschoolwideeligibleschool_noprogram = 7,                               
	}

	public enum SpecialEducationSettingTypeEnum
	{
		[Description("Inside regular class 80% or more of the day")]
		Insideregularclass80Percentageormoreoftheday = 1,                               
		[Description("Inside regular class no more than 79% of day and no less than 40% of the da")]
		Insideregularclassnomorethan79Percentageofdayandnolessthan40Percentageoftheda = 2,                               
		[Description("Inside regular class less than 40% of the day ")]
		Insideregularclasslessthan40Percentageoftheday = 3,                               
		[Description("Separate School")]
		SeparateSchool = 4,                               
		[Description("Residential Facility")]
		ResidentialFacility = 5,                               
		[Description("Homebound/Hospital")]
		HomeboundHospital = 6,                               
		[Description("Correctional Facilities")]
		CorrectionalFacilities = 7,                               
		[Description("Parentally-placed in Private Schools")]
		Parentally_placedinPrivateSchools = 8,                               
	}

	public enum EntryTypeEnum
	{
		[Description("Transfer")]
		Transfer = 1,                               
		[Description("Re-entry")]
		Re_entry = 2,                               
		[Description("Next year school")]
		Nextyearschool = 3,                               
		[Description("New to education system")]
		Newtoeducationsystem = 4,                               
		[Description("Other")]
		Other = 5,                               
	}

	public enum ReasonNotTestedTypeEnum
	{
		[Description("Absent")]
		Absent = 1,                               
		[Description("LEP exempt")]
		LEPexempt = 2,                               
		[Description("LEP postponement")]
		LEPpostponement = 3,                               
		[Description("Not appropriate (ARD decision)")]
		Notappropriate_ARDdecision = 4,                               
		[Description("Not tested (ARD decision)")]
		Nottested_ARDdecision = 5,                               
		[Description("Alternate assessment administered")]
		Alternateassessmentadministered = 6,                               
		[Description("Parental waiver")]
		Parentalwaiver = 7,                               
		[Description("Foreign exchange student waiver")]
		Foreignexchangestudentwaiver = 8,                               
		[Description("Refusal by parent")]
		Refusalbyparent = 9,                               
		[Description("Refusal by student")]
		Refusalbystudent = 10,                               
		[Description("Medical waiver")]
		Medicalwaiver = 11,                               
		[Description("Disruptive behavior")]
		Disruptivebehavior = 12,                               
		[Description("Previously passed the examination")]
		Previouslypassedtheexamination = 13,                               
		[Description("Other")]
		Other = 14,                               
	}

	public enum ClassroomPositionTypeEnum
	{
		[Description("Teacher of Record")]
		TeacherofRecord = 1,                               
		[Description("Substitute Teacher")]
		SubstituteTeacher = 2,                               
		[Description("Support Teacher")]
		SupportTeacher = 3,                               
		[Description("Assistant Teacher")]
		AssistantTeacher = 4,                               
	}

	public enum SchoolTypeEnum
	{
		[Description("Alternative")]
		Alternative = 1,                               
		[Description("Regular")]
		Regular = 2,                               
		[Description("Special Education")]
		SpecialEducation = 3,                               
		[Description("Career and Technical Education")]
		CareerandTechnicalEducation = 4,                               
	}
}