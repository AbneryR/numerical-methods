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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.calcular = New System.Windows.Forms.Button()
        Me.cs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tba = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.graficar = New System.Windows.Forms.Button()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.a1 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bRectangulo = New System.Windows.Forms.Button()
        Me.bTrapecio = New System.Windows.Forms.Button()
        Me.bSimpson = New System.Windows.Forms.Button()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(277, 63)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 0
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'cs
        '
        Me.cs.Location = New System.Drawing.Point(144, 146)
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(100, 20)
        Me.cs.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cifras Significativas"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(128, 31)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dame f"
        '
        'tba
        '
        Me.tba.Location = New System.Drawing.Point(128, 66)
        Me.tba.Name = "tba"
        Me.tba.Size = New System.Drawing.Size(100, 20)
        Me.tba.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dame a"
        '
        'tbb
        '
        Me.tbb.Location = New System.Drawing.Point(128, 104)
        Me.tbb.Name = "tbb"
        Me.tbb.Size = New System.Drawing.Size(100, 20)
        Me.tbb.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dame b"
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(30, 234)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(340, 204)
        Me.salida.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "n"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integracion"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.Name = "Column3"
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(277, 109)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 0
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'graficar
        '
        Me.graficar.Location = New System.Drawing.Point(277, 172)
        Me.graficar.Name = "graficar"
        Me.graficar.Size = New System.Drawing.Size(75, 23)
        Me.graficar.TabIndex = 6
        Me.graficar.Text = "graficar"
        Me.graficar.UseVisualStyleBackColor = True
        '
        'Graf
        '
        ChartArea2.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Graf.Legends.Add(Legend2)
        Me.Graf.Location = New System.Drawing.Point(407, 138)
        Me.Graf.Name = "Graf"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Me.Graf.Series.Add(Series3)
        Me.Graf.Series.Add(Series4)
        Me.Graf.Size = New System.Drawing.Size(375, 300)
        Me.Graf.TabIndex = 7
        Me.Graf.Text = "Chart1"
        '
        'a1
        '
        Me.a1.Location = New System.Drawing.Point(73, 199)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(52, 20)
        Me.a1.TabIndex = 1
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(162, 198)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(49, 20)
        Me.b1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rango"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "a"
        '
        'bRectangulo
        '
        Me.bRectangulo.Location = New System.Drawing.Point(407, 62)
        Me.bRectangulo.Name = "bRectangulo"
        Me.bRectangulo.Size = New System.Drawing.Size(75, 23)
        Me.bRectangulo.TabIndex = 9
        Me.bRectangulo.Text = "Int. Rect"
        Me.bRectangulo.UseVisualStyleBackColor = True
        '
        'bTrapecio
        '
        Me.bTrapecio.Location = New System.Drawing.Point(505, 62)
        Me.bTrapecio.Name = "bTrapecio"
        Me.bTrapecio.Size = New System.Drawing.Size(75, 23)
        Me.bTrapecio.TabIndex = 9
        Me.bTrapecio.Text = "Int Trapecio"
        Me.bTrapecio.UseVisualStyleBackColor = True
        '
        'bSimpson
        '
        Me.bSimpson.Location = New System.Drawing.Point(611, 63)
        Me.bSimpson.Name = "bSimpson"
        Me.bSimpson.Size = New System.Drawing.Size(75, 23)
        Me.bSimpson.TabIndex = 9
        Me.bSimpson.Text = "Simpson 1/3"
        Me.bSimpson.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 504)
        Me.Controls.Add(Me.bSimpson)
        Me.Controls.Add(Me.bTrapecio)
        Me.Controls.Add(Me.bRectangulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.graficar)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbb)
        Me.Controls.Add(Me.tba)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.cs)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcular As Button
    Friend WithEvents cs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tba As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents limpiar As Button
    Friend WithEvents graficar As Button
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents a1 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bRectangulo As Button
    Friend WithEvents bTrapecio As Button
    Friend WithEvents bSimpson As Button
End Class
