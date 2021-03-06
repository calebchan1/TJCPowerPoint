Public Class PrayerRequests
    Private directory As String

    Private Sub ClosePrayerRequests_Click(sender As Object, e As EventArgs) Handles ClosePrayerRequests.Click
        Me.Hide()
    End Sub

    Private Sub onCreate(sender As Object, e As EventArgs) Handles MyBase.Load
        directory = MainProgram.Current + "\Files\PrayerRequests.txt"
        If My.Computer.FileSystem.FileExists(directory) Then
            PrayerRequestTxt.Text = IO.File.ReadAllText(directory)
        End If
    End Sub
    Private Sub UpdatePrayerRequests_Click(sender As Object, e As EventArgs) Handles UpdatePrayerRequests.Click
        MainProgram.ppPres.Slides(3).Shapes(1).TextFrame.TextRange.Text = PrayerRequestTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\PrayerRequests.txt", PrayerRequestTxt.Text, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try

    End Sub
    Private Sub PRFontBtn_Click(sender As Object, e As EventArgs) Handles PRFontBtn.Click
        MainProgram.ChangeFont(3, 1)
    End Sub
    Private Sub PRColorBtn_Click(sender As Object, e As EventArgs) Handles PRColorBtn.Click
        MainProgram.ChangeColor(3, 1)
    End Sub
    Private Sub PRTitleFontBtn_Click(sender As Object, e As EventArgs) Handles PRTitleFontBtn.Click
        MainProgram.ChangeFont(3, 2)
    End Sub
    Private Sub PRTitleColorBtn_Click(sender As Object, e As EventArgs) Handles PRTitleColorBtn.Click
        MainProgram.ChangeColor(3, 2)
    End Sub

    Private Sub editPrayerImage_Click(sender As Object, e As EventArgs) Handles editPrayerImage.Click
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                MainProgram.ppPres.Slides(2).Shapes.AddPicture(ofd.FileName, False, True, 0, 0, MainProgram.ppPres.PageSetup.SlideWidth, MainProgram.ppPres.PageSetup.SlideHeight)
                System.IO.File.WriteAllText(MainProgram.Current + "\Files\prayerImgDir.txt", ofd.FileName)
                MessageBox.Show("Prayer Image Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
            End If


        Catch ex As Exception
            MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainProgram.ppPres.SlideShowWindow.View.GotoSlide(3)
    End Sub


    'https://stackoverflow.com/questions/17392088/allow-a-user-to-move-a-borderless-window
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseDown, header.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseUp, header.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseMove, header.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
End Class