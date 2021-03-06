﻿CREATE TABLE [dbo].[StudentProgramStatus](
	[StudentUSI] [int] NOT NULL,
	[TestingAccommodation] [bit] NOT NULL,
	[TestingAccommodationFile] [varchar](200) NULL,
	[BilingualProgram] [bit] NOT NULL,
	[EnglishAsSecondLanguage] [bit] NOT NULL,
	[SchoolFoodServicesEligibilityTypeId] [int] NOT NULL,
	[Gifted] [bit] NOT NULL,
	[SpecialEducation] [bit] NOT NULL,
	[SpecialEducationFile] [varchar](200) NULL,
	[TitleParticipation] [bit] NOT NULL,
	[TitleParticipationFile] [varchar](200) NULL,
	[McKinneyVento] [bit] NOT NULL,
	[McKinneyVentoFile] [varchar](200) NULL,
	[Id] [uniqueidentifier] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_StudentProgramStatus] PRIMARY KEY CLUSTERED 
(
	[StudentUSI] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[StudentProgramStatus] ADD  CONSTRAINT [DF_StudentProgramStatus_Id]  DEFAULT (newid()) FOR [Id]
GO

ALTER TABLE [dbo].[StudentProgramStatus] ADD  CONSTRAINT [DF_StudentProgramStatus_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO

ALTER TABLE [dbo].[StudentProgramStatus] ADD  CONSTRAINT [DF_StudentProgramStatus_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO

ALTER TABLE [dbo].[StudentProgramStatus]  WITH CHECK ADD  CONSTRAINT [FK_StudentProgramStatus_SchoolFoodServicesEligibilityType] FOREIGN KEY([SchoolFoodServicesEligibilityTypeId])
REFERENCES [edfi].[SchoolFoodServicesEligibilityType] ([SchoolFoodServicesEligibilityTypeId])
GO

ALTER TABLE [dbo].[StudentProgramStatus] CHECK CONSTRAINT [FK_StudentProgramStatus_SchoolFoodServicesEligibilityType]
GO

ALTER TABLE [dbo].[StudentProgramStatus]  WITH CHECK ADD  CONSTRAINT [FK_StudentProgramStatus_Student] FOREIGN KEY([StudentUSI])
REFERENCES [edfi].[Student] ([StudentUSI])
GO

ALTER TABLE [dbo].[StudentProgramStatus] CHECK CONSTRAINT [FK_StudentProgramStatus_Student]
GO
