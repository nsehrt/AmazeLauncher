using System;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Diagnostics;


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

            //apply config to drop downs

            //display

            switch (config.Display.ResolutionWidth)
            {
                case 1280: resolution.SelectedIndex = 0; break;
                case 1600: resolution.SelectedIndex = 1; break;
                case 1920: resolution.SelectedIndex = 2; break;
                case 2560: resolution.SelectedIndex = 3; break;
                case 3840: resolution.SelectedIndex = 4; break;
            }

            displayMode.SelectedIndex = config.Display.WindowMode;

            vsync.SelectedIndex = config.Display.VSync == 0 ?
                vsync.FindStringExact("Off") :
                vsync.FindStringExact("On");

            refreshRate.SelectedIndex = refreshRate.FindStringExact(Convert.ToString(config.Display.RefreshRate) + "hz");

            //volume
            volume.Value = (int)(config.Audio.MasterVolume * 10);


            //graphic

            if (config.Graphic.ShadowEnabled == 1)
            {
                shadowQuality.SelectedIndex = config.Graphic.ShadowQuality + 1;
            }
            else
            {
                shadowQuality.SelectedIndex = 0;
            }

            anisotropicFilter.SelectedIndex = anisotropicFilter.FindStringExact(
                config.Graphic.AnisotropicFiltering != 0 ? Convert.ToString(config.Graphic.AnisotropicFiltering) + "x" : "None");


            sobelFilter.SelectedIndex = config.Graphic.SobelFilter == 0 ?
                sobelFilter.FindStringExact("Off") :
                sobelFilter.FindStringExact("On");

            //misc
            drawFPS.SelectedIndex = config.Misc.DrawFPSEnabled == 0 ?
                drawFPS.FindStringExact("Off") :
                drawFPS.FindStringExact("On");

        }

        //close button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //play button
        private void button1_Click(object sender, EventArgs e)
        {
            // apply settings

            switch (resolution.SelectedIndex)
            {
                case 0: config.Display.ResolutionWidth = 1280; config.Display.ResolutionHeight = 720; break;
                case 1: config.Display.ResolutionWidth = 1600; config.Display.ResolutionHeight = 900; break;
                case 2: config.Display.ResolutionWidth = 1920; config.Display.ResolutionHeight = 1080; break;
                case 3: config.Display.ResolutionWidth = 2560; config.Display.ResolutionHeight = 1440; break;
                case 4: config.Display.ResolutionWidth = 3840; config.Display.ResolutionHeight = 2160; break;
            }

            config.Display.WindowMode = displayMode.SelectedIndex;
            config.Display.VSync = vsync.SelectedIndex;

            switch (refreshRate.SelectedIndex)
            {
                case 0: config.Display.RefreshRate = 30; break;
                case 1: config.Display.RefreshRate = 60; break;
                case 2: config.Display.RefreshRate = 144; break;
                case 3: config.Display.RefreshRate = 240; break;
            }

            config.Audio.MasterVolume = volume.Value / 10.0f;

            switch (shadowQuality.SelectedIndex)
            {
                case 0: config.Graphic.ShadowEnabled = 0; break;
                case 1: config.Graphic.ShadowEnabled = 1; config.Graphic.ShadowQuality = 0; break;
                case 2: config.Graphic.ShadowEnabled = 1; config.Graphic.ShadowQuality = 1; break;
                case 3: config.Graphic.ShadowEnabled = 1; config.Graphic.ShadowQuality = 2; break;
                case 4: config.Graphic.ShadowEnabled = 1; config.Graphic.ShadowQuality = 3; break;
            }

            switch (anisotropicFilter.SelectedIndex)
            {
                case 0: config.Graphic.AnisotropicFiltering = 0; break;
                case 1: config.Graphic.AnisotropicFiltering = 4; break;
                case 2: config.Graphic.AnisotropicFiltering = 8; break;
                case 3: config.Graphic.AnisotropicFiltering = 16; break;
            }

            config.Graphic.SobelFilter = sobelFilter.SelectedIndex;
            config.Misc.DrawFPSEnabled = drawFPS.SelectedIndex;

            // save json configuration

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string outJson = JsonSerializer.Serialize(config, options);
            File.WriteAllText("config\\settings.json", outJson);

            // start game
            try
            {
                _ = Process.Start("amaze.exe");
            }
            catch
            {
                _ = MessageBox.Show("Launcher can not find game executable!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            // close launcher 
            Application.Exit();
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
