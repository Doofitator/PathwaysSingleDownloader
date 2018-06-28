Public Class Form1
    Private Sub btn_downloadModule_Click(sender As Object, e As EventArgs) Handles btn_downloadModule.Click
        Dim x As Exception = Nothing
        Try
            My.Computer.Network.DownloadFile("https://mpcontent.blob.core.windows.net/worksheets/" + txt_code.Text.ToUpper + "-W.pdf", Path + "\" + txt_code.Text.ToUpper + "-W.pdf")
        Catch ex As Exception
            x = ex
            MsgBox("Download Failed: 404.", vbOKOnly, "Error")
        Finally
            If x Is Nothing Then
                MsgBox("Success: File downloaded to " + Path + "\" + txt_code.Text.ToUpper + "-W.pdf", vbOKOnly, "Success!")
            End If
        End Try
    End Sub

    Private Sub btn_downloadVideo_Click(sender As Object, e As EventArgs) Handles btn_downloadVideo.Click
        Dim x As Exception = Nothing
        Try
            My.Computer.Network.DownloadFile("https://mpcontent.blob.core.windows.net/videos/" + txt_code.Text.ToUpper + "-V.mp4", Path + "\" + txt_code.Text.ToUpper + "-V.mp4")
        Catch ex As Exception
            x = ex
            MsgBox("Download Failed: 404.", vbOKOnly, "Error")
        Finally
            If x Is Nothing Then
                MsgBox("Success: File downloaded to " + Path + "\" + txt_code.Text.ToUpper + "-V.mp4", vbOKOnly, "Success!")
            End If
        End Try
    End Sub
    Public Shared Path As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
        'MsgBox(Path)
        Path = New Uri(Path).LocalPath
        'MsgBox(Path)
        Path = Path + "\single_pathways_modules"
        'MsgBox(Path)
        System.IO.Directory.CreateDirectory(Path)
    End Sub
End Class
