Public Class Form1
    Dim POpe As Operaciones
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        POpe = New Operaciones()

    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim resul As String
        resul = POpe.dividir(CInt(txtN1.Text), CInt(txtN2.Text))
        txmOut.Text = resul

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtN1.Text = ""
        txtN2.Text = ""
        txmOut.Text = ""
        txtN1.Focus()


    End Sub

    Private Sub BtnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        POpe.Creditos()

    End Sub
End Class
