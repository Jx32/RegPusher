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
        Me.MotiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegPushersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New RegistroPushers.databaseDataSet()
        Me.RegPushersTableAdapter = New RegistroPushers.databaseDataSetTableAdapters.regPushersTableAdapter()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegPushersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AssetDescDataGridViewTextBoxColumn, Me.AssetIDDataGridViewTextBoxColumn, Me.AssetModelDataGridViewTextBoxColumn, Me.PushersDataGridViewTextBoxColumn, Me.MotiveDataGridViewTextBoxColumn, Me.LocDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CreatorIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegPushersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(105, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(517, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'AssetDescDataGridViewTextBoxColumn
        '
        Me.AssetDescDataGridViewTextBoxColumn.DataPropertyName = "AssetDesc"
        Me.AssetDescDataGridViewTextBoxColumn.HeaderText = "AssetDesc"
        Me.AssetDescDataGridViewTextBoxColumn.Name = "AssetDescDataGridViewTextBoxColumn"
        '
        'AssetIDDataGridViewTextBoxColumn
        '
        Me.AssetIDDataGridViewTextBoxColumn.DataPropertyName = "assetID"
        Me.AssetIDDataGridViewTextBoxColumn.HeaderText = "assetID"
        Me.AssetIDDataGridViewTextBoxColumn.Name = "AssetIDDataGridViewTextBoxColumn"
        '
        'AssetModelDataGridViewTextBoxColumn
        '
        Me.AssetModelDataGridViewTextBoxColumn.DataPropertyName = "assetModel"
        Me.AssetModelDataGridViewTextBoxColumn.HeaderText = "assetModel"
        Me.AssetModelDataGridViewTextBoxColumn.Name = "AssetModelDataGridViewTextBoxColumn"
        '
        'PushersDataGridViewTextBoxColumn
        '
        Me.PushersDataGridViewTextBoxColumn.DataPropertyName = "pushers"
        Me.PushersDataGridViewTextBoxColumn.HeaderText = "pushers"
        Me.PushersDataGridViewTextBoxColumn.Name = "PushersDataGridViewTextBoxColumn"
        '
        'MotiveDataGridViewTextBoxColumn
        '
        Me.MotiveDataGridViewTextBoxColumn.DataPropertyName = "motive"
        Me.MotiveDataGridViewTextBoxColumn.HeaderText = "motive"
        Me.MotiveDataGridViewTextBoxColumn.Name = "MotiveDataGridViewTextBoxColumn"
        '
        'LocDataGridViewTextBoxColumn
        '
        Me.LocDataGridViewTextBoxColumn.DataPropertyName = "loc"
        Me.LocDataGridViewTextBoxColumn.HeaderText = "loc"
        Me.LocDataGridViewTextBoxColumn.Name = "LocDataGridViewTextBoxColumn"
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt"
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "createdAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'CreatorIDDataGridViewTextBoxColumn
        '
        Me.CreatorIDDataGridViewTextBoxColumn.DataPropertyName = "creatorID"
        Me.CreatorIDDataGridViewTextBoxColumn.HeaderText = "creatorID"
        Me.CreatorIDDataGridViewTextBoxColumn.Name = "CreatorIDDataGridViewTextBoxColumn"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exportar a Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.xlsx"
        Me.SaveFileDialog1.Filter = "Hojas de calculo de Excel |*.xlsx"
        '
        'modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegPushersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSet As databaseDataSet
    Friend WithEvents RegPushersBindingSource As BindingSource
    Friend WithEvents RegPushersTableAdapter As databaseDataSetTableAdapters.regPushersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PushersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotiveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
