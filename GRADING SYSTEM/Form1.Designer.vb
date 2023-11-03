<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DwdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtStNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMidScore = New System.Windows.Forms.TextBox()
        Me.txtFinScore = New System.Windows.Forms.TextBox()
        Me.txtFinalMark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbListStudents = New System.Windows.Forms.RadioButton()
        Me.rbDetailedList = New System.Windows.Forms.RadioButton()
        Me.rbPassOrFail = New System.Windows.Forms.RadioButton()
        Me.rbNumPassed = New System.Windows.Forms.RadioButton()
        Me.rbNumFailed = New System.Windows.Forms.RadioButton()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lstboxReport = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DwdToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 28)
        '
        'DwdToolStripMenuItem
        '
        Me.DwdToolStripMenuItem.Name = "DwdToolStripMenuItem"
        Me.DwdToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.DwdToolStripMenuItem.Text = "dwd"
        '
        'txtStNumber
        '
        Me.txtStNumber.Location = New System.Drawing.Point(124, 46)
        Me.txtStNumber.Name = "txtStNumber"
        Me.txtStNumber.Size = New System.Drawing.Size(247, 22)
        Me.txtStNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number:"
        '
        'txtStName
        '
        Me.txtStName.Location = New System.Drawing.Point(124, 85)
        Me.txtStName.Name = "txtStName"
        Me.txtStName.Size = New System.Drawing.Size(247, 22)
        Me.txtStName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Student Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Midterm Grade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Final Ex. Grade :"
        '
        'txtMidScore
        '
        Me.txtMidScore.Location = New System.Drawing.Point(124, 128)
        Me.txtMidScore.Name = "txtMidScore"
        Me.txtMidScore.Size = New System.Drawing.Size(247, 22)
        Me.txtMidScore.TabIndex = 7
        '
        'txtFinScore
        '
        Me.txtFinScore.Location = New System.Drawing.Point(120, 176)
        Me.txtFinScore.Name = "txtFinScore"
        Me.txtFinScore.Size = New System.Drawing.Size(251, 22)
        Me.txtFinScore.TabIndex = 8
        '
        'txtFinalMark
        '
        Me.txtFinalMark.Location = New System.Drawing.Point(120, 219)
        Me.txtFinalMark.Name = "txtFinalMark"
        Me.txtFinalMark.ReadOnly = True
        Me.txtFinalMark.Size = New System.Drawing.Size(247, 22)
        Me.txtFinalMark.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Final Mark:"
        '
        'rbListStudents
        '
        Me.rbListStudents.AutoSize = True
        Me.rbListStudents.Location = New System.Drawing.Point(8, 323)
        Me.rbListStudents.Name = "rbListStudents"
        Me.rbListStudents.Size = New System.Drawing.Size(99, 20)
        Me.rbListStudents.TabIndex = 11
        Me.rbListStudents.TabStop = True
        Me.rbListStudents.Text = "Student List "
        Me.rbListStudents.UseVisualStyleBackColor = True
        '
        'rbDetailedList
        '
        Me.rbDetailedList.AutoSize = True
        Me.rbDetailedList.Location = New System.Drawing.Point(119, 323)
        Me.rbDetailedList.Name = "rbDetailedList"
        Me.rbDetailedList.Size = New System.Drawing.Size(150, 20)
        Me.rbDetailedList.TabIndex = 12
        Me.rbDetailedList.TabStop = True
        Me.rbDetailedList.Text = "Detailed Student List"
        Me.rbDetailedList.UseVisualStyleBackColor = True
        '
        'rbPassOrFail
        '
        Me.rbPassOrFail.AutoSize = True
        Me.rbPassOrFail.Location = New System.Drawing.Point(284, 323)
        Me.rbPassOrFail.Name = "rbPassOrFail"
        Me.rbPassOrFail.Size = New System.Drawing.Size(136, 20)
        Me.rbPassOrFail.TabIndex = 13
        Me.rbPassOrFail.TabStop = True
        Me.rbPassOrFail.Text = "Student Status List"
        Me.rbPassOrFail.UseVisualStyleBackColor = True
        '
        'rbNumPassed
        '
        Me.rbNumPassed.AutoSize = True
        Me.rbNumPassed.Location = New System.Drawing.Point(437, 323)
        Me.rbNumPassed.Name = "rbNumPassed"
        Me.rbNumPassed.Size = New System.Drawing.Size(197, 20)
        Me.rbNumPassed.TabIndex = 14
        Me.rbNumPassed.TabStop = True
        Me.rbNumPassed.Text = "Number of Students Passing"
        Me.rbNumPassed.UseVisualStyleBackColor = True
        '
        'rbNumFailed
        '
        Me.rbNumFailed.AutoSize = True
        Me.rbNumFailed.Location = New System.Drawing.Point(649, 323)
        Me.rbNumFailed.Name = "rbNumFailed"
        Me.rbNumFailed.Size = New System.Drawing.Size(213, 20)
        Me.rbNumFailed.TabIndex = 15
        Me.rbNumFailed.TabStop = True
        Me.rbNumFailed.Text = "Number of Students Remaining"
        Me.rbNumFailed.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(26, 261)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(155, 30)
        Me.btnAddStudent.TabIndex = 16
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(198, 261)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(196, 31)
        Me.btnGenerateReport.TabIndex = 17
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(12, 9)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 18
        '
        'lstboxReport
        '
        Me.lstboxReport.FormattingEnabled = True
        Me.lstboxReport.ItemHeight = 16
        Me.lstboxReport.Location = New System.Drawing.Point(394, 29)
        Me.lstboxReport.Name = "lstboxReport"
        Me.lstboxReport.Size = New System.Drawing.Size(468, 212)
        Me.lstboxReport.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 379)
        Me.Controls.Add(Me.lstboxReport)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.rbNumFailed)
        Me.Controls.Add(Me.rbNumPassed)
        Me.Controls.Add(Me.rbPassOrFail)
        Me.Controls.Add(Me.rbDetailedList)
        Me.Controls.Add(Me.rbListStudents)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFinalMark)
        Me.Controls.Add(Me.txtFinScore)
        Me.Controls.Add(Me.txtMidScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DwdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtStNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMidScore As TextBox
    Friend WithEvents txtFinScore As TextBox
    Friend WithEvents txtFinalMark As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbListStudents As RadioButton
    Friend WithEvents rbDetailedList As RadioButton
    Friend WithEvents rbPassOrFail As RadioButton
    Friend WithEvents rbNumPassed As RadioButton
    Friend WithEvents rbNumFailed As RadioButton
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lstboxReport As ListBox
End Class
