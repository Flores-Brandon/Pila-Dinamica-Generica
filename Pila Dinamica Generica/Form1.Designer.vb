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
        PushButton = New Button()
        PopButton = New Button()
        PeekButton = New Button()
        label2 = New Label()
        InputTextBox = New TextBox()
        StackListBox = New ListBox()
        SuspendLayout()
        ' 
        ' PushButton
        ' 
        PushButton.Location = New Point(353, 176)
        PushButton.Name = "PushButton"
        PushButton.Size = New Size(168, 29)
        PushButton.TabIndex = 0
        PushButton.Text = "Push (Apilar/Agregar)"
        PushButton.UseVisualStyleBackColor = True
        ' 
        ' PopButton
        ' 
        PopButton.Location = New Point(353, 211)
        PopButton.Name = "PopButton"
        PopButton.Size = New Size(168, 29)
        PopButton.TabIndex = 1
        PopButton.Text = "Pop (Eliminar)"
        PopButton.UseVisualStyleBackColor = True
        ' 
        ' PeekButton
        ' 
        PeekButton.Location = New Point(353, 246)
        PeekButton.Name = "PeekButton"
        PeekButton.Size = New Size(168, 29)
        PeekButton.TabIndex = 2
        PeekButton.Text = "Peek (Solo Mostrar)"
        PeekButton.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        label2.Location = New Point(60, 78)
        label2.Name = "label2"
        label2.Size = New Size(104, 28)
        label2.TabIndex = 9
        label2.Text = "Dato  (Int):"
        ' 
        ' InputTextBox
        ' 
        InputTextBox.Location = New Point(50, 124)
        InputTextBox.Name = "InputTextBox"
        InputTextBox.Size = New Size(190, 27)
        InputTextBox.TabIndex = 10
        ' 
        ' StackListBox
        ' 
        StackListBox.FormattingEnabled = True
        StackListBox.ItemHeight = 20
        StackListBox.Location = New Point(577, 93)
        StackListBox.Name = "StackListBox"
        StackListBox.Size = New Size(240, 284)
        StackListBox.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(874, 450)
        Controls.Add(StackListBox)
        Controls.Add(InputTextBox)
        Controls.Add(label2)
        Controls.Add(PeekButton)
        Controls.Add(PopButton)
        Controls.Add(PushButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PushButton As Button
    Friend WithEvents PopButton As Button
    Friend WithEvents PeekButton As Button
    Private WithEvents label2 As Label
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents StackListBox As ListBox
End Class
