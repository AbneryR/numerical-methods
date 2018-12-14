Public Class Form1
    Dim g As Graphics
    Dim x() As Single
    Dim y() As Single
    Dim a As Single
    Dim b As Single
    Dim sumaX, sumaY, sumaXY, sumaXX As Single
    Dim red As Integer

    Public Sub graficar1(x As Single, y As Single)
        graf.Series(0).Points.AddXY(x, y)

    End Sub

    Public Sub graficar2(x As Single, y As Single)
        graf.Series(1).Points.AddXY(x, y)

    End Sub


    Private Sub salida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles salida.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        red = 4
    End Sub

    Private Sub graficar_Click(sender As Object, e As EventArgs) Handles graficar.Click
        g = graf.CreateGraphics()
        For k = 0 To n.Text - 1
            graficar1(x(k), y(k))

        Next
        graficar2(xmin, ymin)
        graficar2(xmax, ymax)

    End Sub

    Dim xmin, xmax, ymin, ymax As Single


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        ReDim x(0 To n.Text - 1)
        ReDim y(0 To n.Text - 1)
        salida.Rows.Clear()
        For k = 0 To n.Text - 1
            x(k) = InputBox("x(" & k & ")=")
            y(k) = InputBox("y(" & k & ")=")
        Next
        'x(0) = 1.0
        'x(1) = 1.1
        'x(2) = 1.2
        'x(3) = 1.3
        'x(4) = 1.4
        'x(5) = 1.5
        'x(6) = 1.6
        'x(7) = 1.7
        'x(8) = 1.8
        'x(9) = 1.9
        'x(10) = 2


        'y(0) = 8.1
        'y(1) = 7.8
        'y(2) = 8.5
        'y(3) = 9.8
        'y(4) = 9.5
        'y(5) = 8.9
        'y(6) = 8.6
        'y(7) = 10.2
        'y(8) = 9.3
        'y(9) = 9.2
        'y(10) = 10.5

        For k = 0 To n.Text - 1
            salida.Rows.Add(k + 1, x(k), y(k))
            sumaX += x(k)
            sumaY += y(k)
            sumaXY += (x(k) * y(k))
            sumaXX += (x(k)) ^ 2
        Next
        salida.Rows.Add("Suma de X", sumaX, "")
        salida.Rows.Add("Suma de Y", sumaY, "")
        salida.Rows.Add("Suma de XY", sumaXY, "")
        salida.Rows.Add("Suma de X^2", sumaXX, "")

        b = (n.Text * sumaXY - sumaX * sumaY) / (n.Text * sumaXX - sumaX ^ 2)
        a = (sumaY - b * sumaX) / n.Text


        salida.Rows.Add("La recta de mejor ajuste es y =", Math.Round(a, red) & "+", Math.Round(b, red) & "x")

        xmin = x(0)
        ymin = a + b * x(0)
        xmax = x(n.Text - 1)
        ymax = a + b * x(n.Text - 1)

        salida.Rows.Add("Recta de mejor ajuste", "^x", "^y")
        salida.Rows.Add("", xmin, ymin)
        salida.Rows.Add("", xmax, ymax)


    End Sub

    'boton para graficar

End Class
