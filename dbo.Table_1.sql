CREATE TABLE [dbo].[Appointments]
(
	[ap_Id] INT NOT NULL PRIMARY KEY, 
	[ap_piority] INT NULL,
    [ap_startT] DATETIME NULL, 
    [ap_duraT] DATETIMEOFFSET NULL, 
    [ap_patient] NCHAR(10) NULL, 
    [ap_request] INT NULL, 
    [ap_status] INT NULL
)
