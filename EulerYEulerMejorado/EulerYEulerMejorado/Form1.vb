Imports info.lundin.math


Public Class Form1
    Dim x(500) As Single
    Dim y(500) As Single
    Dim er(500) As Single
    Dim n As Single
    Dim h As Single
    Dim k As Integer
    Dim redon As Integer
    Dim g As Graphics
    Dim q As Single
    Dim t As Single

    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", x * y)


        parser.Values.Add("e", 2.7183)
        Return parser.Parse(tf.Text)
    End Function



    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click, eulermejorado.Click
        Dim suma As Single
        Dim i As Integer
        Dim xf As Single

        redon = cs.Text + 2
        n = 0
        h = tbh.Text
        xf = tbx.Text
        x(i) = tba.Text
        y(i) = tbb.Text


        salida.Rows.Add(Math.Round(x(i), redon), Math.Round(y(i), redon))


        Do While x(i) <= xf
            i = i + 1

            x(i) = x(i - 1) + h */ (f(x()))

            y(i) = y(i - 1) + (h) * (2 * y(i - 1) + 1) / (x(i - 1) ^ 2)

            salida.Rows.Add(Math.Round(x(i), redon), Math.Round(y(i), redon))

        Loop


    End Sub

    Private Sub eulermejorado_Click(sender As Object, e As EventArgs) Handles eulermejorado.Click

        Dim i As Integer
        Dim xf As Single
        Dim A As Single

        redon = cs.Text + 2
        n = 0
        h = tbh.Text
        xf = tbx.Text
        x(i) = tba.Text
        y(i) = tbb.Text


        salida.Rows.Add(Math.Round(x(i), redon), Math.Round(y(i), redon))


        Do While x(i) <= xf
            i = i + 1

            x(i) = x(i - 1) + h


            y(i) = y(i - 1) + (h) * (2 * A) / (x(i - 1) ^ 2)

            salida.Rows.Add(Math.Round(x(i), redon), Math.Round(y(i), redon))

        Loop


    End Sub
End Class
