<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBlackTurn2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWhiteCount = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblBlackCount = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblBlackTurn = New System.Windows.Forms.Label()
        Me.lblWhiteTurn = New System.Windows.Forms.Label()
        Me.btnStartBlack = New System.Windows.Forms.Button()
        Me.btnStartWhite = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBlackTurn2
        '
        Me.lblBlackTurn2.AutoSize = True
        Me.lblBlackTurn2.BackColor = System.Drawing.Color.Red
        Me.lblBlackTurn2.Font = New System.Drawing.Font("HG行書体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBlackTurn2.Location = New System.Drawing.Point(506, 71)
        Me.lblBlackTurn2.Name = "lblBlackTurn2"
        Me.lblBlackTurn2.Size = New System.Drawing.Size(110, 16)
        Me.lblBlackTurn2.TabIndex = 1
        Me.lblBlackTurn2.Text = "　　　　　　"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(29, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 416)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblWhiteCount
        '
        Me.lblWhiteCount.AutoSize = True
        Me.lblWhiteCount.Font = New System.Drawing.Font("HG行書体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWhiteCount.Location = New System.Drawing.Point(589, 100)
        Me.lblWhiteCount.Name = "lblWhiteCount"
        Me.lblWhiteCount.Size = New System.Drawing.Size(32, 33)
        Me.lblWhiteCount.TabIndex = 1
        Me.lblWhiteCount.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("HG行書体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label2.Location = New System.Drawing.Point(506, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 33)
        Me.label2.TabIndex = 1
        Me.label2.Text = "白"
        '
        'lblBlackCount
        '
        Me.lblBlackCount.AutoSize = True
        Me.lblBlackCount.Font = New System.Drawing.Font("HG行書体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBlackCount.Location = New System.Drawing.Point(589, 38)
        Me.lblBlackCount.Name = "lblBlackCount"
        Me.lblBlackCount.Size = New System.Drawing.Size(32, 33)
        Me.lblBlackCount.TabIndex = 1
        Me.lblBlackCount.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("HG行書体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(506, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 33)
        Me.label1.TabIndex = 1
        Me.label1.Text = "黒"
        '
        'lblBlackTurn
        '
        Me.lblBlackTurn.AutoSize = True
        Me.lblBlackTurn.BackColor = System.Drawing.Color.Red
        Me.lblBlackTurn.Font = New System.Drawing.Font("HG行書体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBlackTurn.Location = New System.Drawing.Point(506, 67)
        Me.lblBlackTurn.Name = "lblBlackTurn"
        Me.lblBlackTurn.Size = New System.Drawing.Size(0, 33)
        Me.lblBlackTurn.TabIndex = 1
        '
        'lblWhiteTurn
        '
        Me.lblWhiteTurn.AutoSize = True
        Me.lblWhiteTurn.BackColor = System.Drawing.Color.Red
        Me.lblWhiteTurn.Font = New System.Drawing.Font("HG行書体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWhiteTurn.Location = New System.Drawing.Point(506, 133)
        Me.lblWhiteTurn.Name = "lblWhiteTurn"
        Me.lblWhiteTurn.Size = New System.Drawing.Size(110, 16)
        Me.lblWhiteTurn.TabIndex = 1
        Me.lblWhiteTurn.Text = "　　　　　　"
        '
        'btnStartBlack
        '
        Me.btnStartBlack.Font = New System.Drawing.Font("HG教科書体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStartBlack.Location = New System.Drawing.Point(496, 263)
        Me.btnStartBlack.Name = "btnStartBlack"
        Me.btnStartBlack.Size = New System.Drawing.Size(138, 44)
        Me.btnStartBlack.TabIndex = 2
        Me.btnStartBlack.Text = "黒(先手)で開始"
        Me.btnStartBlack.UseVisualStyleBackColor = True
        '
        'btnStartWhite
        '
        Me.btnStartWhite.Font = New System.Drawing.Font("HG教科書体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStartWhite.Location = New System.Drawing.Point(496, 328)
        Me.btnStartWhite.Name = "btnStartWhite"
        Me.btnStartWhite.Size = New System.Drawing.Size(138, 44)
        Me.btnStartWhite.TabIndex = 2
        Me.btnStartWhite.Text = "白(後手)で開始"
        Me.btnStartWhite.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 450)
        Me.Controls.Add(Me.btnStartWhite)
        Me.Controls.Add(Me.btnStartBlack)
        Me.Controls.Add(Me.lblWhiteCount)
        Me.Controls.Add(Me.lblBlackCount)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblBlackTurn)
        Me.Controls.Add(Me.lblWhiteTurn)
        Me.Controls.Add(Me.lblBlackTurn2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBlackTurn2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWhiteCount As Label
    Friend WithEvents label2 As Label
    Friend WithEvents lblBlackCount As Label
    Friend WithEvents label1 As Label
    Friend WithEvents lblBlackTurn As Label
    Friend WithEvents lblWhiteTurn As Label
    Friend WithEvents btnStartBlack As Button
    Friend WithEvents btnStartWhite As Button
End Class
