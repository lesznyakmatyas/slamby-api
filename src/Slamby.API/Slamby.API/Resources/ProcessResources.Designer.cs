﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ezt a kódot eszköz generálta.
//     Futásidejű verzió:4.0.30319.42000
//
//     Ennek a fájlnak a módosítása helytelen viselkedést eredményezhet, és elvész, ha
//     a kódot újragenerálják.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slamby.API.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ProcessResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal ProcessResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Slamby.API.Resources.ProcessResources", typeof(ProcessResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Fatal error occured during the operation!.
        /// </summary>
        internal static string FatalErrorOccuredDuringTheOperation {
            get {
                return ResourceManager.GetString("FatalErrorOccuredDuringTheOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid Status! Only the Processes with &apos;InProgress&apos; status can be cancelled!.
        /// </summary>
        internal static string InvalidStatusOnlyProcessesWithInProgressCanBeCancelled {
            get {
                return ResourceManager.GetString("InvalidStatusOnlyProcessesWithInProgressCanBeCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Process with Id &apos;{0}&apos; does not found.
        /// </summary>
        internal static string ProcessWithId_0_DoesNotFound {
            get {
                return ResourceManager.GetString("ProcessWithId_0_DoesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The operation was interrupted unexpectedly!.
        /// </summary>
        internal static string UnexpectedInterruptionError {
            get {
                return ResourceManager.GetString("UnexpectedInterruptionError", resourceCulture);
            }
        }
    }
}
