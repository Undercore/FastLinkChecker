<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LB_Checked = New System.Windows.Forms.ListBox()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.TimeOUT = New System.Windows.Forms.NumericUpDown()
        Me.Time_OUT = New System.Windows.Forms.Label()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        CType(Me.TimeOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_Checked
        '
        Me.LB_Checked.FormattingEnabled = True
        Me.LB_Checked.ItemHeight = 20
        Me.LB_Checked.Location = New System.Drawing.Point(12, 13)
        Me.LB_Checked.Name = "LB_Checked"
        Me.LB_Checked.Size = New System.Drawing.Size(1123, 364)
        Me.LB_Checked.TabIndex = 0
        '
        'btn_Check
        '
        Me.btn_Check.Location = New System.Drawing.Point(13, 383)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(148, 38)
        Me.btn_Check.TabIndex = 1
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'TimeOUT
        '
        Me.TimeOUT.Location = New System.Drawing.Point(168, 395)
        Me.TimeOUT.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TimeOUT.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeOUT.Name = "TimeOUT"
        Me.TimeOUT.Size = New System.Drawing.Size(120, 26)
        Me.TimeOUT.TabIndex = 4
        Me.TimeOUT.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'Time_OUT
        '
        Me.Time_OUT.AutoSize = True
        Me.Time_OUT.Location = New System.Drawing.Point(286, 401)
        Me.Time_OUT.Name = "Time_OUT"
        Me.Time_OUT.Size = New System.Drawing.Size(71, 20)
        Me.Time_OUT.TabIndex = 5
        Me.Time_OUT.Text = "Time-out"
        '
        'btn_Export
        '
        Me.btn_Export.Location = New System.Drawing.Point(987, 383)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(148, 38)
        Me.btn_Export.TabIndex = 6
        Me.btn_Export.Text = "Export"
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(833, 383)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(148, 38)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 433)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Export)
        Me.Controls.Add(Me.Time_OUT)
        Me.Controls.Add(Me.TimeOUT)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.LB_Checked)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Link Checker"
        CType(Me.TimeOUT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_Checked As ListBox
    Friend WithEvents btn_Check As Button
    Friend WithEvents TimeOUT As NumericUpDown
    Friend WithEvents Time_OUT As Label
    Friend WithEvents btn_Export As Button
    Friend WithEvents btn_Exit As Button
End Class
