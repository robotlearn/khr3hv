using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Extensions.Collections;
using Rcb4;

namespace Rcb4CommandGenerator
{

  /// <summary>
  /// Rcb4CommandGenerator LE
  /// </summary>
  public partial class Rcb4CmdGenForm: Form
  {
    // データを管理するためのリスト
    private NameObjectCollection srcCollection = new NameObjectCollection ();
    private NameObjectCollection destCollection = new NameObjectCollection ();

    // 受け取りデータ数を管理する
    int recv_count = 0;

    /// <summary>
    /// インスタンスコンストラクタ
    /// </summary>
    public Rcb4CmdGenForm ()
    {
      InitializeComponent ();

      this.Font = SystemInformation.MenuFont; // 表示フォントをメニューフォントにする
      this.DoubleBuffered = true; // ダブルバッファリングを有効に

      // MOVEコマンド用のデータ管理リストを作成する
      srcCollection.Add ("Battery", Rcb4.Rcb4.Adc0RamAddress);
      srcCollection.Add ("AD1", Rcb4.Rcb4.Adc1RamAddress);
      srcCollection.Add ("AD2", Rcb4.Rcb4.Adc2RamAddress);
      srcCollection.Add ("AD3", Rcb4.Rcb4.Adc3RamAddress);
      srcCollection.Add ("AD4", Rcb4.Rcb4.Adc4RamAddress);
      srcCollection.Add ("AD5", Rcb4.Rcb4.Adc5RamAddress);
      srcCollection.Add ("AD6", Rcb4.Rcb4.Adc6RamAddress);
      srcCollection.Add ("AD7", Rcb4.Rcb4.Adc7RamAddress);
      srcCollection.Add ("AD8", Rcb4.Rcb4.Adc8RamAddress);
      srcCollection.Add ("AD9", Rcb4.Rcb4.Adc9RamAddress);
      srcCollection.Add ("AD10", Rcb4.Rcb4.Adc10RamAddress);
      srcCollection.Add ("PIO_DIR", Rcb4.Rcb4.PioAddress);
      srcCollection.Add ("PIO", Rcb4.Rcb4.PioPortAddress);

      string s = string.Empty;
      int pos_addr = 0;

      // サーボリスト（Moveコマンド用）を作成する
      for (int i = 0; i < Rcb4.Rcb4.MaxDeviceNumner; i++)
      {
        // 表示名を作成
        s = "Servo " + i.ToString ("00");
        // 表示名（サーボモーターの番号）に対するRAMアドレスを作成
        pos_addr = Rcb4.Rcb4.ServoRamAddress + (i * Rcb4.Rcb4.ServoSingleDataCount) + Rcb4.Rcb4.PositionAddressOffset;
        // 項目を追加する
        destCollection.Add (s, pos_addr);
      }
    }

    #region フォームが画面時表示（消去）されたときのイベント
    
    /// <summary>
    /// フォームが画面時表示されたときのイベント（主にGUIメニューなどの初期設定）
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void Rcb4CmdGenForm_Shown (object sender, EventArgs e)
    {
      // 転送元データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        if (devType != Command.DeviceTypes.Compare)
        {
          srcTypeSelectBox.Items.Add (devType.ToString ());
        }
      }

      // 転送元データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        if (devType != Command.DeviceTypes.Compare)
        {
          destTypeSelectBox.Items.Add (devType.ToString ());
        }
      }

      // 転送元アドレスデータ
      srcAddrSelectBox.Items.AddRange (srcCollection.AllKeys);

      // 転送先アドレスデータ
      destAddrSelectBox.Items.AddRange (destCollection.AllKeys);

      //
      // サーボモーターのリストを作成する
      icsDeviceListView.Items.Clear ();

