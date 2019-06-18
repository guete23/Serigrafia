Public Class empresas
    Private Shared empresan As String
    Private Shared nomempre As String
    Private Shared conecstr As String
    Private Shared strconec As String
    Private Shared usuario_sistema As String
    Private Shared clave_sistema As String
    Private Shared iniciales As String

    Public Sub New()
        'empresan = "Jesus Acosta"
    End Sub

    Public Property numero() As String
        Get
            Return empresan
        End Get


        Set(ByVal Value As String)
            empresan = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nomempre
        End Get


        Set(ByVal Value As String)
            nomempre = Value
        End Set
    End Property

    Public Property conexion() As String
        Get
            Return conecstr
        End Get


        Set(ByVal Value As String)
            conecstr = Value
        End Set
    End Property


    Public Property constr() As String
        Get
            Return strconec
        End Get


        Set(ByVal Value As String)
            strconec = Value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return usuario_sistema
        End Get

        Set(ByVal Value As String)
            usuario_sistema = Value
        End Set
    End Property

    Public Property clave() As String
        Get
            Return clave_sistema
        End Get

        Set(ByVal Value As String)
            clave_sistema = Value
        End Set
    End Property


    Public Property inicial() As String
        Get
            Return iniciales
        End Get

        Set(ByVal Value As String)
            iniciales = Value
        End Set
    End Property
End Class
Public Class datos_e
    Private Shared p_empresa As String
    Private Shared p_nombre As String
    Private Shared p_nit As String
    Private Shared p_direccion As String
    Private Shared p_telefono As String
    Private Shared p_fax As String
    Private Shared p_representante As String
    Private Shared p_contador As String
    Private Shared p_codigo As Decimal
    Private Shared p_registro As String
    Public Property nit() As String
        Get
            Return p_nit
        End Get

        Set(ByVal Value As String)
            p_empresa = Value
        End Set


    End Property

    Public Property direccion() As String
        Get
            Return p_direccion
        End Get

        Set(ByVal Value As String)
            p_direccion = Value
        End Set
    End Property

    Public Property representante() As String
        Get
            Return p_representante
        End Get

        Set(ByVal Value As String)
            p_representante = Value
        End Set
    End Property

    Public Property contador() As String
        Get
            Return p_contador
        End Get

        Set(ByVal Value As String)
            p_contador = Value
        End Set
    End Property

    Public Property registro() As String
        Get
            Return p_registro
        End Get

        Set(ByVal Value As String)
            p_registro = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return p_nombre
        End Get

        Set(ByVal Value As String)
            p_nombre = Value
        End Set
    End Property
   
End Class




