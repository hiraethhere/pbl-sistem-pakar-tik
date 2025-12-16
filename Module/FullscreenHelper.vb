Imports System.Windows.Forms

Public Module FullscreenHelper
    Public Sub SetFullscreen(frm As Form, Optional keepBorder As Boolean = True, Optional hideTaskbar As Boolean = False)
        frm.SuspendLayout()
        Try
            frm.TopMost = If(hideTaskbar, True, False)

            If keepBorder Then
                frm.FormBorderStyle = FormBorderStyle.Sizable
                frm.ControlBox = True
                frm.MinimizeBox = True
                frm.MaximizeBox = True
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.WindowState = FormWindowState.Maximized
            Else
                frm.FormBorderStyle = FormBorderStyle.None
                frm.StartPosition = FormStartPosition.Manual
                frm.WindowState = FormWindowState.Normal
                frm.Bounds = Screen.FromControl(frm).WorkingArea
            End If
        Finally
            frm.ResumeLayout()
        End Try
    End Sub
End Module