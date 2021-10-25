Imports System.Data.SqlClient
Imports System.IO

Public Class UpdateAdminProfile

    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”)


    Dim btn As MessageBoxButtons = MessageBoxButtons.OK
    Dim ico As MessageBoxIcon = MessageBoxIcon.Information
    Dim caption As String = "Save"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)

            PictureBox1.BackgroundImage = Nothing



        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Dim memstr As New MemoryStream

        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)


        Dim img() As Byte

        img = memstr.ToArray()
        Using command1 As New SqlCommand("UPDATE UserLog Set Firstname=@fn , Lastname=@ln , password =@pw,image=@img WHERE username =@username", conn)



            command1.Parameters.Add("@fn", SqlDbType.VarChar).Value = textbox1.Text


            command1.Parameters.Add("@ln", SqlDbType.VarChar).Value = TextBox2.Text

            command1.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox3.Text

            command1.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox4.Text
            command1.Parameters.Add("@img", SqlDbType.Image).Value = img

            PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

            conn.open()

            If conn.State = ConnectionState.Closed Then

                conn.Open()
            End If
            command1.ExecuteNonQuery()

            MessageBox.Show("updated successfully.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information)



        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clientreservation.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        LoginForm.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viewusersvb.Show()


        Me.Hide()


    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Hide()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class