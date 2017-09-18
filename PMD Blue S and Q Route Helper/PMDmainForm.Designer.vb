<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMDmainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PMDmainForm))
        Me.lblStaticDungeon = New System.Windows.Forms.Label()
        Me.lblDungeon = New System.Windows.Forms.Label()
        Me.lblStaticFloor = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.btnPreviousFloor = New System.Windows.Forms.Button()
        Me.btnNextFloor = New System.Windows.Forms.Button()
        Me.lblStaticNotes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxDungeon = New System.Windows.Forms.ComboBox()
        Me.lblManual = New System.Windows.Forms.Label()
        Me.cboxFloor = New System.Windows.Forms.ComboBox()
        Me.btnPreviousDungeon = New System.Windows.Forms.Button()
        Me.btnNextDungeon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxhiddenDungeonSelected = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picBoxDungeon = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxDungeon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStaticDungeon
        '
        Me.lblStaticDungeon.AutoSize = True
        Me.lblStaticDungeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticDungeon.Location = New System.Drawing.Point(12, 451)
        Me.lblStaticDungeon.Name = "lblStaticDungeon"
        Me.lblStaticDungeon.Size = New System.Drawing.Size(102, 24)
        Me.lblStaticDungeon.TabIndex = 1
        Me.lblStaticDungeon.Text = "Dungeon:"
        '
        'lblDungeon
        '
        Me.lblDungeon.AutoSize = True
        Me.lblDungeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDungeon.Location = New System.Drawing.Point(120, 451)
        Me.lblDungeon.Name = "lblDungeon"
        Me.lblDungeon.Size = New System.Drawing.Size(121, 24)
        Me.lblDungeon.TabIndex = 2
        Me.lblDungeon.Text = "Tiny Woods"
        '
        'lblStaticFloor
        '
        Me.lblStaticFloor.AutoSize = True
        Me.lblStaticFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticFloor.Location = New System.Drawing.Point(373, 451)
        Me.lblStaticFloor.Name = "lblStaticFloor"
        Me.lblStaticFloor.Size = New System.Drawing.Size(65, 24)
        Me.lblStaticFloor.TabIndex = 3
        Me.lblStaticFloor.Text = "Floor:"
        '
        'lblFloor
        '
        Me.lblFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.Location = New System.Drawing.Point(444, 456)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(128, 55)
        Me.lblFloor.TabIndex = 4
        Me.lblFloor.Text = "1F"
        Me.lblFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPreviousFloor
        '
        Me.btnPreviousFloor.Location = New System.Drawing.Point(444, 511)
        Me.btnPreviousFloor.Name = "btnPreviousFloor"
        Me.btnPreviousFloor.Size = New System.Drawing.Size(61, 33)
        Me.btnPreviousFloor.TabIndex = 5
        Me.btnPreviousFloor.Text = "Previous"
        Me.btnPreviousFloor.UseVisualStyleBackColor = True
        '
        'btnNextFloor
        '
        Me.btnNextFloor.Location = New System.Drawing.Point(511, 511)
        Me.btnNextFloor.Name = "btnNextFloor"
        Me.btnNextFloor.Size = New System.Drawing.Size(61, 33)
        Me.btnNextFloor.TabIndex = 6
        Me.btnNextFloor.Text = "Next"
        Me.btnNextFloor.UseVisualStyleBackColor = True
        '
        'lblStaticNotes
        '
        Me.lblStaticNotes.AutoSize = True
        Me.lblStaticNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticNotes.Location = New System.Drawing.Point(272, 511)
        Me.lblStaticNotes.Name = "lblStaticNotes"
        Me.lblStaticNotes.Size = New System.Drawing.Size(48, 15)
        Me.lblStaticNotes.TabIndex = 7
        Me.lblStaticNotes.Text = "Notes:"
        Me.lblStaticNotes.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(272, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Something stupid you should have memorized"
        Me.Label1.Visible = False
        '
        'cboxDungeon
        '
        Me.cboxDungeon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDungeon.FormattingEnabled = True
        Me.cboxDungeon.Location = New System.Drawing.Point(124, 516)
        Me.cboxDungeon.Name = "cboxDungeon"
        Me.cboxDungeon.Size = New System.Drawing.Size(120, 21)
        Me.cboxDungeon.TabIndex = 9
        '
        'lblManual
        '
        Me.lblManual.AutoSize = True
        Me.lblManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManual.Location = New System.Drawing.Point(12, 513)
        Me.lblManual.Name = "lblManual"
        Me.lblManual.Size = New System.Drawing.Size(84, 24)
        Me.lblManual.TabIndex = 10
        Me.lblManual.Text = "Manual:"
        '
        'cboxFloor
        '
        Me.cboxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFloor.FormattingEnabled = True
        Me.cboxFloor.Location = New System.Drawing.Point(195, 546)
        Me.cboxFloor.Name = "cboxFloor"
        Me.cboxFloor.Size = New System.Drawing.Size(49, 21)
        Me.cboxFloor.TabIndex = 11
        '
        'btnPreviousDungeon
        '
        Me.btnPreviousDungeon.Location = New System.Drawing.Point(124, 477)
        Me.btnPreviousDungeon.Name = "btnPreviousDungeon"
        Me.btnPreviousDungeon.Size = New System.Drawing.Size(57, 24)
        Me.btnPreviousDungeon.TabIndex = 12
        Me.btnPreviousDungeon.Text = "Previous"
        Me.btnPreviousDungeon.UseVisualStyleBackColor = True
        '
        'btnNextDungeon
        '
        Me.btnNextDungeon.Location = New System.Drawing.Point(187, 477)
        Me.btnNextDungeon.Name = "btnNextDungeon"
        Me.btnNextDungeon.Size = New System.Drawing.Size(57, 24)
        Me.btnNextDungeon.TabIndex = 13
        Me.btnNextDungeon.Text = "Next"
        Me.btnNextDungeon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 543)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Floor Selection:"
        '
        'cboxhiddenDungeonSelected
        '
        Me.cboxhiddenDungeonSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxhiddenDungeonSelected.FormattingEnabled = True
        Me.cboxhiddenDungeonSelected.Location = New System.Drawing.Point(250, 477)
        Me.cboxhiddenDungeonSelected.Name = "cboxhiddenDungeonSelected"
        Me.cboxhiddenDungeonSelected.Size = New System.Drawing.Size(17, 21)
        Me.cboxhiddenDungeonSelected.TabIndex = 15
        Me.cboxhiddenDungeonSelected.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 558)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Program made by SirPudge"
        '
        'picBoxDungeon
        '
        Me.picBoxDungeon.Image = Global.PMD_Blue_S_and_Q_Route_Helper.My.Resources.Resources.Tiny_Woods__1F
        Me.picBoxDungeon.Location = New System.Drawing.Point(12, 12)
        Me.picBoxDungeon.Name = "picBoxDungeon"
        Me.picBoxDungeon.Size = New System.Drawing.Size(560, 436)
        Me.picBoxDungeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxDungeon.TabIndex = 0
        Me.picBoxDungeon.TabStop = False
        '
        'PMDmainForm
        '
        Me.AcceptButton = Me.btnNextFloor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 580)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxhiddenDungeonSelected)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNextDungeon)
        Me.Controls.Add(Me.btnPreviousDungeon)
        Me.Controls.Add(Me.cboxFloor)
        Me.Controls.Add(Me.lblManual)
        Me.Controls.Add(Me.cboxDungeon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStaticNotes)
        Me.Controls.Add(Me.btnNextFloor)
        Me.Controls.Add(Me.btnPreviousFloor)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.lblStaticFloor)
        Me.Controls.Add(Me.lblDungeon)
        Me.Controls.Add(Me.lblStaticDungeon)
        Me.Controls.Add(Me.picBoxDungeon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PMDmainForm"
        Me.Text = "PMD Blue S and Q Route Helper"
        CType(Me.picBoxDungeon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxDungeon As PictureBox
    Friend WithEvents lblStaticDungeon As Label
    Friend WithEvents lblDungeon As Label
    Friend WithEvents lblStaticFloor As Label
    Friend WithEvents lblFloor As Label
    Friend WithEvents btnPreviousFloor As Button
    Friend WithEvents btnNextFloor As Button
    Friend WithEvents lblStaticNotes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxDungeon As ComboBox
    Friend WithEvents lblManual As Label
    Friend WithEvents cboxFloor As ComboBox
    Friend WithEvents btnPreviousDungeon As Button
    Friend WithEvents btnNextDungeon As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxhiddenDungeonSelected As ComboBox
    Friend WithEvents Label3 As Label
End Class
