USE [ProgramaMedico]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[CitaID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CitaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[DUI] [nvarchar](20) NULL,
	[NombreCompleto] [nvarchar](20) NULL,
	[Estado] [int] NULL,
	[TipoEmpleadoID] [int] NULL,
	[Usuario] [nvarchar](50) NULL,
	[Password] [nvarchar](100) NULL,
	[Especialidad] [nvarchar](100) NULL,
 CONSTRAINT [PK__Empleado__958BE6F06A2B38C4] PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[EstadoID] [int] IDENTITY(1,1) NOT NULL,
	[TipoEstado] [nvarchar](50) NULL,
 CONSTRAINT [PK__Estado__FEF86B604C23A0E5] PRIMARY KEY CLUSTERED 
(
	[EstadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialMedico]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialMedico](
	[HistorialID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NULL,
	[FechaConsulta] [date] NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Diagnostico] [nvarchar](max) NULL,
	[Tratamiento] [nvarchar](max) NULL,
 CONSTRAINT [PK__Historia__975206EF3DE14266] PRIMARY KEY CLUSTERED 
(
	[HistorialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[PacienteID] [int] IDENTITY(1,1) NOT NULL,
	[DUI] [nvarchar](20) NULL,
	[NombreCompleto] [nvarchar](250) NULL,
	[Telefono] [nvarchar](20) NULL,
	[Sexo] [nvarchar](10) NULL,
	[Edad] [int] NULL,
	[TipoSangre] [nvarchar](5) NULL,
	[Estatura] [decimal](5, 2) NULL,
	[Peso] [decimal](5, 2) NULL,
 CONSTRAINT [PK__Paciente__9353C07FFD30F044] PRIMARY KEY CLUSTERED 
(
	[PacienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEmpleado]    Script Date: 20/04/2025 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEmpleado](
	[TipoEmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK__TipoEmpl__0636C37B1856E5FF] PRIMARY KEY CLUSTERED 
(
	[TipoEmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Empleados] FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Empleados]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Pacientes] FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Pacientes]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK__Empleados__TipoE__29572725] FOREIGN KEY([TipoEmpleadoID])
REFERENCES [dbo].[TipoEmpleado] ([TipoEmpleadoID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK__Empleados__TipoE__29572725]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EstadoID] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([EstadoID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_EstadoID]
GO
ALTER TABLE [dbo].[HistorialMedico]  WITH CHECK ADD  CONSTRAINT [FK__Historial__Pacie__36B12243] FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[HistorialMedico] CHECK CONSTRAINT [FK__Historial__Pacie__36B12243]
GO
