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
            GetPlanet = new Button();
            PlanetIDBox = new TextBox();
            listBox1 = new ListBox();
            GetPeople = new Button();
            PeopleIDBox = new TextBox();
            speciesBtn = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // GetPlanet
            // 
            GetPlanet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GetPlanet.Location = new Point(12, 35);
            GetPlanet.Name = "GetPlanet";
            GetPlanet.Size = new Size(132, 48);
            GetPlanet.TabIndex = 0;
            GetPlanet.Text = "Get Planet";
            GetPlanet.UseVisualStyleBackColor = true;
            GetPlanet.Click += GetPlanet_Click;
            // 
            // PlanetIDBox
            // 
            PlanetIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlanetIDBox.Location = new Point(150, 43);
            PlanetIDBox.Name = "PlanetIDBox";
            PlanetIDBox.Size = new Size(105, 34);
            PlanetIDBox.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(12, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 280);
            listBox1.TabIndex = 2;
            // 
            // GetPeople
            // 
            GetPeople.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GetPeople.Location = new Point(282, 35);
            GetPeople.Name = "GetPeople";
            GetPeople.Size = new Size(132, 48);
            GetPeople.TabIndex = 3;
            GetPeople.Text = "Get People";
            GetPeople.UseVisualStyleBackColor = true;
            GetPeople.Click += GetPeople_Click;
            // 
            // PeopleIDBox
            // 
            PeopleIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PeopleIDBox.Location = new Point(420, 43);
            PeopleIDBox.Name = "PeopleIDBox";
            PeopleIDBox.Size = new Size(105, 34);
            PeopleIDBox.TabIndex = 4;
            // 
            // speciesBtn
            // 
            speciesBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            speciesBtn.Location = new Point(616, 35);
            speciesBtn.Name = "speciesBtn";
            speciesBtn.Size = new Size(141, 48);
            speciesBtn.TabIndex = 5;
            speciesBtn.Text = "List All Species";
            speciesBtn.UseCompatibleTextRendering = true;
            speciesBtn.UseVisualStyleBackColor = true;
            speciesBtn.Click += speciesBtn_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(457, 182);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(331, 284);
            listBox2.TabIndex = 6;
            // 
            // StarWars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(listBox2);
            Controls.Add(speciesBtn);
            Controls.Add(PeopleIDBox);
            Controls.Add(GetPeople);
            Controls.Add(listBox1);
            Controls.Add(PlanetIDBox);
            Controls.Add(GetPlanet);
            Name = "StarWars";
            Text = "Star Wars API This & That";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetPlanet;
        private TextBox PlanetIDBox;
        private ListBox listBox1;
        private Button GetPeople;
        private TextBox PeopleIDBox;
        private Button speciesBtn;
        private ListBox listBox2;
    }
}