﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AoEBalancingTool.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
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
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AoEBalancingTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die 0=0 - Unused
        ///1=1 - Infantry
        ///2=2 - Turtle Ships
        ///3=3 - Base Pierce
        ///4=4 - Base Melee
        ///5=5 - War Elephants
        ///6=6 - Unused
        ///7=7 - Unused
        ///8=8 - Cavalry
        ///9=9 - Unused
        ///10=10 - Unused
        ///11=11 - All Buildings (except Port)
        ///12=12 - Unused
        ///13=13 - Stone Defense
        ///14=14 - Unused
        ///15=15 - Archers
        ///16=16 - Ships &amp; Camels &amp; Saboteurs
        ///17=17 - Rams
        ///18=18 - Trees
        ///19=19 - Unique Units (except Turtle Ship)
        ///20=20 - Siege Weapons
        ///21=21 - Standard Buildings
        ///22=22 - Walls &amp; Gates
        ///23=23 - Unused
        ///24=24 - Boars
        ///25=25 - M [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string ArmorClasses {
            get {
                return ResourceManager.GetString("ArmorClasses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Ressource vom Typ System.Byte[].
        /// </summary>
        internal static byte[] pal50500 {
            get {
                object obj = ResourceManager.GetObject("pal50500", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die -1=None
        ///0=Food Storage
        ///1=Wood Storage
        ///2=Stone Storage
        ///3=Gold Storage 
        ///4=Population Headroom
        ///5=Conversion Range
        ///6=Current Age
        ///7=Relics Captured
        ///8=Trade Bonus
        ///9=Trade Goods
        ///10=Trade Production
        ///11=Current Population
        ///12=Corpse Decay Time
        ///13=Discovery
        ///14=Monuments Captured
        ///15=Meat Storage
        ///16=Berry Storage
        ///17=Fish Storage
        ///18=Unknown
        ///19=Total Units Owned
        ///20=Units Killed
        ///21=Tech Count
        ///22=% Map Explored
        ///23=Castle Age tech ID
        ///24=Imperial Age tech ID
        ///25=Feudal Age tech ID
        ///26=Attack Warning S [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string ResourceTypes {
            get {
                return ResourceManager.GetString("ResourceTypes", resourceCulture);
            }
        }
    }
}
