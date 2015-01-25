﻿namespace ElectronicObserver.Window.Dialog {
	partial class DialogConfigurationNotifier {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.GroupSound = new System.Windows.Forms.GroupBox();
			this.ButtonTest = new System.Windows.Forms.Button();
			this.SoundPathSearch = new System.Windows.Forms.Button();
			this.SoundPath = new System.Windows.Forms.TextBox();
			this.PlaysSound = new System.Windows.Forms.CheckBox();
			this.IsEnabled = new System.Windows.Forms.CheckBox();
			this.GroupImage = new System.Windows.Forms.GroupBox();
			this.DrawsImage = new System.Windows.Forms.CheckBox();
			this.ImagePathSearch = new System.Windows.Forms.Button();
			this.ImagePath = new System.Windows.Forms.TextBox();
			this.GroupDialog = new System.Windows.Forms.GroupBox();
			this.ShowsDialog = new System.Windows.Forms.CheckBox();
			this.Alignment = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LocationX = new System.Windows.Forms.NumericUpDown();
			this.LocationY = new System.Windows.Forms.NumericUpDown();
			this.TopMostFlag = new System.Windows.Forms.CheckBox();
			this.AccelInterval = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CloseOnMouseOver = new System.Windows.Forms.CheckBox();
			this.ForeColorSelect = new System.Windows.Forms.Button();
			this.ForeColorPreview = new System.Windows.Forms.Label();
			this.BackColorPreview = new System.Windows.Forms.Label();
			this.BackColorSelect = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ClosingInterval = new System.Windows.Forms.NumericUpDown();
			this.HasFormBorder = new System.Windows.Forms.CheckBox();
			this.GroupDamage = new System.Windows.Forms.GroupBox();
			this.NotifiesBefore = new System.Windows.Forms.CheckBox();
			this.NotifiesNow = new System.Windows.Forms.CheckBox();
			this.NotifiesAfter = new System.Windows.Forms.CheckBox();
			this.LevelBorder = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.ContainsNotLockedShip = new System.Windows.Forms.CheckBox();
			this.ContainsSafeShip = new System.Windows.Forms.CheckBox();
			this.ContainsFlagship = new System.Windows.Forms.CheckBox();
			this.DrawsMessage = new System.Windows.Forms.CheckBox();
			this.GroupSound.SuspendLayout();
			this.GroupImage.SuspendLayout();
			this.GroupDialog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LocationX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AccelInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClosingInterval)).BeginInit();
			this.GroupDamage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelBorder)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Location = new System.Drawing.Point(463, 377);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 4;
			this.ButtonCancel.Text = "キャンセル";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// ButtonOK
			// 
			this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ButtonOK.Location = new System.Drawing.Point(382, 377);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(75, 23);
			this.ButtonOK.TabIndex = 3;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			// 
			// GroupSound
			// 
			this.GroupSound.Controls.Add(this.PlaysSound);
			this.GroupSound.Controls.Add(this.SoundPathSearch);
			this.GroupSound.Controls.Add(this.SoundPath);
			this.GroupSound.Location = new System.Drawing.Point(12, 37);
			this.GroupSound.Name = "GroupSound";
			this.GroupSound.Size = new System.Drawing.Size(260, 78);
			this.GroupSound.TabIndex = 5;
			this.GroupSound.TabStop = false;
			this.GroupSound.Text = "通知音";
			// 
			// ButtonTest
			// 
			this.ButtonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonTest.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ButtonTest.Enabled = false;
			this.ButtonTest.Location = new System.Drawing.Point(12, 377);
			this.ButtonTest.Name = "ButtonTest";
			this.ButtonTest.Size = new System.Drawing.Size(75, 23);
			this.ButtonTest.TabIndex = 6;
			this.ButtonTest.Text = "テスト";
			this.ButtonTest.UseVisualStyleBackColor = true;
			// 
			// SoundPathSearch
			// 
			this.SoundPathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SoundPathSearch.Location = new System.Drawing.Point(222, 47);
			this.SoundPathSearch.Name = "SoundPathSearch";
			this.SoundPathSearch.Size = new System.Drawing.Size(32, 23);
			this.SoundPathSearch.TabIndex = 9;
			this.SoundPathSearch.Text = "...";
			this.SoundPathSearch.UseVisualStyleBackColor = true;
			// 
			// SoundPath
			// 
			this.SoundPath.AllowDrop = true;
			this.SoundPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SoundPath.Location = new System.Drawing.Point(6, 47);
			this.SoundPath.Name = "SoundPath";
			this.SoundPath.Size = new System.Drawing.Size(210, 23);
			this.SoundPath.TabIndex = 8;
			// 
			// PlaysSound
			// 
			this.PlaysSound.AutoSize = true;
			this.PlaysSound.Location = new System.Drawing.Point(6, 22);
			this.PlaysSound.Name = "PlaysSound";
			this.PlaysSound.Size = new System.Drawing.Size(78, 19);
			this.PlaysSound.TabIndex = 10;
			this.PlaysSound.Text = "有効にする";
			this.PlaysSound.UseVisualStyleBackColor = true;
			// 
			// IsEnabled
			// 
			this.IsEnabled.AutoSize = true;
			this.IsEnabled.Location = new System.Drawing.Point(12, 12);
			this.IsEnabled.Name = "IsEnabled";
			this.IsEnabled.Size = new System.Drawing.Size(111, 19);
			this.IsEnabled.TabIndex = 11;
			this.IsEnabled.Text = "通知を有効にする";
			this.IsEnabled.UseVisualStyleBackColor = true;
			// 
			// GroupImage
			// 
			this.GroupImage.Controls.Add(this.DrawsImage);
			this.GroupImage.Controls.Add(this.ImagePathSearch);
			this.GroupImage.Controls.Add(this.ImagePath);
			this.GroupImage.Location = new System.Drawing.Point(278, 37);
			this.GroupImage.Name = "GroupImage";
			this.GroupImage.Size = new System.Drawing.Size(260, 78);
			this.GroupImage.TabIndex = 11;
			this.GroupImage.TabStop = false;
			this.GroupImage.Text = "通知画像";
			// 
			// DrawsImage
			// 
			this.DrawsImage.AutoSize = true;
			this.DrawsImage.Location = new System.Drawing.Point(6, 22);
			this.DrawsImage.Name = "DrawsImage";
			this.DrawsImage.Size = new System.Drawing.Size(78, 19);
			this.DrawsImage.TabIndex = 10;
			this.DrawsImage.Text = "有効にする";
			this.DrawsImage.UseVisualStyleBackColor = true;
			// 
			// ImagePathSearch
			// 
			this.ImagePathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePathSearch.Location = new System.Drawing.Point(222, 47);
			this.ImagePathSearch.Name = "ImagePathSearch";
			this.ImagePathSearch.Size = new System.Drawing.Size(32, 23);
			this.ImagePathSearch.TabIndex = 9;
			this.ImagePathSearch.Text = "...";
			this.ImagePathSearch.UseVisualStyleBackColor = true;
			// 
			// ImagePath
			// 
			this.ImagePath.AllowDrop = true;
			this.ImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePath.Location = new System.Drawing.Point(6, 47);
			this.ImagePath.Name = "ImagePath";
			this.ImagePath.Size = new System.Drawing.Size(210, 23);
			this.ImagePath.TabIndex = 8;
			// 
			// GroupDialog
			// 
			this.GroupDialog.Controls.Add(this.DrawsMessage);
			this.GroupDialog.Controls.Add(this.HasFormBorder);
			this.GroupDialog.Controls.Add(this.label6);
			this.GroupDialog.Controls.Add(this.label7);
			this.GroupDialog.Controls.Add(this.ClosingInterval);
			this.GroupDialog.Controls.Add(this.BackColorPreview);
			this.GroupDialog.Controls.Add(this.BackColorSelect);
			this.GroupDialog.Controls.Add(this.ForeColorPreview);
			this.GroupDialog.Controls.Add(this.ForeColorSelect);
			this.GroupDialog.Controls.Add(this.CloseOnMouseOver);
			this.GroupDialog.Controls.Add(this.label3);
			this.GroupDialog.Controls.Add(this.label2);
			this.GroupDialog.Controls.Add(this.AccelInterval);
			this.GroupDialog.Controls.Add(this.TopMostFlag);
			this.GroupDialog.Controls.Add(this.LocationY);
			this.GroupDialog.Controls.Add(this.LocationX);
			this.GroupDialog.Controls.Add(this.label1);
			this.GroupDialog.Controls.Add(this.Alignment);
			this.GroupDialog.Controls.Add(this.ShowsDialog);
			this.GroupDialog.Location = new System.Drawing.Point(12, 121);
			this.GroupDialog.Name = "GroupDialog";
			this.GroupDialog.Size = new System.Drawing.Size(526, 141);
			this.GroupDialog.TabIndex = 11;
			this.GroupDialog.TabStop = false;
			this.GroupDialog.Text = "通知ダイアログ";
			// 
			// ShowsDialog
			// 
			this.ShowsDialog.AutoSize = true;
			this.ShowsDialog.Location = new System.Drawing.Point(6, 22);
			this.ShowsDialog.Name = "ShowsDialog";
			this.ShowsDialog.Size = new System.Drawing.Size(78, 19);
			this.ShowsDialog.TabIndex = 10;
			this.ShowsDialog.Text = "有効にする";
			this.ShowsDialog.UseVisualStyleBackColor = true;
			// 
			// Alignment
			// 
			this.Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Alignment.FormattingEnabled = true;
			this.Alignment.Items.AddRange(new object[] {
            "未指定",
            "左上",
            "上",
            "右上",
            "左",
            "中央",
            "右",
            "左下",
            "下",
            "右下",
            "手動設定"});
			this.Alignment.Location = new System.Drawing.Point(55, 47);
			this.Alignment.Name = "Alignment";
			this.Alignment.Size = new System.Drawing.Size(121, 23);
			this.Alignment.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "配置：";
			// 
			// LocationX
			// 
			this.LocationX.Location = new System.Drawing.Point(55, 76);
			this.LocationX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.LocationX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.LocationX.Name = "LocationX";
			this.LocationX.Size = new System.Drawing.Size(80, 23);
			this.LocationX.TabIndex = 13;
			this.LocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.LocationX.Value = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			// 
			// LocationY
			// 
			this.LocationY.Location = new System.Drawing.Point(141, 76);
			this.LocationY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.LocationY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.LocationY.Name = "LocationY";
			this.LocationY.Size = new System.Drawing.Size(80, 23);
			this.LocationY.TabIndex = 14;
			this.LocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.LocationY.Value = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			// 
			// TopMostFlag
			// 
			this.TopMostFlag.AutoSize = true;
			this.TopMostFlag.Location = new System.Drawing.Point(107, 22);
			this.TopMostFlag.Name = "TopMostFlag";
			this.TopMostFlag.Size = new System.Drawing.Size(114, 19);
			this.TopMostFlag.TabIndex = 15;
			this.TopMostFlag.Text = "最前面に表示する";
			this.TopMostFlag.UseVisualStyleBackColor = true;
			// 
			// AccelInterval
			// 
			this.AccelInterval.Location = new System.Drawing.Point(358, 18);
			this.AccelInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.AccelInterval.Name = "AccelInterval";
			this.AccelInterval.Size = new System.Drawing.Size(80, 23);
			this.AccelInterval.TabIndex = 16;
			this.AccelInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(269, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 15);
			this.label2.TabIndex = 17;
			this.label2.Text = "通知を早める：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(444, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 15);
			this.label3.TabIndex = 18;
			this.label3.Text = "秒";
			// 
			// CloseOnMouseOver
			// 
			this.CloseOnMouseOver.AutoSize = true;
			this.CloseOnMouseOver.Location = new System.Drawing.Point(272, 80);
			this.CloseOnMouseOver.Name = "CloseOnMouseOver";
			this.CloseOnMouseOver.Size = new System.Drawing.Size(132, 19);
			this.CloseOnMouseOver.TabIndex = 19;
			this.CloseOnMouseOver.Text = "マウスオーバーで閉じる";
			this.CloseOnMouseOver.UseVisualStyleBackColor = true;
			// 
			// ForeColorSelect
			// 
			this.ForeColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ForeColorSelect.Location = new System.Drawing.Point(342, 105);
			this.ForeColorSelect.Name = "ForeColorSelect";
			this.ForeColorSelect.Size = new System.Drawing.Size(32, 23);
			this.ForeColorSelect.TabIndex = 12;
			this.ForeColorSelect.Text = "...";
			this.ForeColorSelect.UseVisualStyleBackColor = true;
			// 
			// ForeColorPreview
			// 
			this.ForeColorPreview.AutoSize = true;
			this.ForeColorPreview.Location = new System.Drawing.Point(269, 109);
			this.ForeColorPreview.Name = "ForeColorPreview";
			this.ForeColorPreview.Size = new System.Drawing.Size(67, 15);
			this.ForeColorPreview.TabIndex = 20;
			this.ForeColorPreview.Text = "■前景色：";
			// 
			// BackColorPreview
			// 
			this.BackColorPreview.AutoSize = true;
			this.BackColorPreview.Location = new System.Drawing.Point(397, 109);
			this.BackColorPreview.Name = "BackColorPreview";
			this.BackColorPreview.Size = new System.Drawing.Size(67, 15);
			this.BackColorPreview.TabIndex = 23;
			this.BackColorPreview.Text = "■背景色：";
			// 
			// BackColorSelect
			// 
			this.BackColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BackColorSelect.Location = new System.Drawing.Point(470, 105);
			this.BackColorSelect.Name = "BackColorSelect";
			this.BackColorSelect.Size = new System.Drawing.Size(32, 23);
			this.BackColorSelect.TabIndex = 22;
			this.BackColorSelect.Text = "...";
			this.BackColorSelect.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(444, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 15);
			this.label6.TabIndex = 26;
			this.label6.Text = "秒";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(269, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 25;
			this.label7.Text = "自動で閉じる：";
			// 
			// ClosingInterval
			// 
			this.ClosingInterval.Location = new System.Drawing.Point(358, 47);
			this.ClosingInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.ClosingInterval.Name = "ClosingInterval";
			this.ClosingInterval.Size = new System.Drawing.Size(80, 23);
			this.ClosingInterval.TabIndex = 24;
			this.ClosingInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// HasFormBorder
			// 
			this.HasFormBorder.AutoSize = true;
			this.HasFormBorder.Location = new System.Drawing.Point(135, 108);
			this.HasFormBorder.Name = "HasFormBorder";
			this.HasFormBorder.Size = new System.Drawing.Size(102, 19);
			this.HasFormBorder.TabIndex = 27;
			this.HasFormBorder.Text = "窓枠を表示する";
			this.HasFormBorder.UseVisualStyleBackColor = true;
			// 
			// GroupDamage
			// 
			this.GroupDamage.Controls.Add(this.ContainsFlagship);
			this.GroupDamage.Controls.Add(this.ContainsSafeShip);
			this.GroupDamage.Controls.Add(this.ContainsNotLockedShip);
			this.GroupDamage.Controls.Add(this.label8);
			this.GroupDamage.Controls.Add(this.LevelBorder);
			this.GroupDamage.Controls.Add(this.NotifiesAfter);
			this.GroupDamage.Controls.Add(this.NotifiesNow);
			this.GroupDamage.Controls.Add(this.NotifiesBefore);
			this.GroupDamage.Location = new System.Drawing.Point(12, 268);
			this.GroupDamage.Name = "GroupDamage";
			this.GroupDamage.Size = new System.Drawing.Size(526, 103);
			this.GroupDamage.TabIndex = 12;
			this.GroupDamage.TabStop = false;
			this.GroupDamage.Text = "大破警告";
			// 
			// NotifiesBefore
			// 
			this.NotifiesBefore.AutoSize = true;
			this.NotifiesBefore.Location = new System.Drawing.Point(6, 22);
			this.NotifiesBefore.Name = "NotifiesBefore";
			this.NotifiesBefore.Size = new System.Drawing.Size(135, 19);
			this.NotifiesBefore.TabIndex = 0;
			this.NotifiesBefore.Text = "事前通知を有効にする";
			this.NotifiesBefore.UseVisualStyleBackColor = true;
			// 
			// NotifiesNow
			// 
			this.NotifiesNow.AutoSize = true;
			this.NotifiesNow.Location = new System.Drawing.Point(6, 47);
			this.NotifiesNow.Name = "NotifiesNow";
			this.NotifiesNow.Size = new System.Drawing.Size(135, 19);
			this.NotifiesNow.TabIndex = 1;
			this.NotifiesNow.Text = "事中通知を有効にする";
			this.NotifiesNow.UseVisualStyleBackColor = true;
			// 
			// NotifiesAfter
			// 
			this.NotifiesAfter.AutoSize = true;
			this.NotifiesAfter.Location = new System.Drawing.Point(6, 72);
			this.NotifiesAfter.Name = "NotifiesAfter";
			this.NotifiesAfter.Size = new System.Drawing.Size(135, 19);
			this.NotifiesAfter.TabIndex = 2;
			this.NotifiesAfter.Text = "事後通知を有効にする";
			this.NotifiesAfter.UseVisualStyleBackColor = true;
			// 
			// LevelBorder
			// 
			this.LevelBorder.Location = new System.Drawing.Point(356, 21);
			this.LevelBorder.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.LevelBorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LevelBorder.Name = "LevelBorder";
			this.LevelBorder.Size = new System.Drawing.Size(80, 23);
			this.LevelBorder.TabIndex = 28;
			this.LevelBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.LevelBorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(294, 23);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 15);
			this.label8.TabIndex = 28;
			this.label8.Text = "最低Lv：";
			// 
			// ContainsNotLockedShip
			// 
			this.ContainsNotLockedShip.AutoSize = true;
			this.ContainsNotLockedShip.Location = new System.Drawing.Point(146, 22);
			this.ContainsNotLockedShip.Name = "ContainsNotLockedShip";
			this.ContainsNotLockedShip.Size = new System.Drawing.Size(114, 19);
			this.ContainsNotLockedShip.TabIndex = 29;
			this.ContainsNotLockedShip.Text = "非ロック艦を含める";
			this.ContainsNotLockedShip.UseVisualStyleBackColor = true;
			// 
			// ContainsSafeShip
			// 
			this.ContainsSafeShip.AutoSize = true;
			this.ContainsSafeShip.Location = new System.Drawing.Point(146, 47);
			this.ContainsSafeShip.Name = "ContainsSafeShip";
			this.ContainsSafeShip.Size = new System.Drawing.Size(136, 19);
			this.ContainsSafeShip.TabIndex = 30;
			this.ContainsSafeShip.Text = "ダメコン装備艦を含める";
			this.ContainsSafeShip.UseVisualStyleBackColor = true;
			// 
			// ContainsFlagship
			// 
			this.ContainsFlagship.AutoSize = true;
			this.ContainsFlagship.Location = new System.Drawing.Point(146, 72);
			this.ContainsFlagship.Name = "ContainsFlagship";
			this.ContainsFlagship.Size = new System.Drawing.Size(90, 19);
			this.ContainsFlagship.TabIndex = 31;
			this.ContainsFlagship.Text = "旗艦を含める";
			this.ContainsFlagship.UseVisualStyleBackColor = true;
			// 
			// DrawsMessage
			// 
			this.DrawsMessage.AutoSize = true;
			this.DrawsMessage.Location = new System.Drawing.Point(6, 108);
			this.DrawsMessage.Name = "DrawsMessage";
			this.DrawsMessage.Size = new System.Drawing.Size(123, 19);
			this.DrawsMessage.TabIndex = 28;
			this.DrawsMessage.Text = "メッセージを表示する";
			this.DrawsMessage.UseVisualStyleBackColor = true;
			// 
			// DialogConfigurationNotifier
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(550, 412);
			this.Controls.Add(this.GroupDamage);
			this.Controls.Add(this.GroupDialog);
			this.Controls.Add(this.GroupImage);
			this.Controls.Add(this.IsEnabled);
			this.Controls.Add(this.ButtonTest);
			this.Controls.Add(this.GroupSound);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonOK);
			this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DialogConfigurationNotifier";
			this.ShowInTaskbar = false;
			this.Text = "通知の設定";
			this.Load += new System.EventHandler(this.DialogConfigurationNotifier_Load);
			this.GroupSound.ResumeLayout(false);
			this.GroupSound.PerformLayout();
			this.GroupImage.ResumeLayout(false);
			this.GroupImage.PerformLayout();
			this.GroupDialog.ResumeLayout(false);
			this.GroupDialog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LocationX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AccelInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClosingInterval)).EndInit();
			this.GroupDamage.ResumeLayout(false);
			this.GroupDamage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelBorder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.GroupBox GroupSound;
		private System.Windows.Forms.Button ButtonTest;
		private System.Windows.Forms.CheckBox PlaysSound;
		private System.Windows.Forms.Button SoundPathSearch;
		internal System.Windows.Forms.TextBox SoundPath;
		private System.Windows.Forms.CheckBox IsEnabled;
		private System.Windows.Forms.GroupBox GroupImage;
		private System.Windows.Forms.CheckBox DrawsImage;
		private System.Windows.Forms.Button ImagePathSearch;
		internal System.Windows.Forms.TextBox ImagePath;
		private System.Windows.Forms.GroupBox GroupDialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown AccelInterval;
		private System.Windows.Forms.CheckBox TopMostFlag;
		private System.Windows.Forms.NumericUpDown LocationY;
		private System.Windows.Forms.NumericUpDown LocationX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Alignment;
		private System.Windows.Forms.CheckBox ShowsDialog;
		private System.Windows.Forms.Label BackColorPreview;
		private System.Windows.Forms.Button BackColorSelect;
		private System.Windows.Forms.Label ForeColorPreview;
		private System.Windows.Forms.Button ForeColorSelect;
		private System.Windows.Forms.CheckBox CloseOnMouseOver;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown ClosingInterval;
		private System.Windows.Forms.CheckBox HasFormBorder;
		private System.Windows.Forms.GroupBox GroupDamage;
		private System.Windows.Forms.CheckBox NotifiesAfter;
		private System.Windows.Forms.CheckBox NotifiesNow;
		private System.Windows.Forms.CheckBox NotifiesBefore;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown LevelBorder;
		private System.Windows.Forms.CheckBox ContainsSafeShip;
		private System.Windows.Forms.CheckBox ContainsNotLockedShip;
		private System.Windows.Forms.CheckBox ContainsFlagship;
		private System.Windows.Forms.CheckBox DrawsMessage;
	}
}