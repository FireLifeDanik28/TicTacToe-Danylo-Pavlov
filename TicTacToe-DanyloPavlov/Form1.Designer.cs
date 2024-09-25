using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicTacToe_Danylo_Pavlov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            TopLeft = new Button();
            TopCenter = new Button();
            TopRight = new Button();
            CenterLeft = new Button();
            CenterCenter = new Button();
            CenterRight = new Button();
            BottomLeft = new Button();
            BottomCenter = new Button();
            BottomRight = new Button();
            ActivePlayerLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(TopLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(TopCenter, 1, 1);
            tableLayoutPanel1.Controls.Add(TopRight, 2, 1);
            tableLayoutPanel1.Controls.Add(CenterLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(CenterCenter, 1, 2);
            tableLayoutPanel1.Controls.Add(CenterRight, 2, 2);
            tableLayoutPanel1.Controls.Add(BottomLeft, 0, 3);
            tableLayoutPanel1.Controls.Add(BottomCenter, 1, 3);
            tableLayoutPanel1.Controls.Add(BottomRight, 2, 3);
            tableLayoutPanel1.Controls.Add(ActivePlayerLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = SystemColors.Window;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(627, 695);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TopLeft
            // 
            TopLeft.Dock = DockStyle.Fill;
            TopLeft.ForeColor = SystemColors.InfoText;
            TopLeft.Location = new Point(3, 57);
            TopLeft.Margin = new Padding(3, 4, 3, 4);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(202, 206);
            TopLeft.TabIndex = 0;
            TopLeft.UseVisualStyleBackColor = true;
            TopLeft.Click += GameButtonClick;
            // 
            // TopCenter
            // 
            TopCenter.Dock = DockStyle.Fill;
            TopCenter.ForeColor = SystemColors.InfoText;
            TopCenter.Location = new Point(211, 57);
            TopCenter.Margin = new Padding(3, 4, 3, 4);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(203, 206);
            TopCenter.TabIndex = 1;
            TopCenter.UseVisualStyleBackColor = true;
            TopCenter.Click += GameButtonClick;
            // 
            // TopRight
            // 
            TopRight.Dock = DockStyle.Fill;
            TopRight.ForeColor = SystemColors.InfoText;
            TopRight.Location = new Point(420, 57);
            TopRight.Margin = new Padding(3, 4, 3, 4);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(204, 206);
            TopRight.TabIndex = 2;
            TopRight.UseVisualStyleBackColor = true;
            TopRight.Click += GameButtonClick;
            // 
            // CenterLeft
            // 
            CenterLeft.Dock = DockStyle.Fill;
            CenterLeft.ForeColor = SystemColors.InfoText;
            CenterLeft.Location = new Point(3, 271);
            CenterLeft.Margin = new Padding(3, 4, 3, 4);
            CenterLeft.Name = "CenterLeft";
            CenterLeft.Size = new Size(202, 206);
            CenterLeft.TabIndex = 3;
            CenterLeft.UseVisualStyleBackColor = true;
            CenterLeft.Click += GameButtonClick;
            // 
            // CenterCenter
            // 
            CenterCenter.Dock = DockStyle.Fill;
            CenterCenter.ForeColor = SystemColors.InfoText;
            CenterCenter.Location = new Point(211, 271);
            CenterCenter.Margin = new Padding(3, 4, 3, 4);
            CenterCenter.Name = "CenterCenter";
            CenterCenter.Size = new Size(203, 206);
            CenterCenter.TabIndex = 4;
            CenterCenter.UseVisualStyleBackColor = true;
            CenterCenter.Click += GameButtonClick;
            // 
            // CenterRight
            // 
            CenterRight.Dock = DockStyle.Fill;
            CenterRight.ForeColor = SystemColors.InfoText;
            CenterRight.Location = new Point(420, 271);
            CenterRight.Margin = new Padding(3, 4, 3, 4);
            CenterRight.Name = "CenterRight";
            CenterRight.Size = new Size(204, 206);
            CenterRight.TabIndex = 5;
            CenterRight.UseVisualStyleBackColor = true;
            CenterRight.Click += GameButtonClick;
            // 
            // BottomLeft
            // 
            BottomLeft.Dock = DockStyle.Fill;
            BottomLeft.ForeColor = SystemColors.InfoText;
            BottomLeft.Location = new Point(3, 485);
            BottomLeft.Margin = new Padding(3, 4, 3, 4);
            BottomLeft.Name = "BottomLeft";
            BottomLeft.Size = new Size(202, 206);
            BottomLeft.TabIndex = 6;
            BottomLeft.UseVisualStyleBackColor = true;
            BottomLeft.Click += GameButtonClick;
            // 
            // BottomCenter
            // 
            BottomCenter.Dock = DockStyle.Fill;
            BottomCenter.ForeColor = SystemColors.InfoText;
            BottomCenter.Location = new Point(211, 485);
            BottomCenter.Margin = new Padding(3, 4, 3, 4);
            BottomCenter.Name = "BottomCenter";
            BottomCenter.Size = new Size(203, 206);
            BottomCenter.TabIndex = 7;
            BottomCenter.UseVisualStyleBackColor = true;
            BottomCenter.Click += GameButtonClick;
            // 
            // BottomRight
            // 
            BottomRight.Dock = DockStyle.Fill;
            BottomRight.ForeColor = SystemColors.InfoText;
            BottomRight.Location = new Point(420, 485);
            BottomRight.Margin = new Padding(3, 4, 3, 4);
            BottomRight.Name = "BottomRight";
            BottomRight.Size = new Size(204, 206);
            BottomRight.TabIndex = 8;
            BottomRight.UseVisualStyleBackColor = true;
            BottomRight.Click += GameButtonClick;
            // 
            // ActivePlayerLabel
            // 
            ActivePlayerLabel.AutoSize = true;
            ActivePlayerLabel.BackColor = SystemColors.ActiveCaptionText;
            ActivePlayerLabel.Dock = DockStyle.Fill;
            ActivePlayerLabel.ForeColor = SystemColors.ControlLightLight;
            ActivePlayerLabel.Location = new Point(211, 0);
            ActivePlayerLabel.Name = "ActivePlayerLabel";
            ActivePlayerLabel.Size = new Size(203, 53);
            ActivePlayerLabel.TabIndex = 9;
            ActivePlayerLabel.Text = "Aktywny gracz:";
            ActivePlayerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 695);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Tic Tac Toe Danylo Pavlov";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button TopLeft;
        private Button TopCenter;
        private Button TopRight;
        private Button CenterLeft;
        private Button CenterCenter;
        private Button CenterRight;
        private Button BottomLeft;
        private Button BottomCenter;
        private Button BottomRight;
        private Label ActivePlayerLabel;
    }
}