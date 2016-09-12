using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class MorseCode {

	static long[] A = { 0, 1, 1, 3 }; //dot dash
	static long[] B = { 0, 3, 1, 1, 1, 1, 1, 1}; //dash dot dot dot
	static long[] C = { 0, 3, 1, 1, 1, 3, 1, 1}; //dash dot dash dot
	static long[] D = { 0, 3, 1, 1, 1, 1}; //dash dot dot
	static long[] E = { 0, 1}; //dot
	static long[] F = { 0, 1, 1, 1, 1, 3, 1, 1}; //dot dot dash dot
	static long[] G = { 0, 3, 1, 3, 1, 1}; //dash dash dot
	static long[] H = { 0, 1, 1, 1, 1, 1, 1, 1}; //dot dot dot dot
	static long[] I = { 0, 1, 1, 1}; //dot dot
	static long[] J = { 0, 1, 1, 3, 1, 3, 1, 3}; //dot dash dash dash
	static long[] K = { 0, 3, 1, 1, 1, 3}; //dash dot dash
	static long[] L = { 0, 1, 1, 3, 1, 1, 1, 1}; //dot dash dot dot
	static long[] M = { 0, 3, 1, 3}; //dash dash
	static long[] N = { 0, 3, 1, 1}; //dash dot
	static long[] O = { 0, 3, 1, 3, 1, 3}; //dash dash dash
	static long[] P = { 0, 1, 1, 3, 1, 3, 1, 1}; //dot dash dash dot
	static long[] Q = { 0, 3, 1, 3, 1, 1, 1, 3}; //dash dash dot dash
	static long[] R = { 0, 1, 1, 3, 1, 1}; //dot dash dot
	static long[] S = { 0, 1, 1, 1, 1, 1}; //dot dot dot
	static long[] T = { 0, 3}; //dash
	static long[] U = { 0, 1, 1, 1, 1, 3}; //dot dot dash
	static long[] V = { 0, 1, 1, 1, 1, 1, 1, 3}; //dot dot dot dash
	static long[] W = { 0, 1, 1, 3, 1, 3}; //dot dash dash
	static long[] X = { 0, 3, 1, 1, 1, 1, 1, 3}; //dash dot dot dash
	static long[] Y = { 0, 3, 1, 1, 1, 3, 1, 3}; //dash dot dash dash
	static long[] Z = { 0, 3, 1, 3, 1, 1, 1, 1}; //dash dash dot dot

	public static long[] GetPattern(char letter){
        return null;
	}
}
