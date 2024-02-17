<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheFile
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
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.Buka = New System.Windows.Forms.Button()
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.TextBoxEditor = New System.Windows.Forms.RichTextBox()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxPath
        '
        Me.TextBoxPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBoxPath.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBoxPath.Location = New System.Drawing.Point(69, 46)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(455, 22)
        Me.TextBoxPath.TabIndex = 0
        '
        'Buka
        '
        Me.Buka.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Buka.FlatAppearance.BorderSize = 0
        Me.Buka.Location = New System.Drawing.Point(557, 46)
        Me.Buka.Name = "Buka"
        Me.Buka.Size = New System.Drawing.Size(135, 25)
        Me.Buka.TabIndex = 1
        Me.Buka.Text = "Buka"
        Me.Buka.UseVisualStyleBackColor = False
        '
        'ListBoxItems
        '
        Me.ListBoxItems.BackColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxItems.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.ItemHeight = 16
        Me.ListBoxItems.Location = New System.Drawing.Point(69, 93)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(312, 324)
        Me.ListBoxItems.TabIndex = 2
        '
        'TextBoxEditor
        '
        Me.TextBoxEditor.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBoxEditor.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxEditor.Location = New System.Drawing.Point(410, 93)
        Me.TextBoxEditor.Name = "TextBoxEditor"
        Me.TextBoxEditor.Size = New System.Drawing.Size(361, 291)
        Me.TextBoxEditor.TabIndex = 3
        Me.TextBoxEditor.Text = ""
        '
        'Simpan
        '
        Me.Simpan.BackColor = System.Drawing.Color.YellowGreen
        Me.Simpan.Location = New System.Drawing.Point(523, 390)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(169, 27)
        Me.Simpan.TabIndex = 4
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = False
        '
        'TheFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.TextBoxEditor)
        Me.Controls.Add(Me.ListBoxItems)
        Me.Controls.Add(Me.Buka)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Name = "TheFile"
        Me.Text = "TheFile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents Buka As Button
    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents TextBoxEditor As RichTextBox
    Friend WithEvents Simpan As Button
End Class
