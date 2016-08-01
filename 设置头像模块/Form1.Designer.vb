<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HeadPictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomHeadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.HeadPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeadPictureBox
        '
        Me.HeadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HeadPictureBox.Image = CType(resources.GetObject("HeadPictureBox.Image"), System.Drawing.Image)
        Me.HeadPictureBox.Location = New System.Drawing.Point(49, 55)
        Me.HeadPictureBox.Name = "HeadPictureBox"
        Me.HeadPictureBox.Size = New System.Drawing.Size(191, 191)
        Me.HeadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.HeadPictureBox.TabIndex = 0
        Me.HeadPictureBox.TabStop = False
        '
        'CustomHeadDialog
        '
        Me.CustomHeadDialog.Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.wmf|All Files|*.*"
        Me.CustomHeadDialog.Title = "Please select the path of custom head."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(306, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 323)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HeadPictureBox)
        Me.Name = "Form1"
        Me.Text = "设置头像"
        CType(Me.HeadPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeadPictureBox As PictureBox
    Friend WithEvents CustomHeadDialog As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
