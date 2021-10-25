Imports System.Data.SqlClient
Imports System.IO

Public Class catalogue

    Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Initial Catalog=UserLoginDB;Integrated Security=True”)

    Private Sub bind1()

        Dim command1 As New SqlCommand("Select * from Voiture1 WHERE Disponibilité='disponible' ", conn)


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
    Private Sub catalogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind1()

        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False


    End Sub




    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value.ToString = textbox1.Text Then
                    temp = 1
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.MidnightBlue





                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("car not found")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command1 As New SqlCommand("Insert into VoitureClient(ModeleChoisie,nomConducteur,prenomConducteur,Dateprise,DateRetour,LieuPrisecharge,telephone,image)values(@modele,@nom,@prenom,@prise,@retour,@lieu,@telephone,@img)", conn)

        command1.Parameters.Add("@modele", SqlDbType.VarChar).Value = TextBox3.Text


        command1.Parameters.Add("@nom", SqlDbType.VarChar).Value = TextBox4.Text

        command1.Parameters.Add("@prenom", SqlDbType.VarChar).Value = TextBox6.Text
        command1.Parameters.Add("@telephone", SqlDbType.VarChar).Value = TextBox5.Text
        command1.Parameters.Add("@lieu", SqlDbType.VarChar).Value = TextBox7.Text

        command1.Parameters.Add("@prise", SqlDbType.VarChar).Value = TextBox2.Text

        command1.Parameters.Add("@retour", SqlDbType.VarChar).Value = RichTextBox2.Text


        Dim memstr As New MemoryStream


        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

        command1.Parameters.Add("@img", SqlDbType.Image).Value = memstr.ToArray


        If conn.State = ConnectionState.Closed Then

            conn.Open()


        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("Succes")

        conn.Close()

        bind1()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            TextBox2.Text = DateTimePicker1.Value.ToShortDateString()
            DateTimePicker1.Value = Date.Parse(TextBox2.Text)
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            RichTextBox2.Text = DateTimePicker2.Value.ToShortDateString()
            DateTimePicker2.Value = Date.Parse(RichTextBox2.Text)


        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        TextBox3.Text = DataGridView1.CurrentRow.Cells(1).Value


        Dim img As Byte()

        img = DataGridView1.CurrentRow.Cells(3).Value

        Dim memstr As New MemoryStream(img)

        PictureBox1.Image = Image.FromStream(memstr)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateClientProfile.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (DateTimePicker1.Visible) Then

            DateTimePicker1.Visible = False

        Else

            DateTimePicker1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (DateTimePicker2.Visible) Then

            DateTimePicker2.Visible = False

        Else

            DateTimePicker2.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClientForm.Show()
        Me.Hide()
    End Sub


End Class