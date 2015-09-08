using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;


namespace ADBCrk
{

    public partial class Form1 : Form
    {

        Load load;
        readonly int dimFinestraMin = 327;
        bool isClicked = false;

        //*************************************************************************************************************************

        public Form1()
        {
            InitializeComponent();
        }

        //*************************************************************************************************************************

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStato.Text = "Pronto.    Seleziona il programma che vuoi craccare.";
            lbl_Descrizione.Text = "Seleziona il programma che vuoi craccare, se non è disponibile\nspunta la casella \"programma non disponibile\", e selezionalo \nper modificarne il percorso.";

            LoadADBcrkProgramDetector();

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_PS, "Photoshop CC");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_AE, "After Effects CC");
        }

        //*************************************************************************************************************************

        private void LoadADBcrkProgramDetector()
        {
            load = new Load();


            if (load.PhotoshopPath != "NOT FOUND" && load.PhotoshopPath != "ERROR")
            {
                btn_PS.Enabled = true;
            }
            else
                btn_PS.Enabled = false;

            if (load.AfterEffectsPath != "NOT FOUND" && load.AfterEffectsPath != "ERROR")
            {
                btn_AE.Enabled = true;
            }
            else
                btn_AE.Enabled = false;


            if (load.InDesignPath != "NOT FOUND" && load.InDesignPath != "ERROR")
            {
                btn_ID.Enabled = true;
            }
            else
                btn_ID.Enabled = false;

            if (load.DreamWarePath != "NOT FOUND" && load.DreamWarePath != "ERROR")
            {
                btn_DW.Enabled = true;
            }
            else
                btn_DW.Enabled = false;

            if (load.AuditionPath != "NOT FOUND" && load.AuditionPath != "ERROR")
            {
                btn_AU.Enabled = true;
            }
            else
                btn_AU.Enabled = false;

            if (load.PreludePath != "NOT FOUND" && load.PreludePath != "ERROR")
            {
                btn_PL.Enabled = true;
            }
            else
                btn_PL.Enabled = false;

            if (load.LightroomPath != "NOT FOUND" && load.LightroomPath != "ERROR")
            {
                btn_LR.Enabled = true;
            }
            else
                btn_LR.Enabled = false;

            if (load.MusePath != "NOT FOUND" && load.MusePath != "ERROR")
            {
                btn_MU.Enabled = true;
            }
            else
                btn_MU.Enabled = false;

            if (load.SpeedgradePath != "NOT FOUND" && load.SpeedgradePath != "ERROR")
            {
                btn_SG.Enabled = true;
            }
            else
                btn_SG.Enabled = false;

            if (load.PremierePath != "NOT FOUND" && load.PremierePath != "ERROR")
            {
                btn_PR.Enabled = true;
            }
            else
                btn_PR.Enabled = false;

            if (load.FlashPlayerPath != "NOT FOUND" && load.FlashPlayerPath != "ERROR")
            {
                btn_FL.Enabled = true;
            }
            else
                btn_FL.Enabled = false;
        }

        //*************************************************************************************************************************

        private static void ExtractEmbeddedResource(string outputDir, string resourceLocation, List<string> files)
        {
            foreach (string file in files)
            {
                using (System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceLocation + @"." + file))
                {
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(System.IO.Path.Combine(outputDir, file), System.IO.FileMode.Create))
                    {
                        for (int i = 0; i < stream.Length; i++)
                        {
                            fileStream.WriteByte((byte)stream.ReadByte());
                        }
                        fileStream.Close();
                    }
                }
            }
        }

        //*************************************************************************************************************************

        private void btnSettingsPs_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls.Add("amtlib1.dll");
            ExtractEmbeddedResource("C:\\Users\\fabio\\Desktop\\ciao\\", "ADBCrk",ls);
        }

        //*************************************************************************************************************************

        private void btnChiudiPannello_Click(object sender, EventArgs e)
        {
            ChiudiPnl();
        }

        //*************************************************************************************************************************

        private void ApriPnl()
        {
            if (!isClicked)
            {
                new Thread(() =>
                {
                    for (int i = 0; i < 422; i++)
                        this.Invoke(new Action(() =>
                       this.Width++));
                }
                ).Start();

                isClicked = true;
            }
        }

        //*************************************************************************************************************************

        private void ChiudiPnl()
        {
            if (isClicked)
            {
                new Thread(() =>
                {
                    for (int i = 422; i > 0; i--)
                        this.Invoke(new Action(() =>
                           this.Width--));
                }
                ).Start();

                isClicked = false;
            }
        }
        //*************************************************************************************************************************

        private void WriteAutoPath(string program)
        {
            if(program == "PS")
            {
                //txtAutoPath.Text = load.PhotoshopPath;
            }

            if(program == "AE")
            {
               // txtAutoPath.Text = load.AfterEffectsPath;
            }

            if(program == "ID")
            {
               // txtAutoPath.Text = load.InDesignPath;
            }
        }

        //*************************************************************************************************************************

        private void btnSettingsAe_Click(object sender, EventArgs e)
        {
            ApriPnl();

            WriteAutoPath("AE");
        }

        //*************************************************************************************************************************

        private void btnSettingsId_Click(object sender, EventArgs e)
        {
            ApriPnl();

            WriteAutoPath("ID");
        }

        //*************************************************************************************************************************

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //*************************************************************************************************************************

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //*************************************************************************************************************************

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ProgrammaNonDisponibile.Checked)
            {
                FlatButtonEnabledRed();

                btn_AE.Enabled = true;
                btn_AI.Enabled = true;
                btn_AU.Enabled = true;
                btn_DW.Enabled = true;
                btn_FL.Enabled = true;
                btn_ID.Enabled = true;
                btn_LR.Enabled = true;
                btn_PL.Enabled = true;
                btn_PR.Enabled = true;
                btn_PS.Enabled = true;
                btn_SG.Enabled = true;
                btn_MU.Enabled = true;

               // statusStrip.BackColor = Color.LightGreen;
            }
            else
            {
                LoadADBcrkProgramDetector();

                FlatButtonEnabledTRansparent();
            }
        }

        //*************************************************************************************************************************

        private void FlatButtonEnabledRed()
        {
            btn_AE.BackColor = Color.Coral;
            btn_AI.BackColor = Color.Coral;
            btn_AU.BackColor = Color.Coral;
            btn_DW.BackColor = Color.Coral;
            btn_FL.BackColor = Color.Coral;
            btn_ID.BackColor = Color.Coral;
            btn_LR.BackColor = Color.Coral;
            btn_PL.BackColor = Color.Coral;
            btn_PR.BackColor = Color.Coral;
            btn_PS.BackColor = Color.Coral;
            btn_SG.BackColor = Color.Coral;
            btn_MU.BackColor  = Color.Coral;

            btn_AE.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_AI.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_AU.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_DW.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_FL.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_ID.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_LR.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_PL.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_PR.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_PS.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_SG.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_MU.FlatAppearance.MouseOverBackColor  = Color.Red;

            statusStrip.BackColor = Color.Coral;
            lblStato.Text = "MODALITA' DI MODIFICA ATTIVATA";
        }

        //*************************************************************************************************************************

        private void FlatButtonEnabledTRansparent()
        {
            btn_AE.BackColor = Color.Transparent;
            btn_AI.BackColor = Color.Transparent;
            btn_AU.BackColor = Color.Transparent;
            btn_DW.BackColor = Color.Transparent;
            btn_FL.BackColor = Color.Transparent;
            btn_ID.BackColor = Color.Transparent;
            btn_LR.BackColor = Color.Transparent;
            btn_PL.BackColor = Color.Transparent;
            btn_PR.BackColor = Color.Transparent;
            btn_PS.BackColor = Color.Transparent;
            btn_SG.BackColor = Color.Transparent;
            btn_MU.BackColor  = Color.Transparent;

            btn_AE.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_AI.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_AU.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_DW.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_FL.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_ID.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_LR.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_PL.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_PR.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_PS.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_SG.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_MU.FlatAppearance.MouseOverBackColor = Color.LightGray;

            statusStrip.BackColor = Color.LightGreen;
            lblStato.Text = "Pronto.    Seleziona il programma che vuoi craccare.";
        }

        //*************************************************************************************************************************

        private void btn_PS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Photoshop CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("PS");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }

        }

        //*************************************************************************************************************************

        private void Crack(string program)
        {
            if (chk_BackupFirst.Checked)
            {
                //-------
                //CHECKED
                //-------

                string thisPath = AssegnaPath(program);
                string thisDLL = AssegnaDLL(program);
                prBar.Value = 20;
                try
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ADBcrk_Backups");     
                    File.Move(thisPath + @"amtlib.dll", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ADBcrk_Backups\\amtlib.dll");
                }
                catch
                {
                    //NOTHING
                }
                prBar.Value = 40;
                File.Delete(thisPath + @"amtlib.dll");
                prBar.Value = 60;
                List<string> ls = new List<string>();
                ls.Add(thisDLL);
                prBar.Value = 70;
                ExtractEmbeddedResource(thisPath, "ADBCrk", ls);
                File.Move(thisPath + thisDLL, thisPath + @"amtlib.dll");
                prBar.Value = 90;
            }
            else
            {
                //-----------
                //NOT CHECKED
                //-----------

                string thisPath = AssegnaPath(program);
                string thisDLL = AssegnaDLL(program);
                prBar.Value = 20;
                prBar.Value = 40;
                File.Delete(thisPath + @"amtlib.dll");
                prBar.Value = 60;
                List<string> ls = new List<string>();
                ls.Add(thisDLL);
                prBar.Value = 70;
                ExtractEmbeddedResource(thisPath, "ADBCrk", ls);
                File.Move(thisPath + thisDLL, thisPath + @"amtlib.dll");
                prBar.Value = 90;

            }

            prBar.Value = 100;
            lblStato.Text = "PATCH EFFETTUATA. ORA PUOI USARE IL PROGRAMMA.";

            Thread t = new Thread(() =>
            {
                System.Threading.Thread.Sleep(3000);
                prBar.Invoke(new Action( () => prBar.Value = 0));
            });
            t.Start();
        }

        //*************************************************************************************************************************

        private string AssegnaPath(string program)
        {
            if      (program == "PS")
                return load.PhotoshopPath.Remove(load.PhotoshopPath.Length-string.Format("Photoshop.exe").Length, string.Format("Photoshop.exe").Length);
            else if (program == "AE")
                return load.AfterEffectsPath.Remove(load.AfterEffectsPath.Length - string.Format("AfterFX.exe").Length, string.Format("AfterFX.exe").Length);
            else
                return "";
        }

        //*************************************************************************************************************************

        private string AssegnaDLL(string program)
        {
            if      (program == "PS")
                return "amtlibPS.dll";
            else if (program == "AE")
                return "amtlibAE.dll";
            else
                return "";
        }

        //*************************************************************************************************************************

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }

        //*************************************************************************************************************************

        private void istruzioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            lbldescrizioneinformazioni.Text = "ADBcrk è un proramma autonomo che patcha il programma adobe selezionato\nesso è in grado di rilevare quali programmi dell'adobe avete installato ed è in\ngrado di effettuare tutte le operazioni di patching autonomamente. Consiglio di \nvedere la sezione TUTORIAL.\n\nIl programma è funzionante con le ultime versioni della adobe, e su un sistema \na 64bit (x64).Eseguendo il prorgamma si accettano automaticamente i termini\ne le condizioni di utilizzo.\n\n\nI METODI DESCRITTI IN QUESTO PROGRAMMA E IL SUO FUNZIONAMENTO \nSONO SOLO A SCOPOINFORMATIVO.NON MI ASSUMO RESPONSABILITÀ \nSUL VOSTRO UTILIZZO E L'UTILIZZO DI QUESTO PROGRAMMA.\n\n Xyril Ⓒ";
        }

        private void btn_AE_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato After Effects CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("AE");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_DW_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato DreamWare CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("DW");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_AI_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Illustrator CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("AI");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_AU_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Audition CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("AU");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_PL_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Prelude CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("PL");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_ID_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato In Design CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("ID");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_LR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Lightroom CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("LR");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_MU_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Muse CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("MU");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_SG_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Speedgrade CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("SG");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_PR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Premiere CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("PR");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }

        private void btn_FL_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hai selezionato Flash CC\nConfermi?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prBar.Value = 10;
                Crack("FL");
            }
            else if (result == DialogResult.No)
            {
                //CANCEL
            }
        }
    }
}
