USE [Clinica]
GO

UPDATE [dbo].[Pacientes]
   SET [Nombre] ='gera'
      ,[Celular] = '5555'
      ,[Correo] = 'g@gmail'
      ,[Descripcion] = 'viva'
      ,[Fecha] =  '12/34/2002'
      ,[Recomedacion] =  'caminar'
 WHERE  [IdPersona] = 12345
GO


