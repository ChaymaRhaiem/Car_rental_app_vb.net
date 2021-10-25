
Imports System.Data.SqlClient

Public Class LoginForm
    Dim tries As Integer = 0

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Select()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub


    Private Sub login_Click_1(sender As Object, e As EventArgs) Handles login.Click

        If tries < 3 Then
            If Not String.IsNullOrEmpty(username.Text) And
                    Not String.IsNullOrEmpty(password.Text) Then

                Dim SQL As String = String.Empty
                SQL &= "SELECT * FROM UserLog "
                SQL &= "WHERE Username = '" & username.Text & "' "
                SQL &= "AND Password = '" & password.Text & "'"

                Dim connection As New SqlConnection
                Dim conn As SqlConnection

                Dim cmd As New SqlCommand
                conn = New SqlConnection
                conn.ConnectionString = “Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”
                Dim Reader As SqlDataReader

                Dim UserData As DataTable = ExecuteSQL(SQL)

                If UserData.Rows.Count > 0 Then


                    Try
                        conn.Open()
                        Dim query As String
                        query = "SELECT UserAuthorisation FROM UserLog WHERE Username= '" & username.Text & "' and Password = '" & password.Text & "' "
                        cmd = New SqlCommand(query, conn)
                        Reader = cmd.ExecuteReader

                        If (Reader.HasRows()) Then

                            Reader.Read()

                            Dim Index As Long = Reader.GetOrdinal("UserAuthorisation")
                            Dim usertype As String = ""

                            usertype = Reader.GetString(Index)







                            If usertype = "admin" Then
                                Me.Hide()
                                MsgBox("Welcome Admin")
                                managevoitures.Show()
                                conn.Close()
                                ' conn.Dispose()
                            Else
                                MsgBox("Welcome Client")
                                ClientForm.Show()

                                Me.Hide()
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally

                        username.Text = ""
                        password.Text = ""
                    End Try



                Else
                    tries += 1
                    MsgBox("The Username or Password is incorrect. Try again: you currently have reached attempt " & tries & " of 3", MsgBoxStyle.Critical, "Error")
                    username.Focus()
                    username.SelectAll()

                    If tries = 3 Then
                        MsgBox("Maximum count of retries(3),And you'reach the maximum attempts!Try again later", MsgBoxStyle.Critical, "Warning")
                        Me.Close()
                    End If

                End If

            Else
                MsgBox("Please enter Username and Password.", MsgBoxStyle.Critical, "Error")

                username.Select()
            End If


        End If

    End Sub

    Private Sub signup_Click(sender As Object, e As EventArgs) Handles signup.Click
        ClientProfile.Show()
        Me.Hide()
    End Sub
End Class
