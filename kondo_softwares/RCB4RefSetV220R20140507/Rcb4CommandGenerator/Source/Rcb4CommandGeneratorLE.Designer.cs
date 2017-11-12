namespace Rcb4CommandGenerator
{
  partial class Rcb4CmdGenForm
  {
    /// <summary>
    /// 必要なデザイナ変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows フォーム デザイナで生成されたコード

    /// <summary>
    /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディタで変更しないでください。
    /// </summary>
    private void InitializeComponent ()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rcb4CmdGenForm));
        this.cmdGroupBox = new System.Windows.Forms.GroupBox();
        this.cmdSendButton = new System.Windows.Forms.Button();
        this.label8 = new System.Windows.Forms.Label();
        this.resultTextBox = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.cmdTextBox = new System.Windows.Forms.TextBox();
        this.serialPort = new System.IO.Ports.SerialPort(this.components);
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.holdRadioButton = new System.Windows.Forms.RadioButton();
        this.freeRadioButton = new System.Windows.Forms.RadioButton();
        this.freeButton = new System.Windows.Forms.Button();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label12 = new System.Windows.Forms.Label();
        this.ssFrameUpDown = new System.Windows.Forms.NumericUpDown();
        this.ssGenCmdButton = new System.Windows.Forms.Button();
        this.ssPositionUpDown = new System.Windows.Forms.NumericUpDown();
        this.label13 = new System.Windows.Forms.Label();
        this.ssGroupBox = new System.Windows.Forms.GroupBox();
        this.label31 = new System.Windows.Forms.Label();
        this.label30 = new System.Windows.Forms.Label();
        this.idUpDown = new System.Windows.Forms.NumericUpDown();
        this.sioUpDown = new System.Windows.Forms.NumericUpDown();
        this.label1 = new System.Windows.Forms.Label();
        this.ssIcsNoUpDown = new System.Windows.Forms.NumericUpDown();
        this.tabPage6 = new System.Windows.Forms.TabPage();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.servoListView = new System.Windows.Forms.ListView();
        this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.readPosButton = new System.Windows.Forms.Button();
        this.clearListButton = new System.Windows.Forms.Button();
        this.msGroupBox = new System.Windows.Forms.GroupBox();
        this.label14 = new System.Windows.Forms.Label();
        this.label15 = new System.Windows.Forms.Label();
        this.msFrameUpDown = new System.Windows.Forms.NumericUpDown();
        this.msPosUpDown = new System.Windows.Forms.NumericUpDown();
        this.icsDeviceListView = new System.Windows.Forms.ListView();
        this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.msGenCmdButton = new System.Windows.Forms.Button();
        this.tabPage5 = new System.Windows.Forms.TabPage();
        this.pioGroupBox = new System.Windows.Forms.GroupBox();
        this.pioOutButton = new System.Windows.Forms.Button();
        this.pio10CheckBox = new System.Windows.Forms.CheckBox();
        this.pio9CheckBox = new System.Windows.Forms.CheckBox();
        this.pio8CheckBox = new System.Windows.Forms.CheckBox();
        this.pio7CheckBox = new System.Windows.Forms.CheckBox();
        this.pio6CheckBox = new System.Windows.Forms.CheckBox();
        this.pio5CheckBox = new System.Windows.Forms.CheckBox();
        this.pio4CheckBox = new System.Windows.Forms.CheckBox();
        this.pio3CheckBox = new System.Windows.Forms.CheckBox();
        this.pio2CheckBox = new System.Windows.Forms.CheckBox();
        this.pio1CheckBox = new System.Windows.Forms.CheckBox();
        this.pioInButton = new System.Windows.Forms.Button();
        this.adrGroupBox = new System.Windows.Forms.GroupBox();
        this.adrReadButton = new System.Windows.Forms.Button();
        this.adr10RadioButton = new System.Windows.Forms.RadioButton();
        this.adr9RadioButton = new System.Windows.Forms.RadioButton();
        this.adr8RadioButton = new System.Windows.Forms.RadioButton();
        this.adr7RadioButton = new System.Windows.Forms.RadioButton();
        this.adr6RadioButton = new System.Windows.Forms.RadioButton();
        this.adr5RadioButton = new System.Windows.Forms.RadioButton();
        this.adr4RadioButton = new System.Windows.Forms.RadioButton();
        this.adr3RadioButton = new System.Windows.Forms.RadioButton();
        this.adr2RadioButton = new System.Windows.Forms.RadioButton();
        this.adr1RadioButton = new System.Windows.Forms.RadioButton();
        this.adr0RadioButton = new System.Windows.Forms.RadioButton();
        this.adGroupBox = new System.Windows.Forms.GroupBox();
        this.adReadButton = new System.Windows.Forms.Button();
        this.ad10RadioButton = new System.Windows.Forms.RadioButton();
        this.ad9RadioButton = new System.Windows.Forms.RadioButton();
        this.ad8RadioButton = new System.Windows.Forms.RadioButton();
        this.ad7RadioButton = new System.Windows.Forms.RadioButton();
        this.ad6RadioButton = new System.Windows.Forms.RadioButton();
        this.ad5RadioButton = new System.Windows.Forms.RadioButton();
        this.ad4RadioButton = new System.Windows.Forms.RadioButton();
        this.ad3RadioButton = new System.Windows.Forms.RadioButton();
        this.ad2RadioButton = new System.Windows.Forms.RadioButton();
        this.ad1RadioButton = new System.Windows.Forms.RadioButton();
        this.ad0RadioButton = new System.Windows.Forms.RadioButton();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.cfgGroupBox = new System.Windows.Forms.GroupBox();
        this.label23 = new System.Windows.Forms.Label();
        this.icsBaudrateSelectBox = new System.Windows.Forms.ComboBox();
        this.label22 = new System.Windows.Forms.Label();
        this.comBaudrateSelectBox = new System.Windows.Forms.ComboBox();
        this.label21 = new System.Windows.Forms.Label();
        this.frameSelectBox = new System.Windows.Forms.ComboBox();
        this.label20 = new System.Windows.Forms.Label();
        this.cfgTextBox = new System.Windows.Forms.TextBox();
        this.checkBox12 = new System.Windows.Forms.CheckBox();
        this.checkBox13 = new System.Windows.Forms.CheckBox();
        this.checkBox14 = new System.Windows.Forms.CheckBox();
        this.checkBox0 = new System.Windows.Forms.CheckBox();
        this.checkBox8 = new System.Windows.Forms.CheckBox();
        this.checkBox9 = new System.Windows.Forms.CheckBox();
        this.checkBox10 = new System.Windows.Forms.CheckBox();
        this.checkBox11 = new System.Windows.Forms.CheckBox();
        this.checkBox4 = new System.Windows.Forms.CheckBox();
        this.checkBox5 = new System.Windows.Forms.CheckBox();
        this.checkBox6 = new System.Windows.Forms.CheckBox();
        this.checkBox7 = new System.Windows.Forms.CheckBox();
        this.checkBox3 = new System.Windows.Forms.CheckBox();
        this.checkBox2 = new System.Windows.Forms.CheckBox();
        this.checkBox1 = new System.Windows.Forms.CheckBox();
        this.checkBox15 = new System.Windows.Forms.CheckBox();
        this.cfgReadCmdButton = new System.Windows.Forms.Button();
        this.cfgGenCmdButton = new System.Windows.Forms.Button();
        this.tabPage4 = new System.Windows.Forms.TabPage();
        this.mpGroupBox = new System.Windows.Forms.GroupBox();
        this.motionCmdSendButton = new System.Windows.Forms.Button();
        this.sendMotionPlayCmdutton = new System.Windows.Forms.Button();
        this.sendCallCmdButton = new System.Windows.Forms.Button();
        this.sendResetCmdButton = new System.Windows.Forms.Button();
        this.sendSuspendCmdButton = new System.Windows.Forms.Button();
        this.label29 = new System.Windows.Forms.Label();
        this.sendMotionPlayCmdTextBox = new System.Windows.Forms.TextBox();
        this.label28 = new System.Windows.Forms.Label();
        this.label27 = new System.Windows.Forms.Label();
        this.label26 = new System.Windows.Forms.Label();
        this.sendCallCmdTextBox = new System.Windows.Forms.TextBox();
        this.sendResetCmdTextBox = new System.Windows.Forms.TextBox();
        this.sendSuspendCmdtextBox = new System.Windows.Forms.TextBox();
        this.label24 = new System.Windows.Forms.Label();
        this.motionGenCmdButton = new System.Windows.Forms.Button();
        this.motionNumberUpDown = new System.Windows.Forms.NumericUpDown();
        this.label25 = new System.Windows.Forms.Label();
        this.tabPage7 = new System.Windows.Forms.TabPage();
        this.pa4TrackBar = new System.Windows.Forms.TrackBar();
        this.pa2TrackBar = new System.Windows.Forms.TrackBar();
        this.pa3TrackBar = new System.Windows.Forms.TrackBar();
        this.pa1TrackBar = new System.Windows.Forms.TrackBar();
        this.krcButton = new System.Windows.Forms.Button();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.RUL = new System.Windows.Forms.CheckBox();
        this.RU = new System.Windows.Forms.CheckBox();
        this.RUR = new System.Windows.Forms.CheckBox();
        this.LL = new System.Windows.Forms.CheckBox();
        this.LUL = new System.Windows.Forms.CheckBox();
        this.LU = new System.Windows.Forms.CheckBox();
        this.S3 = new System.Windows.Forms.CheckBox();
        this.S4 = new System.Windows.Forms.CheckBox();
        this.S1 = new System.Windows.Forms.CheckBox();
        this.N = new System.Windows.Forms.CheckBox();
        this.LR = new System.Windows.Forms.CheckBox();
        this.RL = new System.Windows.Forms.CheckBox();
        this.RR = new System.Windows.Forms.CheckBox();
        this.RDL = new System.Windows.Forms.CheckBox();
        this.RD = new System.Windows.Forms.CheckBox();
        this.LUR = new System.Windows.Forms.CheckBox();
        this.LD = new System.Windows.Forms.CheckBox();
        this.RDR = new System.Windows.Forms.CheckBox();
        this.LDR = new System.Windows.Forms.CheckBox();
        this.LDL = new System.Windows.Forms.CheckBox();
        this.S2 = new System.Windows.Forms.CheckBox();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.moveGroupBox = new System.Windows.Forms.GroupBox();
        this.label17 = new System.Windows.Forms.Label();
        this.sendByteCountUpDown = new System.Windows.Forms.NumericUpDown();
        this.label16 = new System.Windows.Forms.Label();
        this.destAddrSelectBox = new System.Windows.Forms.ComboBox();
        this.srcAddrUpDown = new System.Windows.Forms.NumericUpDown();
        this.destAddrUpDown = new System.Windows.Forms.NumericUpDown();
        this.moveGenCmdButton = new System.Windows.Forms.Button();
        this.icsGroupBox = new System.Windows.Forms.GroupBox();
        this.label11 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.destDevOffsetUpDown = new System.Windows.Forms.NumericUpDown();
        this.srcDevOffsetUpDown = new System.Windows.Forms.NumericUpDown();
        this.destDevNoUpDown = new System.Windows.Forms.NumericUpDown();
        this.srcDevNoUpDown = new System.Windows.Forms.NumericUpDown();
        this.label10 = new System.Windows.Forms.Label();
        this.anyByteDataTextBox = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.srcAddrSelectBox = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.destTypeSelectBox = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.srcTypeSelectBox = new System.Windows.Forms.ComboBox();
        this.addressLabel = new System.Windows.Forms.Label();
        this.mpGenCmdButton = new System.Windows.Forms.Button();
        this.mpUpDown = new System.Windows.Forms.NumericUpDown();
        this.label18 = new System.Windows.Forms.Label();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
        this.comComboBox = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
        this.baudrateComboBox = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.AckButton = new System.Windows.Forms.ToolStripButton();
        this.cmdGroupBox.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.ssFrameUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.ssPositionUpDown)).BeginInit();
        this.ssGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.idUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.sioUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.ssIcsNoUpDown)).BeginInit();
        this.tabPage6.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.msGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.msFrameUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.msPosUpDown)).BeginInit();
        this.tabPage5.SuspendLayout();
        this.pioGroupBox.SuspendLayout();
        this.adrGroupBox.SuspendLayout();
        this.adGroupBox.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.cfgGroupBox.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.mpGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.motionNumberUpDown)).BeginInit();
        this.tabPage7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pa4TrackBar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa2TrackBar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa3TrackBar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa1TrackBar)).BeginInit();
        this.tableLayoutPanel1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.moveGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.sendByteCountUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcAddrUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.destAddrUpDown)).BeginInit();
        this.icsGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.destDevOffsetUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcDevOffsetUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.destDevNoUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcDevNoUpDown)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.mpUpDown)).BeginInit();
        this.toolStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // cmdGroupBox
        // 
        this.cmdGroupBox.Controls.Add(this.cmdSendButton);
        this.cmdGroupBox.Controls.Add(this.label8);
        this.cmdGroupBox.Controls.Add(this.resultTextBox);
        this.cmdGroupBox.Controls.Add(this.label6);
        this.cmdGroupBox.Controls.Add(this.cmdTextBox);
        this.cmdGroupBox.Location = new System.Drawing.Point(7, 394);
        this.cmdGroupBox.Name = "cmdGroupBox";
        this.cmdGroupBox.Size = new System.Drawing.Size(615, 145);
        this.cmdGroupBox.TabIndex = 15;
        this.cmdGroupBox.TabStop = false;
        this.cmdGroupBox.Text = "コマンド生成テスト";
        // 
        // cmdSendButton
        // 
        this.cmdSendButton.Location = new System.Drawing.Point(487, 44);
        this.cmdSendButton.Name = "cmdSendButton";
        this.cmdSendButton.Size = new System.Drawing.Size(96, 28);
        this.cmdSendButton.TabIndex = 23;
        this.cmdSendButton.Text = "送信";
        this.cmdSendButton.UseVisualStyleBackColor = true;
        this.cmdSendButton.Click += new System.EventHandler(this.cmdSendButton_Click);
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(12, 83);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(151, 12);
        this.label8.TabIndex = 20;
        this.label8.Text = "RCB-4HVからの返事（String）";
        // 
        // resultTextBox
        // 
        this.resultTextBox.Location = new System.Drawing.Point(14, 106);
        this.resultTextBox.Name = "resultTextBox";
        this.resultTextBox.Size = new System.Drawing.Size(464, 19);
        this.resultTextBox.TabIndex = 19;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(12, 26);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(124, 12);
        this.label6.TabIndex = 18;
        this.label6.Text = "生成したコマンド（String）";
        // 
        // cmdTextBox
        // 
        this.cmdTextBox.Location = new System.Drawing.Point(14, 49);
        this.cmdTextBox.Name = "cmdTextBox";
        this.cmdTextBox.Size = new System.Drawing.Size(464, 19);
        this.cmdTextBox.TabIndex = 17;
        // 
        // serialPort
        // 
        this.serialPort.BaudRate = 115200;
        this.serialPort.Parity = System.IO.Ports.Parity.Even;
        this.serialPort.ReadTimeout = 100;
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage6);
        this.tabControl1.Controls.Add(this.tabPage5);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Controls.Add(this.tabPage7);
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Location = new System.Drawing.Point(7, 31);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(615, 350);
        this.tabControl1.TabIndex = 27;
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.groupBox2);
        this.tabPage2.Controls.Add(this.groupBox1);
        this.tabPage2.Controls.Add(this.ssGroupBox);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(607, 324);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "単体サーボモーター";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.holdRadioButton);
        this.groupBox2.Controls.Add(this.freeRadioButton);
        this.groupBox2.Controls.Add(this.freeButton);
        this.groupBox2.Location = new System.Drawing.Point(10, 188);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(582, 70);
        this.groupBox2.TabIndex = 39;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Free/Hold 【CMD = 0Fh】";
        // 
        // holdRadioButton
        // 
        this.holdRadioButton.AutoSize = true;
        this.holdRadioButton.Location = new System.Drawing.Point(148, 30);
        this.holdRadioButton.Name = "holdRadioButton";
        this.holdRadioButton.Size = new System.Drawing.Size(46, 16);
        this.holdRadioButton.TabIndex = 39;
        this.holdRadioButton.TabStop = true;
        this.holdRadioButton.Text = "Hold";
        this.holdRadioButton.UseVisualStyleBackColor = true;
        // 
        // freeRadioButton
        // 
        this.freeRadioButton.AutoSize = true;
        this.freeRadioButton.Checked = true;
        this.freeRadioButton.Location = new System.Drawing.Point(20, 30);
        this.freeRadioButton.Name = "freeRadioButton";
        this.freeRadioButton.Size = new System.Drawing.Size(46, 16);
        this.freeRadioButton.TabIndex = 38;
        this.freeRadioButton.TabStop = true;
        this.freeRadioButton.Text = "Free";
        this.freeRadioButton.UseVisualStyleBackColor = true;
        // 
        // freeButton
        // 
        this.freeButton.Location = new System.Drawing.Point(473, 24);
        this.freeButton.Name = "freeButton";
        this.freeButton.Size = new System.Drawing.Size(96, 28);
        this.freeButton.TabIndex = 37;
        this.freeButton.Text = "コマンド生成";
        this.freeButton.UseVisualStyleBackColor = true;
        this.freeButton.Click += new System.EventHandler(this.freeButton_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.label12);
        this.groupBox1.Controls.Add(this.ssFrameUpDown);
        this.groupBox1.Controls.Add(this.ssGenCmdButton);
        this.groupBox1.Controls.Add(this.ssPositionUpDown);
        this.groupBox1.Controls.Add(this.label13);
        this.groupBox1.Location = new System.Drawing.Point(10, 112);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(582, 70);
        this.groupBox1.TabIndex = 38;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "シングルサーボ 【CMD = 0Fh】";
        // 
        // label12
        // 
        this.label12.AutoSize = true;
        this.label12.Location = new System.Drawing.Point(18, 32);
        this.label12.Name = "label12";
        this.label12.Size = new System.Drawing.Size(42, 12);
        this.label12.TabIndex = 32;
        this.label12.Text = "フレーム";
        // 
        // ssFrameUpDown
        // 
        this.ssFrameUpDown.Location = new System.Drawing.Point(89, 30);
        this.ssFrameUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.ssFrameUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.ssFrameUpDown.Name = "ssFrameUpDown";
        this.ssFrameUpDown.Size = new System.Drawing.Size(65, 19);
        this.ssFrameUpDown.TabIndex = 30;
        this.ssFrameUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.ssFrameUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // ssGenCmdButton
        // 
        this.ssGenCmdButton.Location = new System.Drawing.Point(473, 24);
        this.ssGenCmdButton.Name = "ssGenCmdButton";
        this.ssGenCmdButton.Size = new System.Drawing.Size(96, 28);
        this.ssGenCmdButton.TabIndex = 37;
        this.ssGenCmdButton.Text = "コマンド生成";
        this.ssGenCmdButton.UseVisualStyleBackColor = true;
        this.ssGenCmdButton.Click += new System.EventHandler(this.ssGenCmdButton_Click);
        // 
        // ssPositionUpDown
        // 
        this.ssPositionUpDown.Location = new System.Drawing.Point(277, 30);
        this.ssPositionUpDown.Maximum = new decimal(new int[] {
            11500,
            0,
            0,
            0});
        this.ssPositionUpDown.Minimum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
        this.ssPositionUpDown.Name = "ssPositionUpDown";
        this.ssPositionUpDown.Size = new System.Drawing.Size(65, 19);
        this.ssPositionUpDown.TabIndex = 28;
        this.ssPositionUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.ssPositionUpDown.Value = new decimal(new int[] {
            7500,
            0,
            0,
            0});
        // 
        // label13
        // 
        this.label13.AutoSize = true;
        this.label13.Location = new System.Drawing.Point(205, 32);
        this.label13.Name = "label13";
        this.label13.Size = new System.Drawing.Size(50, 12);
        this.label13.TabIndex = 33;
        this.label13.Text = "ポジション";
        // 
        // ssGroupBox
        // 
        this.ssGroupBox.Controls.Add(this.label31);
        this.ssGroupBox.Controls.Add(this.label30);
        this.ssGroupBox.Controls.Add(this.idUpDown);
        this.ssGroupBox.Controls.Add(this.sioUpDown);
        this.ssGroupBox.Controls.Add(this.label1);
        this.ssGroupBox.Controls.Add(this.ssIcsNoUpDown);
        this.ssGroupBox.Location = new System.Drawing.Point(10, 6);
        this.ssGroupBox.Name = "ssGroupBox";
        this.ssGroupBox.Size = new System.Drawing.Size(582, 100);
        this.ssGroupBox.TabIndex = 25;
        this.ssGroupBox.TabStop = false;
        this.ssGroupBox.Text = "ICS番号設定";
        // 
        // label31
        // 
        this.label31.AutoSize = true;
        this.label31.Location = new System.Drawing.Point(13, 65);
        this.label31.Name = "label31";
        this.label31.Size = new System.Drawing.Size(40, 12);
        this.label31.TabIndex = 41;
        this.label31.Text = "ID番号";
        // 
        // label30
        // 
        this.label30.AutoSize = true;
        this.label30.Location = new System.Drawing.Point(13, 34);
        this.label30.Name = "label30";
        this.label30.Size = new System.Drawing.Size(51, 12);
        this.label30.TabIndex = 40;
        this.label30.Text = "SIOポート";
        // 
        // idUpDown
        // 
        this.idUpDown.Location = new System.Drawing.Point(86, 63);
        this.idUpDown.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
        this.idUpDown.Name = "idUpDown";
        this.idUpDown.Size = new System.Drawing.Size(65, 19);
        this.idUpDown.TabIndex = 39;
        this.idUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.idUpDown.ValueChanged += new System.EventHandler(this.idUpDown_ValueChanged);
        // 
        // sioUpDown
        // 
        this.sioUpDown.Location = new System.Drawing.Point(86, 32);
        this.sioUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
        this.sioUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.sioUpDown.Name = "sioUpDown";
        this.sioUpDown.Size = new System.Drawing.Size(65, 19);
        this.sioUpDown.TabIndex = 38;
        this.sioUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.sioUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.sioUpDown.ValueChanged += new System.EventHandler(this.sioUpDown_ValueChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(205, 34);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(47, 12);
        this.label1.TabIndex = 31;
        this.label1.Text = "ICS番号";
        // 
        // ssIcsNoUpDown
        // 
        this.ssIcsNoUpDown.Location = new System.Drawing.Point(274, 32);
        this.ssIcsNoUpDown.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
        this.ssIcsNoUpDown.Name = "ssIcsNoUpDown";
        this.ssIcsNoUpDown.Size = new System.Drawing.Size(65, 19);
        this.ssIcsNoUpDown.TabIndex = 29;
        this.ssIcsNoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // tabPage6
        // 
        this.tabPage6.Controls.Add(this.groupBox3);
        this.tabPage6.Controls.Add(this.msGroupBox);
        this.tabPage6.Location = new System.Drawing.Point(4, 22);
        this.tabPage6.Name = "tabPage6";
        this.tabPage6.Size = new System.Drawing.Size(607, 324);
        this.tabPage6.TabIndex = 5;
        this.tabPage6.Text = "複数サーボモーター";
        this.tabPage6.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.servoListView);
        this.groupBox3.Controls.Add(this.readPosButton);
        this.groupBox3.Controls.Add(this.clearListButton);
        this.groupBox3.Location = new System.Drawing.Point(236, 6);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(356, 292);
        this.groupBox3.TabIndex = 47;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "ポジション読み取り";
        // 
        // servoListView
        // 
        this.servoListView.CheckBoxes = true;
        this.servoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
        this.servoListView.FullRowSelect = true;
        this.servoListView.GridLines = true;
        this.servoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        this.servoListView.Location = new System.Drawing.Point(8, 18);
        this.servoListView.MultiSelect = false;
        this.servoListView.Name = "servoListView";
        this.servoListView.Size = new System.Drawing.Size(335, 234);
        this.servoListView.TabIndex = 44;
        this.servoListView.UseCompatibleStateImageBehavior = false;
        this.servoListView.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "ICS";
        // 
        // columnHeader4
        // 
        this.columnHeader4.Text = "トリム";
        this.columnHeader4.Width = 80;
        // 
        // columnHeader5
        // 
        this.columnHeader5.Text = "現在値";
        this.columnHeader5.Width = 80;
        // 
        // columnHeader6
        // 
        this.columnHeader6.Text = "目標値";
        this.columnHeader6.Width = 80;
        // 
        // readPosButton
        // 
        this.readPosButton.Location = new System.Drawing.Point(140, 258);
        this.readPosButton.Name = "readPosButton";
        this.readPosButton.Size = new System.Drawing.Size(96, 28);
        this.readPosButton.TabIndex = 45;
        this.readPosButton.Text = "読み取り";
        this.readPosButton.UseVisualStyleBackColor = true;
        this.readPosButton.Click += new System.EventHandler(this.readPosButton_Click);
        // 
        // clearListButton
        // 
        this.clearListButton.Location = new System.Drawing.Point(247, 258);
        this.clearListButton.Name = "clearListButton";
        this.clearListButton.Size = new System.Drawing.Size(96, 28);
        this.clearListButton.TabIndex = 46;
        this.clearListButton.Text = "リスト消去";
        this.clearListButton.UseVisualStyleBackColor = true;
        this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
        // 
        // msGroupBox
        // 
        this.msGroupBox.Controls.Add(this.label14);
        this.msGroupBox.Controls.Add(this.label15);
        this.msGroupBox.Controls.Add(this.msFrameUpDown);
        this.msGroupBox.Controls.Add(this.msPosUpDown);
        this.msGroupBox.Controls.Add(this.icsDeviceListView);
        this.msGroupBox.Controls.Add(this.msGenCmdButton);
        this.msGroupBox.Location = new System.Drawing.Point(10, 6);
        this.msGroupBox.Name = "msGroupBox";
        this.msGroupBox.Size = new System.Drawing.Size(220, 292);
        this.msGroupBox.TabIndex = 27;
        this.msGroupBox.TabStop = false;
        this.msGroupBox.Text = "複数サーボモーター【CMD = 10h】";
        // 
        // label14
        // 
        this.label14.AutoSize = true;
        this.label14.Location = new System.Drawing.Point(9, 207);
        this.label14.Name = "label14";
        this.label14.Size = new System.Drawing.Size(50, 12);
        this.label14.TabIndex = 43;
        this.label14.Text = "ポジション";
        // 
        // label15
        // 
        this.label15.AutoSize = true;
        this.label15.Location = new System.Drawing.Point(123, 207);
        this.label15.Name = "label15";
        this.label15.Size = new System.Drawing.Size(42, 12);
        this.label15.TabIndex = 42;
        this.label15.Text = "フレーム";
        // 
        // msFrameUpDown
        // 
        this.msFrameUpDown.Location = new System.Drawing.Point(125, 229);
        this.msFrameUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.msFrameUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.msFrameUpDown.Name = "msFrameUpDown";
        this.msFrameUpDown.Size = new System.Drawing.Size(70, 19);
        this.msFrameUpDown.TabIndex = 41;
        this.msFrameUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.msFrameUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // msPosUpDown
        // 
        this.msPosUpDown.Location = new System.Drawing.Point(11, 229);
        this.msPosUpDown.Maximum = new decimal(new int[] {
            11500,
            0,
            0,
            0});
        this.msPosUpDown.Minimum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
        this.msPosUpDown.Name = "msPosUpDown";
        this.msPosUpDown.Size = new System.Drawing.Size(70, 19);
        this.msPosUpDown.TabIndex = 40;
        this.msPosUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.msPosUpDown.Value = new decimal(new int[] {
            7500,
            0,
            0,
            0});
        this.msPosUpDown.ValueChanged += new System.EventHandler(this.msPosUpDown_ValueChanged);
        // 
        // icsDeviceListView
        // 
        this.icsDeviceListView.CheckBoxes = true;
        this.icsDeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
        this.icsDeviceListView.FullRowSelect = true;
        this.icsDeviceListView.GridLines = true;
        this.icsDeviceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        this.icsDeviceListView.Location = new System.Drawing.Point(11, 18);
        this.icsDeviceListView.MultiSelect = false;
        this.icsDeviceListView.Name = "icsDeviceListView";
        this.icsDeviceListView.Size = new System.Drawing.Size(184, 180);
        this.icsDeviceListView.TabIndex = 39;
        this.icsDeviceListView.UseCompatibleStateImageBehavior = false;
        this.icsDeviceListView.View = System.Windows.Forms.View.Details;
        this.icsDeviceListView.SelectedIndexChanged += new System.EventHandler(this.icsDeviceListView_SelectedIndexChanged);
        // 
        // columnHeader1
        // 
        this.columnHeader1.Text = "ICS";
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "目標値";
        this.columnHeader2.Width = 80;
        // 
        // msGenCmdButton
        // 
        this.msGenCmdButton.Location = new System.Drawing.Point(99, 258);
        this.msGenCmdButton.Name = "msGenCmdButton";
        this.msGenCmdButton.Size = new System.Drawing.Size(96, 28);
        this.msGenCmdButton.TabIndex = 38;
        this.msGenCmdButton.Text = "コマンド生成";
        this.msGenCmdButton.UseVisualStyleBackColor = true;
        this.msGenCmdButton.Click += new System.EventHandler(this.msGenCmdButton_Click);
        // 
        // tabPage5
        // 
        this.tabPage5.Controls.Add(this.pioGroupBox);
        this.tabPage5.Controls.Add(this.adrGroupBox);
        this.tabPage5.Controls.Add(this.adGroupBox);
        this.tabPage5.Location = new System.Drawing.Point(4, 22);
        this.tabPage5.Name = "tabPage5";
        this.tabPage5.Size = new System.Drawing.Size(607, 324);
        this.tabPage5.TabIndex = 4;
        this.tabPage5.Text = "センサー読み取り";
        this.tabPage5.UseVisualStyleBackColor = true;
        // 
        // pioGroupBox
        // 
        this.pioGroupBox.Controls.Add(this.pioOutButton);
        this.pioGroupBox.Controls.Add(this.pio10CheckBox);
        this.pioGroupBox.Controls.Add(this.pio9CheckBox);
        this.pioGroupBox.Controls.Add(this.pio8CheckBox);
        this.pioGroupBox.Controls.Add(this.pio7CheckBox);
        this.pioGroupBox.Controls.Add(this.pio6CheckBox);
        this.pioGroupBox.Controls.Add(this.pio5CheckBox);
        this.pioGroupBox.Controls.Add(this.pio4CheckBox);
        this.pioGroupBox.Controls.Add(this.pio3CheckBox);
        this.pioGroupBox.Controls.Add(this.pio2CheckBox);
        this.pioGroupBox.Controls.Add(this.pio1CheckBox);
        this.pioGroupBox.Controls.Add(this.pioInButton);
        this.pioGroupBox.Location = new System.Drawing.Point(10, 182);
        this.pioGroupBox.Name = "pioGroupBox";
        this.pioGroupBox.Size = new System.Drawing.Size(582, 109);
        this.pioGroupBox.TabIndex = 2;
        this.pioGroupBox.TabStop = false;
        this.pioGroupBox.Text = "PIOポート";
        // 
        // pioOutButton
        // 
        this.pioOutButton.Location = new System.Drawing.Point(473, 71);
        this.pioOutButton.Name = "pioOutButton";
        this.pioOutButton.Size = new System.Drawing.Size(96, 28);
        this.pioOutButton.TabIndex = 55;
        this.pioOutButton.Text = "書き出し";
        this.pioOutButton.UseVisualStyleBackColor = true;
        this.pioOutButton.Click += new System.EventHandler(this.pioOutButton_Click);
        // 
        // pio10CheckBox
        // 
        this.pio10CheckBox.AutoSize = true;
        this.pio10CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio10CheckBox.Location = new System.Drawing.Point(372, 32);
        this.pio10CheckBox.Name = "pio10CheckBox";
        this.pio10CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio10CheckBox.TabIndex = 54;
        this.pio10CheckBox.Text = "10";
        this.pio10CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio9CheckBox
        // 
        this.pio9CheckBox.AutoSize = true;
        this.pio9CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio9CheckBox.Location = new System.Drawing.Point(333, 32);
        this.pio9CheckBox.Name = "pio9CheckBox";
        this.pio9CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio9CheckBox.TabIndex = 53;
        this.pio9CheckBox.Text = "09";
        this.pio9CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio8CheckBox
        // 
        this.pio8CheckBox.AutoSize = true;
        this.pio8CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio8CheckBox.Location = new System.Drawing.Point(294, 32);
        this.pio8CheckBox.Name = "pio8CheckBox";
        this.pio8CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio8CheckBox.TabIndex = 52;
        this.pio8CheckBox.Text = "08";
        this.pio8CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio7CheckBox
        // 
        this.pio7CheckBox.AutoSize = true;
        this.pio7CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio7CheckBox.Location = new System.Drawing.Point(255, 32);
        this.pio7CheckBox.Name = "pio7CheckBox";
        this.pio7CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio7CheckBox.TabIndex = 51;
        this.pio7CheckBox.Text = "07";
        this.pio7CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio6CheckBox
        // 
        this.pio6CheckBox.AutoSize = true;
        this.pio6CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio6CheckBox.Location = new System.Drawing.Point(216, 32);
        this.pio6CheckBox.Name = "pio6CheckBox";
        this.pio6CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio6CheckBox.TabIndex = 50;
        this.pio6CheckBox.Text = "06";
        this.pio6CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio5CheckBox
        // 
        this.pio5CheckBox.AutoSize = true;
        this.pio5CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio5CheckBox.Location = new System.Drawing.Point(177, 32);
        this.pio5CheckBox.Name = "pio5CheckBox";
        this.pio5CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio5CheckBox.TabIndex = 49;
        this.pio5CheckBox.Text = "05";
        this.pio5CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio4CheckBox
        // 
        this.pio4CheckBox.AutoSize = true;
        this.pio4CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio4CheckBox.Location = new System.Drawing.Point(138, 32);
        this.pio4CheckBox.Name = "pio4CheckBox";
        this.pio4CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio4CheckBox.TabIndex = 48;
        this.pio4CheckBox.Text = "04";
        this.pio4CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio3CheckBox
        // 
        this.pio3CheckBox.AutoSize = true;
        this.pio3CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio3CheckBox.Location = new System.Drawing.Point(99, 32);
        this.pio3CheckBox.Name = "pio3CheckBox";
        this.pio3CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio3CheckBox.TabIndex = 47;
        this.pio3CheckBox.Text = "03";
        this.pio3CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio2CheckBox
        // 
        this.pio2CheckBox.AutoSize = true;
        this.pio2CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio2CheckBox.Location = new System.Drawing.Point(60, 32);
        this.pio2CheckBox.Name = "pio2CheckBox";
        this.pio2CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio2CheckBox.TabIndex = 46;
        this.pio2CheckBox.Text = "02";
        this.pio2CheckBox.UseVisualStyleBackColor = true;
        // 
        // pio1CheckBox
        // 
        this.pio1CheckBox.AutoSize = true;
        this.pio1CheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.pio1CheckBox.Location = new System.Drawing.Point(21, 32);
        this.pio1CheckBox.Name = "pio1CheckBox";
        this.pio1CheckBox.Size = new System.Drawing.Size(21, 30);
        this.pio1CheckBox.TabIndex = 45;
        this.pio1CheckBox.Text = "01";
        this.pio1CheckBox.UseVisualStyleBackColor = true;
        // 
        // pioInButton
        // 
        this.pioInButton.Location = new System.Drawing.Point(473, 32);
        this.pioInButton.Name = "pioInButton";
        this.pioInButton.Size = new System.Drawing.Size(96, 28);
        this.pioInButton.TabIndex = 44;
        this.pioInButton.Text = "読み取り";
        this.pioInButton.UseVisualStyleBackColor = true;
        this.pioInButton.Click += new System.EventHandler(this.pioInButton_Click);
        // 
        // adrGroupBox
        // 
        this.adrGroupBox.Controls.Add(this.adrReadButton);
        this.adrGroupBox.Controls.Add(this.adr10RadioButton);
        this.adrGroupBox.Controls.Add(this.adr9RadioButton);
        this.adrGroupBox.Controls.Add(this.adr8RadioButton);
        this.adrGroupBox.Controls.Add(this.adr7RadioButton);
        this.adrGroupBox.Controls.Add(this.adr6RadioButton);
        this.adrGroupBox.Controls.Add(this.adr5RadioButton);
        this.adrGroupBox.Controls.Add(this.adr4RadioButton);
        this.adrGroupBox.Controls.Add(this.adr3RadioButton);
        this.adrGroupBox.Controls.Add(this.adr2RadioButton);
        this.adrGroupBox.Controls.Add(this.adr1RadioButton);
        this.adrGroupBox.Controls.Add(this.adr0RadioButton);
        this.adrGroupBox.Location = new System.Drawing.Point(10, 94);
        this.adrGroupBox.Name = "adrGroupBox";
        this.adrGroupBox.Size = new System.Drawing.Size(582, 82);
        this.adrGroupBox.TabIndex = 1;
        this.adrGroupBox.TabStop = false;
        this.adrGroupBox.Text = "アナログ基準値";
        // 
        // adrReadButton
        // 
        this.adrReadButton.Location = new System.Drawing.Point(473, 30);
        this.adrReadButton.Name = "adrReadButton";
        this.adrReadButton.Size = new System.Drawing.Size(96, 28);
        this.adrReadButton.TabIndex = 44;
        this.adrReadButton.Text = "コマンド生成";
        this.adrReadButton.UseVisualStyleBackColor = true;
        this.adrReadButton.Click += new System.EventHandler(this.adrReadButton_Click);
        // 
        // adr10RadioButton
        // 
        this.adr10RadioButton.AutoSize = true;
        this.adr10RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr10RadioButton.Location = new System.Drawing.Point(411, 29);
        this.adr10RadioButton.Name = "adr10RadioButton";
        this.adr10RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr10RadioButton.TabIndex = 10;
        this.adr10RadioButton.TabStop = true;
        this.adr10RadioButton.Text = "10";
        this.adr10RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr9RadioButton
        // 
        this.adr9RadioButton.AutoSize = true;
        this.adr9RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr9RadioButton.Location = new System.Drawing.Point(372, 29);
        this.adr9RadioButton.Name = "adr9RadioButton";
        this.adr9RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr9RadioButton.TabIndex = 9;
        this.adr9RadioButton.TabStop = true;
        this.adr9RadioButton.Text = "09";
        this.adr9RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr8RadioButton
        // 
        this.adr8RadioButton.AutoSize = true;
        this.adr8RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr8RadioButton.Location = new System.Drawing.Point(333, 29);
        this.adr8RadioButton.Name = "adr8RadioButton";
        this.adr8RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr8RadioButton.TabIndex = 8;
        this.adr8RadioButton.TabStop = true;
        this.adr8RadioButton.Text = "08";
        this.adr8RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr7RadioButton
        // 
        this.adr7RadioButton.AutoSize = true;
        this.adr7RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr7RadioButton.Location = new System.Drawing.Point(294, 29);
        this.adr7RadioButton.Name = "adr7RadioButton";
        this.adr7RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr7RadioButton.TabIndex = 7;
        this.adr7RadioButton.TabStop = true;
        this.adr7RadioButton.Text = "07";
        this.adr7RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr6RadioButton
        // 
        this.adr6RadioButton.AutoSize = true;
        this.adr6RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr6RadioButton.Location = new System.Drawing.Point(255, 29);
        this.adr6RadioButton.Name = "adr6RadioButton";
        this.adr6RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr6RadioButton.TabIndex = 6;
        this.adr6RadioButton.TabStop = true;
        this.adr6RadioButton.Text = "06";
        this.adr6RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr5RadioButton
        // 
        this.adr5RadioButton.AutoSize = true;
        this.adr5RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr5RadioButton.Location = new System.Drawing.Point(216, 29);
        this.adr5RadioButton.Name = "adr5RadioButton";
        this.adr5RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr5RadioButton.TabIndex = 5;
        this.adr5RadioButton.TabStop = true;
        this.adr5RadioButton.Text = "05";
        this.adr5RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr4RadioButton
        // 
        this.adr4RadioButton.AutoSize = true;
        this.adr4RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr4RadioButton.Location = new System.Drawing.Point(177, 29);
        this.adr4RadioButton.Name = "adr4RadioButton";
        this.adr4RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr4RadioButton.TabIndex = 4;
        this.adr4RadioButton.TabStop = true;
        this.adr4RadioButton.Text = "04";
        this.adr4RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr3RadioButton
        // 
        this.adr3RadioButton.AutoSize = true;
        this.adr3RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr3RadioButton.Location = new System.Drawing.Point(138, 29);
        this.adr3RadioButton.Name = "adr3RadioButton";
        this.adr3RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr3RadioButton.TabIndex = 3;
        this.adr3RadioButton.TabStop = true;
        this.adr3RadioButton.Text = "03";
        this.adr3RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr2RadioButton
        // 
        this.adr2RadioButton.AutoSize = true;
        this.adr2RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr2RadioButton.Location = new System.Drawing.Point(99, 29);
        this.adr2RadioButton.Name = "adr2RadioButton";
        this.adr2RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr2RadioButton.TabIndex = 2;
        this.adr2RadioButton.TabStop = true;
        this.adr2RadioButton.Text = "02";
        this.adr2RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr1RadioButton
        // 
        this.adr1RadioButton.AutoSize = true;
        this.adr1RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr1RadioButton.Location = new System.Drawing.Point(60, 29);
        this.adr1RadioButton.Name = "adr1RadioButton";
        this.adr1RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr1RadioButton.TabIndex = 1;
        this.adr1RadioButton.TabStop = true;
        this.adr1RadioButton.Text = "01";
        this.adr1RadioButton.UseVisualStyleBackColor = true;
        // 
        // adr0RadioButton
        // 
        this.adr0RadioButton.AutoSize = true;
        this.adr0RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.adr0RadioButton.Location = new System.Drawing.Point(21, 29);
        this.adr0RadioButton.Name = "adr0RadioButton";
        this.adr0RadioButton.Size = new System.Drawing.Size(21, 29);
        this.adr0RadioButton.TabIndex = 0;
        this.adr0RadioButton.TabStop = true;
        this.adr0RadioButton.Text = "00";
        this.adr0RadioButton.UseVisualStyleBackColor = true;
        // 
        // adGroupBox
        // 
        this.adGroupBox.Controls.Add(this.adReadButton);
        this.adGroupBox.Controls.Add(this.ad10RadioButton);
        this.adGroupBox.Controls.Add(this.ad9RadioButton);
        this.adGroupBox.Controls.Add(this.ad8RadioButton);
        this.adGroupBox.Controls.Add(this.ad7RadioButton);
        this.adGroupBox.Controls.Add(this.ad6RadioButton);
        this.adGroupBox.Controls.Add(this.ad5RadioButton);
        this.adGroupBox.Controls.Add(this.ad4RadioButton);
        this.adGroupBox.Controls.Add(this.ad3RadioButton);
        this.adGroupBox.Controls.Add(this.ad2RadioButton);
        this.adGroupBox.Controls.Add(this.ad1RadioButton);
        this.adGroupBox.Controls.Add(this.ad0RadioButton);
        this.adGroupBox.Location = new System.Drawing.Point(10, 6);
        this.adGroupBox.Name = "adGroupBox";
        this.adGroupBox.Size = new System.Drawing.Size(582, 82);
        this.adGroupBox.TabIndex = 0;
        this.adGroupBox.TabStop = false;
        this.adGroupBox.Text = "アナログポート";
        // 
        // adReadButton
        // 
        this.adReadButton.Location = new System.Drawing.Point(473, 30);
        this.adReadButton.Name = "adReadButton";
        this.adReadButton.Size = new System.Drawing.Size(96, 28);
        this.adReadButton.TabIndex = 44;
        this.adReadButton.Text = "コマンド生成";
        this.adReadButton.UseVisualStyleBackColor = true;
        this.adReadButton.Click += new System.EventHandler(this.adReadButton_Click);
        // 
        // ad10RadioButton
        // 
        this.ad10RadioButton.AutoSize = true;
        this.ad10RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad10RadioButton.Location = new System.Drawing.Point(411, 29);
        this.ad10RadioButton.Name = "ad10RadioButton";
        this.ad10RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad10RadioButton.TabIndex = 10;
        this.ad10RadioButton.TabStop = true;
        this.ad10RadioButton.Text = "10";
        this.ad10RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad9RadioButton
        // 
        this.ad9RadioButton.AutoSize = true;
        this.ad9RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad9RadioButton.Location = new System.Drawing.Point(372, 29);
        this.ad9RadioButton.Name = "ad9RadioButton";
        this.ad9RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad9RadioButton.TabIndex = 9;
        this.ad9RadioButton.TabStop = true;
        this.ad9RadioButton.Text = "09";
        this.ad9RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad8RadioButton
        // 
        this.ad8RadioButton.AutoSize = true;
        this.ad8RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad8RadioButton.Location = new System.Drawing.Point(333, 29);
        this.ad8RadioButton.Name = "ad8RadioButton";
        this.ad8RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad8RadioButton.TabIndex = 8;
        this.ad8RadioButton.TabStop = true;
        this.ad8RadioButton.Text = "08";
        this.ad8RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad7RadioButton
        // 
        this.ad7RadioButton.AutoSize = true;
        this.ad7RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad7RadioButton.Location = new System.Drawing.Point(294, 29);
        this.ad7RadioButton.Name = "ad7RadioButton";
        this.ad7RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad7RadioButton.TabIndex = 7;
        this.ad7RadioButton.TabStop = true;
        this.ad7RadioButton.Text = "07";
        this.ad7RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad6RadioButton
        // 
        this.ad6RadioButton.AutoSize = true;
        this.ad6RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad6RadioButton.Location = new System.Drawing.Point(255, 29);
        this.ad6RadioButton.Name = "ad6RadioButton";
        this.ad6RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad6RadioButton.TabIndex = 6;
        this.ad6RadioButton.TabStop = true;
        this.ad6RadioButton.Text = "06";
        this.ad6RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad5RadioButton
        // 
        this.ad5RadioButton.AutoSize = true;
        this.ad5RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad5RadioButton.Location = new System.Drawing.Point(216, 29);
        this.ad5RadioButton.Name = "ad5RadioButton";
        this.ad5RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad5RadioButton.TabIndex = 5;
        this.ad5RadioButton.TabStop = true;
        this.ad5RadioButton.Text = "05";
        this.ad5RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad4RadioButton
        // 
        this.ad4RadioButton.AutoSize = true;
        this.ad4RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad4RadioButton.Location = new System.Drawing.Point(177, 29);
        this.ad4RadioButton.Name = "ad4RadioButton";
        this.ad4RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad4RadioButton.TabIndex = 4;
        this.ad4RadioButton.TabStop = true;
        this.ad4RadioButton.Text = "04";
        this.ad4RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad3RadioButton
        // 
        this.ad3RadioButton.AutoSize = true;
        this.ad3RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad3RadioButton.Location = new System.Drawing.Point(138, 29);
        this.ad3RadioButton.Name = "ad3RadioButton";
        this.ad3RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad3RadioButton.TabIndex = 3;
        this.ad3RadioButton.TabStop = true;
        this.ad3RadioButton.Text = "03";
        this.ad3RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad2RadioButton
        // 
        this.ad2RadioButton.AutoSize = true;
        this.ad2RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad2RadioButton.Location = new System.Drawing.Point(99, 29);
        this.ad2RadioButton.Name = "ad2RadioButton";
        this.ad2RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad2RadioButton.TabIndex = 2;
        this.ad2RadioButton.TabStop = true;
        this.ad2RadioButton.Text = "02";
        this.ad2RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad1RadioButton
        // 
        this.ad1RadioButton.AutoSize = true;
        this.ad1RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad1RadioButton.Location = new System.Drawing.Point(60, 29);
        this.ad1RadioButton.Name = "ad1RadioButton";
        this.ad1RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad1RadioButton.TabIndex = 1;
        this.ad1RadioButton.TabStop = true;
        this.ad1RadioButton.Text = "01";
        this.ad1RadioButton.UseVisualStyleBackColor = true;
        // 
        // ad0RadioButton
        // 
        this.ad0RadioButton.AutoSize = true;
        this.ad0RadioButton.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.ad0RadioButton.Location = new System.Drawing.Point(21, 29);
        this.ad0RadioButton.Name = "ad0RadioButton";
        this.ad0RadioButton.Size = new System.Drawing.Size(21, 29);
        this.ad0RadioButton.TabIndex = 0;
        this.ad0RadioButton.TabStop = true;
        this.ad0RadioButton.Text = "00";
        this.ad0RadioButton.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.cfgGroupBox);
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage3.Size = new System.Drawing.Size(607, 324);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "システム設定値";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // cfgGroupBox
        // 
        this.cfgGroupBox.Controls.Add(this.label23);
        this.cfgGroupBox.Controls.Add(this.icsBaudrateSelectBox);
        this.cfgGroupBox.Controls.Add(this.label22);
        this.cfgGroupBox.Controls.Add(this.comBaudrateSelectBox);
        this.cfgGroupBox.Controls.Add(this.label21);
        this.cfgGroupBox.Controls.Add(this.frameSelectBox);
        this.cfgGroupBox.Controls.Add(this.label20);
        this.cfgGroupBox.Controls.Add(this.cfgTextBox);
        this.cfgGroupBox.Controls.Add(this.checkBox12);
        this.cfgGroupBox.Controls.Add(this.checkBox13);
        this.cfgGroupBox.Controls.Add(this.checkBox14);
        this.cfgGroupBox.Controls.Add(this.checkBox0);
        this.cfgGroupBox.Controls.Add(this.checkBox8);
        this.cfgGroupBox.Controls.Add(this.checkBox9);
        this.cfgGroupBox.Controls.Add(this.checkBox10);
        this.cfgGroupBox.Controls.Add(this.checkBox11);
        this.cfgGroupBox.Controls.Add(this.checkBox4);
        this.cfgGroupBox.Controls.Add(this.checkBox5);
        this.cfgGroupBox.Controls.Add(this.checkBox6);
        this.cfgGroupBox.Controls.Add(this.checkBox7);
        this.cfgGroupBox.Controls.Add(this.checkBox3);
        this.cfgGroupBox.Controls.Add(this.checkBox2);
        this.cfgGroupBox.Controls.Add(this.checkBox1);
        this.cfgGroupBox.Controls.Add(this.checkBox15);
        this.cfgGroupBox.Controls.Add(this.cfgReadCmdButton);
        this.cfgGroupBox.Controls.Add(this.cfgGenCmdButton);
        this.cfgGroupBox.Location = new System.Drawing.Point(10, 6);
        this.cfgGroupBox.Name = "cfgGroupBox";
        this.cfgGroupBox.Size = new System.Drawing.Size(582, 182);
        this.cfgGroupBox.TabIndex = 28;
        this.cfgGroupBox.TabStop = false;
        this.cfgGroupBox.Text = "システムスイッチ";
        // 
        // label23
        // 
        this.label23.AutoSize = true;
        this.label23.Location = new System.Drawing.Point(14, 85);
        this.label23.Name = "label23";
        this.label23.Size = new System.Drawing.Size(66, 12);
        this.label23.TabIndex = 84;
        this.label23.Text = "フレーム周期";
        // 
        // icsBaudrateSelectBox
        // 
        this.icsBaudrateSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.icsBaudrateSelectBox.FormattingEnabled = true;
        this.icsBaudrateSelectBox.Items.AddRange(new object[] {
            "115200",
            "625000",
            "1250000"});
        this.icsBaudrateSelectBox.Location = new System.Drawing.Point(112, 142);
        this.icsBaudrateSelectBox.Name = "icsBaudrateSelectBox";
        this.icsBaudrateSelectBox.Size = new System.Drawing.Size(79, 20);
        this.icsBaudrateSelectBox.TabIndex = 83;
        this.icsBaudrateSelectBox.DropDownClosed += new System.EventHandler(this.icsBaudrateSelectBox_DropDownClosed);
        // 
        // label22
        // 
        this.label22.AutoSize = true;
        this.label22.Location = new System.Drawing.Point(14, 145);
        this.label22.Name = "label22";
        this.label22.Size = new System.Drawing.Size(71, 12);
        this.label22.TabIndex = 82;
        this.label22.Text = "ICS通信速度";
        // 
        // comBaudrateSelectBox
        // 
        this.comBaudrateSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comBaudrateSelectBox.FormattingEnabled = true;
        this.comBaudrateSelectBox.Items.AddRange(new object[] {
            "115200",
            "625000",
            "1250000"});
        this.comBaudrateSelectBox.Location = new System.Drawing.Point(112, 112);
        this.comBaudrateSelectBox.Name = "comBaudrateSelectBox";
        this.comBaudrateSelectBox.Size = new System.Drawing.Size(79, 20);
        this.comBaudrateSelectBox.TabIndex = 81;
        this.comBaudrateSelectBox.DropDownClosed += new System.EventHandler(this.comBaudrateSelectBox_DropDownClosed);
        // 
        // label21
        // 
        this.label21.AutoSize = true;
        this.label21.Location = new System.Drawing.Point(14, 115);
        this.label21.Name = "label21";
        this.label21.Size = new System.Drawing.Size(78, 12);
        this.label21.TabIndex = 80;
        this.label21.Text = "COM通信速度";
        // 
        // frameSelectBox
        // 
        this.frameSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.frameSelectBox.FormattingEnabled = true;
        this.frameSelectBox.Items.AddRange(new object[] {
            "10ms",
            "15ms",
            "20ms",
            "25ms"});
        this.frameSelectBox.Location = new System.Drawing.Point(112, 82);
        this.frameSelectBox.Name = "frameSelectBox";
        this.frameSelectBox.Size = new System.Drawing.Size(79, 20);
        this.frameSelectBox.TabIndex = 79;
        this.frameSelectBox.DropDownClosed += new System.EventHandler(this.frameSelectBox_DropDownClosed);
        // 
        // label20
        // 
        this.label20.AutoSize = true;
        this.label20.Location = new System.Drawing.Point(234, 145);
        this.label20.Name = "label20";
        this.label20.Size = new System.Drawing.Size(80, 12);
        this.label20.TabIndex = 78;
        this.label20.Text = "System Config";
        // 
        // cfgTextBox
        // 
        this.cfgTextBox.Location = new System.Drawing.Point(342, 142);
        this.cfgTextBox.Name = "cfgTextBox";
        this.cfgTextBox.ReadOnly = true;
        this.cfgTextBox.Size = new System.Drawing.Size(100, 19);
        this.cfgTextBox.TabIndex = 77;
        // 
        // checkBox12
        // 
        this.checkBox12.AutoSize = true;
        this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox12.Location = new System.Drawing.Point(97, 31);
        this.checkBox12.Name = "checkBox12";
        this.checkBox12.Size = new System.Drawing.Size(21, 30);
        this.checkBox12.TabIndex = 76;
        this.checkBox12.Text = "12";
        this.checkBox12.UseVisualStyleBackColor = true;
        this.checkBox12.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox13
        // 
        this.checkBox13.AutoSize = true;
        this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox13.Location = new System.Drawing.Point(70, 31);
        this.checkBox13.Name = "checkBox13";
        this.checkBox13.Size = new System.Drawing.Size(21, 30);
        this.checkBox13.TabIndex = 75;
        this.checkBox13.Text = "13";
        this.checkBox13.UseVisualStyleBackColor = true;
        this.checkBox13.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox14
        // 
        this.checkBox14.AutoSize = true;
        this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox14.Location = new System.Drawing.Point(43, 31);
        this.checkBox14.Name = "checkBox14";
        this.checkBox14.Size = new System.Drawing.Size(21, 30);
        this.checkBox14.TabIndex = 74;
        this.checkBox14.Text = "14";
        this.checkBox14.UseVisualStyleBackColor = true;
        this.checkBox14.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox0
        // 
        this.checkBox0.AutoSize = true;
        this.checkBox0.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox0.Location = new System.Drawing.Point(421, 31);
        this.checkBox0.Name = "checkBox0";
        this.checkBox0.Size = new System.Drawing.Size(21, 30);
        this.checkBox0.TabIndex = 73;
        this.checkBox0.Text = "00";
        this.checkBox0.UseVisualStyleBackColor = true;
        this.checkBox0.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox8
        // 
        this.checkBox8.AutoSize = true;
        this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox8.Location = new System.Drawing.Point(205, 31);
        this.checkBox8.Name = "checkBox8";
        this.checkBox8.Size = new System.Drawing.Size(21, 30);
        this.checkBox8.TabIndex = 72;
        this.checkBox8.Text = "08";
        this.checkBox8.UseVisualStyleBackColor = true;
        this.checkBox8.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox9
        // 
        this.checkBox9.AutoSize = true;
        this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox9.Location = new System.Drawing.Point(178, 31);
        this.checkBox9.Name = "checkBox9";
        this.checkBox9.Size = new System.Drawing.Size(21, 30);
        this.checkBox9.TabIndex = 71;
        this.checkBox9.Text = "09";
        this.checkBox9.UseVisualStyleBackColor = true;
        this.checkBox9.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox10
        // 
        this.checkBox10.AutoSize = true;
        this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox10.Location = new System.Drawing.Point(151, 31);
        this.checkBox10.Name = "checkBox10";
        this.checkBox10.Size = new System.Drawing.Size(21, 30);
        this.checkBox10.TabIndex = 70;
        this.checkBox10.Text = "10";
        this.checkBox10.UseVisualStyleBackColor = true;
        this.checkBox10.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox11
        // 
        this.checkBox11.AutoSize = true;
        this.checkBox11.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox11.Location = new System.Drawing.Point(124, 31);
        this.checkBox11.Name = "checkBox11";
        this.checkBox11.Size = new System.Drawing.Size(21, 30);
        this.checkBox11.TabIndex = 69;
        this.checkBox11.Text = "11";
        this.checkBox11.UseVisualStyleBackColor = true;
        this.checkBox11.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox4
        // 
        this.checkBox4.AutoSize = true;
        this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox4.Location = new System.Drawing.Point(313, 31);
        this.checkBox4.Name = "checkBox4";
        this.checkBox4.Size = new System.Drawing.Size(21, 30);
        this.checkBox4.TabIndex = 68;
        this.checkBox4.Text = "04";
        this.checkBox4.UseVisualStyleBackColor = true;
        this.checkBox4.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox5
        // 
        this.checkBox5.AutoSize = true;
        this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox5.Location = new System.Drawing.Point(286, 31);
        this.checkBox5.Name = "checkBox5";
        this.checkBox5.Size = new System.Drawing.Size(21, 30);
        this.checkBox5.TabIndex = 67;
        this.checkBox5.Text = "05";
        this.checkBox5.UseVisualStyleBackColor = true;
        this.checkBox5.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox6
        // 
        this.checkBox6.AutoSize = true;
        this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox6.Location = new System.Drawing.Point(259, 31);
        this.checkBox6.Name = "checkBox6";
        this.checkBox6.Size = new System.Drawing.Size(21, 30);
        this.checkBox6.TabIndex = 66;
        this.checkBox6.Text = "06";
        this.checkBox6.UseVisualStyleBackColor = true;
        this.checkBox6.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox7
        // 
        this.checkBox7.AutoSize = true;
        this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox7.Location = new System.Drawing.Point(232, 31);
        this.checkBox7.Name = "checkBox7";
        this.checkBox7.Size = new System.Drawing.Size(21, 30);
        this.checkBox7.TabIndex = 65;
        this.checkBox7.Text = "07";
        this.checkBox7.UseVisualStyleBackColor = true;
        this.checkBox7.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox3
        // 
        this.checkBox3.AutoSize = true;
        this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox3.Location = new System.Drawing.Point(340, 31);
        this.checkBox3.Name = "checkBox3";
        this.checkBox3.Size = new System.Drawing.Size(21, 30);
        this.checkBox3.TabIndex = 64;
        this.checkBox3.Text = "03";
        this.checkBox3.UseVisualStyleBackColor = true;
        this.checkBox3.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox2
        // 
        this.checkBox2.AutoSize = true;
        this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox2.Location = new System.Drawing.Point(367, 31);
        this.checkBox2.Name = "checkBox2";
        this.checkBox2.Size = new System.Drawing.Size(21, 30);
        this.checkBox2.TabIndex = 63;
        this.checkBox2.Text = "02";
        this.checkBox2.UseVisualStyleBackColor = true;
        this.checkBox2.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox1
        // 
        this.checkBox1.AutoSize = true;
        this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox1.Location = new System.Drawing.Point(394, 31);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new System.Drawing.Size(21, 30);
        this.checkBox1.TabIndex = 62;
        this.checkBox1.Text = "01";
        this.checkBox1.UseVisualStyleBackColor = true;
        this.checkBox1.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // checkBox15
        // 
        this.checkBox15.AutoSize = true;
        this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.checkBox15.Location = new System.Drawing.Point(16, 31);
        this.checkBox15.Name = "checkBox15";
        this.checkBox15.Size = new System.Drawing.Size(21, 30);
        this.checkBox15.TabIndex = 61;
        this.checkBox15.Text = "15";
        this.checkBox15.UseVisualStyleBackColor = true;
        this.checkBox15.Click += new System.EventHandler(this.checkBox_Click);
        // 
        // cfgReadCmdButton
        // 
        this.cfgReadCmdButton.Location = new System.Drawing.Point(473, 33);
        this.cfgReadCmdButton.Name = "cfgReadCmdButton";
        this.cfgReadCmdButton.Size = new System.Drawing.Size(96, 28);
        this.cfgReadCmdButton.TabIndex = 44;
        this.cfgReadCmdButton.Text = "読み取り";
        this.cfgReadCmdButton.UseVisualStyleBackColor = true;
        this.cfgReadCmdButton.Click += new System.EventHandler(this.cfgReadCmdButton_Click);
        // 
        // cfgGenCmdButton
        // 
        this.cfgGenCmdButton.Location = new System.Drawing.Point(473, 137);
        this.cfgGenCmdButton.Name = "cfgGenCmdButton";
        this.cfgGenCmdButton.Size = new System.Drawing.Size(96, 28);
        this.cfgGenCmdButton.TabIndex = 43;
        this.cfgGenCmdButton.Text = "コマンド生成";
        this.cfgGenCmdButton.UseVisualStyleBackColor = true;
        this.cfgGenCmdButton.Click += new System.EventHandler(this.cfgGenCmdButton_Click);
        // 
        // tabPage4
        // 
        this.tabPage4.Controls.Add(this.mpGroupBox);
        this.tabPage4.Location = new System.Drawing.Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Size = new System.Drawing.Size(607, 324);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "モーション再生";
        this.tabPage4.UseVisualStyleBackColor = true;
        // 
        // mpGroupBox
        // 
        this.mpGroupBox.Controls.Add(this.motionCmdSendButton);
        this.mpGroupBox.Controls.Add(this.sendMotionPlayCmdutton);
        this.mpGroupBox.Controls.Add(this.sendCallCmdButton);
        this.mpGroupBox.Controls.Add(this.sendResetCmdButton);
        this.mpGroupBox.Controls.Add(this.sendSuspendCmdButton);
        this.mpGroupBox.Controls.Add(this.label29);
        this.mpGroupBox.Controls.Add(this.sendMotionPlayCmdTextBox);
        this.mpGroupBox.Controls.Add(this.label28);
        this.mpGroupBox.Controls.Add(this.label27);
        this.mpGroupBox.Controls.Add(this.label26);
        this.mpGroupBox.Controls.Add(this.sendCallCmdTextBox);
        this.mpGroupBox.Controls.Add(this.sendResetCmdTextBox);
        this.mpGroupBox.Controls.Add(this.sendSuspendCmdtextBox);
        this.mpGroupBox.Controls.Add(this.label24);
        this.mpGroupBox.Controls.Add(this.motionGenCmdButton);
        this.mpGroupBox.Controls.Add(this.motionNumberUpDown);
        this.mpGroupBox.Controls.Add(this.label25);
        this.mpGroupBox.Location = new System.Drawing.Point(10, 6);
        this.mpGroupBox.Name = "mpGroupBox";
        this.mpGroupBox.Size = new System.Drawing.Size(582, 283);
        this.mpGroupBox.TabIndex = 28;
        this.mpGroupBox.TabStop = false;
        this.mpGroupBox.Text = "モーション再生（HeartToHeart4 Ver.2.2）";
        // 
        // motionCmdSendButton
        // 
        this.motionCmdSendButton.Location = new System.Drawing.Point(473, 23);
        this.motionCmdSendButton.Name = "motionCmdSendButton";
        this.motionCmdSendButton.Size = new System.Drawing.Size(96, 28);
        this.motionCmdSendButton.TabIndex = 56;
        this.motionCmdSendButton.Text = "全て送信";
        this.motionCmdSendButton.UseVisualStyleBackColor = true;
        this.motionCmdSendButton.Click += new System.EventHandler(this.motionCmdSendButton_Click);
        // 
        // sendMotionPlayCmdutton
        // 
        this.sendMotionPlayCmdutton.Location = new System.Drawing.Point(473, 241);
        this.sendMotionPlayCmdutton.Name = "sendMotionPlayCmdutton";
        this.sendMotionPlayCmdutton.Size = new System.Drawing.Size(96, 28);
        this.sendMotionPlayCmdutton.TabIndex = 55;
        this.sendMotionPlayCmdutton.Text = "送信";
        this.sendMotionPlayCmdutton.UseVisualStyleBackColor = true;
        this.sendMotionPlayCmdutton.Click += new System.EventHandler(this.sendMotionPlayCmdutton_Click);
        // 
        // sendCallCmdButton
        // 
        this.sendCallCmdButton.Location = new System.Drawing.Point(473, 190);
        this.sendCallCmdButton.Name = "sendCallCmdButton";
        this.sendCallCmdButton.Size = new System.Drawing.Size(96, 28);
        this.sendCallCmdButton.TabIndex = 54;
        this.sendCallCmdButton.Text = "送信";
        this.sendCallCmdButton.UseVisualStyleBackColor = true;
        this.sendCallCmdButton.Click += new System.EventHandler(this.sendCallCmdButton_Click);
        // 
        // sendResetCmdButton
        // 
        this.sendResetCmdButton.Location = new System.Drawing.Point(473, 139);
        this.sendResetCmdButton.Name = "sendResetCmdButton";
        this.sendResetCmdButton.Size = new System.Drawing.Size(96, 28);
        this.sendResetCmdButton.TabIndex = 53;
        this.sendResetCmdButton.Text = "送信";
        this.sendResetCmdButton.UseVisualStyleBackColor = true;
        this.sendResetCmdButton.Click += new System.EventHandler(this.sendResetCmdButton_Click);
        // 
        // sendSuspendCmdButton
        // 
        this.sendSuspendCmdButton.Location = new System.Drawing.Point(473, 88);
        this.sendSuspendCmdButton.Name = "sendSuspendCmdButton";
        this.sendSuspendCmdButton.Size = new System.Drawing.Size(96, 28);
        this.sendSuspendCmdButton.TabIndex = 52;
        this.sendSuspendCmdButton.Text = "送信";
        this.sendSuspendCmdButton.UseVisualStyleBackColor = true;
        this.sendSuspendCmdButton.Click += new System.EventHandler(this.sendSuspendCmdButton_Click);
        // 
        // label29
        // 
        this.label29.AutoSize = true;
        this.label29.Location = new System.Drawing.Point(14, 226);
        this.label29.Name = "label29";
        this.label29.Size = new System.Drawing.Size(114, 12);
        this.label29.TabIndex = 51;
        this.label29.Text = "4．モーションをリスタート";
        // 
        // sendMotionPlayCmdTextBox
        // 
        this.sendMotionPlayCmdTextBox.Location = new System.Drawing.Point(34, 246);
        this.sendMotionPlayCmdTextBox.Name = "sendMotionPlayCmdTextBox";
        this.sendMotionPlayCmdTextBox.ReadOnly = true;
        this.sendMotionPlayCmdTextBox.Size = new System.Drawing.Size(428, 19);
        this.sendMotionPlayCmdTextBox.TabIndex = 50;
        // 
        // label28
        // 
        this.label28.AutoSize = true;
        this.label28.Location = new System.Drawing.Point(14, 175);
        this.label28.Name = "label28";
        this.label28.Size = new System.Drawing.Size(185, 12);
        this.label28.TabIndex = 49;
        this.label28.Text = "3. コール命令で移動先アドレスをセット";
        // 
        // label27
        // 
        this.label27.AutoSize = true;
        this.label27.Location = new System.Drawing.Point(14, 124);
        this.label27.Name = "label27";
        this.label27.Size = new System.Drawing.Size(251, 12);
        this.label27.TabIndex = 48;
        this.label27.Text = "2. プログラムカウンターとEEPROM更新フラグをリセット";
        // 
        // label26
        // 
        this.label26.AutoSize = true;
        this.label26.Location = new System.Drawing.Point(14, 73);
        this.label26.Name = "label26";
        this.label26.Size = new System.Drawing.Size(117, 12);
        this.label26.TabIndex = 47;
        this.label26.Text = "1. モーションをサスペンド";
        // 
        // sendCallCmdTextBox
        // 
        this.sendCallCmdTextBox.Location = new System.Drawing.Point(34, 195);
        this.sendCallCmdTextBox.Name = "sendCallCmdTextBox";
        this.sendCallCmdTextBox.ReadOnly = true;
        this.sendCallCmdTextBox.Size = new System.Drawing.Size(428, 19);
        this.sendCallCmdTextBox.TabIndex = 46;
        // 
        // sendResetCmdTextBox
        // 
        this.sendResetCmdTextBox.Location = new System.Drawing.Point(34, 144);
        this.sendResetCmdTextBox.Name = "sendResetCmdTextBox";
        this.sendResetCmdTextBox.ReadOnly = true;
        this.sendResetCmdTextBox.Size = new System.Drawing.Size(428, 19);
        this.sendResetCmdTextBox.TabIndex = 45;
        // 
        // sendSuspendCmdtextBox
        // 
        this.sendSuspendCmdtextBox.Location = new System.Drawing.Point(34, 93);
        this.sendSuspendCmdtextBox.Name = "sendSuspendCmdtextBox";
        this.sendSuspendCmdtextBox.ReadOnly = true;
        this.sendSuspendCmdtextBox.Size = new System.Drawing.Size(428, 19);
        this.sendSuspendCmdtextBox.TabIndex = 44;
        // 
        // label24
        // 
        this.label24.AutoSize = true;
        this.label24.Location = new System.Drawing.Point(196, 31);
        this.label24.Name = "label24";
        this.label24.Size = new System.Drawing.Size(49, 12);
        this.label24.TabIndex = 43;
        this.label24.Text = "(アドレス)";
        // 
        // motionGenCmdButton
        // 
        this.motionGenCmdButton.Location = new System.Drawing.Point(371, 23);
        this.motionGenCmdButton.Name = "motionGenCmdButton";
        this.motionGenCmdButton.Size = new System.Drawing.Size(96, 28);
        this.motionGenCmdButton.TabIndex = 42;
        this.motionGenCmdButton.Text = "コマンド生成";
        this.motionGenCmdButton.UseVisualStyleBackColor = true;
        this.motionGenCmdButton.Click += new System.EventHandler(this.motionGenCmdButton_Click);
        // 
        // motionNumberUpDown
        // 
        this.motionNumberUpDown.Location = new System.Drawing.Point(113, 29);
        this.motionNumberUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
        this.motionNumberUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.motionNumberUpDown.Name = "motionNumberUpDown";
        this.motionNumberUpDown.Size = new System.Drawing.Size(70, 19);
        this.motionNumberUpDown.TabIndex = 41;
        this.motionNumberUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.motionNumberUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // label25
        // 
        this.label25.AutoSize = true;
        this.label25.Location = new System.Drawing.Point(14, 31);
        this.label25.Name = "label25";
        this.label25.Size = new System.Drawing.Size(73, 12);
        this.label25.TabIndex = 0;
        this.label25.Text = "モーション番号";
        // 
        // tabPage7
        // 
        this.tabPage7.Controls.Add(this.pa4TrackBar);
        this.tabPage7.Controls.Add(this.pa2TrackBar);
        this.tabPage7.Controls.Add(this.pa3TrackBar);
        this.tabPage7.Controls.Add(this.pa1TrackBar);
        this.tabPage7.Controls.Add(this.krcButton);
        this.tabPage7.Controls.Add(this.tableLayoutPanel1);
        this.tabPage7.Location = new System.Drawing.Point(4, 22);
        this.tabPage7.Name = "tabPage7";
        this.tabPage7.Size = new System.Drawing.Size(607, 324);
        this.tabPage7.TabIndex = 6;
        this.tabPage7.Text = "コントローラー";
        this.tabPage7.UseVisualStyleBackColor = true;
        // 
        // pa4TrackBar
        // 
        this.pa4TrackBar.Location = new System.Drawing.Point(277, 271);
        this.pa4TrackBar.Maximum = 127;
        this.pa4TrackBar.Name = "pa4TrackBar";
        this.pa4TrackBar.Size = new System.Drawing.Size(177, 45);
        this.pa4TrackBar.TabIndex = 47;
        this.pa4TrackBar.TickFrequency = 8;
        this.pa4TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
        // 
        // pa2TrackBar
        // 
        this.pa2TrackBar.Location = new System.Drawing.Point(74, 271);
        this.pa2TrackBar.Maximum = 127;
        this.pa2TrackBar.Name = "pa2TrackBar";
        this.pa2TrackBar.Size = new System.Drawing.Size(178, 45);
        this.pa2TrackBar.TabIndex = 45;
        this.pa2TrackBar.TickFrequency = 8;
        this.pa2TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
        // 
        // pa3TrackBar
        // 
        this.pa3TrackBar.Location = new System.Drawing.Point(463, 102);
        this.pa3TrackBar.Maximum = 127;
        this.pa3TrackBar.Name = "pa3TrackBar";
        this.pa3TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
        this.pa3TrackBar.Size = new System.Drawing.Size(45, 160);
        this.pa3TrackBar.TabIndex = 46;
        this.pa3TrackBar.TickFrequency = 8;
        this.pa3TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
        // 
        // pa1TrackBar
        // 
        this.pa1TrackBar.Location = new System.Drawing.Point(20, 102);
        this.pa1TrackBar.Maximum = 127;
        this.pa1TrackBar.Name = "pa1TrackBar";
        this.pa1TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
        this.pa1TrackBar.Size = new System.Drawing.Size(45, 160);
        this.pa1TrackBar.TabIndex = 44;
        this.pa1TrackBar.TickFrequency = 8;
        this.pa1TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
        // 
        // krcButton
        // 
        this.krcButton.Location = new System.Drawing.Point(483, 18);
        this.krcButton.Name = "krcButton";
        this.krcButton.Size = new System.Drawing.Size(96, 28);
        this.krcButton.TabIndex = 43;
        this.krcButton.Text = "コマンド生成";
        this.krcButton.UseVisualStyleBackColor = true;
        this.krcButton.Click += new System.EventHandler(this.krcButton_Click);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 7;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        this.tableLayoutPanel1.Controls.Add(this.RUL, 4, 2);
        this.tableLayoutPanel1.Controls.Add(this.RU, 5, 2);
        this.tableLayoutPanel1.Controls.Add(this.RUR, 6, 2);
        this.tableLayoutPanel1.Controls.Add(this.LL, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.LUL, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.LU, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.S3, 6, 1);
        this.tableLayoutPanel1.Controls.Add(this.S4, 6, 0);
        this.tableLayoutPanel1.Controls.Add(this.S1, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.N, 1, 3);
        this.tableLayoutPanel1.Controls.Add(this.LR, 2, 3);
        this.tableLayoutPanel1.Controls.Add(this.RL, 4, 3);
        this.tableLayoutPanel1.Controls.Add(this.RR, 6, 3);
        this.tableLayoutPanel1.Controls.Add(this.RDL, 4, 4);
        this.tableLayoutPanel1.Controls.Add(this.RD, 5, 4);
        this.tableLayoutPanel1.Controls.Add(this.LUR, 2, 2);
        this.tableLayoutPanel1.Controls.Add(this.LD, 1, 4);
        this.tableLayoutPanel1.Controls.Add(this.RDR, 6, 4);
        this.tableLayoutPanel1.Controls.Add(this.LDR, 2, 4);
        this.tableLayoutPanel1.Controls.Add(this.LDL, 0, 4);
        this.tableLayoutPanel1.Controls.Add(this.S2, 0, 0);
        this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 12);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 5;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 250);
        this.tableLayoutPanel1.TabIndex = 3;
        // 
        // RUL
        // 
        this.RUL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RUL.Appearance = System.Windows.Forms.Appearance.Button;
        this.RUL.Location = new System.Drawing.Point(209, 104);
        this.RUL.Name = "RUL";
        this.RUL.Size = new System.Drawing.Size(42, 42);
        this.RUL.TabIndex = 20;
        this.RUL.Text = "RUL";
        this.RUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RUL.UseVisualStyleBackColor = true;
        // 
        // RU
        // 
        this.RU.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RU.Appearance = System.Windows.Forms.Appearance.Button;
        this.RU.Location = new System.Drawing.Point(269, 104);
        this.RU.Name = "RU";
        this.RU.Size = new System.Drawing.Size(42, 42);
        this.RU.TabIndex = 21;
        this.RU.Text = "RU";
        this.RU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RU.UseVisualStyleBackColor = true;
        // 
        // RUR
        // 
        this.RUR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RUR.Appearance = System.Windows.Forms.Appearance.Button;
        this.RUR.Location = new System.Drawing.Point(329, 104);
        this.RUR.Name = "RUR";
        this.RUR.Size = new System.Drawing.Size(42, 42);
        this.RUR.TabIndex = 19;
        this.RUR.Text = "RUR";
        this.RUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RUR.UseVisualStyleBackColor = true;
        // 
        // LL
        // 
        this.LL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LL.Appearance = System.Windows.Forms.Appearance.Button;
        this.LL.Location = new System.Drawing.Point(9, 154);
        this.LL.Name = "LL";
        this.LL.Size = new System.Drawing.Size(42, 42);
        this.LL.TabIndex = 18;
        this.LL.Text = "LL";
        this.LL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LL.UseVisualStyleBackColor = true;
        // 
        // LUL
        // 
        this.LUL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LUL.Appearance = System.Windows.Forms.Appearance.Button;
        this.LUL.Location = new System.Drawing.Point(9, 104);
        this.LUL.Name = "LUL";
        this.LUL.Size = new System.Drawing.Size(42, 42);
        this.LUL.TabIndex = 16;
        this.LUL.Text = "LUL";
        this.LUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LUL.UseVisualStyleBackColor = true;
        // 
        // LU
        // 
        this.LU.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LU.Appearance = System.Windows.Forms.Appearance.Button;
        this.LU.Location = new System.Drawing.Point(69, 104);
        this.LU.Name = "LU";
        this.LU.Size = new System.Drawing.Size(42, 42);
        this.LU.TabIndex = 17;
        this.LU.Text = "LU";
        this.LU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LU.UseVisualStyleBackColor = true;
        // 
        // S3
        // 
        this.S3.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.S3.Appearance = System.Windows.Forms.Appearance.Button;
        this.S3.Location = new System.Drawing.Point(329, 54);
        this.S3.Name = "S3";
        this.S3.Size = new System.Drawing.Size(42, 42);
        this.S3.TabIndex = 10;
        this.S3.Text = "S3";
        this.S3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.S3.UseVisualStyleBackColor = true;
        // 
        // S4
        // 
        this.S4.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.S4.Appearance = System.Windows.Forms.Appearance.Button;
        this.S4.Location = new System.Drawing.Point(329, 4);
        this.S4.Name = "S4";
        this.S4.Size = new System.Drawing.Size(42, 42);
        this.S4.TabIndex = 9;
        this.S4.Text = "S4";
        this.S4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.S4.UseVisualStyleBackColor = true;
        // 
        // S1
        // 
        this.S1.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.S1.Appearance = System.Windows.Forms.Appearance.Button;
        this.S1.Location = new System.Drawing.Point(9, 54);
        this.S1.Name = "S1";
        this.S1.Size = new System.Drawing.Size(42, 42);
        this.S1.TabIndex = 1;
        this.S1.Text = "S1";
        this.S1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.S1.UseVisualStyleBackColor = true;
        // 
        // N
        // 
        this.N.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.N.Appearance = System.Windows.Forms.Appearance.Button;
        this.N.Location = new System.Drawing.Point(69, 154);
        this.N.Name = "N";
        this.N.Size = new System.Drawing.Size(42, 42);
        this.N.TabIndex = 4;
        this.N.Text = "N";
        this.N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.N.UseVisualStyleBackColor = true;
        // 
        // LR
        // 
        this.LR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LR.Appearance = System.Windows.Forms.Appearance.Button;
        this.LR.Location = new System.Drawing.Point(129, 154);
        this.LR.Name = "LR";
        this.LR.Size = new System.Drawing.Size(42, 42);
        this.LR.TabIndex = 5;
        this.LR.Text = "LR";
        this.LR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LR.UseVisualStyleBackColor = true;
        // 
        // RL
        // 
        this.RL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RL.Appearance = System.Windows.Forms.Appearance.Button;
        this.RL.Location = new System.Drawing.Point(209, 154);
        this.RL.Name = "RL";
        this.RL.Size = new System.Drawing.Size(42, 42);
        this.RL.TabIndex = 3;
        this.RL.Text = "RL";
        this.RL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RL.UseVisualStyleBackColor = true;
        // 
        // RR
        // 
        this.RR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RR.Appearance = System.Windows.Forms.Appearance.Button;
        this.RR.Location = new System.Drawing.Point(329, 154);
        this.RR.Name = "RR";
        this.RR.Size = new System.Drawing.Size(42, 42);
        this.RR.TabIndex = 12;
        this.RR.Text = "RR";
        this.RR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RR.UseVisualStyleBackColor = true;
        // 
        // RDL
        // 
        this.RDL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RDL.Appearance = System.Windows.Forms.Appearance.Button;
        this.RDL.Location = new System.Drawing.Point(209, 204);
        this.RDL.Name = "RDL";
        this.RDL.Size = new System.Drawing.Size(42, 42);
        this.RDL.TabIndex = 8;
        this.RDL.Text = "RDL";
        this.RDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RDL.UseVisualStyleBackColor = true;
        // 
        // RD
        // 
        this.RD.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RD.Appearance = System.Windows.Forms.Appearance.Button;
        this.RD.Location = new System.Drawing.Point(269, 204);
        this.RD.Name = "RD";
        this.RD.Size = new System.Drawing.Size(42, 42);
        this.RD.TabIndex = 2;
        this.RD.Text = "RD";
        this.RD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RD.UseVisualStyleBackColor = true;
        // 
        // LUR
        // 
        this.LUR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LUR.Appearance = System.Windows.Forms.Appearance.Button;
        this.LUR.Location = new System.Drawing.Point(129, 104);
        this.LUR.Name = "LUR";
        this.LUR.Size = new System.Drawing.Size(42, 42);
        this.LUR.TabIndex = 13;
        this.LUR.Text = "LUR";
        this.LUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LUR.UseVisualStyleBackColor = true;
        // 
        // LD
        // 
        this.LD.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LD.Appearance = System.Windows.Forms.Appearance.Button;
        this.LD.Location = new System.Drawing.Point(69, 204);
        this.LD.Name = "LD";
        this.LD.Size = new System.Drawing.Size(42, 42);
        this.LD.TabIndex = 6;
        this.LD.Text = "LD";
        this.LD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LD.UseVisualStyleBackColor = true;
        // 
        // RDR
        // 
        this.RDR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.RDR.Appearance = System.Windows.Forms.Appearance.Button;
        this.RDR.Location = new System.Drawing.Point(329, 204);
        this.RDR.Name = "RDR";
        this.RDR.Size = new System.Drawing.Size(42, 42);
        this.RDR.TabIndex = 15;
        this.RDR.Text = "RDR";
        this.RDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.RDR.UseVisualStyleBackColor = true;
        // 
        // LDR
        // 
        this.LDR.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LDR.Appearance = System.Windows.Forms.Appearance.Button;
        this.LDR.Location = new System.Drawing.Point(129, 204);
        this.LDR.Name = "LDR";
        this.LDR.Size = new System.Drawing.Size(42, 42);
        this.LDR.TabIndex = 11;
        this.LDR.Text = "LDR";
        this.LDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LDR.UseVisualStyleBackColor = true;
        // 
        // LDL
        // 
        this.LDL.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.LDL.Appearance = System.Windows.Forms.Appearance.Button;
        this.LDL.Location = new System.Drawing.Point(9, 204);
        this.LDL.Name = "LDL";
        this.LDL.Size = new System.Drawing.Size(42, 42);
        this.LDL.TabIndex = 7;
        this.LDL.Text = "LDL";
        this.LDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LDL.UseVisualStyleBackColor = true;
        // 
        // S2
        // 
        this.S2.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.S2.Appearance = System.Windows.Forms.Appearance.Button;
        this.S2.Location = new System.Drawing.Point(9, 4);
        this.S2.Name = "S2";
        this.S2.Size = new System.Drawing.Size(42, 42);
        this.S2.TabIndex = 0;
        this.S2.Text = "S2";
        this.S2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.S2.UseVisualStyleBackColor = true;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.moveGroupBox);
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(607, 324);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "MOVE命令";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // moveGroupBox
        // 
        this.moveGroupBox.Controls.Add(this.label17);
        this.moveGroupBox.Controls.Add(this.sendByteCountUpDown);
        this.moveGroupBox.Controls.Add(this.label16);
        this.moveGroupBox.Controls.Add(this.destAddrSelectBox);
        this.moveGroupBox.Controls.Add(this.srcAddrUpDown);
        this.moveGroupBox.Controls.Add(this.destAddrUpDown);
        this.moveGroupBox.Controls.Add(this.moveGenCmdButton);
        this.moveGroupBox.Controls.Add(this.icsGroupBox);
        this.moveGroupBox.Controls.Add(this.label10);
        this.moveGroupBox.Controls.Add(this.anyByteDataTextBox);
        this.moveGroupBox.Controls.Add(this.label5);
        this.moveGroupBox.Controls.Add(this.label4);
        this.moveGroupBox.Controls.Add(this.srcAddrSelectBox);
        this.moveGroupBox.Controls.Add(this.label3);
        this.moveGroupBox.Controls.Add(this.destTypeSelectBox);
        this.moveGroupBox.Controls.Add(this.label2);
        this.moveGroupBox.Controls.Add(this.srcTypeSelectBox);
        this.moveGroupBox.Location = new System.Drawing.Point(10, 6);
        this.moveGroupBox.Name = "moveGroupBox";
        this.moveGroupBox.Size = new System.Drawing.Size(582, 222);
        this.moveGroupBox.TabIndex = 24;
        this.moveGroupBox.TabStop = false;
        this.moveGroupBox.Text = "Move 【CMD = 00h】";
        // 
        // label17
        // 
        this.label17.AutoSize = true;
        this.label17.Location = new System.Drawing.Point(392, 24);
        this.label17.Name = "label17";
        this.label17.Size = new System.Drawing.Size(69, 12);
        this.label17.TabIndex = 42;
        this.label17.Tag = "";
        this.label17.Text = "送信データ数";
        // 
        // sendByteCountUpDown
        // 
        this.sendByteCountUpDown.Location = new System.Drawing.Point(394, 48);
        this.sendByteCountUpDown.Name = "sendByteCountUpDown";
        this.sendByteCountUpDown.Size = new System.Drawing.Size(70, 19);
        this.sendByteCountUpDown.TabIndex = 41;
        this.sendByteCountUpDown.Tag = "";
        this.sendByteCountUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label16
        // 
        this.label16.AutoSize = true;
        this.label16.Location = new System.Drawing.Point(75, 85);
        this.label16.Name = "label16";
        this.label16.Size = new System.Drawing.Size(89, 12);
        this.label16.TabIndex = 40;
        this.label16.Tag = "";
        this.label16.Text = "アドレス直接指定";
        // 
        // destAddrSelectBox
        // 
        this.destAddrSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.destAddrSelectBox.FormattingEnabled = true;
        this.destAddrSelectBox.Location = new System.Drawing.Point(287, 47);
        this.destAddrSelectBox.Name = "destAddrSelectBox";
        this.destAddrSelectBox.Size = new System.Drawing.Size(80, 20);
        this.destAddrSelectBox.TabIndex = 39;
        this.destAddrSelectBox.Tag = "";
        this.destAddrSelectBox.DropDownClosed += new System.EventHandler(this.destAddrSelectBox_DropDownClosed);
        // 
        // srcAddrUpDown
        // 
        this.srcAddrUpDown.Hexadecimal = true;
        this.srcAddrUpDown.Location = new System.Drawing.Point(197, 83);
        this.srcAddrUpDown.Maximum = new decimal(new int[] {
            1167,
            0,
            0,
            0});
        this.srcAddrUpDown.Name = "srcAddrUpDown";
        this.srcAddrUpDown.Size = new System.Drawing.Size(80, 19);
        this.srcAddrUpDown.TabIndex = 38;
        this.srcAddrUpDown.Tag = "2";
        this.srcAddrUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.srcAddrUpDown.ValueChanged += new System.EventHandler(this.srcAddrUpDown_ValueChanged);
        // 
        // destAddrUpDown
        // 
        this.destAddrUpDown.Hexadecimal = true;
        this.destAddrUpDown.Location = new System.Drawing.Point(287, 83);
        this.destAddrUpDown.Maximum = new decimal(new int[] {
            1167,
            0,
            0,
            0});
        this.destAddrUpDown.Name = "destAddrUpDown";
        this.destAddrUpDown.Size = new System.Drawing.Size(80, 19);
        this.destAddrUpDown.TabIndex = 37;
        this.destAddrUpDown.Tag = "6";
        this.destAddrUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.destAddrUpDown.ValueChanged += new System.EventHandler(this.destAddrUpDown_ValueChanged);
        // 
        // moveGenCmdButton
        // 
        this.moveGenCmdButton.Location = new System.Drawing.Point(473, 178);
        this.moveGenCmdButton.Name = "moveGenCmdButton";
        this.moveGenCmdButton.Size = new System.Drawing.Size(96, 28);
        this.moveGenCmdButton.TabIndex = 36;
        this.moveGenCmdButton.Tag = "";
        this.moveGenCmdButton.Text = "コマンド生成";
        this.moveGenCmdButton.UseVisualStyleBackColor = true;
        this.moveGenCmdButton.Click += new System.EventHandler(this.moveGenCmdButton_Click);
        // 
        // icsGroupBox
        // 
        this.icsGroupBox.Controls.Add(this.label11);
        this.icsGroupBox.Controls.Add(this.label7);
        this.icsGroupBox.Controls.Add(this.destDevOffsetUpDown);
        this.icsGroupBox.Controls.Add(this.srcDevOffsetUpDown);
        this.icsGroupBox.Controls.Add(this.destDevNoUpDown);
        this.icsGroupBox.Controls.Add(this.srcDevNoUpDown);
        this.icsGroupBox.Location = new System.Drawing.Point(77, 114);
        this.icsGroupBox.Name = "icsGroupBox";
        this.icsGroupBox.Size = new System.Drawing.Size(304, 92);
        this.icsGroupBox.TabIndex = 35;
        this.icsGroupBox.TabStop = false;
        this.icsGroupBox.Tag = "";
        this.icsGroupBox.Text = "ICSレジスタ";
        // 
        // label11
        // 
        this.label11.AutoSize = true;
        this.label11.Location = new System.Drawing.Point(25, 24);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(47, 12);
        this.label11.TabIndex = 27;
        this.label11.Tag = "";
        this.label11.Text = "ICS番号";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(28, 55);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(47, 12);
        this.label7.TabIndex = 26;
        this.label7.Tag = "";
        this.label7.Text = "オフセット";
        // 
        // destDevOffsetUpDown
        // 
        this.destDevOffsetUpDown.Location = new System.Drawing.Point(210, 53);
        this.destDevOffsetUpDown.Name = "destDevOffsetUpDown";
        this.destDevOffsetUpDown.Size = new System.Drawing.Size(80, 19);
        this.destDevOffsetUpDown.TabIndex = 25;
        this.destDevOffsetUpDown.Tag = "";
        this.destDevOffsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // srcDevOffsetUpDown
        // 
        this.srcDevOffsetUpDown.Location = new System.Drawing.Point(120, 53);
        this.srcDevOffsetUpDown.Name = "srcDevOffsetUpDown";
        this.srcDevOffsetUpDown.Size = new System.Drawing.Size(80, 19);
        this.srcDevOffsetUpDown.TabIndex = 24;
        this.srcDevOffsetUpDown.Tag = "";
        this.srcDevOffsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // destDevNoUpDown
        // 
        this.destDevNoUpDown.Location = new System.Drawing.Point(210, 22);
        this.destDevNoUpDown.Name = "destDevNoUpDown";
        this.destDevNoUpDown.Size = new System.Drawing.Size(80, 19);
        this.destDevNoUpDown.TabIndex = 23;
        this.destDevNoUpDown.Tag = "";
        this.destDevNoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // srcDevNoUpDown
        // 
        this.srcDevNoUpDown.Location = new System.Drawing.Point(120, 22);
        this.srcDevNoUpDown.Name = "srcDevNoUpDown";
        this.srcDevNoUpDown.Size = new System.Drawing.Size(80, 19);
        this.srcDevNoUpDown.TabIndex = 22;
        this.srcDevNoUpDown.Tag = "";
        this.srcDevNoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new System.Drawing.Point(392, 85);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(109, 12);
        this.label10.TabIndex = 34;
        this.label10.Tag = "";
        this.label10.Text = "任意のデータ列を送る";
        // 
        // anyByteDataTextBox
        // 
        this.anyByteDataTextBox.Location = new System.Drawing.Point(394, 108);
        this.anyByteDataTextBox.Name = "anyByteDataTextBox";
        this.anyByteDataTextBox.Size = new System.Drawing.Size(170, 19);
        this.anyByteDataTextBox.TabIndex = 33;
        this.anyByteDataTextBox.Tag = "";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(290, 24);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(77, 12);
        this.label5.TabIndex = 32;
        this.label5.Tag = "";
        this.label5.Text = "転送先アドレス";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(195, 24);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(77, 12);
        this.label4.TabIndex = 30;
        this.label4.Tag = "";
        this.label4.Text = "転送元アドレス";
        // 
        // srcAddrSelectBox
        // 
        this.srcAddrSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.srcAddrSelectBox.FormattingEnabled = true;
        this.srcAddrSelectBox.Location = new System.Drawing.Point(197, 47);
        this.srcAddrSelectBox.Name = "srcAddrSelectBox";
        this.srcAddrSelectBox.Size = new System.Drawing.Size(80, 20);
        this.srcAddrSelectBox.TabIndex = 29;
        this.srcAddrSelectBox.Tag = "";
        this.srcAddrSelectBox.DropDownClosed += new System.EventHandler(this.srcAddrSelectBox_DropDownClosed);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(105, 24);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(65, 12);
        this.label3.TabIndex = 28;
        this.label3.Tag = "";
        this.label3.Text = "転送先種類";
        // 
        // destTypeSelectBox
        // 
        this.destTypeSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.destTypeSelectBox.FormattingEnabled = true;
        this.destTypeSelectBox.Location = new System.Drawing.Point(107, 47);
        this.destTypeSelectBox.Name = "destTypeSelectBox";
        this.destTypeSelectBox.Size = new System.Drawing.Size(80, 20);
        this.destTypeSelectBox.TabIndex = 27;
        this.destTypeSelectBox.Tag = "";
        this.destTypeSelectBox.SelectionChangeCommitted += new System.EventHandler(this.destTypeSelectBox_SelectedIndexChanged);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(15, 24);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(65, 12);
        this.label2.TabIndex = 26;
        this.label2.Tag = "";
        this.label2.Text = "転送元種類";
        // 
        // srcTypeSelectBox
        // 
        this.srcTypeSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.srcTypeSelectBox.FormattingEnabled = true;
        this.srcTypeSelectBox.Location = new System.Drawing.Point(17, 47);
        this.srcTypeSelectBox.Name = "srcTypeSelectBox";
        this.srcTypeSelectBox.Size = new System.Drawing.Size(80, 20);
        this.srcTypeSelectBox.TabIndex = 25;
        this.srcTypeSelectBox.Tag = "";
        this.srcTypeSelectBox.SelectionChangeCommitted += new System.EventHandler(this.srcTypeSelectBox_SelectedIndexChanged);
        // 
        // addressLabel
        // 
        this.addressLabel.AutoSize = true;
        this.addressLabel.Location = new System.Drawing.Point(196, 31);
        this.addressLabel.Name = "addressLabel";
        this.addressLabel.Size = new System.Drawing.Size(49, 12);
        this.addressLabel.TabIndex = 43;
        this.addressLabel.Text = "(アドレス)";
        // 
        // mpGenCmdButton
        // 
        this.mpGenCmdButton.Location = new System.Drawing.Point(469, 23);
        this.mpGenCmdButton.Name = "mpGenCmdButton";
        this.mpGenCmdButton.Size = new System.Drawing.Size(85, 28);
        this.mpGenCmdButton.TabIndex = 42;
        this.mpGenCmdButton.Text = "コマンド生成";
        this.mpGenCmdButton.UseVisualStyleBackColor = true;
        // 
        // mpUpDown
        // 
        this.mpUpDown.Location = new System.Drawing.Point(113, 29);
        this.mpUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
        this.mpUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.mpUpDown.Name = "mpUpDown";
        this.mpUpDown.Size = new System.Drawing.Size(70, 19);
        this.mpUpDown.TabIndex = 41;
        this.mpUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.mpUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // label18
        // 
        this.label18.AutoSize = true;
        this.label18.Location = new System.Drawing.Point(14, 31);
        this.label18.Name = "label18";
        this.label18.Size = new System.Drawing.Size(73, 12);
        this.label18.TabIndex = 0;
        this.label18.Text = "モーション番号";
        // 
        // toolStrip1
        // 
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comComboBox,
            this.toolStripLabel2,
            this.baudrateComboBox,
            this.toolStripSeparator1,
            this.AckButton});
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(634, 26);
        this.toolStrip1.TabIndex = 28;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // toolStripLabel1
        // 
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new System.Drawing.Size(35, 23);
        this.toolStripLabel1.Text = "COM";
        // 
        // comComboBox
        // 
        this.comComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comComboBox.Name = "comComboBox";
        this.comComboBox.Size = new System.Drawing.Size(121, 26);
        this.comComboBox.DropDown += new System.EventHandler(this.comComboBox_DropDown);
        this.comComboBox.DropDownClosed += new System.EventHandler(this.comComboBox_DropDownClosed);
        // 
        // toolStripLabel2
        // 
        this.toolStripLabel2.Name = "toolStripLabel2";
        this.toolStripLabel2.Size = new System.Drawing.Size(68, 23);
        this.toolStripLabel2.Text = "ボーレート";
        // 
        // baudrateComboBox
        // 
        this.baudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.baudrateComboBox.Items.AddRange(new object[] {
            "115200",
            "625000",
            "1250000"});
        this.baudrateComboBox.Name = "baudrateComboBox";
        this.baudrateComboBox.Size = new System.Drawing.Size(121, 26);
        this.baudrateComboBox.DropDownClosed += new System.EventHandler(this.baudrateComboBox_DropDownClosed);
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
        // 
        // AckButton
        // 
        this.AckButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.AckButton.Image = ((System.Drawing.Image)(resources.GetObject("AckButton.Image")));
        this.AckButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.AckButton.Name = "AckButton";
        this.AckButton.Size = new System.Drawing.Size(81, 23);
        this.AckButton.Text = "Ackコマンド";
        this.AckButton.Click += new System.EventHandler(this.AckButton_Click);
        // 
        // Rcb4CmdGenForm
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.ClientSize = new System.Drawing.Size(634, 551);
        this.Controls.Add(this.toolStrip1);
        this.Controls.Add(this.tabControl1);
        this.Controls.Add(this.cmdGroupBox);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Rcb4CmdGenForm";
        this.Text = "RCB-4HV Command Generator LE for HeartToHeart4 Ver.2.2";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rcb4CmdGenForm_FormClosing);
        this.Shown += new System.EventHandler(this.Rcb4CmdGenForm_Shown);
        this.cmdGroupBox.ResumeLayout(false);
        this.cmdGroupBox.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.ssFrameUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.ssPositionUpDown)).EndInit();
        this.ssGroupBox.ResumeLayout(false);
        this.ssGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.idUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.sioUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.ssIcsNoUpDown)).EndInit();
        this.tabPage6.ResumeLayout(false);
        this.groupBox3.ResumeLayout(false);
        this.msGroupBox.ResumeLayout(false);
        this.msGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.msFrameUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.msPosUpDown)).EndInit();
        this.tabPage5.ResumeLayout(false);
        this.pioGroupBox.ResumeLayout(false);
        this.pioGroupBox.PerformLayout();
        this.adrGroupBox.ResumeLayout(false);
        this.adrGroupBox.PerformLayout();
        this.adGroupBox.ResumeLayout(false);
        this.adGroupBox.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.cfgGroupBox.ResumeLayout(false);
        this.cfgGroupBox.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.mpGroupBox.ResumeLayout(false);
        this.mpGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.motionNumberUpDown)).EndInit();
        this.tabPage7.ResumeLayout(false);
        this.tabPage7.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pa4TrackBar)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa2TrackBar)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa3TrackBar)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pa1TrackBar)).EndInit();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.moveGroupBox.ResumeLayout(false);
        this.moveGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.sendByteCountUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcAddrUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.destAddrUpDown)).EndInit();
        this.icsGroupBox.ResumeLayout(false);
        this.icsGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.destDevOffsetUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcDevOffsetUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.destDevNoUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.srcDevNoUpDown)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.mpUpDown)).EndInit();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox cmdGroupBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox resultTextBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox cmdTextBox;
    private System.IO.Ports.SerialPort serialPort;
    private System.Windows.Forms.Button cmdSendButton;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.GroupBox moveGroupBox;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.NumericUpDown sendByteCountUpDown;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.ComboBox destAddrSelectBox;
    private System.Windows.Forms.NumericUpDown srcAddrUpDown;
    private System.Windows.Forms.NumericUpDown destAddrUpDown;
    private System.Windows.Forms.Button moveGenCmdButton;
    private System.Windows.Forms.GroupBox icsGroupBox;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown destDevOffsetUpDown;
    private System.Windows.Forms.NumericUpDown srcDevOffsetUpDown;
    private System.Windows.Forms.NumericUpDown destDevNoUpDown;
    private System.Windows.Forms.NumericUpDown srcDevNoUpDown;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox anyByteDataTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox srcAddrSelectBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox destTypeSelectBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox srcTypeSelectBox;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.GroupBox ssGroupBox;
    private System.Windows.Forms.Button ssGenCmdButton;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown ssFrameUpDown;
    private System.Windows.Forms.NumericUpDown ssIcsNoUpDown;
    private System.Windows.Forms.NumericUpDown ssPositionUpDown;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.GroupBox cfgGroupBox;
    private System.Windows.Forms.Button cfgReadCmdButton;
    private System.Windows.Forms.Button cfgGenCmdButton;
    private System.Windows.Forms.CheckBox checkBox12;
    private System.Windows.Forms.CheckBox checkBox13;
    private System.Windows.Forms.CheckBox checkBox14;
    private System.Windows.Forms.CheckBox checkBox0;
    private System.Windows.Forms.CheckBox checkBox8;
    private System.Windows.Forms.CheckBox checkBox9;
    private System.Windows.Forms.CheckBox checkBox10;
    private System.Windows.Forms.CheckBox checkBox11;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.CheckBox checkBox7;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox15;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.TextBox cfgTextBox;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.ComboBox icsBaudrateSelectBox;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.ComboBox comBaudrateSelectBox;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.ComboBox frameSelectBox;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.GroupBox mpGroupBox;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Button motionGenCmdButton;
    private System.Windows.Forms.NumericUpDown motionNumberUpDown;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.Label addressLabel;
    private System.Windows.Forms.Button mpGenCmdButton;
    private System.Windows.Forms.NumericUpDown mpUpDown;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox sendCallCmdTextBox;
    private System.Windows.Forms.TextBox sendResetCmdTextBox;
    private System.Windows.Forms.TextBox sendSuspendCmdtextBox;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.TextBox sendMotionPlayCmdTextBox;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.Button sendCallCmdButton;
    private System.Windows.Forms.Button sendResetCmdButton;
    private System.Windows.Forms.Button sendSuspendCmdButton;
    private System.Windows.Forms.Button sendMotionPlayCmdutton;
    private System.Windows.Forms.Button motionCmdSendButton;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.GroupBox adGroupBox;
    private System.Windows.Forms.RadioButton ad10RadioButton;
    private System.Windows.Forms.RadioButton ad9RadioButton;
    private System.Windows.Forms.RadioButton ad8RadioButton;
    private System.Windows.Forms.RadioButton ad7RadioButton;
    private System.Windows.Forms.RadioButton ad6RadioButton;
    private System.Windows.Forms.RadioButton ad5RadioButton;
    private System.Windows.Forms.RadioButton ad4RadioButton;
    private System.Windows.Forms.RadioButton ad3RadioButton;
    private System.Windows.Forms.RadioButton ad2RadioButton;
    private System.Windows.Forms.RadioButton ad1RadioButton;
    private System.Windows.Forms.RadioButton ad0RadioButton;
    private System.Windows.Forms.GroupBox adrGroupBox;
    private System.Windows.Forms.Button adrReadButton;
    private System.Windows.Forms.RadioButton adr10RadioButton;
    private System.Windows.Forms.RadioButton adr9RadioButton;
    private System.Windows.Forms.RadioButton adr8RadioButton;
    private System.Windows.Forms.RadioButton adr7RadioButton;
    private System.Windows.Forms.RadioButton adr6RadioButton;
    private System.Windows.Forms.RadioButton adr5RadioButton;
    private System.Windows.Forms.RadioButton adr4RadioButton;
    private System.Windows.Forms.RadioButton adr3RadioButton;
    private System.Windows.Forms.RadioButton adr2RadioButton;
    private System.Windows.Forms.RadioButton adr1RadioButton;
    private System.Windows.Forms.RadioButton adr0RadioButton;
    private System.Windows.Forms.Button adReadButton;
    private System.Windows.Forms.GroupBox pioGroupBox;
    private System.Windows.Forms.CheckBox pio1CheckBox;
    private System.Windows.Forms.Button pioInButton;
    private System.Windows.Forms.CheckBox pio10CheckBox;
    private System.Windows.Forms.CheckBox pio9CheckBox;
    private System.Windows.Forms.CheckBox pio8CheckBox;
    private System.Windows.Forms.CheckBox pio7CheckBox;
    private System.Windows.Forms.CheckBox pio6CheckBox;
    private System.Windows.Forms.CheckBox pio5CheckBox;
    private System.Windows.Forms.CheckBox pio4CheckBox;
    private System.Windows.Forms.CheckBox pio3CheckBox;
    private System.Windows.Forms.CheckBox pio2CheckBox;
    private System.Windows.Forms.Button pioOutButton;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.NumericUpDown idUpDown;
    private System.Windows.Forms.NumericUpDown sioUpDown;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton holdRadioButton;
    private System.Windows.Forms.RadioButton freeRadioButton;
    private System.Windows.Forms.Button freeButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.Button readPosButton;
    private System.Windows.Forms.GroupBox msGroupBox;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.NumericUpDown msFrameUpDown;
    private System.Windows.Forms.NumericUpDown msPosUpDown;
    private System.Windows.Forms.ListView icsDeviceListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Button msGenCmdButton;
    private System.Windows.Forms.ListView servoListView;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.Button clearListButton;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.CheckBox RUL;
    private System.Windows.Forms.CheckBox RU;
    private System.Windows.Forms.CheckBox RUR;
    private System.Windows.Forms.CheckBox LL;
    private System.Windows.Forms.CheckBox LUL;
    private System.Windows.Forms.CheckBox LU;
    private System.Windows.Forms.CheckBox S3;
    private System.Windows.Forms.CheckBox S4;
    private System.Windows.Forms.CheckBox S1;
    private System.Windows.Forms.CheckBox S2;
    private System.Windows.Forms.CheckBox N;
    private System.Windows.Forms.CheckBox LR;
    private System.Windows.Forms.CheckBox RL;
    private System.Windows.Forms.CheckBox RR;
    private System.Windows.Forms.CheckBox RDL;
    private System.Windows.Forms.CheckBox RD;
    private System.Windows.Forms.CheckBox LUR;
    private System.Windows.Forms.CheckBox LD;
    private System.Windows.Forms.CheckBox RDR;
    private System.Windows.Forms.CheckBox LDR;
    private System.Windows.Forms.CheckBox LDL;
    private System.Windows.Forms.Button krcButton;
    private System.Windows.Forms.TrackBar pa4TrackBar;
    private System.Windows.Forms.TrackBar pa2TrackBar;
    private System.Windows.Forms.TrackBar pa3TrackBar;
    private System.Windows.Forms.TrackBar pa1TrackBar;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripComboBox comComboBox;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripComboBox baudrateComboBox;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton AckButton;
  }
}

