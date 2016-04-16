Imports System.Net, System.IO
Public Class Main
    Private  Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        Dim fo As New OpenFileDialog
        fo.RestoreDirectory = True
        fo.Multiselect = False
        fo.Filter = "txt files (*.txt)|*.txt"
        fo.FilterIndex = 1
        fo.ShowDialog()
        If (Not fo.FileName = Nothing) Then
            Dim links As New List(Of String)
            Using sr As New StreamReader(fo.FileName)
                While sr.Peek <> -1
                    links.Add(sr.ReadLine())
                End While
            End Using
            MyBase.Update()
            Dim myProxy As WebProxy
            For Each link As String In links
                Try
                    Dim WebRequest As HttpWebRequest = WebRequest.Create(link)
                    WebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
                    WebRequest.Timeout = TimeOUT.Value
                    Dim re As HttpWebResponse = WebRequest.GetResponse()
                    LB_Checked.Items.Add("Responsive: " & link)
                    MyBase.Update()
                Catch ex As Exception
                    LB_Checked.Items.Add("Unresponsive: " & link)
                    MyBase.Update()
                End Try
            Next
        End If
    End Sub


    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        If LB_Checked.Items.Count = (0) Then MessageBox.Show("Please check proxies first!.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim S_W As IO.StreamWriter
        Dim itms() As String = {LB_Checked.Items.ToString}
        Dim save As New SaveFileDialog With {.FileName = "Checked Links", .Filter = "Checked Links (*.txt)|*.txt|ALL Files (*.*)|*.*", .CheckPathExists = True}
        save.ShowDialog(Me)
        S_W = New StreamWriter(save.FileName)
        For it As Integer = 0 To LB_Checked.Items.Count - 1
            S_W.WriteLine(LB_Checked.Items.Item(it))
        Next
        S_W.Close()
        MessageBox.Show("Links checked and saved:: " & LB_Checked.Items.Count.ToString())
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub
    '"Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
End Class