﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cnt019_Kaskorse
    Inherits ProbarSiparis.BaseControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnt019_Kaskorse))
        Me.NeoTable1 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable1_nID = New System.Data.DataColumn()
        Me.NeoTable1_Deleted = New System.Data.DataColumn()
        Me.NeoTable1_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable1_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable1_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable1_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable1_Iplik = New System.Data.DataColumn()
        Me.NeoTable1_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable1_GramajArtis = New System.Data.DataColumn()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.txtTurArtis = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTur = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbIplik = New NeoDAC.NeoTable(Me.components)
        Me.tbIplik_IplikID = New System.Data.DataColumn()
        Me.tbIplik_IplikKod = New System.Data.DataColumn()
        Me.tbIplik_IplikIsmi = New System.Data.DataColumn()
        Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.tbRenk = New NeoDAC.NeoTable(Me.components)
        Me.tbRenk_RenkID = New System.Data.DataColumn()
        Me.tbRenk_Deleted = New System.Data.DataColumn()
        Me.tbRenk_CreatedBy = New System.Data.DataColumn()
        Me.tbRenk_CreatedDate = New System.Data.DataColumn()
        Me.tbRenk_ModifiedBy = New System.Data.DataColumn()
        Me.tbRenk_ModifiedDate = New System.Data.DataColumn()
        Me.tbRenk_RenkKod = New System.Data.DataColumn()
        Me.tbRenk_RenkIsmi = New System.Data.DataColumn()
        Me.tbRenk_IntCode = New System.Data.DataColumn()
        Me.tbRenk_Pasif = New System.Data.DataColumn()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.NeoTable2 = New NeoDAC.NeoTable(Me.components)
        Me.NeoTable2_nID = New System.Data.DataColumn()
        Me.NeoTable2_Deleted = New System.Data.DataColumn()
        Me.NeoTable2_CreatedBy = New System.Data.DataColumn()
        Me.NeoTable2_CreatedDate = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedBy = New System.Data.DataColumn()
        Me.NeoTable2_ModifiedDate = New System.Data.DataColumn()
        Me.NeoTable2_SipDetayParamID = New System.Data.DataColumn()
        Me.NeoTable2_SourceID = New System.Data.DataColumn()
        Me.NeoTable2_KategoriParamID = New System.Data.DataColumn()
        Me.NeoTable2_RenkID = New System.Data.DataColumn()
        Me.NeoTable2_Iplik = New System.Data.DataColumn()
        Me.NeoTable2_IpGramaj = New System.Data.DataColumn()
        Me.NeoTable2_GramajArtis = New System.Data.DataColumn()
        Me.SqlCommand40 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand38 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand37 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand39 = New System.Data.SqlClient.SqlCommand()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand36 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand34 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand33 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand35 = New System.Data.SqlClient.SqlCommand()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCaption.SuspendLayout()
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.Location = New System.Drawing.Point(2, 2)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCaption.Size = New System.Drawing.Size(146, 22)
        Me.lblCaption.Text = "Kaşkorse"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.XtraTabControl1.Size = New System.Drawing.Size(247, 96)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtTur)
        Me.XtraTabPage1.Controls.Add(Me.txtTurArtis)
        Me.XtraTabPage1.Controls.Add(Me.LookUpEdit1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabPage1.Size = New System.Drawing.Size(241, 68)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabPage2.Size = New System.Drawing.Size(241, 68)
        Me.XtraTabPage2.Text = "Kaşkorse"
        '
        'SqlConn
        '
        Me.SqlConn.ConnectionString = "Server=(local)\sql2012;Database=ProbarSiparisDB3;User ID=sa;Password=;Trusted_Con" &
    "nection=True;"
        '
        'panelCaption
        '
        Me.panelCaption.Margin = New System.Windows.Forms.Padding(5)
        Me.panelCaption.Size = New System.Drawing.Size(247, 26)
        '
        'chkSecmeli
        '
        Me.chkSecmeli.Location = New System.Drawing.Point(187, 2)
        Me.chkSecmeli.Margin = New System.Windows.Forms.Padding(4)
        '
        'chkVar
        '
        Me.chkVar.Location = New System.Drawing.Point(148, 2)
        Me.chkVar.Margin = New System.Windows.Forms.Padding(4)
        '
        'NeoTable1
        '
        Me.NeoTable1.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable1_nID, Me.NeoTable1_Deleted, Me.NeoTable1_CreatedBy, Me.NeoTable1_CreatedDate, Me.NeoTable1_ModifiedBy, Me.NeoTable1_ModifiedDate, Me.NeoTable1_KategoriParamID, Me.NeoTable1_Iplik, Me.NeoTable1_IpGramaj, Me.NeoTable1_GramajArtis})
        Me.NeoTable1.Connection = Me.SqlConn
        Me.NeoTable1.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable1.CurrentRow = Nothing
        Me.NeoTable1.DataSourceLink = Nothing
        Me.NeoTable1.DeleteCommand = Me.SqlCommand4
        Me.NeoTable1.Filter = ""
        Me.NeoTable1.InsertCommand = Me.SqlCommand2
        Me.NeoTable1.LiveSave = False
        Me.NeoTable1.MaxRecords = CType(0, Long)
        Me.NeoTable1.Name = "NeoTable1"
        Me.NeoTable1.ParentRelation_ChildColumns = Nothing
        Me.NeoTable1.ParentRelation_ParentColumns = Nothing
        Me.NeoTable1.ParentRelation_Table = Nothing
        Me.NeoTable1.Position = CType(-1, Long)
        Me.NeoTable1.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable1_nID}
        Me.NeoTable1.Quoted = False
        Me.NeoTable1.SelectCommand = Me.SqlCommand1
        Me.NeoTable1.TableName = "NeoTable1"
        Me.NeoTable1.Transaction = Nothing
        Me.NeoTable1.UpdateCommand = Me.SqlCommand3
        '
        'NeoTable1_nID
        '
        Me.NeoTable1_nID.AllowDBNull = False
        Me.NeoTable1_nID.AutoIncrement = True
        Me.NeoTable1_nID.ColumnName = "nID"
        Me.NeoTable1_nID.DataType = GetType(Integer)
        '
        'NeoTable1_Deleted
        '
        Me.NeoTable1_Deleted.ColumnName = "Deleted"
        Me.NeoTable1_Deleted.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedBy
        '
        Me.NeoTable1_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable1_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable1_CreatedDate
        '
        Me.NeoTable1_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable1_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable1_ModifiedBy
        '
        Me.NeoTable1_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable1_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable1_ModifiedDate
        '
        Me.NeoTable1_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable1_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable1_KategoriParamID
        '
        Me.NeoTable1_KategoriParamID.ColumnName = "KategoriParamID"
        Me.NeoTable1_KategoriParamID.DataType = GetType(Integer)
        '
        'NeoTable1_Iplik
        '
        Me.NeoTable1_Iplik.ColumnName = "Iplik"
        Me.NeoTable1_Iplik.DataType = GetType(Integer)
        '
        'NeoTable1_IpGramaj
        '
        Me.NeoTable1_IpGramaj.ColumnName = "IpGramaj"
        Me.NeoTable1_IpGramaj.DataType = GetType(Integer)
        '
        'NeoTable1_GramajArtis
        '
        Me.NeoTable1_GramajArtis.ColumnName = "GramajArtis"
        Me.NeoTable1_GramajArtis.DataType = GetType(Integer)
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE KategoriParam_019_Kaskorse SET Deleted = nID  , ModifiedBy = @ModifiedBy ," &
    " ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         KategoriParam_019_Kaskorse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM CizgiRenkKafaLakos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTurArtis
        '
        Me.txtTurArtis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "GramajArtis", True))
        Me.txtTurArtis.Location = New System.Drawing.Point(184, 17)
        Me.txtTurArtis.Name = "txtTurArtis"
        Me.txtTurArtis.Size = New System.Drawing.Size(47, 20)
        Me.txtTurArtis.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(194, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Artış"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(127, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "İp Grm."
        '
        'txtTur
        '
        Me.txtTur.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "IpGramaj", True))
        Me.txtTur.Location = New System.Drawing.Point(127, 17)
        Me.txtTur.Name = "txtTur"
        Me.txtTur.Size = New System.Drawing.Size(47, 20)
        Me.txtTur.TabIndex = 2
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable1, "Iplik", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(3, 17)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit1.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit1.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit1.Properties.ValueMember = "IplikID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit1.TabIndex = 1
        '
        'tbIplik
        '
        Me.tbIplik.Columns.AddRange(New System.Data.DataColumn() {Me.tbIplik_IplikID, Me.tbIplik_IplikKod, Me.tbIplik_IplikIsmi})
        Me.tbIplik.Connection = Me.SqlConn
        Me.tbIplik.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"IplikID"}, True)})
        Me.tbIplik.CurrentRow = Nothing
        Me.tbIplik.DataSourceLink = Nothing
        Me.tbIplik.DeleteCommand = Me.SqlCommand12
        Me.tbIplik.Filter = ""
        Me.tbIplik.InsertCommand = Me.SqlCommand10
        Me.tbIplik.LiveSave = False
        Me.tbIplik.MaxRecords = CType(0, Long)
        Me.tbIplik.Name = "tbIplik"
        Me.tbIplik.ParentRelation_ChildColumns = Nothing
        Me.tbIplik.ParentRelation_ParentColumns = Nothing
        Me.tbIplik.ParentRelation_Table = Nothing
        Me.tbIplik.Position = CType(-1, Long)
        Me.tbIplik.PrimaryKey = New System.Data.DataColumn() {Me.tbIplik_IplikID}
        Me.tbIplik.Quoted = False
        Me.tbIplik.SelectCommand = Me.SqlCommand9
        Me.tbIplik.TableName = "NeoTable2"
        Me.tbIplik.Transaction = Nothing
        Me.tbIplik.UpdateCommand = Me.SqlCommand11
        '
        'tbIplik_IplikID
        '
        Me.tbIplik_IplikID.AllowDBNull = False
        Me.tbIplik_IplikID.AutoIncrement = True
        Me.tbIplik_IplikID.ColumnName = "IplikID"
        Me.tbIplik_IplikID.DataType = GetType(Integer)
        '
        'tbIplik_IplikKod
        '
        Me.tbIplik_IplikKod.ColumnName = "IplikKod"
        '
        'tbIplik_IplikIsmi
        '
        Me.tbIplik_IplikIsmi.ColumnName = "IplikIsmi"
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT IplikID" & Global.Microsoft.VisualBasic.ChrW(9) & ",IplikKod,IplikIsmi FROM Iplikler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "HMD"
        '
        'SqlCommand28
        '
        Me.SqlCommand28.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Cizgiler SET Deleted = nID  , ModifiedBy = @Mo" &
    "difiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand25
        '
        Me.SqlCommand25.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand27
        '
        Me.SqlCommand27.CommandText = resources.GetString("SqlCommand27.CommandText")
        '
        'tbRenk
        '
        Me.tbRenk.Columns.AddRange(New System.Data.DataColumn() {Me.tbRenk_RenkID, Me.tbRenk_Deleted, Me.tbRenk_CreatedBy, Me.tbRenk_CreatedDate, Me.tbRenk_ModifiedBy, Me.tbRenk_ModifiedDate, Me.tbRenk_RenkKod, Me.tbRenk_RenkIsmi, Me.tbRenk_IntCode, Me.tbRenk_Pasif})
        Me.tbRenk.Connection = Me.SqlConn
        Me.tbRenk.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"RenkID"}, True)})
        Me.tbRenk.CurrentRow = Nothing
        Me.tbRenk.DataSourceLink = Nothing
        Me.tbRenk.DeleteCommand = Me.SqlCommand16
        Me.tbRenk.Filter = ""
        Me.tbRenk.InsertCommand = Me.SqlCommand14
        Me.tbRenk.LiveSave = False
        Me.tbRenk.MaxRecords = CType(0, Long)
        Me.tbRenk.Name = "tbRenk"
        Me.tbRenk.ParentRelation_ChildColumns = Nothing
        Me.tbRenk.ParentRelation_ParentColumns = Nothing
        Me.tbRenk.ParentRelation_Table = Nothing
        Me.tbRenk.Position = CType(-1, Long)
        Me.tbRenk.PrimaryKey = New System.Data.DataColumn() {Me.tbRenk_RenkID}
        Me.tbRenk.Quoted = False
        Me.tbRenk.SelectCommand = Me.SqlCommand13
        Me.tbRenk.TableName = "NeoTable2"
        Me.tbRenk.Transaction = Nothing
        Me.tbRenk.UpdateCommand = Me.SqlCommand15
        '
        'tbRenk_RenkID
        '
        Me.tbRenk_RenkID.AllowDBNull = False
        Me.tbRenk_RenkID.AutoIncrement = True
        Me.tbRenk_RenkID.ColumnName = "RenkID"
        Me.tbRenk_RenkID.DataType = GetType(Integer)
        '
        'tbRenk_Deleted
        '
        Me.tbRenk_Deleted.ColumnName = "Deleted"
        Me.tbRenk_Deleted.DataType = GetType(Integer)
        '
        'tbRenk_CreatedBy
        '
        Me.tbRenk_CreatedBy.ColumnName = "CreatedBy"
        Me.tbRenk_CreatedBy.DataType = GetType(Integer)
        '
        'tbRenk_CreatedDate
        '
        Me.tbRenk_CreatedDate.ColumnName = "CreatedDate"
        Me.tbRenk_CreatedDate.DataType = GetType(Date)
        '
        'tbRenk_ModifiedBy
        '
        Me.tbRenk_ModifiedBy.ColumnName = "ModifiedBy"
        Me.tbRenk_ModifiedBy.DataType = GetType(Integer)
        '
        'tbRenk_ModifiedDate
        '
        Me.tbRenk_ModifiedDate.ColumnName = "ModifiedDate"
        Me.tbRenk_ModifiedDate.DataType = GetType(Date)
        '
        'tbRenk_RenkKod
        '
        Me.tbRenk_RenkKod.ColumnName = "RenkKod"
        '
        'tbRenk_RenkIsmi
        '
        Me.tbRenk_RenkIsmi.ColumnName = "RenkIsmi"
        '
        'tbRenk_IntCode
        '
        Me.tbRenk_IntCode.ColumnName = "IntCode"
        '
        'tbRenk_Pasif
        '
        Me.tbRenk_Pasif.ColumnName = "Pasif"
        Me.tbRenk_Pasif.DataType = GetType(Integer)
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = "SELECT * FROM Renkler WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = "UPDATE SipDetayParam_014_Manset6cm SET Deleted = nID  , ModifiedBy = @ModifiedBy " &
    ", ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = resources.GetString("SqlCommand18.CommandText")
        Me.SqlCommand18.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_014_Manset6cm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = resources.GetString("SqlCommand19.CommandText")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.TextEdit1)
        Me.PanelControl2.Controls.Add(Me.TextEdit3)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit8)
        Me.PanelControl2.Controls.Add(Me.LabelControl12)
        Me.PanelControl2.Controls.Add(Me.LabelControl13)
        Me.PanelControl2.Controls.Add(Me.LookUpEdit2)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(241, 71)
        Me.PanelControl2.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(6, 28)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl11.TabIndex = 13
        Me.LabelControl11.Text = "Tur"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "IpGramaj", True))
        Me.TextEdit1.Location = New System.Drawing.Point(129, 42)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit1.TabIndex = 9
        '
        'NeoTable2
        '
        Me.NeoTable2.Columns.AddRange(New System.Data.DataColumn() {Me.NeoTable2_nID, Me.NeoTable2_Deleted, Me.NeoTable2_CreatedBy, Me.NeoTable2_CreatedDate, Me.NeoTable2_ModifiedBy, Me.NeoTable2_ModifiedDate, Me.NeoTable2_SipDetayParamID, Me.NeoTable2_SourceID, Me.NeoTable2_KategoriParamID, Me.NeoTable2_RenkID, Me.NeoTable2_Iplik, Me.NeoTable2_IpGramaj, Me.NeoTable2_GramajArtis})
        Me.NeoTable2.Connection = Me.SqlConn
        Me.NeoTable2.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"nID"}, True)})
        Me.NeoTable2.CurrentRow = Nothing
        Me.NeoTable2.DataSourceLink = Nothing
        Me.NeoTable2.DeleteCommand = Me.SqlCommand40
        Me.NeoTable2.Filter = ""
        Me.NeoTable2.InsertCommand = Me.SqlCommand38
        Me.NeoTable2.LiveSave = False
        Me.NeoTable2.MaxRecords = CType(0, Long)
        Me.NeoTable2.Name = "NeoTable2"
        Me.NeoTable2.ParentRelation_ChildColumns = Nothing
        Me.NeoTable2.ParentRelation_ParentColumns = Nothing
        Me.NeoTable2.ParentRelation_Table = Nothing
        Me.NeoTable2.Position = CType(-1, Long)
        Me.NeoTable2.PrimaryKey = New System.Data.DataColumn() {Me.NeoTable2_nID}
        Me.NeoTable2.Quoted = False
        Me.NeoTable2.SelectCommand = Me.SqlCommand37
        Me.NeoTable2.TableName = "NeoTable2"
        Me.NeoTable2.Transaction = Nothing
        Me.NeoTable2.UpdateCommand = Me.SqlCommand39
        '
        'NeoTable2_nID
        '
        Me.NeoTable2_nID.AllowDBNull = False
        Me.NeoTable2_nID.AutoIncrement = True
        Me.NeoTable2_nID.ColumnName = "nID"
        Me.NeoTable2_nID.DataType = GetType(Integer)
        '
        'NeoTable2_Deleted
        '
        Me.NeoTable2_Deleted.ColumnName = "Deleted"
        Me.NeoTable2_Deleted.DataType = GetType(Integer)
        '
        'NeoTable2_CreatedBy
        '
        Me.NeoTable2_CreatedBy.ColumnName = "CreatedBy"
        Me.NeoTable2_CreatedBy.DataType = GetType(Integer)
        '
        'NeoTable2_CreatedDate
        '
        Me.NeoTable2_CreatedDate.ColumnName = "CreatedDate"
        Me.NeoTable2_CreatedDate.DataType = GetType(Date)
        '
        'NeoTable2_ModifiedBy
        '
        Me.NeoTable2_ModifiedBy.ColumnName = "ModifiedBy"
        Me.NeoTable2_ModifiedBy.DataType = GetType(Integer)
        '
        'NeoTable2_ModifiedDate
        '
        Me.NeoTable2_ModifiedDate.ColumnName = "ModifiedDate"
        Me.NeoTable2_ModifiedDate.DataType = GetType(Date)
        '
        'NeoTable2_SipDetayParamID
        '
        Me.NeoTable2_SipDetayParamID.ColumnName = "SipDetayParamID"
        Me.NeoTable2_SipDetayParamID.DataType = GetType(Integer)
        '
        'NeoTable2_SourceID
        '
        Me.NeoTable2_SourceID.ColumnName = "SourceID"
        Me.NeoTable2_SourceID.DataType = GetType(Integer)
        '
        'NeoTable2_KategoriParamID
        '
        Me.NeoTable2_KategoriParamID.ColumnName = "KategoriParamID"
        Me.NeoTable2_KategoriParamID.DataType = GetType(Integer)
        '
        'NeoTable2_RenkID
        '
        Me.NeoTable2_RenkID.ColumnName = "RenkID"
        Me.NeoTable2_RenkID.DataType = GetType(Integer)
        '
        'NeoTable2_Iplik
        '
        Me.NeoTable2_Iplik.ColumnName = "Iplik"
        Me.NeoTable2_Iplik.DataType = GetType(Integer)
        '
        'NeoTable2_IpGramaj
        '
        Me.NeoTable2_IpGramaj.ColumnName = "IpGramaj"
        Me.NeoTable2_IpGramaj.DataType = GetType(Integer)
        '
        'NeoTable2_GramajArtis
        '
        Me.NeoTable2_GramajArtis.ColumnName = "GramajArtis"
        Me.NeoTable2_GramajArtis.DataType = GetType(Integer)
        '
        'SqlCommand40
        '
        Me.SqlCommand40.CommandText = "UPDATE SipDetayParam_019_Kaskorse SET Deleted = nID  , ModifiedBy = @ModifiedBy ," &
    " ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand38
        '
        Me.SqlCommand38.CommandText = resources.GetString("SqlCommand38.CommandText")
        '
        'SqlCommand37
        '
        Me.SqlCommand37.CommandText = "SELECT * FROM SipDetayParam_019_Kaskorse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 "
        '
        'SqlCommand39
        '
        Me.SqlCommand39.CommandText = resources.GetString("SqlCommand39.CommandText")
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "GramajArtis", True))
        Me.TextEdit3.Location = New System.Drawing.Point(187, 42)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit3.TabIndex = 12
        '
        'LookUpEdit8
        '
        Me.LookUpEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "Iplik", True))
        Me.LookUpEdit8.Location = New System.Drawing.Point(6, 42)
        Me.LookUpEdit8.Name = "LookUpEdit8"
        Me.LookUpEdit8.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit8.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikKod", "Iplik Kod", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikIsmi", "Iplik Ismi", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IplikID", "Iplik ID", 56, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit8.Properties.DataSource = Me.tbIplik
        Me.LookUpEdit8.Properties.DisplayMember = "IplikKod"
        Me.LookUpEdit8.Properties.NullText = ""
        Me.LookUpEdit8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit8.Properties.ValueMember = "IplikID"
        Me.LookUpEdit8.Size = New System.Drawing.Size(118, 20)
        Me.LookUpEdit8.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(129, 28)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "İp Grm."
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(197, 28)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl13.TabIndex = 11
        Me.LabelControl13.Text = "Artış"
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.NeoTable2, "RenkID", True))
        Me.LookUpEdit2.EnterMoveNextControl = True
        Me.LookUpEdit2.Location = New System.Drawing.Point(37, 3)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEdit2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkKod", "Renk Kod", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkIsmi", "Renk Ismi", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RenkID", "Renk ID", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit2.Properties.DataSource = Me.tbRenk
        Me.LookUpEdit2.Properties.DisplayMember = "RenkKod"
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit2.Properties.ValueMember = "RenkID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(167, 20)
        Me.LookUpEdit2.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Renk"
        '
        'SqlCommand24
        '
        Me.SqlCommand24.CommandText = "DELETE FROM SipDetayParam_002_Lastik_Kol WHERE nID = @nID"
        '
        'SqlCommand22
        '
        Me.SqlCommand22.CommandText = resources.GetString("SqlCommand22.CommandText")
        Me.SqlCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = "SELECT     *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         SipDetayParam_002_Lastik_Kol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE 1=1 "
        '
        'SqlCommand23
        '
        Me.SqlCommand23.CommandText = "UPDATE SipDetayParam_002_Lastik_Kol SET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SipDetayParamID = @SipDetayParamID , So" &
    "urceID = @SourceID , KategoriParamID = @KategoriParamID , CizgiSayisi = @CizgiSa" &
    "yisi , RKafa = @RKafa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE nID = @nID"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Tur"
        '
        'SqlCommand32
        '
        Me.SqlCommand32.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Garni1Cizgiler SET Deleted = nID  , ModifiedBy" &
    " = @ModifiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand30
        '
        Me.SqlCommand30.CommandText = resources.GetString("SqlCommand30.CommandText")
        Me.SqlCommand30.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand29
        '
        Me.SqlCommand29.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Garni1Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand31
        '
        Me.SqlCommand31.CommandText = resources.GetString("SqlCommand31.CommandText")
        '
        'SqlCommand36
        '
        Me.SqlCommand36.CommandText = "UPDATE SipDetayParam_014_Manset6cm_Garni2Cizgiler SET Deleted = nID  , ModifiedBy" &
    " = @ModifiedBy , ModifiedDate = GETDATE()   WHERE nID = @nID"
        '
        'SqlCommand34
        '
        Me.SqlCommand34.CommandText = resources.GetString("SqlCommand34.CommandText")
        Me.SqlCommand34.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, True, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, 0)})
        '
        'SqlCommand33
        '
        Me.SqlCommand33.CommandText = "SELECT * FROM SipDetayParam_014_Manset6cm_Garni2Cizgiler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE Deleted = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SqlCommand35
        '
        Me.SqlCommand35.CommandText = resources.GetString("SqlCommand35.CommandText")
        '
        'cnt019_Kaskorse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Caption = "Kaşkorse"
        Me.Code = "019"
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cnt019_Kaskorse"
        Me.Size = New System.Drawing.Size(255, 130)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MasterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCaption.ResumeLayout(False)
        CType(Me.chkSecmeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTurArtis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbIplik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeoTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeoTable1 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tbIplik As NeoDAC.NeoTable
    Friend WithEvents tbIplik_IplikID As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikKod As System.Data.DataColumn
    Friend WithEvents tbIplik_IplikIsmi As System.Data.DataColumn
    Friend WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtTurArtis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbRenk As NeoDAC.NeoTable
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents tbRenk_RenkID As System.Data.DataColumn
    Friend WithEvents tbRenk_Deleted As System.Data.DataColumn
    Friend WithEvents tbRenk_CreatedBy As System.Data.DataColumn
    Friend WithEvents tbRenk_CreatedDate As System.Data.DataColumn
    Friend WithEvents tbRenk_ModifiedBy As System.Data.DataColumn
    Friend WithEvents tbRenk_ModifiedDate As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkKod As System.Data.DataColumn
    Friend WithEvents tbRenk_RenkIsmi As System.Data.DataColumn
    Friend WithEvents tbRenk_IntCode As System.Data.DataColumn
    Friend WithEvents tbRenk_Pasif As System.Data.DataColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SqlCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand36 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand34 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand33 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand35 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NeoTable1_GramajArtis As DataColumn
    Friend WithEvents NeoTable1_IpGramaj As DataColumn
    Friend WithEvents NeoTable1_Iplik As DataColumn
    Friend WithEvents NeoTable1_KategoriParamID As DataColumn
    Friend WithEvents NeoTable1_ModifiedDate As DataColumn
    Friend WithEvents NeoTable1_ModifiedBy As DataColumn
    Friend WithEvents NeoTable1_CreatedDate As DataColumn
    Friend WithEvents NeoTable1_CreatedBy As DataColumn
    Friend WithEvents NeoTable1_Deleted As DataColumn
    Friend WithEvents NeoTable1_nID As DataColumn
    Friend WithEvents NeoTable2 As NeoDAC.NeoTable
    Friend WithEvents SqlCommand40 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand38 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand37 As SqlClient.SqlCommand
    Friend WithEvents SqlCommand39 As SqlClient.SqlCommand
    Friend WithEvents NeoTable2_GramajArtis As DataColumn
    Friend WithEvents NeoTable2_IpGramaj As DataColumn
    Friend WithEvents NeoTable2_Iplik As DataColumn
    Friend WithEvents NeoTable2_RenkID As DataColumn
    Friend WithEvents NeoTable2_KategoriParamID As DataColumn
    Friend WithEvents NeoTable2_SourceID As DataColumn
    Friend WithEvents NeoTable2_SipDetayParamID As DataColumn
    Friend WithEvents NeoTable2_ModifiedDate As DataColumn
    Friend WithEvents NeoTable2_ModifiedBy As DataColumn
    Friend WithEvents NeoTable2_CreatedDate As DataColumn
    Friend WithEvents NeoTable2_CreatedBy As DataColumn
    Friend WithEvents NeoTable2_Deleted As DataColumn
    Friend WithEvents NeoTable2_nID As DataColumn
End Class
