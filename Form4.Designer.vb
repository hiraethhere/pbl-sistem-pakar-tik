<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnMulai = New Button()
        btnKeluar = New Button()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(435, 29)
        Label1.TabIndex = 0
        Label1.Text = "Sistem Pakar Profil Lulusan TIK"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnMulai
        ' 
        btnMulai.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnMulai.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnMulai.Cursor = Cursors.Hand
        btnMulai.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMulai.Location = New Point(0, 74)
        btnMulai.Margin = New Padding(0)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(447, 33)
        btnMulai.TabIndex = 1
        btnMulai.Text = "Mulai"
        btnMulai.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = SystemColors.ControlLight
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = SystemColors.ControlDarkDark
        btnKeluar.Location = New Point(207, 213)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(126, 31)
        btnKeluar.TabIndex = 1
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(3, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(435, 22)
        Label2.TabIndex = 0
        Label2.Text = "Tentukan Jalur Karir Terbaik Anda dengan Sistem Pakar"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 54.5454559F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45.4545441F))
        TableLayoutPanel1.Size = New Size(441, 54)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(btnMulai, 0, 1)
        TableLayoutPanel2.Location = New Point(47, 73)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(447, 121)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(534, 291)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(btnKeluar)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
