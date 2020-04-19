using System;
using System.Reflection;
using UnityEditor;
using UnityEngine.Events;

namespace UniEditorApplicationInternal
{
	public static class EditorApplicationInternal
	{
		private const BindingFlags BINDING_ATTR = BindingFlags.Static | BindingFlags.NonPublic;

		private static readonly Type      m_type                            = typeof( EditorApplication );
		private static readonly FieldInfo m_projectWasLoaded                = m_type.GetField( "projectWasLoaded", BINDING_ATTR );
		private static readonly FieldInfo m_editorApplicationQuit           = m_type.GetField( "editorApplicationQuit", BINDING_ATTR );
		private static readonly FieldInfo m_refreshHierarchy                = m_type.GetField( "refreshHierarchy", BINDING_ATTR );
		private static readonly FieldInfo m_dirtyHierarchySorting           = m_type.GetField( "dirtyHierarchySorting", BINDING_ATTR );
		private static readonly FieldInfo m_assetLabelsChanged              = m_type.GetField( "assetLabelsChanged", BINDING_ATTR );
		private static readonly FieldInfo m_assetBundleNameChanged          = m_type.GetField( "assetBundleNameChanged", BINDING_ATTR );
		private static readonly FieldInfo m_globalEventHandler              = m_type.GetField( "globalEventHandler", BINDING_ATTR );
		private static readonly FieldInfo m_doPressedKeysTriggerAnyShortcut = m_type.GetField( "doPressedKeysTriggerAnyShortcut", BINDING_ATTR );
		private static readonly FieldInfo m_focusChanged                    = m_type.GetField( "focusChanged", BINDING_ATTR );
		private static readonly FieldInfo m_windowsReordered                = m_type.GetField( "windowsReordered", BINDING_ATTR );

		public static UnityAction projectWasLoaded
		{
			get => m_projectWasLoaded.GetValue( null ) as UnityAction;
			set => m_projectWasLoaded.SetValue( null, value );
		}

		public static UnityAction editorApplicationQuit
		{
			get => m_editorApplicationQuit.GetValue( null ) as UnityAction;
			set => m_editorApplicationQuit.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction refreshHierarchy
		{
			get => m_refreshHierarchy.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_refreshHierarchy.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction dirtyHierarchySorting
		{
			get => m_dirtyHierarchySorting.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_dirtyHierarchySorting.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction assetLabelsChanged
		{
			get => m_assetLabelsChanged.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_assetLabelsChanged.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction assetBundleNameChanged
		{
			get => m_assetBundleNameChanged.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_assetBundleNameChanged.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction globalEventHandler
		{
			get => m_globalEventHandler.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_globalEventHandler.SetValue( null, value );
		}

		public static Func<bool> doPressedKeysTriggerAnyShortcut
		{
			get => m_doPressedKeysTriggerAnyShortcut.GetValue( null ) as Func<bool>;
			set => m_doPressedKeysTriggerAnyShortcut.SetValue( null, value );
		}

		public static Action<bool> focusChanged
		{
			get => m_focusChanged.GetValue( null ) as Action<bool>;
			set => m_focusChanged.SetValue( null, value );
		}

		public static EditorApplication.CallbackFunction windowsReordered
		{
			get => m_windowsReordered.GetValue( null ) as EditorApplication.CallbackFunction;
			set => m_windowsReordered.SetValue( null, value );
		}
	}
}