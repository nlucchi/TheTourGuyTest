using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTourGuyTest.Data.Migrations
{
    public partial class initialseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
SET IDENTITY_INSERT [dbo].[Climates] ON 
GO
INSERT [dbo].[Climates] ([ClimateId], [ClimateName]) VALUES (1, N'Desert')
GO
INSERT [dbo].[Climates] ([ClimateId], [ClimateName]) VALUES (2, N'Temperate')
GO
INSERT [dbo].[Climates] ([ClimateId], [ClimateName]) VALUES (3, N'Forested')
GO
SET IDENTITY_INSERT [dbo].[Climates] OFF
GO
SET IDENTITY_INSERT [dbo].[Planets] ON 
GO
INSERT [dbo].[Planets] ([PlanetId], [PlanetName], [ClimateId]) VALUES (1, N'Tattooine', 1)
GO
INSERT [dbo].[Planets] ([PlanetId], [PlanetName], [ClimateId]) VALUES (2, N'Naboo', 2)
GO
INSERT [dbo].[Planets] ([PlanetId], [PlanetName], [ClimateId]) VALUES (3, N'Alderaan', 3)
GO
INSERT [dbo].[Planets] ([PlanetId], [PlanetName], [ClimateId]) VALUES (4, N'Corellia', 2)
GO
INSERT [dbo].[Planets] ([PlanetId], [PlanetName], [ClimateId]) VALUES (5, N'Chandrila', 2)
GO
SET IDENTITY_INSERT [dbo].[Planets] OFF
GO
INSERT [dbo].[RelationTypes] ([RelationTypeId], [RelationName]) VALUES (1, N'Partner of')
GO
INSERT [dbo].[RelationTypes] ([RelationTypeId], [RelationName]) VALUES (2, N'Child of')
GO
INSERT [dbo].[RelationTypes] ([RelationTypeId], [RelationName]) VALUES (3, N'Parent of')
GO
INSERT [dbo].[RelationTypes] ([RelationTypeId], [RelationName]) VALUES (4, N'Sibling of')
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'Sith')
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Royalty')
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'Knight')
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (4, N'Smuggler')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName]) VALUES (1, N'Jedi')
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName]) VALUES (2, N'Alliance')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (2, N'Anakin', N'Skywalker', 1, 1, 1)
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (3, N'Padme', N'Amidala', 2, 2, 2)
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (5, N'Luke', N'Skywalker', 3, 1, 1)
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (7, N'Leia', N'Organa', 2, 2, 3)
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (8, N'Han', N'Solo', 4, 2, 4)
GO
INSERT [dbo].[Persons] ([PersonId], [Name], [Surname], [RoleId], [TeamId], [PlanetId]) VALUES (9, N'Ben', N'Solo', 1, 1, 5)
GO
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (1, 2, 3)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (3, 2, 5)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (3, 2, 7)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (1, 3, 2)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (3, 3, 5)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (3, 3, 7)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 5, 2)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 5, 3)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (4, 5, 7)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 7, 2)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 7, 3)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (4, 7, 5)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (1, 8, 7)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (3, 8, 9)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 9, 7)
GO
INSERT [dbo].[Relations] ([RelationTypeId], [RelationSubjectId], [RelationObjectId]) VALUES (2, 9, 8)
GO
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
