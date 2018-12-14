Imports info.lundin.math



Public Class Form1
    Dim integra(500) As Single
    Dim er(500) As Single
    Dim ec As Single
    Dim n As Single
    Dim h As Single
    Dim k As Integer
    Dim redon As Integer
    Dim g As Graphics
    Dim q As Single
    Dim t As Single

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)

        Return parser.Parse(tf.Text)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calcular.Click

        Dim suma As Single
        Dim a As Single
        Dim b As Single
        Dim i As Integer


        ec = 0.5 * 10 ^ (-cs.Text)
        a = tba.Text
        b = tbb.Text
        redon = cs.Text + 2
        n = 4
        h = (b - a) / n

        suma = 0

        For k = 0 To n - 1
            suma = suma + h * f(a + k * h)
        Next

        integra(i) = suma
        salida.Rows.Add(n, integra(i), "----")
        er(i) = 1


        Do While er(i) > ec
            n = n + 4
            h = (b - a) / n
            suma = 0
            i = i + 1
            For k = 0 To n - 1
                suma = suma + h * f(a + k * h)
            Next
            integra(i) = suma
            er(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))
            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(er(i), redon))

        Loop



    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        salida.Rows.Clear()
    End Sub

    Private Sub graficar_Click(sender As Object, e As EventArgs) Handles graficar.Click
        g = Graf.CreateGraphics()
        q = a1.Text
        Do While q <= b1.Text
            Graf.Series(0).Points.AddXY(Math.Round(q, 1), f(q))
            q = q + 0.1
        Loop

        t = tba.Text

        Do While t <= tbb.Text
            Graf.Series(1).Points.AddXY(Math.Round(t, 1), f(t))
            t = t + 0.1
        Loop


    End Sub

    Private Sub g_Click(sender As Object, e As EventArgs) Handles Graf.Click

    End Sub

    Private Sub bRectangulo_Click(sender As Object, e As EventArgs) Handles bRectangulo.Click

        Dim suma As Single
        Dim a As Single
        Dim b As Single
        Dim i As Integer


        ec = 0.5 * 10 ^ (-cs.Text)
        a = tba.Text
        b = tbb.Text
        redon = cs.Text + 2
        n = 100
        h = (b - a) / n

        suma = 0

        For k = 0 To n - 1
            suma = suma + h * f(a + k * h)
        Next

        integra(i) = suma
        salida.Rows.Add(n, integra(i), "----")
        er(i) = 1


        Do While er(i) > ec
            n = n + 100
            h = (b - a) / n
            suma = 0
            i = i + 1
            For k = 0 To n - 1
                suma = suma + h * f(a + k * h)
            Next
            integra(i) = suma
            er(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))
            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(er(i), redon))

        Loop



    End Sub

    Private Sub bTrapecio_Click(sender As Object, e As EventArgs) Handles bTrapecio.Click

        Dim suma As Single
        Dim a As Single
        Dim b As Single
        Dim i As Integer


        ec = 0.5 * 10 ^ (-cs.Text)
        a = tba.Text
        b = tbb.Text
        redon = cs.Text + 2
        n = 10
        h = (b - a) / n

        suma = 0

        For k = 1 To n - 1
            suma = suma + 2 * f(a + k * h)
        Next

        integra(i) = (suma + f(a) + f(b)) * h / 2
        salida.Rows.Add(n, integra(i), "----")
        er(i) = 1


        Do While er(i) > ec
            n = n + 10
            h = (b - a) / n
            suma = 0
            i = i + 1

            For k = 1 To n - 1
                suma = suma + 2 * f(a + k * h)
                ''        suma = suma + h * f(a + k * h)
            Next

            integra(i) = (suma + f(a) + f(b)) * h / 2
            er(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))
            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(er(i), redon))

        Loop



    End Sub

    Private Sub bSimpson_Click(sender As Object, e As EventArgs) Handles bSimpson.Click
        Dim suma As Single
        Dim sumaDos As Single
        Dim a As Single
        Dim b As Single
        Dim i As Integer


        ec = 0.5 * 10 ^ (-cs.Text)
        a = tba.Text
        b = tbb.Text
        redon = cs.Text + 2
        n = 4
        h = (b - a) / (2 * n)
        suma = 0
        sumaDos = 0

        For k = 1 To n
            suma = suma + 2 * f(a + 2 * k * h)
            sumaDos = sumaDos + 4 * f(a + (2 * k - 1) * h)
        Next
        integra(i) = (f(a) - f(b) + sumaDos + suma) * h / 3
        salida.Rows.Add(n, integra(i), "----")
        er(i) = 1


        Do While er(i) > ec
            n = n + 4
            h = (b - a) / (2 * n)
            suma = 0
            sumaDos = 0

            i = i + 1
            For k = 1 To n
                suma = suma + 2 * f(a + 2 * k * h)
                sumaDos = sumaDos + 4 * f(a + (2 * k - 1) * h)
                ''        suma = suma + h * f(a + k * h)
            Next

            integra(i) = (f(a) - f(b) + sumaDos + suma) * h / 3

            er(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))

            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(er(i), redon))

        Loop

    End Sub
End Class