      for (int i = 0; i < Rcb4.Rcb4.MaxDeviceNumner; i++)
      {
        ListViewItem item1 = new ListViewItem (new string[] { i.ToString ("00"), "7500" });
        icsDeviceListView.Items.Add (item1);

        ListViewItem item2 = new ListViewItem (new string[] { i.ToString ("00"), "-", "-", "-" });
        servoListView.Items.Add (item2);
      }
    }

    /// <summary>
    /// フォームが閉じるときの処理
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void Rcb4CmdGenForm_FormClosing (object sender, FormClosingEventArgs e)
    {
      if (serialPort.IsOpen)
      {
        serialPort.Close (); // シリアルポートを閉じる
      }
    }
    #endregion

    #region シングルサーボ
    /// <summary>
    /// ID番号が変わったとき
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void idUpDown_ValueChanged (object sender, EventArgs e)
    {
      ssIcsNoUpDown.Value = idUpDown.Value * 2 + (sioUpDown.Value - 1);
    }

    /// <summary>
    /// SIO番号が変わったとき
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sioUpDown_ValueChanged (object sender, EventArgs e)
    {
      ssIcsNoUpDown.Value = idUpDown.Value * 2 + (sioUpDown.Value - 1);
    }

    /// <summary>
    /// コマンド生成ボタンが押されたときは、命令を作成して下のテキストボックスに表示します。
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void ssGenCmdButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();

      cmd.Bytes = Command.RunSingleServo (
        (byte)ssIcsNoUpDown.Value, (byte)ssFrameUpDown.Value, (int)ssPositionUpDown.Value);

      // 作成した命令をテキスト表示
      cmdTextBox.Text = cmd.CommaText;

      // 受信データ数を保存しておく（コマンドを実際に送信するときに必要）
      recv_count = 4;
    }

    /// <summary>
    /// Free/Holdをセットする
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void freeButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();
      Dictionary<int,int> poss = new Dictionary<int,int> ();

      // このコマンドはsingle servoコマンドを使わない
      // RunConstFrameServo (System.Collections.Generic.Dictionary<int, int> poss)を使う
      // possの1番目のアイテムには<-1,frame>を入れること
      poss.Add (-1, (byte)ssFrameUpDown.Value);

      int pos = 0;

      if (freeRadioButton.Checked)
      {
        pos = Rcb4.Rcb4.FreePosition;
      }
      else if (holdRadioButton.Checked)
      {
        pos = Rcb4.Rcb4.HoldPosition;
      }
      else 
      {
        return; // どちらにもチェックマークがなかった
      }

      // リストに追加
      poss.Add ((byte)ssIcsNoUpDown.Value, pos);

      // コマンドを生成
      cmd.Bytes = Command.RunConstFrameServo (poss);
      cmdTextBox.Text = cmd.CommaText;

    }
    #endregion

    #region 複数サーボモーターコマンドの処理
    
    /// <summary>
    /// サーボモーター選択欄がクリックされたとき
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void icsDeviceListView_SelectedIndexChanged (object sender, EventArgs e)
    {
      // 何も選択されていないときは終了
      if (icsDeviceListView.SelectedIndices.Count == 0)
      {
        return;
      }

      // 選択されているリスト番号を取得
      int sindex = icsDeviceListView.SelectedIndices[0]; // １つだけ選択されているはず
      // 選択されているリスト項目のポジションを取得
      msPosUpDown.Value = Convert.ToInt32 (icsDeviceListView.Items[sindex].SubItems[1].Text);
    }

    /// <summary>
    /// numericUpDownの値が変化したときには、データをリストへ書き戻す
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void msPosUpDown_ValueChanged (object sender, EventArgs e)
    {
      // 何も選択されていないときは終了
      if (icsDeviceListView.SelectedIndices.Count == 0)
      {
        return;
      }

      // 選択されているリスト番号を取得
      int sindex = icsDeviceListView.SelectedIndices[0]; // １つだけ選択されているはず

      icsDeviceListView.Items[sindex].SubItems[1].Text = msPosUpDown.Value.ToString ();
    }

    /// <summary>
    /// コマンドを生成する
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void msGenCmdButton_Click (object sender, EventArgs e)
    {
      // リスト一覧からコマンド生成に必要なデータを取り出す。
      System.Collections.Generic.Dictionary<int,int> icsList = new Dictionary<int,int>();

      // あらかじめフレーム数を登録する
      // フレーム数は-1で登録する
      icsList.Add (-1, (int)msFrameUpDown.Value);

      // リストビューからチェックの入ったIDのデータを取り出して、リスト化する
      foreach (ListViewItem item in icsDeviceListView.Items)
      {
        if (item.Checked)
        {
          try
          {
            // 項目の番号（ICS番号）とポジションデータをペアにして保存する
            // 並び方は昇順になるはず
            int icsNo = int.Parse (item.SubItems[0].Text);
            int pos = int.Parse (item.SubItems[1].Text);

            icsList.Add (icsNo, pos);
          }
          catch
          {
            // 特に何もしない
            continue;
          }
        }
      }

      ByteList cmd = new ByteList ();
      // 命令を生成する
      cmd.Bytes = Command.RunConstFrameServo (icsList);

      // 作成した命令をテキスト表示
      cmdTextBox.Text = cmd.CommaText;

      // 受信データ数を保存しておく（コマンドを実際に送信するときに必要）
      recv_count = 4;
    }

    /// <summary>
    /// サーボモーターのトリム・現在位置などを取得する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void readPosButton_Click (object sender, EventArgs e)
    {
      // チェックマークがついているものだけを集める
      List<byte> icsNo = new List<byte> ();

      for (int i = 0; i < servoListView.Items.Count; i++)
      {
        if (servoListView.Items[i].Checked)
        {
          icsNo.Add ((byte)i);
        }
      }

      if (icsNo.Count == 0) // どのサーボも選択されていなかった場合は処理をやめる
      {
        return;
      }

      // コマンドを生成する
      List<ByteList> cmds = new List<ByteList> ();

      // データを一個ずつ取り出してコマンドを追加していく
      foreach (byte b in icsNo) 
      {
        ByteList cmd = new ByteList (); // コマンド新規作成

        // サーボポジションなどをサーボ毎にまとめて取得する命令
        // Trim, Current Position, Desired Position 各２バイト
        cmd.Bytes = Command.MoveDeviceToCom (Rcb4.Rcb4.TrimAddressOffset, b, 6);
        cmds.Add (cmd); // 生成したコマンドを追加
      }

      // コマンドを送信してデータを表示する
      byte[] rx = new byte[9]; // SIZE CMD TRIM_L TRIM_H POS_L POS_H DES_L DES_H SUM

      foreach (ByteList cmd in cmds)
      {
        if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == false)
        {
          MessageBox.Show ("Read error.");
          break;
        }
        else
        {
          // リストに表示
          int ics = (int)cmd[7]; // 書き出す場所
          int trim = Extensions.Converter.ByteConverter.ByteArrayToInt16 (rx[2], rx[3]);
          int pos = Extensions.Converter.ByteConverter.ByteArrayToInt16 (rx[4], rx[5]);
          int des = Extensions.Converter.ByteConverter.ByteArrayToInt16 (rx[6], rx[7]);

          // データを表示する
          servoListView.Items[ics].SubItems[1].Text = trim.ToString ();
          servoListView.Items[ics].SubItems[2].Text = pos.ToString ();
          servoListView.Items[ics].SubItems[3].Text = des.ToString ();
        }
      }
    }

    /// <summary>
    /// サーボモーターポジションリストを消去
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clearListButton_Click (object sender, EventArgs e)
    {
      servoListView.BeginUpdate ();

      // リストのデータを一端消去する
      servoListView.Items.Clear ();

      // リスト初期化
      for (int i = 0; i < Rcb4.Rcb4.MaxDeviceNumner; i++)
      {
        ListViewItem item = new ListViewItem (new string[] { i.ToString ("00"), "-", "-", "-" });
        servoListView.Items.Add (item);
      }

      servoListView.EndUpdate ();
    }
    #endregion

    #region Moveコマンド

    #region メニューの有効・無効を切り替えて、コマンドの間違いを減らす

    /// <summary>
    /// データ転送元種別プルダウンメニュー項目が決定したときの処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void srcTypeSelectBox_SelectedIndexChanged (object sender, EventArgs e)
    {
      // 転送元データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        //
        // 選択した項目と、デバイスタイプが一致した
        if (devType.ToString () == srcTypeSelectBox.Text)
        {
          // 選択された項目に対応して、コントロールの有効と無効を切り替える
          switch (devType)
          {
            case Command.DeviceTypes.COM:
              
              srcAddrSelectBox.Enabled = false;
              srcAddrUpDown.Enabled = false;
              srcDevNoUpDown.Enabled = false;
              srcDevOffsetUpDown.Enabled = false;
              sendByteCountUpDown.Enabled = false;
              anyByteDataTextBox.Enabled = true;

              break;

            case Command.DeviceTypes.Device:

              srcAddrSelectBox.Enabled = false;
              srcAddrUpDown.Enabled = false;
              srcDevNoUpDown.Enabled = true;
              srcDevOffsetUpDown.Enabled = true;
              sendByteCountUpDown.Enabled = true;
              anyByteDataTextBox.Enabled = false;

              break;

            case Command.DeviceTypes.RAM:

              srcAddrSelectBox.Enabled = true;
              srcAddrUpDown.Enabled = true;
              srcDevNoUpDown.Enabled = false;
              srcDevOffsetUpDown.Enabled = false;
              sendByteCountUpDown.Enabled = true;
              anyByteDataTextBox.Enabled = false;

              break;

            case Command.DeviceTypes.ROM:

              srcAddrSelectBox.Enabled = true;
              srcAddrUpDown.Enabled = true;
              srcDevNoUpDown.Enabled = false;
              srcDevOffsetUpDown.Enabled = false;
              sendByteCountUpDown.Enabled = true;
              anyByteDataTextBox.Enabled = false;

              break;
          }

          return;
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void destTypeSelectBox_SelectedIndexChanged (object sender, EventArgs e)
    {
      // 転送先データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        //
        // 選択した項目と、デバイスタイプが一致した
        if (devType.ToString () == destTypeSelectBox.Text)
        {
          // 選択された項目に対応して、コントロールの有効と無効を切り替える
          switch (devType)
          {
            case Command.DeviceTypes.COM:

              destAddrSelectBox.Enabled = false;
              destAddrUpDown.Enabled = false;
              destDevNoUpDown.Enabled = false;
              destDevOffsetUpDown.Enabled = false;

              break;

            case Command.DeviceTypes.Device:

              destAddrSelectBox.Enabled = false;
              destAddrUpDown.Enabled = false;
              destDevNoUpDown.Enabled = true;
              destDevOffsetUpDown.Enabled = true;

              break;

            case Command.DeviceTypes.RAM:

              destAddrSelectBox.Enabled = true;
              destAddrUpDown.Enabled = true;
              destDevNoUpDown.Enabled = false;
              destDevOffsetUpDown.Enabled = false;

              break;

            case Command.DeviceTypes.ROM:

              destAddrSelectBox.Enabled = true;
              destAddrUpDown.Enabled = true;
              destDevNoUpDown.Enabled = false;
              destDevOffsetUpDown.Enabled = false;

              break;
          }
        }
      }
    }
    #endregion

    #region プルダウンメニューの操作

    /// <summary>
    /// 転送元データをプルダウンメニューから選ぶ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void srcAddrSelectBox_DropDownClosed (object sender, EventArgs e)
    {
      if (srcAddrSelectBox.SelectedIndex != -1)
      {
        srcAddrUpDown.Value = (int)srcCollection[srcAddrSelectBox.Text];
      }
    }

    /// <summary>
    /// 転送元データをプルダウンメニューから選ぶ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void destAddrSelectBox_DropDownClosed (object sender, EventArgs e)
    {
      if (destAddrSelectBox.SelectedIndex != -1)
      {
        destAddrUpDown.Value = (int)destCollection[destAddrSelectBox.Text];
      }
    }

    /// <summary>
    /// ソースアドレスが変更されたときの処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void srcAddrUpDown_ValueChanged (object sender, EventArgs e)
    {
      // 自分が操作中の時は、プルダウンメニューを未設定状態に戻す
      if (srcAddrUpDown.Focused)
      {
        srcAddrSelectBox.SelectedIndex = -1;
      }
    }

    /// <summary>
    /// destアドレスが変更されたときの処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void destAddrUpDown_ValueChanged (object sender, EventArgs e)
    {
      // 自分が操作中の時は、プルダウンメニューを未設定状態に戻す
      if (destAddrUpDown.Focused)
      {
        destAddrSelectBox.SelectedIndex = -1;
      }
    }
    #endregion

    /// <summary>
    /// 入力制限を付ける
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void anyByteDataTextBox_KeyPress (object sender, KeyPressEventArgs e)
    {
      string allowkeys = "0123456789abcdefABCDEF "; // 16進数のみ有効

      if (allowkeys.IndexOf (e.KeyChar) < 0 && e.KeyChar != '\b')
      {
        e.Handled = true;
      }
    }

    /// <summary>
    /// MOVEコマンド作成ボタンが押された
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void moveGenCmdButton_Click (object sender, EventArgs e)
    {
      // 転送元を検索する
      Command.DeviceTypes srcType = Command.DeviceTypes.Compare; // 未使用のタイプを使用

      // 転送元データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        if (devType.ToString () == srcTypeSelectBox.Text)
        {
          srcType = devType;
          break;
        }
      }

      // 何も適合しなかった
      if (srcType == Command.DeviceTypes.Compare)
      {
        return;
      }

      // 転送先を検索する
      Command.DeviceTypes destType = Command.DeviceTypes.Compare;  // 未使用のタイプを使用

      // 転送元データプルダウンメニューを作成
      foreach (Command.DeviceTypes devType in Enum.GetValues (typeof (Command.DeviceTypes)))
      {
        if (devType.ToString () == destTypeSelectBox.Text)
        {
          destType = devType;
          break;
        }
      }

      // 何も適合しなかった
      if (destType == Command.DeviceTypes.Compare)
      {
        return;
      }

      // コマンド生成用の変数
      ByteList cmd = new ByteList ();
      ByteList lit = new ByteList (); // リテラル値（COMポートから送るデータ）

      switch (srcType)
      {
        case Command.DeviceTypes.COM:
          // COMポートからデータを受け取るときは、anyByteDataTextBoxが正しくないとだめ
          lit.CommaText = anyByteDataTextBox.Text.Trim ();
          recv_count = 4; // 受信データ数を保存しておく

          switch (destType)
          {
            case Command.DeviceTypes.RAM:
            case Command.DeviceTypes.ROM:

              // COM to RAM/ROM
              cmd.Bytes = Command.Move (srcType, destType, 0, (int)destAddrUpDown.Value, 0, 0, 0, 0, 0, lit.Bytes);

              break;

            case Command.DeviceTypes.Device:

              // COM to Device
              //cmd.Bytes = Command.Move (srcType, destType, 0, 0, 0, 0,
              //  (byte)destDevOffsetUpDown.Value, (byte)destDevNoUpDown.Value, 0, lit.Bytes);
              cmd.Bytes = Command.MoveComToDevice ((byte)destDevOffsetUpDown.Value, (byte)destDevNoUpDown.Value,
                lit.Bytes);

              break;

            case Command.DeviceTypes.COM:

              // COM to COM
              //cmd.Bytes = Command.Move (srcType, destType, 0, 0, 0, 0, 0, 0, 0, lit.Bytes);
              MessageBox.Show ("現在使用できなくなっています。");
              break;
          }

          break;

        case Command.DeviceTypes.Device:

          recv_count = 4; // 受信データ数を保存しておく

          switch (destType)
          {
            case Command.DeviceTypes.RAM:
            case Command.DeviceTypes.ROM:

              // Device to RAM/ROM
              cmd.Bytes = Command.Move (srcType, destType, 0, (int)destAddrUpDown.Value, 
                (byte)srcDevOffsetUpDown.Value, (byte)srcDevNoUpDown.Value, 0, 0, (byte)sendByteCountUpDown.Value);
                
              break;

            case Command.DeviceTypes.Device:

              // Device to Device
              cmd.Bytes = Command.Move (srcType, destType, 0, 0,
                (byte)srcDevOffsetUpDown.Value, (byte)srcDevNoUpDown.Value,
                (byte)destDevOffsetUpDown.Value, (byte)destDevNoUpDown.Value, (byte)sendByteCountUpDown.Value);

              break;

            case Command.DeviceTypes.COM:

              // Device to COM
              cmd.Bytes = Command.Move (srcType, destType, 0, 0,
                (byte)srcDevOffsetUpDown.Value, (byte)srcDevNoUpDown.Value, 0, 0, (byte)sendByteCountUpDown.Value);

              recv_count = (int)sendByteCountUpDown.Value + 3;

              if (recv_count < 4) // このパターンは存在しない
              {
                MessageBox.Show ("送信データ数が不正です。");
                return;
              }

              break;
          }

          break;

        case Command.DeviceTypes.RAM:
        case Command.DeviceTypes.ROM:

          recv_count = 4;

          switch (destType)
          {
            case Command.DeviceTypes.COM:

              // RAM/ROM to COM
              cmd.Bytes = Command.Move (srcType, destType, (int)srcAddrUpDown.Value, 0,
                0, 0, 0, 0, (byte)sendByteCountUpDown.Value);
              recv_count = (int)sendByteCountUpDown.Value + 3;

              if (recv_count < 4) // このパターンは存在しない
              {
                MessageBox.Show ("送信データ数が不正です。");
                return;
              }

              break;

            case Command.DeviceTypes.Device:

              // RAM/ROM to Device
              cmd.Bytes = Command.Move (srcType, destType, (int)srcAddrUpDown.Value, 0,
                0, 0, (byte)destDevOffsetUpDown.Value, (byte)destDevNoUpDown.Value, (byte)sendByteCountUpDown.Value);
              
              break;

            case Command.DeviceTypes.RAM:
            case Command.DeviceTypes.ROM:

              // RAM/ROM to RAM/ROM
              cmd.Bytes = Command.Move (srcType, destType, (int)srcAddrUpDown.Value, (int)destAddrUpDown.Value,
                0, 0, 0, 0, (byte)sendByteCountUpDown.Value);
              
              break;

          }

          break;
      }

      // コマンドが何も生成されていない
      if (cmd.Count == 0)
      {
        return;
      }

      cmdTextBox.Text = cmd.CommaText;
      cmdTextBox.Invalidate ();

    }

    #endregion

    #region コマンド生成エリアでのイベント処理

    #region メインメニュー
    /// <summary>
    /// COMポートメニューがDropDownしたときは接続中のCOMポート一覧を表示する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comComboBox_DropDown (object sender, EventArgs e)
    {
      comComboBox.Items.Clear ();
      comComboBox.Items.Add ("Disconnect");
      comComboBox.Items.AddRange (System.IO.Ports.SerialPort.GetPortNames ());
    }

    /// <summary>
    /// COMポートが選択されたときの処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comComboBox_DropDownClosed (object sender, EventArgs e)
    {
      if (comComboBox.SelectedIndex <= 0) // index = 0も含む
      {
        serialPort.Close ();
      }
      else
      {
        serialPort.Close (); // ポートをいったん閉じる
        serialPort.PortName = comComboBox.SelectedItem.ToString ();
        serialPort.Open ();
      }
    }

    /// <summary>
    /// ボーレートが選択されたときの処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void baudrateComboBox_DropDownClosed (object sender, EventArgs e)
    {
      switch (baudrateComboBox.SelectedIndex)
      {
        case 0:
          serialPort.BaudRate = 115200;
          break;
        case 1:
          serialPort.BaudRate = 625000;
          break;
        case 2:
          serialPort.BaudRate = 1250000;
          break;
        default:
          break;
      }
    }
    #endregion

    /// <summary>
    /// Acknowledgeを送る
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void AckButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();
      cmd.Bytes = Command.AcknowledgeCheck ();

      // 作成した命令をテキスト表示
      cmdTextBox.Text = cmd.CommaText;

      // 受信データ数を保存しておく（コマンドを実際に送信するときに必要）
      recv_count = 4;
    }

    /// <summary>
    /// 生成したコマンドを送信する
    /// </summary>
    /// <param name="sender">呼び出し元コントロール</param>
    /// <param name="e">発生イベント</param>
    private void cmdSendButton_Click (object sender, EventArgs e)
    {
      if (!serialPort.IsOpen)
      {
        MessageBox.Show ("COMポートが接続されていません。");
        return;
      }

      if (cmdTextBox.Text == string.Empty)
      {
        MessageBox.Show ("コマンドが生成されていません。");
        return;
      }

      // 送信コマンド
      ByteList cmd = new ByteList ();
      cmd.CommaText = cmdTextBox.Text;
      // 返事を受け取る配列（コマンドを生成するときに）
      byte[] recv = new byte[recv_count];

      bool result = Command.Synchronize (serialPort, cmd.Bytes, ref recv);

      if (result == true)
      {
        resultTextBox.BackColor = SystemColors.Window;
      }
      else
      {
        resultTextBox.BackColor = Color.Red;
      }

      // 返事をいったんByteListで受け取る
      cmd.Bytes = recv;
      // 返事を書き出す
      resultTextBox.Text = cmd.CommaText;
    }
    #endregion

    #region モーション再生
    /// <summary>
    /// システムスイッチ(RCB-4のフレーム周期や)
    /// </summary>
    private Config config = new Config ();

    /// <summary>
    /// コンフィグデータを表示する
    /// </summary>
    private void SetConfigData ()
    {
      try
      {
        // チェックボックス全体のビットON/OFF状態を書き出す
        foreach (Control c in cfgGroupBox.Controls)
        {
          if (c is CheckBox)
          {
            CheckBox checkBox = c as CheckBox;

            byte bitNo = Convert.ToByte (checkBox.Text);

            if (bitNo > 7) // コンフィグスイッチの上位１バイトのデータを変更する
            {
              bitNo = (byte)((int)bitNo - 8);
              config[1] = (checkBox.Checked ?
                Command.SetBit (config[1], bitNo) : Command.ClearBit (config[1], bitNo));
            }
            else // コンフィグスイッチの下位１バイトのデータを変更する
            {
              config[0] = (checkBox.Checked ?
                Command.SetBit (config[0], bitNo) : Command.ClearBit (config[0], bitNo));
            }
          }
        }
      }
      catch
      {
        throw new ArgumentException ();
      }

      // コンフィグデータを表示する(コマンド生成時にこのテキストボックスよりデータを読み取る)
      cfgTextBox.Text = string.Format ("{0:X2} {1:X2}", config[1], config[0]);
    }

    /// <summary>
    /// チェックボックスのマークが変わったら、システム設定値も変更する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void checkBox_Click (object sender, EventArgs e)
    {
      // コンフィグデータを書き出す
      SetConfigData ();
    }

    /// <summary>
    /// システムコンフィグデータを書き込むコマンドを生成する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cfgGenCmdButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();

      // RAMへ書き出す
      cmd.Bytes = Command.MoveComToRam (Rcb4.Rcb4.ConfigRamAddress, config.ToArray ());

      // 作成した命令をテキスト表示
      cmdTextBox.Text = cmd.CommaText;

      // 受信データ数を保存しておく（コマンドを実際に送信するときに必要）
      recv_count = 4;
    }

    /// <summary>
    /// フレーム周期の変更
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frameSelectBox_DropDownClosed (object sender, EventArgs e)
    {
      switch (frameSelectBox.SelectedIndex)
      {
        case 0: // 10ms
          checkBox4.Checked = false;
          checkBox5.Checked = false;
          break;
        case 1: // 15ms
          checkBox4.Checked = true;
          checkBox5.Checked = false;
          break;
        case 2: // 20ms
          checkBox4.Checked = false;
          checkBox5.Checked = true;
          break;
        case 3: // 25ms
          checkBox4.Checked = true;
          checkBox5.Checked = true;
          break;
        default: // 15ms
          checkBox4.Checked = true;
          checkBox5.Checked = false;
          break;
      }

      // コンフィグデータを書き出す
      SetConfigData ();
    }

    /// <summary>
    /// COMポート通信速度の変更
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comBaudrateSelectBox_DropDownClosed (object sender, EventArgs e)
    {
      switch (comBaudrateSelectBox.SelectedIndex)
      {
        case 0:
          checkBox6.Checked = false;
          checkBox7.Checked = false;
          break;
        case 1:
          checkBox6.Checked = true;
          checkBox7.Checked = false;
          break;
        case 2:
          checkBox6.Checked = false;
          checkBox7.Checked = true;
          break;
        default:
          checkBox6.Checked = false;
          checkBox7.Checked = false;
          break;
      }

      // コンフィグデータを書き出す
      SetConfigData ();
    }

    /// <summary>
    /// ICS通信速度の変更
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void icsBaudrateSelectBox_DropDownClosed (object sender, EventArgs e)
    {
      switch (icsBaudrateSelectBox.SelectedIndex)
      {
        case 0:
          checkBox13.Checked = false;
          checkBox14.Checked = false;
          break;
        case 1:
          checkBox13.Checked = true;
          checkBox14.Checked = false;
          break;
        case 2:
          checkBox13.Checked = false;
          checkBox14.Checked = true;
          break;
        default:
          checkBox13.Checked = false;
          checkBox14.Checked = false;
          break;
      }

      // コンフィグデータを書き出す
      SetConfigData ();
    }

    /// <summary>
    /// RCB-4からデータを読み取る
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cfgReadCmdButton_Click (object sender, EventArgs e)
    {
      if (!serialPort.IsOpen)
      {
        MessageBox.Show ("COM port is not open.");
        return;
      }

      ByteList cmd = new ByteList ();
      cmd.Bytes = Command.MoveRamToCom (Rcb4.Rcb4.ConfigRamAddress, 2);

      // SIZE CMD DATA1 DATA2 SUM 
      byte[] rx = new byte[5];

      // コマンドをRCB-4に送信して
      if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == true)
      {
        config[0] = rx[2]; // 受信したデータをconfigクラスへ代入する
        config[1] = rx[3];

        // 下位８ビット
        checkBox0.Checked = (Command.GetBit (config[0], 0) == 1);
        checkBox1.Checked = (Command.GetBit (config[0], 1) == 1);
        checkBox2.Checked = (Command.GetBit (config[0], 2) == 1);
        checkBox3.Checked = (Command.GetBit (config[0], 3) == 1);
        checkBox4.Checked = (Command.GetBit (config[0], 4) == 1);
        checkBox5.Checked = (Command.GetBit (config[0], 5) == 1);
        checkBox6.Checked = (Command.GetBit (config[0], 6) == 1);
        checkBox7.Checked = (Command.GetBit (config[0], 7) == 1);
        // 上位８ビット
        checkBox8.Checked = (Command.GetBit (config[1], 0) == 1);
        checkBox9.Checked = (Command.GetBit (config[1], 1) == 1);
        checkBox10.Checked = (Command.GetBit (config[1], 2) == 1);
        checkBox11.Checked = (Command.GetBit (config[1], 3) == 1);
        checkBox12.Checked = (Command.GetBit (config[1], 4) == 1);
        checkBox13.Checked = (Command.GetBit (config[1], 5) == 1);
        checkBox14.Checked = (Command.GetBit (config[1], 6) == 1);
        checkBox15.Checked = (Command.GetBit (config[1], 7) == 1);
      }

      // 画面に反映する
      switch (config.Baudrate)
      {
        case Config.Baudrates.Br115200:
          comBaudrateSelectBox.SelectedIndex = 0;
          break;
        case Config.Baudrates.Br625000:
          comBaudrateSelectBox.SelectedIndex = 1;
          break;
        case Config.Baudrates.Br1250000:
          comBaudrateSelectBox.SelectedIndex = 2;
          break;
        default:
          comBaudrateSelectBox.SelectedIndex = -1;
          break;
      }

      switch (config.FrameTime)
      {
        case Config.OptFrameTime.Frame10ms:
          frameSelectBox.SelectedIndex = 0;
          break;
        case Config.OptFrameTime.Frame15ms:
          frameSelectBox.SelectedIndex = 1;
          break;
        case Config.OptFrameTime.Frame20ms:
          frameSelectBox.SelectedIndex = 2;
          break;
        case Config.OptFrameTime.Frame25ms:
          frameSelectBox.SelectedIndex = 3;
          break;
        default:
          frameSelectBox.SelectedIndex = -1;
          break;
      }

      switch (config.IcsBaudrate)
      {
        case Config.Baudrates.Br115200:
          icsBaudrateSelectBox.SelectedIndex = 0;
          break;
        case Config.Baudrates.Br625000:
          icsBaudrateSelectBox.SelectedIndex = 1;
          break;
        case Config.Baudrates.Br1250000:
          icsBaudrateSelectBox.SelectedIndex = 2;
          break;
        default:
          comBaudrateSelectBox.SelectedIndex = -1;
          break;
      }

      // コンフィグデータを書き出す
      SetConfigData ();
    }
    
    /// <summary>
    /// モーション番号からアドレスを生成する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mpUpDown_ValueChanged (object sender, EventArgs e)
    {
      int address = (int)mpUpDown.Value * Rcb4.Rcb4.MotionSingleDataCount + Rcb4.Rcb4.MotionRomAddress;
      addressLabel.Text = String.Format ("{0} (0x{1})", address, address.ToString ("X4"));
    }

    /// <summary>
    /// モーション再生コマンド（Call）を生成
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mpGenCmdButton_Click (object sender, EventArgs e)
    {
      int address = (int)mpUpDown.Value * Rcb4.Rcb4.MotionSingleDataCount + Rcb4.Rcb4.MotionRomAddress;
      ByteList cmd = new ByteList ();

      // RAMへ書き出す
      cmd.Bytes = Command.Call (address);

      // 作成した命令をテキスト表示
      cmdTextBox.Text = cmd.CommaText;

      // 受信データ数を保存しておく（コマンドを実際に送信するときに必要）
      recv_count = 4;
    }

    /// <summary>
    /// モーション再生の一連のコマンドを生成します
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void motionGenCmdButton_Click (object sender, EventArgs e)
    {
      // システム設定値を読み込んでいない
      if (config[0] == 0 && config[1] == 0)
      {
        if (MessageBox.Show ("先にシステムタブを使って、RCB-4の設定値を読み込んでください\n", "警告", MessageBoxButtons.OKCancel,
          MessageBoxIcon.Warning) == DialogResult.Cancel)
        {
          return;
        }
      }

      // データ作成用
      ByteList cmd = new ByteList ();

      // ロボットの動作を一時停止する
      cmd.Bytes = Rcb4.Rcb4.Suspend (config);
      sendSuspendCmdtextBox.Text = cmd.CommaText;

      // プログラムカウンターをセット（いったんMainLoopアドレスにプログラムカウンタをセット）
      cmd.Bytes = Rcb4.Rcb4.ResetProgramCounter (Rcb4.Rcb4.MainLoopCmd);
      sendResetCmdTextBox.Text = cmd.CommaText;

      // モーション再生開始アドレスをセットする
      int address = ((int)motionNumberUpDown.Value - 1) * Rcb4.Rcb4.MotionSingleDataCount + Rcb4.Rcb4.MotionRomAddress;
      cmd.Bytes = Rcb4.Rcb4.Play (address);
      sendCallCmdTextBox.Text = cmd.CommaText;

      // 動作再開
      cmd.Bytes = Rcb4.Rcb4.Resume (config);
      sendMotionPlayCmdTextBox.Text = cmd.CommaText;
    }

    /// <summary>
    /// コマンドを送信する
    /// </summary>
    /// <param name="cmdText">送信するバイトデータを表した文字列</param>
    private bool SendCommand (string cmdText)
    {
      if (!serialPort.IsOpen)
      {
        MessageBox.Show ("COM port is not open.");
        return false;
      }

      // 送信コマンドを生成
      ByteList cmd = new ByteList ();
      cmd.CommaText = cmdText;
      // 受信用データ（受信用だが、データ自身は特に使用しない）
      byte[] rx = new byte[recv_count];

      return Command.Synchronize (serialPort, cmd.Bytes, ref rx);
    }

    /// <summary>
    /// 一時停止コマンドを送信
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sendSuspendCmdButton_Click (object sender, EventArgs e)
    {
      recv_count = 4; // 受信データ数
      if (SendCommand (sendSuspendCmdtextBox.Text) == true)
      {
        // とくに何もしない
      }
      else
      {
        // コマンド送信に失敗
        MessageBox.Show ("Cannot send command ({0}).", sendSuspendCmdtextBox.Text);
        return;
      }
    }

    /// <summary>
    /// プログラムカウンターリセットコマンドを送信
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sendResetCmdButton_Click (object sender, EventArgs e)
    {
      recv_count = 4; // 受信データ数
      if (SendCommand (sendResetCmdTextBox.Text) == true)
      {
        // とくに何もしない
      }
      else
      {
        // コマンド送信に失敗
        MessageBox.Show ("Cannot send command ({0}).", sendResetCmdTextBox.Text);
        return;
      }
    }

    /// <summary>
    /// Call命令を送信
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sendCallCmdButton_Click (object sender, EventArgs e)
    {
      recv_count = 4; // 受信データ数
      if (SendCommand (sendCallCmdTextBox.Text) == true)
      {
        // とくに何もしない
      }
      else
      {
        // コマンド送信に失敗
        MessageBox.Show ("Cannot send command ({0}).", sendCallCmdTextBox.Text);
        return;
      }
    }

    /// <summary>
    /// モーション再生コマンドを送信
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void sendMotionPlayCmdutton_Click (object sender, EventArgs e)
    {
      recv_count = 4; // 受信データ数
      if (SendCommand (sendMotionPlayCmdTextBox.Text) == true)
      {
        // とくに何もしない
      }
      else
      {
        // コマンド送信に失敗
        MessageBox.Show ("Cannot send command ({0}).", sendMotionPlayCmdTextBox.Text);
        return;
      }
    }

    /// <summary>
    /// 全てのコマンドを順番に送信する
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void motionCmdSendButton_Click (object sender, EventArgs e)
    {
      // コマンドが正しく生成されていなかった場合は処理をやめる
      if (sendSuspendCmdtextBox.Text == string.Empty ||
        sendResetCmdTextBox.Text == string.Empty ||
        sendCallCmdTextBox.Text == string.Empty ||
        sendMotionPlayCmdTextBox.Text == string.Empty)
      {
        return;
      }

      // コマンドを文字列配列として保存
      string[] cmd = new string[] {sendSuspendCmdtextBox.Text, sendResetCmdTextBox.Text,
        sendCallCmdTextBox.Text, sendMotionPlayCmdTextBox.Text};

      recv_count = 4; // 受信データ数

      for (int i = 0; i < cmd.Length; i++)
      {
        // コマンドを順番に送信する
        if (SendCommand (cmd[i]) == true)
        {
          // とくに何もしない
        }
        else
        {
          // コマンド送信に失敗
          MessageBox.Show ("Cannot send command ({0}).", cmd[i]);
          return;
        }
      }
    }
    
    #endregion

    #region センサー読み取り
    /// <summary>
    /// AD値を読み取るコマンドを生成
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void adReadButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();
      int port = -1;

      // どのポートが選択されているか探す
      foreach (Control c in adGroupBox.Controls)
      {
        if (c is RadioButton)
        {
          RadioButton radioButton = c as RadioButton;
          if (radioButton.Checked) // 選択されていた
          {
            try
            {
              port = int.Parse (radioButton.Text);

              break; // 検索終了
            }
            catch
            {
              // 読み取り失敗
              continue;
            }
          }
        }
      }

      if (port != -1) // 何かしら選択されていた
      {
        cmd.Bytes = Rcb4.Rcb4.AdRead (port);
        cmdTextBox.Text = cmd.CommaText;
        // 受信データ数を設定
        recv_count = 5;
      }
    }

    /// <summary>
    /// AD基準値を読み取るコマンドを生成
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void adrReadButton_Click (object sender, EventArgs e)
    {
      ByteList cmd = new ByteList ();
      int port = -1;

      // どのポートが選択されているか探す
      foreach (Control c in adrGroupBox.Controls)
      {
        if (c is RadioButton)
        {
          RadioButton radioButton = c as RadioButton;
          if (radioButton.Checked) // 選択されていた
          {
            try
            {
              port = int.Parse (radioButton.Text);

              break; // 検索終了
            }
            catch
            {
              // 読み取り失敗
              continue;
            }
          }
        }
      }

      if (port != -1) // 何かしら選択されていた
      {
        cmd.Bytes = Rcb4.Rcb4.AdReferenceRead (port);
        cmdTextBox.Text = cmd.CommaText;
        // 受信データ数を設定
        recv_count = 5;
      }

    }

    /// <summary>
    /// PIOポート状態を読み取る
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pioInButton_Click (object sender, EventArgs e)
    {
      // 送信コマンドを生成
      ByteList cmd = new ByteList ();
      // 受信用データ（受信用だが、データ自身は特に使用しない）
      byte[] rx = new byte[4];

      // コマンドをセット
      cmd.Bytes = Rcb4.Rcb4.PioDirWrite (0x00, 0x00); // 全てのPIOポートを入力に設定

      if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == false)
      {
        MessageBox.Show ("Send error: PioDirWrite");
        return;
      }

      // PIOポート読み取りコマンドをセット
      cmd.Bytes = Rcb4.Rcb4.PioRead ();
      // 受信用データ
      rx = new byte[5]; // 2バイトを受信するので(SIZE CMD DAT1 DAT2 SUM)

      if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == false)
      {
        MessageBox.Show ("Send error: PioRead");
        return;
      }
      else
      {
        // 下位８ビット
        pio1CheckBox.Checked = (Command.GetBit (rx[2], 0) == 1);
        pio2CheckBox.Checked = (Command.GetBit (rx[2], 1) == 1);
        pio3CheckBox.Checked = (Command.GetBit (rx[2], 2) == 1);
        pio4CheckBox.Checked = (Command.GetBit (rx[2], 3) == 1);
        pio5CheckBox.Checked = (Command.GetBit (rx[2], 4) == 1);
        pio6CheckBox.Checked = (Command.GetBit (rx[2], 5) == 1);
        pio7CheckBox.Checked = (Command.GetBit (rx[2], 6) == 1);
        pio8CheckBox.Checked = (Command.GetBit (rx[2], 7) == 1);
        // 上位８ビット(２ビットのみ)
        pio9CheckBox.Checked = (Command.GetBit (rx[3], 0) == 1);
        pio10CheckBox.Checked = (Command.GetBit (rx[3], 1) == 1);
      }
    }

    /// <summary>
    /// PIOポートの状態をセットする
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pioOutButton_Click (object sender, EventArgs e)
    {
      // 送信コマンドを生成
      ByteList cmd = new ByteList ();
      // 受信用データ（受信用だが、データ自身は特に使用しない）
      byte[] rx = new byte[4];

      // コマンドをセット
      cmd.Bytes = Rcb4.Rcb4.PioDirWrite (0xFF, 0x03); // 全てのPIOポートを出力に設定

      if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == false)
      {
        MessageBox.Show ("Send error: PioDirWrite");
        return;
      }

      // 下位８ビット
      byte pio_l = 0;
      pio_l = (pio1CheckBox.Checked ? Command.SetBit (pio_l, 0) : Command.ClearBit (pio_l, 0));
      pio_l = (pio2CheckBox.Checked ? Command.SetBit (pio_l, 1) : Command.ClearBit (pio_l, 1));
      pio_l = (pio3CheckBox.Checked ? Command.SetBit (pio_l, 2) : Command.ClearBit (pio_l, 2));
      pio_l = (pio4CheckBox.Checked ? Command.SetBit (pio_l, 3) : Command.ClearBit (pio_l, 3));
      pio_l = (pio5CheckBox.Checked ? Command.SetBit (pio_l, 4) : Command.ClearBit (pio_l, 4));
      pio_l = (pio6CheckBox.Checked ? Command.SetBit (pio_l, 5) : Command.ClearBit (pio_l, 5));
      pio_l = (pio7CheckBox.Checked ? Command.SetBit (pio_l, 6) : Command.ClearBit (pio_l, 6));
      pio_l = (pio8CheckBox.Checked ? Command.SetBit (pio_l, 7) : Command.ClearBit (pio_l, 7));
      // 上位８ビット(２ビットのみ)
      byte pio_h = 0;
      pio_h = (pio9CheckBox.Checked ? Command.SetBit (pio_h, 0) : Command.ClearBit (pio_h, 0));
      pio_h = (pio10CheckBox.Checked ? Command.SetBit (pio_h, 1) : Command.ClearBit (pio_h, 1));

      // PIOポート読み取りコマンドをセット
      cmd.Bytes = Rcb4.Rcb4.PioWrite (pio_l, pio_h);

      if (Command.Synchronize (serialPort, cmd.Bytes, ref rx) == false)
      {
        MessageBox.Show ("Send error: PioRead");
        return;
      }
    }

    #endregion

    #region コントロールコード送信(MOVEコマンド)
    /// <summary>
    /// 画面のボタンに合わせて
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void krcButton_Click (object sender, EventArgs e)
    {
      ByteList keyData = new ByteList ();

      int KeyCode = 0;

      // シフトキー
      KeyCode |= (S1.Checked ? (int)Krc.ExtKeyCodes.Shift1 : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (S2.Checked ? (int)Krc.ExtKeyCodes.Shift2 : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (S3.Checked ? (int)Krc.ExtKeyCodes.Shift3 : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (S4.Checked ? (int)Krc.ExtKeyCodes.Shift4 : (int)Krc.ExtKeyCodes.Neutral);
      // 左キー
      KeyCode |= (LUL.Checked ? (int)Krc.ExtKeyCodes.UpperLeft : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LU.Checked ? (int)Krc.ExtKeyCodes.Up : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LUR.Checked ? (int)Krc.ExtKeyCodes.UpperRight : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LL.Checked ? (int)Krc.ExtKeyCodes.Left : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (N.Checked ? (int)Krc.ExtKeyCodes.Neutral : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LR.Checked ? (int)Krc.ExtKeyCodes.Right : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LDL.Checked ? (int)Krc.ExtKeyCodes.LowerLeft : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LD.Checked ? (int)Krc.ExtKeyCodes.Down : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (LDR.Checked ? (int)Krc.ExtKeyCodes.LowerRight : (int)Krc.ExtKeyCodes.Neutral);
      // 右キー
      KeyCode |= (RUL.Checked ? (int)Krc.ExtKeyCodes.C : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RU.Checked ? (int)Krc.ExtKeyCodes.Triangle : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RUR.Checked ? (int)Krc.ExtKeyCodes.A : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RL.Checked ? (int)Krc.ExtKeyCodes.Square : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RR.Checked ? (int)Krc.ExtKeyCodes.Circle : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RDL.Checked ? (int)Krc.ExtKeyCodes.D : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RD.Checked ? (int)Krc.ExtKeyCodes.Cross : (int)Krc.ExtKeyCodes.Neutral);
      KeyCode |= (RDR.Checked ? (int)Krc.ExtKeyCodes.B : (int)Krc.ExtKeyCodes.Neutral);

      // キーデータ作成
      keyData.Add ((byte)(KeyCode >> 8));
      keyData.Add ((byte)KeyCode);
      keyData.Add ((byte)pa1TrackBar.Value);
      keyData.Add ((byte)pa2TrackBar.Value);
      keyData.Add ((byte)pa3TrackBar.Value);
      keyData.Add ((byte)pa4TrackBar.Value);

      // Moveコマンドを作成
      ByteList cmd = new ByteList ();
      cmd.Bytes = Command.MoveComToRam (Rcb4.Rcb4.KRI3ButtonDataAddress, keyData.Bytes);
      cmdTextBox.Text = cmd.CommaText;
    }

    #endregion


  }
}