<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartView
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClosed = New System.Windows.Forms.Button()
        Me.BtnMinimized = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnStatr = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClosed
        '
        Me.BtnClosed.BackColor = System.Drawing.Color.Transparent
        Me.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClosed.FlatAppearance.BorderSize = 0
        Me.BtnClosed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnClosed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClosed.ForeColor = System.Drawing.Color.Black
        Me.BtnClosed.Location = New System.Drawing.Point(534, -8)
        Me.BtnClosed.Name = "BtnClosed"
        Me.BtnClosed.Size = New System.Drawing.Size(32, 52)
        Me.BtnClosed.TabIndex = 63
        Me.BtnClosed.Text = "X"
        Me.BtnClosed.UseVisualStyleBackColor = False
        '
        'BtnMinimized
        '
        Me.BtnMinimized.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimized.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimized.FlatAppearance.BorderSize = 0
        Me.BtnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimized.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimized.ForeColor = System.Drawing.Color.Black
        Me.BtnMinimized.Location = New System.Drawing.Point(501, -8)
        Me.BtnMinimized.Name = "BtnMinimized"
        Me.BtnMinimized.Size = New System.Drawing.Size(33, 52)
        Me.BtnMinimized.TabIndex = 62
        Me.BtnMinimized.Text = "-"
        Me.BtnMinimized.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 34)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "ECCUSBET"
        '
        'BtnStatr
        '
        Me.BtnStatr.BackColor = System.Drawing.Color.White
        Me.BtnStatr.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.BtnStatr.FlatAppearance.BorderSize = 2
        Me.BtnStatr.Location = New System.Drawing.Point(211, 137)
        Me.BtnStatr.Name = "BtnStatr"
        Me.BtnStatr.Size = New System.Drawing.Size(148, 35)
        Me.BtnStatr.TabIndex = 60
        Me.BtnStatr.Text = "Iniciar"
        Me.BtnStatr.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Versão 1.0"
        '
        'StartView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 270)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnClosed)
        Me.Controls.Add(Me.BtnMinimized)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStatr)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClosed As Button
    Friend WithEvents BtnMinimized As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStatr As Button
    Friend WithEvents Label3 As Label
End Class
