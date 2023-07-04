<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lstN = New ListBox()
        btnN = New Button()
        Button1 = New Button()
        btnC = New Button()
        txtK = New TextBox()
        txtM = New TextBox()
        txtE = New TextBox()
        lblM = New Label()
        lblE = New Label()
        lblK = New Label()
        Label1 = New Label()
        lblT = New Label()
        Label3 = New Label()
        lblA = New Label()
        lblG = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblR = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' lstN
        ' 
        lstN.FormattingEnabled = True
        lstN.ItemHeight = 15
        lstN.Location = New Point(547, 22)
        lstN.Name = "lstN"
        lstN.Size = New Size(198, 289)
        lstN.TabIndex = 0
        ' 
        ' btnN
        ' 
        btnN.Location = New Point(667, 326)
        btnN.Name = "btnN"
        btnN.Size = New Size(78, 25)
        btnN.TabIndex = 1
        btnN.Text = "Nums"
        btnN.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(46, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Vote"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Location = New Point(12, 194)
        btnC.Name = "btnC"
        btnC.Size = New Size(75, 23)
        btnC.TabIndex = 3
        btnC.Text = "Compute"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' txtK
        ' 
        txtK.Location = New Point(12, 133)
        txtK.Name = "txtK"
        txtK.Size = New Size(100, 23)
        txtK.TabIndex = 4
        ' 
        ' txtM
        ' 
        txtM.Location = New Point(12, 46)
        txtM.Name = "txtM"
        txtM.Size = New Size(100, 23)
        txtM.TabIndex = 5
        ' 
        ' txtE
        ' 
        txtE.Location = New Point(12, 91)
        txtE.Name = "txtE"
        txtE.Size = New Size(100, 23)
        txtE.TabIndex = 6
        ' 
        ' lblM
        ' 
        lblM.AutoSize = True
        lblM.Location = New Point(143, 46)
        lblM.Name = "lblM"
        lblM.Size = New Size(40, 15)
        lblM.TabIndex = 7
        lblM.Text = "Maths"
        ' 
        ' lblE
        ' 
        lblE.AutoSize = True
        lblE.Location = New Point(143, 94)
        lblE.Name = "lblE"
        lblE.Size = New Size(45, 15)
        lblE.TabIndex = 8
        lblE.Text = "English"
        ' 
        ' lblK
        ' 
        lblK.AutoSize = True
        lblK.Location = New Point(143, 141)
        lblK.Name = "lblK"
        lblK.Size = New Size(22, 15)
        lblK.TabIndex = 9
        lblK.Text = "Kis"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 10
        Label1.Text = "TOTAL"
        ' 
        ' lblT
        ' 
        lblT.BorderStyle = BorderStyle.Fixed3D
        lblT.Location = New Point(214, 55)
        lblT.Name = "lblT"
        lblT.Size = New Size(67, 24)
        lblT.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(214, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 12
        Label3.Text = "AVERAGE"
        ' 
        ' lblA
        ' 
        lblA.BorderStyle = BorderStyle.Fixed3D
        lblA.Location = New Point(214, 99)
        lblA.Name = "lblA"
        lblA.Size = New Size(67, 23)
        lblA.TabIndex = 13
        ' 
        ' lblG
        ' 
        lblG.BorderStyle = BorderStyle.Fixed3D
        lblG.Location = New Point(214, 150)
        lblG.Name = "lblG"
        lblG.Size = New Size(72, 22)
        lblG.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(209, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 14
        Label6.Text = "GRADE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(46, 352)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 15)
        Label7.TabIndex = 16
        Label7.Text = "Legible to vote"
        ' 
        ' lblR
        ' 
        lblR.BorderStyle = BorderStyle.Fixed3D
        lblR.Location = New Point(209, 202)
        lblR.Name = "lblR"
        lblR.Size = New Size(72, 25)
        lblR.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(209, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 15)
        Label9.TabIndex = 17
        Label9.Text = "REMARK"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(65, 5)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 15)
        Label10.TabIndex = 19
        Label10.Text = "Grade Analyzer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(lblR)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(lblG)
        Controls.Add(Label6)
        Controls.Add(lblA)
        Controls.Add(Label3)
        Controls.Add(lblT)
        Controls.Add(Label1)
        Controls.Add(lblK)
        Controls.Add(lblE)
        Controls.Add(lblM)
        Controls.Add(txtE)
        Controls.Add(txtM)
        Controls.Add(txtK)
        Controls.Add(btnC)
        Controls.Add(Button1)
        Controls.Add(btnN)
        Controls.Add(lstN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstN As ListBox
    Friend WithEvents btnN As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnC As Button
    Friend WithEvents txtK As TextBox
    Friend WithEvents txtM As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents lblM As Label
    Friend WithEvents lblE As Label
    Friend WithEvents lblK As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblT As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblG As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
