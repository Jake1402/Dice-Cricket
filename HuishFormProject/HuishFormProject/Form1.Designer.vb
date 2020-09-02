<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiceCricket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiceCricket))
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.InputName = New System.Windows.Forms.TextBox()
        Me.btnPlayerName = New System.Windows.Forms.Button()
        Me.btnNextShot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalBox = New System.Windows.Forms.TextBox()
        Me.GithubPictureLink = New System.Windows.Forms.PictureBox()
        CType(Me.GithubPictureLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        resources.ApplyResources(Me.lblPlayerName, "lblPlayerName")
        Me.lblPlayerName.Name = "lblPlayerName"
        '
        'InputName
        '
        Me.InputName.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.InputName, "InputName")
        Me.InputName.Name = "InputName"
        '
        'btnPlayerName
        '
        resources.ApplyResources(Me.btnPlayerName, "btnPlayerName")
        Me.btnPlayerName.Name = "btnPlayerName"
        Me.btnPlayerName.UseVisualStyleBackColor = True
        '
        'btnNextShot
        '
        resources.ApplyResources(Me.btnNextShot, "btnNextShot")
        Me.btnNextShot.Name = "btnNextShot"
        Me.btnNextShot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtScores
        '
        Me.txtScores.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.txtScores, "txtScores")
        Me.txtScores.Name = "txtScores"
        Me.txtScores.ReadOnly = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'totalBox
        '
        Me.totalBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.totalBox, "totalBox")
        Me.totalBox.Name = "totalBox"
        Me.totalBox.ReadOnly = True
        '
        'GithubPictureLink
        '
        resources.ApplyResources(Me.GithubPictureLink, "GithubPictureLink")
        Me.GithubPictureLink.Name = "GithubPictureLink"
        Me.GithubPictureLink.TabStop = False
        '
        'frmDiceCricket
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GithubPictureLink)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtScores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNextShot)
        Me.Controls.Add(Me.btnPlayerName)
        Me.Controls.Add(Me.InputName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmDiceCricket"
        CType(Me.GithubPictureLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerName As Label
    Friend WithEvents InputName As TextBox
    Friend WithEvents btnPlayerName As Button
    Friend WithEvents btnNextShot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScores As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents totalBox As TextBox
    Friend WithEvents GithubPictureLink As PictureBox
End Class
