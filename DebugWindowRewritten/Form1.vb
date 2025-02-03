Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FormK As New CV.ProgramTester
        FormK.Show()
        Close()
    End Sub
End Class