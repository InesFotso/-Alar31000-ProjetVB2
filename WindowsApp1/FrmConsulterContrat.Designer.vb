﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulterContrat
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
        Me.Titre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.SteelBlue
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(305, 11)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(457, 28)
        Me.Titre.TabIndex = 41
        Me.Titre.Text = "La liste des clients et des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 49)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 500)
        Me.DataGridView1.TabIndex = 40
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BtnQuitter.Location = New System.Drawing.Point(963, 571)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(125, 46)
        Me.BtnQuitter.TabIndex = 39
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FrmConsulterContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 624)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmConsulterContrat"
        Me.Text = "Consulter Contrat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titre As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnQuitter As Button
End Class
