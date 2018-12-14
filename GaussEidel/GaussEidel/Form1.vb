
Public Class Form1
    Dim x(60), y(60), z(60) As Single
    Dim ex(60), ey(60), ez(60) As Single
    Dim a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3 As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim ec, n As Single
    Dim k, i, redon As Integer


    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click

        n = tcs.Text
        redon = n + 2
        ec = 0.5 * 10 ^ (-n)
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1

        a11 = a11_tb.Text
        a12 = a12_tb.Text
        a13 = a13_tb.Text
        a21 = a21_tb.Text
        a22 = a22_tb.Text
        a23 = a23_tb.Text
        a31 = a31_tb.Text
        a32 = a32_tb.Text
        a33 = a33_tb.Text
        b1 = b1_tb.Text
        b2 = b2_tb.Text
        b3 = b3_tb.Text

        i = 0
        k = 0

        x(i) = 0
        y(i) = 0
        z(i) = 0


        salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), "----", "----", "----")

        Do While (ex(i) > ec) Or (ey(i) > ec) Or (ez(i) > ec)


            x(i + 1) = (b1 - a12 * y(i) - a13 * z(i)) / (a11)
            y(i + 1) = (b2 - a21 * x(i + 1) - a23 * z(i)) / (a22)
            z(i + 1) = (b3 - a31 * x(i + 1) - a32 * y(i + 1)) / (a33)



            ex(i + 1) = Math.Abs((x(i + 1) - x(i)) / x(i + 1))
            ey(i + 1) = Math.Abs((y(i + 1) - y(i)) / y(i + 1))
            ez(i + 1) = Math.Abs((z(i + 1) - z(i)) / z(i + 1))

            salida.Rows.Add(i + 1, Math.Round(x(i + 1), redon), Math.Round(y(i + 1), redon), Math.Round(z(i + 1), redon), Math.Round(ex(i + 1), redon), Math.Round(ey(i + 1), redon), Math.Round(ez(i + 1), redon))
            i = i + 1

        Loop

        salida.Rows.Add("Las raíces son", Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), "----", "----", "----")
    End Sub


    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub

End Class
