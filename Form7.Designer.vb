<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardDosen
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
        NamaTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NIMTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        DataGridView = New DataGridView()
        ProdiComboBox = New ComboBox()
        Label4 = New Label()
        RoleComboBox = New ComboBox()
        Label5 = New Label()
        LogOutButton = New Button()
        TambahButton = New Button()
        EditButton = New Button()
        HapusButton = New Button()
        ClearButton = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label6 = New Label()
        TableLayoutPanel8 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        CekHasilButton = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Location = New Point(13, 17)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(172, 22)
        NamaTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 14)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 14)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 14)
        Label3.TabIndex = 3
        Label3.Text = "Prodi"
        ' 
        ' NIMTextBox
        ' 
        NIMTextBox.Location = New Point(13, 17)
        NIMTextBox.Name = "NIMTextBox"
        NIMTextBox.Size = New Size(172, 22)
        NIMTextBox.TabIndex = 4
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(13, 17)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(172, 22)
        PasswordTextBox.TabIndex = 5
        ' 
        ' DataGridView
        ' 
        DataGridView.BackgroundColor = Color.AliceBlue
        DataGridView.BorderStyle = BorderStyle.Fixed3D
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(220, 9)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 45
        DataGridView.Size = New Size(564, 331)
        DataGridView.TabIndex = 6
        ' 
        ' ProdiComboBox
        ' 
        ProdiComboBox.FormattingEnabled = True
        ProdiComboBox.Location = New Point(13, 17)
        ProdiComboBox.Name = "ProdiComboBox"
        ProdiComboBox.Size = New Size(172, 22)
        ProdiComboBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 14)
        Label4.TabIndex = 8
        Label4.Text = "Role"
        ' 
        ' RoleComboBox
        ' 
        RoleComboBox.FormattingEnabled = True
        RoleComboBox.Location = New Point(13, 17)
        RoleComboBox.Name = "RoleComboBox"
        RoleComboBox.Size = New Size(172, 22)
        RoleComboBox.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 14)
        Label5.TabIndex = 10
        Label5.Text = "Password"
        ' 
        ' LogOutButton
        ' 
        LogOutButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LogOutButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        LogOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        LogOutButton.FlatAppearance.MouseOverBackColor = Color.Maroon
        LogOutButton.FlatStyle = FlatStyle.Flat
        LogOutButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutButton.ForeColor = Color.White
        LogOutButton.Location = New Point(6, 413)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(202, 23)
        LogOutButton.TabIndex = 11
        LogOutButton.Text = "Logout"
        LogOutButton.UseVisualStyleBackColor = False
        ' 
        ' TambahButton
        ' 
        TambahButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        TambahButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        TambahButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        TambahButton.FlatAppearance.MouseOverBackColor = Color.Lime
        TambahButton.FlatStyle = FlatStyle.Flat
        TambahButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TambahButton.Location = New Point(356, 346)
        TambahButton.Name = "TambahButton"
        TambahButton.Size = New Size(126, 22)
        TambahButton.TabIndex = 12
        TambahButton.Text = "Tambah"
        TambahButton.UseVisualStyleBackColor = False
        ' 
        ' EditButton
        ' 
        EditButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        EditButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        EditButton.FlatAppearance.BorderColor = Color.Navy
        EditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        EditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        EditButton.FlatStyle = FlatStyle.Flat
        EditButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditButton.Location = New Point(3, 3)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(196, 21)
        EditButton.TabIndex = 13
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = False
        ' 
        ' HapusButton
        ' 
        HapusButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        HapusButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        HapusButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        HapusButton.FlatAppearance.MouseOverBackColor = Color.Maroon
        HapusButton.FlatStyle = FlatStyle.Flat
        HapusButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HapusButton.ForeColor = Color.White
        HapusButton.Location = New Point(3, 30)
        HapusButton.Name = "HapusButton"
        HapusButton.Size = New Size(196, 22)
        HapusButton.TabIndex = 14
        HapusButton.Text = "Hapus"
        HapusButton.UseVisualStyleBackColor = False
        ' 
        ' ClearButton
        ' 
        ClearButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearButton.Location = New Point(220, 380)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(130, 22)
        ClearButton.TabIndex = 15
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(NIMTextBox)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(6, 43)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10, 0, 0, 0)
        FlowLayoutPanel1.Size = New Size(202, 49)
        FlowLayoutPanel1.TabIndex = 16
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(NamaTextBox)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(6, 102)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Padding = New Padding(10, 0, 0, 0)
        FlowLayoutPanel2.Size = New Size(202, 48)
        FlowLayoutPanel2.TabIndex = 17
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label3)
        FlowLayoutPanel3.Controls.Add(ProdiComboBox)
        FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel3.Location = New Point(6, 161)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Padding = New Padding(10, 0, 0, 0)
        FlowLayoutPanel3.Size = New Size(202, 49)
        FlowLayoutPanel3.TabIndex = 18
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Label4)
        FlowLayoutPanel4.Controls.Add(RoleComboBox)
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(6, 220)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Padding = New Padding(10, 0, 0, 0)
        FlowLayoutPanel4.Size = New Size(202, 47)
        FlowLayoutPanel4.TabIndex = 19
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Controls.Add(Label5)
        FlowLayoutPanel5.Controls.Add(PasswordTextBox)
        FlowLayoutPanel5.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel5.Location = New Point(6, 279)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Padding = New Padding(10, 0, 0, 0)
        FlowLayoutPanel5.Size = New Size(202, 50)
        FlowLayoutPanel5.TabIndex = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(LogOutButton, 0, 7)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 6)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel5, 0, 5)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel4, 0, 4)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 0, 3)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 0, 2)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label6, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.328246F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.6260576F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.6260576F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.6260576F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.6260576F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.6260576F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.8207893F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.720677F))
        TableLayoutPanel1.Size = New Size(214, 442)
        TableLayoutPanel1.TabIndex = 21
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(EditButton, 0, 0)
        TableLayoutPanel2.Controls.Add(HapusButton, 0, 1)
        TableLayoutPanel2.Location = New Point(6, 338)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(202, 55)
        TableLayoutPanel2.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(202, 19)
        Label6.TabIndex = 23
        Label6.Text = "Data Mahasiswa"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.SkyBlue
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Location = New Point(729, 353)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 61F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 39F))
        TableLayoutPanel8.Size = New Size(108, 100)
        TableLayoutPanel8.TabIndex = 25
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.PowderBlue
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Location = New Point(368, 325)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(556, 117)
        TableLayoutPanel4.TabIndex = 22
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.DeepSkyBlue
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Location = New Point(254, 380)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(354, 119)
        TableLayoutPanel5.TabIndex = 23
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.CadetBlue
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Location = New Point(535, 119)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(334, 186)
        TableLayoutPanel6.TabIndex = 24
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.DeepSkyBlue
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Location = New Point(383, -31)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(556, 117)
        TableLayoutPanel3.TabIndex = 22
        ' 
        ' CekHasilButton
        ' 
        CekHasilButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        CekHasilButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        CekHasilButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        CekHasilButton.FlatAppearance.MouseOverBackColor = Color.Lime
        CekHasilButton.FlatStyle = FlatStyle.Flat
        CekHasilButton.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CekHasilButton.Location = New Point(220, 346)
        CekHasilButton.Name = "CekHasilButton"
        CekHasilButton.Size = New Size(126, 22)
        CekHasilButton.TabIndex = 13
        CekHasilButton.Text = "Cek Hasil"
        CekHasilButton.UseVisualStyleBackColor = False
        ' 
        ' DashboardDosen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(790, 442)
        Controls.Add(ClearButton)
        Controls.Add(CekHasilButton)
        Controls.Add(TableLayoutPanel8)
        Controls.Add(TambahButton)
        Controls.Add(DataGridView)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel5)
        MaximizeBox = False
        Name = "DashboardDosen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Dosen"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ProdiComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RoleComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogOutButton As Button
    Friend WithEvents TambahButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents HapusButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CekHasilButton As Button
End Class
