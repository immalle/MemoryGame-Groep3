Public Class Form1



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim imageList As New List(Of String)

        imageList.Add(My.Resources.ResourceManager.GetObject("Image1"))
        imageList.Add(My.Resources.ResourceManager.GetObject("Image2"))
        imageList.Add(My.Resources.ResourceManager.GetObject("Image3"))


        For i = 0 To 1
            For j = 0 To 2
                Dim rnd As New Random

                imageList.RemoveAt(1)

                Dim picbox As New PictureBox()
                picbox.Size = New Size(20, 20)
                picbox.Location = New Point(30 * i, 30 * j)

                picbox.Image = 

                Me.Controls.Add(picbox)
            Next
        Next


        'AddHandler picbox.MouseEnter, AddressOf PicboxOnMouseEnterEventHandler
    End Sub

    'Private Sub PicboxOnMouseEnterEventHandler(sender As Label, e As System.EventArgs)
    '    sender.BackColor = Color.Red
    'End Sub
End Class


