Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Just a simple tool to auto kill a process, at any given time. Enjoy!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If TextBox2.Text = Label4.Text Then
            Try
                Dim Xcel() As Process = Process.GetProcessesByName(TextBox1.Text)
                For Each Process As Process In Xcel
                    Process.Kill()
                Next
            Catch ex As Exception
            End Try
        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Timer2.Enabled = False

    End Sub
End Class
