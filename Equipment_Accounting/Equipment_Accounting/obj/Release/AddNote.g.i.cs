#pragma checksum "..\..\AddNote.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F23AFAC497EE22C925E686EF4F5D7C9C2E9CC659F7D6FB60464B6A3FF6AC65E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Equipment_Accounting;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Equipment_Accounting {
    
    
    /// <summary>
    /// AddNote
    /// </summary>
    public partial class AddNote : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameT;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IPT;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MACT;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeT;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StateT;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdresT;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteT;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Equipment_Accounting;component/addnote.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNote.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.IPT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MACT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TypeT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StateT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AdresT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NoteT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddNote.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.createB = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddNote.xaml"
            this.createB.Click += new System.Windows.RoutedEventHandler(this.createB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

