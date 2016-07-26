using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using Transitions;

namespace LeParadoxHD_Converter
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            getVideo.DragEnter += new DragEventHandler(getVideo_DragEnter);
        }

        // Variable preestablecidas

        string videoFile;
        string path;
        bool ready = false;

        void getVideo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void getVideo_Click(object sender, EventArgs e)
        {
            comenzar();
        }

        // Desplegar diálogo de selección de archivo de vídeo

        private void comenzar()
        {
            fileDialog.Title = "Abrir archivo de vídeo";
            fileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            fileDialog.FileName = "";
            fileDialog.Filter = "Formatos de vídeo soportados (*.wm,*.m4v,*.wmv,*.asf,*.mov,*.mp4,*.3g2,*.3gp,*.mp4v,*.avi,*.pyv,*.3gpp,*.3gp2)| *.wm;*.m4v;*.wmv;*.asf;*.mov;*.mp4;*.3g2;*.3gp;*.mp4v;*.avi;*.pyv;*.3gpp;*.3gp2";
            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = fileDialog.FileName;
                videoFile = Path.GetFileName(fileDialog.FileName);
                FileInfo fa1 = new FileInfo(fileDialog.FileName);
                if ( videoFile.Length > 20 )
                {
                    status.Text = videoFile.Substring(0, 20) + " | " + (fa1.Length / 1024) / 1024 + " MB";
                } else
                {
                    status.Text = videoFile + " | " + (fa1.Length / 1024) / 1024 + " MB";
                }
                showButton();
            }
        }

        // Detectar arrastre de archivos

        void getVideo_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int c = FileList.Length;
            if ( c != 1 )
            {
                MessageBox.Show("¡Solo se permite un elemento a la vez!", "Multiples archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                path = FileList[0];
                videoFile = Path.GetFileName(FileList[0]);
                string videoExtension = Path.GetExtension(FileList[0]);
                string[] extensiones = { ".wm", ".m4v", ".wmv", ".asf", ".mov", ".mp4", ".3g2", ".3gp", ".mp4v", ".avi", ".pyv", ".3gpp", ".3gp2" };
                if ( extensiones.Contains(videoExtension) )
                {
                    FileInfo fa2 = new FileInfo(FileList[0]);
                    status.Text = videoFile + " | " + (fa2.Length / 1024) / 1024 + " MB";
                    showButton();
                } else
                {
                    MessageBox.Show("Archivo de vídeo no soportado", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Comprobar conexión

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Mostrar botones de opciones al seleccionar archivo de vídeo

        public void showButton()
        {
            if (File.Exists("ffmpeg.exe") == false)
            {
                if (CheckForInternetConnection())
                {
                    progreso.Visible = true;
                    status.Text = "Descargando ffmpeg.exe...";
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(completed);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadFileAsync(new Uri("http://www.pollastresantana.com/descargas/ffmpeg.exe"), "ffmpeg.exe");
                    getVideo.Visible = false;
                    mismoNombre.Checked = true;
                    comenzarButton.Visible = true;
                    calidad.SelectedIndex = 4;
                    cores.SelectedIndex = 3;
                    quality.Visible = true;
                    calidad.Visible = true;
                    CPUCores.Visible = true;
                    cores.Visible = true;
                    customName.Visible = true;
                    mismoNombre.Visible = true;
                    customName.Text = Path.GetFileNameWithoutExtension(path) + "(1)";
                    customName.ReadOnly = true;
                    resolucion.Visible = true;
                    resolution.Visible = true;
                    fotos.Visible = true;
                    frameRate.Visible = true;
                    resolution.SelectedIndex = 0;
                    frameRate.SelectedIndex = 0;
                    Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
                    t.add(comenzarButton, "Left", 15);
                    t.add(mismoNombre, "Left", 149);
                    t.add(customName, "Left", 260);
                    t.add(quality, "Left", 15);
                    t.add(calidad, "Left", 75);
                    t.add(CPUCores, "Left", 176);
                    t.add(cores, "Left", 327);
                    t.add(fotos, "Left", 375);
                    t.add(frameRate, "Left", 412);
                    t.add(resolucion, "Left", 15);
                    t.add(resolution, "Left", 93);
                    t.run();
                } else
                {
                    while (!CheckForInternetConnection())
                    {
                        DialogResult Reintentar = MessageBox.Show("Es necesaria una conexión a internet para descargar los archivos necesarios.", "Conexión a Internet", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if ( Reintentar == DialogResult.Cancel )
                        {
                            System.Environment.Exit(1);
                        }
                    }
                }

            }
            else
            {
                ready = true;
                getVideo.Visible = false;
                comenzarButton.Visible = true;
                calidad.SelectedIndex = 4;
                cores.SelectedIndex = 3;
                quality.Visible = true;
                calidad.Visible = true;
                CPUCores.Visible = true;
                cores.Visible = true;
                customName.Visible = true;
                mismoNombre.Visible = true;
                customName.Text = Path.GetFileNameWithoutExtension(path) + "(1)";
                customName.ReadOnly = true;
                resolucion.Visible = true;
                resolution.Visible = true;
                fotos.Visible = true;
                mismoNombre.Checked = true;
                frameRate.Visible = true;
                resolution.SelectedIndex = 0;
                frameRate.SelectedIndex = 0;
                Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
                t.add(comenzarButton, "Left", 15);
                t.add(mismoNombre, "Left", 149);
                t.add(customName, "Left", 260);
                t.add(quality, "Left", 15);
                t.add(calidad, "Left", 75);
                t.add(CPUCores, "Left", 176);
                t.add(cores, "Left", 327);
                t.add(fotos, "Left", 375);
                t.add(frameRate, "Left", 412);
                t.add(resolucion, "Left", 15);
                t.add(resolution, "Left", 93);
                t.run();
            }
        }

        // Descarga progreso

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if ( e.ProgressPercentage == 100 )
            {
                status.Text = "¡Descarga finalizada!";
                showButton();
                ready = true;
            }
            status.Text = "Descargando ffmpeg.exe... " + e.ProgressPercentage.ToString() + "%";
            progreso.Value = e.ProgressPercentage;
        }

        // Descarga completada

        private void completed(object sender, AsyncCompletedEventArgs e)
        {
            status.Text = "¡Descarga finalizada!";
            ready = true;
            progreso.Visible = false;
        }

        // Comenzar compresión

        private void comenzarButton_Click(object sender, EventArgs e)
        {
            progreso.Visible = false;
            string calidadF = calidad.Text;
            int nucleos = Int32.Parse(cores.Text);
            string outputName = customName.Text;
            string compare1 = Path.GetFileNameWithoutExtension(path);
            string compare2 = outputName;
            if (ready == true)
            {
                if (compare1 != compare2)
                {
                    var proc = new Process();
                    string cua;
                    /// Calidad
                    switch ( calidadF )
                    {
                        case "Baja":
                            cua = "30";
                            break;
                        case "Media":
                            cua = "25";
                            break;
                        case "Alta":
                            cua = "20";
                            break;
                        case "Ultra":
                            cua = "15";
                            break;
                        case "Sin pérdida":
                            cua = "10";
                            break;
                        default:
                            cua = "15";
                            break;
                    }
                    // Núcleos
                    int nuc;
                    switch ( nucleos )
                    {
                        case 1:
                            nuc = 1;
                            break;
                        case 2:
                            nuc = 2;
                            break;
                        case 4:
                            nuc = 4;
                            break;
                        case 8:
                            nuc = 8;
                            break;
                        default:
                            nuc = 8;
                            break;
                    }
                    // Resolución
                    string res = resolution.Text.Trim();
                    string pi = Regex.Replace(res, @"\s+", "");
                    string pixel;
                    switch ( pi )
                    {
                        case "Igual":
                            pixel = "";
                            break;
                        default:
                            pixel = "-filter:v scale=" + pi;
                            break;
                    }
                    // Fotogramas por segundo
                    string fps = frameRate.Text;
                    string fotogramas;
                    switch ( fps )
                    {
                        case "Igual":
                            fotogramas = "";
                            break;
                        default:
                            fotogramas = "-r " + fps;
                            break;
                    }
                    // Empezar proceso de conversión
                    proc.StartInfo.FileName = "ffmpeg.exe";
                    proc.StartInfo.Arguments = "-y -i " + "\u0022" + path + "\u0022" +
                    " -c:v libx264 " + fotogramas + " -preset ultrafast " + pixel + " -crf " + cua + " -threads " + nuc + 
                    " -c:a copy " + "\u0022" + Path.GetDirectoryName(path) + "\\" + outputName + 
                    ".mp4" + "\u0022";
                    proc.Start();
                    proc.WaitForExit();
                    Process.Start("explorer.exe", "/select," + "\u0022" + Path.GetDirectoryName(path) + "\\" + outputName + ".mp4" + "\u0022");
                    status.Text = "¡Finalizado!";
                    linkYouTube.Visible = true;
                    getVideo.Visible = true;
                    comenzarButton.Visible = false;
                    quality.Visible = false;
                    calidad.Visible = false;
                    CPUCores.Visible = false;
                    cores.Visible = false;
                    customName.Visible = false;
                    mismoNombre.Visible = false;
                    resolucion.Visible = false;
                    resolution.Visible = false;
                    fotos.Visible = false;
                    frameRate.Visible = false;
                    Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
                    t.add(comenzarButton, "Left", 700);
                    t.add(mismoNombre, "Left", 700);
                    t.add(customName, "Left", 700);
                    t.add(quality, "Left", 700);
                    t.add(calidad, "Left", 700);
                    t.add(CPUCores, "Left", 700);
                    t.add(cores, "Left", 700);
                    t.add(fotos, "Left", 700);
                    t.add(frameRate, "Left", 700);
                    t.add(resolucion, "Left", 700);
                    t.add(resolution, "Left", 700);
                    t.run();
                }
                else
                {
                    MessageBox.Show("El archivo de origen y destindo son idénticos, por favor cambie el nombre de archivo de destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Aún no se he descargado ffmpeg.exe, por favor, espere.", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void mismoNombre_CheckStateChanged(object sender, EventArgs e)
        {
            if ( mismoNombre.Checked == true )
            {
                customName.ReadOnly = true;
                customName.Text = Path.GetFileNameWithoutExtension(path) + "(1)";
            } else
            {
                customName.ReadOnly = false;
                customName.Text = "";
            }
        }

        private void linkYouTube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/LeParadoxHDV");
        }

        private void changeTheme_CheckedStateChanged(object sender, EventArgs e)
        {
            if (changeTheme.Checked == true)
            {
                exchangeTheme(true);
            }
            else
            {
                exchangeTheme(false);
            }
        }

        public void exchangeTheme(bool state)
        {
            if (state)
            {
                comenzarButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                customName.Theme = MetroFramework.MetroThemeStyle.Dark;
                CPUCores.Theme = MetroFramework.MetroThemeStyle.Dark;
                cores.Theme = MetroFramework.MetroThemeStyle.Dark;
                resolucion.Theme = MetroFramework.MetroThemeStyle.Dark;
                resolution.Theme = MetroFramework.MetroThemeStyle.Dark;
                frameRate.Theme = MetroFramework.MetroThemeStyle.Dark;
                fotos.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
                changeTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                linkYouTube.Theme = MetroFramework.MetroThemeStyle.Dark;
                status.Theme = MetroFramework.MetroThemeStyle.Dark;
                getVideo.Theme = MetroFramework.MetroThemeStyle.Dark;
                calidad.Theme = MetroFramework.MetroThemeStyle.Dark;
                quality.Theme = MetroFramework.MetroThemeStyle.Dark;
                mismoNombre.Theme = MetroFramework.MetroThemeStyle.Dark;
                progreso.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Refresh();
            } else
            {
                comenzarButton.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                customName.Theme = MetroFramework.MetroThemeStyle.Light;
                CPUCores.Theme = MetroFramework.MetroThemeStyle.Light;
                cores.Theme = MetroFramework.MetroThemeStyle.Light;
                resolucion.Theme = MetroFramework.MetroThemeStyle.Light;
                resolution.Theme = MetroFramework.MetroThemeStyle.Light;
                frameRate.Theme = MetroFramework.MetroThemeStyle.Light;
                fotos.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
                changeTheme.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
                linkYouTube.Theme = MetroFramework.MetroThemeStyle.Light;
                status.Theme = MetroFramework.MetroThemeStyle.Light;
                getVideo.Theme = MetroFramework.MetroThemeStyle.Light;
                calidad.Theme = MetroFramework.MetroThemeStyle.Light;
                quality.Theme = MetroFramework.MetroThemeStyle.Light;
                mismoNombre.Theme = MetroFramework.MetroThemeStyle.Light;
                progreso.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Refresh();
            }
        }
    }
}
