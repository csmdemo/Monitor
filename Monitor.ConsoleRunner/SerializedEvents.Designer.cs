﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitor.ConsoleRunner {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SerializedEvents {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SerializedEvents() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Monitor.ConsoleRunner.SerializedEvents", typeof(SerializedEvents).Assembly);
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
        ///   Looks up a localized string similar to [{&quot;Id&quot;:&quot;fde3f499-a588-48b9-a8b5-29f5f2ec0df5&quot;,&quot;Title&quot;:&quot;Recurring&quot;,&quot;EventCategory&quot;:{&quot;Id&quot;:&quot;8c818910-8a62-4f75-805a-8aa0cb887956&quot;,&quot;Name&quot;:&quot;Payment&quot;},&quot;Content&quot;:&quot;New Membership&quot;,&quot;DateTimeUtc&quot;:&quot;2014-03-09T17:41:20.7233558Z&quot;},{&quot;Id&quot;:&quot;7c2bd401-78f9-4364-8e4e-795dd9567a9d&quot;,&quot;Title&quot;:&quot;Non-Recurring&quot;,&quot;EventCategory&quot;:{&quot;Id&quot;:&quot;8c818910-8a62-4f75-805a-8aa0cb887956&quot;,&quot;Name&quot;:&quot;Payment&quot;},&quot;Content&quot;:&quot;New Ball Bearings&quot;,&quot;DateTimeUtc&quot;:&quot;2014-03-09T17:40:20.7233558Z&quot;},{&quot;Id&quot;:&quot;81b787dd-9e8f-49d7-8f07-126ac3cd1b7e&quot;,&quot;Title&quot;:&quot;Non-Recurring&quot;,&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Payments {
            get {
                return ResourceManager.GetString("Payments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;Id&quot;:&quot;25a9b180-f588-4a69-9760-036873677633&quot;,&quot;Title&quot;:&quot;Authentication Failure&quot;,&quot;EventCategory&quot;:{&quot;Id&quot;:&quot;d72ca9cf-8742-4cb2-a48e-c495239d8ede&quot;,&quot;Name&quot;:&quot;Website Errors&quot;},&quot;Content&quot;:&quot;Login Failed for user xyx&quot;,&quot;DateTimeUtc&quot;:&quot;2014-03-09T17:44:32.6043584Z&quot;},{&quot;Id&quot;:&quot;f1a840d2-ab81-40db-b4f1-9919bdc72e05&quot;,&quot;Title&quot;:&quot;Db Timeout&quot;,&quot;EventCategory&quot;:{&quot;Id&quot;:&quot;d72ca9cf-8742-4cb2-a48e-c495239d8ede&quot;,&quot;Name&quot;:&quot;Website Errors&quot;},&quot;Content&quot;:&quot;Db timeout occured on the checkout page&quot;,&quot;DateTimeUtc&quot;:&quot;2014-03-09T17:43:32.6043584Z&quot;},{&quot;Id&quot;:&quot;bd4d5e [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WebsiteErrors {
            get {
                return ResourceManager.GetString("WebsiteErrors", resourceCulture);
            }
        }
    }
}