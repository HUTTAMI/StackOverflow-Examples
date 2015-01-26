namespace SO.SentenceBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSentenceOutput = new System.Windows.Forms.GroupBox();
            this.lblSentenceOutput = new System.Windows.Forms.Label();
            this.btnClearSentence = new System.Windows.Forms.Button();
            this.grpSentenceComponents = new System.Windows.Forms.GroupBox();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnOver = new System.Windows.Forms.Button();
            this.btnJumped = new System.Windows.Forms.Button();
            this.btnFox = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnThe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmboCase = new System.Windows.Forms.ComboBox();
            this.grpSentenceOutput.SuspendLayout();
            this.grpSentenceComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSentenceOutput
            // 
            this.grpSentenceOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSentenceOutput.Controls.Add(this.lblSentenceOutput);
            this.grpSentenceOutput.Controls.Add(this.btnClearSentence);
            this.grpSentenceOutput.Location = new System.Drawing.Point(12, 12);
            this.grpSentenceOutput.Name = "grpSentenceOutput";
            this.grpSentenceOutput.Size = new System.Drawing.Size(598, 100);
            this.grpSentenceOutput.TabIndex = 0;
            this.grpSentenceOutput.TabStop = false;
            this.grpSentenceOutput.Text = "Final Sentence";
            // 
            // lblSentenceOutput
            // 
            this.lblSentenceOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSentenceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentenceOutput.Location = new System.Drawing.Point(6, 18);
            this.lblSentenceOutput.Name = "lblSentenceOutput";
            this.lblSentenceOutput.Size = new System.Drawing.Size(586, 50);
            this.lblSentenceOutput.TabIndex = 0;
            this.lblSentenceOutput.Text = "The quick brown fox jumped over the lazy dog.";
            // 
            // btnClearSentence
            // 
            this.btnClearSentence.Location = new System.Drawing.Point(442, 71);
            this.btnClearSentence.Name = "btnClearSentence";
            this.btnClearSentence.Size = new System.Drawing.Size(150, 23);
            this.btnClearSentence.TabIndex = 0;
            this.btnClearSentence.Text = "Clear Sentence";
            this.btnClearSentence.UseVisualStyleBackColor = true;
            this.btnClearSentence.Click += new System.EventHandler(this.ClearSentence_Click);
            // 
            // grpSentenceComponents
            // 
            this.grpSentenceComponents.Controls.Add(this.cmboCase);
            this.grpSentenceComponents.Controls.Add(this.btnSpace);
            this.grpSentenceComponents.Controls.Add(this.btnDog);
            this.grpSentenceComponents.Controls.Add(this.btnLazy);
            this.grpSentenceComponents.Controls.Add(this.btnOver);
            this.grpSentenceComponents.Controls.Add(this.btnJumped);
            this.grpSentenceComponents.Controls.Add(this.btnFox);
            this.grpSentenceComponents.Controls.Add(this.btnBrown);
            this.grpSentenceComponents.Controls.Add(this.btnQuick);
            this.grpSentenceComponents.Controls.Add(this.btnThe);
            this.grpSentenceComponents.Location = new System.Drawing.Point(12, 118);
            this.grpSentenceComponents.Name = "grpSentenceComponents";
            this.grpSentenceComponents.Size = new System.Drawing.Size(598, 220);
            this.grpSentenceComponents.TabIndex = 1;
            this.grpSentenceComponents.TabStop = false;
            this.grpSentenceComponents.Text = "Sentence Components";
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(163, 162);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(281, 46);
            this.btnSpace.TabIndex = 9;
            this.btnSpace.Tag = " ";
            this.btnSpace.Text = "(space)";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(467, 90);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(125, 46);
            this.btnDog.TabIndex = 8;
            this.btnDog.Tag = "dog";
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(319, 90);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(125, 46);
            this.btnLazy.TabIndex = 7;
            this.btnLazy.Tag = "lazy";
            this.btnLazy.Text = "Lazy";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnOver
            // 
            this.btnOver.Location = new System.Drawing.Point(163, 90);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(125, 46);
            this.btnOver.TabIndex = 6;
            this.btnOver.Tag = "over";
            this.btnOver.Text = "Over";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnJumped
            // 
            this.btnJumped.Location = new System.Drawing.Point(11, 90);
            this.btnJumped.Name = "btnJumped";
            this.btnJumped.Size = new System.Drawing.Size(125, 46);
            this.btnJumped.TabIndex = 5;
            this.btnJumped.Tag = "jumped";
            this.btnJumped.Text = "Jumped";
            this.btnJumped.UseVisualStyleBackColor = true;
            this.btnJumped.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnFox
            // 
            this.btnFox.Location = new System.Drawing.Point(467, 21);
            this.btnFox.Name = "btnFox";
            this.btnFox.Size = new System.Drawing.Size(125, 46);
            this.btnFox.TabIndex = 4;
            this.btnFox.Tag = "fox";
            this.btnFox.Text = "Fox";
            this.btnFox.UseVisualStyleBackColor = true;
            this.btnFox.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.Location = new System.Drawing.Point(319, 21);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(125, 46);
            this.btnBrown.TabIndex = 3;
            this.btnBrown.Tag = "brown";
            this.btnBrown.Text = "Brown";
            this.btnBrown.UseVisualStyleBackColor = true;
            this.btnBrown.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(163, 21);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(125, 46);
            this.btnQuick.TabIndex = 2;
            this.btnQuick.Tag = "quick";
            this.btnQuick.Text = "Quick";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnThe
            // 
            this.btnThe.Location = new System.Drawing.Point(11, 21);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(125, 46);
            this.btnThe.TabIndex = 1;
            this.btnThe.Tag = "the";
            this.btnThe.Text = "The";
            this.btnThe.UseVisualStyleBackColor = true;
            this.btnThe.Click += new System.EventHandler(this.Fragment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(535, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // cmboCase
            // 
            this.cmboCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmboCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCase.FormattingEnabled = true;
            this.cmboCase.Items.AddRange(new object[] {
            "Title Case",
            "lowercase",
            "UPPERCASE"});
            this.cmboCase.Location = new System.Drawing.Point(11, 174);
            this.cmboCase.Name = "cmboCase";
            this.cmboCase.Size = new System.Drawing.Size(125, 24);
            this.cmboCase.TabIndex = 10;
            this.cmboCase.SelectedIndexChanged += new System.EventHandler(this.Case_Change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 383);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpSentenceComponents);
            this.Controls.Add(this.grpSentenceOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SO.SentenceBuilder";
            this.grpSentenceOutput.ResumeLayout(false);
            this.grpSentenceComponents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSentenceOutput;
        private System.Windows.Forms.Label lblSentenceOutput;
        private System.Windows.Forms.GroupBox grpSentenceComponents;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.Button btnJumped;
        private System.Windows.Forms.Button btnFox;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnThe;
        private System.Windows.Forms.Button btnClearSentence;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.ComboBox cmboCase;
    }
}

