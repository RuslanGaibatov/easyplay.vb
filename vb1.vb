Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button10.Text = "Panel_Rot X: " & Button6.Location.X & ", Y:" & Button6.Location.Y
        Button11.Text = "Panel_Gelb X: " & Button7.Location.X & ", Y:" & Button7.Location.Y
        Button12.Text = "Panel_Grün X: " & Button8.Location.X & ", Y:" & Button8.Location.Y
        Button4.Text = "Panel_Blau X: " & Button9.Location.X & ", Y:" & Button9.Location.Y
        Button6.Location = New Point(Button6.Location.X - 3, Button6.Location.Y - 2)
        Button7.Location = New Point(Button7.Location.X + 3, Button7.Location.Y - 2)
        Button8.Location = New Point(Button8.Location.X - 3, Button8.Location.Y + 2)
        Button9.Location = New Point(Button9.Location.X + 3, Button9.Location.Y + 2)
        If Button7.Location.X >= 610 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button10.Text = "Panel_Rot X: " & Button6.Location.X & ", Y:" & Button6.Location.Y
        Button11.Text = "Panel_Gelb X: " & Button7.Location.X & ", Y:" & Button7.Location.Y
        Button12.Text = "Panel_Grün X: " & Button8.Location.X & ", Y:" & Button8.Location.Y
        Button4.Text = "Panel_Blau X: " & Button9.Location.X & ", Y:" & Button9.Location.Y
        Button6.Location = New Point(Button6.Location.X + 3, Button6.Location.Y + 2)
        Button7.Location = New Point(Button7.Location.X - 3, Button7.Location.Y + 2)
        Button8.Location = New Point(Button8.Location.X + 3, Button8.Location.Y - 2)
        Button9.Location = New Point(Button9.Location.X - 3, Button9.Location.Y - 2)
        If Button7.Location.X <= 430 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub
End Class
