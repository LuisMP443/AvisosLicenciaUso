Imports System
Imports System.IO
Public Class imagenes
    Private directorio As New DirectoryInfo(".\avisos")
    Private arrayfichero As FileInfo() = directorio.GetFiles()
    Private tam As Integer = arrayfichero.Length
    Private i As Integer = 0

    Private Sub imagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(".\avisos\" + arrayfichero(i).Name)
    End Sub
    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, PictureBox1.MouseClick
        i = i + 1
        If (i.Equals(tam)) Then
            Me.Close()
        Else
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(".\avisos\" + arrayfichero(i).Name)

        End If

    End Sub
End Class