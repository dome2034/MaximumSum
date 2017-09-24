Module Module1
    Dim Data() As Double
    Dim DataSize, Key(), p, q As UInteger
    Dim isAllNegative As Boolean = True
    Sub Main()
        input()
        process(Data)
        output()
        Console.ReadLine()
    End Sub

    Sub input()
        Console.Write("Data size : ")
        DataSize = Console.ReadLine() - 1
        ReDim Data(DataSize)

        For i As UInteger = 0 To DataSize
            Console.Write("Input data " + (i).ToString() + " : ")
            Data(i) = Console.ReadLine()
        Next
    End Sub
    Sub process(Data() As Double)
        Dim Maximum, Sum As Double
        Maximum = Data(0)
        p = 0
        q = 0
        For i As Integer = 0 To DataSize
            Sum = Data(i)
            If isAllNegative Then
                If Data(i) / (-1) = Math.Abs(Data(i)) Then
                    isAllNegative = True
                Else
                    isAllNegative = False
                End If
            End If

            For j As Integer = i + 1 To DataSize
                If Sum > Maximum Then
                    Maximum = Sum
                    p = i
                    q = i
                End If

                Sum = Sum + Data(j)

                If Sum > Maximum Then
                    Maximum = Sum
                    p = i
                    q = j
                End If

            Next
        Next
    End Sub

    Sub output()
        Console.WriteLine("-------------------------------------------")
        If isAllNegative Then
            Console.WriteLine("Ans : 0")
        Else
            Console.WriteLine("p : " + p.ToString())
            Console.WriteLine("q : " + q.ToString())
        End If

    End Sub

End Module
