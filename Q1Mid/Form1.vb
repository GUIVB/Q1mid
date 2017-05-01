Public Class Form1

    Private Sub find_Btn_Click(sender As Object, e As EventArgs) Handles find_Btn.Click
        Dim arr() As String = Tb1.Text.Split(vbCr)


        Dim max = arr(0)
        Dim min = arr(0)


        If MaxR.Checked Then



            For i = 0 To arr.Length - 1

                If max < Val(arr(i)) Then
                    max = arr(i)

                End If

            Next



            MsgBox("the max number is  : " & max)

        ElseIf MinR.Checked Then

            For i = 0 To arr.Length - 1

                If min > Val(arr(i)) Then
                    min = arr(i)

                End If


            Next

            MsgBox(" the min number is :" & min)

        ElseIf EqR.Checked Then

            For i = 0 To arr.Length - 1

                If arr(i) = Val(EqTb.Text) Then


                    MsgBox("yes , " & EqTb.Text & " is exist ")

                End If


            Next



        End If


    End Sub
End Class
