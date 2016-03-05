﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.JSchema {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.JSchema.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Generate an enumeration.
        /// </summary>
        internal static string EnumHintName {
            get {
                return ResourceManager.GetString("EnumHintName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot generate a type from a {0} object of type {1}..
        /// </summary>
        internal static string ErrorCannotGenerateAdditionalTypeFromHintType {
            get {
                return ResourceManager.GetString("ErrorCannotGenerateAdditionalTypeFromHintType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The copyright file &quot;{0}&quot; could not be found..
        /// </summary>
        internal static string ErrorCopyrightFileNotFound {
            get {
                return ResourceManager.GetString("ErrorCopyrightFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This schema does not contain the sub-schema definition referred to by the $ref value &quot;{0}&quot;..
        /// </summary>
        internal static string ErrorDefinitionDoesNotExist {
            get {
                return ResourceManager.GetString("ErrorDefinitionDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The enumeration hint for the property {0} does not specify a type name for the generated enumeration..
        /// </summary>
        internal static string ErrorEnumHintRequiresTypeName {
            get {
                return ResourceManager.GetString("ErrorEnumHintRequiresTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} object for the type {1} specifies {2} enum values, but the schema specifies {3} values. The schema and the {0} object must specify the same number of enum values..
        /// </summary>
        internal static string ErrorMismatchedEnumCount {
            get {
                return ResourceManager.GetString("ErrorMismatchedEnumCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} property of this {1} instance is {2}, so it has no class name..
        /// </summary>
        internal static string ErrorNoClassNameForInferredTypeKindPrimitive {
            get {
                return ResourceManager.GetString("ErrorNoClassNameForInferredTypeKindPrimitive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} property of this {1} instance is not {2}, so it has no item type..
        /// </summary>
        internal static string ErrorNoItemTypeForNonArray {
            get {
                return ResourceManager.GetString("ErrorNoItemTypeForNonArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} property of this {1} instance is {2}, so it has no primitive type..
        /// </summary>
        internal static string ErrorNoPrimitiveTypeForInferredTypeKindClassName {
            get {
                return ResourceManager.GetString("ErrorNoPrimitiveTypeForInferredTypeKindClassName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified schema has type=&quot;{0}&quot;. Data model generation requires a schema whose top-level type is &quot;object&quot;..
        /// </summary>
        internal static string ErrorNotAnObject {
            get {
                return ResourceManager.GetString("ErrorNotAnObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This partial implementation of JSON Schema only accepts $ref values in the form of fragments that refer to sub-properties of the &quot;definitions&quot; property, for example &quot;#/definitions/def1&quot;. The URI reference &quot;{0}&quot; is not supported..
        /// </summary>
        internal static string ErrorOnlyDefinitionFragmentsSupported {
            get {
                return ResourceManager.GetString("ErrorOnlyDefinitionFragmentsSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The output directory {0} already exists..
        /// </summary>
        internal static string ErrorOutputDirectoryExists {
            get {
                return ResourceManager.GetString("ErrorOutputDirectoryExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify a non-null, non-blank value for the {0} property of the {1} object..
        /// </summary>
        internal static string ErrorSettingsPropertyMissing {
            get {
                return ResourceManager.GetString("ErrorSettingsPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot call GetText until after you have called FinishClass..
        /// </summary>
        internal static string ErrorTextNotYetGenerated {
            get {
                return ResourceManager.GetString("ErrorTextNotYetGenerated", resourceCulture);
            }
        }
    }
}
