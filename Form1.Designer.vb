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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CheckBox1.Location = New Point(55, 132)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(124, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "champignions"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CheckBox2.Location = New Point(57, 181)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(69, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "olives"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(57, 226)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(79, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "poivres"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CheckBox4.Location = New Point(57, 265)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(197, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "fromage supplimentaires"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(57, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(313, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(265, 57)
        Button1.TabIndex = 5
        Button1.Text = "afficher le récapitulatif"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        RadioButton1.Location = New Point(57, 78)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(101, 24)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "croute fine"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        RadioButton2.Location = New Point(294, 78)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(136, 24)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "croute classique"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(569, 78)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(123, 24)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "croute epaise "
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton

End Class
