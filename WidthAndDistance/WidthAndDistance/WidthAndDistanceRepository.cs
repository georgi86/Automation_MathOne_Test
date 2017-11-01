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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace WidthAndDistance
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WidthAndDistanceRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("496e57b7-0ab0-437d-a04d-e770a7371166")]
    public partial class WidthAndDistanceRepository : RepoGenBaseFolder
    {
        static WidthAndDistanceRepository instance = new WidthAndDistanceRepository();
        WidthAndDistanceRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        WidthAndDistanceRepositoryFolders.OpenSnapXRoutineAppFolder _opensnapxroutine;
        WidthAndDistanceRepositoryFolders.SnapXConstructMxyAppFolder _snapxconstructmxy;
        WidthAndDistanceRepositoryFolders.ConstructSTANotepadAppFolder _constructstanotepad;

        /// <summary>
        /// Gets the singleton class instance representing the WidthAndDistanceRepository element repository.
        /// </summary>
        [RepositoryFolder("496e57b7-0ab0-437d-a04d-e770a7371166")]
        public static WidthAndDistanceRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WidthAndDistanceRepository() 
            : base("WidthAndDistanceRepository", "/", null, 0, false, "496e57b7-0ab0-437d-a04d-e770a7371166", ".\\RepositoryImages\\WidthAndDistanceRepository496e57b7.rximgres")
        {
            _snapxuntitled = new WidthAndDistanceRepositoryFolders.SnapXUntitledAppFolder(this);
            _opensnapxroutine = new WidthAndDistanceRepositoryFolders.OpenSnapXRoutineAppFolder(this);
            _snapxconstructmxy = new WidthAndDistanceRepositoryFolders.SnapXConstructMxyAppFolder(this);
            _constructstanotepad = new WidthAndDistanceRepositoryFolders.ConstructSTANotepadAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("496e57b7-0ab0-437d-a04d-e770a7371166")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("5fd40d4d-5600-49dc-934c-f8fa8cb94309")]
        public virtual WidthAndDistanceRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The OpenSnapXRoutine folder.
        /// </summary>
        [RepositoryFolder("7cd3cfa6-c28c-4856-9746-10ef18a02b47")]
        public virtual WidthAndDistanceRepositoryFolders.OpenSnapXRoutineAppFolder OpenSnapXRoutine
        {
            get { return _opensnapxroutine; }
        }

        /// <summary>
        /// The SnapXConstructMxy folder.
        /// </summary>
        [RepositoryFolder("228613af-a3d6-4006-a16d-c15de565223b")]
        public virtual WidthAndDistanceRepositoryFolders.SnapXConstructMxyAppFolder SnapXConstructMxy
        {
            get { return _snapxconstructmxy; }
        }

        /// <summary>
        /// The ConstructSTANotepad folder.
        /// </summary>
        [RepositoryFolder("02679507-459c-4395-b784-4efdf0a9c6ae")]
        public virtual WidthAndDistanceRepositoryFolders.ConstructSTANotepadAppFolder ConstructSTANotepad
        {
            get { return _constructstanotepad; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class WidthAndDistanceRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("5fd40d4d-5600-49dc-934c-f8fa8cb94309")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _snapxuntitledInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXUntitled", "/form[@title='Snap-X - [Untitled]']", parentFolder, 30000, null, true, "5fd40d4d-5600-49dc-934c-f8fa8cb94309", "")
            {
                _snapxuntitledInfo = new RepoItemInfo(this, "SnapXUntitled", "titlebar[@accessiblerole='TitleBar']", 30000, null, "6d754965-0077-4668-9a2f-dd6972c8b823");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5fd40d4d-5600-49dc-934c-f8fa8cb94309")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5fd40d4d-5600-49dc-934c-f8fa8cb94309")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SnapXUntitled item.
            /// </summary>
            [RepositoryItem("6d754965-0077-4668-9a2f-dd6972c8b823")]
            public virtual Ranorex.TitleBar SnapXUntitled
            {
                get
                {
                    return _snapxuntitledInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The SnapXUntitled item info.
            /// </summary>
            [RepositoryItemInfo("6d754965-0077-4668-9a2f-dd6972c8b823")]
            public virtual RepoItemInfo SnapXUntitledInfo
            {
                get
                {
                    return _snapxuntitledInfo;
                }
            }
        }

        /// <summary>
        /// The OpenSnapXRoutineAppFolder folder.
        /// </summary>
        [RepositoryFolder("7cd3cfa6-c28c-4856-9746-10ef18a02b47")]
        public partial class OpenSnapXRoutineAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text1148Info;

            /// <summary>
            /// Creates a new OpenSnapXRoutine  folder.
            /// </summary>
            public OpenSnapXRoutineAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OpenSnapXRoutine", "/form[@title='Open Snap-X Routine']", parentFolder, 30000, null, true, "7cd3cfa6-c28c-4856-9746-10ef18a02b47", "")
            {
                _text1148Info = new RepoItemInfo(this, "Text1148", "?/?/text[@controlid='1148']", 30000, null, "e104e411-b618-488f-b0e0-c878864de912");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7cd3cfa6-c28c-4856-9746-10ef18a02b47")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7cd3cfa6-c28c-4856-9746-10ef18a02b47")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text1148 item.
            /// </summary>
            [RepositoryItem("e104e411-b618-488f-b0e0-c878864de912")]
            public virtual Ranorex.Text Text1148
            {
                get
                {
                    return _text1148Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1148 item info.
            /// </summary>
            [RepositoryItemInfo("e104e411-b618-488f-b0e0-c878864de912")]
            public virtual RepoItemInfo Text1148Info
            {
                get
                {
                    return _text1148Info;
                }
            }
        }

        /// <summary>
        /// The SnapXConstructMxyAppFolder folder.
        /// </summary>
        [RepositoryFolder("228613af-a3d6-4006-a16d-c15de565223b")]
        public partial class SnapXConstructMxyAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _snapxconstructmxyInfo;
            RepoItemInfo _buttonokInfo;
            RepoItemInfo _buttonnewInfo;
            RepoItemInfo _finishInfo;

            /// <summary>
            /// Creates a new SnapXConstructMxy  folder.
            /// </summary>
            public SnapXConstructMxyAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SnapXConstructMxy", "/form[@title='Snap-X - [Construct.mxy]']", parentFolder, 30000, null, true, "228613af-a3d6-4006-a16d-c15de565223b", "")
            {
                _snapxconstructmxyInfo = new RepoItemInfo(this, "SnapXConstructMxy", "titlebar[@accessiblerole='TitleBar']", 30000, null, "12a61b01-96f3-475e-9ec0-1b1aea82d884");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "container/form//button[@text='&OK' and @controlid='1148']", 30000, null, "ab312d71-b386-46db-b1c3-780bd1558415");
                _buttonnewInfo = new RepoItemInfo(this, "ButtonNew", "container/form//container/toolbar/button[@text='New' and @commandid='57600']", 30000, null, "b9187499-ba37-427b-b103-44b5351d9688");
                _finishInfo = new RepoItemInfo(this, "Finish", "container/form/?/?/element/element/container/button[@text='Finish' and @controlid='3165']", 30000, null, "3bece437-03bc-4c10-b24d-c9ccc33623d8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("228613af-a3d6-4006-a16d-c15de565223b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("228613af-a3d6-4006-a16d-c15de565223b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SnapXConstructMxy item.
            /// </summary>
            [RepositoryItem("12a61b01-96f3-475e-9ec0-1b1aea82d884")]
            public virtual Ranorex.TitleBar SnapXConstructMxy
            {
                get
                {
                    return _snapxconstructmxyInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The SnapXConstructMxy item info.
            /// </summary>
            [RepositoryItemInfo("12a61b01-96f3-475e-9ec0-1b1aea82d884")]
            public virtual RepoItemInfo SnapXConstructMxyInfo
            {
                get
                {
                    return _snapxconstructmxyInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("ab312d71-b386-46db-b1c3-780bd1558415")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("ab312d71-b386-46db-b1c3-780bd1558415")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }

            /// <summary>
            /// The ButtonNew item.
            /// </summary>
            [RepositoryItem("b9187499-ba37-427b-b103-44b5351d9688")]
            public virtual Ranorex.Button ButtonNew
            {
                get
                {
                    return _buttonnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonNew item info.
            /// </summary>
            [RepositoryItemInfo("b9187499-ba37-427b-b103-44b5351d9688")]
            public virtual RepoItemInfo ButtonNewInfo
            {
                get
                {
                    return _buttonnewInfo;
                }
            }

            /// <summary>
            /// The Finish item.
            /// </summary>
            [RepositoryItem("3bece437-03bc-4c10-b24d-c9ccc33623d8")]
            public virtual Ranorex.Button Finish
            {
                get
                {
                    return _finishInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Finish item info.
            /// </summary>
            [RepositoryItemInfo("3bece437-03bc-4c10-b24d-c9ccc33623d8")]
            public virtual RepoItemInfo FinishInfo
            {
                get
                {
                    return _finishInfo;
                }
            }
        }

        /// <summary>
        /// The ConstructSTANotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("02679507-459c-4395-b784-4efdf0a9c6ae")]
        public partial class ConstructSTANotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new ConstructSTANotepad  folder.
            /// </summary>
            public ConstructSTANotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ConstructSTANotepad", "/form[@title='Construct.STA - Notepad']", parentFolder, 30000, null, true, "02679507-459c-4395-b784-4efdf0a9c6ae", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "d59712e6-9ac2-424e-877b-aa60a8c1f49c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("02679507-459c-4395-b784-4efdf0a9c6ae")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("02679507-459c-4395-b784-4efdf0a9c6ae")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("d59712e6-9ac2-424e-877b-aa60a8c1f49c")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("d59712e6-9ac2-424e-877b-aa60a8c1f49c")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

    }
#pragma warning restore 0436
}