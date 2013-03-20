Public Class Form1



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim list As New ArrayList

        list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        list.Add(My.Resources.ResourceManager.GetObject("Image3"))
        list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        list.Add(My.Resources.ResourceManager.GetObject("Image3"))


        Dim rand As New Random
        Dim index As Integer
        Dim item As Object



        Dim listIndex As Integer = 0
        For i = 0 To 1
            For j = 0 To 2
                Dim picbox As New PictureBox()
                picbox.Size = New Size(20, 20)
                picbox.Location = New Point(30 * i, 30 * j)

                picbox.Image = list(listIndex)
                listIndex += 1

                Me.Controls.Add(picbox)
            Next
        Next
       


        'AddHandler picbox.MouseEnter, AddressOf PicboxOnMouseEnterEventHandler
    End Sub

    'Private Sub PicboxOnMouseEnterEventHandler(sender As Label, e As System.EventArgs)
    '    sender.BackColor = Color.Red
    'End Sub
End Class


