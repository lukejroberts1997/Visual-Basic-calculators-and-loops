<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.btngrade = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(50, 18)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(174, 25)
        Me.lblgrade.TabIndex = 0
        Me.lblgrade.Text = "Grade Calculator"
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(80, 81)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(101, 13)
        Me.lblinfo.TabIndex = 1
        Me.lblinfo.Text = "Enter Numeric Mark"
        '
        'txtgrade
        '
        Me.txtgrade.Location = New System.Drawing.Point(83, 113)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(100, 20)
        Me.txtgrade.TabIndex = 2
        '
        'btngrade
        '
        Me.btngrade.Location = New System.Drawing.Point(83, 163)
        Me.btngrade.Name = "btngrade"
        Me.btngrade.Size = New System.Drawing.Size(98, 23)
        Me.btngrade.TabIndex = 3
        Me.btngrade.Text = "Calculate"
        Me.btngrade.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(81, 212)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btngrade)
        Me.Controls.Add(Me.txtgrade)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.lblgrade)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblgrade As Label
    Friend WithEvents lblinfo As Label
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btngrade As Button
    Friend WithEvents txtanswer As TextBox
End Class
