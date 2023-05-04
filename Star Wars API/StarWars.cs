namespace Star_Wars_API
{
    public partial class StarWars : Form
    {
        public StarWars()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListPlanetInfo(Planet myPlanet)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name: " + myPlanet.name);
            listBox1.Items.Add("Rotation Period: " + myPlanet.rotation_period);
            listBox1.Items.Add("Orbital Period: " + myPlanet.orbital_period);
            listBox1.Items.Add("Diameter: " + myPlanet.diameter);
            listBox1.Items.Add("Climate: " + myPlanet.climate);
            listBox1.Items.Add("Gravity: " + myPlanet.gravity);
            listBox1.Items.Add("Terrain: " + myPlanet.terrain);
            listBox1.Items.Add("Surface Water: " + myPlanet.surface_water);
            listBox1.Items.Add("Population: " + myPlanet.population);
        }

        private void ListPeopleInfo(People myPeople)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name: " + myPeople.name);
            listBox1.Items.Add("Height: " + myPeople.height);
            listBox1.Items.Add("Mass: " + myPeople.mass);
            listBox1.Items.Add("Hair Color: " + myPeople.hair_color);
            listBox1.Items.Add("Skin Color: " + myPeople.skin_color);
            listBox1.Items.Add("Eye Color: " + myPeople.eye_color);
            listBox1.Items.Add("Birth Year: " + myPeople.birth_year);
            listBox1.Items.Add("Gender: " + myPeople.gender);
            listBox1.Items.Add("Homeworld: " + myPeople.homeworld);

            foreach (var i in myPeople.starships)
                listBox1.Items.Add("Starships: " + i);
        }

        private void ListSpecies(Species mySpecies)
        {
            listBox1.Items.Add("Name: " + mySpecies.name);
            listBox1.Items.Add("Classification: " + mySpecies.classification);
            listBox1.Items.Add("Designation: " + mySpecies.designation);
            listBox1.Items.Add("Average Height: " + mySpecies.average_height);
            listBox1.Items.Add("Skin Colors: " + mySpecies.skin_colors);
            listBox1.Items.Add("Hair Colors: " + mySpecies.hair_colors);
            listBox1.Items.Add("Eye Colors: " + mySpecies.eye_colors);
            listBox1.Items.Add("Average Lifespan: " + mySpecies.average_lifespan);
            listBox1.Items.Add("Homeworld: " + mySpecies.homeworld);
            listBox1.Items.Add("Language: " + mySpecies.language);
        }

        private async void GetPlanet_Click(object sender, EventArgs e)
        {
            try
            {
                Planet myPlanet = await JSONHelper.GetPlanet(Convert.ToInt32(PlanetIDBox.Text));
                ListPlanetInfo(myPlanet);
            }
            catch
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please enter valid Planet ID.");
            }
        }

        private async void GetPeople_Click(object sender, EventArgs e)
        {
            try
            {
                People myPeople = await JSONHelper.GetPeople(Convert.ToInt32(PeopleIDBox.Text));
                ListPeopleInfo(myPeople);
            }
            catch
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please enter valid People ID.");
            }

        }

        private async void speciesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AllSpecies spec = await JSONHelper.GetAllSpecies();

                //Loops through All Species and Lists it in listBox1
                foreach (var i in spec.results)//
                {
                    ListSpecies(i);
                    listBox1.Items.Add(" ");
                }
            }
            catch
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Failed to get allspecies.");
            }
        }
    }
}