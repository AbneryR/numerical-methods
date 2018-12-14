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
        Me.salir = New System.Windows.Forms.Button()
        Me.calcular = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.tcs = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iteracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tfp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(399, 148)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 32
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(399, 81)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 31
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iteracion, Me.Column3, Me.Column2})
        Me.salida.Location = New System.Drawing.Point(25, 229)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(475, 267)
        Me.salida.TabIndex = 30
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(177, 155)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(111, 20)
        Me.tf.TabIndex = 29
        '
        'tcs
        '
        Me.tcs.Location = New System.Drawing.Point(177, 122)
        Me.tcs.Name = "tcs"
        Me.tcs.Size = New System.Drawing.Size(112, 20)
        Me.tcs.TabIndex = 28
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(153, 72)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(112, 20)
        Me.tb.TabIndex = 27
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(150, 29)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(115, 20)
        Me.ta.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Dame funcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Dame cifras Significativas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "dame b"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Dame a"
        '
        'iteracion
        '
        Me.iteracion.HeaderText = "Iteracion i"
        Me.iteracion.Name = "iteracion"
        '
        'Column3
        '
        Me.Column3.HeaderText = "x(i)"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Error"
        Me.Column2.Name = "Column2"
        '
        'tfp
        '
        Me.tfp.Location = New System.Drawing.Point(177, 181)
        Me.tfp.Name = "tfp"
        Me.tfp.Size = New System.Drawing.Size(111, 20)
        Me.tfp.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Dame funcion derivada"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.tfp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.tcs)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salir As Button
    Friend WithEvents calcular As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents tf As TextBox
    Friend WithEvents tcs As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents iteracion As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents tfp As TextBox
    Friend WithEvents Label5 As Label
End Class
