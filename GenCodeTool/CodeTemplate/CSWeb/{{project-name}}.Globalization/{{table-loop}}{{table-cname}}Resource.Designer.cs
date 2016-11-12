﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace {{project:namespace}}.Globalization {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class {{table:cname}}Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal {{table:cname}}Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("{{project:namespace}}.Globalization.{{table:cname}}Resource", typeof({{table:cname}}Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        {{loop:col}}
        /// <summary>
        ///   查找类似 {{col:comment}} 的本地化字符串。
        /// </summary>
        public static string {{col:pname}} {
            get {
                return ResourceManager.GetString("{{col:pname}}", resourceCulture);
            }
        }
        {{/loop:col}}
        /// <summary>
        ///   查找类似 外键错误 的本地化字符串。
        /// </summary>
        public static string ErrorFK {
            get {
                return ResourceManager.GetString("ErrorFK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 唯一性错误 的本地化字符串。
        /// </summary>
        public static string ErrorUQ {
            get {
                return ResourceManager.GetString("ErrorUQ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未添加成功 的本地化字符串。
        /// </summary>
        public static string ErrorNoAdd {
            get {
                return ResourceManager.GetString("ErrorNoAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 记录版本已变更 的本地化字符串。
        /// </summary>
        public static string ErrorVersionChanged {
            get {
                return ResourceManager.GetString("ErrorVersionChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未更新成功 的本地化字符串。
        /// </summary>
        public static string ErrorNoUpdate {
            get {
                return ResourceManager.GetString("ErrorNoUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 新建 的本地化字符串。
        /// </summary>
        public static string Add {
            get {
                return ResourceManager.GetString("Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 修改 的本地化字符串。
        /// </summary>
        public static string Edit {
            get {
                return ResourceManager.GetString("Edit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 删除 的本地化字符串。
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 查询 的本地化字符串。
        /// </summary>
        public static string Search {
            get {
                return ResourceManager.GetString("Search", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 查看 的本地化字符串。
        /// </summary>
        public static string View {
            get {
                return ResourceManager.GetString("View", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 导入 的本地化字符串。
        /// </summary>
        public static string Import {
            get {
                return ResourceManager.GetString("Import", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 导出 的本地化字符串。
        /// </summary>
        public static string Export {
            get {
                return ResourceManager.GetString("Export", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 确认删除 的本地化字符串。
        /// </summary>
        public static string ConfirmDelete {
            get {
                return ResourceManager.GetString("ConfirmDelete", resourceCulture);
            }
        }

        /// <summary>
        ///   查找类似 新建失败 的本地化字符串。
        /// </summary>
        public static string AddFail {
            get {
                return ResourceManager.GetString("AddFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更新失败 的本地化字符串。
        /// </summary>
        public static string UpdateFail {
            get {
                return ResourceManager.GetString("UpdateFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 删除失败 的本地化字符串。
        /// </summary>
        public static string DeleteFail {
            get {
                return ResourceManager.GetString("DeleteFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 新建成功 的本地化字符串。
        /// </summary>
        public static string AddSuccess {
            get {
                return ResourceManager.GetString("AddSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更新成功 的本地化字符串。
        /// </summary>
        public static string UpdateSuccess {
            get {
                return ResourceManager.GetString("UpdateSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 删除成功 的本地化字符串。
        /// </summary>
        public static string DeleteSuccess {
            get {
                return ResourceManager.GetString("DeleteSuccess", resourceCulture);
            }
        }
    }
}