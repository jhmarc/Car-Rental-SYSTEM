<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxCar = New System.Windows.Forms.TextBox()
        Me.TextBoxRenter = New System.Windows.Forms.TextBox()
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(106, 258)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(598, 170)
        Me.dgvResults.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Car Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Renter Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "End Date"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(218, 39)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxID.TabIndex = 6
        '
        'TextBoxCar
        '
        Me.TextBoxCar.Location = New System.Drawing.Point(218, 75)
        Me.TextBoxCar.Name = "TextBoxCar"
        Me.TextBoxCar.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxCar.TabIndex = 7
        '
        'TextBoxRenter
        '
        Me.TextBoxRenter.Location = New System.Drawing.Point(218, 117)
        Me.TextBoxRenter.Name = "TextBoxRenter"
        Me.TextBoxRenter.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxRenter.TabIndex = 8
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.Location = New System.Drawing.Point(218, 156)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerStart.TabIndex = 9
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(218, 194)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerEnd.TabIndex = 10
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(485, 65)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(97, 65)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(485, 156)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 58)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(607, 67)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(97, 60)
        Me.btnRead.TabIndex = 13
        Me.btnRead.Text = "READ"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(607, 156)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 58)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(54, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(697, 435)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.DateTimePickerEnd)
        Me.Controls.Add(Me.DateTimePickerStart)
        Me.Controls.Add(Me.TextBoxRenter)
        Me.Controls.Add(Me.TextBoxCar)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxCar As TextBox
    Friend WithEvents TextBoxRenter As TextBox
    Friend WithEvents DateTimePickerStart As DateTimePicker
    Friend WithEvents DateTimePickerEnd As DateTimePicker
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button1 As Button
End Class
