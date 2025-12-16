Imports System.Windows.Forms
Imports System.Drawing

Public Module UIStyler
    Public Sub ApplyFullscreenStyling(frm As Form, Optional groupBoxName As String = "GroupBox1")
        FullscreenHelper.SetFullscreen(frm, keepBorder:=True, hideTaskbar:=False)

        frm.BackColor = Color.WhiteSmoke
        frm.Font = New Font("Segoe UI", 10)

        Dim contentControl As Control = Nothing
        Dim gbControls() As Control = frm.Controls.Find(groupBoxName, True)
        If gbControls.Length > 0 Then contentControl = gbControls(0)

        If contentControl Is Nothing Then
            Dim candidates = New String() {"contentPanel", "Panel1", "panelMain", "mainPanel"}
            For Each name In candidates
                Dim found() As Control = frm.Controls.Find(name, True)
                If found.Length > 0 Then
                    contentControl = found(0)
                    Exit For
                End If
            Next
        End If

        If contentControl Is Nothing Then
            For Each c As Control In frm.Controls
                If TypeOf c Is GroupBox OrElse TypeOf c Is Panel Then
                    contentControl = c
                    Exit For
                End If
            Next
        End If

        If contentControl IsNot Nothing Then
            contentControl.Padding = New Padding(12)
            If TypeOf contentControl Is GroupBox Then
                CType(contentControl, GroupBox).Font = New Font("Segoe UI", 11, FontStyle.Bold)
            End If

            contentControl.BackColor = Color.White
            contentControl.Dock = DockStyle.None

            Dim ResizeAndCenter As Action = Sub()
                                                Dim margin As Integer = 120
                                                Dim pctW As Double = 0.75
                                                Dim pctH As Double = 0.72

                                                Dim targetW As Integer = Math.Max(400, CInt(frm.ClientSize.Width * pctW))
                                                Dim targetH As Integer = Math.Max(300, CInt(frm.ClientSize.Height * pctH))
                                                Dim w As Integer = Math.Min(targetW, frm.ClientSize.Width - margin)
                                                Dim h As Integer = Math.Min(targetH, frm.ClientSize.Height - margin)

                                                contentControl.Size = New Size(w, h)
                                                contentControl.Location = New Point((frm.ClientSize.Width - contentControl.Width) \ 2, (frm.ClientSize.Height - contentControl.Height) \ 2)
                                            End Sub
            ResizeAndCenter()

            Dim tagKey As String = "UIStyler_Applied"
            If frm.Tag Is Nothing OrElse Not frm.Tag.ToString().Contains(tagKey) Then
                AddHandler frm.Resize, Sub(s, e) ResizeAndCenter()
                frm.Tag = If(frm.Tag Is Nothing, tagKey, frm.Tag.ToString() & "|" & tagKey)
            End If
        End If

        For Each c As Control In frm.Controls
            If c.Dock = DockStyle.Top Then c.BringToFront()
        Next

        ApplyToChildren(frm.Controls)
    End Sub

    Private Sub ApplyToChildren(ctrls As Control.ControlCollection)
        For Each c As Control In ctrls
            Try
                Select Case True
                    Case TypeOf c Is Button
                        Dim b = DirectCast(c, Button)
                        b.FlatStyle = FlatStyle.Flat
                        b.BackColor = Color.White
                        b.ForeColor = Color.FromArgb(34, 45, 65)
                        b.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 230)
                        b.Padding = New Padding(8, 4, 8, 4)
                    Case TypeOf c Is Label
                        Dim l = DirectCast(c, Label)
                        l.ForeColor = Color.FromArgb(34, 45, 65)
                        If l.Font.Size < 10 Then l.Font = New Font("Segoe UI", 9)
                    Case TypeOf c Is TextBox
                        Dim t = DirectCast(c, TextBox)
                        t.BorderStyle = BorderStyle.FixedSingle
                    Case TypeOf c Is ComboBox
                        Dim cb = DirectCast(c, ComboBox)
                        cb.FlatStyle = FlatStyle.Flat
                    Case TypeOf c Is Panel
                        c.BackColor = Color.Transparent
                End Select
            Catch

            End Try

            If c.HasChildren Then ApplyToChildren(c.Controls)
        Next
    End Sub
End Module