namespace HaloWidget
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.haloButtonBase1 = new HaloWidget.Widget.HaloButtonBase();
            this.haloComboBoxBase1 = new HaloWidget.Widget.HaloComboBoxBase();
            this.haloListBoxBase1 = new HaloWidget.Widget.HaloListBoxBase();
            this.haloTabControlBase1 = new HaloWidget.Widget.HaloTabControlBase();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.haloCheckBoxBase2 = new HaloWidget.Widget.HaloCheckBoxBase();
            this.haloCheckBoxBase1 = new HaloWidget.Widget.HaloCheckBoxBase();
            this.haloRadioButtonBase1 = new HaloWidget.Widget.HaloRadioButtonBase();
            this.haloRadioButtonBase2 = new HaloWidget.Widget.HaloRadioButtonBase();
            this.label1 = new System.Windows.Forms.Label();
            this.haloTrackBarBase1 = new HaloWidgets.Widget.HaloTrackBarBase();
            this.haloTitleBase1 = new HaloCustomWidgets.Widget.HaloTitleBase();
            this.haloTabControlBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haloTrackBarBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // haloButtonBase1
            // 
            this.haloButtonBase1.AlphaPercent = ((byte)(100));
            this.haloButtonBase1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.haloButtonBase1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.haloButtonBase1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.haloButtonBase1.BorderRadius = 7;
            this.haloButtonBase1.BorderSize = 0;
            this.haloButtonBase1.FlatAppearance.BorderSize = 0;
            this.haloButtonBase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.haloButtonBase1.ForeColor = System.Drawing.Color.White;
            this.haloButtonBase1.Location = new System.Drawing.Point(80, 162);
            this.haloButtonBase1.Name = "haloButtonBase1";
            this.haloButtonBase1.Size = new System.Drawing.Size(131, 36);
            this.haloButtonBase1.TabIndex = 0;
            this.haloButtonBase1.Text = "haloButtonBase1";
            this.haloButtonBase1.TextColor = System.Drawing.Color.White;
            this.haloButtonBase1.UseVisualStyleBackColor = false;
            this.haloButtonBase1.Click += new System.EventHandler(this.haloButton1_Click);
            // 
            // haloComboBoxBase1
            // 
            this.haloComboBoxBase1.ArrowIconColor = System.Drawing.Color.White;
            this.haloComboBoxBase1.ArrowIconSize = 12;
            this.haloComboBoxBase1.BackColor = System.Drawing.Color.DimGray;
            this.haloComboBoxBase1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.haloComboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.haloComboBoxBase1.ForeColor = System.Drawing.Color.White;
            this.haloComboBoxBase1.FormattingEnabled = true;
            this.haloComboBoxBase1.InSideBackGroundColor = System.Drawing.Color.DimGray;
            this.haloComboBoxBase1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.haloComboBoxBase1.ItemTextColor = System.Drawing.Color.White;
            this.haloComboBoxBase1.Location = new System.Drawing.Point(80, 107);
            this.haloComboBoxBase1.Name = "haloComboBoxBase1";
            this.haloComboBoxBase1.OutSideBackGroundColor = System.Drawing.Color.Black;
            this.haloComboBoxBase1.Size = new System.Drawing.Size(121, 22);
            this.haloComboBoxBase1.TabIndex = 1;
            this.haloComboBoxBase1.TextColor = System.Drawing.Color.White;
            // 
            // haloListBoxBase1
            // 
            this.haloListBoxBase1.BackColor = System.Drawing.Color.Black;
            this.haloListBoxBase1.BackGroundColor = System.Drawing.Color.Black;
            this.haloListBoxBase1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haloListBoxBase1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.haloListBoxBase1.FontColor = System.Drawing.Color.White;
            this.haloListBoxBase1.FormattingEnabled = true;
            this.haloListBoxBase1.ItemHeight = 36;
            this.haloListBoxBase1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.haloListBoxBase1.Location = new System.Drawing.Point(250, 107);
            this.haloListBoxBase1.Name = "haloListBoxBase1";
            this.haloListBoxBase1.SelectedBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.haloListBoxBase1.SelectedFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.haloListBoxBase1.Size = new System.Drawing.Size(161, 240);
            this.haloListBoxBase1.TabIndex = 2;
            // 
            // haloTabControlBase1
            // 
            this.haloTabControlBase1.Controls.Add(this.tabPage1);
            this.haloTabControlBase1.Controls.Add(this.tabPage2);
            this.haloTabControlBase1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.haloTabControlBase1.FontColor = System.Drawing.Color.DarkGray;
            this.haloTabControlBase1.ItemColor = System.Drawing.Color.WhiteSmoke;
            this.haloTabControlBase1.ItemSize = new System.Drawing.Size(50, 17);
            this.haloTabControlBase1.Location = new System.Drawing.Point(437, 216);
            this.haloTabControlBase1.Name = "haloTabControlBase1";
            this.haloTabControlBase1.SelectedFontColor = System.Drawing.Color.Black;
            this.haloTabControlBase1.SelectedIndex = 0;
            this.haloTabControlBase1.SelectedItemColor = System.Drawing.Color.Gray;
            this.haloTabControlBase1.Size = new System.Drawing.Size(594, 295);
            this.haloTabControlBase1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.haloTabControlBase1.TabHeight = 17;
            this.haloTabControlBase1.TabIndex = 6;
            this.haloTabControlBase1.TabWidth = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // haloCheckBoxBase2
            // 
            this.haloCheckBoxBase2.BackGroundColor = System.Drawing.Color.AliceBlue;
            this.haloCheckBoxBase2.CheckedIconColor = System.Drawing.Color.Black;
            this.haloCheckBoxBase2.FontColor = System.Drawing.Color.Black;
            this.haloCheckBoxBase2.IconColor = System.Drawing.Color.LightGray;
            this.haloCheckBoxBase2.Location = new System.Drawing.Point(437, 161);
            this.haloCheckBoxBase2.Name = "haloCheckBoxBase2";
            this.haloCheckBoxBase2.SelectedFontColor = System.Drawing.Color.Black;
            this.haloCheckBoxBase2.Size = new System.Drawing.Size(205, 34);
            this.haloCheckBoxBase2.TabIndex = 8;
            this.haloCheckBoxBase2.Text = "haloCheckBoxBase2";
            this.haloCheckBoxBase2.UseVisualStyleBackColor = true;
            // 
            // haloCheckBoxBase1
            // 
            this.haloCheckBoxBase1.BackGroundColor = System.Drawing.Color.Olive;
            this.haloCheckBoxBase1.CheckedIconColor = System.Drawing.Color.MidnightBlue;
            this.haloCheckBoxBase1.FontColor = System.Drawing.Color.DarkOrange;
            this.haloCheckBoxBase1.IconColor = System.Drawing.Color.OrangeRed;
            this.haloCheckBoxBase1.Location = new System.Drawing.Point(441, 107);
            this.haloCheckBoxBase1.Name = "haloCheckBoxBase1";
            this.haloCheckBoxBase1.SelectedFontColor = System.Drawing.Color.Red;
            this.haloCheckBoxBase1.Size = new System.Drawing.Size(105, 34);
            this.haloCheckBoxBase1.TabIndex = 9;
            this.haloCheckBoxBase1.Text = "haloCheckBoxBase1";
            this.haloCheckBoxBase1.UseVisualStyleBackColor = true;
            // 
            // haloRadioButtonBase1
            // 
            this.haloRadioButtonBase1.BackGroundColor = System.Drawing.Color.AliceBlue;
            this.haloRadioButtonBase1.CheckedIconColor = System.Drawing.Color.Blue;
            this.haloRadioButtonBase1.FontColor = System.Drawing.Color.Black;
            this.haloRadioButtonBase1.IconColor = System.Drawing.Color.Red;
            this.haloRadioButtonBase1.Location = new System.Drawing.Point(667, 107);
            this.haloRadioButtonBase1.Name = "haloRadioButtonBase1";
            this.haloRadioButtonBase1.SelectedFontColor = System.Drawing.Color.Black;
            this.haloRadioButtonBase1.Size = new System.Drawing.Size(100, 34);
            this.haloRadioButtonBase1.TabIndex = 10;
            this.haloRadioButtonBase1.TabStop = true;
            this.haloRadioButtonBase1.Text = "haloRadioButtonBase1";
            this.haloRadioButtonBase1.UseVisualStyleBackColor = true;
            // 
            // haloRadioButtonBase2
            // 
            this.haloRadioButtonBase2.BackGroundColor = System.Drawing.Color.AliceBlue;
            this.haloRadioButtonBase2.CheckedIconColor = System.Drawing.Color.Blue;
            this.haloRadioButtonBase2.FontColor = System.Drawing.Color.Black;
            this.haloRadioButtonBase2.IconColor = System.Drawing.Color.Red;
            this.haloRadioButtonBase2.Location = new System.Drawing.Point(667, 160);
            this.haloRadioButtonBase2.Name = "haloRadioButtonBase2";
            this.haloRadioButtonBase2.SelectedFontColor = System.Drawing.Color.Black;
            this.haloRadioButtonBase2.Size = new System.Drawing.Size(195, 34);
            this.haloRadioButtonBase2.TabIndex = 11;
            this.haloRadioButtonBase2.TabStop = true;
            this.haloRadioButtonBase2.Text = "haloRadioButtonBase2";
            this.haloRadioButtonBase2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 89);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // haloTrackBarBase1
            // 
            this.haloTrackBarBase1.AutoSize = false;
            this.haloTrackBarBase1.BackColor = System.Drawing.Color.LightGray;
            this.haloTrackBarBase1.BarColor = System.Drawing.Color.Black;
            this.haloTrackBarBase1.BarSize = 16;
            this.haloTrackBarBase1.LineColor = System.Drawing.Color.DarkGray;
            this.haloTrackBarBase1.Location = new System.Drawing.Point(66, 373);
            this.haloTrackBarBase1.Maximum = 100;
            this.haloTrackBarBase1.Name = "haloTrackBarBase1";
            this.haloTrackBarBase1.Size = new System.Drawing.Size(263, 37);
            this.haloTrackBarBase1.TabIndex = 13;
            this.haloTrackBarBase1.Value = 45;
            // 
            // haloTitleBase1
            // 
            this.haloTitleBase1.BackColor = System.Drawing.Color.LightBlue;
            this.haloTitleBase1.Dock = System.Windows.Forms.DockStyle.Top;
            this.haloTitleBase1.FontColor = System.Drawing.Color.Blue;
            this.haloTitleBase1.Location = new System.Drawing.Point(0, 0);
            this.haloTitleBase1.MouseDownEvent = null;
            this.haloTitleBase1.MouseMoveEvent = null;
            this.haloTitleBase1.MouseUpEvent = null;
            this.haloTitleBase1.Name = "haloTitleBase1";
            this.haloTitleBase1.Size = new System.Drawing.Size(1264, 26);
            this.haloTitleBase1.TabIndex = 14;
            this.haloTitleBase1.TitleFont = new System.Drawing.Font("Calibri", 10F);
            this.haloTitleBase1.TitleText = "Here is title area";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.haloTitleBase1);
            this.Controls.Add(this.haloTrackBarBase1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haloRadioButtonBase2);
            this.Controls.Add(this.haloRadioButtonBase1);
            this.Controls.Add(this.haloCheckBoxBase1);
            this.Controls.Add(this.haloCheckBoxBase2);
            this.Controls.Add(this.haloTabControlBase1);
            this.Controls.Add(this.haloListBoxBase1);
            this.Controls.Add(this.haloComboBoxBase1);
            this.Controls.Add(this.haloButtonBase1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.haloTabControlBase1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.haloTrackBarBase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Widget.HaloButtonBase haloButtonBase1;
        private Widget.HaloComboBoxBase haloComboBoxBase1;
        private Widget.HaloListBoxBase haloListBoxBase1;
        private Widget.HaloTabControlBase haloTabControlBase1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Widget.HaloCheckBoxBase haloCheckBoxBase2;
        private Widget.HaloCheckBoxBase haloCheckBoxBase1;
        private Widget.HaloRadioButtonBase haloRadioButtonBase1;
        private Widget.HaloRadioButtonBase haloRadioButtonBase2;
        private System.Windows.Forms.Label label1;
        private HaloWidgets.Widget.HaloTrackBarBase haloTrackBarBase1;
        private HaloCustomWidgets.Widget.HaloTitleBase haloTitleBase1;
    }
}

