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
    ///The ValidateGroup recording.
    /// </summary>
    [TestModule("069e8305-2efe-4185-83c4-e100c1ad273e", ModuleType.Recording, 1)]
    public partial class ValidateGroup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static global::KeePassTestSuite.KeePassTestSuiteRepository repo = global::KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static ValidateGroup instance = new ValidateGroup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateGroup()
        {
            varGroupName = "Ranorex";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateGroup Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varGroupName.
        /// </summary>
        [TestVariable("efec13be-47b2-451f-8692-e549f975827a")]
        public string varGroupName
        {
            get { return repo.varGroupName; }
            set { repo.varGroupName = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$varGroupName) on item 'MainForm.Categories.CategoryRanorex'.", repo.MainForm.Categories.CategoryRanorexInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MainForm.Categories.CategoryRanorexInfo, "Text", varGroupName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
