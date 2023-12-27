
namespace Maze_Solver
{
   
    partial class MazeInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeInterface));
            LoadMazeButton = new Button();
            SolveMazeButton = new Button();
            MazeLayout = new PictureBox();
            SizeLabel = new Label();
            SolutionProgressBar = new ProgressBar();
            SizeValue = new Label();
            SolutionLabel = new Label();
            SolutionValue = new Label();
            StartCord = new Label();
            StartLabel = new Label();
            FinishCord = new Label();
            FinishLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MazeLayout).BeginInit();
            SuspendLayout();
            // 
            // LoadMazeButton
            // 
            LoadMazeButton.Location = new Point(28, 40);
            LoadMazeButton.Name = "LoadMazeButton";
            LoadMazeButton.Size = new Size(192, 74);
            LoadMazeButton.TabIndex = 0;
            LoadMazeButton.Text = "Load Maze";
            LoadMazeButton.UseVisualStyleBackColor = true;
            LoadMazeButton.Click += LoadMazeButton_Click;
            // 
            // SolveMazeButton
            // 
            SolveMazeButton.Location = new Point(287, 40);
            SolveMazeButton.Name = "SolveMazeButton";
            SolveMazeButton.Size = new Size(197, 74);
            SolveMazeButton.TabIndex = 1;
            SolveMazeButton.Text = "Solve Maze";
            SolveMazeButton.UseVisualStyleBackColor = true;
            SolveMazeButton.Click += SolveMazeButton_Click;
            // 
            // MazeLayout
            // 
            MazeLayout.BorderStyle = BorderStyle.Fixed3D;
            MazeLayout.Location = new Point(552, 12);
            MazeLayout.Name = "MazeLayout";
            MazeLayout.Size = new Size(1100, 1100);
            MazeLayout.TabIndex = 3;
            MazeLayout.TabStop = false;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SizeLabel.ForeColor = SystemColors.ActiveCaptionText;
            SizeLabel.Location = new Point(21, 608);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(186, 48);
            SizeLabel.TabIndex = 4;
            SizeLabel.Text = "Maze Size:";
            // 
            // SolutionProgressBar
            // 
            SolutionProgressBar.Location = new Point(28, 1039);
            SolutionProgressBar.Name = "SolutionProgressBar";
            SolutionProgressBar.Size = new Size(500, 52);
            SolutionProgressBar.TabIndex = 5;
            // 
            // SizeValue
            // 
            SizeValue.AutoSize = true;
            SizeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SizeValue.ForeColor = SystemColors.ActiveCaptionText;
            SizeValue.Location = new Point(198, 608);
            SizeValue.Name = "SizeValue";
            SizeValue.Size = new Size(30, 48);
            SizeValue.TabIndex = 7;
            SizeValue.Text = " ";
            // 
            // SolutionLabel
            // 
            SolutionLabel.AutoSize = true;
            SolutionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SolutionLabel.ForeColor = SystemColors.ActiveCaptionText;
            SolutionLabel.Location = new Point(40, 973);
            SolutionLabel.Name = "SolutionLabel";
            SolutionLabel.Size = new Size(251, 48);
            SolutionLabel.TabIndex = 8;
            SolutionLabel.Text = "Cells Explored:";
            // 
            // SolutionValue
            // 
            SolutionValue.AutoSize = true;
            SolutionValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SolutionValue.ForeColor = SystemColors.ActiveCaptionText;
            SolutionValue.Location = new Point(287, 973);
            SolutionValue.Name = "SolutionValue";
            SolutionValue.Size = new Size(39, 48);
            SolutionValue.TabIndex = 9;
            SolutionValue.Text = "0";
            // 
            // StartCord
            // 
            StartCord.AutoSize = true;
            StartCord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartCord.ForeColor = SystemColors.ActiveCaptionText;
            StartCord.Location = new Point(313, 667);
            StartCord.Name = "StartCord";
            StartCord.Size = new Size(30, 48);
            StartCord.TabIndex = 11;
            StartCord.Text = " ";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartLabel.ForeColor = SystemColors.ActiveCaptionText;
            StartLabel.Location = new Point(21, 667);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(302, 48);
            StartLabel.TabIndex = 10;
            StartLabel.Text = "Start Coordinates:";
            // 
            // FinishCord
            // 
            FinishCord.AutoSize = true;
            FinishCord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FinishCord.ForeColor = SystemColors.ActiveCaptionText;
            FinishCord.Location = new Point(338, 724);
            FinishCord.Name = "FinishCord";
            FinishCord.Size = new Size(30, 48);
            FinishCord.TabIndex = 13;
            FinishCord.Text = " ";
            // 
            // FinishLabel
            // 
            FinishLabel.AutoSize = true;
            FinishLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FinishLabel.ForeColor = SystemColors.ActiveCaptionText;
            FinishLabel.Location = new Point(21, 724);
            FinishLabel.Name = "FinishLabel";
            FinishLabel.Size = new Size(320, 48);
            FinishLabel.TabIndex = 12;
            FinishLabel.Text = "Finish Coordinates:";
            // 
            // MazeInterface
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1664, 1116);
            Controls.Add(FinishCord);
            Controls.Add(FinishLabel);
            Controls.Add(StartCord);
            Controls.Add(StartLabel);
            Controls.Add(SolutionValue);
            Controls.Add(SolutionLabel);
            Controls.Add(SizeValue);
            Controls.Add(SolutionProgressBar);
            Controls.Add(SizeLabel);
            Controls.Add(MazeLayout);
            Controls.Add(SolveMazeButton);
            Controls.Add(LoadMazeButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MazeInterface";
            Text = "   Maze Solver";
            ((System.ComponentModel.ISupportInitialize)MazeLayout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button LoadMazeButton;
        private Button SolveMazeButton;
        private PictureBox MazeLayout;
        private Label SizeLabel;
        private ProgressBar SolutionProgressBar;
        private Label SizeValue;
        private Label SolutionLabel;
        private Label SolutionValue;
        private Label StartCord;
        private Label StartLabel;
        private Label FinishCord;
        private Label FinishLabel;
    }
}
