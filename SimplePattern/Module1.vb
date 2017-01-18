Module Module1

    Sub Main()
        Dim side As Integer = 5
        Dim row As Integer
        Dim column As Integer

        Console.WriteLine("Pattern 1")
        For row = 1 To side
            For column = side To 1 Step -1
                If (row = column) Then
                    Console.Write("-")
                Else
                    Console.Write("0")
                End If
            Next
            Console.WriteLine()
        Next
        '0000-
        '000-0
        '00-00
        '0-000
        '-0000
        Console.WriteLine()

        Console.WriteLine("Pattern 2")
        For row = 1 To side
            For column = 1 To side
                If (row = column) Then
                    Console.Write("-")
                Else
                    Console.Write("0")
                End If
            Next
            Console.WriteLine()
        Next
        '-0000
        '0-000
        '00-00
        '000-0
        '0000-
        Console.WriteLine()

        Console.WriteLine("Pattern 3")
        For row = 1 To side
            For column = 1 To side
                If (column Mod 2 = 0) Then
                    Console.Write("-")
                Else
                    Console.Write("0")
                End If
            Next
            Console.WriteLine()
        Next
        '0-0-0
        '0-0-0
        '0-0-0
        '0-0-0
        '0-0-0
        Console.WriteLine()

        Console.WriteLine("Pattern 4")
        For row = 1 To side
            If row Mod 2 = 0 Then
                For column = 1 To side
                    Console.Write("-")
                Next
            Else
                For c = 1 To side
                    Console.Write("0")
                Next
            End If
            Console.WriteLine()
        Next
        '00000
        '-----
        '00000
        '-----
        '00000

        Console.ReadLine()
    End Sub

End Module
