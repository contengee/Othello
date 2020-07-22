Public Class CpuLevel1

    Public Standard As CellStatus
    Dim Grid As ReverseGrid

    Public Sub New(ByVal Grid As ReverseGrid, ByVal Standard As CellStatus)

        Me.Grid = Grid
        Me.Standard = Standard

    End Sub

    Public Sub PutStone()

        Dim X As Integer
        Dim Y As Integer

        '順番に見ていってはじめに置けるところにどこでもいいから置く
        For Y = 0 To ReverseGrid.YCount - 1
            For X = 0 To ReverseGrid.XCount - 1
                If Grid.CanPut(Standard, X, Y) Then
                    Grid.Put(Standard, X, Y)
                    Return
                End If
            Next
        Next

    End Sub

End Class