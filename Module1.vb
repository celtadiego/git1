Option Strict On
Module Module1

    Sub Main()
        Dim a, b, c, d, menor As Double
        Console.WriteLine("Escriba el valor de a")
        a = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("Escriba el valor de b")
        b = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("Escriba el valor de c")
        c = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("Escriba el valor de d")
        d = Convert.ToDouble(Console.ReadLine)

        If a > b Then
            menor = b
        Else
            menor = a
        End If
        If menor > c Then
            menor = c
        End If
        If menor > d Then
            menor = d
        End If

        Console.WriteLine("menor es: " & menor)
        Console.ReadLine()
    End Sub

End Module
