Imports Microsoft.Extensions.Configuration

Public Class ConfigHelper
    Public ReadOnly Property ConnectionString() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()

            Dim sections = configuration.GetSection("database").GetChildren().ToList()

            Return $"Data Source={sections(1).Value};Initial Catalog={sections(0).Value};Integrated Security={sections(2).Value}"
        End Get
    End Property
End Class
