<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataDiri
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        txtProdi = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnLanjut = New Button()
        lblTitle = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtNama.Location = New Point(3, 25)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(340, 23)
        txtNama.TabIndex = 0
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(3, 25)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(340, 23)
        txtNIM.TabIndex = 0
        ' 
        ' txtProdi
        ' 
        txtProdi.Location = New Point(3, 25)
        txtProdi.Name = "txtProdi"
        txtProdi.Size = New Size(340, 23)
        txtProdi.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 22)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 22)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 22)
        Label3.TabIndex = 1
        Label3.Text = "Prodi"
        ' 
        ' btnLanjut
        ' 
        btnLanjut.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnLanjut.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnLanjut.Cursor = Cursors.Hand
        btnLanjut.FlatStyle = FlatStyle.Popup
        btnLanjut.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = SystemColors.ControlText
        btnLanjut.Location = New Point(3, 3)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(340, 32)
        btnLanjut.TabIndex = 2
        btnLanjut.Text = "Lanjut"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(173, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(155, 34)
        lblTitle.TabIndex = 5
        lblTitle.Text = "Form Data Diri"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.BackColor = SystemColors.Control
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(txtNama)
        FlowLayoutPanel2.Location = New Point(3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(349, 53)
        FlowLayoutPanel2.TabIndex = 6
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = SystemColors.Control
        FlowLayoutPanel3.Controls.Add(Label2)
        FlowLayoutPanel3.Controls.Add(txtNIM)
        FlowLayoutPanel3.Location = New Point(3, 62)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(347, 53)
        FlowLayoutPanel3.TabIndex = 7
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.BackColor = SystemColors.Control
        FlowLayoutPanel4.Controls.Add(Label3)
        FlowLayoutPanel4.Controls.Add(txtProdi)
        FlowLayoutPanel4.Location = New Point(3, 121)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(347, 53)
        FlowLayoutPanel4.TabIndex = 8
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.Control
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 0, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel4, 0, 2)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel5, 0, 3)
        TableLayoutPanel1.Location = New Point(73, 78)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 27.7777786F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 27.7777786F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 27.7777786F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(355, 215)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel5.BackColor = SystemColors.Control
        FlowLayoutPanel5.Controls.Add(btnLanjut)
        FlowLayoutPanel5.Location = New Point(3, 180)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(349, 32)
        FlowLayoutPanel5.TabIndex = 8
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Location = New Point(63, 66)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(374, 239)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' FormDataDiri
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(514, 328)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblTitle)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormDataDiri"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormDataDiri"
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLanjut As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel

End Class
