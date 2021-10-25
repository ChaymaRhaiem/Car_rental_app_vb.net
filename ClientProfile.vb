Imports System.Data.SqlClient
Imports System.IO

Public Class ClientProfile
    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”)



    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from UserLog order by ID desc", conn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)






    End Sub


   
    Dim btn As MessageBoxButtons = MessageBoxButtons.OK
    Dim ico As MessageBoxIcon = MessageBoxIcon.Information
    Dim caption As String = "Save"



    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
        Next
        textbox1.Select()
    End Sub

    Private Sub ClientProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textbox1.Select()

    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)

            PictureBox1.BackgroundImage = Nothing



        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(textbox1.Text) Then
            MessageBox.Show("Please enter First Name.", caption, btn, ico)
            textbox1.Select()
            Return
        End If

        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Please enter Last Name.", caption, btn, ico)
            TextBox2.Select()
            Return
        End If

        If String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Please enter Username.", caption, btn, ico)

            TextBox3.Select()
            Return
        End If

        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Please enter password.", caption, btn, ico)
            TextBox4.Select()
            Return
        End If

        If String.IsNullOrEmpty(TextBox6.Text) Then
            MessageBox.Show("Please enter Confirmation Password.", caption, btn, ico)
            TextBox6.Select()
            Return
        End If

        If TextBox6.Text <> TextBox4.Text Then
            MessageBox.Show("Your password and confirmation password do not match.", caption, btn, ico)
            TextBox6.Select()
            Exit Sub
        End If

        Dim CheckDuplicates As DataTable = ExecuteSQL("SELECT username FROM UserLog WHERE username = '" & TextBox3.Text & "'")

        If CheckDuplicates.Rows.Count > 0 Then
            MessageBox.Show("The Username already exists. Please try another username.", caption, btn, ico)
            TextBox3.Focus()
            Return
        End If

        Dim result As DialogResult

        result = MessageBox.Show("Do you want to save the selected record?", "Save",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then


            '  ShowUserData()

            ' Clear all textboxes
            For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
                tb.Text = String.Empty
            Next

        Else
            Return
        End If

        Dim command1 As New SqlCommand("Insert into UserLog(username,Firstname,Lastname,password,UserAuthorisation,image)values(@username,@Firstname,@Lastname,@password,@UserAuthorisation ,@image)", conn)

        command1.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = textbox1.Text


        command1.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = TextBox2.Text

        command1.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox3.Text

        command1.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox4.Text
        command1.Parameters.Add("@UserAuthorisation", SqlDbType.VarChar).Value = TextBox5.Text


        Dim memstr As New MemoryStream


        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

        command1.Parameters.Add("@image", SqlDbType.Image).Value = memstr.ToArray


        If conn.State = ConnectionState.Closed Then

            conn.Open()


        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("image inserted")



        conn.Close()

        bind1()
        Me.Hide()

        ClientForm.Show()
    End Sub
End Class