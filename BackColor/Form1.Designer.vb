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
        SuspendLayout()
        ' 
        ' lstN
        ' 
        lstN.FormattingEnabled = True
        lstN.ItemHeight = 15
        lstN.Location = New Point(323, 61)
        lstN.Name = "lstN"
        lstN.Size = New Size(198, 289)
        lstN.TabIndex = 0
        ' 
        ' btnN
        ' 
        btnN.Location = New Point(178, 325)
        btnN.Name = "btnN"
        btnN.Size = New Size(78, 25)
        btnN.TabIndex = 1
        btnN.Text = "Nums"
        btnN.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnN)
        Controls.Add(lstN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstN As ListBox
    Friend WithEvents btnN As Button
End Class
