﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace KeePassTestSuite.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartSUT recording.
    /// </summary>
    [TestModule("3bf45418-e728-424a-b8a5-27a733ae62b0", ModuleType.Recording, 1)]
    public partial class StartSUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static global::KeePassTestSuite.KeePassTestSuiteRepository repo = global::KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static StartSUT instance = new StartSUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartSUT()
        {
            varApplicationPath = "..\\..\\KeePass\\\\KeePass.exe";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartSUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _varApplicationPath;

        /// <summary>
        /// Gets or sets the value of variable varApplicationPath.
        /// </summary>
        [TestVariable("10cd0224-7644-4ec2-be91-a18ab45bdfe2")]
        public string varApplicationPath
        {
            get { return _varApplicationPath; }
            set { _varApplicationPath = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $varApplicationPath in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(varApplicationPath, "", "", false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
