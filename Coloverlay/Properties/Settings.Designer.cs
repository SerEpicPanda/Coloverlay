﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coloverlay.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200,200")]
        public global::System.Drawing.Point WindowPos
        {
            get
            {
                return ((global::System.Drawing.Point)(this["WindowPos"]));
            }
            set
            {
                this["WindowPos"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public global::System.Int32 Width
        {
            get
            {
                return ((global::System.Int32)(this["Width"]));
            }
            set
            {
                this["Width"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public global::System.Int32 Height
        {
            get
            {
                return ((global::System.Int32)(this["Height"]));
            }
            set
            {
                this["Height"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public global::System.Boolean FirstTime
        {
            get
            {
                return ((global::System.Boolean)(this["FirstTime"]));
            }
            set
            {
                this["FirstTime"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 192, 192")]
        public global::System.Drawing.Color OverlayColor {
            get {
                return ((global::System.Drawing.Color)(this["OverlayColor"]));
            }
            set {
                this["OverlayColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double OverlayOpacity {
            get {
                return ((double)(this["OverlayOpacity"]));
            }
            set {
                this["OverlayOpacity"] = value;
            }
        }
    }
}
