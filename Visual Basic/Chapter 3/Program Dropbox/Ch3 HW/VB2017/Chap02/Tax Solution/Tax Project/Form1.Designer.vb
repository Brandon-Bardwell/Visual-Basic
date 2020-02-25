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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblTaxTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtAssessed = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 121)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 29)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(87, 69)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(128, 20)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Assessed Value:"
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.AutoSize = True
        Me.lblTaxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxTotal.Location = New System.Drawing.Point(548, 69)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(140, 20)
        Me.lblTaxTotal.TabIndex = 1
        Me.lblTaxTotal.Text = "Total Property Tax:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(337, 92)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Tax:"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtAssessed
        '
        Me.txtAssessed.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtAssessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAssessed.Location = New System.Drawing.Point(91, 92)
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.Size = New System.Drawing.Size(120, 20)
        Me.txtAssessed.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(552, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 188)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTaxTotal)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblValue As Label
    Friend WithEvents lblTaxTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtAssessed As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
