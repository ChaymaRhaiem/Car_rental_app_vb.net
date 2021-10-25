Imports System.Data.SqlClient
Imports System.IO

Public Class Clientreservation


    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”)

    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from VoitureClient order by ID desc", conn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 90


        Dim pic1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table

        pic1 = DataGridView1.Columns(5)

        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub Clientreservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind1()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub DatagridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        RichTextBox3.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value


        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value

        TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value

        TextBox4.Text = DataGridView1.CurrentRow.Cells(6).Value


        TextBox5.Text = DataGridView1.CurrentRow.Cells(7).Value

        TextBox6.Text = DataGridView1.CurrentRow.Cells(8).Value


    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        Dim command1 As New SqlCommand("Insert into Confirmed(Modele,lieu,DatePrise,DateRetour,nomConducteur,prenomConducteur,telephone)values(@modele,@lieu,@dp,@dr,@nc,@pc,@telephone)", conn)

        command1.Parameters.Add("@modele", SqlDbType.VarChar).Value = RichTextBox3.Text



        command1.Parameters.Add("@dp", SqlDbType.VarChar).Value = TextBox2.Text



        command1.Parameters.Add("@dr", SqlDbType.VarChar).Value = TextBox3.Text


        command1.Parameters.Add("@lieu", SqlDbType.VarChar).Value = TextBox1.Text

        command1.Parameters.Add("@nc", SqlDbType.VarChar).Value = TextBox4.Text

        command1.Parameters.Add("@pc", SqlDbType.VarChar).Value = TextBox5.Text

        command1.Parameters.Add("@telephone", SqlDbType.VarChar).Value = TextBox6.Text







        If conn.State = ConnectionState.Closed Then

            conn.Open()


        End If

        command1.ExecuteNonQuery()

        MessageBox.Show(" inserted")

        conn.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateAdminProfile.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        managevoitures.Show()


        Me.Hide()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class