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
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.find_Btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EqR = New System.Windows.Forms.RadioButton()
        Me.MaxR = New System.Windows.Forms.RadioButton()
        Me.MinR = New System.Windows.Forms.RadioButton()
        Me.EqTb = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(21, 33)
        Me.Tb1.Multiline = True
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(322, 276)
        Me.Tb1.TabIndex = 0
        '
        'find_Btn
        '
        Me.find_Btn.Location = New System.Drawing.Point(21, 315)
        Me.find_Btn.Name = "find_Btn"
        Me.find_Btn.Size = New System.Drawing.Size(75, 23)
        Me.find_Btn.TabIndex = 1
        Me.find_Btn.Text = "find"
        Me.find_Btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EqTb)
        Me.GroupBox1.Controls.Add(Me.EqR)
        Me.GroupBox1.Controls.Add(Me.MaxR)
        Me.GroupBox1.Controls.Add(Me.MinR)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 163)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'EqR
        '
        Me.EqR.AutoSize = True
        Me.EqR.Location = New System.Drawing.Point(28, 111)
        Me.EqR.Name = "EqR"
        Me.EqR.Size = New System.Drawing.Size(51, 17)
        Me.EqR.TabIndex = 2
        Me.EqR.Text = "Equal"
        Me.EqR.UseVisualStyleBackColor = True
        '
        'MaxR
        '
        Me.MaxR.AutoSize = True
        Me.MaxR.Location = New System.Drawing.Point(28, 75)
        Me.MaxR.Name = "MaxR"
        Me.MaxR.Size = New System.Drawing.Size(69, 17)
        Me.MaxR.TabIndex = 1
        Me.MaxR.Text = "Maximum"
        Me.MaxR.UseVisualStyleBackColor = True
        '
        'MinR
        '
        Me.MinR.AutoSize = True
        Me.MinR.Checked = True
        Me.MinR.Location = New System.Drawing.Point(28, 43)
        Me.MinR.Name = "MinR"
        Me.MinR.Size = New System.Drawing.Size(65, 17)
        Me.MinR.TabIndex = 0
        Me.MinR.TabStop = True
        Me.MinR.Text = "Minimum"
        Me.MinR.UseVisualStyleBackColor = True
        '
        'EqTb
        '
        Me.EqTb.Location = New System.Drawing.Point(86, 111)
        Me.EqTb.Name = "EqTb"
        Me.EqTb.Size = New System.Drawing.Size(66, 20)
        Me.EqTb.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.find_Btn)
        Me.Controls.Add(Me.Tb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb1 As TextBox
    Friend WithEvents find_Btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EqR As RadioButton
    Friend WithEvents MaxR As RadioButton
    Friend WithEvents MinR As RadioButton
    Friend WithEvents EqTb As TextBox
End Class
