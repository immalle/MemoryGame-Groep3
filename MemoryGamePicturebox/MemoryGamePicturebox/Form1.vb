Public Class Form1



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim list As New ArrayList

        'list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image3"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image3"))

        list.Add(My.Resources.ResourceManager.GetObject("Image4"))
        list.Add(My.Resources.ResourceManager.GetObject("Image5"))
        list.Add(My.Resources.ResourceManager.GetObject("Image6"))
        list.Add(My.Resources.ResourceManager.GetObject("Image7"))
        list.Add(My.Resources.ResourceManager.GetObject("Image8"))
        list.Add(My.Resources.ResourceManager.GetObject("Image9"))
        list.Add(My.Resources.ResourceManager.GetObject("Image10"))
        list.Add(My.Resources.ResourceManager.GetObject("Image11"))
        list.Add(My.Resources.ResourceManager.GetObject("Image12"))
        list.Add(My.Resources.ResourceManager.GetObject("Image13"))
        list.Add(My.Resources.ResourceManager.GetObject("Image14"))
        list.Add(My.Resources.ResourceManager.GetObject("Image15"))
        list.Add(My.Resources.ResourceManager.GetObject("Image16"))
        list.Add(My.Resources.ResourceManager.GetObject("Image17"))
        list.Add(My.Resources.ResourceManager.GetObject("Image18"))
        list.Add(My.Resources.ResourceManager.GetObject("Image19"))
        list.Add(My.Resources.ResourceManager.GetObject("Image4"))
        list.Add(My.Resources.ResourceManager.GetObject("Image5"))
        list.Add(My.Resources.ResourceManager.GetObject("Image6"))
        list.Add(My.Resources.ResourceManager.GetObject("Image7"))
        list.Add(My.Resources.ResourceManager.GetObject("Image8"))
        list.Add(My.Resources.ResourceManager.GetObject("Image9"))
        list.Add(My.Resources.ResourceManager.GetObject("Image10"))
        list.Add(My.Resources.ResourceManager.GetObject("Image11"))
        list.Add(My.Resources.ResourceManager.GetObject("Image12"))
        list.Add(My.Resources.ResourceManager.GetObject("Image13"))
        list.Add(My.Resources.ResourceManager.GetObject("Image14"))
        list.Add(My.Resources.ResourceManager.GetObject("Image15"))
        list.Add(My.Resources.ResourceManager.GetObject("Image16"))
        list.Add(My.Resources.ResourceManager.GetObject("Image17"))
        list.Add(My.Resources.ResourceManager.GetObject("Image18"))
        list.Add(My.Resources.ResourceManager.GetObject("Image19"))
      


        Dim rand As New Random
        Dim index As Integer
        Dim item As Object
        Dim listIndex As Integer = 0

        For i = 0 To 5
            For j = 0 To 7

                Dim picbox As New PictureBox()
                picbox.Size = New Size(100, 100)
                picbox.Location = New Point(150 * j, 150 * i)
                picbox.SizeMode = PictureBoxSizeMode.StretchImage

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


