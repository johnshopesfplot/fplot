﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JohnsHope.FPlot.Library.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JohnsHope.FPlot.Library.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Fit.BeginSolve: Another fitting thread is already running..
        /// </summary>
        internal static string AlreadyFittingError {
            get {
                return ResourceManager.GetString("AlreadyFittingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Covariance Matrix is invalid during fitting.
        /// </summary>
        internal static string CovarianceMatrixException {
            get {
                return ResourceManager.GetString("CovarianceMatrixException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong type of IAsyncResult parameter in EndSolve.
        /// </summary>
        internal static string EndSolveException {
            get {
                return ResourceManager.GetString("EndSolveException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change Fitp during calculation..
        /// </summary>
        internal static string FitpException {
            get {
                return ResourceManager.GetString("FitpException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments in routine gammq.
        /// </summary>
        internal static string gammqException {
            get {
                return ResourceManager.GetString("gammqException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in gaussj: Singular Matrix-1.
        /// </summary>
        internal static string gaussjException0 {
            get {
                return ResourceManager.GetString("gaussjException0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in gaussj: Singular Matrix-2.
        /// </summary>
        internal static string gaussjException1 {
            get {
                return ResourceManager.GetString("gaussjException1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to a too large, ITMAX too small in gcf.
        /// </summary>
        internal static string gcfException {
            get {
                return ResourceManager.GetString("gcfException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to x less than 0 in routine gser.
        /// </summary>
        internal static string gserException0 {
            get {
                return ResourceManager.GetString("gserException0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to a too large, ITMAX too small in routine gser.
        /// </summary>
        internal static string gserException1 {
            get {
                return ResourceManager.GetString("gserException1", resourceCulture);
            }
        }
    }
}
