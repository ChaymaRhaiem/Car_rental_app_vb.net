Imports System.Data.SqlClient
Imports System.IO

Public Class viewusersvb
    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from UserLog order by ID desc", conn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 90


        Dim pic1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table

        pic1 = DataGridView1.Columns(6)

        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”)


    Private Sub viewusersvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind1()

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value.ToString = textbox1.Text Then
                    temp = 1
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Navy



                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("user not found")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim delete1 As String = "Delete from UserLog where ID=" & Label4.Text

        Dim command1 As New SqlCommand(delete1, conn)

        If conn.State = ConnectionState.Closed Then

            conn.Open()

        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("deleted")


        conn.Close()


        bind1()


    End Sub

    Private Sub datagridview1_click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        Label4.Text = DataGridView1.CurrentRow.Cells(0).Value

        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value


        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value

        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value

        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value




    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clientreservation.Show()

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateAdminProfile.Show()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()

        LoginForm.Show()


    End Sub
End Class