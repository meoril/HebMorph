﻿/***************************************************************************
 *   Copyright (C) 2010 by                                                 *
 *      Itamar Syn-Hershko <itamar at code972 dot com>                     *
 *                                                                         *
 *   Distributed under the GNU General Public License, Version 2.0.        *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation (v2).                                    *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   51 Franklin Steet, Fifth Floor, Boston, MA  02111-1307, USA.          *
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace HebMorph.HSpell
{
    internal sealed class Constants
    {
        public const string DictionaryFile = "hebrew.wgz";
        public const string PrefixesFile = DictionaryFile + ".prefixes";
        public const string StemsFile = DictionaryFile + ".stems";
        public const string DescFile = DictionaryFile + ".desc";
        public const string SizesFile = DictionaryFile + ".sizes";
        public const byte MaxWordLength = 255;

        #region dmask.c
        // Taken from HSpell's dmask.c, which is being auto-generated by a Perl script
        // TODO: Since this is being used in conjunction with a data file (.desc), it is actually quite
        // wrong to have this compiled in code and not loaded from an external file
        public static readonly int[] dmasks = {
            69,
            131141,
            41029,
            106565,
            51269,
            53317,
            116805,
            118853,
            59461,
            61509,
            127045,
            124997,
            197,
            131269,
            41157,
            106693,
            51397,
            53445,
            116933,
            118981,
            59589,
            61637,
            127173,
            125125,
            73,
            131145,
            41033,
            106569,
            51273,
            53321,
            116809,
            118857,
            59465,
            61513,
            127049,
            125001,
            201,
            131273,
            41161,
            106697,
            51401,
            53449,
            116937,
            118985,
            59593,
            61641,
            127177,
            125129,
            71,
            131143,
            199,
            131271,
            75,
            131147,
            203,
            131275,
            77,
            131149,
            41037,
            106573,
            51277,
            53325,
            116813,
            118861,
            59469,
            61517,
            127053,
            125005,
            205,
            131277,
            41165,
            106701,
            51405,
            53453,
            116941,
            118989,
            59597,
            61645,
            127181,
            125133,
            262153,
            630,
            594,
            614,
            618,
            634,
            722,
            742,
            746,
            758,
            762,
            258,
            41218,
            51458,
            53506,
            59650,
            61698,
            106754,
            116994,
            119042,
            125186,
            127234,
            42498,
            1382,
            1386,
            1510,
            1514,
            1106,
            1126,
            1130,
            1142,
            1146,
            1234,
            1254,
            1258,
            1270,
            1274,
            838,
            131910,
            842,
            131914,
            966,
            132038,
            970,
            132042,
            52738,
            60930,
            62978,
            108034,
            118274,
            120322,
            126466,
            128514,
            1538,
            0,
            67,
            65,
            2,
            262145,
            262149,
            262213,
            1,
            193,
            5,
            131137,
            262209,
            131073,
            3,
            834,
            770,
            962,
            131906,
            131842,
            132034
        };
        #endregion

        #region prefixes.c
        public static string[] prefixes_noH ={/*"",*/
