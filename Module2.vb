Module Module2

    '   procedure generate(k : integer, A : array of any):
    '  if k = 1 then
    '     output(A)
    'else
    '    // Generate permutations with kth unaltered
    '    // Initially k == length(A)
    '    generate(k - 1, A)

    '    // Generate permutations for kth swapped with each k-1 initial
    '    for i := 0; i < k-1; i += 1 do
    '        // Swap choice dependent on parity of k (even or odd)
    '        if k is even then
    '            swap(A[i], A[k-1]) // zero-indexed, the kth is at k-1
    '        else
    '            swap(A[0], A[k-1])
    '        end if
    '        generate(k - 1, A)

    '    end for
    'end if
    Sub run()
        Dim blah() As Byte = {1, 2, 3, 4, 5}
        GenPerms(5, blah)
    End Sub

    Function GenPerms(ByVal k As Integer, ByVal blah() As Byte)
        Dim temp As Byte
        If k = 1 Then
            For z = 0 To 4
                Console.Write(blah(z) & ",")
            Next
            Console.WriteLine()
            Return blah
        Else
            GenPerms(k - 1, blah)

            For i = 0 To k - 1
                If k Mod 2 = 0 Then
                    temp = blah(i)
                    blah(i) = blah(k - 1)
                    blah(k - 1) = temp
                Else
                    temp = blah(0)
                    blah(0) = blah(k - 1)
                    blah(k - 1) = temp
                End If
                GenPerms(k - 1, blah)
            Next
        End If

    End Function
End Module
