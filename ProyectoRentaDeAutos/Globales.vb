' Para trabajar con una base de datos en ORACLE
Imports Oracle.DataAccess.Client

Module Globales

    'Para trabajar con una base de datos ORACLE, es requerida
    ' para poder abrir y cerrar la BD
    Public cnx As OracleConnection

    ' Definir variables de mi proyecto
    Public idLogin As Integer
    Public usuario As String
    Public contrasena As String
    Public idEstadoAuto As Integer
    Public descripcion As String
    Public idMarca As Integer
    Public nombreMarca As String
    Public idModelo As Integer
    Public nombreModelo As String
    Public placa As String
    Public capacidad As Integer
    Public disponible As String
    Public idPrecioDiario As Integer
    Public montoDia As String
    Public montoGarantia As Integer
    Public idEstado As String
    Public nombreEstado As String
    Public idCiudad As String
    Public nombreCiudad As String
    Public idColonia As String
    Public nombreColonia As String
    Public idSucursal As String
    Public nombreSucursal As Integer
    Public calle As String
    Public idEmpleado As String
    Public nombreEmp As String
    Public paternoEmp As String
    Public maternoEmp As String
    Public telefonoEmp As String
    Public correoEmp As String
    Public noLicencia As String
    Public nombreCli As String
    Public paternoCli As String
    Public maternoCli As String
    Public telefonoCli As String
    Public correoCli As String
    Public noCasa As Integer
    Public idRenta As String
    Public fechaPrestamo As Date
    Public fechaDevolucion As Date
    Public diasRenta As String

End Module
