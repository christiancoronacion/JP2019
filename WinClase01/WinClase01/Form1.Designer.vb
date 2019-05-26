<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txmOut = New System.Windows.Forms.TextBox()
        Me.btnCreditos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "num 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "num 2"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(111, 22)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(100, 20)
        Me.txtN1.TabIndex = 2
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(111, 51)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(100, 20)
        Me.txtN2.TabIndex = 3
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(281, 20)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 37)
        Me.btnDividir.TabIndex = 0
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(281, 58)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 38)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txmOut
        '
        Me.txmOut.Location = New System.Drawing.Point(29, 102)
        Me.txmOut.Multiline = True
        Me.txmOut.Name = "txmOut"
        Me.txmOut.Size = New System.Drawing.Size(327, 220)
        Me.txmOut.TabIndex = 4
        '
        'btnCreditos
        '
        Me.btnCreditos.Location = New System.Drawing.Point(96, 332)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.Size = New System.Drawing.Size(194, 33)
        Me.btnCreditos.TabIndex = 5
        Me.btnCreditos.Text = "&Creditos"
        Me.btnCreditos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 367)
        Me.Controls.Add(Me.btnCreditos)
        Me.Controls.Add(Me.txmOut)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txmOut As TextBox
    Friend WithEvents btnCreditos As Button
End Class
