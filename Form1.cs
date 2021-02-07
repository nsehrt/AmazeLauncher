using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace AmazeLauncher
{

    public partial class AmazeLauncher : Form
    {
        public AmazeLauncher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load configuration file
            string configFile = "config\\settings.json";
            string json = File.ReadAllText(configFile);
            config = JsonSerializer.Deserialize<Configuration>(json);
        }

        //close button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //play button
        private void button1_Click(object sender, EventArgs e)
        {
            // save json configuration

            // start game

            // close launcher 
        }


        public Configuration config;
    }

    public class JAudio
    {
        public float MasterVolume { get; set; }
        public float EffectVolume { get; set; }
        public float MusicVolume { get; set; }
    }

    public class JDisplay
    {
        public int Monitor { get; set; }
        public int RefreshRate { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public int FOV { get; set; }
        public int VSync { get; set; }
        public int WindowMode { get; set; }
    }

    public class JGameplay
    {
        public int MazeAlgorithm { get; set; }
        public float MazeBraidRatio { get; set; }
        public bool TrailEnabled { get; set; }
        public int RandomSeed { get; set; }
    }

    public class JGraphic
    {
        public int NumFrameResources { get; set; }
        public int AnisotropicFiltering { get; set; }
        public int ShadowEnabled { get; set; }
        public int ShadowQuality { get; set; }
        public int SobelFilter { get; set; }
    }

    public class JInput
    {
        public int InvertYAxis { get; set; }
        public float Sensitivity { get; set; }
        public float FPSCameraSpeed { get; set; }
    }

    public class JMisc
    {
        public int DebugEnabled { get; set; }
        public int DebugQuadEnabled { get; set; }
        public int EditModeEnabled { get; set; }
        public int DrawFPSEnabled { get; set; }
    }

    public class Configuration
    {

        public JAudio Audio { get; set; }
        public JDisplay Display { get; set; }
        public JGameplay Gameplay { get; set; }
        public JGraphic Graphic { get; set; }
        public JInput Input { get; set; }
        public JMisc Misc { get; set; }

    }
}
