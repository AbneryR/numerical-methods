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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbb = New System.Windows.Forms.TextBox()
        Me.tba = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbh = New System.Windows.Forms.TextBox()
        Me.cs = New System.Windows.Forms.TextBox()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbx = New System.Windows.Forms.TextBox()
        Me.eulermejorado = New System.Windows.Forms.Button()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "       h="
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.salida.Location = New System.Drawing.Point(42, 234)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(340, 204)
        Me.salida.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "x"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "y"
        Me.Column2.Name = "Column2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = ")="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "y( "
        '
        'tbb
        '
        Me.tbb.Location = New System.Drawing.Point(204, 107)
        Me.tbb.Name = "tbb"
        Me.tbb.Size = New System.Drawing.Size(100, 20)
        Me.tbb.TabIndex = 15
        '
        'tba
        '
        Me.tba.Location = New System.Drawing.Point(82, 107)
        Me.tba.Name = "tba"
        Me.tba.Size = New System.Drawing.Size(100, 20)
        Me.tba.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cifras Significativas"
        '
        'tbh
        '
        Me.tbh.Location = New System.Drawing.Point(242, 146)
        Me.tbh.Name = "tbh"
        Me.tbh.Size = New System.Drawing.Size(52, 20)
        Me.tbh.TabIndex = 11
        '
        'cs
        '
        Me.cs.Location = New System.Drawing.Point(204, 58)
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(100, 20)
        Me.cs.TabIndex = 13
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(242, 183)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 36)
        Me.limpiar.TabIndex = 9
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(42, 183)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 36)
        Me.calcular.TabIndex = 10
        Me.calcular.Text = "Euler"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "       para x="
        '
        'tbx
        '
        Me.tbx.Location = New System.Drawing.Point(130, 146)
        Me.tbx.Name = "tbx"
        Me.tbx.Size = New System.Drawing.Size(52, 20)
        Me.tbx.TabIndex = 25
        '
        'eulermejorado
        '
        Me.eulermejorado.Location = New System.Drawing.Point(142, 183)
        Me.eulermejorado.Name = "eulermejorado"
        Me.eulermejorado.Size = New System.Drawing.Size(75, 36)
        Me.eulermejorado.TabIndex = 10
        Me.eulermejorado.Text = "Euler Mejorado"
        Me.eulermejorado.UseVisualStyleBackColor = True
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(204, 26)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Dame f"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbb)
        Me.Controls.Add(Me.tba)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbh)
        Me.Controls.Add(Me.cs)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.eulermejorado)
        Me.Controls.Add(Me.calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents salida As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbb As TextBox
    Friend WithEvents tba As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbh As TextBox
    Friend WithEvents cs As TextBox
    Friend WithEvents limpiar As Button
    Friend WithEvents calcular As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents tbx As TextBox
    Friend WithEvents eulermejorado As Button
    Friend WithEvents tf As TextBox
    Friend WithEvents Label2 As Label
End Class
