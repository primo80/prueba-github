Module Module1

    Sub Main()
        Dim temperatura, presion As Double

        Console.WriteLine("Dime la temperatura")
        temperatura = Console.ReadLine
        Console.WriteLine("Dime la presion")
        presion = Console.ReadLine

        If temperatura > 500 Then
            Console.WriteLine("reducir la temperatura")
        End If



        If presion > 2 Then
            Console.WriteLine("abrir valvula de seguridad")
        End If




        If presion <= 2 And temperatura < 500 Then
            Console.WriteLine("todo en orden")
        End If

        Console.ReadLine()

    End Sub

End Module
