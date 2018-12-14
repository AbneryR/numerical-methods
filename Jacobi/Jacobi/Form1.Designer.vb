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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.a11_tb = New System.Windows.Forms.TextBox()
        Me.a31_tb = New System.Windows.Forms.TextBox()
        Me.a21_tb = New System.Windows.Forms.TextBox()
        Me.a12_tb = New System.Windows.Forms.TextBox()
        Me.a22_tb = New System.Windows.Forms.TextBox()
        Me.a32_tb = New System.Windows.Forms.TextBox()
        Me.a13_tb = New System.Windows.Forms.TextBox()
        Me.b1_tb = New System.Windows.Forms.TextBox()
        Me.a23_tb = New System.Windows.Forms.TextBox()
        Me.b2_tb = New System.Windows.Forms.TextBox()
        Me.a33_tb = New System.Windows.Forms.TextBox()
        Me.b3_tb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(535, 171)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 45
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(535, 77)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 44
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.salida.Location = New System.Drawing.Point(28, 225)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(704, 267)
        Me.salida.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.HeaderText = "iteracion i"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "x"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "y"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "z"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "error x"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "error y"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "error z"
        Me.Column7.Name = "Column7"
        '
        'tcs
        '
        Me.tcs.Location = New System.Drawing.Point(187, 47)
        Me.tcs.Name = "tcs"
        Me.tcs.Size = New System.Drawing.Size(112, 20)
        Me.tcs.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Dame cifras Significativas"
        '
        'a11_tb
        '
        Me.a11_tb.Location = New System.Drawing.Point(70, 101)
        Me.a11_tb.Name = "a11_tb"
        Me.a11_tb.Size = New System.Drawing.Size(27, 20)
        Me.a11_tb.TabIndex = 46
        '
        'a31_tb
        '
        Me.a31_tb.Location = New System.Drawing.Point(70, 154)
        Me.a31_tb.Name = "a31_tb"
        Me.a31_tb.Size = New System.Drawing.Size(27, 20)
        Me.a31_tb.TabIndex = 46
        '
        'a21_tb
        '
        Me.a21_tb.Location = New System.Drawing.Point(70, 127)
        Me.a21_tb.Name = "a21_tb"
        Me.a21_tb.Size = New System.Drawing.Size(27, 20)
        Me.a21_tb.TabIndex = 46
        '
        'a12_tb
        '
        Me.a12_tb.Location = New System.Drawing.Point(125, 101)
        Me.a12_tb.Name = "a12_tb"
        Me.a12_tb.Size = New System.Drawing.Size(27, 20)
        Me.a12_tb.TabIndex = 46
        '
        'a22_tb
        '
        Me.a22_tb.Location = New System.Drawing.Point(125, 127)
        Me.a22_tb.Name = "a22_tb"
        Me.a22_tb.Size = New System.Drawing.Size(27, 20)
        Me.a22_tb.TabIndex = 46
        '
        'a32_tb
        '
        Me.a32_tb.Location = New System.Drawing.Point(125, 153)
        Me.a32_tb.Name = "a32_tb"
        Me.a32_tb.Size = New System.Drawing.Size(27, 20)
        Me.a32_tb.TabIndex = 46
        '
        'a13_tb
        '
        Me.a13_tb.Location = New System.Drawing.Point(187, 101)
        Me.a13_tb.Name = "a13_tb"
        Me.a13_tb.Size = New System.Drawing.Size(27, 20)
        Me.a13_tb.TabIndex = 46
        '
        'b1_tb
        '
        Me.b1_tb.Location = New System.Drawing.Point(249, 101)
        Me.b1_tb.Name = "b1_tb"
        Me.b1_tb.Size = New System.Drawing.Size(27, 20)
        Me.b1_tb.TabIndex = 46
        '
        'a23_tb
        '
        Me.a23_tb.Location = New System.Drawing.Point(187, 127)
        Me.a23_tb.Name = "a23_tb"
        Me.a23_tb.Size = New System.Drawing.Size(27, 20)
        Me.a23_tb.TabIndex = 46
        '
        'b2_tb
        '
        Me.b2_tb.Location = New System.Drawing.Point(249, 127)
        Me.b2_tb.Name = "b2_tb"
        Me.b2_tb.Size = New System.Drawing.Size(27, 20)
        Me.b2_tb.TabIndex = 46
        '
        'a33_tb
        '
        Me.a33_tb.Location = New System.Drawing.Point(187, 153)
        Me.a33_tb.Name = "a33_tb"
        Me.a33_tb.Size = New System.Drawing.Size(27, 20)
        Me.a33_tb.TabIndex = 46
        '
        'b3_tb
        '
        Me.b3_tb.Location = New System.Drawing.Point(249, 153)
        Me.b3_tb.Name = "b3_tb"
        Me.b3_tb.Size = New System.Drawing.Size(27, 20)
        Me.b3_tb.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(218, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "z="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(156, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "y+"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "z="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "y+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "x+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "z="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "x+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "y+"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "x+"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 511)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b3_tb)
        Me.Controls.Add(Me.a23_tb)
        Me.Controls.Add(Me.a33_tb)
        Me.Controls.Add(Me.a22_tb)
        Me.Controls.Add(Me.a21_tb)
        Me.Controls.Add(Me.a12_tb)
        Me.Controls.Add(Me.a32_tb)
        Me.Controls.Add(Me.b2_tb)
        Me.Controls.Add(Me.b1_tb)
        Me.Controls.Add(Me.a13_tb)
        Me.Controls.Add(Me.a31_tb)
        Me.Controls.Add(Me.a11_tb)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.tcs)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Jacobi"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salir As Button
    Friend WithEvents calcular As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents tcs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents a11_tb As TextBox
    Friend WithEvents a31_tb As TextBox
    Friend WithEvents a21_tb As TextBox
    Friend WithEvents a12_tb As TextBox
    Friend WithEvents a22_tb As TextBox
    Friend WithEvents a32_tb As TextBox
    Friend WithEvents a13_tb As TextBox
    Friend WithEvents b1_tb As TextBox
    Friend WithEvents a23_tb As TextBox
    Friend WithEvents b2_tb As TextBox
    Friend WithEvents a33_tb As TextBox
    Friend WithEvents b3_tb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
