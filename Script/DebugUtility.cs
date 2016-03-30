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
		public void _DebugValue( string name, ref int v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.intValue;
				return;
			}

			_debugValues.Add( name, new DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref float v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.floatValue;
				return;
			}

			_debugValues.Add( name, new DebugValue( v ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugValue( string name, ref bool v )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			DebugValue debugValue;
			if( _debugValues.TryGetValue( name, out debugValue ) ) {
				v = debugValue.boolValue;
				return;
			}

			_debugValues.Add( name, new DebugValue( v ) );
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
			_debugPoints.Add( new DebugPoint( DebugPointType.Cube, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugCube( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.Cube, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.Sphere, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugSphere( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.Sphere, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireCube( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.WireCube, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireCube( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.WireCube, pos, color, size ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireSphere( Vector3 pos )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.WireSphere, pos ) );
#endif
		}

		[System.Diagnostics.Conditional( "SADEBUGUTILITY_ENABLED" )]
		public void _DebugWireSphere( Vector3 pos, Color color, float size = _debugPointDefaultSize )
		{
#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
			_debugPoints.Add( new DebugPoint( DebugPointType.WireSphere, pos, color, size ) );
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

#if UNITY_EDITOR && SADEBUGUTILITY_ENABLED
		public enum DebugValueType
		{
			Int,
			Float,
			Bool,
		}

		public class DebugValue
		{
			public DebugValueType valueType;

			public int intValue;
			public float floatValue;
			public bool boolValue;

			public DebugValue( int i )
			{
				this.valueType = DebugValueType.Int;
				this.intValue = i;
				this.floatValue = (float)i;
				this.boolValue = (i != 0);
			}

			public DebugValue( float f )
			{
				this.valueType = DebugValueType.Float;
				this.intValue = (int)f;
				this.floatValue = f;
				this.boolValue = (f != 0.0f);
			}

			public DebugValue( bool b )
			{
				this.valueType = DebugValueType.Bool;
				this.intValue = b ? 1 : 0;
				this.floatValue = b ? 1.0f : 0.0f;
				this.boolValue = b;
			}
		}

		public enum DebugPointType
		{
			Cube,
			Sphere,
			WireCube,
			WireSphere,
		}

		public struct DebugPoint
		{
			static readonly Color _debugPointDefaultColor = Color.red;

			public DebugPointType type;
			public Vector3 pos;
			public Color color;
			public float size;

			public DebugPoint( DebugPointType type_, Vector3 pos_ )
			{
				type = type_;
				pos = pos_;
				color = _debugPointDefaultColor;
				size = _debugPointDefaultSize;
			}

			public DebugPoint( DebugPointType type_, Vector3 pos_, Color color_, float size_ = _debugPointDefaultSize )
			{
				type = type_;
				pos = pos_;
				color = color_;
				size = size_;
			}
		}

		[System.NonSerialized]
		public Dictionary<string, DebugValue> _debugValues = new Dictionary<string, DebugValue>();
		[System.NonSerialized]
		public List<DebugPoint> _debugPoints = new List<DebugPoint>();

		void OnDestroy()
		{
			_instances.Remove( this.gameObject );
		}

		static Dictionary<GameObject, DebugUtility> _instances = new Dictionary<GameObject, DebugUtility>();

		void OnDrawGizmos()
		{
			for( int i = 0; i != _debugPoints.Count; ++i ) {
				DebugPoint debugPoint = _debugPoints[i];
				Gizmos.color = debugPoint.color;
                switch( debugPoint.type ) {
				case DebugPointType.Cube:
					Gizmos.DrawCube( debugPoint.pos, new Vector3( debugPoint.size, debugPoint.size, debugPoint.size ) );
					break;
				case DebugPointType.Sphere:
					Gizmos.DrawSphere( debugPoint.pos, debugPoint.size );
					break;
				case DebugPointType.WireCube:
					Gizmos.DrawWireCube( debugPoint.pos, new Vector3( debugPoint.size, debugPoint.size, debugPoint.size ) );
					break;
				case DebugPointType.WireSphere:
					Gizmos.DrawWireSphere( debugPoint.pos, debugPoint.size );
					break;
				}
			}
		}
#endif
	}
}