Imports System.ComponentModel

Public Class agregar
    Private Sub agregar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
    End Sub

    Function ChecarCampo(ByVal data As String, Optional len As Integer = 1, Optional len2 As Integer = -1) As Boolean
        If data.Length >= len Then
            If data.Length <= len2 And len2 >= -1 Then
                Return True
            ElseIf len2 >= -1 Then
                Return True
            End If

        Else
            MsgBox("Hay un campo erroneo!", MsgBoxStyle.Exclamation, "Registro de Pushers")
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ChecarCampo(TextBox1.Text) Then Exit Sub
        If Not ChecarCampo(TextBox2.Text, 4, 6) Then Exit Sub
        If Not ChecarCampo(TextBox3.Text) Then Exit Sub
        If Not ChecarCampo(TextBox4.Text) Then Exit Sub
        If Not ChecarCampo(TextBox5.Text) Then Exit Sub

        Button1.Enabled = False

        newReg()
    End Sub

    Sub newReg()
        Try
            Dim tipo As String
            If RadioButton1.Checked Then tipo = RadioButton1.Text
            If RadioButton2.Checked Then tipo = RadioButton2.Text
            If RadioButton3.Checked Then tipo = RadioButton3.Text

            Dim Sql As String = "INSERT INTO regPushers (AssetDesc, assetID, assetModel, pushers, motive, loc, createdAt, type, creatorID) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & NumericUpDown1.Value & "', '" & TextBox5.Text & "', '" & TextBox4.Text & "', '" & DateTime.Now.ToShortDateString & "', '" & tipo & "', '" & Form1.Label1.Text & "');"

            Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\database.mdb;Persist Security Info=True;Jet OLEDB:Database Password=jorge2100;")
            Dim Command As New OleDb.OleDbCommand(Sql, Connection)

            Connection.Open()
            Command.ExecuteNonQuery()

            Connection.Close()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            NumericUpDown1.Value = 1
            Button1.Enabled = True
            TextBox1.Select()

            MsgBox("Registro agregado!", MsgBoxStyle.Information, "Registro de Pushers")
        Catch ex As Exception
            MsgBox("Excepcion:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Registro de Pushers")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox5_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1.Select()
        End If
    End Sub
End Class