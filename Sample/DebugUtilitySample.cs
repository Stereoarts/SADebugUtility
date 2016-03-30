// Copyright (c) 2016 Nora
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
public class DebugUtilitySample : MonoBehaviour
{
	void Update()
	{
		int _debugInteger = 1234;
		float _debugFloat = 1.0f;
		bool _debugFlag = true;
		float _debugRate = 0.5f;

#if true
		// TypeA : Method Extension
		this.DebugValue( "_debugInteger", ref _debugInteger );
		this.DebugValue( "_debugFloat", ref _debugFloat );
		this.DebugValue( "_debugFlag", ref _debugFlag );
		this.DebugValue( "_debugRate", ref _debugRate );
		this.ClearDebugPoints();
		this.DebugSphere( this.transform.position, Color.red, 1.0f * _debugFloat * _debugRate );
#else
		// TypeB : Call directlly.
		var debugUtility = SA.DebugUtility.GetInstance( this );
		if( debugUtility != null ) {
			debugUtility._DebugValue( "_debugInteger", ref _debugInteger );
			debugUtility._DebugValue( "_debugFloat", ref _debugFloat );
			debugUtility._DebugValue( "_debugFlag", ref _debugFlag );
			debugUtility._DebugValue( "_debugRate", ref _debugRate );
			debugUtility._ClearDebugPoints();
            debugUtility._DebugSphere( this.transform.position, Color.red, 1.0f * _debugFloat * _debugRate );
		}
#endif
	}
}
#endif
