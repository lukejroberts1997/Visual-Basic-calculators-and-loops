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
        Me.btnhex = New System.Windows.Forms.Button()
        Me.btngrade = New System.Windows.Forms.Button()
        Me.btnloops = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnhex
        '
        Me.btnhex.Location = New System.Drawing.Point(23, 31)
        Me.btnhex.Name = "btnhex"
        Me.btnhex.Size = New System.Drawing.Size(75, 23)
        Me.btnhex.TabIndex = 0
        Me.btnhex.Text = "Hex"
        Me.btnhex.UseVisualStyleBackColor = True
        '
        'btngrade
        '
        Me.btngrade.Location = New System.Drawing.Point(23, 74)
        Me.btngrade.Name = "btngrade"
        Me.btngrade.Size = New System.Drawing.Size(75, 23)
        Me.btngrade.TabIndex = 1
        Me.btngrade.Text = "Grade"
        Me.btngrade.UseVisualStyleBackColor = True
        '
        'btnloops
        '
        Me.btnloops.Location = New System.Drawing.Point(23, 121)
        Me.btnloops.Name = "btnloops"
        Me.btnloops.Size = New System.Drawing.Size(75, 23)
        Me.btnloops.TabIndex = 2
        Me.btnloops.Text = "Loops"
        Me.btnloops.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Location = New System.Drawing.Point(23, 163)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(75, 23)
        Me.btnquit.TabIndex = 3
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 211)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnloops)
        Me.Controls.Add(Me.btngrade)
        Me.Controls.Add(Me.btnhex)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnhex As Button
    Friend WithEvents btngrade As Button
    Friend WithEvents btnloops As Button
    Friend WithEvents btnquit As Button
End Class
