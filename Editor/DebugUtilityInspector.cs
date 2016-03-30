// Copyright (c) 2016 Nora
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php

using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace SA
{

	[CustomEditor( typeof( DebugUtility ) )]
	public class DebugUtilityInspector : Editor
	{
		public override void OnInspectorGUI()
		{
#if UNITY_EDITOR
			var debugUtility = this.target as DebugUtility;

			if( debugUtility._debugValues.Count == 0 ) {
				EditorGUILayout.LabelField( "No debug properties." );
			}

			foreach( var debugValue in debugUtility._debugValues ) {
				var v = debugValue.Value;
				switch( debugValue.Value.valueType ) {
				case DebugUtility.DebugValueType.Int:
					v.intValue = EditorGUILayout.IntField( debugValue.Key, debugValue.Value.intValue );
					break;
				case DebugUtility.DebugValueType.Float:
					if( debugValue.Key.Contains( "Rate" ) ) {
						v.floatValue = EditorGUILayout.Slider( debugValue.Key, debugValue.Value.floatValue, 0.0f, 1.0f );
					} else {
						v.floatValue = EditorGUILayout.FloatField( debugValue.Key, debugValue.Value.floatValue );
					}
					break;
				case DebugUtility.DebugValueType.Bool:
					v.boolValue = EditorGUILayout.Toggle( debugValue.Key, debugValue.Value.boolValue );
					break;
				}
			}
#endif
		}
	}

}