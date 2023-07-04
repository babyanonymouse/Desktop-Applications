<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblN1 = New Label()
        lblN2 = New Label()
        lblN3 = New Label()
        txtN1 = New TextBox()
        txtN2 = New TextBox()
        txtN3 = New TextBox()
        Label1 = New Label()
        lblA = New Label()
        lblS = New Label()
        Label3 = New Label()
        lblP = New Label()
        Label5 = New Label()
        btnC = New Button()
        SuspendLayout()
        ' 
        ' lblN1
        ' 
        lblN1.AutoSize = True
        lblN1.Location = New Point(38, 41)
        lblN1.Name = "lblN1"
        lblN1.Size = New Size(41, 15)
        lblN1.TabIndex = 0
        lblN1.Text = "NUM1"
        ' 
        ' lblN2
        ' 
        lblN2.AutoSize = True
        lblN2.Location = New Point(38, 71)
        lblN2.Name = "lblN2"
        lblN2.Size = New Size(41, 15)
        lblN2.TabIndex = 0
        lblN2.Text = "NUM2"
        ' 
        ' lblN3
        ' 
        lblN3.AutoSize = True
        lblN3.Location = New Point(38, 105)
        lblN3.Name = "lblN3"
        lblN3.Size = New Size(41, 15)
        lblN3.TabIndex = 0
        lblN3.Text = "NUM3"
        ' 
        ' txtN1
        ' 
        txtN1.Location = New Point(85, 41)
        txtN1.Name = "txtN1"
        txtN1.Size = New Size(100, 23)
        txtN1.TabIndex = 1
        ' 
        ' txtN2
        ' 
        txtN2.Location = New Point(85, 70)
        txtN2.Name = "txtN2"
        txtN2.Size = New Size(100, 23)
        txtN2.TabIndex = 1
        ' 
        ' txtN3
        ' 
        txtN3.Location = New Point(85, 99)
        txtN3.Name = "txtN3"
        txtN3.Size = New Size(100, 23)
        txtN3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(253, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 2
        Label1.Text = "AVERAGE"
        ' 
        ' lblA
        ' 
        lblA.BorderStyle = BorderStyle.Fixed3D
        lblA.Location = New Point(253, 52)
        lblA.Name = "lblA"
        lblA.Size = New Size(56, 26)
        lblA.TabIndex = 2
        ' 
        ' lblS
        ' 
        lblS.BorderStyle = BorderStyle.Fixed3D
        lblS.Location = New Point(253, 116)
        lblS.Name = "lblS"
        lblS.Size = New Size(56, 26)
        lblS.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(253, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 4
        Label3.Text = "SUM"
        ' 
        ' lblP
        ' 
        lblP.BorderStyle = BorderStyle.Fixed3D
        lblP.Location = New Point(253, 173)
        lblP.Name = "lblP"
        lblP.Size = New Size(56, 26)
        lblP.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(253, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 6
        Label5.Text = "PRODUCT"
        ' 
        ' btnC
        ' 
        btnC.Location = New Point(161, 232)
        btnC.Name = "btnC"
        btnC.Size = New Size(75, 23)
        btnC.TabIndex = 7
        btnC.Text = "Compute"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(556, 280)
        Controls.Add(btnC)
        Controls.Add(lblP)
        Controls.Add(Label5)
        Controls.Add(lblS)
        Controls.Add(Label3)
        Controls.Add(lblA)
        Controls.Add(Label1)
        Controls.Add(txtN3)
        Controls.Add(txtN2)
        Controls.Add(txtN1)
        Controls.Add(lblN3)
        Controls.Add(lblN2)
        Controls.Add(lblN1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblN1 As Label
    Friend WithEvents lblN2 As Label
    Friend WithEvents lblN3 As Label
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents txtN3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblS As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblP As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnC As Button
End Class
