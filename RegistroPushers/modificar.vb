Imports System.ComponentModel
Imports System.IO

Public Class modificar
    Dim WB As Object
    Dim WS As Object
    Dim xlsApp As Object

    Private Sub modificar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
        RegPushersTableAdapter.Update(DatabaseDataSet.regPushers)
    End Sub

    Private Sub modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RegPushersTableAdapter.Fill(Me.DatabaseDataSet.regPushers)
    End Sub

    Private Sub modificar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'DataGridView1.Size = New Size(Me.Width, Me.Height * 0.9)
        'DataGridView1.Location = New Point(0, Me.Height * 0.1)
    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub closeXls()
        Try
            WB.saved = True
            WB.close()
            xlsApp.quit()
            releaseObject(xlsApp)
            releaseObject(WB)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim f As String = SaveFileDialog1.FileName

            xlsApp = CreateObject("Excel.Application")
            xlsApp.visible = False 'False if RELEASE VERSION

            If File.Exists(f) Then
                File.Delete(f)
            End If

            WB = xlsApp.Workbooks.Add()
            WS = WB.Worksheets(1)

            'ID, AssetDesc, assetID, assetModel, pushers, motive, loc, createdAt, type, creatorID
            WS.cells(1, 1).value = "ID"
            WS.cells(1, 2).value = "Descripcion"
            WS.cells(1, 3).value = "# Asset"
            WS.cells(1, 4).value = "Modelo equipo"
            WS.cells(1, 5).value = "Pushers"
            WS.cells(1, 6).value = "Motivo"
            WS.cells(1, 7).value = "Locacion"
            WS.cells(1, 8).value = "Fecha creacion"
            WS.cells(1, 9).value = "Accion"
            WS.cells(1, 10).value = "Creado por"

            For x = 0 To DatabaseDataSet.Tables.Item(0).Rows.Count - 1
                Dim inf As DataRow = DatabaseDataSet.Tables.Item(0).Rows.Item(x)
                WS.cells(x + 2, 1).value = inf.Item(0)
                WS.cells(x + 2, 2).value = inf.Item(1)
                WS.cells(x + 2, 3).value = inf.Item(2)
                WS.cells(x + 2, 4).value = inf.Item(3)
                WS.cells(x + 2, 5).value = inf.Item(4)
                WS.cells(x + 2, 6).value = inf.Item(5)
                WS.cells(x + 2, 7).value = inf.Item(6)
                WS.cells(x + 2, 8).value = inf.Item(7)
                WS.cells(x + 2, 9).value = inf.Item(8)
                WS.cells(x + 2, 10).value = inf.Item(9)
            Next

            WB.SaveAs(f)

            closeXls()

            MsgBox("Archivo exportado con exito!", MsgBoxStyle.Information, "Registro de Pushers")
        End If
    End Sub
End Class