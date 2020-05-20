Imports Transitions

Public Class Form1

    Dim X, Y As Integer
    Dim newPoint As New System.Drawing.Point
    Dim c As Integer = 1
    Dim btnA As Boolean

    Dim num1 As Integer
    Dim num2 As Integer


    Private Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr)
    Private Sub PerformMouseClick(ByVal LClick_RClick_DClick As String)
        Const MOUSEEVENTF_LEFTDOWN As Integer = 2
        Const MOUSEEVENTF_LEFTUP As Integer = 4
        Const MOUSEEVENTF_RIGHTDOWN As Integer = 6
        Const MOUSEEVENTF_RIGHTUP As Integer = 8
        If LClick_RClick_DClick = "RClick" Then
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "LClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "DClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Transition.run(btnActive, "BaseColor1", Color.FromArgb(86, 204, 242), New TransitionType_EaseInEaseOut(1000))
        Transition.run(btnActive, "BaseColor2", Color.FromArgb(47, 128, 237), New TransitionType_EaseInEaseOut(1000))
        Transition.run(btnActive, "OnHoverBaseColor1", Color.FromArgb(62, 150, 179), New TransitionType_EaseInEaseOut(1000))
        Transition.run(btnActive, "OnHoverBaseColor2", Color.FromArgb(35, 98, 184), New TransitionType_EaseInEaseOut(1000))
        Transition.run(btnActive, "ForeColor", Color.FromArgb(255, 255, 255), New TransitionType_EaseInEaseOut(1000))
        Transition.run(StayAvail, "Top", 130, New TransitionType_EaseInEaseOut(1500))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transition.run(lblArsh, "ForeColor", Color.FromArgb(255, 255, 255), New TransitionType_EaseInEaseOut(1500))
    End Sub

    Private Sub btnActive_Click(sender As Object, e As EventArgs) Handles btnActive.Click
        If btnA = False Then
            Timer.Start()
            Transition.run(btnActive, "BaseColor1", Color.FromArgb(255, 81, 47), New TransitionType_EaseInEaseOut(100))
            Transition.run(btnActive, "BaseColor2", Color.FromArgb(221, 36, 118), New TransitionType_EaseInEaseOut(100))
            Transition.run(btnActive, "OnHoverBaseColor1", Color.FromArgb(212, 66, 38), New TransitionType_EaseInEaseOut(500))
            Transition.run(btnActive, "OnHoverBaseColor2", Color.FromArgb(184, 29, 98), New TransitionType_EaseInEaseOut(500))
            Transition.run(StayAvail, "ForeColor", Color.FromArgb(244, 76, 70), New TransitionType_EaseInEaseOut(500))
            Transition.run(btnActive, "Text", "Deactivate", New TransitionType_EaseInEaseOut(500))
            btnA = True
        ElseIf btnA = True Then
            btnA = False
            Transition.run(btnActive, "BaseColor1", Color.FromArgb(86, 204, 242), New TransitionType_EaseInEaseOut(100))
            Transition.run(btnActive, "BaseColor2", Color.FromArgb(47, 128, 237), New TransitionType_EaseInEaseOut(100))
            Transition.run(btnActive, "OnHoverBaseColor1", Color.FromArgb(62, 150, 179), New TransitionType_EaseInEaseOut(500))
            Transition.run(btnActive, "OnHoverBaseColor2", Color.FromArgb(35, 98, 184), New TransitionType_EaseInEaseOut(500))
            Transition.run(StayAvail, "ForeColor", Color.FromArgb(0, 193, 255), New TransitionType_EaseInEaseOut(500))
            Transition.run(btnActive, "Text", "Activate", New TransitionType_EaseInEaseOut(500))

        End If

    End Sub

    Private Sub btnMinimise_Click(sender As Object, e As EventArgs) Handles btnMinimise.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GunaPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles GunaPanel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub



    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If btnA = True Then
            If c = 1 Then
                Dim rnd As New Random
                Dim s As Integer = rnd.Next(1, Screen.PrimaryScreen.Bounds.Size.Width)
                Dim p As Integer = rnd.Next(1, Screen.PrimaryScreen.Bounds.Size.Height)

                Me.Cursor.Position = New Point(s, p)
                c = 2
            ElseIf c = 2 Then
                Dim p As Integer
                p = Me.Location.Y

                Me.Cursor.Position = New Point(Screen.PrimaryScreen.Bounds.Size.Width / 2, p * 1.25)
                PerformMouseClick("LClick")
                c = 1
            End If
        End If




    End Sub

    Private Sub GunaPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles GunaPanel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X -= (X)
            newPoint.Y -= (Y)
            Me.Location = newPoint
        End If
    End Sub



End Class
