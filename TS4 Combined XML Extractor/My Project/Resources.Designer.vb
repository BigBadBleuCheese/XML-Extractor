﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("TS4_Combined_XML_Extractor.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Icon ähnlich wie (Symbol).
        '''</summary>
        Friend ReadOnly Property ico256() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ico256", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Icon ähnlich wie (Symbol).
        '''</summary>
        Friend ReadOnly Property ico32() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ico32", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Icon ähnlich wie (Symbol).
        '''</summary>
        Friend ReadOnly Property ico48() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ico48", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Icon ähnlich wie (Symbol).
        '''</summary>
        Friend ReadOnly Property ico64() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ico64", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die &lt;GAMEPACKS&gt;
        '''	&lt;PACK&gt;
        '''		&lt;SHORTNAME&gt;BG&lt;/SHORTNAME&gt;
        '''		&lt;LONGNAME&gt;Base Game&lt;/LONGNAME&gt;
        '''		&lt;VALUE&gt;0&lt;/VALUE&gt;
        '''	&lt;/PACK&gt;
        '''	&lt;PACK&gt;
        '''		&lt;SHORTNAME&gt;SP01&lt;/SHORTNAME&gt;
        '''		&lt;LONGNAME&gt;Luxury Party Stuff&lt;/LONGNAME&gt;
        '''		&lt;VALUE&gt;1&lt;/VALUE&gt;
        '''	&lt;/PACK&gt;
        '''	&lt;PACK&gt;
        '''		&lt;SHORTNAME&gt;GP01&lt;/SHORTNAME&gt;
        '''		&lt;LONGNAME&gt;Outdoor Retreat&lt;/LONGNAME&gt;
        '''		&lt;VALUE&gt;2&lt;/VALUE&gt;
        '''	&lt;/PACK&gt;
        '''	&lt;PACK&gt;
        '''		&lt;SHORTNAME&gt;EP01&lt;/SHORTNAME&gt;
        '''		&lt;LONGNAME&gt;Get to Work&lt;/LONGNAME&gt;
        '''		&lt;VALUE&gt;3&lt;/VALUE&gt;
        '''	&lt;/PACK&gt;
        '''	&lt;PACK&gt;
        '''		&lt;SHORTNAME&gt;FP01&lt;/SHORTNAME&gt;
        '''		&lt;LONGNAME&gt;Holiday Celebrat [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property xmlGPData() As String
            Get
                Return ResourceManager.GetString("xmlGPData", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
