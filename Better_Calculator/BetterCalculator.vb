﻿Option Explicit On
Option Strict On
'Payden Hoskins
'RCET2265
'Spring 2025
'Better Calculator

Imports System.ComponentModel.Design
Imports System.Linq.Expressions

Module BetterCalculator

    Sub Main()
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim GetOutOfHere As Boolean
        Dim UserInput As String
        Dim Operation As String
        Do
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

            Do While UserInput <> "Q"
                Console.WriteLine("Type 'Q' at any point to Quit")
                Console.WriteLine("Enter 2nd Number: ")
                UserInput = Console.ReadLine()
                Console.WriteLine($"You entered {UserInput}.")
                Try
                    SecondNumber = CInt(UserInput)
                Catch ex As Exception
                    If UserInput <> "Q" Then
                        Console.WriteLine($"{UserInput} is not a whole number...")
                    ElseIf UserInput = "Q" Then
                        GetOutOfHere = True
                    End If
                End Try
            Loop

            Console.WriteLine("Select Opertion: ")
            Console.WriteLine("1.Add")
            Console.WriteLine("2.Subtract")
            Console.WriteLine("3.Multiply")
            Console.WriteLine("4.Divide")
            Console.WriteLine("Input you choice below.")
            Operation = Console.ReadLine()
        Loop While UserInput <> "Q"
    End Sub

End Module
