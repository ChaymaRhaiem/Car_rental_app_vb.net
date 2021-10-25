Imports System.Data.SqlClient
Imports System.IO

Public Class managevoitures
    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Database = images;Initial Catalog=UserLoginDB;Integrated Security=True”)



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)


        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Dim command1 As New SqlCommand("Insert into Voiture1(Modele,Disponibilité,description,image)values(@modele,@dispo,@description,@img)", conn)

        command1.Parameters.Add("@modele", SqlDbType.VarChar).Value = TextBox1.Text


        command1.Parameters.Add("@dispo", SqlDbType.VarChar).Value = TextBox2.Text
        command1.Parameters.Add("@description", SqlDbType.VarChar).Value = TextBox3.Text



        Dim memstr As New MemoryStream


        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

        command1.Parameters.Add("@img", SqlDbType.Image).Value = memstr.ToArray


        If conn.State = ConnectionState.Closed Then

            conn.Open()


        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("image inserted")

        conn.Close()

        bind1()



    End Sub


    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from Voiture1 order by AutoId desc", conn)


        Dim adapter As New SqlDataAdapter(command1)


        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 90


        Dim pic1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table

        pic1 = DataGridView1.Columns(3)

        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch



    End Sub



    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click


        Label4.Text = DataGridView1.CurrentRow.Cells(0).Value

        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value


        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value

        TextBox3.Text = DataGridView1.CurrentRow.Cells(4).Value

        Dim img As Byte()

        img = DataGridView1.CurrentRow.Cells(3).Value

        Dim memstr As New MemoryStream(img)

        PictureBox1.Image = Image.FromStream(memstr)





    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click


        Dim memstr As New MemoryStream

        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)


        Dim img() As Byte

        img = memstr.ToArray()


        Using command1 As New SqlCommand("UPDATE Voiture1 Set Modele=@fn , Disponibilité=@ln , description=@pw,image=@img WHERE AutoId =" & Label4.Text, conn)



            command1.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox1.Text


            command1.Parameters.Add("@ln", SqlDbType.VarChar).Value = TextBox2.Text


            command1.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox3.Text
            command1.Parameters.Add("@img", SqlDbType.Image).Value = img

            If conn.State = ConnectionState.Closed Then

                conn.Open()
            End If

            command1.ExecuteNonQuery()

            MessageBox.Show("updated")
        End Using
        conn.Close()


        bind1()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click


        Dim delete1 As String = "Delete from Voiture1 where AutoId=" & Label4.Text

        Dim command1 As New SqlCommand(delete1, conn)

        If conn.State = ConnectionState.Closed Then

            conn.Open()

        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("deleted")


        conn.Close()


        bind1()


    End Sub

    Private Sub AdminManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        UpdateAdminProfile.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        viewusersvb.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Clientreservation.Show()
        viewusersvb.Show()


    End Sub
End Class