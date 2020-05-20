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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StayAvail = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnActive = New Guna.UI.WinForms.GunaGradientButton()
        Me.lblArsh = New System.Windows.Forms.Label()
        Me.btnMinimise = New Guna.UI.WinForms.GunaButton()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblV1 = New System.Windows.Forms.Label()
        Me.lblSa = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StayAvail
        '
        Me.StayAvail.AutoSize = True
        Me.StayAvail.BackColor = System.Drawing.Color.Transparent
        Me.StayAvail.Font = New System.Drawing.Font("Product Sans", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StayAvail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StayAvail.Location = New System.Drawing.Point(230, -82)
        Me.StayAvail.Name = "StayAvail"
        Me.StayAvail.Size = New System.Drawing.Size(383, 76)
        Me.StayAvail.TabIndex = 0
        Me.StayAvail.Text = "StayAvailable"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnActive
        '
        Me.btnActive.Animated = True
        Me.btnActive.AnimationHoverSpeed = 0.07!
        Me.btnActive.AnimationSpeed = 0.2!
        Me.btnActive.BackColor = System.Drawing.Color.Transparent
        Me.btnActive.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnActive.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnActive.BorderColor = System.Drawing.Color.Black
        Me.btnActive.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnActive.FocusedColor = System.Drawing.Color.Empty
        Me.btnActive.Font = New System.Drawing.Font("Product Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnActive.Image = Nothing
        Me.btnActive.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnActive.Location = New System.Drawing.Point(297, 343)
        Me.btnActive.Name = "btnActive"
        Me.btnActive.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnActive.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnActive.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnActive.OnHoverForeColor = System.Drawing.Color.White
        Me.btnActive.OnHoverImage = Nothing
        Me.btnActive.OnPressedColor = System.Drawing.Color.Black
        Me.btnActive.Radius = 25
        Me.btnActive.Size = New System.Drawing.Size(263, 70)
        Me.btnActive.TabIndex = 1
        Me.btnActive.Text = "Activate"
        Me.btnActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblArsh
        '
        Me.lblArsh.AutoSize = True
        Me.lblArsh.BackColor = System.Drawing.Color.Transparent
        Me.lblArsh.Font = New System.Drawing.Font("Product Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArsh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblArsh.Location = New System.Drawing.Point(372, 218)
        Me.lblArsh.Name = "lblArsh"
        Me.lblArsh.Size = New System.Drawing.Size(184, 38)
        Me.lblArsh.TabIndex = 2
        Me.lblArsh.Text = "by Arsh Zilpe"
        '
        'btnMinimise
        '
        Me.btnMinimise.Animated = True
        Me.btnMinimise.AnimationHoverSpeed = 0.07!
        Me.btnMinimise.AnimationSpeed = 0.03!
        Me.btnMinimise.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimise.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMinimise.BorderColor = System.Drawing.Color.Black
        Me.btnMinimise.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMinimise.FocusedColor = System.Drawing.Color.Empty
        Me.btnMinimise.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimise.ForeColor = System.Drawing.Color.White
        Me.btnMinimise.Image = Nothing
        Me.btnMinimise.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMinimise.Location = New System.Drawing.Point(733, 4)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMinimise.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMinimise.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMinimise.OnHoverImage = Nothing
        Me.btnMinimise.OnPressedColor = System.Drawing.Color.Black
        Me.btnMinimise.Radius = 5
        Me.btnMinimise.Size = New System.Drawing.Size(45, 32)
        Me.btnMinimise.TabIndex = 3
        Me.btnMinimise.Text = "‒"
        Me.btnMinimise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semilight", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Nothing
        Me.btnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(788, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Radius = 5
        Me.btnClose.Size = New System.Drawing.Size(45, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "×"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.lblV1)
        Me.GunaPanel1.Controls.Add(Me.lblSa)
        Me.GunaPanel1.Controls.Add(Me.btnMinimise)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Location = New System.Drawing.Point(0, -2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(842, 41)
        Me.GunaPanel1.TabIndex = 5
        '
        'lblV1
        '
        Me.lblV1.AutoSize = True
        Me.lblV1.Font = New System.Drawing.Font("Product Sans", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV1.ForeColor = System.Drawing.Color.Gray
        Me.lblV1.Location = New System.Drawing.Point(48, 10)
        Me.lblV1.Name = "lblV1"
        Me.lblV1.Size = New System.Drawing.Size(45, 24)
        Me.lblV1.TabIndex = 7
        Me.lblV1.Text = "V1.0"
        '
        'lblSa
        '
        Me.lblSa.AutoSize = True
        Me.lblSa.Font = New System.Drawing.Font("Product Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSa.ForeColor = System.Drawing.Color.Transparent
        Me.lblSa.Location = New System.Drawing.Point(12, 6)
        Me.lblSa.Name = "lblSa"
        Me.lblSa.Size = New System.Drawing.Size(40, 30)
        Me.lblSa.TabIndex = 6
        Me.lblSa.Text = "Sa"
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(838, 545)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.lblArsh)
        Me.Controls.Add(Me.btnActive)
        Me.Controls.Add(Me.StayAvail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StayAvailable"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StayAvail As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnActive As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents lblArsh As Label
    Friend WithEvents btnMinimise As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Timer As Timer
    Friend WithEvents lblV1 As Label
    Friend WithEvents lblSa As Label
End Class
