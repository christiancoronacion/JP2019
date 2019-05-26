Public Class Operaciones

    Public Function dividir(n1 As Integer, n2 As Integer) As String
        Dim n As Double = 0
        If n2 <> 0 Then
            If n1 > n2 Then
                n = n1 / n2
                Dim str As String
                str = n1 & "/" + CStr(n2) & "=" & n
                Return str
            Else
                Return "El segundo numero debe ser mayor"
            End If
        Else
            Return "Division por Cero Error.."

        End If

    End Function
    Public Sub Creditos()
        Dim msg = "Infodata"
        MsgBox(msg)
    End Sub
End Class
