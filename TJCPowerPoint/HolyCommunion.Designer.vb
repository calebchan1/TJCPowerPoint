﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HolyCommunion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolyCommunion))
        Me.breadTxt = New System.Windows.Forms.TextBox()
        Me.cupTxt = New System.Windows.Forms.TextBox()
        Me.HCLabel = New System.Windows.Forms.Label()
        Me.updateHC = New System.Windows.Forms.Button()
        Me.HCClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.Color.Black
        Me.breadTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.White
        Me.breadTxt.Location = New System.Drawing.Point(21, 59)
        Me.breadTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breadTxt.Multiline = True
        Me.breadTxt.Name = "breadTxt"
        Me.breadTxt.Size = New System.Drawing.Size(326, 380)
        Me.breadTxt.TabIndex = 0
        Me.breadTxt.Text = "Bread:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.breadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cupTxt
        '
        Me.cupTxt.AcceptsReturn = True
        Me.cupTxt.AcceptsTab = True
        Me.cupTxt.BackColor = System.Drawing.Color.Black
        Me.cupTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupTxt.ForeColor = System.Drawing.Color.White
        Me.cupTxt.Location = New System.Drawing.Point(353, 59)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.Size = New System.Drawing.Size(326, 380)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.Text = "Cup:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HCLabel
        '
        Me.HCLabel.AutoSize = True
        Me.HCLabel.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCLabel.Location = New System.Drawing.Point(224, 9)
        Me.HCLabel.Name = "HCLabel"
        Me.HCLabel.Size = New System.Drawing.Size(259, 36)
        Me.HCLabel.TabIndex = 2
        Me.HCLabel.Text = "Holy Communion"
        Me.HCLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'updateHC
        '
        Me.updateHC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.Location = New System.Drawing.Point(685, 59)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Size = New System.Drawing.Size(112, 116)
        Me.updateHC.TabIndex = 3
        Me.updateHC.Text = "Update Holy Communion"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'HCClose
        '
        Me.HCClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCClose.Location = New System.Drawing.Point(685, 181)
        Me.HCClose.Name = "HCClose"
        Me.HCClose.Size = New System.Drawing.Size(112, 34)
        Me.HCClose.TabIndex = 4
        Me.HCClose.Text = "Close"
        Me.HCClose.UseVisualStyleBackColor = True
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 461)
        Me.Controls.Add(Me.HCClose)
        Me.Controls.Add(Me.updateHC)
        Me.Controls.Add(Me.HCLabel)
        Me.Controls.Add(Me.cupTxt)
        Me.Controls.Add(Me.breadTxt)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(825, 500)
        Me.Name = "HolyCommunion"
        Me.Text = "Holy Communion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents breadTxt As TextBox
    Friend WithEvents cupTxt As TextBox
    Friend WithEvents HCLabel As Label
    Friend WithEvents updateHC As Button
    Friend WithEvents HCClose As Button
End Class