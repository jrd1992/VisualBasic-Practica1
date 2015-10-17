Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim resultado As String = ""

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())

        If (n1 Mod n2 = 0) Then
            resultado = "Es Exacto"
        Else
            resultado = "No es Exacto"
        End If

        Label1.Text = resultado
    End Sub
End Class
