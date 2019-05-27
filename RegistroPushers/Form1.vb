Public Class Form1

    Public user As String
    Dim passwords As New ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        agregar.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pass As String = InputBox("Escriba el password de acceso:", "Registro de Pushers")

        If pass.Length > 0 Then
            If passwords.Contains(pass) Then
                modificar.Show()
                Me.Enabled = False
            Else
                MsgBox("Password incorrecto!", MsgBoxStyle.Exclamation, "Registro de Pushers")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar passwords a Array
        passwords.Add("jortega")
        passwords.Add("jportillo")

        changeUser()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        changeUser()
    End Sub

    Private Sub changeUser(Optional obligatorio As Boolean = False)
        Dim res As String = InputBox("Escanee o escriba su numero de reloj:", "Registro de Pushers")

        If res.Length = 5 And IsNumeric(res) Then
            user = res
            Label1.Text = user
        Else
            changeUser()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With modificar
            .Show()
            .DataGridView1.AllowUserToDeleteRows = False
            .DataGridView1.ReadOnly = True
        End With


        Me.Enabled = False
    End Sub
End Class
