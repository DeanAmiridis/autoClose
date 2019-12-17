Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Locks both Time & Proc Textbox's
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Disables lock for both Time & Proc Textbox's
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Pulls current time for Label4
        ' Label4.Text = DateTime.Now.ToString("HH:mm")

        Dim TimeNow As String
        TimeNow = TimeOfDay.ToString("h:mm tt")
        Label4.Text = TimeNow

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Disables all textbox's
        ' Enables countdown for autoClose to run at specific time.

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' ** CORE FUNCTION **
        ' 
        ' If the time in Label4 matches what is in Textbox2, then Proc (Textbox1) will initiate autoClose to terminate the process

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
        ' Cancells core function -- resets to NULL.

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Timer2.Enabled = False

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Height = 576
        GroupBox3.Visible = True
        Button6.Enabled = False
        Button5.Enabled = True


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Height = 211
        GroupBox3.Visible = False
        Button5.Enabled = False
        Button6.Enabled = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()

        For Each OneProcess As Process In Process.GetProcesses
            ListBox1.Items.Add(OneProcess.ProcessName)
        Next

    End Sub
End Class