"ב",
"בכ",
"ה",
"ו",
"וב",
"ובכ",
"וה",
"וכ",
"וכב",
"וככ",
"וכל",
"וכמ",
"וכמה",
"וכש",
"וכשב",
"וכשבכ",
"וכשה",
"וכשכ",
"וכשכב",
"וכשככ",
"וכשכל",
"וכשכמ",
"וכשכמה",
"וכשל",
"וכשלכ",
"וכשמ",
"וכשמה",
"וכשמכ",
"ול",
"ולכ",
"ולכש",
"ולכשב",
"ולכשבכ",
"ולכשה",
"ולכשכ",
"ולכשכב",
"ולכשככ",
"ולכשכל",
"ולכשכמ",
"ולכשכמה",
"ולכשל",
"ולכשלכ",
"ולכשמ",
"ולכשמה",
"ולכשמכ",
"ומ",
"ומה",
"ומכ",
"ומש",
"ומשב",
"ומשבכ",
"ומשה",
"ומשכ",
"ומשכב",
"ומשככ",
"ומשכל",
"ומשכמ",
"ומשכמה",
"ומשל",
"ומשלכ",
"ומשמ",
"ומשמה",
"ומשמכ",
"וש",
"ושב",
"ושבכ",
"ושה",
"ושכ",
"ושכב",
"ושככ",
"ושכל",
"ושכמ",
"ושכמה",
"ושכש",
"ושכשב",
"ושכשבכ",
"ושכשה",
"ושכשכ",
"ושכשכב",
"ושכשככ",
"ושכשכל",
"ושכשכמ",
"ושכשכמה",
"ושכשל",
"ושכשלכ",
"ושכשמ",
"ושכשמה",
"ושכשמכ",
"ושל",
"ושלכ",
"ושלכש",
"ושלכשב",
"ושלכשבכ",
"ושלכשה",
"ושלכשכ",
"ושלכשכב",
"ושלכשככ",
"ושלכשכל",
"ושלכשכמ",
"ושלכשכמה",
"ושלכשל",
"ושלכשלכ",
"ושלכשמ",
"ושלכשמה",
"ושלכשמכ",
"ושמ",
"ושמה",
"ושמכ",
"ושמש",
"ושמשב",
"ושמשבכ",
"ושמשה",
"ושמשכ",
"ושמשכב",
"ושמשככ",
"ושמשכל",
"ושמשכמ",
"ושמשכמה",
"ושמשל",
"ושמשלכ",
"ושמשמ",
"ושמשמה",
"ושמשמכ",
"כ",
"כב",
"ככ",
"כל",
"כמ",
"כמה",
"כש",
"כשב",
"כשבכ",
"כשה",
"כשכ",
"כשכב",
"כשככ",
"כשכל",
"כשכמ",
"כשכמה",
"כשל",
"כשלכ",
"כשמ",
"כשמה",
"כשמכ",
"ל",
"לכ",
"לכש",
"לכשב",
"לכשבכ",
"לכשה",
"לכשכ",
"לכשכב",
"לכשככ",
"לכשכל",
"לכשכמ",
"לכשכמה",
"לכשל",
"לכשלכ",
"לכשמ",
"לכשמה",
"לכשמכ",
"מ",
"מב",
"מה",
"מכ",
"מל",
"מש",
"משב",
"משבכ",
"משה",
"משכ",
"משכב",
"משככ",
"משכל",
"משכמ",
"משכמה",
"משל",
"משלכ",
"משמ",
"משמה",
"משמכ",
"ש",
"שב",
"שבכ",
"שה",
"שכ",
"שכב",
"שככ",
"שכל",
"שכמ",
"שכמה",
"שכש",
"שכשב",
"שכשבכ",
"שכשה",
"שכשכ",
"שכשכב",
"שכשככ",
"שכשכל",
"שכשכמ",
"שכשכמה",
"שכשל",
"שכשלכ",
"שכשמ",
"שכשמה",
"שכשמכ",
"של",
"שלכ",
"שלכש",
"שלכשב",
"שלכשבכ",
"שלכשה",
"שלכשכ",
"שלכשכב",
"שלכשככ",
"שלכשכל",
"שלכשכמ",
"שלכשכמה",
"שלכשל",
"שלכשלכ",
"שלכשמ",
"שלכשמה",
"שלכשמכ",
"שמ",
"שמה",
"שמכ",
"שמש",
"שמשב",
"שמשבכ",
"שמשה",
"שמשכ",
"שמשכב",
"שמשככ",
"שמשכל",
"שמשכמ",
"שמשכמה",
"שמשל",
"שמשלכ",
"שמשמ",
"שמשמה",
"שמשמכ", null};
        public static int[] masks_noH ={/*60,*/
43,
42,
32,
60,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
-1};
        public static string[] prefixes_H ={/*"",*/
"ב",
"בכ",
"ה",
"הב",
"הבכ",
"הה",
"הכ",
"הכב",
"הככ",
"הכל",
"הכמ",
"הכמה",
"הכש",
"הכשב",
"הכשבכ",
"הכשה",
"הכשכ",
"הכשכב",
"הכשככ",
"הכשכל",
"הכשכמ",
"הכשכמה",
"הכשל",
"הכשלכ",
"הכשמ",
"הכשמה",
"הכשמכ",
"הל",
"הלכ",
"הלכש",
"הלכשב",
"הלכשבכ",
"הלכשה",
"הלכשכ",
"הלכשכב",
"הלכשככ",
"הלכשכל",
"הלכשכמ",
"הלכשכמה",
"הלכשל",
"הלכשלכ",
"הלכשמ",
"הלכשמה",
"הלכשמכ",
"המ",
"המה",
"המכ",
"המש",
"המשב",
"המשבכ",
"המשה",
"המשכ",
"המשכב",
"המשככ",
"המשכל",
"המשכמ",
"המשכמה",
"המשל",
"המשלכ",
"המשמ",
"המשמה",
"המשמכ",
"ו",
"וב",
"ובכ",
"וה",
"והב",
"והבכ",
"והה",
"והכ",
"והכב",
"והככ",
"והכל",
"והכמ",
"והכמה",
"והכש",
"והכשב",
"והכשבכ",
"והכשה",
"והכשכ",
"והכשכב",
"והכשככ",
"והכשכל",
"והכשכמ",
"והכשכמה",
"והכשל",
"והכשלכ",
"והכשמ",
"והכשמה",
"והכשמכ",
"והל",
"והלכ",
"והלכש",
"והלכשב",
"והלכשבכ",
"והלכשה",
"והלכשכ",
"והלכשכב",
"והלכשככ",
"והלכשכל",
"והלכשכמ",
"והלכשכמה",
"והלכשל",
"והלכשלכ",
"והלכשמ",
"והלכשמה",
"והלכשמכ",
"והמ",
"והמה",
"והמכ",
"והמש",
"והמשב",
"והמשבכ",
"והמשה",
"והמשכ",
"והמשכב",
"והמשככ",
"והמשכל",
"והמשכמ",
"והמשכמה",
"והמשל",
"והמשלכ",
"והמשמ",
"והמשמה",
"והמשמכ",
"וכ",
"וכב",
"וככ",
"וכל",
"וכמ",
"וכמה",
"וכש",
"וכשב",
"וכשבכ",
"וכשה",
"וכשכ",
"וכשכב",
"וכשככ",
"וכשכל",
"וכשכמ",
"וכשכמה",
"וכשל",
"וכשלכ",
"וכשמ",
"וכשמה",
"וכשמכ",
"ול",
"ולכ",
"ולכש",
"ולכשב",
"ולכשבכ",
"ולכשה",
"ולכשכ",
"ולכשכב",
"ולכשככ",
"ולכשכל",
"ולכשכמ",
"ולכשכמה",
"ולכשל",
"ולכשלכ",
"ולכשמ",
"ולכשמה",
"ולכשמכ",
"ומ",
"ומה",
"ומכ",
"ומש",
"ומשב",
"ומשבכ",
"ומשה",
"ומשכ",
"ומשכב",
"ומשככ",
"ומשכל",
"ומשכמ",
"ומשכמה",
"ומשל",
"ומשלכ",
"ומשמ",
"ומשמה",
"ומשמכ",
"וש",
"ושב",
"ושבכ",
"ושה",
"ושכ",
"ושכב",
"ושככ",
"ושכל",
"ושכמ",
"ושכמה",
"ושכש",
"ושכשב",
"ושכשבכ",
"ושכשה",
"ושכשכ",
"ושכשכב",
"ושכשככ",
"ושכשכל",
"ושכשכמ",
"ושכשכמה",
"ושכשל",
"ושכשלכ",
"ושכשמ",
"ושכשמה",
"ושכשמכ",
"ושל",
"ושלכ",
"ושלכש",
"ושלכשב",
"ושלכשבכ",
"ושלכשה",
"ושלכשכ",
"ושלכשכב",
"ושלכשככ",
"ושלכשכל",
"ושלכשכמ",
"ושלכשכמה",
"ושלכשל",
"ושלכשלכ",
"ושלכשמ",
"ושלכשמה",
"ושלכשמכ",
"ושמ",
"ושמה",
"ושמכ",
"ושמש",
"ושמשב",
"ושמשבכ",
"ושמשה",
"ושמשכ",
"ושמשכב",
"ושמשככ",
"ושמשכל",
"ושמשכמ",
"ושמשכמה",
"ושמשל",
"ושמשלכ",
"ושמשמ",
"ושמשמה",
"ושמשמכ",
"כ",
"כב",
"ככ",
"כל",
"כמ",
"כמה",
"כש",
"כשב",
"כשבכ",
"כשה",
"כשכ",
"כשכב",
"כשככ",
"כשכל",
"כשכמ",
"כשכמה",
"כשל",
"כשלכ",
"כשמ",
"כשמה",
"כשמכ",
"ל",
"לכ",
"לכש",
"לכשב",
"לכשבכ",
"לכשה",
"לכשכ",
"לכשכב",
"לכשככ",
"לכשכל",
"לכשכמ",
"לכשכמה",
"לכשל",
"לכשלכ",
"לכשמ",
"לכשמה",
"לכשמכ",
"מ",
"מב",
"מה",
"מכ",
"מל",
"מש",
"משב",
"משבכ",
"משה",
"משכ",
"משכב",
"משככ",
"משכל",
"משכמ",
"משכמה",
"משל",
"משלכ",
"משמ",
"משמה",
"משמכ",
"ש",
"שב",
"שבכ",
"שה",
"שכ",
"שכב",
"שככ",
"שכל",
"שכמ",
"שכמה",
"שכש",
"שכשב",
"שכשבכ",
"שכשה",
"שכשכ",
"שכשכב",
"שכשככ",
"שכשכל",
"שכשכמ",
"שכשכמה",
"שכשל",
"שכשלכ",
"שכשמ",
"שכשמה",
"שכשמכ",
"של",
"שלכ",
"שלכש",
"שלכשב",
"שלכשבכ",
"שלכשה",
"שלכשכ",
"שלכשכב",
"שלכשככ",
"שלכשכל",
"שלכשכמ",
"שלכשכמה",
"שלכשל",
"שלכשלכ",
"שלכשמ",
"שלכשמה",
"שלכשמכ",
"שמ",
"שמה",
"שמכ",
"שמש",
"שמשב",
"שמשבכ",
"שמשה",
"שמשכ",
"שמשכב",
"שמשככ",
"שמשכל",
"שמשכמ",
"שמשכמה",
"שמשל",
"שמשלכ",
"שמשמ",
"שמשמה",
"שמשמכ", null};
        public static int[] masks_H ={/*60,*/
43,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
60,
43,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
-1};
        #endregion
    }

    [Flags]
    public enum DMask : int
    {
        D_NOUN = 1,
        D_VERB = 2,
        D_ADJ = 3,
        D_TYPEMASK = 3,
        D_GENDERBASE = 4,
        D_MASCULINE = 4,
        D_FEMININE = 8,
        D_GENDERMASK = 12,
        D_GUFBASE = 16,
        D_FIRST = 16,
        D_SECOND = 32,
        D_THIRD = 48,
        D_GUFMASK = 48,
        D_NUMBASE = 64,
        D_SINGULAR = 64,
        D_DOUBLE = 128,
        D_PLURAL = 192,
        D_NUMMASK = 192,
        D_TENSEBASE = 256,
        D_INFINITIVE = 256,
        D_BINFINITIVE = 1536,
        D_PAST = 512,
        D_PRESENT = 768,
        D_FUTURE = 1024,
        D_IMPERATIVE = 1280,
        D_TENSEMASK = 1792,
        D_OGENDERBASE = 2048,
        D_OMASCULINE = 2048,
        D_OFEMININE = 4096,
        D_OGENDERMASK = 6144,
        D_OGUFBASE = 8192,
        D_OFIRST = 8192,
        D_OSECOND = 16384,
        D_OTHIRD = 24576,
        D_OGUFMASK = 24576,
        D_ONUMBASE = 32768,
        D_OSINGULAR = 32768,
        D_ODOUBLE = 65536,
        D_OPLURAL = 98304,
        D_ONUMMASK = 98304,
        D_OMASK = 129024,
        D_OSMICHUT = 131072,
        D_SPECNOUN = 262144,
        D_STARTBIT = 524288,
    }

    [Flags]
    public enum PrefixType : byte
    {
        PS_ALL = 63,
        PS_B = 1,
        PS_L = 2,
        PS_VERB = 4,
        PS_NONDEF = 8,
        PS_IMPER = 16,
        PS_MISC = 32,
    }
}
