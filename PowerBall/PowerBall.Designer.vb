<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerBall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PowerBall))
        Me.Number1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MainNumbers = New System.Windows.Forms.Panel()
        Me.MainNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'Number1
        '
        Me.Number1.AutoSize = True
        Me.Number1.BackColor = System.Drawing.Color.Transparent
        Me.Number1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number1.ForeColor = System.Drawing.SystemColors.Window
        Me.Number1.Location = New System.Drawing.Point(162, 9)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(446, 37)
        Me.Number1.TabIndex = 0
        Me.Number1.Text = "Power Ball Number Generator"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(653, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 37)
        Me.Label6.TabIndex = 6
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(580, 318)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(123, 38)
        Me.cmdGenerate.TabIndex = 8
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 37)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 37)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 37)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 37)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 37)
        Me.Label5.TabIndex = 5
        '
        'MainNumbers
        '
        Me.MainNumbers.BackColor = System.Drawing.Color.Transparent
        Me.MainNumbers.Controls.Add(Me.Label1)
        Me.MainNumbers.Controls.Add(Me.Label2)
        Me.MainNumbers.Controls.Add(Me.Label3)
        Me.MainNumbers.Controls.Add(Me.Label5)
        Me.MainNumbers.Controls.Add(Me.Label4)
        Me.MainNumbers.Location = New System.Drawing.Point(63, 193)
        Me.MainNumbers.Name = "MainNumbers"
        Me.MainNumbers.Size = New System.Drawing.Size(584, 100)
        Me.MainNumbers.TabIndex = 9
        '
        'PowerBall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainNumbers)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Number1)
        Me.Name = "PowerBall"
        Me.Text = "Power Ball Number Generator"
        Me.MainNumbers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Number1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MainNumbers As Panel
End Class
