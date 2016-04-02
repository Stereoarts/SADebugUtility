// Copyright (c) 2016 Nora
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php

#if UNITY_EDITOR
#define SADEBUGUTILITY_ENABLED
#endif

using UnityEngine;
using System.Collections.Generic;

public static class SADebugUtilityExtention
{
	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, int v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, float v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, bool v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, Vector3 v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, ref int v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, ref v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, ref float v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, ref v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, ref bool v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, ref v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugValue( this Component component, string name, ref Vector3 v )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugValue( name, ref v );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void ClearDebugPoints( this Component component )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._ClearDebugPoints();
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugCube( this Component component, Vector3 pos )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugCube( pos );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugCube( this Component component, Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugCube( pos, color, size );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugSphere( this Component component, Vector3 pos )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugSphere( pos );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugSphere( this Component component, Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugSphere( pos, color, size );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugWireCube( this Component component, Vector3 pos )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugWireCube( pos );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugWireCube( this Component component, Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugWireCube( pos, color, size );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugWireSphere( this Component component, Vector3 pos )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugWireSphere( pos );
		}
#endif
	}

	[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
	public static void DebugWireSphere( this Component component, Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
	{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		SA.DebugUtility debugUtility = SA.DebugUtility.GetInstance( component );
		if( debugUtility != null ) {
			debugUtility._DebugWireSphere( pos, color, size );
		}
#endif
	}
}

namespace SA
{
	[ExecuteInEditMode]
	public class DebugUtility : MonoBehaviour
	{
		public const float _debugPointDefaultSize = 0.02f;

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, int v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, float v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, bool v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, Vector3 v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, ref int v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, ref v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, ref float v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, ref v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, ref bool v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, ref v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugValue( string name, ref Vector3 v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugValue( name, ref v );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void ClearDebugPoints()
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._ClearDebugPoints();
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugCube( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugCube( pos );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugCube( Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugCube( pos, color, size );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugSphere( pos );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugSphere( Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugSphere( pos, color, size );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugWireCube( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugWireCube( pos );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugWireCube( Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugWireCube( pos, color, size );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugWireSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugWireSphere( pos );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public static void DebugWireSphere( Vector3 pos, Color color, float size = SA.DebugUtility._debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugUtility debugUtility = DebugUtility.instance;
			if( debugUtility != null ) {
				debugUtility._DebugWireSphere( pos, color, size );
			}
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, int v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				debugValue.intValue = v;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, float v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				debugValue.floatValue = v;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, bool v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				debugValue.boolValue = v;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, Vector3 v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				debugValue.vector3Value = v;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref int v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.intValue;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref float v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.floatValue;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref bool v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.boolValue;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref Vector3 v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			__DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.vector3Value;
				return;
			}

			_debugValues.Add( name, new __DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _ClearDebugPoints()
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Clear();
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugCube( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.Cube, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugCube( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.Cube, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.Sphere, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugSphere( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.Sphere, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireCube( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.WireCube, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireCube( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.WireCube, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.WireSphere, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireSphere( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new __DebugPoint( __DebugPointType.WireSphere, pos, color, size ) );
#endif
		}

		public static DebugUtility GetInstance( Component component )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			return (component != null) ? GetInstance( component.gameObject ) : null;
#else
			return null;
#endif
		}

		public static DebugUtility GetInstance( GameObject gameObject )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			if( gameObject != null ) {
				DebugUtility v;
				if( _instances.TryGetValue( gameObject, out v ) ) {
					return v;
				}

				v = gameObject.GetComponent<DebugUtility>();
				if( v == null ) {
					v = gameObject.AddComponent<DebugUtility>();
				}

				_instances.Add( gameObject, v );
				return v;
			}
#endif
			return null;
		}

#if UNITY_EDITOR
		static DebugUtility _instance; // for Singleton

		static DebugUtility instance
		{
			get
			{
				if( _instance == null ) {
					_instance = Object.FindObjectOfType<DebugUtility>();
					if( _instance == null ) {
						GameObject go = new GameObject("SADebugUtility");
						_instance = go.AddComponent<DebugUtility>();
						_instances.Add( go, _instance ); // Add directly.
                        GameObject.DontDestroyOnLoad( go );
					}
				}

				return _instance;
			}
		}

		public enum __DebugValueType
		{
			Int,
			Float,
			Bool,
			Vector3,
		}

		public class __DebugValue
		{
			public __DebugValueType valueType;

			public int intValue;
			public float floatValue;
			public bool boolValue;
			public Vector3 vector3Value;

			public __DebugValue( int i )
			{
				this.valueType = __DebugValueType.Int;
				this.boolValue = false;
			}

			public __DebugValue( float f )
			{
				this.valueType = __DebugValueType.Float;
				this.floatValue = f;
			}

			public __DebugValue( bool b )
			{
				this.valueType = __DebugValueType.Bool;
				this.boolValue = b;
			}

			public __DebugValue( Vector3 v )
			{
				this.valueType = __DebugValueType.Vector3;
				this.vector3Value = v;
			}
		}

		public enum __DebugPointType
		{
			Cube,
			Sphere,
			WireCube,
			WireSphere,
		}

		public struct __DebugPoint
		{
			static readonly Color _debugPointDefaultColor = Color.red;

			public __DebugPointType type;
			public Vector3 pos;
			public Color color;
			public float size;

			public __DebugPoint( __DebugPointType type_, Vector3 pos_ )
			{
				type = type_;
				pos = pos_;
				color = _debugPointDefaultColor;
				size = _debugPointDefaultSize;
			}

			public __DebugPoint( __DebugPointType type_, Vector3 pos_, Color color_, float size_ = _debugPointDefaultSize )
			{
				type = type_;
				pos = pos_;
				color = color_;
				size = size_;
			}
		}

		[System.NonSerialized]
		public Dictionary<string, __DebugValue> _debugValues = new Dictionary<string, __DebugValue>();
		[System.NonSerialized]
		public List<__DebugPoint> _debugPoints = new List<__DebugPoint>();

		void OnDestroy()
		{
			_instances.Remove( this.gameObject );

			if( _instance == this ) {
				_instance = null;
            }
		}

		static Dictionary<GameObject, DebugUtility> _instances = new Dictionary<GameObject, DebugUtility>();

		void OnDrawGizmos()
		{
			for( int i = 0; i != _debugPoints.Count; ++i ) {
				__DebugPoint debugPoint = _debugPoints[i];
				Gizmos.color = debugPoint.color;
                switch( debugPoint.type ) {
				case __DebugPointType.Cube:
					Gizmos.DrawCube( debugPoint.pos, new Vector3( debugPoint.size, debugPoint.size, debugPoint.size ) );
					break;
				case __DebugPointType.Sphere:
					Gizmos.DrawSphere( debugPoint.pos, debugPoint.size );
					break;
				case __DebugPointType.WireCube:
					Gizmos.DrawWireCube( debugPoint.pos, new Vector3( debugPoint.size, debugPoint.size, debugPoint.size ) );
					break;
				case __DebugPointType.WireSphere:
					Gizmos.DrawWireSphere( debugPoint.pos, debugPoint.size );
					break;
				}
			}
		}
#endif
	}
}