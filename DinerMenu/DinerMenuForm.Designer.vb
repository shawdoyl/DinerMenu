<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinerMenuForm))
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.DinerDisplayLabel = New System.Windows.Forms.Label()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplaySpecialLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(213, 67)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(363, 245)
        Me.DisplaySpecialLabel.TabIndex = 7
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerDisplayLabel
        '
        Me.DinerDisplayLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DinerDisplayLabel.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerDisplayLabel.Location = New System.Drawing.Point(230, 9)
        Me.DinerDisplayLabel.Name = "DinerDisplayLabel"
        Me.DinerDisplayLabel.Size = New System.Drawing.Size(328, 58)
        Me.DinerDisplayLabel.TabIndex = 8
        Me.DinerDisplayLabel.Text = "Arthur's Diner"
        Me.DinerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FishButton
        '
        Me.FishButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(470, 384)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(112, 54)
        Me.FishButton.TabIndex = 11
        Me.FishButton.TabStop = False
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(335, 384)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(115, 54)
        Me.SaladButton.TabIndex = 10
        Me.SaladButton.TabStop = False
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(200, 384)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(114, 54)
        Me.SoupButton.TabIndex = 9
        Me.SoupButton.TabStop = False
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'WarningLabel
        '
        Me.WarningLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WarningLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.Location = New System.Drawing.Point(213, 286)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(363, 95)
        Me.WarningLabel.TabIndex = 13
        Me.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinerDisplayLabel)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Name = "DinerMenuForm"
        Me.Text = "DinerMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents DinerDisplayLabel As Label
    Friend WithEvents FishButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents WarningLabel As Label
End Class
