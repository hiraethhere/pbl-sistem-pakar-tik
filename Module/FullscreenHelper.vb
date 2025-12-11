Imports System.Windows.Forms

Public Module FullscreenHelper
    ''' <summary>
    ''' Make a form occupy the screen while optionally keeping the window chrome and taskbar.
    ''' keepBorder:=True preserves title bar and control boxes.
    ''' hideTaskbar:=True will set TopMost (not recommended unless you want to hide the taskbar).
    ''' </summary>
    Public Sub SetFullscreen(frm As Form, Optional keepBorder As Boolean = True, Optional hideTaskbar As Boolean = False)
        frm.SuspendLayout()
        Try
            frm.TopMost = If(hideTaskbar, True, False)

            If keepBorder Then
                ' Keep title bar and control boxes, maximize (respects taskbar)
                frm.FormBorderStyle = FormBorderStyle.Sizable
                frm.ControlBox = True
                frm.MinimizeBox = True
                frm.MaximizeBox = True
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.WindowState = FormWindowState.Maximized
            Else
                ' Borderless fullscreen but keep taskbar visible by using WorkingArea
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