namespace HaloCustomWidgets.Widget
{
    partial class HaloTitleBase
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this._titleLayout = new System.Windows.Forms.TableLayoutPanel();
            this._titleButtonPanel = new System.Windows.Forms.Panel();
            this._ExitButton = new System.Windows.Forms.Label();
            this._SizeableButton = new System.Windows.Forms.Label();
            this._MinimumButton = new System.Windows.Forms.Label();
            this._titleLabel = new System.Windows.Forms.Label();
            this._titleLayout.SuspendLayout();
            this._titleButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titleLayout
            // 
            this._titleLayout.BackColor = System.Drawing.Color.Transparent;
            this._titleLayout.ColumnCount = 3;
            this._titleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._titleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._titleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._titleLayout.Controls.Add(this._titleButtonPanel, 2, 0);
            this._titleLayout.Controls.Add(this._titleLabel, 1, 0);
            this._titleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleLayout.Location = new System.Drawing.Point(0, 0);
            this._titleLayout.Margin = new System.Windows.Forms.Padding(0);
            this._titleLayout.Name = "_titleLayout";
            this._titleLayout.RowCount = 1;
            this._titleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._titleLayout.Size = new System.Drawing.Size(668, 26);
            this._titleLayout.TabIndex = 0;
            // 
            // _titleButtonPanel
            // 
            this._titleButtonPanel.AutoSize = true;
            this._titleButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this._titleButtonPanel.Controls.Add(this._MinimumButton);
            this._titleButtonPanel.Controls.Add(this._SizeableButton);
            this._titleButtonPanel.Controls.Add(this._ExitButton);
            this._titleButtonPanel.Location = new System.Drawing.Point(578, 0);
            this._titleButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this._titleButtonPanel.Name = "_titleButtonPanel";
            this._titleButtonPanel.Size = new System.Drawing.Size(90, 24);
            this._titleButtonPanel.TabIndex = 0;
            // 
            // _ExitButton
            // 
            this._ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._ExitButton.BackColor = System.Drawing.Color.Transparent;
            this._ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ExitButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ExitButton.Location = new System.Drawing.Point(63, 0);
            this._ExitButton.Name = "_ExitButton";
            this._ExitButton.Size = new System.Drawing.Size(24, 24);
            this._ExitButton.TabIndex = 0;
            this._ExitButton.Text = "×";
            this._ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._ExitButton.Click += new System.EventHandler(this._ExitButton_Click);
            // 
            // _SizeableButton
            // 
            this._SizeableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._SizeableButton.BackColor = System.Drawing.Color.Transparent;
            this._SizeableButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SizeableButton.Location = new System.Drawing.Point(33, 0);
            this._SizeableButton.Name = "_SizeableButton";
            this._SizeableButton.Size = new System.Drawing.Size(24, 24);
            this._SizeableButton.TabIndex = 1;
            this._SizeableButton.Text = "□";
            this._SizeableButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _MinimumButton
            // 
            this._MinimumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MinimumButton.BackColor = System.Drawing.Color.Transparent;
            this._MinimumButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MinimumButton.Location = new System.Drawing.Point(3, 0);
            this._MinimumButton.Name = "_MinimumButton";
            this._MinimumButton.Size = new System.Drawing.Size(24, 24);
            this._MinimumButton.TabIndex = 2;
            this._MinimumButton.Text = "━";
            this._MinimumButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._titleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(64, 5);
            this._titleLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(514, 15);
            this._titleLabel.TabIndex = 1;
            this._titleLabel.Text = "Here is title zone";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HaloTitleBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._titleLayout);
            this.DoubleBuffered = true;
            this.Name = "HaloTitleBase";
            this.Size = new System.Drawing.Size(668, 26);
            this._titleLayout.ResumeLayout(false);
            this._titleLayout.PerformLayout();
            this._titleButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _titleLayout;
        private System.Windows.Forms.Panel _titleButtonPanel;
        private System.Windows.Forms.Label _MinimumButton;
        private System.Windows.Forms.Label _SizeableButton;
        private System.Windows.Forms.Label _ExitButton;
        private System.Windows.Forms.Label _titleLabel;
    }
}
