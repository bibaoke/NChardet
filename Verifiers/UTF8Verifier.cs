﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2006-12-16
 * Time: 1:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace NChardet
{
	/// <summary>
	/// Description of UTF8Verifier.
	/// </summary>
	public sealed class UTF8Verifier : Verifier
	{
		static int[]  _cclass   ; 
	 	static int[]  _states   ; 
	 	static int    _stFactor ; 
	 	static string _charset  ; 

	 	public override int[]  cclass()   { return _cclass ;   }
	 	public override int[]  states()   { return _states ;   }
	 	public override int    stFactor() { return _stFactor ; }
	 	public override string charset()  { return _charset ;  }
	 	
		public UTF8Verifier()
		{
			_cclass = new int[256/8] ;
			_cclass[0] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[1] = ((int)(((  ((int)(((  ((int)((( 0) << 4) | (0)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[2] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[3] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((0) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[4] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[5] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[6] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[7] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[8] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[9] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[10] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[11] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[12] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[13] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[14] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[15] = ((int)(((  ((int)(((  ((int)((( 1) << 4) | (1)))  ) << 8) | (((int)(((1) << 4) | ( 1))) ))) ) << 16) | (  ((int)(((  ((int)(((1) << 4) | (1))) ) << 8) | (   ((int)(((1) << 4) | (1))) )))))) ;
      		_cclass[16] = ((int)(((  ((int)(((  ((int)((( 3) << 4) | (3)))  ) << 8) | (((int)(((3) << 4) | ( 3))) ))) ) << 16) | (  ((int)(((  ((int)(((2) << 4) | (2))) ) << 8) | (   ((int)(((2) << 4) | (2))) )))))) ;
      		_cclass[17] = ((int)(((  ((int)(((  ((int)((( 4) << 4) | (4)))  ) << 8) | (((int)(((4) << 4) | ( 4))) ))) ) << 16) | (  ((int)(((  ((int)(((4) << 4) | (4))) ) << 8) | (   ((int)(((4) << 4) | (4))) )))))) ;
      		_cclass[18] = ((int)(((  ((int)(((  ((int)((( 4) << 4) | (4)))  ) << 8) | (((int)(((4) << 4) | ( 4))) ))) ) << 16) | (  ((int)(((  ((int)(((4) << 4) | (4))) ) << 8) | (   ((int)(((4) << 4) | (4))) )))))) ;
      		_cclass[19] = ((int)(((  ((int)(((  ((int)((( 4) << 4) | (4)))  ) << 8) | (((int)(((4) << 4) | ( 4))) ))) ) << 16) | (  ((int)(((  ((int)(((4) << 4) | (4))) ) << 8) | (   ((int)(((4) << 4) | (4))) )))))) ;
      		_cclass[20] = ((int)(((  ((int)(((  ((int)((( 5) << 4) | (5)))  ) << 8) | (((int)(((5) << 4) | ( 5))) ))) ) << 16) | (  ((int)(((  ((int)(((5) << 4) | (5))) ) << 8) | (   ((int)(((5) << 4) | (5))) )))))) ;
      		_cclass[21] = ((int)(((  ((int)(((  ((int)((( 5) << 4) | (5)))  ) << 8) | (((int)(((5) << 4) | ( 5))) ))) ) << 16) | (  ((int)(((  ((int)(((5) << 4) | (5))) ) << 8) | (   ((int)(((5) << 4) | (5))) )))))) ;
      		_cclass[22] = ((int)(((  ((int)(((  ((int)((( 5) << 4) | (5)))  ) << 8) | (((int)(((5) << 4) | ( 5))) ))) ) << 16) | (  ((int)(((  ((int)(((5) << 4) | (5))) ) << 8) | (   ((int)(((5) << 4) | (5))) )))))) ;
      		_cclass[23] = ((int)(((  ((int)(((  ((int)((( 5) << 4) | (5)))  ) << 8) | (((int)(((5) << 4) | ( 5))) ))) ) << 16) | (  ((int)(((  ((int)(((5) << 4) | (5))) ) << 8) | (   ((int)(((5) << 4) | (5))) )))))) ;
      		_cclass[24] = ((int)(((  ((int)(((  ((int)((( 6) << 4) | (6)))  ) << 8) | (((int)(((6) << 4) | ( 6))) ))) ) << 16) | (  ((int)(((  ((int)(((6) << 4) | (6))) ) << 8) | (   ((int)(((0) << 4) | (0))) )))))) ;
      		_cclass[25] = ((int)(((  ((int)(((  ((int)((( 6) << 4) | (6)))  ) << 8) | (((int)(((6) << 4) | ( 6))) ))) ) << 16) | (  ((int)(((  ((int)(((6) << 4) | (6))) ) << 8) | (   ((int)(((6) << 4) | (6))) )))))) ;
      		_cclass[26] = ((int)(((  ((int)(((  ((int)((( 6) << 4) | (6)))  ) << 8) | (((int)(((6) << 4) | ( 6))) ))) ) << 16) | (  ((int)(((  ((int)(((6) << 4) | (6))) ) << 8) | (   ((int)(((6) << 4) | (6))) )))))) ;
      		_cclass[27] = ((int)(((  ((int)(((  ((int)((( 6) << 4) | (6)))  ) << 8) | (((int)(((6) << 4) | ( 6))) ))) ) << 16) | (  ((int)(((  ((int)(((6) << 4) | (6))) ) << 8) | (   ((int)(((6) << 4) | (6))) )))))) ;
      		_cclass[28] = ((int)(((  ((int)(((  ((int)((( 8) << 4) | (8)))  ) << 8) | (((int)(((8) << 4) | ( 8))) ))) ) << 16) | (  ((int)(((  ((int)(((8) << 4) | (8))) ) << 8) | (   ((int)(((8) << 4) | (7))) )))))) ;
      		_cclass[29] = ((int)(((  ((int)(((  ((int)((( 8) << 4) | (8)))  ) << 8) | (((int)(((9) << 4) | ( 8))) ))) ) << 16) | (  ((int)(((  ((int)(((8) << 4) | (8))) ) << 8) | (   ((int)(((8) << 4) | (8))) )))))) ;
      		_cclass[30] = ((int)(((  ((int)(((  ((int)((( 11) << 4) | (11)))  ) << 8) | (((int)(((11) << 4) | ( 11))) ))) ) << 16) | (  ((int)(((  ((int)(((11) << 4) | (11))) ) << 8) | (   ((int)(((11) << 4) | (10))) )))))) ;
      		_cclass[31] = ((int)(((  ((int)(((  ((int)((( 0) << 4) | (0)))  ) << 8) | (((int)(((15) << 4) | ( 14))) ))) ) << 16) | (  ((int)(((  ((int)(((13) << 4) | (13))) ) << 8) | (   ((int)(((13) << 4) | (12))) )))))) ;

      		_states = new int[26] ;
      		_states[0] = ((int)(((  ((int)(((  ((int)(((      10) << 4) | (     12)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eStart) << 4) | (eError))) )))))) ;
      		_states[1] = ((int)(((  ((int)(((  ((int)(((      3) << 4) | (     4)))  ) << 8) | (((int)(((     5) << 4) | (      6))) ))) ) << 16) | (  ((int)(((  ((int)(((     7) << 4) | (     8))) ) << 8) | (   ((int)(((     11) << 4) | (     9))) )))))) ;
      		_states[2] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[3] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[4] = ((int)(((  ((int)(((  ((int)((( eItsMe) << 4) | (eItsMe)))  ) << 8) | (((int)(((eItsMe) << 4) | ( eItsMe))) ))) ) << 16) | (  ((int)(((  ((int)(((eItsMe) << 4) | (eItsMe))) ) << 8) | (   ((int)(((eItsMe) << 4) | (eItsMe))) )))))) ;
      		_states[5] = ((int)(((  ((int)(((  ((int)((( eItsMe) << 4) | (eItsMe)))  ) << 8) | (((int)(((eItsMe) << 4) | ( eItsMe))) ))) ) << 16) | (  ((int)(((  ((int)(((eItsMe) << 4) | (eItsMe))) ) << 8) | (   ((int)(((eItsMe) << 4) | (eItsMe))) )))))) ;
      		_states[6] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     5) << 4) | (      5))) ))) ) << 16) | (  ((int)(((  ((int)(((     5) << 4) | (     5))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[7] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[8] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     5) << 4) | (      5))) ))) ) << 16) | (  ((int)(((  ((int)(((     5) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[9] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[10] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     7) << 4) | (      7))) ))) ) << 16) | (  ((int)(((  ((int)(((     7) << 4) | (     7))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[11] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[12] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     7) << 4) | (      7))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[13] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[14] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     9) << 4) | (      9))) ))) ) << 16) | (  ((int)(((  ((int)(((     9) << 4) | (     9))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[15] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[16] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     9) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[17] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[18] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     12) << 4) | (      12))) ))) ) << 16) | (  ((int)(((  ((int)(((     12) << 4) | (     12))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[19] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[20] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((     12) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[21] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[22] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | (      12))) ))) ) << 16) | (  ((int)(((  ((int)(((     12) << 4) | (     12))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[23] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[24] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eStart) << 4) | ( eStart))) ))) ) << 16) | (  ((int)(((  ((int)(((eStart) << 4) | (eStart))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		_states[25] = ((int)(((  ((int)(((  ((int)((( eError) << 4) | (eError)))  ) << 8) | (((int)(((eError) << 4) | ( eError))) ))) ) << 16) | (  ((int)(((  ((int)(((eError) << 4) | (eError))) ) << 8) | (   ((int)(((eError) << 4) | (eError))) )))))) ;
      		
      		_charset =  "UTF-8";
      		_stFactor =  16;
		}
		
		public override bool isUCS2() { return  false; }
	}
}