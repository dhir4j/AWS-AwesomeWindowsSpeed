using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Collections.Specialized;

namespace AWS___Awesome_Windows_Speed
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,MaterialSkin.Accent.Pink200,MaterialSkin.TextShade.WHITE);


            MessageBox.Show("Create Restore point Before Proceeding...\nUse AWS at your own risk!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch2.Checked)
            {
                const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\mouclass\Parameters";
                const string valueName = "MouseDataQueueSize";
                const int value = 0x19;

                // Set the value in the registry
                Registry.SetValue(keyName, valueName, value, RegistryValueKind.DWord);

                // Get the value from the registry to verify that it was set correctly
                int readValue = (int)Registry.GetValue(keyName, valueName, null);

                if (readValue == value)
                {
                    System.Console.WriteLine("Registry value set and retrieved successfully.");
                }
                else
                {
                    System.Console.WriteLine("Error setting or retrieving registry value.");
                }
            }
            else 
            {
                const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\mouclass\Parameters";
                const string valueName = "MouseDataQueueSize";
                const int defaultValue = 100;

                // Set the default value in the registry
                Registry.SetValue(keyName, valueName, defaultValue, RegistryValueKind.DWord);

                // Get the value from the registry to verify that it was set correctly
                int readValue = (int)Registry.GetValue(keyName, valueName, null);

                if (readValue == defaultValue)
                {
                    System.Console.WriteLine("Registry value set and retrieved successfully.");
                }
                else
                {
                    System.Console.WriteLine("Error setting or retrieving registry value.");
                }
            }
        }

        private void materialSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch3.Checked)
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Add the ""AutoEndTasks"" value
                echo Adding ""AutoEndTasks"" value...
                reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""AutoEndTasks"" /t REG_SZ /d ""1"" /f

                rem Add the ""HungAppTimeout"" value
                echo Adding ""HungAppTimeout"" value...
                reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""HungAppTimeout"" /t REG_SZ /d ""1000"" /f

                rem Add the ""MenuShowDelay"" value
                echo Adding ""MenuShowDelay"" value...
                reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""MenuShowDelay"" /t REG_SZ /d ""8"" /f

                rem Add the ""WaitToKillAppTimeout"" value
                echo Adding ""WaitToKillAppTimeout"" value...
                reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""WaitToKillAppTimeout"" /t REG_SZ /d ""2000"" /f

                rem Add the ""LowLevelHooksTimeout"" value
                echo Adding ""LowLevelHooksTimeout"" value...
                reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""LowLevelHooksTimeout"" /t REG_SZ /d ""1000"" /f
                echo Done!

                pause


                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else 
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Delete the ""AutoEndTasks"" value
                echo Deleting ""AutoEndTasks"" value...
                reg delete ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""AutoEndTasks"" /f

                rem Delete the ""HungAppTimeout"" value
                echo Deleting ""HungAppTimeout"" value...
                reg delete ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""HungAppTimeout"" /f

                rem Delete the ""MenuShowDelay"" value
                echo Deleting ""MenuShowDelay"" value...
                reg delete ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""MenuShowDelay"" /f

                rem Delete the ""WaitToKillAppTimeout"" value
                echo Deleting ""WaitToKillAppTimeout"" value...
                reg delete ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""WaitToKillAppTimeout"" /f

                rem Delete the ""LowLevelHooksTimeout"" value
                echo Deleting ""LowLevelHooksTimeout"" value...
                reg delete ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v ""LowLevelHooksTimeout"" /f
                echo Done!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
        }

        private void materialSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch4.Checked)
            {
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Add the ""WaitToKillServiceTimeout"" value
                echo Adding ""WaitToKillServiceTimeout"" value...
                reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control"" /v ""WaitToKillServiceTimeout"" /t REG_SZ /d ""2000"" /f
                echo Done!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else 
            {
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Delete the ""WaitToKillServiceTimeout"" value
                echo Deleting ""WaitToKillServiceTimeout"" value...
                reg delete ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control"" /v ""WaitToKillServiceTimeout"" /f
                echo Done!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
        }

        private void materialSwitch5_CheckedChanged(object sender, EventArgs e)
        {   
            if (materialSwitch5.Checked)
            {
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Add the ""WaitToKillServiceTimeout"" value
                echo Adding ""WaitToKillServiceTimeout"" value...
                reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control"" /v ""WaitToKillServiceTimeout"" /t REG_SZ /d ""2000"" /f
                echo Done!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else
            {
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Delete the ""WaitToKillServiceTimeout"" value
                echo Deleting ""WaitToKillServiceTimeout"" value...
                reg delete ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control"" /v ""WaitToKillServiceTimeout"" /f
                echo Done!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
        }

        private void materialSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch7.Checked)
            {
                const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Feeds";
                const string valueName = "EnableFeeds";
                const int value = 0;

                // Set the value in the registry
                Registry.SetValue(keyName, valueName, value, RegistryValueKind.DWord);

                // Get the value from the registry to verify that it was set correctly
                int readValue = (int)Registry.GetValue(keyName, valueName, null);

                if (readValue == value)
                {
                    System.Console.WriteLine("Registry value set and retrieved successfully.");
                }
                else
                {
                    System.Console.WriteLine("Error setting or retrieving registry value.");
                }
            }
            else 
            {
                const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Feeds";
                const string valueName = "EnableFeeds";
                const int value = 1;

                // Set the value in the registry
                Registry.SetValue(keyName, valueName, value, RegistryValueKind.DWord);

                // Get the value from the registry to verify that it was set correctly
                int readValue = (int)Registry.GetValue(keyName, valueName, null);

                if (readValue == value)
                {
                    System.Console.WriteLine("Registry value set and retrieved successfully.");
                }
                else
                {
                    System.Console.WriteLine("Error setting or retrieving registry value.");
                }
            }
        }

        private void materialSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch8.Checked)
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Add the ""AllowGameDVR"" value
                echo Adding ""AllowGameDVR"" value...
                reg add ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement"" /v ""AllowGameDVR"" /t REG_DWORD /d 00000000 /f

                rem Add the ""GameDVR_Enabled"" value
                echo Adding ""GameDVR_Enabled"" value...
                reg add ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_Enabled"" /t REG_DWORD /d 0 /f

                rem Add the ""GameDVR_FSEBehavior"" value
                echo Adding ""GameDVR_FSEBehavior"" value...
                reg add ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_FSEBehavior"" /t REG_DWORD /d 00000002 /f

                rem Add the ""GameDVR_FSEBehaviorMode"" value
                echo Adding ""GameDVR_FSEBehaviorMode"" value...
                reg add ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_FSEBehaviorMode"" /t REG_DWORD /d 00000002 /f

                rem Add the ""AllowGameDVR"" value
                echo Adding ""AllowGameDVR"" value...
                reg add ""HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GameDVR"" /v ""AllowGameDVR"" /t REG_DWORD /d 0 /f
                echo Disabled GameDVR and GameBar Successfully!

                pause
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off
                
                rem Delete the ""AllowGameDVR"" value
                echo Deleting ""AllowGameDVR"" value...
                reg delete ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement"" /v ""AllowGameDVR"" /f

                rem Delete the ""GameDVR_Enabled"" value
                echo Deleting ""GameDVR_Enabled"" value...
                reg delete ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_Enabled"" /f

                rem Delete the ""GameDVR_FSEBehavior"" value
                echo Deleting ""GameDVR_FSEBehavior"" value...
                reg delete ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_FSEBehavior"" /f

                rem Delete the ""GameDVR_FSEBehaviorMode"" value
                echo Deleting ""GameDVR_FSEBehaviorMode"" value...
                reg delete ""HKEY_CURRENT_USER\System\GameConfigStore"" /v ""GameDVR_FSEBehaviorMode"" /f

                rem Delete the ""AllowGameDVR"" value
                echo Deleting ""AllowGameDVR"" value...
                reg delete ""HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GameDVR"" /v ""AllowGameDVR"" /f
                echo Successfully Enabled GameDVR and GameBar!

                pause

                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
        }

        private void materialSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch6.Checked)
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off 
                echo is clearing system junk files, please wait... 
                del /f /s /q %systemdrive%\*.tmp 
                del /f /s /q %systemdrive%\*._mp 
                del /f /s /q %systemdrive%\*.log 
                del /f /s /q %systemdrive%\*.gid 
                del /f /s /q %systemdrive%\*.chk  
                del /f /s /q %systemdrive%\*.old 
                del /f /s /q %systemdrive%\recycled\*.* 
                del /f /s /q %windir%\*.bak 
                del /f /s /q %windir%\prefetch\*.* rd /s /q %windir%\temp & md %windir%\temp 
                echo Temp Files Removed! 
            ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else {
                MessageBox.Show("Sorry This Action Cannot be Reverted!");
            }
        }

        private void materialSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch9.Checked)
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Enable dark mode in Windows
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v AppsUseLightTheme /t REG_DWORD /d 0 /f

                rem Set the color scheme to dark
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v SystemUsesLightTheme /t REG_DWORD /d 0 /f

                rem Set the default app mode to dark
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v DefaultAppMode /t REG_DWORD /d 1 /f
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
            else
            {
                // Create a temporary batch file
                string tempFile = Path.GetTempFileName() + ".bat";

                // Write the batch script to the temporary file
                File.WriteAllText(tempFile, @"
                @echo off

                rem Disable dark mode in Windows
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v AppsUseLightTheme /t REG_DWORD /d 1 /f

                rem Set the color scheme to light
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v SystemUsesLightTheme /t REG_DWORD /d 1 /f

                rem Set the default app mode to light
                reg add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v DefaultAppMode /t REG_DWORD /d 0 /f
                ");

                // Create a new ProcessStartInfo object
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + tempFile;
                startInfo.Verb = "runas";

                // Start the Command Prompt as an administrator and run the batch script
                Process.Start(startInfo);
            }
        }

        private void materialSwitch10_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch10.Checked)
            {
                // Open the "This PC" folder when File Explorer is opened
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}");

                System.Diagnostics.Process.Start("explorer.exe", "/restart");
            }
            else 
            {
                // Restore the default behavior of opening the Quick Access folder when File Explorer is opened
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo", "{679f85cb-0220-4080-b29b-5540cc05aab6}");

                System.Diagnostics.Process.Start("explorer.exe", "/restart");
            }
        }
    }
}