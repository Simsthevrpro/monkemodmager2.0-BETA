using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System.Reflection.Emit;
using System.Runtime.InteropServices;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            MessageBox.Show("welcome to monkey mod manger enjoy");
            MessageBox.Show("also i did not make the mods");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string downloadUrl = "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_x64_5.4.22.0.zip";
            string extractPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Gorilla Tag"; // Change this to the directory where you want to extract BepInEx

            MessageBox.Show("Downloading BepInEx...");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(downloadUrl, "BepInEx.zip");

                    MessageBox.Show("BepInEx downloaded successfully.");

                    MessageBox.Show("Extracting BepInEx...");

                    ZipFile.ExtractToDirectory("BepInEx.zip", extractPath);

                    MessageBox.Show("BepInEx extracted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Clean up
                File.Delete("BepInEx.zip");
                Console.Beep();
            }

            MessageBox.Show("Installation completed.");


        }



        private void zipinstaller_Click(object sender, EventArgs e)
        {
            // Source folder containing the files
            string sourceFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            // Destination folder where the zip file will be created
            string destinationFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag";

            // Name of the zip file
            string zipFileName = "plugins_back_up.zip";

            // Combine destination folder and zip file name to get full path of the zip file
            string zipFilePath = Path.Combine(destinationFolder, zipFileName);

            try
            {
                // Create the destination folder if it doesn't exist
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Create a new zip file
                ZipFile.CreateFromDirectory(sourceFolder, zipFilePath);

                MessageBox.Show("Zip file created successfully at: " + zipFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.Beep();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void label_Click(object sender, EventArgs e)
        {

        }

        private void onlyupinstaller_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1158930022472613980/1223304721918464071/Monke.Dimensions.zip?ex=66195e4d&is=6606e94d&hm=3c94661c2c606ee348a255e647f05c74fe31528bfa859fc0c90a2387345b3b95&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "Monke.Dimensions.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("Monke.Dimensions.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("Monke.Dimensions.zip");
            }
        }

        private void comperter_inface_installer_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1158930022472613980/1223308529021227111/ComputerInterface.zip?ex=661961d9&is=6606ecd9&hm=89548d045abd3e3acd1b811a59f127a625c7bf86580105ca4df8816b00f3a901&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "ComputerInterface.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("ComputerInterface.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("ComputerInterface.zip");
            }
        }

        private void utillainstaller_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1158930022472613980/1223312113531879455/Utilla.zip?ex=6619652f&is=6606f02f&hm=4d2ba75187a4e8125b64b93cb5b66273f7d51b528510d49162f10b26beffb3f2&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "Utilla.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("Utilla.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("Utilla.zip");
            }
        }

        private void gorillashirtsinstaller_Click(object sender, EventArgs e)
        {

            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1158930022472613980/1223316893528494160/GorillaShirts.zip?ex=661969a3&is=6606f4a3&hm=47bc4b069a3c36eecdd009e3d6367b4674e77683e16f18444aa61028bfd4321b&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "GorillaShirts.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("GorillaShirts.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("GorillaShirts.zip");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            // URL to navigate to
            string url = "https://docs.google.com/document/d/1WfJ8RuIzTD_6fuxb1dGaplb__Jopb0AayK4RLaKr4X0/edit?usp=sharing";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }

        private void unistllamods_Click(object sender, EventArgs e)
        {
            // Path to the folder to delete
            string folderPath = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                // Check if the folder exists
                if (Directory.Exists(folderPath))
                {
                    // Delete all files within the folder
                    string[] files = Directory.GetFiles(folderPath);
                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }

                    // Delete all subfolders and their contents recursively
                    string[] subfolders = Directory.GetDirectories(folderPath);
                    foreach (string subfolder in subfolders)
                    {
                        Directory.Delete(subfolder, true);
                    }

                    MessageBox.Show("All files and subfolders within the folder have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
                else
                {
                    MessageBox.Show("The specified folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void restoremods_Click(object sender, EventArgs e)
        {
            // Source path of the ZIP file
            string sourceFilePath = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\plugins_back_up.zip";

            // Destination folder where the ZIP file will be copied and extracted
            string destinationFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                // Check if the source file exists
                if (File.Exists(sourceFilePath))
                {
                    // Create the destination folder if it doesn't exist
                    if (!Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }

                    // Get the file name from the source path
                    string fileName = Path.GetFileName(sourceFilePath);

                    // Combine the destination folder with the file name to get the full destination path
                    string destinationFilePath = Path.Combine(destinationFolder, fileName);

                    // Copy the ZIP file to the destination folder
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    MessageBox.Show("ZIP file copied successfully to: " + destinationFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory(destinationFilePath, destinationFolder);

                    MessageBox.Show("ZIP file extracted successfully to: " + destinationFolder, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
                else
                {
                    MessageBox.Show("backup mods does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clean up: Delete the downloaded ZIP file
                File.Delete("plugins_back_up.zip");
            }
        }

        private void insteler_intall_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223342955490836613/InterstellarV1.5.zip?ex=661981e9&is=66070ce9&hm=d8d16068a7d295421f4118a6c0e3b92526045e7979f4213ee86f5ac2ab2f73de&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "InterstellarV1.5.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("InterstellarV1.5.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("InterstellarV1.5.zip");
            }
        }

        private void bark_instller_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223343038458495100/Bark-1.5.1.zip?ex=661981fc&is=66070cfc&hm=b1bfe6506e79462777974751079ce0af65080e8ccea72b18ac09fef0d27303e1&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "Bark-1.5.1.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("Bark-1.5.1.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("Bark-1.5.1.zip");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223343110407323648/YizziCamModV2.zip?ex=6619820e&is=66070d0e&hm=1d9030a0e617118e08b869a5e6c9196c752d2745a2ce48addd1efd9ed172e724&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "YizziCamModV2.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("YizziCamModV2.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("YizziCamModV2.zip");
            }
        }

        private void intaller_iistupit_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223344206291144866/iis_Stupid_Menu_1.zip?ex=66198313&is=66070e13&hm=a1026025bab686fb4f5780b8460f6b3c0d40df84f72d8e7910a73634cd002751&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "iis_Stupid_Menu_1.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("iis_Stupid_Menu_1.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("iis_Stupid_Menu_1.zip");
            }
        }

        private void ShibaGoldLite_intaller_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223345027913224365/ShibaGT_Gold_Lite_v1.zip?ex=661983d7&is=66070ed7&hm=9b26c641169f6d6414d0f0e7891fab5b9aa58ec0dbceb71bce56d017645c6404&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "ShibaGT_Gold_Lite_v1.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("ShibaGT_Gold_Lite_v1.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("ShibaGT_Gold_Lite_v1.zip");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BEEP_Click(object sender, EventArgs e)
        {
            Console.Beep();
        }

        private void devblinkmod_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223359268384669756/DevBlinkMod.zip?ex=6619911a&is=66071c1a&hm=d94e8ff37f602d54b92c91605e07fd7c1967f3052a60b57027852c7b97986fe9&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "DevBlinkMod.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("DevBlinkMod.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("DevBlinkMod.zip");
            }
        }

        private void needed_folders_Click(object sender, EventArgs e)
        {

            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223412277001326632/IT_needed_folders.zip?ex=6619c278&is=66074d78&hm=2bd1980dfda1b6dbe59bbf29a837e28b8b10c197c4af1dad0df6d9ed33baf854&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "IT_needed_folders.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("IT_needed_folders.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("IT_needed_folders.zip");
            }
        }

        private void FNAG_instller_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223422847096193155/FiveNightsAtGorillas.zip?ex=6619cc50&is=66075750&hm=3858046d81ab3e1f1f13eee53489dc9eedad531a701efdf5bb0e97899da0c4f4&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "FiveNightsAtGorillas.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("FiveNightsAtGorillas.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("FiveNightsAtGorillas.zip");
            }
        }

        private void gorillacosmetic_installer_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223477855766450247/GorillaCosmetics_1.zip?ex=6619ff8b&is=66078a8b&hm=fa752256ce1f26cfc27ab785a0aaee090ca247c732e78c4afcf51649a651658a&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "GorillaCosmetics_1.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("GorillaCosmetics_1.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("GorillaCosmetics_1.zip");
            }
        }

        private void FPSC_installer_Click(object sender, EventArgs e)
        {
            // URL of the ZIP file to download
            string zipUrl = "https://cdn.discordapp.com/attachments/1223342811840118785/1223479334023725116/FpsCounter.zip?ex=661a00ec&is=66078bec&hm=0e5d0456bb3780a894217cec68b96162713f0df775819ed75a753874e6a7fc9f&";

            // Destination folder where the ZIP file will be extracted
            string extractFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the ZIP file
                    webClient.DownloadFile(zipUrl, "FpsCounter.zip");

                    // Extract the contents of the ZIP file to the destination folder
                    ZipFile.ExtractToDirectory("FpsCounter.zip", extractFolder);

                    MessageBox.Show("Extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Beep();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up: Delete the downloaded ZIP file
                File.Delete("FpsCounter.zip");
            }
        }
    }
}


        
    






















