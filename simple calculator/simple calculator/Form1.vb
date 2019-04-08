Public Class Form1

    Private a As Double
    Private b As Single
    Private c As Single
    Private k As Single
    Private g As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
        RadioButton1.Checked = False
        k = 0
        a = 0
        g = 1

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = False Then
            TextBox1.Enabled = False
            RadioButton1.Checked = False


        Else
            TextBox1.Enabled = True
            RadioButton1.Checked = True



        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        c = 1
        If (TextBox1.Text = "") Then
            a = Val(TextBox1.Text)
            TextBox1.Text = ""
        Else
            If k = 0 Then
                a = a + Val(TextBox1.Text)
                TextBox1.Text = ""
            Else
                a = Val(TextBox1.Text)
                k = 0
                TextBox1.Text = ""
            End If


        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        c = 2
        If (TextBox1.Text = "") Then
            a = Val(TextBox1.Text)
            TextBox1.Text = ""
        Else
            If k = 0 Then
                a = a - Val(TextBox1.Text)
                TextBox1.Text = ""
            Else
                a = Val(TextBox1.Text)
                k = 0
                TextBox1.Text = ""
            End If
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        c = 3
        If (TextBox1.Text = "") Then
            g = Val(TextBox1.Text)
            TextBox1.Text = ""
        Else
            If k = 0 Then
                g = g * Val(TextBox1.Text)
                TextBox1.Text = ""
            Else
                g = Val(TextBox1.Text)
                k = 0
                TextBox1.Text = ""
            End If
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        c = 4
        If (TextBox1.Text = "") Then
            g = Val(TextBox1.Text)
            TextBox1.Text = ""
        Else
            If k = 0 Then
                g = g / Val(TextBox1.Text)
                TextBox1.Text = ""
            Else
                g = Val(TextBox1.Text)
                k = 0
                TextBox1.Text = ""

            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        b = Val(TextBox1.Text)

        If c = 1 Then
            TextBox1.Text = a + b
            k = 1
        ElseIf c = 2 Then
            TextBox1.Text = a - b
            k = 1
        ElseIf c = 3 Then
            TextBox1.Text = g * b
            k = 1
        ElseIf c = 4 Then
            TextBox1.Text = g / b
            k = 1
        Else
            TextBox1.Text = "INVALID"
        End If
    End Sub
End Class
