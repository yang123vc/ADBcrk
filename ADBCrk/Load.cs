using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ADBCrk
{
    public class Load
    {
        public string PhotoshopPath    { get; set; }
        public string AfterEffectsPath { get; set; }
        public string InDesignPath     { get; set; }
        public string DreamWarePath    { get; set; }
        public string AuditionPath     { get; set; }
        public string PreludePath      { get; set; }
        public string LightroomPath    { get; set; }
        public string MusePath         { get; set; }
        public string SpeedgradePath   { get; set; }
        public string PremierePath     { get; set; }
        public string FlashPlayerPath  { get; set; }
        public string IllustratorPath  { get; set; }

        //*************************************************************************************************************************

        public Load()
        {
            PhotoshopPath    = GetApplicationPath("Photoshop.exe"  );
            AfterEffectsPath = GetApplicationPath("AfterFX.exe"    );
            InDesignPath     = GetApplicationPath("InDesign.exe"   );
            DreamWarePath    = GetApplicationPath("Dreamweaver.exe");
            AuditionPath     = GetApplicationPath("Audition.exe"   );
            PreludePath      = GetApplicationPath("Prelude.exe"    );
            LightroomPath    = GetApplicationPath("Lightroom.exe"  );
            MusePath         = GetApplicationPath("Muse.exe"       );
            SpeedgradePath   = GetApplicationPath("Speedgrade.exe" );
            PremierePath     = GetApplicationPath("Premiere.exe"   );
            FlashPlayerPath  = GetApplicationPath("FlashPlayer.exe");
            IllustratorPath  = GetApplicationPath("Illustrator.exe");
        }

        //*************************************************************************************************************************

        public string GetApplicationPath(string ExeName)
        {
            try
            {
                RegistryKey OurKey = Registry.LocalMachine;
                OurKey = OurKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\App Paths\" + ExeName, true);

                if (OurKey != null)
                    return OurKey.GetValue("").ToString();
                else
                    return "NOT FOUND";
            }
            catch
            {
                return "ERROR";
            }
        }

        //*************************************************************************************************************************
    }
}
