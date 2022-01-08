Imports System
Imports System.Console
Module Program
    Sub Main()
        Dim ran As Integer
        ran = 0
        WriteLine("Press (1) to play or (2) to exit")
        ran = ReadLine()
        If ran = 1 Then
            outout()
        ElseIf ran = 2 Then
            Environment.Exit(0)
        Else
            Main()
        End If
    End Sub
    Sub outout()
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        If value = 1 Then
            WriteLine("Rock")
        ElseIf value = 2 Then
            WriteLine("Paper")
        ElseIf value = 3 Then
            WriteLine("Scissors")
        End If
        ReadKey()
    End Sub
End Module
