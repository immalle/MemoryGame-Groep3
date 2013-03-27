Public Class Form1





    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim keuze1 As String
        Dim keuze2 As String
        Dim list As New ArrayList

        For i = 1 To 16
            Dim img As Image

            img = My.Resources.ResourceManager.GetObject("Image" & i)
            img.Tag = "Image" & i

            list.Add(img)
        Next

        'list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image3"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image4"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image5"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image6"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image7"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image8"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image9"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image10"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image11"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image12"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image13"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image14"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image15"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image16"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image1"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image2"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image3"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image4"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image5"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image6"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image7"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image8"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image9"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image10"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image11"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image12"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image13"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image14"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image15"))
        'list.Add(My.Resources.ResourceManager.GetObject("Image16"))




        Dim rand As New Random
        Dim index As Integer
        Dim item As Object
        Dim listIndex As Integer = 0
        Dim getalIndex As String

        For i = 0 To 5
            For j = 0 To 7

                Dim picbox As New PictureBox()
                picbox.Size = New Size(100, 100)
                picbox.Location = New Point(150 * j, 150 * i)
                picbox.SizeMode = PictureBoxSizeMode.StretchImage

                'picbox.Image = list(listIndex)
                picbox.Tag = list(listIndex)
                listIndex += 1
                getalIndex = listIndex.ToString()

                picbox.Image = My.Resources.ResourceManager.GetObject("ImageAchterzijde")
                Me.Controls.Add(picbox)
                AddHandler picbox.MouseClick, AddressOf PicboxMouseClickEventHandler
            Next
        Next


    End Sub

    Private Sub PicboxMouseClickEventHandler(sender As PictureBox, e As System.EventArgs)


        'sender.Image.Tag = 

        Dim temp As Object

        temp = sender.Image
        sender.Image = sender.Tag

        sender.Tag = temp

    End Sub

   
End Class


