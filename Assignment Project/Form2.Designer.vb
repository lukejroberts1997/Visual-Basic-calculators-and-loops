<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblhex = New System.Windows.Forms.Label()
        Me.txthex = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnhexback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblhex
        '
        Me.lblhex.AutoSize = True
        Me.lblhex.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhex.Location = New System.Drawing.Point(70, 27)
        Me.lblhex.Name = "lblhex"
        Me.lblhex.Size = New System.Drawing.Size(150, 25)
        Me.lblhex.TabIndex = 0
        Me.lblhex.Text = "Hex Converter"
        '
        'txthex
        '
        Me.txthex.Location = New System.Drawing.Point(89, 69)
        Me.txthex.Name = "txthex"
        Me.txthex.Size = New System.Drawing.Size(100, 20)
        Me.txthex.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(89, 113)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(100, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnhexback
        '
        Me.btnhexback.Location = New System.Drawing.Point(13, 226)
        Me.btnhexback.Name = "btnhexback"
        Me.btnhexback.Size = New System.Drawing.Size(75, 23)
        Me.btnhexback.TabIndex = 3
        Me.btnhexback.Text = "Back"
        Me.btnhexback.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnhexback)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txthex)
        Me.Controls.Add(Me.lblhex)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblhex As Label
    Friend WithEvents txthex As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents btnhexback As Button
End Class
