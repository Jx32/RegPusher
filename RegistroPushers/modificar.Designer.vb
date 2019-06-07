<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PushersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegPushersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New RegistroPushers.databaseDataSet()
        Me.RegPushersTableAdapter = New RegistroPushers.databaseDataSetTableAdapters.regPushersTableAdapter()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegPushersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AssetDescDataGridViewTextBoxColumn, Me.AssetIDDataGridViewTextBoxColumn, Me.AssetModelDataGridViewTextBoxColumn, Me.PushersDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.LocDataGridViewTextBoxColumn, Me.MotiveDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatorIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegPushersBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(696, 431)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'AssetDescDataGridViewTextBoxColumn
        '
        Me.AssetDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AssetDescDataGridViewTextBoxColumn.DataPropertyName = "AssetDesc"
        Me.AssetDescDataGridViewTextBoxColumn.HeaderText = "Descripcion de Equipo"
        Me.AssetDescDataGridViewTextBoxColumn.Name = "AssetDescDataGridViewTextBoxColumn"
        Me.AssetDescDataGridViewTextBoxColumn.Width = 97
        '
        'AssetIDDataGridViewTextBoxColumn
        '
        Me.AssetIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AssetIDDataGridViewTextBoxColumn.DataPropertyName = "assetID"
        Me.AssetIDDataGridViewTextBoxColumn.HeaderText = "Blue tag"
        Me.AssetIDDataGridViewTextBoxColumn.Name = "AssetIDDataGridViewTextBoxColumn"
        Me.AssetIDDataGridViewTextBoxColumn.Width = 66
        '
        'AssetModelDataGridViewTextBoxColumn
        '
        Me.AssetModelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AssetModelDataGridViewTextBoxColumn.DataPropertyName = "assetModel"
        Me.AssetModelDataGridViewTextBoxColumn.HeaderText = "Modelo equipo"
        Me.AssetModelDataGridViewTextBoxColumn.Name = "AssetModelDataGridViewTextBoxColumn"
        Me.AssetModelDataGridViewTextBoxColumn.Width = 94
        '
        'PushersDataGridViewTextBoxColumn
        '
        Me.PushersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PushersDataGridViewTextBoxColumn.DataPropertyName = "pushers"
        Me.PushersDataGridViewTextBoxColumn.HeaderText = "Cant. Pushers"
        Me.PushersDataGridViewTextBoxColumn.Name = "PushersDataGridViewTextBoxColumn"
        Me.PushersDataGridViewTextBoxColumn.Width = 90
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Accion"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 65
        '
        'LocDataGridViewTextBoxColumn
        '
        Me.LocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LocDataGridViewTextBoxColumn.DataPropertyName = "loc"
        Me.LocDataGridViewTextBoxColumn.HeaderText = "Localidad(es)"
        Me.LocDataGridViewTextBoxColumn.Name = "LocDataGridViewTextBoxColumn"
        Me.LocDataGridViewTextBoxColumn.Width = 95
        '
        'MotiveDataGridViewTextBoxColumn
        '
        Me.MotiveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MotiveDataGridViewTextBoxColumn.DataPropertyName = "motive"
        Me.MotiveDataGridViewTextBoxColumn.HeaderText = "Motivo(s)"
        Me.MotiveDataGridViewTextBoxColumn.Name = "MotiveDataGridViewTextBoxColumn"
        Me.MotiveDataGridViewTextBoxColumn.Width = 75
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt"
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "Fecha de Creacion"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.Width = 112
        '
        'CreatorIDDataGridViewTextBoxColumn
        '
        Me.CreatorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CreatorIDDataGridViewTextBoxColumn.DataPropertyName = "creatorID"
        Me.CreatorIDDataGridViewTextBoxColumn.HeaderText = "ID Creador"
        Me.CreatorIDDataGridViewTextBoxColumn.Name = "CreatorIDDataGridViewTextBoxColumn"
        Me.CreatorIDDataGridViewTextBoxColumn.Width = 77
        '
        'RegPushersBindingSource
        '
        Me.RegPushersBindingSource.DataMember = "regPushers"
        Me.RegPushersBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegPushersTableAdapter
        '
        Me.RegPushersTableAdapter.ClearBeforeFill = True
        '
        'DatabaseDataSetBindingSource
        '
        Me.DatabaseDataSetBindingSource.DataSource = Me.DatabaseDataSet
        Me.DatabaseDataSetBindingSource.Position = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.xlsx"
        Me.SaveFileDialog1.Filter = "Hojas de calculo de Excel |*.xlsx"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripMenuItem1.Text = "Registros"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem2.Text = "Exportar a formato Excel"
        '
        'modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 455)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegPushersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSet As databaseDataSet
    Friend WithEvents RegPushersBindingSource As BindingSource
    Friend WithEvents RegPushersTableAdapter As databaseDataSetTableAdapters.regPushersTableAdapter
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PushersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotiveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
