Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtConPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDestinationDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtConPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnBrowseEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnChangeDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnBrowseDecrypt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox5 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox6 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnChangeEncrypt = New System.Windows.Forms.Button()
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtConPassEncrypt = New System.Windows.Forms.TextBox()
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseEncrypt = New System.Windows.Forms.Button()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnChangeDecrypt = New System.Windows.Forms.Button()
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtConPassDecrypt = New System.Windows.Forms.TextBox()
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrowseDecrypt = New System.Windows.Forms.Button()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox5 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox6 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(1, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 282)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.btnChangeEncrypt)
        Me.TabPage1.Controls.Add(Me.txtDestinationEncrypt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Controls.Add(Me.txtConPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPassEncrypt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(584, 249)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt File"
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.Enabled = False
        Me.btnChangeEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(446, 79)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(130, 43)
        Me.btnChangeEncrypt.TabIndex = 11
        Me.btnChangeEncrypt.Text = "Change"
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(212, 87)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = True
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtDestinationEncrypt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(4, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File destination"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Enabled = False
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncrypt.Location = New System.Drawing.Point(446, 164)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEncrypt.Size = New System.Drawing.Size(130, 71)
        Me.btnEncrypt.TabIndex = 8
        Me.btnEncrypt.Text = "ENCRYPT"
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(212, 203)
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtConPassEncrypt.TabIndex = 7
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassEncrypt.Location = New System.Drawing.Point(212, 164)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassEncrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtPassEncrypt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File to encrypt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(4, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(446, 27)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(130, 44)
        Me.btnBrowseEncrypt.TabIndex = 2
        Me.btnBrowseEncrypt.Text = "Browse"
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(212, 33)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtFileToEncrypt.TabIndex = 1
        Me.txtFileToEncrypt.Text = "Click Browse to load file."
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btnChangeDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDestinationDecrypt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.txtConPassDecrypt)
        Me.TabPage2.Controls.Add(Me.txtPassDecrypt)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnBrowseDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(584, 249)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt File"
        '
        'btnChangeDecrypt
        '
        Me.btnChangeDecrypt.Enabled = False
        Me.btnChangeDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChangeDecrypt.Location = New System.Drawing.Point(446, 80)
        Me.btnChangeDecrypt.Name = "btnChangeDecrypt"
        Me.btnChangeDecrypt.Size = New System.Drawing.Size(130, 43)
        Me.btnChangeDecrypt.TabIndex = 22
        Me.btnChangeDecrypt.Text = "Change"
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(212, 85)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = True
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtDestinationDecrypt.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(4, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(187, 31)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File destination"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Enabled = False
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDecrypt.Location = New System.Drawing.Point(446, 166)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(130, 72)
        Me.btnDecrypt.TabIndex = 19
        Me.btnDecrypt.Text = "DECRYPT"
        '
        'txtConPassDecrypt
        '
        Me.txtConPassDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConPassDecrypt.Location = New System.Drawing.Point(212, 203)
        Me.txtConPassDecrypt.Name = "txtConPassDecrypt"
        Me.txtConPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassDecrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtConPassDecrypt.TabIndex = 18
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassDecrypt.Location = New System.Drawing.Point(212, 162)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassDecrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(4, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 32)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "File to decrypt"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(4, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 45)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(1, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Type password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBrowseDecrypt.Location = New System.Drawing.Point(446, 27)
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(130, 46)
        Me.btnBrowseDecrypt.TabIndex = 13
        Me.btnBrowseDecrypt.Text = "Browse"
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(212, 33)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(221, 26)
        Me.txtFileToDecrypt.TabIndex = 12
        Me.txtFileToDecrypt.Text = "Click Browse to load file."
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(1, 312)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(592, 18)
        Me.pbStatus.TabIndex = 1
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.CustomizableEdges = CustomizableEdges27
        Me.Guna2Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        Me.Guna2Panel1.Size = New System.Drawing.Size(598, 28)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.BorderRadius = 4
        Me.Guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox4.CustomizableEdges = CustomizableEdges19
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(993, 7)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(28, 16)
        Me.Guna2ControlBox4.TabIndex = 3
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BorderRadius = 4
        Me.Guna2ControlBox3.CustomizableEdges = CustomizableEdges21
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1027, 7)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(28, 16)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.CustomizableEdges = CustomizableEdges23
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1443, 6)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 19)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2ControlBox1.CustomizableEdges = CustomizableEdges25
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1480, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 19)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox5
        '
        Me.Guna2ControlBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox5.BorderRadius = 4
        Me.Guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox5.CustomizableEdges = CustomizableEdges15
        Me.Guna2ControlBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox5.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox5.Location = New System.Drawing.Point(532, 6)
        Me.Guna2ControlBox5.Name = "Guna2ControlBox5"
        Me.Guna2ControlBox5.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Me.Guna2ControlBox5.Size = New System.Drawing.Size(28, 16)
        Me.Guna2ControlBox5.TabIndex = 5
        '
        'Guna2ControlBox6
        '
        Me.Guna2ControlBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox6.BorderRadius = 4
        Me.Guna2ControlBox6.CustomizableEdges = CustomizableEdges17
        Me.Guna2ControlBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox6.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox6.Location = New System.Drawing.Point(566, 6)
        Me.Guna2ControlBox6.Name = "Guna2ControlBox6"
        Me.Guna2ControlBox6.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Me.Guna2ControlBox6.Size = New System.Drawing.Size(28, 16)
        Me.Guna2ControlBox6.TabIndex = 4
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(593, 336)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encrypt / Decrypt File (Using Rijndael)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "1. Variables "

    '*************************
    '**  Variables
    '*************************

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

#End Region


#Region "2. Membuat Key "

    '*************************
    '** Membuat Key
    '*************************

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Mengubah strPassword ke array dan menyimapan di chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Menggunakan intLength utuk mendapatkan ukuran strPassword.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Menyatakan bytDataToHash dan membuatnya dalam ukuran yg sama sebagai chrData.
        Dim bytDataToHash(intLength) As Byte

        'Menggunakan For Next untuk mengubah dan menyimpan chrData menjadi bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Meyatakan tipe hash.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Menyatakane bytResult, Hash bytDataToHash dan menyimpannya ke bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Menyatakan bytKey(31).  akan menjadi 256 bits.
        Dim bytKey(31) As Byte

        'Menggunakan For Next untuk meletakkan ukuran tertentu (256 bits) dari 
        'bytResult menjadi bytKey. 0 ke 31 akan menempatkan yang pertama 256 bits
        'dari 512 bits menjadi bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'mengembalikan nilai key.
    End Function

#End Region


#Region "3. Membuat IV "

    '*************************
    '** Membuat IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Mengubah strPassword menjadi array dan menyimpannya di chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Menggunakan intLength untuk mendapatkan ukuran strPassword.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Menyatakan bytDataToHash dan membuatnya dalam ukuran yg sama sebagai chrData.
        Dim bytDataToHash(intLength) As Byte

        'Menggunakan For Next untuk mengubah dan menyimpan chrData menjadi bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Meyatakan tipe hash.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Menyatakane bytResult, Hash bytDataToHash dan menyimpannya ke bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Menyatakan bytIV(15).  akan menjadi 128 bits.
        Dim bytIV(15) As Byte

        'Menggunakan For Next untuk meletakkan ukuran tertentu (128 bits) dari
        'bytResult menjadi bytIV. 0 To 30 untuk bytKey menggunakan yg pertama 256 bits.
        'dari hashed password. 32 To 47 akan menempatkan yang berikutnya 128 bits menjadi bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'mengembalikan nilai IV
    End Function

#End Region


#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'menentukan enumeration untuk CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, ByVal strOutputFile As String, ByVal bytKey() As Byte, ByVal bytIV() As Byte, ByVal Direction As CryptoAction)
        Try 'Dalam hal terjadi kesalahan.

            'Setup file streams to untuk menangani input dan output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0) 'meyakinkan fsOutput kosong

            'Menentukan variables untuk proses encrypt/decrypt.
            Dim bytBuffer(4096) As Byte 'memegang blok byte untuk diproses
            Dim lngBytesProcessed As Long = 0 'menjalankan hitungan byte yang diproses
            Dim lngFileLength As Long = fsInput.Length 'panjang file input
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'menyatakan CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            pbStatus.Value = 0
            pbStatus.Maximum = 100

            'Menentukan apakah enkripsi atau dekripsi dan pengaturan CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select

            'Gunakan While untuk mengulang sampai semua file diproses.
            While lngBytesProcessed < lngFileLength
                'Baca file dengan inputt filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Tulis file keluaran dengan cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Menutup FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'Jika mengenkripsi maka hapus file asli yang tidak dienkripsi.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'Jika mendekripsi maka hapus file yang dienkripsi.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Perbarui pengguna saat file selesai.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap +
                        "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToEncrypt.Text = "Click Browse to load file."
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""
                txtDestinationEncrypt.Text = ""
                btnChangeEncrypt.Enabled = False
                btnEncrypt.Enabled = False

            Else
                'Perbarui pengguna saat file selesai.
                MsgBox("Decryption Complete" + Wrap + Wrap +
                       "Total bytes processed = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToDecrypt.Text = "Click Browse to load file."
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""
                txtDestinationDecrypt.Text = ""
                btnChangeDecrypt.Enabled = False
                btnDecrypt.Enabled = False
            End If


            'Catch file tidak ditemukan kesalahan.
        Catch When Err.Number = 53 'jika file tidak ditemukan
            MsgBox("Please check to make sure the path and filename" +
                    "are correct and if the file exists.",
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch semua kesalahan lainnya. Dan hapus sebagian file.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                fileDelete.Delete()
                pbStatus.Value = 0
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" +
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                fileDelete.Delete()

                pbStatus.Value = 0
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.",
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. Browse / Change Button "

    '******************************
    '** Browse/Change Buttons
    '******************************

    Private Sub btnBrowseEncrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowseEncrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to encrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "All Files (*.*) | *.*"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToEncrypt = OpenFileDialog.FileName
            txtFileToEncrypt.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.
            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'Assign strOutputFile to the position after the last "\" in the path.
            'This position is the beginning of the file name.
            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            'Replace the "." in the file extension with "_".
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            'The final file name.  XXXXX.encrypt
            txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
            'Update buttons.
            btnEncrypt.Enabled = True
            btnChangeEncrypt.Enabled = True

        End If

    End Sub

    Private Sub btnBrowseDecrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowseDecrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = OpenFileDialog.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'strOutputFile = the file path minus the last 8 characters (.encrypt)
            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            'Assign strOutputFile to the position after the last "\" in the path.
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            'Replace "_" with "."
            txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            'Update buttons
            btnDecrypt.Enabled = True
            btnChangeDecrypt.Enabled = True

        End If
    End Sub

    Private Sub btnChangeEncrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnChangeEncrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder to place the encrypted file in."
        'If the user selected a folder assign the path to txtDestinationEncrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationEncrypt.Text = FolderBrowserDialog.SelectedPath +
                                         "\" + strOutputEncrypt + ".encrypt"
        End If
    End Sub

    Private Sub btnChangeDecrypt_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles btnChangeDecrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder for to place the decrypted file in."
        'If the user selected a folder assign the path to txtDestinationDecrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationDecrypt.Text = FolderBrowserDialog.SelectedPath +
                                         "\" + strOutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub

#End Region


#Region "6. Tombol Encrypt / Decrypt "

    '******************************
    '** Tombol Encrypt/Decrypt
    '******************************

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        'Memastikan Password benar.
        If txtConPassEncrypt.Text = txtPassEncrypt.Text Then
            'Menyatakan variables untuk key dan iv.
            'Key perlu menampung 256 bit dan iv 128 bit.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'mengirim password ke CreateKey function.
            bytKey = CreateKey(txtPassEncrypt.Text)
            'Mengirim password ke CreateIV function.
            bytIV = CreateIV(txtPassEncrypt.Text)
            'memulai encryption.
            EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text, bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassEncrypt.Text = ""
            txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        'Memastikan Password benar.
        If txtConPassDecrypt.Text = txtPassDecrypt.Text Then
            'Menyatakan variables untuk key dan iv.
            'Key perlu menampung 256 bit dan iv 128 bit.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'mengirim password ke CreateKey function.
            bytKey = CreateKey(txtPassDecrypt.Text)
            'Mengirim password ke CreateIV function.
            bytIV = CreateIV(txtPassDecrypt.Text)
            'memulai decryption.
            EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text, bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassDecrypt.Text = ""
            txtConPassDecrypt.Text = ""
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region




End Class
