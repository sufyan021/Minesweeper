Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1

    Dim PicArray(20) As PictureBox

    Dim Traps(3) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Text = "Restart"

        For count = 1 To 20

            PicArray(count).Enabled = True

        Next

        Randomize()

        Traps(0) = Int((20 * Rnd()) + 1)

        Traps(1) = Int((20 * Rnd()) + 1)

        Traps(2) = Int((20 * Rnd()) + 1)

        Traps(3) = Int((20 * Rnd()) + 1)

        For count = 1 To 20

            PicArray(count).BackColor = Color.White

        Next

        For count = 1 To 20

            PicArray(count).Cursor = Cursors.Hand

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PicArray(1) = PictureBox1

        PicArray(2) = PictureBox2

        PicArray(3) = PictureBox3

        PicArray(4) = PictureBox4

        PicArray(5) = PictureBox5

        PicArray(6) = PictureBox6

        PicArray(7) = PictureBox7

        PicArray(8) = PictureBox8

        PicArray(9) = PictureBox9

        PicArray(10) = PictureBox10

        PicArray(11) = PictureBox11

        PicArray(12) = PictureBox12

        PicArray(13) = PictureBox13

        PicArray(14) = PictureBox14

        PicArray(15) = PictureBox15

        PicArray(16) = PictureBox16

        PicArray(17) = PictureBox17

        PicArray(18) = PictureBox18

        PicArray(19) = PictureBox19

        PicArray(20) = PictureBox20

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        For count = 1 To 1

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        For count = 2 To 2

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        For count = 3 To 3

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        For count = 4 To 4

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        For count = 5 To 5

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        For count = 6 To 6

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        For count = 7 To 7

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        For count = 8 To 8

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        For count = 9 To 9

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        For count = 10 To 10

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        For count = 11 To 11

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        For count = 12 To 12

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        For count = 13 To 13

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

        For count = 14 To 14

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

        For count = 15 To 15

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

        For count = 16 To 16

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

        For count = 17 To 17

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

        For count = 18 To 18

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click

        For count = 19 To 19

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

        For count = 20 To 20

            If count = Traps(0) Then

                PicArray(count).BackColor = Color.Gray

            Else

                If count = Traps(1) Then

                    PicArray(count).BackColor = Color.Gray

                Else

                    If count = Traps(2) Then

                        PicArray(count).BackColor = Color.Gray

                    Else

                        If count = Traps(3) Then

                            PicArray(count).BackColor = Color.Gray

                        Else

                            PicArray(count).BackColor = Color.LimeGreen

                        End If

                    End If

                End If

            End If

        Next

    End Sub

End Class
