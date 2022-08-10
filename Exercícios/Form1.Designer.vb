<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.FraseUp = New System.Windows.Forms.Label()
        Me.FraseDown = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.ResultMaior = New System.Windows.Forms.TextBox()
        Me.FraseResult = New System.Windows.Forms.Label()
        Me.Comparar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Titulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Titulo.Location = New System.Drawing.Point(72, 9)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(346, 28)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Determinar qual número é maior"
        '
        'FraseUp
        '
        Me.FraseUp.AutoSize = True
        Me.FraseUp.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FraseUp.Location = New System.Drawing.Point(32, 77)
        Me.FraseUp.Name = "FraseUp"
        Me.FraseUp.Size = New System.Drawing.Size(136, 23)
        Me.FraseUp.TabIndex = 1
        Me.FraseUp.Text = "Primeiro número"
        '
        'FraseDown
        '
        Me.FraseDown.AutoSize = True
        Me.FraseDown.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FraseDown.Location = New System.Drawing.Point(32, 125)
        Me.FraseDown.Name = "FraseDown"
        Me.FraseDown.Size = New System.Drawing.Size(142, 23)
        Me.FraseDown.TabIndex = 2
        Me.FraseDown.Text = "Segundo número"
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(221, 77)
        Me.Num1.MaxLength = 10
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(100, 23)
        Me.Num1.TabIndex = 3
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(221, 125)
        Me.Num2.MaxLength = 10
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(100, 23)
        Me.Num2.TabIndex = 4
        '
        'ResultMaior
        '
        Me.ResultMaior.Location = New System.Drawing.Point(179, 213)
        Me.ResultMaior.Name = "ResultMaior"
        Me.ResultMaior.Size = New System.Drawing.Size(142, 23)
        Me.ResultMaior.TabIndex = 5
        Me.ResultMaior.TabStop = False
        '
        'FraseResult
        '
        Me.FraseResult.AutoSize = True
        Me.FraseResult.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FraseResult.Location = New System.Drawing.Point(179, 187)
        Me.FraseResult.Name = "FraseResult"
        Me.FraseResult.Size = New System.Drawing.Size(145, 23)
        Me.FraseResult.TabIndex = 6
        Me.FraseResult.Text = "O maior número é"
        '
        'Comparar
        '
        Me.Comparar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Comparar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Comparar.Location = New System.Drawing.Point(370, 77)
        Me.Comparar.Name = "Comparar"
        Me.Comparar.Size = New System.Drawing.Size(85, 71)
        Me.Comparar.TabIndex = 7
        Me.Comparar.Text = "Comparar"
        Me.Comparar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 257)
        Me.Controls.Add(Me.Comparar)
        Me.Controls.Add(Me.FraseResult)
        Me.Controls.Add(Me.ResultMaior)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.FraseDown)
        Me.Controls.Add(Me.FraseUp)
        Me.Controls.Add(Me.Titulo)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qual é maior?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents FraseUp As Label
    Friend WithEvents FraseDown As Label
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents ResultMaior As TextBox
    Friend WithEvents FraseResult As Label
    Friend WithEvents Comparar As Button
End Class
