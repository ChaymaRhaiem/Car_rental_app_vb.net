Imports System.Data.SqlClient

Public Class ClientForm

     Dim connection As New SqlConnection

    Dim cmd As New SqlCommand
    Dim conn = New SqlConnection(“Data Source=DESKTOP-660GU2G\SQLEXPRESS;Database = images;Initial Catalog=UserLoginDB;Integrated Security=True”)




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random

        Dim rand As Integer = rnd.Next(10, max + 1)

        Dim i As Integer = 1
        Dim number(max - 1) As Integer



        For i = 0 To max - 1

            If number(i) = rand Then

                rand = rnd.Next(1, max + 1)

                i = -1

            ElseIf number(i) = 0 Then

                number(i) = rand

                rand = rnd.Next(1, max + 1)

                If i = max - 1 Then

                    Exit For

                End If

                i = -1

            End If

        Next

        Timer1.Interval = number(i)

        i += 1

        ChangeImage()

    End Sub

    Private Sub ChangeImage()



        Static Dim iImage1 As Integer



        Select Case iImage1

            Case 0



                PictureBox1.Visible = True

                PictureBox1.Image = My.Resources.mercedes1_png


                iImage1 += 1

            Case 1

                PictureBox1.Visible = True

                PictureBox1.Image = My.Resources.mercedes2_png


                iImage1 += 1

            Case 2



                PictureBox1.Visible = True

                PictureBox1.Image = My.Resources.truck1_png


                iImage1 += 1

            Case 3



                PictureBox1.Visible = True

                PictureBox1.Image = My.Resources.porsche_png


                iImage1 += 1

            Case 4

                PictureBox1.Visible = True

                PictureBox1.Image = My.Resources.range_png


                iImage1 = 0

        End Select
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

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False






    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            TextBox1.Text = DateTimePicker1.Value.ToShortDateString()
            DateTimePicker1.Value = Date.Parse(TextBox1.Text)
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateClientProfile.Show()
        Me.Hide()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        LoginForm.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        catalogue.Show()
        Me.Hide()



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            RichTextBox2.Text = DateTimePicker2.Value.ToShortDateString()
            DateTimePicker2.Value = Date.Parse(RichTextBox2.Text)


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class

