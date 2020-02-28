<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class awal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmaster = New System.Windows.Forms.Button()
        Me.btnhpp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(88, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APLIKASI PERHITUNGAN HPP"
        '
        'btnmaster
        '
        Me.btnmaster.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnmaster.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmaster.Location = New System.Drawing.Point(287, 126)
        Me.btnmaster.Name = "btnmaster"
        Me.btnmaster.Size = New System.Drawing.Size(221, 93)
        Me.btnmaster.TabIndex = 2
        Me.btnmaster.Text = "Data Master"
        Me.btnmaster.UseVisualStyleBackColor = False
        '
        'btnhpp
        '
        Me.btnhpp.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnhpp.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhpp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhpp.Location = New System.Drawing.Point(287, 245)
        Me.btnhpp.Name = "btnhpp"
        Me.btnhpp.Size = New System.Drawing.Size(221, 93)
        Me.btnhpp.TabIndex = 3
        Me.btnhpp.Text = "HPP"
        Me.btnhpp.UseVisualStyleBackColor = False
        '
        'awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnhpp)
        Me.Controls.Add(Me.btnmaster)
        Me.Controls.Add(Me.Label1)
        Me.Name = "awal"
        Me.Text = "awal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnmaster As Button
    Friend WithEvents btnhpp As Button
End Class
