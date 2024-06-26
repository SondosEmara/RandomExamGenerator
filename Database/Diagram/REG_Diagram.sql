/*
   Tuesday, February 27, 20245:05:37 PM
   User: 
   Server: OSAMA-ALLAM-PC
   Database: RandomExamGenerator
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Instructor SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Instructor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Instructor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Instructor', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Department ADD CONSTRAINT
	FK_Department_Has_Instructor_Manager FOREIGN KEY
	(
	InstructorManagerID
	) REFERENCES dbo.Instructor
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Department SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Department', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Department', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Department', 'Object', 'CONTROL') as Contr_Per 