﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MINHTAM\\SQLEXPRESS;Initial Catalog=QuanLyKaraoke;User ID=sa;Password=" +
            "sa2012")]
        public string QuanLyKaraokeConnectionString {
            get {
                return ((string)(this["QuanLyKaraokeConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-FQDE5LO;Initial Catalog=QuanLyKiTucXa;User ID=sa;Password=123" +
            "456")]
        public string StringConnect {
            get {
                return ((string)(this["StringConnect"]));
            }
            set {
                this["StringConnect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StringUser {
            get {
                return ((string)(this["StringUser"]));
            }
            set {
                this["StringUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StringPass {
            get {
                return ((string)(this["StringPass"]));
            }
            set {
                this["StringPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckLuu {
            get {
                return ((bool)(this["CheckLuu"]));
            }
            set {
                this["CheckLuu"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MINHTAM\\SQLEXPRESS;Initial Catalog=QuanLyKiTucXa;User ID=sa;Password=" +
            "sa2012")]
        public string QuanLyKiTucXaConnectionString {
            get {
                return ((string)(this["QuanLyKiTucXaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-FQDE5LO;Initial Catalog=QuanLyKiTucXa;User ID=sa;Password=123" +
            "456")]
        public string QuanLyKiTucXaConnectionString1 {
            get {
                return ((string)(this["QuanLyKiTucXaConnectionString1"]));
            }
        }
    }
}