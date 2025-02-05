<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConverter
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
        Me.TXTKM = New System.Windows.Forms.TextBox()
        Me.TXTMIL = New System.Windows.Forms.TextBox()
        Me.BottonConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXTKM
        '
        Me.TXTKM.Location = New System.Drawing.Point(249, 300)
        Me.TXTKM.Name = "TXTKM"
        Me.TXTKM.Size = New System.Drawing.Size(184, 26)
        Me.TXTKM.TabIndex = 0
        '
        'TXTMIL
        '
        Me.TXTMIL.Location = New System.Drawing.Point(249, 383)
        Me.TXTMIL.Name = "TXTMIL"
        Me.TXTMIL.Size = New System.Drawing.Size(184, 26)
        Me.TXTMIL.TabIndex = 1
        '
        'BottonConvert
        '
        Me.BottonConvert.Location = New System.Drawing.Point(298, 332)
        Me.BottonConvert.Name = "BottonConvert"
        Me.BottonConvert.Size = New System.Drawing.Size(82, 33)
        Me.BottonConvert.TabIndex = 2
        Me.BottonConvert.Text = "Teisenda"
        Me.BottonConvert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kilomeetrid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tulemus miilides"
        '
        'FormConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 1034)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BottonConvert)
        Me.Controls.Add(Me.TXTMIL)
        Me.Controls.Add(Me.TXTKM)
        Me.Name = "FormConverter"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTKM As TextBox
    Friend WithEvents TXTMIL As TextBox
    Friend WithEvents BottonConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
