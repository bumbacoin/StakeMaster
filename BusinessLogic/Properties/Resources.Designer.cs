﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StakeMaster.BusinessLogic.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StakeMaster.BusinessLogic.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument:.
        /// </summary>
        internal static string SettingsArgumentInvalidException_Argument_Name {
            get {
                return ResourceManager.GetString("SettingsArgumentInvalidException_Argument_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument given is invalid or unknown in the current context..
        /// </summary>
        internal static string SettingsArgumentInvalidException_Generic {
            get {
                return ResourceManager.GetString("SettingsArgumentInvalidException_Generic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StakeMaster commandline arguments:.
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_Header {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1}Please check your settings..
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_InvalidArgument_Text {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_InvalidArgument_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General settings{0}-? or --help: Displays this help{0}{0}Settings regarding the stake function{0}-s=&lt;true/false&gt; or --stakes=&lt;true/false&gt;  : Enables or disables modifications of inputs at the stake address. Default: true{0}-a=&lt;address&gt; or --stakeaddress=&lt;addres&gt;   : Sets the dedicated stake address. Mandatory.{0}-c=&lt;address&gt; or --collectaddress=&lt;address&gt;: Sets the dedicated collect address. Mandatory.{0}{0}Settings regarding all other addresses in the wallet{0}-i=&lt;true/false&gt; or --collectinputs=&lt;true/false&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_Text {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_Text", resourceCulture);
            }
        }
    }
}
