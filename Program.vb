'Napišite program koji će od korisnika tražiti unos veličine stranica trokuta. Provjerom
'unesenih stranica potrebno je ispisati o kojoj vrsti trokuta se radi.
'Ilva Perić, 1. godina prijediplomskog stručnog studija računarstva 2024/2025

Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("Unesite 3 stranice trokuta")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        If (a = b And a = c) Then
            Console.WriteLine("Trokut je jednostraničan")
        ElseIf a = b Then
            Console.WriteLine("Trokut je jednakokračan")
        Else
            Console.WriteLine("Trokut je raznostraničan")
        End If

    End Sub
End Module
