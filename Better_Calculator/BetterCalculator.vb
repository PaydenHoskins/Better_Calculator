'Payden Hoskins
'RCET2265
'Spring 2025
'Better Calculator

Option Explicit On
Option Strict On


Module BetterCalculator

    Sub Main()
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim GetOutOfHere As Boolean
        Dim UserInput As String
        Do
            GetOutOfHere = False
            Console.WriteLine("Type 'Q' at any point to Quit")
            Console.WriteLine("Enter 1st Number: ")
            UserInput = Console.ReadLine()
            Console.WriteLine($"You entered {UserInput}.")
            Try
                FirstNumber = CInt(UserInput)
                GetOutOfHere = True
            Catch ex As Exception
                If UserInput <> "Q" Then
                    Console.WriteLine($"{UserInput} is not a whole number...")
                ElseIf UserInput = "Q" Then
                    GetOutOfHere = True
                End If
            End Try
        Loop While GetOutOfHere = False

        Console.WriteLine("Type 'Q' at any point to Quit")
            Console.WriteLine("Enter 2st Number: ")
            UserInput = Console.ReadLine()
            Console.WriteLine($"You entered {UserInput}.")
            Try
                SecondNumber = CInt(UserInput)
            Catch ex As Exception
                If UserInput <> "Q" Then
                    Console.WriteLine($"{UserInput} is not a whole number...")
                End If
            End Try


    End Sub

End Module
