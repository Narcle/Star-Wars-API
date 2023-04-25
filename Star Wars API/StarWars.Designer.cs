namespace Star_Wars_API
{
    partial class StarWars
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
            this.GetPlanet = new System.Windows.Forms.Button();
            this.PlanetIDBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetPeople = new System.Windows.Forms.Button();
            this.PeopleIDBox = new System.Windows.Forms.TextBox();
            this.speciesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetPlanet
            // 
            this.GetPlanet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetPlanet.Location = new System.Drawing.Point(12, 33);
            this.GetPlanet.Name = "GetPlanet";
            this.GetPlanet.Size = new System.Drawing.Size(132, 46);
            this.GetPlanet.TabIndex = 0;
            this.GetPlanet.Text = "Get Planet";
            this.GetPlanet.UseVisualStyleBackColor = true;
            this.GetPlanet.Click += new System.EventHandler(this.GetPlanet_Click);
            // 
            // PlanetIDBox
            // 
            this.PlanetIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlanetIDBox.Location = new System.Drawing.Point(150, 41);
            this.PlanetIDBox.Name = "PlanetIDBox";
            this.PlanetIDBox.Size = new System.Drawing.Size(105, 32);
            this.PlanetIDBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(197, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 284);
            this.listBox1.TabIndex = 2;
            // 
            // GetPeople
            // 
            this.GetPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetPeople.Location = new System.Drawing.Point(282, 33);
            this.GetPeople.Name = "GetPeople";
            this.GetPeople.Size = new System.Drawing.Size(132, 46);
            this.GetPeople.TabIndex = 3;
            this.GetPeople.Text = "Get People";
            this.GetPeople.UseVisualStyleBackColor = true;
            this.GetPeople.Click += new System.EventHandler(this.GetPeople_Click);
            // 
            // PeopleIDBox
            // 
            this.PeopleIDBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeopleIDBox.Location = new System.Drawing.Point(432, 41);
            this.PeopleIDBox.Name = "PeopleIDBox";
            this.PeopleIDBox.Size = new System.Drawing.Size(105, 32);
            this.PeopleIDBox.TabIndex = 4;
            // 
            // speciesBtn
            // 
            this.speciesBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speciesBtn.Location = new System.Drawing.Point(616, 33);
            this.speciesBtn.Name = "speciesBtn";
            this.speciesBtn.Size = new System.Drawing.Size(132, 46);
            this.speciesBtn.TabIndex = 5;
            this.speciesBtn.Text = "List All Species";
            this.speciesBtn.UseCompatibleTextRendering = true;
            this.speciesBtn.UseVisualStyleBackColor = true;
            this.speciesBtn.Click += new System.EventHandler(this.speciesBtn_Click);
            // 
            // StarWars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speciesBtn);
            this.Controls.Add(this.PeopleIDBox);
            this.Controls.Add(this.GetPeople);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PlanetIDBox);
            this.Controls.Add(this.GetPlanet);
            this.Name = "StarWars";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetPlanet;
        private TextBox PlanetIDBox;
        private ListBox listBox1;
        private Button GetPeople;
        private TextBox PeopleIDBox;
        private Button speciesBtn;
    }
}