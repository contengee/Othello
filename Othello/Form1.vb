Public Class Form1

    Dim WithEvents Grid As New ReverseGrid
    Dim Turn As CellStatus = CellStatus.Black '今どっちの順番か
    Dim PlayerColor As CellStatus = CellStatus.Black 'プレイヤーの色
    Dim Computer As New CpuLevel3(Grid, CellStatus.White)


    '■Start
    ''' <summary>ゲームを開始します。</summary>
    ''' <param name="PlayerColor">人間の石の色を指定します。</param>
    ''' <remarks>黒が先手になります。</remarks>
    Private Sub Start(ByVal PlayerColor As CellStatus)

        Grid.Initialize()

        Me.PlayerColor = PlayerColor '人間の色

        If PlayerColor = CellStatus.Black Then
            Computer.Standard = CellStatus.White 'コンピュータの色は白
        Else
            Computer.Standard = CellStatus.Black 'コンピュータの色は黒
        End If

        '現在の黒と白の駒の数を表示する
        lblBlackCount.Text = Grid.Count(CellStatus.Black)
        lblWhiteCount.Text = Grid.Count(CellStatus.White)

        'ChangeTurnを呼び出して黒の番を開始する。そのために仮に今は白の番であることにする。
        Turn = CellStatus.White
        ChangeTurn()

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        Grid.Draw(e.Graphics)

    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        'マウスの座標をPictureBox1のコントロール座標に変換する。
        Dim Pos As Point = PictureBox1.PointToClient(Windows.Forms.Cursor.Position)
        Dim ThisCell As Cell

        ThisCell = Grid.CellFromPoint(Pos.X, Pos.Y)

        If Grid.Put(Turn, ThisCell.Position.X, ThisCell.Position.Y) Then
            ChangeTurn()
        End If

    End Sub

    ''' <summary>マウスの移動に伴ってセルにアクティブを示す枠を描画する</summary>
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        Dim ThisCell As Cell

        'マウスがある位置のセルを取得
        ThisCell = Grid.CellFromPoint(e.X, e.Y)

        If Not IsNothing(ThisCell) Then

            'セルが取得できた場合は、セルにアクティブを示す枠を描画
            ThisCell.Focus()

            '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
            PictureBox1.Invalidate() '←実際の描画はすべてここで行う

        End If

    End Sub

    '■ChangeTurn
    ''' <summary>ターン交代</summary>
    Public Sub ChangeTurn()

        '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
        PictureBox1.Invalidate()

        '▼勝敗判定
        If Grid.Count(CellStatus.Nothing) = 0 Then
            '全セルへの配置が終了した場合は勝敗判定して終了
            If Grid.Count(CellStatus.Black) > Grid.Count(CellStatus.White) Then
                MsgBox("黒の勝ちです！")
            ElseIf Grid.Count(CellStatus.Black) < Grid.Count(CellStatus.White) Then
                MsgBox("白の勝ちです！")
            Else
                MsgBox("引き分けです！！")
            End If
            Return
        ElseIf Grid.PuttableCount(CellStatus.Black) = 0 AndAlso Grid.PuttableCount(CellStatus.White) = 0 Then
            '空いているセルがあるのに黒も白も置けない場合
            If Grid.Count(CellStatus.Black) > Grid.Count(CellStatus.White) Then
                MsgBox("黒の勝ちです！")
            ElseIf Grid.Count(CellStatus.Black) < Grid.Count(CellStatus.White) Then
                MsgBox("白の勝ちです！")
            Else
                MsgBox("引き分けです！！")
            End If
            Return
        ElseIf Grid.Count(CellStatus.Black) = 0 Then
            'すべての石が白になった場合(=黒の石が0個の場合)
            MsgBox("白の勝ちです！")
            Return
        ElseIf Grid.Count(CellStatus.White) = 0 Then
            'すべての石が黒になった場合(=白の石が0個の場合)
            MsgBox("黒の勝ちです！")
            Return
        End If

        '▼次のターンの決定
        If Turn = CellStatus.Black Then
            Turn = CellStatus.White
            lblBlackTurn2.Visible = False
            lblWhiteTurn.Visible = True
        Else
            Turn = CellStatus.Black
            lblBlackTurn2.Visible = True
            lblWhiteTurn.Visible = False
        End If

        '▼置ける場所があるか判定
        If Grid.PuttableCount(Turn) = 0 Then
            '置く場所がなければパスして次のターン
            ChangeTurn()
        End If

        '▼人間かコンピュータかで処理を分岐
        If Turn = PlayerColor Then
            '人間の番ならば、PictureBoxを使用可能にする。
            PictureBox1.Enabled = True
        Else
            'コンピュータの番ならば、PictureBoxを使用不可にする。
            PictureBox1.Enabled = False

            'ちょっと時間をおく
            Application.DoEvents()
            System.Threading.Thread.Sleep(500)

            'コンピュータに石を置かせる。どのセルに置くかはコンピュータ(AI)が決定する。
            Computer.PutStone()
            ChangeTurn() 'プレイヤーの番へ
        End If

    End Sub
    ''' <summary>石を置いたときに発生するイベント</summary>
    Private Sub Grid_PutNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.PutNew

        Call Grid_Reversed(sender, e)

    End Sub

    ''' <summary>石がひっくり返されたときに発生するイベント</summary>
    Private Sub Grid_Reversed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Reversed

        '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
        PictureBox1.Invalidate()

        '現在の黒と白の石の数を表示する
        lblBlackCount.Text = Grid.Count(CellStatus.Black)
        lblWhiteCount.Text = Grid.Count(CellStatus.White)

        'ちょっと時間をおく
        Application.DoEvents()
        System.Threading.Thread.Sleep(500)

    End Sub

    Private Sub btnStartBlack_Click(sender As Object, e As EventArgs) Handles btnStartBlack.Click
        Start(CellStatus.Black)
    End Sub

    Private Sub btnStartWhite_Click(sender As Object, e As EventArgs) Handles btnStartWhite.Click
        Start(CellStatus.White)
    End Sub
End Class
